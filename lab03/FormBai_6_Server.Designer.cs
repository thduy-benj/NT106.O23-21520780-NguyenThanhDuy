namespace lab03
{
    partial class FormBai_6_Server
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
            lbLog = new ListBox();
            btnListen = new Button();
            SuspendLayout();
            // 
            // lbLog
            // 
            lbLog.FormattingEnabled = true;
            lbLog.ItemHeight = 20;
            lbLog.Location = new Point(12, 12);
            lbLog.Name = "lbLog";
            lbLog.Size = new Size(443, 424);
            lbLog.TabIndex = 0;
            // 
            // btnListen
            // 
            btnListen.Location = new Point(588, 12);
            btnListen.Name = "btnListen";
            btnListen.Size = new Size(94, 29);
            btnListen.TabIndex = 1;
            btnListen.Text = "Listen";
            btnListen.UseVisualStyleBackColor = true;
            btnListen.Click += btnListen_Click;
            // 
            // FormBai_6_Server
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnListen);
            Controls.Add(lbLog);
            Name = "FormBai_6_Server";
            Text = "FormBai_6_Server";
            ResumeLayout(false);
        }

        #endregion

        private ListBox lbLog;
        private Button btnListen;
    }
}