﻿using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Text.Json;

namespace lab03
{
    public partial class FormBai_6_Server : Form
    {
        public FormBai_6_Server()
        {
            InitializeComponent();
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

        private TcpListener server;
        // Lưu thông tin các client được kết nối vào dict để có thể tuỳ chọn client muốn gửi tin nhắn
        private Dictionary<string, TcpClient> connectedClients = new Dictionary<string, TcpClient>();
        private bool isConnect = true;
        private async void btnListen_Click(object sender, EventArgs e)
        {
            server = new TcpListener(IPAddress.Parse("127.0.0.1"), 9000);
            server.Start();
            lbLog.Items.Add("Server started!");
            while (isConnect)
            {
                TcpClient client = await server.AcceptTcpClientAsync();
                lbLog.Items.Add("Connection accepted from " + client.Client.RemoteEndPoint);
                
                Thread clientThread = new Thread(() => ReceiveClientMessage(client));
                clientThread.Start();
            }
        }

        /// <summary>
        /// Nhận các tin nhắn từ client và gửi đến những người được gửi 
        /// </summary>
        /// <param name="client"></param>
        private void ReceiveClientMessage(TcpClient client)
        {
            NetworkStream stream = client.GetStream();
            byte[] buffer = new byte[client.ReceiveBufferSize];
            int bytesRead;

            while (client.Connected)
            {
                bytesRead = stream.Read(buffer, 0, buffer.Length);
                if (bytesRead == 0) { break; }
                string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                Data data = JsonSerializer.Deserialize<Data>(message);
                if (data.type.Equals("info"))
                {
                    connectedClients.Add(data.data, client);
                }
                SendClientMessage(data);
            }
            isConnect = false;
            server.Stop();
        }

        /// <summary>
        /// Hàm gửi tin nhắn đến các client
        /// Nếu nhận được data về "info" thì thêm vào danh sách các client
        /// Nếu nhận được data về "message" thì đọc thông tin từ sendTo để
        /// gửi đến những người muốn gửi
        /// </summary>
        /// <param name="sendData"></param>
        private void SendClientMessage(Data sendData)
        {
            List<string> ClientsName = new List<string>();
            if (sendData.type.Equals("info"))
            {
                // Gửi "info" cho tất cả các client đã kết nối
                foreach (string client in connectedClients.Keys)
                {
                    ClientsName.Add(client);
                }
                Data data = new Data(sendData.type, ClientsName, sendData.data);
                String message = JsonSerializer.Serialize(data);
                byte[] messageBuffer = Encoding.UTF8.GetBytes(message);

                foreach (TcpClient client in connectedClients.Values)
                {
                    NetworkStream stream = client.GetStream();
                    stream.Write(messageBuffer, 0, messageBuffer.Length);
                }
            }
            else if (sendData.type.Equals("message"))
            {
                foreach (string client in sendData.sendTo)
                {
                    String message = JsonSerializer.Serialize(sendData);
                    byte[] messageBuffer = Encoding.UTF8.GetBytes(message);
                    TcpClient tcpClient = connectedClients[client];
                    NetworkStream stream = tcpClient.GetStream();
                    stream.Write(messageBuffer, 0, messageBuffer.Length);
                }
            }
        }
    }
}
