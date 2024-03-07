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
    public partial class FormBai2 : Form
    {
        public FormBai2()
        {
            InitializeComponent();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbSoThuNhat.Text))
            {
                MessageBox.Show("Nhập số thứ nhất");
                return;
            }
            if (String.IsNullOrEmpty(tbSoThuHai.Text))
            {
                MessageBox.Show("Nhập số thứ hai");
                return;
            }
            if (String.IsNullOrEmpty(tbSoThuBa.Text))
            {
                MessageBox.Show("Nhập số thứ ba");
                return;
            }
            double mot, hai, ba;
            if (double.TryParse(tbSoThuNhat.Text, out mot) == false)
            {
                MessageBox.Show("Sai định dạng");
                return;
            }
            if (double.TryParse(tbSoThuHai.Text, out hai) == false)
            {
                MessageBox.Show("Sai định dạng");
                return;
            }
            if (double.TryParse(tbSoThuBa.Text, out ba) == false)
            {
                MessageBox.Show("Sai định dạng");
                return;
            }

            double min = mot;
            double max = mot;

            if (max < hai)
            {
                max = hai;
            }

            if (max < ba)
            {
                max = ba;
            }

            if (min > hai)
            {
                min = hai;
            }

            if (min > ba)
            {
                min = ba;
            }

            tbSoLonNhat.Text = max.ToString();
            tbSoNhoNhat.Text = min.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            tbSoThuNhat.Text = "";
            tbSoThuHai.Text = "";
            tbSoThuBa.Text = "";

            tbSoNhoNhat.Text = "";
            tbSoLonNhat.Text = "";

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
