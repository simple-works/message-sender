namespace MessageSender
{
    partial class Form_Login
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Login));
            this.button_login = new System.Windows.Forms.Button();
            this.textBox_userName = new System.Windows.Forms.TextBox();
            this.label_userName = new System.Windows.Forms.Label();
            this.textBox_userMAC = new System.Windows.Forms.TextBox();
            this.errorProvider_main = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_main)).BeginInit();
            this.SuspendLayout();
            // 
            // button_login
            // 
            this.button_login.Image = global::MessageSender.Properties.Resources.key;
            this.button_login.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_login.Location = new System.Drawing.Point(230, 57);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(87, 25);
            this.button_login.TabIndex = 2;
            this.button_login.Text = "Login";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // textBox_userName
            // 
            this.textBox_userName.Location = new System.Drawing.Point(19, 29);
            this.textBox_userName.Name = "textBox_userName";
            this.textBox_userName.Size = new System.Drawing.Size(298, 20);
            this.textBox_userName.TabIndex = 1;
            this.textBox_userName.TextChanged += new System.EventHandler(this.textBox_userName_TextChanged);
            // 
            // label_userName
            // 
            this.label_userName.AutoSize = true;
            this.label_userName.Location = new System.Drawing.Point(15, 12);
            this.label_userName.Name = "label_userName";
            this.label_userName.Size = new System.Drawing.Size(42, 14);
            this.label_userName.TabIndex = 0;
            this.label_userName.Text = "Name:";
            // 
            // textBox_userMAC
            // 
            this.textBox_userMAC.Location = new System.Drawing.Point(19, 57);
            this.textBox_userMAC.Name = "textBox_userMAC";
            this.textBox_userMAC.ReadOnly = true;
            this.textBox_userMAC.Size = new System.Drawing.Size(203, 20);
            this.textBox_userMAC.TabIndex = 3;
            // 
            // errorProvider_main
            // 
            this.errorProvider_main.BlinkRate = 100;
            this.errorProvider_main.ContainerControl = this;
            this.errorProvider_main.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider_main.Icon")));
            // 
            // Form_Login
            // 
            this.AcceptButton = this.button_login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 94);
            this.Controls.Add(this.textBox_userMAC);
            this.Controls.Add(this.label_userName);
            this.Controls.Add(this.textBox_userName);
            this.Controls.Add(this.button_login);
            this.Font = new System.Drawing.Font("Courier New", 8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_main)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.TextBox textBox_userName;
        private System.Windows.Forms.Label label_userName;
        private System.Windows.Forms.TextBox textBox_userMAC;
        private System.Windows.Forms.ErrorProvider errorProvider_main;
    }
}

