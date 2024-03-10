namespace lab01
{
    partial class FormBai8
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
            btnThem = new Button();
            tbNhap = new TextBox();
            rtbMon = new RichTextBox();
            btnTim = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            label2 = new Label();
            tbKetQua = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(77, 38);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 0;
            label1.Text = "Nhập món ăn";
            // 
            // btnThem
            // 
            btnThem.Location = new Point(314, 68);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 1;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // tbNhap
            // 
            tbNhap.Location = new Point(204, 35);
            tbNhap.Name = "tbNhap";
            tbNhap.Size = new Size(204, 27);
            tbNhap.TabIndex = 2;
            // 
            // rtbMon
            // 
            rtbMon.Location = new Point(414, 35);
            rtbMon.Name = "rtbMon";
            rtbMon.Size = new Size(314, 191);
            rtbMon.TabIndex = 3;
            rtbMon.Text = "";
            rtbMon.TextChanged += rtbMon_TextChanged;
            // 
            // btnTim
            // 
            btnTim.Location = new Point(77, 272);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(107, 29);
            btnTim.TabIndex = 4;
            btnTim.Text = "Tìm món ăn";
            btnTim.UseVisualStyleBackColor = true;
            btnTim.Click += btnTim_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(342, 272);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 5;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(589, 272);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 6;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(313, 354);
            label2.Name = "label2";
            label2.Size = new Size(140, 20);
            label2.TabIndex = 7;
            label2.Text = "Món ăn hôm nay là ";
            // 
            // tbKetQua
            // 
            tbKetQua.Location = new Point(253, 391);
            tbKetQua.Name = "tbKetQua";
            tbKetQua.Size = new Size(268, 27);
            tbKetQua.TabIndex = 8;
            // 
            // FormBai8
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbKetQua);
            Controls.Add(label2);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(btnTim);
            Controls.Add(rtbMon);
            Controls.Add(tbNhap);
            Controls.Add(btnThem);
            Controls.Add(label1);
            Name = "FormBai8";
            Text = "FormBai8";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnThem;
        private TextBox tbNhap;
        private RichTextBox rtbMon;
        private Button btnTim;
        private Button btnXoa;
        private Button btnThoat;
        private Label label2;
        private TextBox tbKetQua;
    }
}