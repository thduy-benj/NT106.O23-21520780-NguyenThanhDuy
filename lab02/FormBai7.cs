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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace lab02
{
    public partial class FormBai7 : Form
    {
        public FormBai7()
        {
            InitializeComponent();
        }

        private void FormBai7_Load(object sender, EventArgs e)
        {
            string path = @"D:\";
            TreeNode node = new TreeNode() { Text = path };
            Loadfile_folder(node);
            tvPath.Nodes.Add(node);
        }

        public void Loadfile_folder(TreeNode root)
        {
            if (root == null) return;
            try
            {
                string[] filePaths = Directory.GetFiles(root.Text);
                foreach (string filePath in filePaths)
                {
                    TreeNode node = new TreeNode() { Text = filePath };
                    root.Nodes.Add(node);
                }
                DirectoryInfo[] directory = new DirectoryInfo(root.Text).GetDirectories();
                if (directory.Count() == 0) return;
                foreach (DirectoryInfo d in directory)
                {
                    if (Directory.Exists(d.FullName))
                    {
                        TreeNode node = new TreeNode() { Text = d.FullName };
                        root.Nodes.Add(node);
                        Loadfile_folder(node);
                    }
                }
            }
            catch
            {
                return;
            }
        }

        private void tvPath_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            gbFileContent.Controls.Clear();
            TreeNode node = tvPath.GetNodeAt(tvPath.PointToClient(Cursor.Position));
            if (node != null)
            {
                string filePath = node.Text;
                if (Path.GetExtension(filePath).ToLower() == ".jpg" || Path.GetExtension(filePath).ToLower() == ".jpeg" || Path.GetExtension(filePath).ToLower() == ".png" || Path.GetExtension(filePath).ToLower() == ".bmp" || Path.GetExtension(filePath).ToLower() == ".gif")
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Image = Image.FromFile(filePath);
                    pictureBox.Dock = DockStyle.Fill;
                    gbFileContent.Controls.Add(pictureBox);
                }
                else if (Path.GetExtension(filePath).ToLower() == ".txt")
                {
                    System.Windows.Forms.TextBox tb = new System.Windows.Forms.TextBox();
                    tb.Multiline = true;
                    tb.Dock = DockStyle.Fill;
                    tb.ScrollBars = ScrollBars.Vertical;
                    tb.Text = File.ReadAllText(filePath);
                    gbFileContent.Controls.Add(tb);
                }
                else
                {
                    MessageBox.Show("Không thể hiển thị nội dung");
                }
            }
        }
    }
}
