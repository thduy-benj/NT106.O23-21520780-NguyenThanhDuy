namespace lab02
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
            tvPath = new TreeView();
            gbFileContent = new GroupBox();
            SuspendLayout();
            // 
            // tvPath
            // 
            tvPath.Location = new Point(12, 12);
            tvPath.Name = "tvPath";
            tvPath.Size = new Size(226, 561);
            tvPath.TabIndex = 0;
            tvPath.NodeMouseDoubleClick += tvPath_NodeMouseDoubleClick;
            // 
            // gbFileContent
            // 
            gbFileContent.Location = new Point(276, 12);
            gbFileContent.Name = "gbFileContent";
            gbFileContent.Size = new Size(902, 561);
            gbFileContent.TabIndex = 1;
            gbFileContent.TabStop = false;
            gbFileContent.Text = "File content";
            // 
            // FormBai7
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1190, 585);
            Controls.Add(gbFileContent);
            Controls.Add(tvPath);
            Name = "FormBai7";
            Text = "Bài 7";
            Load += FormBai7_Load;
            ResumeLayout(false);
        }

        #endregion

        private TreeView tvPath;
        private GroupBox gbFileContent;
    }
}