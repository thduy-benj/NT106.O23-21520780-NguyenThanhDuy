using System.Net.Sockets;
using System.Net;
using System.Text;

namespace lab03
{
    public partial class FormBai_1_server : Form
    {
        public FormBai_1_server()
        {
            InitializeComponent();
        }

        public void serverThread()
        {
            int port;
            if (int.TryParse(tbPort.Text, out port))
            {
                UdpClient udpClient = new UdpClient(port);
                while (true)
                {
                    IPEndPoint ipe = new IPEndPoint(IPAddress.Any, 0);
                    Byte[] receiveByte = udpClient.Receive(ref ipe);
                    string returnData = Encoding.UTF8.GetString(receiveByte);
                    string mess = ipe.Address.ToString() + ": " + returnData.ToString();
                    lbMessage.Items.Add(mess);
                }

            }
            else
            {
                MessageBox.Show("vui lòng nhập port lại cho đúng!");
            }
        }

        private void btnListen_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Thread UDPserver = new Thread(new ThreadStart(serverThread));
            UDPserver.Start();
            UDPserver.IsBackground = true;
        }
    }
}
