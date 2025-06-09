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
            btnMngBook = new Button();
            btnLogOut = new Button();
            btnReport = new Button();
            BtnRtnBook = new Button();
            btnIssBook = new Button();
            btnMngStu = new Button();
            panelBook = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            bookTitle = new TextBox();
            bookAuthor = new TextBox();
            BookISBN = new TextBox();
            bookCategory = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            panelStudent = new Panel();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            panelBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panelStudent.SuspendLayout();
            SuspendLayout();
            // 
            // btnMngBook
            // 
            btnMngBook.BackColor = Color.LightCyan;
            btnMngBook.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMngBook.Image = Properties.Resources.stack_of_books1;
            btnMngBook.ImageAlign = ContentAlignment.MiddleLeft;
            btnMngBook.Location = new Point(26, 21);
            btnMngBook.Name = "btnMngBook";
            btnMngBook.Size = new Size(103, 50);
            btnMngBook.TabIndex = 0;
            btnMngBook.Text = "Manage Book";
            btnMngBook.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMngBook.UseVisualStyleBackColor = false;
            btnMngBook.Click += btnMngBook_Click;
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.LightCyan;
            btnLogOut.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogOut.Image = Properties.Resources.logout;
            btnLogOut.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogOut.Location = new Point(571, 21);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(103, 50);
            btnLogOut.TabIndex = 1;
            btnLogOut.Text = "LogOut";
            btnLogOut.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLogOut.UseVisualStyleBackColor = false;
            // 
            // btnReport
            // 
            btnReport.BackColor = Color.LightCyan;
            btnReport.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReport.Image = Properties.Resources.seo_report;
            btnReport.ImageAlign = ContentAlignment.MiddleLeft;
            btnReport.Location = new Point(462, 21);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(103, 50);
            btnReport.TabIndex = 2;
            btnReport.Text = "Reports";
            btnReport.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReport.UseVisualStyleBackColor = false;
            // 
            // BtnRtnBook
            // 
            BtnRtnBook.BackColor = Color.LightCyan;
            BtnRtnBook.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnRtnBook.Image = Properties.Resources._return;
            BtnRtnBook.ImageAlign = ContentAlignment.MiddleLeft;
            BtnRtnBook.Location = new Point(353, 21);
            BtnRtnBook.Name = "BtnRtnBook";
            BtnRtnBook.Size = new Size(103, 50);
            BtnRtnBook.TabIndex = 3;
            BtnRtnBook.Text = "Return Book";
            BtnRtnBook.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnRtnBook.UseVisualStyleBackColor = false;
            // 
            // btnIssBook
            // 
            btnIssBook.BackColor = Color.LightCyan;
            btnIssBook.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIssBook.Image = Properties.Resources.return__1_;
            btnIssBook.ImageAlign = ContentAlignment.MiddleLeft;
            btnIssBook.Location = new Point(244, 21);
            btnIssBook.Name = "btnIssBook";
            btnIssBook.Size = new Size(103, 50);
            btnIssBook.TabIndex = 4;
            btnIssBook.Text = "Issue Book";
            btnIssBook.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnIssBook.UseVisualStyleBackColor = false;
            // 
            // btnMngStu
            // 
            btnMngStu.BackColor = Color.LightCyan;
            btnMngStu.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMngStu.Image = Properties.Resources.graduated;
            btnMngStu.ImageAlign = ContentAlignment.MiddleLeft;
            btnMngStu.Location = new Point(135, 21);
            btnMngStu.Name = "btnMngStu";
            btnMngStu.Size = new Size(103, 50);
            btnMngStu.TabIndex = 5;
            btnMngStu.Text = "Manage Student";
            btnMngStu.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMngStu.UseVisualStyleBackColor = false;
            btnMngStu.Click += btnMngStu_Click;
            // 
            // panelBook
            // 
            panelBook.BackColor = Color.LightSkyBlue;
            panelBook.Controls.Add(dataGridView1);
            panelBook.Controls.Add(button3);
            panelBook.Controls.Add(button2);
            panelBook.Controls.Add(button1);
            panelBook.Controls.Add(bookCategory);
            panelBook.Controls.Add(BookISBN);
            panelBook.Controls.Add(bookAuthor);
            panelBook.Controls.Add(bookTitle);
            panelBook.Controls.Add(label4);
            panelBook.Controls.Add(label3);
            panelBook.Controls.Add(label2);
            panelBook.Controls.Add(label1);
            panelBook.Location = new Point(124, 143);
            panelBook.Name = "panelBook";
            panelBook.Size = new Size(985, 385);
            panelBook.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(102, 50);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 0;
            label1.Text = "Title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(102, 110);
            label2.Name = "label2";
            label2.Size = new Size(63, 23);
            label2.TabIndex = 1;
            label2.Text = "Author";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(102, 173);
            label3.Name = "label3";
            label3.Size = new Size(47, 23);
            label3.TabIndex = 2;
            label3.Text = "ISBN";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(102, 227);
            label4.Name = "label4";
            label4.Size = new Size(81, 23);
            label4.TabIndex = 3;
            label4.Text = "Category";
            // 
            // bookTitle
            // 
            bookTitle.Location = new Point(294, 50);
            bookTitle.Name = "bookTitle";
            bookTitle.Size = new Size(125, 27);
            bookTitle.TabIndex = 4;
            // 
            // bookAuthor
            // 
            bookAuthor.Location = new Point(294, 107);
            bookAuthor.Name = "bookAuthor";
            bookAuthor.Size = new Size(125, 27);
            bookAuthor.TabIndex = 5;
            // 
            // BookISBN
            // 
            BookISBN.Location = new Point(294, 170);
            BookISBN.Name = "BookISBN";
            BookISBN.Size = new Size(125, 27);
            BookISBN.TabIndex = 6;
            // 
            // bookCategory
            // 
            bookCategory.Location = new Point(294, 224);
            bookCategory.Name = "bookCategory";
            bookCategory.Size = new Size(125, 27);
            bookCategory.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(77, 299);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 8;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(213, 299);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 9;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(380, 299);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 10;
            button3.Text = "Search";
            button3.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(512, 50);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(438, 278);
            dataGridView1.TabIndex = 11;
            // 
            // panelStudent
            // 
            panelStudent.BackColor = Color.LightSkyBlue;
            panelStudent.Controls.Add(textBox4);
            panelStudent.Controls.Add(textBox3);
            panelStudent.Controls.Add(textBox2);
            panelStudent.Controls.Add(textBox1);
            panelStudent.Controls.Add(button6);
            panelStudent.Controls.Add(button5);
            panelStudent.Controls.Add(button4);
            panelStudent.Controls.Add(label8);
            panelStudent.Controls.Add(label7);
            panelStudent.Controls.Add(label6);
            panelStudent.Controls.Add(label5);
            panelStudent.Location = new Point(182, 110);
            panelStudent.Name = "panelStudent";
            panelStudent.Size = new Size(1005, 403);
            panelStudent.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(131, 53);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 0;
            label5.Text = "label5";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(131, 103);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 1;
            label6.Text = "label6";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(131, 145);
            label7.Name = "label7";
            label7.Size = new Size(50, 20);
            label7.TabIndex = 2;
            label7.Text = "label7";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(131, 205);
            label8.Name = "label8";
            label8.Size = new Size(50, 20);
            label8.TabIndex = 3;
            label8.Text = "label8";
            // 
            // button4
            // 
            button4.Location = new Point(87, 315);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 4;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(255, 315);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 5;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(411, 315);
            button6.Name = "button6";
            button6.Size = new Size(94, 29);
            button6.TabIndex = 6;
            button6.Text = "button6";
            button6.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(323, 201);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(322, 142);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(322, 96);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(322, 50);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 10;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1445, 692);
            Controls.Add(panelStudent);
            Controls.Add(panelBook);
            Controls.Add(btnMngStu);
            Controls.Add(btnIssBook);
            Controls.Add(BtnRtnBook);
            Controls.Add(btnReport);
            Controls.Add(btnLogOut);
            Controls.Add(btnMngBook);
            Name = "Form2";
            Text = "Form2";
            panelBook.ResumeLayout(false);
            panelBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panelStudent.ResumeLayout(false);
            panelStudent.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnMngBook;
        private Button btnLogOut;
        private Button btnReport;
        private Button BtnRtnBook;
        private Button btnIssBook;
        private Button btnMngStu;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Panel panelBook;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox bookCategory;
        private TextBox BookISBN;
        private TextBox bookAuthor;
        private TextBox bookTitle;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
        private Panel panelStudent;
        private TextBox textBox1;
        private Button button6;
        private Button button5;
        private Button button4;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
    }
}