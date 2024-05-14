using System.Net;
using System.Net.Sockets;
using System.Text;

namespace lab03
{
    public partial class FormBai_3_Server : Form
    {
        public FormBai_3_Server()
        {
            InitializeComponent();
        }

        TcpListener server;
        TcpClient client;
        NetworkStream stream;

        private async void btnListen_Click(object sender, EventArgs e)
        {
            btnListen.Enabled = false;
            server = new TcpListener(IPAddress.Parse("127.0.0.1"), 8080);

            server.Start();

            lbChat.Items.Add("Server started!");

            client = await server.AcceptTcpClientAsync();
            lbChat.Items.Add("Connection accepted from" + server.LocalEndpoint);

            stream = client.GetStream();
            byte[] buffer = new byte[client.ReceiveBufferSize];
            int bytesRead;

            while (client.Connected)
            {
                bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length);
                if (bytesRead == 0)
                {
                    break;
                }
                string mess = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                lbChat.Items.Add("From client: " + mess);
            }
            lbChat.Items.Add("Client disconnected!... ");
            if (client != null) { client.Close(); }
            if (stream != null) { stream.Close(); }
            server.Stop();
            btnListen.Enabled = true;
        }

        private void FormBai_3_Server_Leave(object sender, EventArgs e)
        {
            server.Stop();
            client.Close();
            stream.Close();
        }
    }
}
