using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.ComponentModel;

namespace MessageSender
{
    public partial class Form_Main : Form
    {
        public enum State { Initial, SendingMessage, MessageSent }

        public Form_Main()
        {
            InitializeComponent();

            this.Text += string.Format(" - {0} ({1})", Session.CurrentUser.Name, Session.CurrentUser.MACAddress);

            UpdateSendButton();
            textBox_message.Select();

            richTextBox_messages.SelectionLength = 0;
            richTextBox_messages.SelectionIndent = 10;

            RefreshMessages();
            timer_refresh.Start();
        }

        private void SetState(State state)
        {
            switch (state)
            {
                case State.Initial:
                    break;

                case State.SendingMessage:
                    pictureBox_loading.Visible = true;

                    button_send.Enabled = false;

                    textBox_message.Enabled = false;

                    richTextBox_messages.Enabled = false;
                    richTextBox_messages.Text = "(Loading Messages...)";
                    richTextBox_messages.SuspendDrawing();
                    break;

                case State.MessageSent:
                    pictureBox_loading.Visible = false;

                    button_send.Enabled = true;

                    textBox_message.Enabled = true;
                    textBox_message.Clear();
                    textBox_message.Focus();
                    textBox_message.Select();

                    richTextBox_messages.Enabled = true;
                    richTextBox_messages.ResumeDrawing();
                    richTextBox_messages.ScrollToCaret();
                    break;

                default:
                    break;
            }
        }

        private void SendMessage()
        {
            SetState(State.SendingMessage);

            string messageContent = textBox_message.Text.Trim();
            if (messageContent == string.Empty) return;

            if (!bgWorker_sendMessage.IsBusy)
            {
                textBox_message.Text = "(Sending message...)";
                bgWorker_sendMessage.RunWorkerAsync(new Message(messageContent));
            }

        }

        private void RefreshMessages()
        {
            if (!bgWorker_getMessages.IsBusy)
                bgWorker_getMessages.RunWorkerAsync();
        }

        private void UpdateSendButton()
        {
            button_send.Enabled = textBox_message.Text.Trim() != string.Empty;
        }

        private void button_send_Click(object sender, EventArgs e)
        {
            SendMessage();
        }

        private void textBox_message_TextChanged(object sender, EventArgs e)
        {
            UpdateSendButton();
        }

        private void richTextBox_messages_Enter(object sender, EventArgs e)
        {
            RefreshMessages();
        }

        private void timer_refresh_Tick(object sender, EventArgs e)
        {
            RefreshMessages();
        }

        private void bgWorker_sendMessage_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                Messages.Add(e.Argument as Message);
            }
            catch (Exception exception)
            {
                e.Result = exception;
            }
        }

        private void bgWorker_sendMessage_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Result is Exception)
            {
                Form_Exception.Show(e.Result as Exception, "Could not send message.", this);
                return;
            }

            SetState(State.MessageSent);
            RefreshMessages();
        }

        private void bgWorker_getMessages_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                e.Result = Messages.Get();
            }
            catch (Exception exception)
            {
                e.Result = exception;
            }
        }

        private void bgWorker_getMessages_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Result is Exception || !(e.Result is List<Message>))
            {
                Form_Exception.Show(e.Result as Exception, "Could not load messages.", this);
                return;
            }

            float zoomFactor = richTextBox_messages.ZoomFactor;
            richTextBox_messages.Clear();
            List<Message> messages = e.Result as List<Message>;

            if (messages.Count == 0)
            {
                richTextBox_messages.AppendText("(No messages yet.)");
                return;
            }

            var latestMessages = messages.TakeLast(richTextBox_messages.Height / 10);

            foreach (Message message in latestMessages)
            {
                object senderUserName = Users.Get("id", message.SenderID).Name;
                richTextBox_messages.AppendText(string.Format("[{0}] {1}: {2}\r\n",
                    Miscellaneous.GetRelativeTimeString(message.SendingDate),
                    senderUserName, message.Content));
                richTextBox_messages.SelectionColor = Color.FromArgb(
                    Convert.ToInt32(message.SenderID) * 1000);
            }

            richTextBox_messages.SetZoomFactor(zoomFactor);
            richTextBox_messages.ScrollToCaret();
        }

        private void Form_Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
