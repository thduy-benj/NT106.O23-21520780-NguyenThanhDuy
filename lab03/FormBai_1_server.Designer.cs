namespace lab03
{
    partial class FormBai_1_server
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
            tbPort = new TextBox();
            label1 = new Label();
            label2 = new Label();
            lbMessage = new ListBox();
            SuspendLayout();
            // 
            // btnListen
            // 
            btnListen.Location = new Point(334, 11);
            btnListen.Name = "btnListen";
            btnListen.Size = new Size(83, 27);
            btnListen.TabIndex = 0;
            btnListen.Text = "Listen";
            btnListen.UseVisualStyleBackColor = false;
            btnListen.Click += btnListen_Click;
            // 
            // tbPort
            // 
            tbPort.Location = new Point(77, 11);
            tbPort.Name = "tbPort";
            tbPort.Size = new Size(144, 27);
            tbPort.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 17);
            label1.Name = "label1";
            label1.Size = new Size(35, 20);
            label1.TabIndex = 2;
            label1.Text = "Port";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 61);
            label2.Name = "label2";
            label2.Size = new Size(128, 20);
            label2.TabIndex = 3;
            label2.Text = "Receive messages";
            // 
            // lbMessage
            // 
            lbMessage.BackColor = SystemColors.Control;
            lbMessage.FormattingEnabled = true;
            lbMessage.ItemHeight = 20;
            lbMessage.Location = new Point(12, 88);
            lbMessage.Name = "lbMessage";
            lbMessage.Size = new Size(458, 184);
            lbMessage.TabIndex = 4;
            // 
            // FormBai_1_server
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(492, 391);
            Controls.Add(lbMessage);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbPort);
            Controls.Add(btnListen);
            Name = "FormBai_1_server";
            Text = "FormBai_1_server";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnListen;
        private TextBox tbPort;
        private Label label1;
        private Label label2;
        private ListBox lbMessage;
    }
}