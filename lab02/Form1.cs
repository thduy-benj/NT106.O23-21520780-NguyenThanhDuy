namespace lab02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormBai1 formBai1 = new FormBai1();
            formBai1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormBai2 formBai2 = new FormBai2();
            formBai2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormBai3 formBai3 = new FormBai3();
            formBai3.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormBai4 formBai4 = new FormBai4();
            formBai4.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormBai5 formBai5 = new FormBai5();
            formBai5.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormBai6 formBai6 = new FormBai6();
            formBai6.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FormBai7 formBai7 = new FormBai7();
            formBai7.ShowDialog();
        }
    }
}