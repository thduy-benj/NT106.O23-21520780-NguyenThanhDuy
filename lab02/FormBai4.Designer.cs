namespace lab02
{
    partial class FormBai4
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
            label1 = new Label();
            btnWrite = new Button();
            btnRead = new Button();
            btnBack = new Button();
            btnNext = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            lbSTT = new Label();
            btnAdd = new Button();
            rTBKetQua = new RichTextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            tbInputName = new TextBox();
            tbInputID = new TextBox();
            tbInputPhone = new TextBox();
            tbInputMon1 = new TextBox();
            tbInputMon2 = new TextBox();
            tbInputMon3 = new TextBox();
            tbInputDTB = new TextBox();
            tbReadDTB = new TextBox();
            tbReadMon3 = new TextBox();
            tbReadMon2 = new TextBox();
            tbReadMon1 = new TextBox();
            tbReadPhone = new TextBox();
            tbReadID = new TextBox();
            tbReadName = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 84);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // btnWrite
            // 
            btnWrite.AutoSize = true;
            btnWrite.Location = new Point(35, 12);
            btnWrite.Name = "btnWrite";
            btnWrite.Size = new Size(110, 30);
            btnWrite.TabIndex = 1;
            btnWrite.Text = "Write to a file";
            btnWrite.UseVisualStyleBackColor = true;
            btnWrite.Click += btnWrite_Click;
            // 
            // btnRead
            // 
            btnRead.AutoSize = true;
            btnRead.Location = new Point(777, 21);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(126, 30);
            btnRead.TabIndex = 2;
            btnRead.Text = "Read from a file";
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += btnRead_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(754, 505);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 3;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(915, 505);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(94, 29);
            btnNext.TabIndex = 4;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 145);
            label2.Name = "label2";
            label2.Size = new Size(24, 20);
            label2.TabIndex = 5;
            label2.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 203);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 6;
            label3.Text = "Phone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 265);
            label4.Name = "label4";
            label4.Size = new Size(66, 20);
            label4.TabIndex = 7;
            label4.Text = "Course 1";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 325);
            label5.Name = "label5";
            label5.Size = new Size(66, 20);
            label5.TabIndex = 8;
            label5.Text = "Course 2";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 393);
            label6.Name = "label6";
            label6.Size = new Size(66, 20);
            label6.TabIndex = 9;
            label6.Text = "Course 3";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 452);
            label7.Name = "label7";
            label7.Size = new Size(64, 20);
            label7.TabIndex = 10;
            label7.Text = "Average";
            // 
            // lbSTT
            // 
            lbSTT.AutoSize = true;
            lbSTT.Location = new Point(877, 509);
            lbSTT.Name = "lbSTT";
            lbSTT.Size = new Size(17, 20);
            lbSTT.TabIndex = 18;
            lbSTT.Text = "0";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(35, 500);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 19;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // rTBKetQua
            // 
            rTBKetQua.Location = new Point(310, 23);
            rTBKetQua.Name = "rTBKetQua";
            rTBKetQua.Size = new Size(378, 513);
            rTBKetQua.TabIndex = 20;
            rTBKetQua.Text = "";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(694, 449);
            label8.Name = "label8";
            label8.Size = new Size(64, 20);
            label8.TabIndex = 27;
            label8.Text = "Average";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(694, 394);
            label9.Name = "label9";
            label9.Size = new Size(66, 20);
            label9.TabIndex = 26;
            label9.Text = "Course 3";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(694, 329);
            label10.Name = "label10";
            label10.Size = new Size(66, 20);
            label10.TabIndex = 25;
            label10.Text = "Course 2";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(694, 262);
            label11.Name = "label11";
            label11.Size = new Size(66, 20);
            label11.TabIndex = 24;
            label11.Text = "Course 1";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(694, 200);
            label12.Name = "label12";
            label12.Size = new Size(50, 20);
            label12.TabIndex = 23;
            label12.Text = "Phone";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(694, 142);
            label13.Name = "label13";
            label13.Size = new Size(24, 20);
            label13.TabIndex = 22;
            label13.Text = "ID";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(694, 81);
            label14.Name = "label14";
            label14.Size = new Size(49, 20);
            label14.TabIndex = 21;
            label14.Text = "Name";
            // 
            // tbInputName
            // 
            tbInputName.Location = new Point(86, 84);
            tbInputName.Name = "tbInputName";
            tbInputName.Size = new Size(218, 27);
            tbInputName.TabIndex = 28;
            // 
            // tbInputID
            // 
            tbInputID.Location = new Point(86, 145);
            tbInputID.Name = "tbInputID";
            tbInputID.Size = new Size(218, 27);
            tbInputID.TabIndex = 29;
            // 
            // tbInputPhone
            // 
            tbInputPhone.Location = new Point(86, 203);
            tbInputPhone.Name = "tbInputPhone";
            tbInputPhone.Size = new Size(218, 27);
            tbInputPhone.TabIndex = 30;
            // 
            // tbInputMon1
            // 
            tbInputMon1.Location = new Point(86, 262);
            tbInputMon1.Name = "tbInputMon1";
            tbInputMon1.Size = new Size(218, 27);
            tbInputMon1.TabIndex = 31;
            // 
            // tbInputMon2
            // 
            tbInputMon2.Location = new Point(86, 325);
            tbInputMon2.Name = "tbInputMon2";
            tbInputMon2.Size = new Size(218, 27);
            tbInputMon2.TabIndex = 32;
            // 
            // tbInputMon3
            // 
            tbInputMon3.Location = new Point(86, 390);
            tbInputMon3.Name = "tbInputMon3";
            tbInputMon3.Size = new Size(218, 27);
            tbInputMon3.TabIndex = 33;
            // 
            // tbInputDTB
            // 
            tbInputDTB.Enabled = false;
            tbInputDTB.Location = new Point(86, 452);
            tbInputDTB.Name = "tbInputDTB";
            tbInputDTB.Size = new Size(218, 27);
            tbInputDTB.TabIndex = 34;
            // 
            // tbReadDTB
            // 
            tbReadDTB.Location = new Point(791, 452);
            tbReadDTB.Name = "tbReadDTB";
            tbReadDTB.Size = new Size(218, 27);
            tbReadDTB.TabIndex = 41;
            // 
            // tbReadMon3
            // 
            tbReadMon3.Location = new Point(791, 390);
            tbReadMon3.Name = "tbReadMon3";
            tbReadMon3.Size = new Size(218, 27);
            tbReadMon3.TabIndex = 40;
            // 
            // tbReadMon2
            // 
            tbReadMon2.Location = new Point(791, 325);
            tbReadMon2.Name = "tbReadMon2";
            tbReadMon2.Size = new Size(218, 27);
            tbReadMon2.TabIndex = 39;
            // 
            // tbReadMon1
            // 
            tbReadMon1.Location = new Point(791, 262);
            tbReadMon1.Name = "tbReadMon1";
            tbReadMon1.Size = new Size(218, 27);
            tbReadMon1.TabIndex = 38;
            // 
            // tbReadPhone
            // 
            tbReadPhone.Location = new Point(791, 203);
            tbReadPhone.Name = "tbReadPhone";
            tbReadPhone.Size = new Size(218, 27);
            tbReadPhone.TabIndex = 37;
            // 
            // tbReadID
            // 
            tbReadID.Location = new Point(791, 145);
            tbReadID.Name = "tbReadID";
            tbReadID.Size = new Size(218, 27);
            tbReadID.TabIndex = 36;
            // 
            // tbReadName
            // 
            tbReadName.Location = new Point(791, 84);
            tbReadName.Name = "tbReadName";
            tbReadName.Size = new Size(218, 27);
            tbReadName.TabIndex = 35;
            // 
            // FormBai4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1021, 578);
            Controls.Add(tbReadDTB);
            Controls.Add(tbReadMon3);
            Controls.Add(tbReadMon2);
            Controls.Add(tbReadMon1);
            Controls.Add(tbReadPhone);
            Controls.Add(tbReadID);
            Controls.Add(tbReadName);
            Controls.Add(tbInputDTB);
            Controls.Add(tbInputMon3);
            Controls.Add(tbInputMon2);
            Controls.Add(tbInputMon1);
            Controls.Add(tbInputPhone);
            Controls.Add(tbInputID);
            Controls.Add(tbInputName);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(label13);
            Controls.Add(label14);
            Controls.Add(rTBKetQua);
            Controls.Add(btnAdd);
            Controls.Add(lbSTT);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnNext);
            Controls.Add(btnBack);
            Controls.Add(btnRead);
            Controls.Add(btnWrite);
            Controls.Add(label1);
            Name = "FormBai4";
            Text = "FormBai4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnWrite;
        private Button btnRead;
        private Button btnBack;
        private Button btnNext;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label lbSTT;
        private Button btnAdd;
        private RichTextBox rTBKetQua;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private TextBox tbInputName;
        private TextBox tbInputID;
        private TextBox tbInputPhone;
        private TextBox tbInputMon1;
        private TextBox tbInputMon2;
        private TextBox tbInputMon3;
        private TextBox tbInputDTB;
        private TextBox tbReadDTB;
        private TextBox tbReadMon3;
        private TextBox tbReadMon2;
        private TextBox tbReadMon1;
        private TextBox tbReadPhone;
        private TextBox tbReadID;
        private TextBox tbReadName;
    }
}