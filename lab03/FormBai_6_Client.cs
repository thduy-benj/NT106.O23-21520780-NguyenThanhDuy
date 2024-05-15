using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace lab03
{
    public partial class FormBai_6_Client : Form
    {
        public FormBai_6_Client()
        {
            InitializeComponent();
            btnDisconnect.Enabled = false;
            btnSend.Enabled = false;
        }

        private class Data
        {
            public string type { get; set; }
            public List<string> sendTo { get; set; }
            public string data { get; set; }

            public Data(string type, List<string> sendTo, string data)
            {
                this.type = type;
                this.sendTo = sendTo;
                this.data = data;
            }

            public override string ToString()
            {
                string result = "\nType: " + type + "\nSend to:";
                foreach (string client in sendTo)
                {
                    result += client + " ";
                }
                result += "\nMessage: " + data;
                return result;
            }
        }

        private TcpClient tcpClient;
        private NetworkStream stream;
        private List<string> ClientsName = new List<string>();
        private Dictionary<string, bool> clientList = new Dictionary<string, bool>();
        private async void btnConnect_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbUsrName.Text))
            {
                MessageBox.Show("Hãy nhập tên người dùng!!", "Error");
                return;
            }
            try
            {
                tcpClient = new TcpClient();
                await tcpClient.ConnectAsync("127.0.0.1", 9000);
                stream = tcpClient.GetStream();
                btnDisconnect.Enabled = true;
                btnSend.Enabled = true;

                Data data = new Data("info", ClientsName, tbUsrName.Text);
                string message = JsonSerializer.Serialize(data);
                byte[] buffer = Encoding.ASCII.GetBytes(message);
                stream.Write(buffer, 0, buffer.Length);

                btnConnect.Enabled = false;

                Thread receiveThread = new Thread(ReceiveMessages);
                receiveThread.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cant connect to server!!");
            }
        }

        private void ReceiveMessages()
        {
            byte[] buffer = new byte[tcpClient.ReceiveBufferSize];
            int bytesRead;
            while (tcpClient.Connected)
            {
                bytesRead = stream.Read(buffer, 0, buffer.Length);
                if (bytesRead == 0) { break; }
                string jsonMessage = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                Data data = JsonSerializer.Deserialize<Data>(jsonMessage);
                if (data.type.Equals("info"))
                {
                    ClientsName.Clear();
                    clbClients.Items.Clear();
                    foreach (var clients in data.sendTo)
                    {
                        ClientsName.Add(clients);
                        clbClients.Items.Add(clients, false);
                    }

                }
                if (data.type.Equals("message"))
                {
                    lbChat.Items.Add(data.data);
                }
            }
            tcpClient.Close();
            stream.Close();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbMessage.Text))
            {
                return;
            }

            List<string> sendTo = new List<string>();
            foreach(string client in clbClients.CheckedItems)
            {
                sendTo.Add(client);
            }

            Data data = new Data("message", sendTo, tbUsrName.Text + ": " + tbMessage.Text.Trim());
            String message = JsonSerializer.Serialize(data);

            byte[] buffer = Encoding.UTF8.GetBytes(message);
            stream.Write(buffer, 0, buffer.Length);
            tbMessage.Text = string.Empty;
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                tcpClient.Close();
                stream.Close();
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            lbChat.Items.Clear();
            tbMessage.Text = string.Empty;
        }
    }
}
