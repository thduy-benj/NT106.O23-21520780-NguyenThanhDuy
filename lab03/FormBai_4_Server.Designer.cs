namespace lab03
{
    partial class FormBai_4_Server
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
            btnListen = new Button();
            lbLog = new ListBox();
            SuspendLayout();
            // 
            // btnListen
            // 
            btnListen.Location = new Point(611, 21);
            btnListen.Name = "btnListen";
            btnListen.Size = new Size(94, 29);
            btnListen.TabIndex = 0;
            btnListen.Text = "Listen";
            btnListen.UseVisualStyleBackColor = true;
            btnListen.Click += btnListen_Click;
            // 
            // lbLog
            // 
            lbLog.FormattingEnabled = true;
            lbLog.ItemHeight = 20;
            lbLog.Location = new Point(12, 12);
            lbLog.Name = "lbLog";
            lbLog.Size = new Size(522, 424);
            lbLog.TabIndex = 1;
            // 
            // FormBai_4_Server
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbLog);
            Controls.Add(btnListen);
            Name = "FormBai_4_Server";
            Text = "FormBai_4_Server";
            Leave += FormBai_4_Server_Leave;
            ResumeLayout(false);
        }

        #endregion

        private Button btnListen;
        private ListBox lbLog;
    }
}