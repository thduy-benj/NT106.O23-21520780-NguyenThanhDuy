using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab01
{
    public partial class FormBai5 : Form
    {
        public FormBai5()
        {
            InitializeComponent();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            tbA.Text = string.Empty;
            tbB.Text = string.Empty;
            lbKetQua.Text = string.Empty;
        }

        int optionTinh = 0;
        private void btnTinh_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbA.Text) || String.IsNullOrEmpty(tbB.Text))
            {
                MessageBox.Show("Hãy điền đủ thông tin số A và B");
                return;
            }
            int A, B;
            if (!Int32.TryParse(tbA.Text, out A) || !Int32.TryParse(tbB.Text, out B))
            {
                MessageBox.Show("A và B phải là số nguyên dương");
                return;
            }

            if (B > A)
            {
                MessageBox.Show("A phải lớn hoặc bằng B");
                return;
            }

            if (optionTinh == 0)
            {
                MessageBox.Show("Hãy chọn phương thức tính");
                return;
            }
            else if (optionTinh == 1)
            {
                lbKetQua.Text = string.Empty;
                for (int i = 1; i <= 10; i++)
                {
                    for (int j = B; j <= A; j++)
                    {
                        int tich = j * i;
                        lbKetQua.Text += j.ToString() + " x " + i.ToString() + " = " + tich.ToString() + "   ";
                    }
                    lbKetQua.Text += "\n";
                }
            }
            else if (optionTinh == 2)
            {
                long factorial = 1;
                for (int i = 1; i <= A - B; i++)
                {
                    factorial *= i;
                }
                lbKetQua.Text = "(A-B)! = " + factorial.ToString() + "\n";

                long sum = 0;
                for (int i = 1; i <= B; i++)
                {
                    sum += Convert.ToInt64(Math.Pow(A, i));
                }
                lbKetQua.Text += "Tổng S = A^1 + A^2 + A^3 + A^4 + … + A^B = " + sum.ToString();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbChon_SelectedValueChanged(object sender, EventArgs e)
        {
            optionTinh = (int)cbChon.SelectedIndex + 1;
        }
    }
}
