namespace lab02
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
            btnDoc = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            tbCharCount = new TextBox();
            tbWordCount = new TextBox();
            tbLineCount = new TextBox();
            tbURL = new TextBox();
            tbSize = new TextBox();
            tbFileName = new TextBox();
            rTBKetQua = new RichTextBox();
            btnExit = new Button();
            SuspendLayout();
            // 
            // btnDoc
            // 
            btnDoc.Location = new Point(30, 33);
            btnDoc.Name = "btnDoc";
            btnDoc.Size = new Size(94, 29);
            btnDoc.TabIndex = 0;
            btnDoc.Text = "Đọc File";
            btnDoc.UseVisualStyleBackColor = true;
            btnDoc.Click += btnDoc_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 89);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 1;
            label1.Text = "File name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 136);
            label2.Name = "label2";
            label2.Size = new Size(36, 20);
            label2.TabIndex = 2;
            label2.Text = "Size";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 189);
            label3.Name = "label3";
            label3.Size = new Size(35, 20);
            label3.TabIndex = 3;
            label3.Text = "URL";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 240);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 4;
            label4.Text = "Line count";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 289);
            label5.Name = "label5";
            label5.Size = new Size(86, 20);
            label5.TabIndex = 5;
            label5.Text = "Word count";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(30, 341);
            label6.Name = "label6";
            label6.Size = new Size(113, 20);
            label6.TabIndex = 6;
            label6.Text = "Character count";
            // 
            // tbCharCount
            // 
            tbCharCount.Location = new Point(149, 341);
            tbCharCount.Name = "tbCharCount";
            tbCharCount.Size = new Size(220, 27);
            tbCharCount.TabIndex = 7;
            // 
            // tbWordCount
            // 
            tbWordCount.Location = new Point(149, 286);
            tbWordCount.Name = "tbWordCount";
            tbWordCount.Size = new Size(220, 27);
            tbWordCount.TabIndex = 8;
            // 
            // tbLineCount
            // 
            tbLineCount.Location = new Point(149, 240);
            tbLineCount.Name = "tbLineCount";
            tbLineCount.Size = new Size(220, 27);
            tbLineCount.TabIndex = 9;
            // 
            // tbURL
            // 
            tbURL.Location = new Point(149, 189);
            tbURL.Name = "tbURL";
            tbURL.Size = new Size(220, 27);
            tbURL.TabIndex = 10;
            // 
            // tbSize
            // 
            tbSize.Location = new Point(149, 136);
            tbSize.Name = "tbSize";
            tbSize.Size = new Size(220, 27);
            tbSize.TabIndex = 11;
            // 
            // tbFileName
            // 
            tbFileName.Location = new Point(149, 86);
            tbFileName.Name = "tbFileName";
            tbFileName.Size = new Size(220, 27);
            tbFileName.TabIndex = 12;
            // 
            // rTBKetQua
            // 
            rTBKetQua.Location = new Point(384, 28);
            rTBKetQua.Name = "rTBKetQua";
            rTBKetQua.Size = new Size(404, 383);
            rTBKetQua.TabIndex = 13;
            rTBKetQua.Text = "";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(34, 390);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 14;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // FormBai2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(rTBKetQua);
            Controls.Add(tbFileName);
            Controls.Add(tbSize);
            Controls.Add(tbURL);
            Controls.Add(tbLineCount);
            Controls.Add(tbWordCount);
            Controls.Add(tbCharCount);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnDoc);
            Name = "FormBai2";
            Text = "Bài 2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDoc;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox tbCharCount;
        private TextBox tbWordCount;
        private TextBox tbLineCount;
        private TextBox tbURL;
        private TextBox tbSize;
        private TextBox tbFileName;
        private RichTextBox rTBKetQua;
        private Button btnExit;
    }
}