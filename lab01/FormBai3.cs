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
    public partial class FormBai3 : Form
    {
        public FormBai3()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            tbNhap.Text = string.Empty;
            tbKetQua.Text = string.Empty;
        }

        private void btnDoc_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbNhap.Text))
            {
                MessageBox.Show("Vui lòng nhập một số nguyên 0 - 9");
                return;
            }
            int num;
            if (Int32.TryParse(tbNhap.Text, out num) == false)
            {
                MessageBox.Show("Sai định dạng");
                return;
            }
            if (num < 0 || num > 9)
            {
                MessageBox.Show("Vui lòng nhập một số nguyên 0 - 9");
                return;
            }

            switch (num)
            {
                case 0: 
                    tbKetQua.Text = "Không";
                    break;
                case 1:
                    tbKetQua.Text = "Một";
                    break;
                case 2:
                    tbKetQua.Text = "Hai";
                    break;
                case 3:
                    tbKetQua.Text = "Ba";
                    break;
                case 4:
                    tbKetQua.Text = "Bốn";
                    break;
                case 5:
                    tbKetQua.Text = "Năm";
                    break;
                case 6:
                    tbKetQua.Text = "Sáu";
                    break;
                case 7:
                    tbKetQua.Text = "Bảy";
                    break;
                case 8:
                    tbKetQua.Text = "Tám";
                    break;
                case 9:
                    tbKetQua.Text = "Chín";
                    break;
                default: break;
            }
        }
    }
}
