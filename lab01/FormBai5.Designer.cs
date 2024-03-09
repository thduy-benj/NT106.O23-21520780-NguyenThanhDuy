namespace lab01
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
            label1 = new Label();
            tbA = new TextBox();
            label2 = new Label();
            tbB = new TextBox();
            cbChon = new ComboBox();
            btnTinh = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            lbKetQua = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 41);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 0;
            label1.Text = "Nhập A";
            // 
            // tbA
            // 
            tbA.Location = new Point(138, 37);
            tbA.Name = "tbA";
            tbA.Size = new Size(125, 27);
            tbA.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(508, 40);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 2;
            label2.Text = "Nhập B";
            // 
            // tbB
            // 
            tbB.Location = new Point(600, 37);
            tbB.Name = "tbB";
            tbB.Size = new Size(125, 27);
            tbB.TabIndex = 3;
            // 
            // cbChon
            // 
            cbChon.DropDownStyle = ComboBoxStyle.DropDownList;
            cbChon.FormattingEnabled = true;
            cbChon.Items.AddRange(new object[] { "Bảng cửu chương", "Tính toán giá trị" });
            cbChon.Location = new Point(328, 112);
            cbChon.Name = "cbChon";
            cbChon.Size = new Size(151, 28);
            cbChon.TabIndex = 4;
            cbChon.SelectedValueChanged += cbChon_SelectedValueChanged;
            // 
            // btnTinh
            // 
            btnTinh.AutoSize = true;
            btnTinh.Location = new Point(126, 167);
            btnTinh.Name = "btnTinh";
            btnTinh.Size = new Size(116, 30);
            btnTinh.TabIndex = 5;
            btnTinh.Text = "Tính các giá trị";
            btnTinh.UseVisualStyleBackColor = true;
            btnTinh.Click += btnTinh_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(356, 167);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 6;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(585, 167);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 7;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // lbKetQua
            // 
            lbKetQua.AutoSize = true;
            lbKetQua.Location = new Point(94, 250);
            lbKetQua.Name = "lbKetQua";
            lbKetQua.Size = new Size(0, 20);
            lbKetQua.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 216);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 9;
            label3.Text = "Kết quả";
            // 
            // FormBai5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(lbKetQua);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(btnTinh);
            Controls.Add(cbChon);
            Controls.Add(tbB);
            Controls.Add(label2);
            Controls.Add(tbA);
            Controls.Add(label1);
            Name = "FormBai5";
            Text = "FormBai5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbA;
        private Label label2;
        private TextBox tbB;
        private ComboBox cbChon;
        private Button btnTinh;
        private Button btnXoa;
        private Button btnThoat;
        private Label lbKetQua;
        private Label label3;
    }
}