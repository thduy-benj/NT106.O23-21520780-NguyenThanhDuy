namespace lab01
{
    partial class FormBai4
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
            cbPhim = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cbPhong = new ComboBox();
            btnDatVe = new Button();
            clbB = new CheckedListBox();
            clbA = new CheckedListBox();
            clbC = new CheckedListBox();
            label6 = new Label();
            tbTenKH = new TextBox();
            SuspendLayout();
            // 
            // cbPhim
            // 
            cbPhim.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPhim.FormattingEnabled = true;
            cbPhim.Items.AddRange(new object[] { "Đào, Phở và Piano", "Mai", "Gặp lại chị bầu", "Tarot" });
            cbPhim.Location = new Point(30, 114);
            cbPhim.Name = "cbPhim";
            cbPhim.Size = new Size(151, 28);
            cbPhim.TabIndex = 1;
            cbPhim.SelectedIndexChanged += cbPhim_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 172);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 17;
            label1.Text = "Hàng A";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(103, 172);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 18;
            label2.Text = "Hàng B";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(167, 172);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 19;
            label3.Text = "Hàng C";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 84);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 20;
            label4.Text = "Tên phim";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(187, 84);
            label5.Name = "label5";
            label5.Size = new Size(92, 20);
            label5.TabIndex = 22;
            label5.Text = "Phòng Chiếu";
            // 
            // cbPhong
            // 
            cbPhong.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPhong.FormattingEnabled = true;
            cbPhong.Location = new Point(187, 114);
            cbPhong.Name = "cbPhong";
            cbPhong.Size = new Size(151, 28);
            cbPhong.TabIndex = 21;
            // 
            // btnDatVe
            // 
            btnDatVe.Location = new Point(30, 342);
            btnDatVe.Name = "btnDatVe";
            btnDatVe.Size = new Size(94, 29);
            btnDatVe.TabIndex = 23;
            btnDatVe.Text = "Đặt vé";
            btnDatVe.UseVisualStyleBackColor = true;
            btnDatVe.Click += btnDatVe_Click;
            // 
            // clbB
            // 
            clbB.CheckOnClick = true;
            clbB.FormattingEnabled = true;
            clbB.Items.AddRange(new object[] { "", "B2", "B3", "B4", "" });
            clbB.Location = new Point(99, 195);
            clbB.Name = "clbB";
            clbB.Size = new Size(62, 114);
            clbB.TabIndex = 24;
            // 
            // clbA
            // 
            clbA.CheckOnClick = true;
            clbA.FormattingEnabled = true;
            clbA.Items.AddRange(new object[] { "A1", "A2", "A3", "A4", "A5" });
            clbA.Location = new Point(31, 195);
            clbA.Name = "clbA";
            clbA.Size = new Size(62, 114);
            clbA.TabIndex = 25;
            // 
            // clbC
            // 
            clbC.CheckOnClick = true;
            clbC.FormattingEnabled = true;
            clbC.Items.AddRange(new object[] { "C1", "C2", "C3", "C4", "C5" });
            clbC.Location = new Point(167, 195);
            clbC.Name = "clbC";
            clbC.Size = new Size(62, 114);
            clbC.TabIndex = 26;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(30, 9);
            label6.Name = "label6";
            label6.Size = new Size(111, 20);
            label6.TabIndex = 27;
            label6.Text = "Tên khách hàng";
            // 
            // tbTenKH
            // 
            tbTenKH.Location = new Point(31, 41);
            tbTenKH.Name = "tbTenKH";
            tbTenKH.Size = new Size(307, 27);
            tbTenKH.TabIndex = 28;
            // 
            // FormBai4
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            Name = "FormBai4";
            Text = "FormBai4";
            Load += FormBai4_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox cbPhim;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cbPhong;
        private Button btnDatVe;
        private CheckedListBox clbB;
        private CheckedListBox clbA;
        private CheckedListBox clbC;
        private Label label6;
        private TextBox tbTenKH;
    }
}