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
    public partial class formBai1 : Form
    {
        public formBai1()
        {
            InitializeComponent();
        }

        private void btnTinhTong_Click(object sender, EventArgs e)
        {
            int num1, num2;
            if (String.IsNullOrEmpty(tbSoThuNhat.Text))
            {
                MessageBox.Show("Vui lòng nhập số thứ nhất");
                return;
            }

            if (String.IsNullOrEmpty(tbSoThuHai.Text))
            {
                MessageBox.Show("Vui lòng nhập số thứ hai");
                return;
            }

            if (Int32.TryParse(tbSoThuNhat.Text, out num1) == false)
            {
                MessageBox.Show("Vui lòng nhập số nguyên");
                return;
            }

            if (Int32.TryParse(tbSoThuHai.Text, out num2) == false)
            {
                MessageBox.Show("Vui lòng nhập số nguyên");
                return;
            }

            int sum = num1 + num2;
            tbKetQua.Text = sum.ToString();


        }
    }
}
