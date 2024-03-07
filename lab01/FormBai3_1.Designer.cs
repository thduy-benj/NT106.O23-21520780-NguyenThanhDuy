namespace lab01
{
    partial class FormBai3_1
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
            btnThoat = new Button();
            btnXoa = new Button();
            btnDoc = new Button();
            tbKetQua = new TextBox();
            label2 = new Label();
            label1 = new Label();
            tbNhap = new TextBox();
            SuspendLayout();
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(485, 171);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 13;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(485, 116);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 12;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnDoc
            // 
            btnDoc.Location = new Point(485, 60);
            btnDoc.Name = "btnDoc";
            btnDoc.Size = new Size(94, 29);
            btnDoc.TabIndex = 11;
            btnDoc.Text = "Đọc";
            btnDoc.UseVisualStyleBackColor = true;
            // 
            // tbKetQua
            // 
            tbKetQua.Location = new Point(59, 160);
            tbKetQua.Name = "tbKetQua";
            tbKetQua.ReadOnly = true;
            tbKetQua.Size = new Size(317, 27);
            tbKetQua.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 125);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 9;
            label2.Text = "Kết quả";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 72);
            label1.Name = "label1";
            label1.Size = new Size(157, 20);
            label1.TabIndex = 8;
            label1.Text = "Nhập số nguyên bất kì";
            // 
            // tbNhap
            // 
            tbNhap.Location = new Point(251, 69);
            tbNhap.Name = "tbNhap";
            tbNhap.Size = new Size(125, 27);
            tbNhap.TabIndex = 7;
            // 
            // FormBai3_1
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
            Name = "FormBai3_1";
            Text = "FormBai3_1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnThoat;
        private Button btnXoa;
        private Button btnDoc;
        private TextBox tbKetQua;
        private Label label2;
        private Label label1;
        private TextBox tbNhap;
    }
}