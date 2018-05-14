namespace CustLogIn_BinderForstenpointner
{
    partial class ChangeForm
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnChangeEMail = new System.Windows.Forms.Button();
            this.btnChangeLastname = new System.Windows.Forms.Button();
            this.tbxNewEmail = new System.Windows.Forms.TextBox();
            this.tbxNewLastname = new System.Windows.Forms.TextBox();
            this.lbnewEMail = new System.Windows.Forms.Label();
            this.lbnewLastname = new System.Windows.Forms.Label();
            this.epErrorHandler = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.epErrorHandler)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Retry;
            this.btnClose.Location = new System.Drawing.Point(99, 129);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(95, 30);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnChangeEMail
            // 
            this.btnChangeEMail.Location = new System.Drawing.Point(155, 70);
            this.btnChangeEMail.Name = "btnChangeEMail";
            this.btnChangeEMail.Size = new System.Drawing.Size(101, 29);
            this.btnChangeEMail.TabIndex = 12;
            this.btnChangeEMail.Text = "Change E-Mail";
            this.btnChangeEMail.UseVisualStyleBackColor = true;
            this.btnChangeEMail.Click += new System.EventHandler(this.btnChangeEMail_Click);
            // 
            // btnChangeLastname
            // 
            this.btnChangeLastname.Location = new System.Drawing.Point(153, 20);
            this.btnChangeLastname.Name = "btnChangeLastname";
            this.btnChangeLastname.Size = new System.Drawing.Size(103, 29);
            this.btnChangeLastname.TabIndex = 11;
            this.btnChangeLastname.Text = "Change Lastname";
            this.btnChangeLastname.UseVisualStyleBackColor = true;
            this.btnChangeLastname.Click += new System.EventHandler(this.btnChangeLastname_Click);
            // 
            // tbxNewEmail
            // 
            this.tbxNewEmail.Location = new System.Drawing.Point(15, 75);
            this.tbxNewEmail.Name = "tbxNewEmail";
            this.tbxNewEmail.Size = new System.Drawing.Size(115, 20);
            this.tbxNewEmail.TabIndex = 10;
            this.tbxNewEmail.TextChanged += new System.EventHandler(this.tbxNewEmail_TextChanged);
            // 
            // tbxNewLastname
            // 
            this.tbxNewLastname.Location = new System.Drawing.Point(15, 25);
            this.tbxNewLastname.Name = "tbxNewLastname";
            this.tbxNewLastname.Size = new System.Drawing.Size(91, 20);
            this.tbxNewLastname.TabIndex = 9;
            this.tbxNewLastname.TextChanged += new System.EventHandler(this.tbxNewLastname_TextChanged);
            // 
            // lbnewEMail
            // 
            this.lbnewEMail.AutoSize = true;
            this.lbnewEMail.Location = new System.Drawing.Point(12, 59);
            this.lbnewEMail.Name = "lbnewEMail";
            this.lbnewEMail.Size = new System.Drawing.Size(61, 13);
            this.lbnewEMail.TabIndex = 8;
            this.lbnewEMail.Text = "New E-Mail";
            // 
            // lbnewLastname
            // 
            this.lbnewLastname.AutoSize = true;
            this.lbnewLastname.Location = new System.Drawing.Point(12, 9);
            this.lbnewLastname.Name = "lbnewLastname";
            this.lbnewLastname.Size = new System.Drawing.Size(78, 13);
            this.lbnewLastname.TabIndex = 7;
            this.lbnewLastname.Text = "New Lastname";
            // 
            // epErrorHandler
            // 
            this.epErrorHandler.ContainerControl = this;
            // 
            // ChangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 170);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnChangeEMail);
            this.Controls.Add(this.btnChangeLastname);
            this.Controls.Add(this.tbxNewEmail);
            this.Controls.Add(this.tbxNewLastname);
            this.Controls.Add(this.lbnewEMail);
            this.Controls.Add(this.lbnewLastname);
            this.Name = "ChangeForm";
            this.Text = "ChangeForm";
            ((System.ComponentModel.ISupportInitialize)(this.epErrorHandler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnChangeEMail;
        private System.Windows.Forms.Button btnChangeLastname;
        private System.Windows.Forms.TextBox tbxNewEmail;
        private System.Windows.Forms.TextBox tbxNewLastname;
        private System.Windows.Forms.Label lbnewEMail;
        private System.Windows.Forms.Label lbnewLastname;
        private System.Windows.Forms.ErrorProvider epErrorHandler;
    }
}