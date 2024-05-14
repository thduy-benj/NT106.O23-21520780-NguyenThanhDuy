using System.Net.Sockets;
using System.Net;
using System.Text;

namespace lab03
{
    public partial class FormBai_4_Server : Form
    {
        public FormBai_4_Server()
        {
            InitializeComponent();
        }

        TcpListener server;
        List<TcpClient> connectedClients = new List<TcpClient>();

        private async void btnListen_Click(object sender, EventArgs e)
        {
            server = new TcpListener(IPAddress.Parse("127.0.0.1"), 9000);
            server.Start();
            lbLog.Items.Add("Server started!");
            while (true)
            {
                TcpClient client = await server.AcceptTcpClientAsync();
                connectedClients.Add(client);
                lbLog.Items.Add("Connection accepted from " + client.Client.RemoteEndPoint);

                Thread clientThread = new Thread(() => HandleClient(client));
                clientThread.Start();
            }
        }

        private void HandleClient(TcpClient client)
        {
            NetworkStream stream = client.GetStream();
            byte[] buffer = new byte[client.ReceiveBufferSize];
            int bytesRead;

            while (client.Connected)
            {
                bytesRead = stream.Read(buffer, 0, buffer.Length);
                if (bytesRead == 0)
                {
                    break;
                }
                string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                lbLog.Items.Add(message);
                Broadcast(message);
                //// Code broadcast tin nhắn đến các client khác

                ////// Ví dụ: Gửi phản hồi cho client đã gửi tin nhắn
                //byte[] responseBuffer = Encoding.UTF8.GetBytes("Server received your message");
                //stream.Write(responseBuffer, 0, responseBuffer.Length);

            }

            lbLog.Items.Add("Client disconnected: " + client.Client.RemoteEndPoint);
            connectedClients.Remove(client);
            client.Close();
            server.Stop();
            stream.Close();
            btnListen.Enabled = true;
        }

        private void Broadcast(string message)
        {
            byte[] messageBuffer = Encoding.UTF8.GetBytes(message);

            foreach (TcpClient client in connectedClients)
            {
                NetworkStream stream = client.GetStream();
                stream.Write(messageBuffer, 0, messageBuffer.Length);
            }
        }

        private void FormBai_4_Server_Leave(object sender, EventArgs e)
        {
            server.Stop();
        }
    }
}
