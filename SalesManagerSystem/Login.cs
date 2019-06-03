using SalesManagerSystem.Controller;
using SalesManagerSystem.Resources;
using SalesManagerSystem.View;
using System;
using System.Windows.Forms;

namespace Sales_Manager_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void btnEntry_Click(object sender, EventArgs e)
        {
            string userLogin = txtUser.Text;
            string userPassword = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(userLogin) || string.IsNullOrWhiteSpace(userPassword))
                MessageBox.Show(Messages.MESSAGE_LOGIN_VOID);
            else
            {
                var userClient = new UserController().GetUserLogin(userLogin, userPassword);

                if (userClient == null)
                    LoginInvalid();
                else
                {
                    DisableScreenLogin();
                    ShowScreenMain();
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void EnableScreenLogin()
        {
            this.Enabled = true;
            this.Visible = true;

            ClearScreen();
        }

        private void ShowScreenMain()
        {
            Main main = new Main(this);
            main.StartPosition = FormStartPosition.CenterScreen;
            main.WindowState = FormWindowState.Maximized;
            main.MaximizeBox = false;
            main.Show();
        }

        private void DisableScreenLogin()
        {
            this.Enabled = false;
            this.Visible = false;
        }

        private void LoginInvalid()
        {
            MessageBox.Show(Messages.MESSAGE_USER_INVALID);
            this.ClearScreen();            
        }

        private void ClearScreen()
        {
            txtUser.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtUser.Focus();
        }
    }
}
