using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            hideAllPanel();
        }

        private void btnMngBook_Click(object sender, EventArgs e)
        {
            hideAllPanel();
            panelBook.Visible = true;
        }

        private void btnMngStu_Click(object sender, EventArgs e)
        {
            hideAllPanel();
            panelStudent.Visible = true;
        }
        public void hideAllPanel()
        {
            panelBook.Visible = false;
            panelStudent.Visible = false;
        }
    }
}
