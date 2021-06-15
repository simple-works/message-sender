namespace MessageSender
{
    partial class Form_Splash
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
            this.panel_main = new System.Windows.Forms.Panel();
            this.label_connecting = new System.Windows.Forms.Label();
            this.label_title = new System.Windows.Forms.Label();
            this.progressBar_loading = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker_main = new System.ComponentModel.BackgroundWorker();
            this.panel_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_main
            // 
            this.panel_main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_main.Controls.Add(this.label_connecting);
            this.panel_main.Controls.Add(this.label_title);
            this.panel_main.Controls.Add(this.progressBar_loading);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(0, 0);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(365, 177);
            this.panel_main.TabIndex = 0;
            // 
            // label_connecting
            // 
            this.label_connecting.AutoSize = true;
            this.label_connecting.Font = new System.Drawing.Font("Courier New", 8F);
            this.label_connecting.Location = new System.Drawing.Point(132, 113);
            this.label_connecting.Name = "label_connecting";
            this.label_connecting.Size = new System.Drawing.Size(98, 14);
            this.label_connecting.TabIndex = 2;
            this.label_connecting.Text = "Connecting...";
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Courier New", 25F);
            this.label_title.Location = new System.Drawing.Point(33, 47);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(297, 37);
            this.label_title.TabIndex = 0;
            this.label_title.Text = "Message~Sender";
            // 
            // progressBar_loading
            // 
            this.progressBar_loading.Location = new System.Drawing.Point(35, 93);
            this.progressBar_loading.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progressBar_loading.MarqueeAnimationSpeed = 1;
            this.progressBar_loading.Name = "progressBar_loading";
            this.progressBar_loading.Size = new System.Drawing.Size(293, 10);
            this.progressBar_loading.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar_loading.TabIndex = 1;
            // 
            // backgroundWorker_main
            // 
            this.backgroundWorker_main.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_main_DoWork);
            this.backgroundWorker_main.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_main_RunWorkerCompleted);
            // 
            // Form_Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(365, 177);
            this.Controls.Add(this.panel_main);
            this.Font = new System.Drawing.Font("Courier New", 8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Splash";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Splash";
            this.TopMost = true;
            this.panel_main.ResumeLayout(false);
            this.panel_main.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Label label_connecting;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.ProgressBar progressBar_loading;
        private System.ComponentModel.BackgroundWorker backgroundWorker_main;


    }
}