﻿namespace lab02
{
    partial class FormBai1
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
            btnDoc.Location = new Point(48, 50);
            btnDoc.Name = "btnDoc";
            btnDoc.Size = new Size(94, 29);
            btnDoc.TabIndex = 0;
            btnDoc.Text = "Đọc file";
            btnDoc.UseVisualStyleBackColor = true;
            btnDoc.Click += btnDoc_Click;
            // 
            // btnGhi
            // 
            btnGhi.Location = new Point(48, 111);
            btnGhi.Name = "btnGhi";
            btnGhi.Size = new Size(94, 29);
            btnGhi.TabIndex = 1;
            btnGhi.Text = "Ghi file";
            btnGhi.UseVisualStyleBackColor = true;
            btnGhi.Click += btnGhi_Click;
            // 
            // rTBKetQua
            // 
            rTBKetQua.Location = new Point(168, 50);
            rTBKetQua.Name = "rTBKetQua";
            rTBKetQua.Size = new Size(579, 307);
            rTBKetQua.TabIndex = 2;
            rTBKetQua.Text = "";
            // 
            // FormBai1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rTBKetQua);
            Controls.Add(btnGhi);
            Controls.Add(btnDoc);
            Name = "FormBai1";
            Text = "Bài 1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnDoc;
        private Button btnGhi;
        private RichTextBox rTBKetQua;
    }
}