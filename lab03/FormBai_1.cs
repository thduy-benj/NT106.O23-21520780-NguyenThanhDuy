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
    public partial class FormBai_1 : Form
    {
        public FormBai_1()
        {
            InitializeComponent();
        }

        private void btnUDPserver_Click(object sender, EventArgs e)
        {
            FormBai_1_server formBai_1 = new FormBai_1_server();
            formBai_1.Show();
        }

        private void btnUDPclient_Click(object sender, EventArgs e)
        {
            FormBai_1_client formBai_1= new FormBai_1_client();
            formBai_1.Show();
        }
    }
}
