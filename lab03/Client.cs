using System.Net.Sockets;
using System.Net;
using System.Text;

namespace lab03
{
    internal class Client
    {
        private IPAddress ip;
        private int port;
        private TcpClient clienttcp;
        private NetworkStream stream;

        public Client(IPAddress ip, int port)
        {
            this.ip = ip;
            this.port = port;
            this.clienttcp = new TcpClient();
        }
        public async void Connect()
        {
            try
            {
                await this.clienttcp.ConnectAsync(this.ip, this.port);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }
        public void SendMessage(string s)
        {
            this.stream = clienttcp.GetStream();
            byte[] mess = Encoding.UTF8.GetBytes(s);
            this.stream.Write(mess, 0, mess.Length);
        }
        public void Disconnected()
        {

            if (this.stream != null)
            {
                this.stream.Close();
            }
            if (this.clienttcp != null) this.clienttcp.Close();
        }
    }
}
