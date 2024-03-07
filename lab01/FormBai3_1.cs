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
    public partial class FormBai3_1 : Form
    {
        public FormBai3_1()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            tbKetQua.Text = string.Empty;
            tbNhap.Text = string.Empty;
        }

        private void btnDoc_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbNhap.Text))
            {
                MessageBox.Show("Vui lòng nhập số nguyên");
                return;
            }

            if (tbNhap.Text[0] != '-')
            {
                if (tbNhap.Text.Length > 12)
                {
                    MessageBox.Show("Vui lòng nhập số nguyên ít hơn 13 chữ số");
                    return;
                }
            }
            else
            {
                if (tbNhap.Text.Length > 13)
                {
                    MessageBox.Show("Vui lòng nhập số nguyên ít hơn 13 chữ số");
                    return;
                }
            }

            long num;
            if (long.TryParse(tbNhap.Text, out num) == false)
            {
                MessageBox.Show("Sai định dạng");
                return;
            }
            else
            {
                string ketqua = "";
                if (num < 0) { ketqua += "Âm "; num *= -1; }
                if (num == 0) { ketqua = "Không"; }
                if (num > 100000000000)
                {
                    ketqua = basecase(num / 1000000000, ketqua) + " Tỷ ";
                    num %= 1000000000;
                }
                if (num >= 1000000)
                {
                    ketqua = basecase(num / 1000000, ketqua) + " Triệu ";
                    num %= 1000000;
                }
                if (num >= 1000)
                {
                    ketqua = basecase(num / 1000, ketqua) + " Nghìn ";
                    num %= 1000;
                }
                if (num > 0)
                {
                    ketqua = basecase(num, ketqua);
                }
                tbKetQua.Text = ketqua;
            }
        }

        private string basecase(long num, string ketqua)
        {
            if (num > 99)
            {
                switch ((num % 1000) / 100)
                {
                    case 0: ketqua += "Không Trăm "; break;
                    case 1: ketqua += "Một Trăm "; break;
                    case 2: ketqua += "Hai Trăm "; break;
                    case 3: ketqua += "Ba Trăm "; break;
                    case 4: ketqua += "Bốn Trăm "; break;
                    case 5: ketqua += "Năm Trăm "; break;
                    case 6: ketqua += "Sáu Trăm "; break;
                    case 7: ketqua += "Bảy Trăm "; break;
                    case 8: ketqua += "Tám Trăm "; break;
                    case 9: ketqua += "Chín Trăm "; break;
                }
            }
            if (num > 9)
            {
                switch ((num / 10) % 10)
                {
                    case 0:
                        if (num % 10 > 0) { ketqua += "Linh "; }
                        break;
                    case 1: ketqua += "Mười "; break;
                    case 2: ketqua += "Hai Mươi "; break;
                    case 3: ketqua += "Ba Mươi "; break;
                    case 4: ketqua += "Bốn Mươi "; break;
                    case 5: ketqua += "Năm Mươi "; break;
                    case 6: ketqua += "Sáu Mươi "; break;
                    case 7: ketqua += "Bảy Mươi "; break;
                    case 8: ketqua += "Tám Mươi "; break;
                    case 9: ketqua += "Chín Mươi "; break;
                }
            }
            switch (num % 10)
            {
                case 1:
                    if ((num / 10) % 10 > 1) ketqua += "Mốt";
                    else ketqua += "Một";
                    break;
                case 2: ketqua += "Hai"; break;
                case 3: ketqua += "Ba"; break;
                case 4: ketqua += "Bốn"; break;
                case 5:
                    if ((num / 10) % 10 > 0) ketqua += "Lăm";
                    else ketqua += "Năm";
                    break;
                case 6: ketqua += "Sáu"; break;
                case 7: ketqua += "Bảy"; break;
                case 8: ketqua += "Tám"; break;
                case 9: ketqua += "Chín"; break;
            }
            return ketqua;
        }
    }
}
