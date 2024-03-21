namespace lab02
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
            btnDoc = new Button();
            btnGhi = new Button();
            rTBKetQua = new RichTextBox();
            SuspendLayout();
            // 
            // btnDoc
            // 
            btnDoc.Location = new Point(55, 43);
            btnDoc.Name = "btnDoc";
            btnDoc.Size = new Size(94, 29);
            btnDoc.TabIndex = 0;
            btnDoc.Text = "Đọc file";
            btnDoc.UseVisualStyleBackColor = true;
            btnDoc.Click += btnDoc_Click;
            // 
            // btnGhi
            // 
            btnGhi.Location = new Point(401, 43);
            btnGhi.Name = "btnGhi";
            btnGhi.Size = new Size(94, 29);
            btnGhi.TabIndex = 1;
            btnGhi.Text = "Tính và Ghi";
            btnGhi.UseVisualStyleBackColor = true;
            // 
            // rTBKetQua
            // 
            rTBKetQua.Location = new Point(55, 106);
            rTBKetQua.Name = "rTBKetQua";
            rTBKetQua.Size = new Size(287, 175);
            rTBKetQua.TabIndex = 2;
            rTBKetQua.Text = "";
            // 
            // FormBai3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rTBKetQua);
            Controls.Add(btnGhi);
            Controls.Add(btnDoc);
            Name = "FormBai3";
            Text = "Bài 3";
            ResumeLayout(false);
        }

        #endregion

        private Button btnDoc;
        private Button btnGhi;
        private RichTextBox rTBKetQua;
    }
}