﻿namespace lab03
{
    partial class FormBai_6
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
            btnServer = new Button();
            btnClient = new Button();
            SuspendLayout();
            // 
            // btnServer
            // 
            btnServer.Location = new Point(90, 60);
            btnServer.Name = "btnServer";
            btnServer.Size = new Size(94, 29);
            btnServer.TabIndex = 0;
            btnServer.Text = "Server";
            btnServer.UseVisualStyleBackColor = true;
            btnServer.Click += btnServer_Click;
            // 
            // btnClient
            // 
            btnClient.Location = new Point(90, 114);
            btnClient.Name = "btnClient";
            btnClient.Size = new Size(94, 29);
            btnClient.TabIndex = 1;
            btnClient.Text = "Client";
            btnClient.UseVisualStyleBackColor = true;
            btnClient.Click += btnClient_Click;
            // 
            // FormBai_6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(297, 226);
            Controls.Add(btnClient);
            Controls.Add(btnServer);
            Name = "FormBai_6";
            Text = "FormBai_6";
            ResumeLayout(false);
        }

        #endregion

        private Button btnServer;
        private Button btnClient;
    }
}