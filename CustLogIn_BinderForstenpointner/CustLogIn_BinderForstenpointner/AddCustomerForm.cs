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
    public partial class AddCustomerForm : Form
    {
        private Customer newCustomer;

        public AddCustomerForm()
        {
            InitializeComponent();

            if (GlobalRes.GlobalLangENG == true)
            {
                lbEMail.Text = lang.langENG.lbEMail;
                lbfirstname.Text = lang.langENG.lbfirstname;
                lbLastname.Text = lang.langENG.lbLastname;
                btnCreate.Text = lang.langENG.btnCreate;
            }
            else
            {
                lbEMail.Text = lang.langDEU.lbEMail;
                lbfirstname.Text = lang.langDEU.lbfirstname;
                lbLastname.Text = lang.langDEU.lbLastname;
                btnCreate.Text = lang.langDEU.btnCreate;
            }
        }

        public Customer newCustomerreturn()
        {
            return newCustomer;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                this.newCustomer = new Customer(tbxFirstname.Text, tbxLastname.Text, tbxeMail.Text);
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbxFirstname_TextChanged(object sender, EventArgs e)
        {
            if (tbxFirstname.Text.Length > 0 && tbxLastname.Text.Length > 0 && tbxeMail.Text.Length > 0)
            {
                btnCreate.Enabled = true;
            }
        }

        private void tbxLastname_TextChanged(object sender, EventArgs e)
        {
            if (tbxFirstname.Text.Length > 0 && tbxLastname.Text.Length > 0 && tbxeMail.Text.Length > 0)
            {
                btnCreate.Enabled = true;
            }
        }

        private void tbxeMail_TextChanged(object sender, EventArgs e)
        {
            if (tbxFirstname.Text.Length > 0 && tbxLastname.Text.Length > 0 && tbxeMail.Text.Length > 0)
            {
                btnCreate.Enabled = true;
            }
        }

        
    }
}
