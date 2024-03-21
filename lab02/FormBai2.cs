using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace lab02
{
    public partial class FormBai2 : Form
    {
        public FormBai2()
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
                tbFileName.Text = ofd.SafeFileName;
                tbURL.Text = ofd.FileName;
                rTBKetQua.Text = sr.ReadToEnd();
                FileInfo f = new FileInfo(ofd.FileName);
                tbSize.Text = f.Length.ToString() + " bytes";
                string[] s = rTBKetQua.Text.Split("\n");
                tbLineCount.Text = s.Length.ToString();
                s = rTBKetQua.Text.Split(new Char[] { ' ', '\n' });
                tbWordCount.Text = s.Length.ToString();
                fs.Close();
                string s1 = rTBKetQua.Text.Replace("\r\n", "");
                s1 = s1.Replace(" ", "");
                tbCharCount.Text = s1.Length.ToString();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
