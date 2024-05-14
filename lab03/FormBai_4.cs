using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab03
{
    public partial class FormBai_4 : Form
    {
        public FormBai_4()
        {
            InitializeComponent();
        }

        private void btnServer_Click(object sender, EventArgs e)
        {
            FormBai_4_Server server = new FormBai_4_Server();
            server.Show();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            FormBai_4_Client client = new FormBai_4_Client();
            client.Show();
        }
    }
}
