using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab02
{
    public partial class FormBai1 : Form
    {
        public FormBai1()
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
                rTBKetQua.Text += sr.ReadToEnd();
                fs.Close();
            }
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text File|*.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileStream fs1 = new FileStream(saveFileDialog.FileName, FileMode.OpenOrCreate);
                StreamWriter sw = new StreamWriter(fs1);
                sw.Write(rTBKetQua.Text.ToUpper());
                sw.Flush();
                fs1.Close();
            }
        }
    }
}
