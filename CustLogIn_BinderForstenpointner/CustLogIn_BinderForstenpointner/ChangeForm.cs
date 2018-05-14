using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyBib;

namespace CustLogIn_BinderForstenpointner
{
    public partial class ChangeForm : Form
    {
        private Customer customertochange;
        public Customer Customer
        {
            get
            {
                return customertochange;
            }
            set
            {
                customertochange = value;
            }
        }
        public ChangeForm()
        {
            InitializeComponent();
            ////if (GlobalRes.GlobalLangENG == true)
            ////{
            ////    lbnewEMail.Text = lang.langENG.lbnewEMail;
            ////    lbnewLastname.Text = lang.langENG.lbnewLastname;
            ////    btnChangeEMail.Text = lang.langENG.btnChangeEMail;
            ////    btnChangeLastname.Text = lang.langENG.btnChangeLastname;
            ////    btnClose.Text = lang.langENG.btnClose;
            ////}
            ////else
            ////{
            ////    lbnewEMail.Text = lang.langDEU.lbnewEMail;
            ////    lbnewLastname.Text = lang.langDEU.lbnewLastname;
            ////    btnChangeEMail.Text = lang.langDEU.btnChangeEMail;
            ////    btnChangeLastname.Text = lang.langDEU.btnChangeLastname;
            ////    btnClose.Text = lang.langDEU.btnClose;
            ////}

        }


        private void btnChangeLastname_Click(object sender, EventArgs e)
        {
            try
            {
                customertochange.ChangeLastName = this.tbxNewLastname.Text;
            }
            catch (ArgumentNullException ex)
            {
                this.epErrorHandler.SetError(this.tbxNewLastname, "Please enter new Lastname!");
                this.tbxNewLastname.Text = String.Empty;
            }
        }

        private void btnChangeEMail_Click(object sender, EventArgs e)
        {
            try
            {
                customertochange.ChangeEmail = this.tbxNewEmail.Text;
            }
            catch (ArgumentNullException ex)
            {
                this.epErrorHandler.SetError(this.tbxNewEmail, "Please enter new E-Mail adresse!");
                this.tbxNewEmail.Text = String.Empty;
            }
            catch (ArgumentException ex)
            {
                this.epErrorHandler.SetError(this.tbxNewEmail, "Invalid E-Mail adresse!");
                this.tbxNewEmail.Text = String.Empty;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }

        private void tbxNewLastname_TextChanged(object sender, EventArgs e)
        {
            this.epErrorHandler.SetError(this.tbxNewLastname, "");
        }

        private void tbxNewEmail_TextChanged(object sender, EventArgs e)
        {
            this.epErrorHandler.SetError(this.tbxNewEmail, "");
        }

        
    }

}
