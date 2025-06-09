namespace LibraryManagementSystem
{
    partial class formLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnLogin = new Button();
            btnExit = new Button();
            label1 = new Label();
            label2 = new Label();
            radioAdmin = new RadioButton();
            txtName = new TextBox();
            txtPw = new TextBox();
            radioUser = new RadioButton();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(151, 178);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(318, 178);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 1;
            btnExit.Text = "Exit ";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(44, 59);
            label1.Name = "label1";
            label1.Size = new Size(116, 28);
            label1.TabIndex = 2;
            label1.Text = "User Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(44, 111);
            label2.Name = "label2";
            label2.Size = new Size(101, 28);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // radioAdmin
            // 
            radioAdmin.AutoSize = true;
            radioAdmin.Location = new Point(457, 59);
            radioAdmin.Name = "radioAdmin";
            radioAdmin.Size = new Size(78, 24);
            radioAdmin.TabIndex = 4;
            radioAdmin.TabStop = true;
            radioAdmin.Text = "Admin ";
            radioAdmin.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            txtName.Location = new Point(196, 63);
            txtName.Name = "txtName";
            txtName.Size = new Size(168, 27);
            txtName.TabIndex = 5;
            // 
            // txtPw
            // 
            txtPw.Location = new Point(196, 112);
            txtPw.Name = "txtPw";
            txtPw.Size = new Size(168, 27);
            txtPw.TabIndex = 6;
            txtPw.UseSystemPasswordChar = true;
            // 
            // radioUser
            // 
            radioUser.AutoSize = true;
            radioUser.Location = new Point(457, 89);
            radioUser.Name = "radioUser";
            radioUser.Size = new Size(63, 24);
            radioUser.TabIndex = 7;
            radioUser.TabStop = true;
            radioUser.Text = "User ";
            radioUser.UseVisualStyleBackColor = true;
            // 
            // formLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(626, 246);
            Controls.Add(radioUser);
            Controls.Add(txtPw);
            Controls.Add(txtName);
            Controls.Add(radioAdmin);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnExit);
            Controls.Add(btnLogin);
            Name = "formLogin";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private Button btnExit;
        private Label label1;
        private Label label2;
        private RadioButton radioAdmin;
        private TextBox txtName;
        private TextBox txtPw;
        private RadioButton radioUser;
    }
}
