namespace MessageSender
{
    partial class Form_Exception
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Exception));
            this.linkLabel_showDetails = new System.Windows.Forms.LinkLabel();
            this.textBox_details = new System.Windows.Forms.TextBox();
            this.button_OK = new System.Windows.Forms.Button();
            this.pictureBox_icon = new System.Windows.Forms.PictureBox();
            this.label_notice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_icon)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabel_showDetails
            // 
            this.linkLabel_showDetails.AutoSize = true;
            this.linkLabel_showDetails.Location = new System.Drawing.Point(13, 65);
            this.linkLabel_showDetails.Name = "linkLabel_showDetails";
            this.linkLabel_showDetails.Size = new System.Drawing.Size(161, 14);
            this.linkLabel_showDetails.TabIndex = 1;
            this.linkLabel_showDetails.TabStop = true;
            this.linkLabel_showDetails.Text = "Show technical details";
            this.linkLabel_showDetails.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_showDetails_LinkClicked);
            // 
            // textBox_details
            // 
            this.textBox_details.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_details.Location = new System.Drawing.Point(16, 90);
            this.textBox_details.Multiline = true;
            this.textBox_details.Name = "textBox_details";
            this.textBox_details.ReadOnly = true;
            this.textBox_details.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_details.Size = new System.Drawing.Size(301, 176);
            this.textBox_details.TabIndex = 3;
            // 
            // button_OK
            // 
            this.button_OK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_OK.Location = new System.Drawing.Point(242, 61);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(75, 23);
            this.button_OK.TabIndex = 2;
            this.button_OK.Text = "OK";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // pictureBox_icon
            // 
            this.pictureBox_icon.Image = global::MessageSender.Properties.Resources.error1;
            this.pictureBox_icon.Location = new System.Drawing.Point(16, 14);
            this.pictureBox_icon.Name = "pictureBox_icon";
            this.pictureBox_icon.Size = new System.Drawing.Size(38, 38);
            this.pictureBox_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_icon.TabIndex = 3;
            this.pictureBox_icon.TabStop = false;
            // 
            // label_notice
            // 
            this.label_notice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_notice.AutoEllipsis = true;
            this.label_notice.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Bold);
            this.label_notice.Location = new System.Drawing.Point(69, 14);
            this.label_notice.Name = "label_notice";
            this.label_notice.Size = new System.Drawing.Size(248, 38);
            this.label_notice.TabIndex = 4;
            this.label_notice.Text = "An error has occurred.";
            // 
            // Form_Exception
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 280);
            this.Controls.Add(this.label_notice);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.pictureBox_icon);
            this.Controls.Add(this.textBox_details);
            this.Controls.Add(this.linkLabel_showDetails);
            this.Font = new System.Drawing.Font("Courier New", 8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Exception";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Error";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel_showDetails;
        private System.Windows.Forms.TextBox textBox_details;
        private System.Windows.Forms.PictureBox pictureBox_icon;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Label label_notice;
    }
}