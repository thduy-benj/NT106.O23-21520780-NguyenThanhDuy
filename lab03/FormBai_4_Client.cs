using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab03
{
    public partial class FormBai_4_Client : Form
    {
        public FormBai_4_Client()
        {
            InitializeComponent();
        }
        TcpClient tcpClient;
        NetworkStream stream;
        public class Phim
        {
            public string Name { get; set; }
            public List<int> Phong { get; set; }
            public int GiaVe { get; set; }
            public Phim(string Name, List<int> Phong, int GiaVe)
            {
                this.Name = Name;
                this.Phong = Phong;
                this.GiaVe = GiaVe;
            }
            public Phim()
            {
                this.Name = string.Empty;
                this.Phong = new List<int> { };
                this.GiaVe = 0;
            }
            public override string ToString()
            {
                string ketqua = string.Empty;
                ketqua += this.Name + " " + this.GiaVe.ToString() + " ";
                foreach (int sophong in this.Phong)
                {
                    ketqua += sophong.ToString() + ",";
                }
                return ketqua;
            }
        }
        List<Phim> dsPhim = new List<Phim>();
        public class HoaDon
        {
            public string tenKH { get; set; }
            public string tenPhim { get; set; }
            public int giaVeCB { get; set; }
            public int soVeVip { get; set; }
            public int soVeThuong { get; set; }
            public int soVeVot { get; set; }
            public HoaDon()
            {
                this.tenKH = string.Empty;
                this.tenPhim = string.Empty;
                this.soVeVip = 0;
                this.soVeThuong = 0;
                this.soVeVot = 0;
                this.giaVeCB = 0;
            }

            public double giaTien()
            {
                double ketqua = this.giaVeCB * (this.soVeThuong + this.soVeVip * 2 + this.soVeVot * 0.25);
                return Math.Round(ketqua, 2);
            }

            public override string ToString()
            {
                string ketqua = string.Empty;
                ketqua += "Họ tên khách hàng: " + this.tenKH + "\n"
                    + "Tên phim: " + this.tenPhim + "\n"
                    + "Số vé thường: " + this.soVeThuong + "\n"
                    + "Số vé VIP: " + this.soVeVip + "\n"
                    + "Số vé vớt: " + this.soVeVot + "\n"
                    + "Số tiền cần thanh toán: " + giaTien().ToString();
                return ketqua;
            }
        }
        List<HoaDon> dsHoaDon = new List<HoaDon>();
        // Giả sử tổng số lượng vé ban đầu là 100
        public static int soLuongVeBanDau = 100;

        private void LoadPhim(string info)
        {
            string[] detail = info.Split("\n");
            int index = 0;
            if (detail.Length > 4)
            {
                index++;
            }
            string name = detail[index++];
            int giaVe = int.Parse(detail[index++]);
            List<int> phong = new List<int>();
            string[] string_phong = detail[index].Split(",");
            foreach (string sophong in string_phong)
            {
                phong.Add(int.Parse(sophong));
            }
            Phim phim = new Phim(name, phong, giaVe);
            dsPhim.Add(phim);
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text file|*.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string content = File.ReadAllText(openFileDialog.FileName);
                string[] phims = content.Split("_");
                foreach (string info in phims)
                {
                    LoadPhim(info);
                }
                openFileDialog.Dispose();
            }

            cbPhim.Enabled = true;
            cbPhim.Items.Clear();
            foreach (Phim phim in dsPhim)
            {
                cbPhim.Items.Add(phim.Name);
            }
        }
        Phim selectedPhim = new Phim();
        private void cbPhim_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbPhong.Items.Clear();
            foreach (Phim phim in dsPhim)
            {
                if (phim.Name == cbPhim.Text)
                {
                    selectedPhim = phim;
                    foreach (int sophong in phim.Phong)
                    {
                        cbPhong.Items.Add(sophong);
                    }

                }
            }
            cbPhong.Enabled = true;
        }

        private void cbPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            clbA.Enabled = true;
            clbB.Enabled = true;
            clbC.Enabled = true;
            btnDatVe.Enabled = true;
        }

        private void btnDatVe_Click(object sender, EventArgs e)
        {
            HoaDon hoadon = new HoaDon();
            if (tbTenKH.Text == null || tbTenKH.Text == "")
            {
                MessageBox.Show("Hãy nhập tên khách hàng");
                return;
            }
            hoadon.tenKH = tbTenKH.Text;
            hoadon.tenPhim = selectedPhim.Name;
            hoadon.giaVeCB = selectedPhim.GiaVe;
            List<string> dsChoNgoi = new List<string>();
            foreach (var seat in clbA.CheckedItems)
            {

                if (seat.ToString() == "A2" || seat.ToString() == "A3" || seat.ToString() == "A4")
                {
                    hoadon.soVeThuong++;
                }
                else
                {
                    hoadon.soVeVot++;
                }
                if (string.IsNullOrEmpty(seat.ToString()) == false)
                {
                    dsChoNgoi.Add(seat.ToString());
                }
            }

            foreach (var seat in clbB.CheckedItems)
            {
                if (string.IsNullOrEmpty(seat.ToString()))
                {
                    continue;
                }
                hoadon.soVeVip++;
                if (string.IsNullOrEmpty(seat.ToString()) == false)
                {
                    dsChoNgoi.Add(seat.ToString());
                }
            }

            foreach (var seat in clbC.CheckedItems)
            {
                if (seat.ToString() == "C2" || seat.ToString() == "C3" || seat.ToString() == "C4")
                {
                    hoadon.soVeThuong++;
                }
                else
                {
                    hoadon.soVeVot++;
                }
                if (string.IsNullOrEmpty(seat.ToString()) == false)
                {
                    dsChoNgoi.Add(seat.ToString());
                }
            }
            if (hoadon.soVeThuong == 0 && hoadon.soVeVip == 0 && hoadon.soVeVot == 0)
            {
                MessageBox.Show("Hãy chọn vị trí ngồi ");
                return;
            }
            foreach(TakenSeat taken in takenSeats)
            {
                if (taken.Phim.Equals(cbPhim.Text)
                    && taken.Phong == int.Parse(cbPhong.Text))
                {
                    foreach (var takenseat in taken.seat)
                    {
                        foreach(var seat in dsChoNgoi)
                        {
                            if (seat.Equals(takenseat.ToString()))
                            {
                                MessageBox.Show("Vị trí đã có người đặt!");
                                return;
                            }
                        }
                    }
                }
            }
            dsHoaDon.Add(hoadon);
            MessageBox.Show(hoadon.ToString());

            string message = cbPhim.SelectedItem.ToString() + "/" + cbPhong.SelectedItem.ToString() + "/";
            foreach (string chongoi in dsChoNgoi)
            {
                message += chongoi + "/";
            }

            byte[] buffer = Encoding.UTF8.GetBytes(message);
            stream.Write(buffer, 0, buffer.Length);

            tbTenKH.Clear();
            for (int i = 0; i < clbA.Items.Count; i++)
            {
                clbA.SetItemChecked(i, false);
                clbB.SetItemChecked(i, false);
                clbC.SetItemChecked(i, false);
            }
            clbA.ClearSelected();
            clbB.ClearSelected();
            clbC.ClearSelected();

            btnDatVe.Enabled = false;
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            if (dsHoaDon.Count <= 0)
            {
                MessageBox.Show("Chưa có hoá đơn nào được xuất ra");
                return;
            }
            Dictionary<string, int> soLuongVeBan = new Dictionary<string, int>();
            Dictionary<string, double> doanhthu = new Dictionary<string, double>();
            foreach (Phim phim in dsPhim)
            {
                soLuongVeBan.Add(phim.Name, 0);
                doanhthu.Add(phim.Name, 0);
            }

            foreach (HoaDon hoaDon in dsHoaDon)
            {
                soLuongVeBan[hoaDon.tenPhim] += hoaDon.soVeVip + hoaDon.soVeThuong + hoaDon.soVeVot;
                doanhthu[hoaDon.tenPhim] += hoaDon.giaTien();
            }
            string ketqua = string.Empty;
            foreach (Phim phim in dsPhim)
            {
                ketqua += "Tên phim: " + phim.Name + "\n"
                    + "Số lượng vé bán ra: " + soLuongVeBan[phim.Name] + "\n"
                    + "Số lượng vé tồn: " + (soLuongVeBanDau - soLuongVeBan[phim.Name]).ToString() + "\n"
                    + "Tỷ lệ vé bán ra: " + (soLuongVeBan[phim.Name] * 1.0 / soLuongVeBanDau) * 100 + "%\n"
                    + "Doanh thu: " + doanhthu[phim.Name] + "\n"
                    + "----------------------------------------------------------------------------------\n";
            }

            ketqua += "\n-------------Top doanh thu-------------------\n";
            foreach (KeyValuePair<string, double> top in doanhthu.OrderByDescending(key => key.Value))
            {
                ketqua += top.Key + ": " + top.Value + "\n";
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text File|*.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileStream fs1 = new FileStream(saveFileDialog.FileName, FileMode.OpenOrCreate);
                StreamWriter sw = new StreamWriter(fs1);
                sw.Write(ketqua);
                sw.Flush();
                fs1.Close();
            }
            doanhthu.Clear();
            soLuongVeBan.Clear();
        }

        private async void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                tcpClient = new TcpClient();
                await tcpClient.ConnectAsync("127.0.0.1", 9000);
                stream = tcpClient.GetStream();
                btnLoad.Enabled = true;

                Thread receiveThread = new Thread(ReceiveMessages);
                receiveThread.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cant connect to server!!");
            }
        }
        private UdpClient udpClient;
        private class TakenSeat
        {
            public string Phim { get; set; }
            public int Phong { get; set; }
            public List<string> seat = new List<string>();
        }
        List<TakenSeat> takenSeats = new List<TakenSeat>();
        private void ReceiveMessages()
        {
            byte[] buffer = new byte[tcpClient.ReceiveBufferSize];
            int bytesRead;
            string message = string.Empty;
            while (tcpClient.Connected)
            {
                bytesRead = stream.Read(buffer, 0, buffer.Length);
                if (bytesRead == 0) { break; }
                if (message.Equals(Encoding.UTF8.GetString(buffer, 0, bytesRead)) == false)
                {
                    message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                    lbLog.Items.Add("Server response: " + message);
                    string[] subarrays = message.Split('/');
                    if (takenSeats.Count == 0)
                    {
                        TakenSeat takenSeat = new TakenSeat();
                        takenSeat.Phim = subarrays[0];
                        takenSeat.Phong = int.Parse(subarrays[1]);
                        for (int i = 2; i < subarrays.Length; i++)
                        {
                            if (string.IsNullOrEmpty(subarrays[i]) == false)
                            {
                                takenSeat.seat.Add(subarrays[i]);
                            }
                        }
                    }
                    else
                    {
                        foreach(var taken in takenSeats)
                        {
                            if (taken.Phim == subarrays[0] 
                                && taken.Phong == int.Parse(subarrays[1]))
                            {
                                for (int i = 2;i < subarrays.Length;i++)
                                {
                                    if (string.IsNullOrEmpty(subarrays[i]) == false)
                                    {
                                        taken.seat.Add(subarrays[i]);
                                    }
                                }
                            }
                        }
                    }
                }
            }

        }

        private void FormBai_4_Client_Leave(object sender, EventArgs e)
        {
            tcpClient.Close();
            stream.Close();
        }
    }
}
