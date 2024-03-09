namespace lab01
{
    partial class FormBai7
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
            tbInfo = new TextBox();
            lbInfo = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 32);
            label1.Name = "label1";
            label1.Size = new Size(109, 20);
            label1.TabIndex = 0;
            label1.Text = "Nhập thông tin";
            // 
            // tbInfo
            // 
            tbInfo.Location = new Point(192, 29);
            tbInfo.Name = "tbInfo";
            tbInfo.Size = new Size(125, 27);
            tbInfo.TabIndex = 1;
            tbInfo.TextChanged += tbInfo_TextChanged;
            // 
            // lbInfo
            // 
            lbInfo.AutoSize = true;
            lbInfo.Location = new Point(66, 81);
            lbInfo.Name = "lbInfo";
            lbInfo.Size = new Size(0, 20);
            lbInfo.TabIndex = 2;
            // 
            // FormBai7
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(800, 450);
            Controls.Add(lbInfo);
            Controls.Add(tbInfo);
            Controls.Add(label1);
            Name = "FormBai7";
            Text = "FormBai7";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbInfo;
        private Label lbInfo;
    }
}