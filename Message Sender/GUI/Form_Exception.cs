using System;
using System.Windows.Forms;

namespace MessageSender
{
    public partial class Form_Exception : Form
    {
        private readonly int _detailsAreaHeight;
        private bool _detailsVisible = false;

        public Form_Exception(Exception exception, string notice = null)
        {
            InitializeComponent();

            if (notice != null) label_notice.Text = notice;

            _detailsAreaHeight = textBox_details.Height;
            this.Height -= _detailsAreaHeight;

            textBox_details.Text = string.Format("{0}\r\n\r\nMore detailed:\r\n{1}",
                exception.Message, exception);
        }

        public static void Show(Exception exception, string notice = null, IWin32Window owner = null)
        {
            new Form_Exception(exception, notice).ShowDialog(owner);
        }

        private void linkLabel_showDetails_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Height += _detailsVisible ? -_detailsAreaHeight : _detailsAreaHeight;

            linkLabel_showDetails.Text = _detailsVisible
                ? "Hide technical details" : "Show technical details";

            _detailsVisible = !_detailsVisible;
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
