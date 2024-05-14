namespace lab03
{
    partial class FormBai_3_Server
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
            lbChat = new ListBox();
            SuspendLayout();
            // 
            // btnListen
            // 
            btnListen.Location = new Point(36, 37);
            btnListen.Name = "btnListen";
            btnListen.Size = new Size(94, 29);
            btnListen.TabIndex = 0;
            btnListen.Text = "Listen";
            btnListen.UseVisualStyleBackColor = true;
            btnListen.Click += btnListen_Click;
            // 
            // lbChat
            // 
            lbChat.FormattingEnabled = true;
            lbChat.ItemHeight = 20;
            lbChat.Location = new Point(36, 108);
            lbChat.Name = "lbChat";
            lbChat.Size = new Size(729, 304);
            lbChat.TabIndex = 1;
            // 
            // FormBai_3_Server
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbChat);
            Controls.Add(btnListen);
            Name = "FormBai_3_Server";
            Text = "FormBai_3_Server";
            Leave += FormBai_3_Server_Leave;
            ResumeLayout(false);
        }

        #endregion

        private Button btnListen;
        private ListBox lbChat;
    }
}