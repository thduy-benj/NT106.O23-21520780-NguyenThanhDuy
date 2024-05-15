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
    public partial class FormBai_6 : Form
    {
        public FormBai_6()
        {
            InitializeComponent();
        }

        private void btnServer_Click(object sender, EventArgs e)
        {
            FormBai_6_Server server = new FormBai_6_Server();
            server.Show();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            FormBai_6_Client client = new FormBai_6_Client();
            client.Show();
        }
    }
}
