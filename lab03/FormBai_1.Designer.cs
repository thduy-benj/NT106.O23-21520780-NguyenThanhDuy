namespace lab03
{
    partial class FormBai_1
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
            btnUDPserver = new Button();
            btnUDPclient = new Button();
            SuspendLayout();
            // 
            // btnUDPserver
            // 
            btnUDPserver.Location = new Point(47, 45);
            btnUDPserver.Name = "btnUDPserver";
            btnUDPserver.Size = new Size(94, 29);
            btnUDPserver.TabIndex = 0;
            btnUDPserver.Text = "UDP server";
            btnUDPserver.UseVisualStyleBackColor = true;
            btnUDPserver.Click += btnUDPserver_Click;
            // 
            // btnUDPclient
            // 
            btnUDPclient.Location = new Point(378, 45);
            btnUDPclient.Name = "btnUDPclient";
            btnUDPclient.Size = new Size(94, 29);
            btnUDPclient.TabIndex = 1;
            btnUDPclient.Text = "UDP client";
            btnUDPclient.UseVisualStyleBackColor = true;
            btnUDPclient.Click += btnUDPclient_Click;
            // 
            // FormBai_1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(542, 138);
            Controls.Add(btnUDPclient);
            Controls.Add(btnUDPserver);
            Name = "FormBai_1";
            Text = "FormBai_1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnUDPserver;
        private Button btnUDPclient;
    }
}