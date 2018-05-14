namespace CustLogIn_BinderForstenpointner
{
    partial class AddCustomerForm
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
            this.btnCreate = new System.Windows.Forms.Button();
            this.tbxeMail = new System.Windows.Forms.TextBox();
            this.tbxLastname = new System.Windows.Forms.TextBox();
            this.tbxFirstname = new System.Windows.Forms.TextBox();
            this.lbEMail = new System.Windows.Forms.Label();
            this.lbLastname = new System.Windows.Forms.Label();
            this.lbfirstname = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCreate.Enabled = false;
            this.btnCreate.Location = new System.Drawing.Point(107, 115);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(103, 29);
            this.btnCreate.TabIndex = 13;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // tbxeMail
            // 
            this.tbxeMail.Location = new System.Drawing.Point(71, 64);
            this.tbxeMail.Name = "tbxeMail";
            this.tbxeMail.Size = new System.Drawing.Size(66, 20);
            this.tbxeMail.TabIndex = 12;
            this.tbxeMail.TextChanged += new System.EventHandler(this.tbxeMail_TextChanged);
            // 
            // tbxLastname
            // 
            this.tbxLastname.Location = new System.Drawing.Point(71, 38);
            this.tbxLastname.Name = "tbxLastname";
            this.tbxLastname.Size = new System.Drawing.Size(66, 20);
            this.tbxLastname.TabIndex = 11;
            this.tbxLastname.TextChanged += new System.EventHandler(this.tbxLastname_TextChanged);
            // 
            // tbxFirstname
            // 
            this.tbxFirstname.Location = new System.Drawing.Point(71, 12);
            this.tbxFirstname.Name = "tbxFirstname";
            this.tbxFirstname.Size = new System.Drawing.Size(66, 20);
            this.tbxFirstname.TabIndex = 10;
            this.tbxFirstname.TextChanged += new System.EventHandler(this.tbxFirstname_TextChanged);
            // 
            // lbEMail
            // 
            this.lbEMail.AutoSize = true;
            this.lbEMail.Location = new System.Drawing.Point(26, 67);
            this.lbEMail.Name = "lbEMail";
            this.lbEMail.Size = new System.Drawing.Size(39, 13);
            this.lbEMail.TabIndex = 9;
            this.lbEMail.Text = "E-Mail:";
            // 
            // lbLastname
            // 
            this.lbLastname.AutoSize = true;
            this.lbLastname.Location = new System.Drawing.Point(10, 41);
            this.lbLastname.Name = "lbLastname";
            this.lbLastname.Size = new System.Drawing.Size(56, 13);
            this.lbLastname.TabIndex = 8;
            this.lbLastname.Text = "Lastname:";
            // 
            // lbfirstname
            // 
            this.lbfirstname.AutoSize = true;
            this.lbfirstname.Location = new System.Drawing.Point(10, 15);
            this.lbfirstname.Name = "lbfirstname";
            this.lbfirstname.Size = new System.Drawing.Size(55, 13);
            this.lbfirstname.TabIndex = 7;
            this.lbfirstname.Text = "Firstname:";
            // 
            // AddCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 156);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.tbxeMail);
            this.Controls.Add(this.tbxLastname);
            this.Controls.Add(this.tbxFirstname);
            this.Controls.Add(this.lbEMail);
            this.Controls.Add(this.lbLastname);
            this.Controls.Add(this.lbfirstname);
            this.Name = "AddCustomerForm";
            this.Text = "AddCustomerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox tbxeMail;
        private System.Windows.Forms.TextBox tbxLastname;
        private System.Windows.Forms.TextBox tbxFirstname;
        private System.Windows.Forms.Label lbEMail;
        private System.Windows.Forms.Label lbLastname;
        private System.Windows.Forms.Label lbfirstname;
    }
}