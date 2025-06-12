namespace LibraryManagementSystem
{
    partial class Student
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
            panel1 = new Panel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightBlue;
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button3);
            panel1.Location = new Point(2, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(197, 522);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(39, 56);
            button1.Name = "button1";
            button1.Size = new Size(109, 54);
            button1.TabIndex = 1;
            button1.Text = "Show Book";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(39, 373);
            button2.Name = "button2";
            button2.Size = new Size(109, 55);
            button2.TabIndex = 2;
            button2.Text = "Profile";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(39, 137);
            button3.Name = "button3";
            button3.Size = new Size(109, 55);
            button3.TabIndex = 3;
            button3.Text = "Search Book";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(39, 220);
            button4.Name = "button4";
            button4.Size = new Size(109, 55);
            button4.TabIndex = 4;
            button4.Text = "Cart";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(39, 290);
            button5.Name = "button5";
            button5.Size = new Size(109, 55);
            button5.TabIndex = 5;
            button5.Text = "Feedback";
            button5.UseVisualStyleBackColor = true;
            // 
            // Student
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1091, 562);
            Controls.Add(panel1);
            Name = "Student";
            Text = "Student";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button5;
        private Button button2;
        private Button button4;
        private Button button1;
        private Button button3;
    }
}