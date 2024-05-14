namespace lab03
{
    partial class FormBai_2
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
            tbMessage = new TextBox();
            SuspendLayout();
            // 
            // btnListen
            // 
            btnListen.Location = new Point(32, 39);
            btnListen.Margin = new Padding(2);
            btnListen.Name = "btnListen";
            btnListen.Size = new Size(89, 35);
            btnListen.TabIndex = 0;
            btnListen.Text = "Listen";
            btnListen.UseVisualStyleBackColor = false;
            btnListen.Click += btnListen_Click;
            // 
            // tbMessage
            // 
            tbMessage.BackColor = SystemColors.Control;
            tbMessage.Location = new Point(32, 111);
            tbMessage.Margin = new Padding(2);
            tbMessage.Multiline = true;
            tbMessage.Name = "tbMessage";
            tbMessage.ScrollBars = ScrollBars.Both;
            tbMessage.Size = new Size(422, 263);
            tbMessage.TabIndex = 2;
            // 
            // FormBai_2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(481, 401);
            Controls.Add(tbMessage);
            Controls.Add(btnListen);
            Margin = new Padding(2);
            Name = "FormBai_2";
            Text = "Lab3_bai2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnListen;
        private TextBox tbMessage;
    }
}