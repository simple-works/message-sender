using System;
using System.Windows.Forms;

namespace MessageSender
{
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();

            this.Text = string.Format("{0} - {1}", Application.CompanyName, this.Text);

            if (Session.UserLogged)
            {
                textBox_userName.Text = Session.CurrentUser.Name.ToString();
                textBox_userName.ReadOnly = true;
                textBox_userMAC.Text = Session.CurrentUser.MACAddress.ToString();
                button_login.Select();
            }
            else
            {
                textBox_userMAC.Text = Network.GetMACAddress();
                textBox_userName.Select();
            }

            UpdateLoginButton();
        }

        private void UpdateLoginButton()
        {
            button_login.Enabled = textBox_userName.Text.Trim() != string.Empty;
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            if (Session.UserLogged)
            {
                this.Hide();
                Form_Main form_main = new Form_Main();
                this.Owner = form_main;
                form_main.Show();
                form_main.Select();
                return;
            }

            string userName = textBox_userName.Text.Trim();

            if (userName == string.Empty)
            {
                errorProvider_main.SetError(textBox_userName, "Name is required.");
                return;
            }

            try
            {
                Session.Register(userName);
                Session.LogIn();
            }
            catch (Exception exception)
            {
                Form_Exception.Show(exception, "Could not log in.", this);
            }

            button_login_Click(sender, e);
        }

        private void textBox_userName_TextChanged(object sender, EventArgs e)
        {
            UpdateLoginButton();
        }
    }
}
