namespace lab01
{
    partial class FormBai2
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
            tbSoThuHai = new TextBox();
            tbSoThuBa = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnTim = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            label4 = new Label();
            tbSoLonNhat = new TextBox();
            tbSoNhoNhat = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // tbSoThuNhat
            // 
            tbSoThuNhat.Location = new Point(50, 76);
            tbSoThuNhat.Name = "tbSoThuNhat";
            tbSoThuNhat.Size = new Size(125, 27);
            tbSoThuNhat.TabIndex = 0;
            // 
            // tbSoThuHai
            // 
            tbSoThuHai.Location = new Point(341, 76);
            tbSoThuHai.Name = "tbSoThuHai";
            tbSoThuHai.Size = new Size(125, 27);
            tbSoThuHai.TabIndex = 1;
            // 
            // tbSoThuBa
            // 
            tbSoThuBa.Location = new Point(609, 76);
            tbSoThuBa.Name = "tbSoThuBa";
            tbSoThuBa.Size = new Size(125, 27);
            tbSoThuBa.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 41);
            label1.Name = "label1";
            label1.Size = new Size(85, 20);
            label1.TabIndex = 3;
            label1.Text = "Số thứ nhất";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(341, 41);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 4;
            label2.Text = "Số thứ hai";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(609, 41);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 5;
            label3.Text = "Số thứ ba";
            // 
            // btnTim
            // 
            btnTim.Location = new Point(179, 160);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(94, 29);
            btnTim.TabIndex = 6;
            btnTim.Text = "Tìm";
            btnTim.UseVisualStyleBackColor = true;
            btnTim.Click += btnTim_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(372, 160);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 7;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(545, 160);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 8;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(91, 307);
            label4.Name = "label4";
            label4.Size = new Size(84, 20);
            label4.TabIndex = 9;
            label4.Text = "Số lớn nhất";
            // 
            // tbSoLonNhat
            // 
            tbSoLonNhat.Location = new Point(202, 304);
            tbSoLonNhat.Name = "tbSoLonNhat";
            tbSoLonNhat.ReadOnly = true;
            tbSoLonNhat.Size = new Size(125, 27);
            tbSoLonNhat.TabIndex = 10;
            // 
            // tbSoNhoNhat
            // 
            tbSoNhoNhat.Location = new Point(618, 304);
            tbSoNhoNhat.Name = "tbSoNhoNhat";
            tbSoNhoNhat.ReadOnly = true;
            tbSoNhoNhat.Size = new Size(125, 27);
            tbSoNhoNhat.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(505, 307);
            label5.Name = "label5";
            label5.Size = new Size(88, 20);
            label5.TabIndex = 12;
            label5.Text = "Số nhỏ nhất";
            // 
            // FormBai2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(tbSoNhoNhat);
            Controls.Add(tbSoLonNhat);
            Controls.Add(label4);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(btnTim);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbSoThuBa);
            Controls.Add(tbSoThuHai);
            Controls.Add(tbSoThuNhat);
            Name = "FormBai2";
            Text = "Bài 2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbSoThuNhat;
        private TextBox tbSoThuHai;
        private TextBox tbSoThuBa;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnTim;
        private Button btnXoa;
        private Button btnThoat;
        private Label label4;
        private TextBox tbSoLonNhat;
        private TextBox tbSoNhoNhat;
        private Label label5;
    }
}