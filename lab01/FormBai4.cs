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
    public partial class FormBai4 : Form
    {
        public FormBai4()
        {
            InitializeComponent();
        }
        Dictionary<string, double> dsPhim = new Dictionary<string, double>();
        Dictionary<string, double> choNgoi = new Dictionary<string, double>();
        double heso = 0;
        int demVeVot = 0, demVeThuong = 0, demVeVIP = 0;
        private void FormBai4_Load(object sender, EventArgs e)
        {
            dsPhim.Add("Đào, Phở và Piano", 45000);
            dsPhim.Add("Mai", 100000);
            dsPhim.Add("Gặp lại chị bầu", 70000);
            dsPhim.Add("Tarot", 90000);

            choNgoi.Add("A1", 0.25);
            choNgoi.Add("A5", 0.25);
            choNgoi.Add("C1", 0.25);
            choNgoi.Add("C5", 0.25);

            choNgoi.Add("A2", 1);
            choNgoi.Add("A3", 1);
            choNgoi.Add("A4", 1);
            choNgoi.Add("C2", 1);
            choNgoi.Add("C3", 1);
            choNgoi.Add("C4", 1);

            choNgoi.Add("B2", 2);
            choNgoi.Add("B3", 2);
            choNgoi.Add("B4", 2);
        }
        private void btnDatVe_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbTenKH.Text))
            {
                MessageBox.Show("Hãy nhập tên khách hàng");
                return;
            }
            if (cbPhim.SelectedIndex == -1)
            {
                MessageBox.Show("Hãy chọn phim muốn xem");
                return;
            }

            if (cbPhong.SelectedIndex == -1)
            {
                MessageBox.Show("Hãy chọn phòng muốn xem");
                return;
            }

            foreach (var seat in clbA.CheckedItems)
            {
                if (seat.ToString() == "A2" || seat.ToString() == "A3" || seat.ToString() == "A4")
                {
                    demVeThuong++;
                } 
                else
                {
                    demVeVot++;
                }
                heso += choNgoi[seat.ToString()];
            }

            foreach (var seat in clbB.CheckedItems)
            {
                if (string.IsNullOrEmpty(seat.ToString()))
                {
                    continue;
                }
                demVeVIP++;
                heso += choNgoi[seat.ToString()];
            }

            foreach (var seat in clbC.CheckedItems)
            {
                if (seat.ToString() == "C2" || seat.ToString() == "C3" || seat.ToString() == "C4")
                {
                    demVeThuong++;
                }
                else
                {
                    demVeVot++;
                }
                heso += choNgoi[seat.ToString()];
            }

            if (heso == 0)
            {
                MessageBox.Show("Hãy chọn chỗ ngồi");
                return;
            }

            string ketqua = "";
            ketqua += "Tên khách hàng " + tbTenKH.Text + "\n";
            ketqua += "Tên phim: " + cbPhim.GetItemText(cbPhim.SelectedItem) + "\n";
            ketqua += "Phòng chiếu: " + cbPhong.GetItemText(cbPhong.SelectedItem) + "\n";
            ketqua += "Vé đã chọn: vé thường(" + demVeThuong.ToString()
                + "), vé VIP(" + demVeVIP.ToString()
                + "), vé vớt(" + demVeVot.ToString() + ")\n";
            ketqua += "Số tiền cần thanh toán: " + dsPhim[cbPhim.GetItemText(cbPhim.SelectedItem)] * heso + "\n";
            

            MessageBox.Show(ketqua);

        }

        private void cbPhim_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPhim.SelectedIndex == 0)
            {
                List<string> list = new List<string>()
                {
                    "Phòng chiếu 1",
                    "Phòng chiếu 2",
                    "Phòng chiếu 3"
                };
                cbPhong.DataSource = list;
            }
            else if (cbPhim.SelectedIndex == 1)
            {
                List<string> list = new List<string>()
                {
                    "Phòng chiếu 2",
                    "Phòng chiếu 3"
                };
                cbPhong.DataSource = list;
            }
            else if (cbPhim.SelectedIndex == 2)
            {
                List<string> list = new List<string>()
                {
                    "Phòng chiếu 1"
                };
                cbPhong.DataSource = list;
            }
            else if (cbPhim.SelectedIndex == 3)
            {
                List<string> list = new List<string>()
                {
                    "Phòng chiếu 3"
                };
                cbPhong.DataSource = list;
            }
        }


    }
}
