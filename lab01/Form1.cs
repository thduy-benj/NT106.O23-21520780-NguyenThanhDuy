namespace lab01
{
    public partial class Lab01 : Form
    {
        public Lab01()
        {
            InitializeComponent();
        }

        private void Lab01_Load(object sender, EventArgs e)
        {

        }

        private void btnBai1_Click(object sender, EventArgs e)
        {
            formBai1 bai1 = new formBai1();
            bai1.ShowDialog();
        }

        private void btnBai2_Click(object sender, EventArgs e)
        {
            FormBai2 bai2 = new FormBai2();
            bai2.ShowDialog();
        }

        private void btnBai3_Click(object sender, EventArgs e)
        {
            FormBai3 bai3 = new FormBai3();
            bai3.ShowDialog();
        }

        private void btnBai3_1_Click(object sender, EventArgs e)
        {
            FormBai3_1 formBai3_1 = new FormBai3_1();
            formBai3_1.ShowDialog();
        }
    }
}