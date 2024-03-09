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
    public partial class FormBai6 : Form
    {
        public FormBai6()
        {
            InitializeComponent();
        }

        private void dtNgaySinh_ValueChanged(object sender, EventArgs e)
        {
            DateTime ngaysinh = dtNgaySinh.Value;
            if (ngaysinh >= new DateTime(ngaysinh.Year, 3, 21) && ngaysinh <= new DateTime(ngaysinh.Year, 4, 20))
            {
                tbKetQua.Text = "Bạch Dương";
            }
            else if (ngaysinh >= new DateTime(ngaysinh.Year, 4, 21) && ngaysinh <= new DateTime(ngaysinh.Year, 5, 21))
            {
                tbKetQua.Text = "Kim Ngưu";
            }
            else if (ngaysinh >= new DateTime(ngaysinh.Year, 5, 22) && ngaysinh <= new DateTime(ngaysinh.Year, 6, 21))
            {
                tbKetQua.Text = "Song Tử";
            }
            else if (ngaysinh >= new DateTime(ngaysinh.Year, 6, 22) && ngaysinh <= new DateTime(ngaysinh.Year, 7, 22))
            {
                tbKetQua.Text = "Cự Giải";
            }
            else if (ngaysinh >= new DateTime(ngaysinh.Year, 7, 23) && ngaysinh <= new DateTime(ngaysinh.Year, 8, 22))
            {
                tbKetQua.Text = "Sư Tử";
            }
            else if (ngaysinh >= new DateTime(ngaysinh.Year, 8, 23) && ngaysinh <= new DateTime(ngaysinh.Year, 9, 23))
            {
                tbKetQua.Text = "Xử Nữ";
            }
            else if (ngaysinh >= new DateTime(ngaysinh.Year, 9, 24) && ngaysinh <= new DateTime(ngaysinh.Year, 10, 23))
            {
                tbKetQua.Text = "Thiên Bình";
            }
            else if (ngaysinh >= new DateTime(ngaysinh.Year, 10, 24) && ngaysinh <= new DateTime(ngaysinh.Year, 11, 22))
            {
                tbKetQua.Text = "Thần Nông";
            }
            else if (ngaysinh >= new DateTime(ngaysinh.Year, 11, 23) && ngaysinh <= new DateTime(ngaysinh.Year, 12, 21))
            {
                tbKetQua.Text = "Nhân Mã";
            }
            else if (ngaysinh >= new DateTime(ngaysinh.Year, 12, 22) && ngaysinh <= new DateTime(ngaysinh.Year, 1, 20))
            {
                tbKetQua.Text = "Ma Kết";
            }
            else if (ngaysinh >= new DateTime(ngaysinh.Year, 1, 21) && ngaysinh <= new DateTime(ngaysinh.Year, 2, 19))
            {
                tbKetQua.Text = "Bảo Bình";
            }
            else if (ngaysinh >= new DateTime(ngaysinh.Year, 2, 20) && ngaysinh <= new DateTime(ngaysinh.Year, 3, 20))
            {
                tbKetQua.Text = "Song Ngư";
            }

        }
    }
}
