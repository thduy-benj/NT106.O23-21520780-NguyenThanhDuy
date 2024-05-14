using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab03
{
    public partial class FormBai_1_client : Form
    {
        public FormBai_1_client()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            int port;
            IPAddress ip;
            if (!int.TryParse(tbPort.Text, out port) || !IPAddress.TryParse(tbIP.Text, out ip))
            {
                MessageBox.Show("Vui lòng nhập lại ip hoặc port.");
            }
            else if (string.IsNullOrEmpty(tbMessage.Text))
            {
                MessageBox.Show("Vui lòng nhập tin nhắn!");
            }
            else
            {
                UdpClient udpClient = new UdpClient();
                Byte[] sendBytes = Encoding.UTF8.GetBytes(tbMessage.Text);
                udpClient.Send(sendBytes, sendBytes.Length, tbIP.Text, port);
                tbMessage.Clear();
            }
        }
    }
}
