namespace lab03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormBai_1 formBai_1 = new FormBai_1();
            formBai_1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormBai_2 formBai_2 = new FormBai_2();
            formBai_2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormBai_3 formBai_3 = new FormBai_3();
            formBai_3.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormBai_4 formBai_4 = new FormBai_4();
            formBai_4.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormBai_5 formBai_5 = new FormBai_5();
            formBai_5.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormBai_6 formBai_6 = new FormBai_6();
            formBai_6.ShowDialog();
        }
    }
}