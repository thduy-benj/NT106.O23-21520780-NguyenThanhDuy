using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab01
{
    public partial class FormBai8 : Form
    {
        public FormBai8()
        {
            InitializeComponent();
        }

        List<String> dsMonAn = new List<String>();
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbNhap.Text))
            {
                MessageBox.Show("Hãy nhập tên món ăn!");
                return;
            }

            dsMonAn.Append(tbNhap.Text);
            rtbMon.Text += tbNhap.Text + "\n";
            tbNhap.Text = string.Empty;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            rtbMon.Text = string.Empty;
            tbNhap.Text = string.Empty;
            tbKetQua.Text = string.Empty;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rtbMon_TextChanged(object sender, EventArgs e)
        {
            dsMonAn = rtbMon.Text.Split('\n').ToList();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(rtbMon.Text))
            {
                MessageBox.Show("Chưa nhập món ăn");
                return;
            }

            Random random = new Random();
            int i = random.Next(dsMonAn.Count()-1);
            tbKetQua.Text = dsMonAn[i];

        }
    }
}
