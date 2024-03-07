namespace lab01
{
    partial class formBai1
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
            tbSoThuNhat = new TextBox();
            lbSoThuNhat = new Label();
            lbSoThuHai = new Label();
            tbSoThuHai = new TextBox();
            btnTinhTong = new Button();
            lbKetQua = new Label();
            tbKetQua = new TextBox();
            SuspendLayout();
            // 
            // tbSoThuNhat
            // 
            tbSoThuNhat.Location = new Point(239, 68);
            tbSoThuNhat.Name = "tbSoThuNhat";
            tbSoThuNhat.Size = new Size(125, 27);
            tbSoThuNhat.TabIndex = 0;
            // 
            // lbSoThuNhat
            // 
            lbSoThuNhat.AutoSize = true;
            lbSoThuNhat.Location = new Point(122, 69);
            lbSoThuNhat.Name = "lbSoThuNhat";
            lbSoThuNhat.Size = new Size(85, 20);
            lbSoThuNhat.TabIndex = 1;
            lbSoThuNhat.Text = "Số thứ nhất";
            // 
            // lbSoThuHai
            // 
            lbSoThuHai.AutoSize = true;
            lbSoThuHai.Location = new Point(122, 123);
            lbSoThuHai.Name = "lbSoThuHai";
            lbSoThuHai.Size = new Size(76, 20);
            lbSoThuHai.TabIndex = 2;
            lbSoThuHai.Text = "Số thứ hai";
            // 
            // tbSoThuHai
            // 
            tbSoThuHai.Location = new Point(239, 116);
            tbSoThuHai.Name = "tbSoThuHai";
            tbSoThuHai.Size = new Size(125, 27);
            tbSoThuHai.TabIndex = 3;
            // 
            // btnTinhTong
            // 
            btnTinhTong.Location = new Point(179, 162);
            btnTinhTong.Name = "btnTinhTong";
            btnTinhTong.Size = new Size(94, 29);
            btnTinhTong.TabIndex = 4;
            btnTinhTong.Text = "Tính";
            btnTinhTong.UseVisualStyleBackColor = true;
            btnTinhTong.Click += btnTinhTong_Click;
            // 
            // lbKetQua
            // 
            lbKetQua.AutoSize = true;
            lbKetQua.Location = new Point(129, 205);
            lbKetQua.Name = "lbKetQua";
            lbKetQua.Size = new Size(60, 20);
            lbKetQua.TabIndex = 5;
            lbKetQua.Text = "Kết quả";
            // 
            // tbKetQua
            // 
            tbKetQua.Location = new Point(239, 205);
            tbKetQua.Name = "tbKetQua";
            tbKetQua.ReadOnly = true;
            tbKetQua.Size = new Size(125, 27);
            tbKetQua.TabIndex = 6;
            // 
            // formBai1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbKetQua);
            Controls.Add(lbKetQua);
            Controls.Add(btnTinhTong);
            Controls.Add(tbSoThuHai);
            Controls.Add(lbSoThuHai);
            Controls.Add(lbSoThuNhat);
            Controls.Add(tbSoThuNhat);
            Name = "formBai1";
            Text = "Bài 1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbSoThuNhat;
        private Label lbSoThuNhat;
        private Label lbSoThuHai;
        private TextBox tbSoThuHai;
        private Button btnTinhTong;
        private Label lbKetQua;
        private TextBox tbKetQua;
    }
}