using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.AccessControl;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab02
{
    public partial class FormBai4 : Form
    {
        public FormBai4()
        {
            InitializeComponent();
        }
        [Serializable]
        public class SinhVien
        {
            public string Name { get; set; }
            public int ID { get; set; }
            public string Phone { get; set; }
            public float diemMon1 { get; set; }
            public float diemMon2 { get; set; }
            public float diemMon3 { get; set; }
            public double diemTB()
            {
                return Math.Round((diemMon1 + diemMon2 + diemMon3) / 3);
            }

            public SinhVien() { }

            public override string ToString()
            {
                string ketqua = Name + "\n"
                    + ID.ToString() + "\n"
                    + Phone + "\n"
                    + diemMon1.ToString() + "\n"
                    + diemMon2.ToString() + "\n"
                    + diemMon3.ToString() + "\n"
                    + diemTB().ToString() + "\n";
                return ketqua;
            }
        }

        List<SinhVien> dsSinhVien = new List<SinhVien>();

        private bool IsTextBoxEmpty()
        {
            if (string.IsNullOrEmpty(tbInputName.Text) ||
                string.IsNullOrEmpty(tbInputID.Text) ||
                string.IsNullOrEmpty(tbInputPhone.Text) ||
                string.IsNullOrEmpty(tbInputMon1.Text) ||
                string.IsNullOrEmpty(tbInputMon2.Text) ||
                string.IsNullOrEmpty(tbInputMon3.Text))
            {
                return true;
            }
            return false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (IsTextBoxEmpty())
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin!!");
                return;
            }

            SinhVien sinhvien = new SinhVien();
            sinhvien.Name = tbInputName.Text;
            int ID;
            if (tbInputID.Text.Length < 8 || int.TryParse(tbInputID.Text, out ID) == false)
            {
                MessageBox.Show("Sai định dạng MSSV");
                return;
            }
            sinhvien.ID = ID;

            if (tbInputPhone.Text[0] != '0' || tbInputPhone.Text.Length != 10)
            {
                MessageBox.Show("SDT phải có 10 chữ số và bắt đầu bằng chữ số 0");
                return;
            }
            sinhvien.Phone = tbInputPhone.Text;
            float mon1, mon2, mon3;
            if (!(float.TryParse(tbInputMon1.Text, out mon1) &&
                float.TryParse(tbInputMon2.Text, out mon2) &&
                float.TryParse(tbInputMon3.Text, out mon3)))
            {
                MessageBox.Show("Sai định dạng điểm");
                return;
            }
            sinhvien.diemMon1 = mon1;
            sinhvien.diemMon2 = mon2;
            sinhvien.diemMon3 = mon3;

            tbInputDTB.Text = sinhvien.diemTB().ToString();
            dsSinhVien.Add(sinhvien);
            rTBKetQua.Clear();
            foreach (SinhVien sv in dsSinhVien)
            {
                rTBKetQua.Text += sv.ToString() + "--------------------------------------\n";
            }
            tbInputName.Text = string.Empty;
            tbInputID.Text = string.Empty;
            tbInputPhone.Text = string.Empty;
            tbInputMon1.Text = string.Empty;
            tbInputMon2.Text = string.Empty;
            tbInputMon3.Text = string.Empty;
            tbInputDTB.Text = string.Empty;
        }

        static void SerializeToFileJson(string filePath, List<SinhVien> obj)
        {
            try
            {
                var options = new JsonSerializerOptions()
                {
                    IncludeFields = true,
                };
                // Serialize the object to JSON format
                string json = JsonSerializer.Serialize(obj, options);
                File.WriteAllText(filePath, json);
                MessageBox.Show($"Serialized data successfully written to {filePath} ");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occurred while serializing data: {ex.Message} ");
            }
        }
        private void btnWrite_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName + ".json";
                SerializeToFileJson(filePath, dsSinhVien);
            }
        }
        private List<SinhVien> DeserializeFromFileJson(string filePath)
        {
            try
            {
                // Read the JSON data from the file
                string json = File.ReadAllText(filePath);
                // Deserialize the JSON data to the specified type
                return JsonSerializer.Deserialize<List<SinhVien>>(json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occurred while deserializing data: {ex.Message}");
                return default;
            }
        }
        private void showSinhVien(SinhVien sinhVien)
        {
            if (sinhVien == null)
            {
                MessageBox.Show("Sinh vien không tồn tại");
                return;
            }

            tbReadName.Text = sinhVien.Name;
            tbReadPhone.Text = sinhVien.Phone;
            tbReadID.Text = sinhVien.ID.ToString();
            tbReadMon1.Text = sinhVien.diemMon1.ToString();
            tbReadMon2.Text = sinhVien.diemMon2.ToString();
            tbReadMon3.Text = sinhVien.diemMon3.ToString();
            tbReadDTB.Text = sinhVien.diemTB().ToString();

        }
        int page = 0;
        private void btnRead_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                lbSTT.Text = (page + 1).ToString();
                string filePath = openFileDialog.FileName;
                dsSinhVien = DeserializeFromFileJson(filePath);
                if (dsSinhVien == null || dsSinhVien.Count == 0)
                {
                    MessageBox.Show("Danh sách rỗng");
                }
                showSinhVien(dsSinhVien[0]);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (page > 0)
            {
                page--;
                lbSTT.Text = (page+1).ToString();
                showSinhVien(dsSinhVien[(int)page]);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (page < dsSinhVien.Count - 1)
            {
                page++;
                lbSTT.Text = (page+1).ToString();
                showSinhVien(dsSinhVien[((int)page)]);
            }
            
        }
    }
}
