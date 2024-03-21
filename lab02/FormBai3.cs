using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab02
{
    public partial class FormBai3 : Form
    {
        public FormBai3()
        {
            InitializeComponent();
        }

        private void btnDoc_Click(object sender, EventArgs e)
        {
            rTBKetQua.Clear();
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text File|*.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
                StreamReader sr = new StreamReader(fs);
                string[] s = sr.ReadToEnd().Split("\n");
                for (int i = 0; i < s.Length; i++)
                {
                    rTBKetQua.Text += s[i] + "=" + Tinh(s[i]) + "\r\n";
                }
            }
        }
    }
}
