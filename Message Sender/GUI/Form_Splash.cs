using System;
using System.Windows.Forms;
using System.ComponentModel;

namespace MessageSender
{
    public partial class Form_Splash : Form
    {
        public Form_Splash()
        {
            InitializeComponent();
            if (!backgroundWorker_main.IsBusy) backgroundWorker_main.RunWorkerAsync();
        }

        private void backgroundWorker_main_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                Session.LogIn();
            }
            catch (Exception exception)
            {
                e.Result = exception;
            }
        }

        private void backgroundWorker_main_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Result is Exception)
            {
                Form_Exception.Show(e.Result as Exception, "Could not connect to network.", this);
                this.Close();
            }

            this.Controls.Clear();
            this.Hide();
            new Form_Login().Show();
        }
    }
}
