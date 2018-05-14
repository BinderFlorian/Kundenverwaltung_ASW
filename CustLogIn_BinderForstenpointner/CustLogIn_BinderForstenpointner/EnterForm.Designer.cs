namespace CustLogIn_BinderForstenpointner
{
    partial class EnterForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnDEU = new System.Windows.Forms.Button();
            this.btnENG = new System.Windows.Forms.Button();
            this.lbPassword = new System.Windows.Forms.Label();
            this.tbxpasswordlogin = new System.Windows.Forms.TextBox();
            this.erpWrongPassoword = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnlogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.erpWrongPassoword)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDEU
            // 
            this.btnDEU.Location = new System.Drawing.Point(215, 105);
            this.btnDEU.Name = "btnDEU";
            this.btnDEU.Size = new System.Drawing.Size(42, 26);
            this.btnDEU.TabIndex = 12;
            this.btnDEU.Text = "DEU";
            this.btnDEU.UseVisualStyleBackColor = true;
            this.btnDEU.Click += new System.EventHandler(this.btnDEU_Click);
            // 
            // btnENG
            // 
            this.btnENG.Location = new System.Drawing.Point(176, 105);
            this.btnENG.Name = "btnENG";
            this.btnENG.Size = new System.Drawing.Size(42, 26);
            this.btnENG.TabIndex = 11;
            this.btnENG.Text = "ENG";
            this.btnENG.UseVisualStyleBackColor = true;
            this.btnENG.Click += new System.EventHandler(this.btnENG_Click);
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(24, 18);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(55, 13);
            this.lbPassword.TabIndex = 10;
            this.lbPassword.Text = "password:";
            // 
            // tbxpasswordlogin
            // 
            this.tbxpasswordlogin.Location = new System.Drawing.Point(84, 15);
            this.tbxpasswordlogin.Name = "tbxpasswordlogin";
            this.tbxpasswordlogin.Size = new System.Drawing.Size(111, 20);
            this.tbxpasswordlogin.TabIndex = 9;
            this.tbxpasswordlogin.UseSystemPasswordChar = true;
            this.tbxpasswordlogin.TextChanged += new System.EventHandler(this.tbxpasswordlogin_TextChanged);
            // 
            // erpWrongPassoword
            // 
            this.erpWrongPassoword.ContainerControl = this;
            // 
            // btnlogin
            // 
            this.btnlogin.Enabled = false;
            this.btnlogin.Location = new System.Drawing.Point(99, 60);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(68, 29);
            this.btnlogin.TabIndex = 13;
            this.btnlogin.Text = "login";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // EnterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 142);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.btnDEU);
            this.Controls.Add(this.btnENG);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.tbxpasswordlogin);
            this.Name = "EnterForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.erpWrongPassoword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDEU;
        private System.Windows.Forms.Button btnENG;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox tbxpasswordlogin;
        private System.Windows.Forms.ErrorProvider erpWrongPassoword;
        private System.Windows.Forms.Button btnlogin;
    }
}

