using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab01
{
    public partial class FormBai7 : Form
    {
        public FormBai7()
        {
            InitializeComponent();
        }

        private void tbInfo_TextChanged(object sender, EventArgs e)
        {
            string[] info = tbInfo.Text.Split(',');

            foreach (char c in info[0])
            {
                if (!char.IsLetter(c) && c != ' ')
                {
                    return;
                }
            }
            lbInfo.Text = info[0] + "\n";
            double[] diem = new double[info.Length - 1];
            for (int i = 1; i < info.Length; i++)
            {
                if (double.TryParse(info[i], out diem[i - 1]) == false)
                {
                    return;
                }
                lbInfo.Text += "Môn " + i.ToString() + ": " + diem[i - 1] + "   ";
            }

            double diemTrungBinh = 0;
            int monHighest = 0;
            double diemHighest = double.MinValue;
            int monLowest = 0;
            double diemLowest = double.MaxValue;
            int countDau = 0, countKoDau = 0;
            String xeploai;
            for (int i = 0; i < diem.Length; i++)
            {
                diemTrungBinh += diem[i];

                if (diemHighest < diem[i])
                {
                    monHighest = i + 1;
                    diemHighest = diem[i];
                }

                if (diemLowest > diem[i])
                {
                    diemLowest = diem[i];
                    monLowest = i + 1;
                }

                if (diem[i] >= 5)
                {
                    countDau++;
                }
                else
                {
                    countKoDau++;
                }
            }

            diemTrungBinh /= diem.Length;
            lbInfo.Text += "\nĐiểm trung bình: " + diemTrungBinh.ToString() + "\n";
            lbInfo.Text += "Môn " + monHighest.ToString() + " cao nhất với " + diemHighest.ToString() + "\n";
            lbInfo.Text += "Môn " + monLowest.ToString() + " thấp nhất với " + diemLowest.ToString() + "\n";
            lbInfo.Text += "Số môn đậu: " + countDau.ToString() + "\n";
            lbInfo.Text += "Số môn không đậu: " + countKoDau.ToString() + "\n";

            if (diemTrungBinh >= 8.0)
            {
                xeploai = "Giỏi";
                for (int i = 0; i < diem.Length; i++)
                {
                    if (diem[i] < 6.5)
                    {
                        xeploai = "Khá";
                    }
                }
            }
            else if (diemTrungBinh >= 6.5)
            {
                xeploai = "Khá";
                for (int i = 0; i < diem.Length; i++)
                {
                    if (diem[i] < 5)
                    {
                        xeploai = "Trung bình";
                    }
                }
            }
            else if (diemTrungBinh >= 5)
            {
                xeploai = "Trung bình";
                for (int i = 0; i < diem.Length; i++)
                {
                    if (diem[i] < 3.5)
                    {
                        xeploai = "Yếu";
                    }
                }
            }
            else if (diemTrungBinh >= 3.5)
            {
                xeploai = "Yếu";
                for (int i = 0; i < diem.Length; i++)
                {
                    if (diem[i] < 5)
                    {
                        xeploai = "Kém";
                    }
                }
            }
            else
            {
                xeploai = "Kém";
            }

            lbInfo.Text += "Xếp loại: " + xeploai;





        }
    }
}
