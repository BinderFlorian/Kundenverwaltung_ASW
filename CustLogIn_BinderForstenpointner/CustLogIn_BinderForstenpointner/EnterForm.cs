using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustLogIn_BinderForstenpointner
{
    public partial class EnterForm : Form
    {
        const string password = "password";
        public EnterForm()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (tbxpasswordlogin.Text == password)
            {
                MainForm frmMain = new MainForm();
                frmMain.Show();
                this.Hide();
            }
            else
            {
                tbxpasswordlogin.Text = String.Empty;
                this.erpWrongPassoword.SetError(this.tbxpasswordlogin, "Falsches Passwort!");
            }

        }

        private void tbxpasswordlogin_TextChanged(object sender, EventArgs e)
        {
            this.erpWrongPassoword.SetError(this.tbxpasswordlogin, "");
            if (tbxpasswordlogin.Text.Length > 0)
            {
                btnlogin.Enabled = true;
            }
            else
            {
                btnlogin.Enabled = false;
            }
        }

        private void btnENG_Click(object sender, EventArgs e)
        {
            GlobalRes.GlobalLangENG = true;
            lbPassword.Text = lang.langENG.lbPassword;
            btnlogin.Text = lang.langENG.btnlogin;

        }

        private void btnDEU_Click(object sender, EventArgs e)
        {

            GlobalRes.GlobalLangENG = false;
            lbPassword.Text = lang.langDEU.lbPassword;
            btnlogin.Text = lang.langDEU.btnlogin;
        }

    }

    static class GlobalRes
    {
        private static bool languageENG = true;

        public static bool GlobalLangENG
        {
            get { return languageENG; }
            set { languageENG = value; }
        }
    }
}
