using System.Data;

namespace LibraryManagementSystem
{
    public partial class formLogin : Form
    {

        public formLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtName.Text;
            string userPW = txtPw.Text;
            user us = new user(userName, userPW);
            string role = us.checkUser();
            if (role == "admin")
            {
                this.Hide();
                Form2 dashboard = new Form2();
                dashboard.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }
        public class user
        {
            private string userName;
            private string userPw;
            public user(string userName, string userPw)
            {
                this.userName = userName;
                this.userPw = userPw;
            }
            public string checkUser()
            {
                if (userName == "admin" && userPw == "adminPW")
                {
                    return "admin";
                }
                else
                {
                    return "invalid";
                }
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            register reg=new register();
            reg.ShowDialog();
        }
    }
}
