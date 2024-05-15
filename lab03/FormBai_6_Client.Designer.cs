namespace lab03
{
    partial class FormBai_6_Client
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
            tbUsrName = new TextBox();
            label1 = new Label();
            tbMessage = new TextBox();
            btnSend = new Button();
            btnDisconnect = new Button();
            btnConnect = new Button();
            lbChat = new ListBox();
            clbClients = new CheckedListBox();
            SuspendLayout();
            // 
            // tbUsrName
            // 
            tbUsrName.Location = new Point(104, 24);
            tbUsrName.Name = "tbUsrName";
            tbUsrName.Size = new Size(264, 27);
            tbUsrName.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 24);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 12;
            label1.Text = "Username";
            // 
            // tbMessage
            // 
            tbMessage.Location = new Point(23, 400);
            tbMessage.Name = "tbMessage";
            tbMessage.Size = new Size(545, 27);
            tbMessage.TabIndex = 11;
            // 
            // btnSend
            // 
            btnSend.Location = new Point(574, 398);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(94, 29);
            btnSend.TabIndex = 10;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // btnDisconnect
            // 
            btnDisconnect.Location = new Point(474, 22);
            btnDisconnect.Name = "btnDisconnect";
            btnDisconnect.Size = new Size(94, 29);
            btnDisconnect.TabIndex = 9;
            btnDisconnect.Text = "Disconnect";
            btnDisconnect.UseVisualStyleBackColor = true;
            btnDisconnect.Click += btnDisconnect_Click;
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(374, 22);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(94, 29);
            btnConnect.TabIndex = 8;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // lbChat
            // 
            lbChat.FormattingEnabled = true;
            lbChat.ItemHeight = 20;
            lbChat.Location = new Point(23, 81);
            lbChat.Name = "lbChat";
            lbChat.Size = new Size(545, 304);
            lbChat.TabIndex = 7;
            // 
            // clbClients
            // 
            clbClients.FormattingEnabled = true;
            clbClients.Location = new Point(574, 81);
            clbClients.Name = "clbClients";
            clbClients.Size = new Size(214, 290);
            clbClients.TabIndex = 14;
            // 
            // FormBai_6_Client
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(clbClients);
            Controls.Add(tbUsrName);
            Controls.Add(label1);
            Controls.Add(tbMessage);
            Controls.Add(btnSend);
            Controls.Add(btnDisconnect);
            Controls.Add(btnConnect);
            Controls.Add(lbChat);
            Name = "FormBai_6_Client";
            Text = "FormBai_6_Client";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbUsrName;
        private Label label1;
        private TextBox tbMessage;
        private Button btnSend;
        private Button btnDisconnect;
        private Button btnConnect;
        private ListBox lbChat;
        private CheckedListBox clbClients;
    }
}