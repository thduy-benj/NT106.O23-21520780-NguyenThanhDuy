namespace lab01
{
    partial class FormBai6
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            dtNgaySinh = new DateTimePicker();
            label2 = new Label();
            tbKetQua = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(90, 51);
            label1.Name = "label1";
            label1.Size = new Size(240, 20);
            label1.TabIndex = 0;
            label1.Text = "Chọn ngày tháng năm sinh của bạn";
            // 
            // dtNgaySinh
            // 
            dtNgaySinh.Location = new Point(90, 95);
            dtNgaySinh.Name = "dtNgaySinh";
            dtNgaySinh.Size = new Size(250, 27);
            dtNgaySinh.TabIndex = 1;
            dtNgaySinh.ValueChanged += dtNgaySinh_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(93, 167);
            label2.Name = "label2";
            label2.Size = new Size(175, 20);
            label2.TabIndex = 2;
            label2.Text = "Cung hoàng đạo của bạn";
            // 
            // tbKetQua
            // 
            tbKetQua.Location = new Point(274, 164);
            tbKetQua.Name = "tbKetQua";
            tbKetQua.ReadOnly = true;
            tbKetQua.Size = new Size(193, 27);
            tbKetQua.TabIndex = 3;
            // 
            // FormBai6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbKetQua);
            Controls.Add(label2);
            Controls.Add(dtNgaySinh);
            Controls.Add(label1);
            Name = "FormBai6";
            Text = "FormBai6";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dtNgaySinh;
        private Label label2;
        private TextBox tbKetQua;
    }
}