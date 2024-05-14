namespace lab03
{
    partial class FormBai_1_client
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
            btnSend = new Button();
            tbMessage = new TextBox();
            tbIP = new TextBox();
            tbPort = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnSend
            // 
            btnSend.Location = new Point(13, 282);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(86, 36);
            btnSend.TabIndex = 0;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = false;
            btnSend.Click += btnSend_Click;
            // 
            // tbMessage
            // 
            tbMessage.Location = new Point(12, 116);
            tbMessage.Multiline = true;
            tbMessage.Name = "tbMessage";
            tbMessage.Size = new Size(506, 142);
            tbMessage.TabIndex = 1;
            // 
            // tbIP
            // 
            tbIP.Location = new Point(13, 34);
            tbIP.Name = "tbIP";
            tbIP.Size = new Size(198, 27);
            tbIP.TabIndex = 2;
            // 
            // tbPort
            // 
            tbPort.Location = new Point(374, 34);
            tbPort.Name = "tbPort";
            tbPort.Size = new Size(144, 27);
            tbPort.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 7);
            label1.Name = "label1";
            label1.Size = new Size(112, 20);
            label1.TabIndex = 4;
            label1.Text = "IP Remote Host";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(374, 7);
            label2.Name = "label2";
            label2.Size = new Size(35, 20);
            label2.TabIndex = 5;
            label2.Text = "Port";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 89);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 6;
            label3.Text = "Message";
            // 
            // FormBai_1_client
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(572, 373);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbPort);
            Controls.Add(tbIP);
            Controls.Add(tbMessage);
            Controls.Add(btnSend);
            Name = "FormBai_1_client";
            Text = "FormBai_1_client";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSend;
        private TextBox tbMessage;
        private TextBox tbIP;
        private TextBox tbPort;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}