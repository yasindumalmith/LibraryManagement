namespace LibraryManagementSystem
{
    partial class Form2
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.LightCyan;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Image = Properties.Resources.stack_of_books1;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(26, 21);
            button1.Name = "button1";
            button1.Size = new Size(103, 50);
            button1.TabIndex = 0;
            button1.Text = "Manage Book";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.LightCyan;
            button2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Image = Properties.Resources.logout;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(571, 21);
            button2.Name = "button2";
            button2.Size = new Size(103, 50);
            button2.TabIndex = 1;
            button2.Text = "LogOut";
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.LightCyan;
            button3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Image = Properties.Resources.seo_report;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(462, 21);
            button3.Name = "button3";
            button3.Size = new Size(103, 50);
            button3.TabIndex = 2;
            button3.Text = "Reports";
            button3.TextImageRelation = TextImageRelation.ImageBeforeText;
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.LightCyan;
            button4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Image = Properties.Resources._return;
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(353, 21);
            button4.Name = "button4";
            button4.Size = new Size(103, 50);
            button4.TabIndex = 3;
            button4.Text = "Return Book";
            button4.TextImageRelation = TextImageRelation.ImageBeforeText;
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.LightCyan;
            button5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Image = Properties.Resources.return__1_;
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(244, 21);
            button5.Name = "button5";
            button5.Size = new Size(103, 50);
            button5.TabIndex = 4;
            button5.Text = "Issue Book";
            button5.TextImageRelation = TextImageRelation.ImageBeforeText;
            button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.LightCyan;
            button6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.Image = Properties.Resources.graduated;
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(135, 21);
            button6.Name = "button6";
            button6.Size = new Size(103, 50);
            button6.TabIndex = 5;
            button6.Text = "Manage Student";
            button6.TextImageRelation = TextImageRelation.ImageBeforeText;
            button6.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Location = new Point(164, 242);
            panel1.Name = "panel1";
            panel1.Size = new Size(450, 299);
            panel1.TabIndex = 6;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1179, 596);
            Controls.Add(panel1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Panel panel1;
    }
}