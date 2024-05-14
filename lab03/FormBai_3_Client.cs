using System.Net;

namespace lab03
{
    public partial class FormBai_3_Client : Form
    {
        public FormBai_3_Client()
        {
            InitializeComponent();
            btnDisconnect.Enabled = false;
        }
        Client client;
        private void btnConnect_Click(object sender, EventArgs e)
        {
            btnConnect.Enabled = false;
            btnDisconnect.Enabled = true;
            client = new Client(IPAddress.Parse("127.0.0.1"), 8080);
            client.Connect();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(rtbChat.Text))
            {
                MessageBox.Show("Hay dien thong tin muon gui");
                return;
            }

            client.SendMessage(rtbChat.Text);
            rtbChat.Text = string.Empty;
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            btnConnect.Enabled = true;
            btnDisconnect.Enabled = false;
            client.Disconnected();
        }
    }
}
