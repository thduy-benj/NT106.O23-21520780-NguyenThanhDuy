namespace lab01
{
    partial class FormBai3
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
            tbNhap = new TextBox();
            label1 = new Label();
            label2 = new Label();
            tbKetQua = new TextBox();
            btnDoc = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            SuspendLayout();
            // 
            // tbNhap
            // 
            tbNhap.Location = new Point(223, 46);
            tbNhap.Name = "tbNhap";
            tbNhap.Size = new Size(125, 27);
            tbNhap.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 49);
            label1.Name = "label1";
            label1.Size = new Size(187, 20);
            label1.TabIndex = 1;
            label1.Text = "Nhập số nguyên từ 0 đến 9";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 102);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 2;
            label2.Text = "Kết quả";
            // 
            // tbKetQua
            // 
            tbKetQua.Location = new Point(31, 137);
            tbKetQua.Name = "tbKetQua";
            tbKetQua.ReadOnly = true;
            tbKetQua.Size = new Size(125, 27);
            tbKetQua.TabIndex = 3;
            // 
            // btnDoc
            // 
            btnDoc.Location = new Point(457, 37);
            btnDoc.Name = "btnDoc";
            btnDoc.Size = new Size(94, 29);
            btnDoc.TabIndex = 4;
            btnDoc.Text = "Đọc";
            btnDoc.UseVisualStyleBackColor = true;
            btnDoc.Click += btnDoc_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(457, 93);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 5;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(457, 148);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 6;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // FormBai3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(btnDoc);
            Controls.Add(tbKetQua);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbNhap);
            Name = "FormBai3";
            Text = "FormBai3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbNhap;
        private Label label1;
        private Label label2;
        private TextBox tbKetQua;
        private Button btnDoc;
        private Button btnXoa;
        private Button btnThoat;
    }
}