namespace LibraryManagementSystem
{
    partial class register
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnRegister = new Button();
            regClear = new Button();
            regName = new TextBox();
            regYear = new TextBox();
            regAge = new TextBox();
            regUserName = new TextBox();
            regPw = new TextBox();
            comboGender = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(112, 31);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 0;
            label1.Text = "Student Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(112, 89);
            label2.Name = "label2";
            label2.Size = new Size(37, 20);
            label2.TabIndex = 1;
            label2.Text = "Year";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(112, 138);
            label3.Name = "label3";
            label3.Size = new Size(36, 20);
            label3.TabIndex = 2;
            label3.Text = "Age";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(112, 193);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 3;
            label4.Text = "Gender";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(112, 249);
            label5.Name = "label5";
            label5.Size = new Size(76, 20);
            label5.TabIndex = 4;
            label5.Text = "userName";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(112, 314);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 5;
            label6.Text = "Password";
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(122, 391);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(94, 29);
            btnRegister.TabIndex = 6;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // regClear
            // 
            regClear.Location = new Point(279, 391);
            regClear.Name = "regClear";
            regClear.Size = new Size(94, 29);
            regClear.TabIndex = 7;
            regClear.Text = "Clear ";
            regClear.UseVisualStyleBackColor = true;
            // 
            // regName
            // 
            regName.Location = new Point(290, 24);
            regName.Name = "regName";
            regName.Size = new Size(125, 27);
            regName.TabIndex = 8;
            // 
            // regYear
            // 
            regYear.Location = new Point(290, 86);
            regYear.Name = "regYear";
            regYear.Size = new Size(125, 27);
            regYear.TabIndex = 9;
            // 
            // regAge
            // 
            regAge.Location = new Point(290, 135);
            regAge.Name = "regAge";
            regAge.Size = new Size(125, 27);
            regAge.TabIndex = 10;
            // 
            // regUserName
            // 
            regUserName.Location = new Point(290, 246);
            regUserName.Name = "regUserName";
            regUserName.Size = new Size(125, 27);
            regUserName.TabIndex = 12;
            // 
            // regPw
            // 
            regPw.Location = new Point(290, 311);
            regPw.Name = "regPw";
            regPw.Size = new Size(125, 27);
            regPw.TabIndex = 13;
            // 
            // comboGender
            // 
            comboGender.FormattingEnabled = true;
            comboGender.Location = new Point(290, 185);
            comboGender.Name = "comboGender";
            comboGender.Size = new Size(125, 28);
            comboGender.TabIndex = 14;
            // 
            // register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(545, 471);
            Controls.Add(comboGender);
            Controls.Add(regPw);
            Controls.Add(regUserName);
            Controls.Add(regAge);
            Controls.Add(regYear);
            Controls.Add(regName);
            Controls.Add(regClear);
            Controls.Add(btnRegister);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "register";
            Text = "register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnRegister;
        private Button regClear;
        private TextBox regName;
        private TextBox regYear;
        private TextBox regAge;
        private TextBox regUserName;
        private TextBox regPw;
        private ComboBox comboGender;
    }
}