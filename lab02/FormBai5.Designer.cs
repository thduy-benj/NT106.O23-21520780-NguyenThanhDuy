namespace lab02
{
    partial class FormBai5
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
            tbTenKH = new TextBox();
            label6 = new Label();
            clbC = new CheckedListBox();
            clbA = new CheckedListBox();
            clbB = new CheckedListBox();
            btnDatVe = new Button();
            label5 = new Label();
            cbPhong = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cbPhim = new ComboBox();
            btnLoad = new Button();
            label7 = new Label();
            btnXuat = new Button();
            SuspendLayout();
            // 
            // tbTenKH
            // 
            tbTenKH.Location = new Point(12, 40);
            tbTenKH.Name = "tbTenKH";
            tbTenKH.Size = new Size(307, 27);
            tbTenKH.TabIndex = 41;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(11, 8);
            label6.Name = "label6";
            label6.Size = new Size(111, 20);
            label6.TabIndex = 40;
            label6.Text = "Tên khách hàng";
            // 
            // clbC
            // 
            clbC.CheckOnClick = true;
            clbC.Enabled = false;
            clbC.FormattingEnabled = true;
            clbC.Items.AddRange(new object[] { "C1", "C2", "C3", "C4", "C5" });
            clbC.Location = new Point(148, 264);
            clbC.Name = "clbC";
            clbC.Size = new Size(62, 114);
            clbC.TabIndex = 39;
            // 
            // clbA
            // 
            clbA.CheckOnClick = true;
            clbA.Enabled = false;
            clbA.FormattingEnabled = true;
            clbA.Items.AddRange(new object[] { "A1", "A2", "A3", "A4", "A5" });
            clbA.Location = new Point(12, 264);
            clbA.Name = "clbA";
            clbA.Size = new Size(62, 114);
            clbA.TabIndex = 38;
            // 
            // clbB
            // 
            clbB.CheckOnClick = true;
            clbB.Enabled = false;
            clbB.FormattingEnabled = true;
            clbB.Items.AddRange(new object[] { "", "B2", "B3", "B4", "" });
            clbB.Location = new Point(80, 264);
            clbB.Name = "clbB";
            clbB.Size = new Size(62, 114);
            clbB.TabIndex = 37;
            // 
            // btnDatVe
            // 
            btnDatVe.Enabled = false;
            btnDatVe.Location = new Point(11, 411);
            btnDatVe.Name = "btnDatVe";
            btnDatVe.Size = new Size(94, 29);
            btnDatVe.TabIndex = 36;
            btnDatVe.Text = "Đặt vé";
            btnDatVe.UseVisualStyleBackColor = true;
            btnDatVe.Click += btnDatVe_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(168, 153);
            label5.Name = "label5";
            label5.Size = new Size(92, 20);
            label5.TabIndex = 35;
            label5.Text = "Phòng Chiếu";
            // 
            // cbPhong
            // 
            cbPhong.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPhong.Enabled = false;
            cbPhong.FormattingEnabled = true;
            cbPhong.Location = new Point(168, 183);
            cbPhong.Name = "cbPhong";
            cbPhong.Size = new Size(151, 28);
            cbPhong.TabIndex = 34;
            cbPhong.SelectedIndexChanged += cbPhong_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 153);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 33;
            label4.Text = "Tên phim";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(148, 241);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 32;
            label3.Text = "Hàng C";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(80, 241);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 31;
            label2.Text = "Hàng B";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 241);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 30;
            label1.Text = "Hàng A";
            // 
            // cbPhim
            // 
            cbPhim.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPhim.Enabled = false;
            cbPhim.FormattingEnabled = true;
            cbPhim.Items.AddRange(new object[] { "Đào, Phở và Piano", "Mai", "Gặp lại chị bầu", "Tarot" });
            cbPhim.Location = new Point(11, 183);
            cbPhim.Name = "cbPhim";
            cbPhim.Size = new Size(151, 28);
            cbPhim.TabIndex = 29;
            cbPhim.SelectedIndexChanged += cbPhim_SelectedIndexChanged;
            // 
            // btnLoad
            // 
            btnLoad.AutoSize = true;
            btnLoad.Location = new Point(97, 92);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(126, 30);
            btnLoad.TabIndex = 42;
            btnLoad.Text = "Read from a file";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 96);
            label7.Name = "label7";
            label7.Size = new Size(79, 20);
            label7.TabIndex = 43;
            label7.Text = "Tải dữ liệu";
            // 
            // btnXuat
            // 
            btnXuat.AutoSize = true;
            btnXuat.Location = new Point(148, 411);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(111, 30);
            btnXuat.TabIndex = 44;
            btnXuat.Text = "Xuất thống kê";
            btnXuat.UseVisualStyleBackColor = true;
            btnXuat.Click += btnXuat_Click;
            // 
            // FormBai5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnXuat);
            Controls.Add(label7);
            Controls.Add(btnLoad);
            Controls.Add(tbTenKH);
            Controls.Add(label6);
            Controls.Add(clbC);
            Controls.Add(clbA);
            Controls.Add(clbB);
            Controls.Add(btnDatVe);
            Controls.Add(label5);
            Controls.Add(cbPhong);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbPhim);
            Name = "FormBai5";
            Text = "Bài 5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbTenKH;
        private Label label6;
        private CheckedListBox clbC;
        private CheckedListBox clbA;
        private CheckedListBox clbB;
        private Button btnDatVe;
        private Label label5;
        private ComboBox cbPhong;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cbPhim;
        private Button btnLoad;
        private Label label7;
        private Button btnXuat;
    }
}