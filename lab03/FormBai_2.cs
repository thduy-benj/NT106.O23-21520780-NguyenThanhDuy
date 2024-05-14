using System.Net.Sockets;
using System.Net;
using System.Text;

namespace lab03
{
    public partial class FormBai_2 : Form
    {
        public FormBai_2()
        {
            InitializeComponent();
        }

        private void btnListen_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Thread server = new Thread(new ThreadStart(StartUnsafeThread));
            tbMessage.Text += "Start Listening!...\r\n";
            server.Start();
            server.IsBackground = true;
        }

        public async void StartUnsafeThread()
        {
            NetworkStream stream;
            byte[] buffer = new byte[1024];
            int bufferLength;

            Socket listenerSocket = new Socket(
                AddressFamily.InterNetwork, 
                SocketType.Stream, 
                ProtocolType.Tcp);
            IPEndPoint ipepServer = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
            listenerSocket.Bind(ipepServer);
            listenerSocket.Listen(-1);

            Socket client = listenerSocket.Accept();
            tbMessage.Text += "Telnet running on 127.0.0.1:8080! \n";
            stream = new NetworkStream(client);
            while (client.Connected)
            {
                bufferLength = stream.Read(buffer, 0, buffer.Length);
                string data = Encoding.UTF8.GetString(buffer, 0, bufferLength);
                tbMessage.Text += data;
            }
            listenerSocket.Close();

        }
    }
}
