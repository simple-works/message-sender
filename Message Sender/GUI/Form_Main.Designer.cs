namespace MessageSender
{
    partial class Form_Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.textBox_message = new System.Windows.Forms.TextBox();
            this.richTextBox_messages = new System.Windows.Forms.RichTextBox();
            this.timer_refresh = new System.Windows.Forms.Timer(this.components);
            this.button_send = new System.Windows.Forms.Button();
            this.pictureBox_loading = new System.Windows.Forms.PictureBox();
            this.bgWorker_sendMessage = new System.ComponentModel.BackgroundWorker();
            this.bgWorker_getMessages = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_loading)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_message
            // 
            this.textBox_message.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_message.Location = new System.Drawing.Point(14, 320);
            this.textBox_message.Name = "textBox_message";
            this.textBox_message.Size = new System.Drawing.Size(440, 20);
            this.textBox_message.TabIndex = 0;
            this.textBox_message.TextChanged += new System.EventHandler(this.textBox_message_TextChanged);
            // 
            // richTextBox_messages
            // 
            this.richTextBox_messages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox_messages.Location = new System.Drawing.Point(14, 13);
            this.richTextBox_messages.Name = "richTextBox_messages";
            this.richTextBox_messages.ReadOnly = true;
            this.richTextBox_messages.Size = new System.Drawing.Size(523, 300);
            this.richTextBox_messages.TabIndex = 2;
            this.richTextBox_messages.Text = "";
            this.richTextBox_messages.Enter += new System.EventHandler(this.richTextBox_messages_Enter);
            // 
            // timer_refresh
            // 
            this.timer_refresh.Interval = 5000;
            this.timer_refresh.Tick += new System.EventHandler(this.timer_refresh_Tick);
            // 
            // button_send
            // 
            this.button_send.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_send.Image = global::MessageSender.Properties.Resources.right;
            this.button_send.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_send.Location = new System.Drawing.Point(460, 320);
            this.button_send.Name = "button_send";
            this.button_send.Size = new System.Drawing.Size(77, 22);
            this.button_send.TabIndex = 1;
            this.button_send.Text = "Send";
            this.button_send.UseVisualStyleBackColor = true;
            this.button_send.Click += new System.EventHandler(this.button_send_Click);
            // 
            // pictureBox_loading
            // 
            this.pictureBox_loading.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_loading.Image = global::MessageSender.Properties.Resources.loading;
            this.pictureBox_loading.Location = new System.Drawing.Point(35, 33);
            this.pictureBox_loading.Name = "pictureBox_loading";
            this.pictureBox_loading.Size = new System.Drawing.Size(480, 260);
            this.pictureBox_loading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_loading.TabIndex = 4;
            this.pictureBox_loading.TabStop = false;
            this.pictureBox_loading.Visible = false;
            // 
            // bgWorker_sendMessage
            // 
            this.bgWorker_sendMessage.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorker_sendMessage_DoWork);
            this.bgWorker_sendMessage.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWorker_sendMessage_RunWorkerCompleted);
            // 
            // bgWorker_getMessages
            // 
            this.bgWorker_getMessages.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorker_getMessages_DoWork);
            this.bgWorker_getMessages.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWorker_getMessages_RunWorkerCompleted);
            // 
            // Form_Main
            // 
            this.AcceptButton = this.button_send;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 355);
            this.Controls.Add(this.pictureBox_loading);
            this.Controls.Add(this.button_send);
            this.Controls.Add(this.textBox_message);
            this.Controls.Add(this.richTextBox_messages);
            this.Font = new System.Drawing.Font("Courier New", 8F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Message Sender";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Main_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_loading)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_message;
        private System.Windows.Forms.Button button_send;
        private System.Windows.Forms.RichTextBox richTextBox_messages;
        private System.Windows.Forms.Timer timer_refresh;
        private System.Windows.Forms.PictureBox pictureBox_loading;
        private System.ComponentModel.BackgroundWorker bgWorker_sendMessage;
        private System.ComponentModel.BackgroundWorker bgWorker_getMessages;
    }
}