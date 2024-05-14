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
    public partial class FormBai_3 : Form
    {
        public FormBai_3()
        {
            InitializeComponent();
        }

        private void btnServer_Click(object sender, EventArgs e)
        {
            FormBai_3_Server server = new FormBai_3_Server();
            server.Show();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            FormBai_3_Client client = new FormBai_3_Client();
            client.Show();
        }
    }
}
