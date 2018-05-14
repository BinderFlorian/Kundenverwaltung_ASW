using MyBib;
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
    public partial class MainForm : Form
    {
        public CustomerList customerList;
        private CustomerList searchList;

        bool customerAdded = false;

        double amountnotchecked;
        double amountchecked;
        int selectedCustomerCustNr;


        public MainForm()
        {
            InitializeComponent();

            if (GlobalRes.GlobalLangENG == true)
            {
                label1.Text = lang.langENG.label1;
                label2.Text = lang.langENG.label2;
                btnAddCustomer.Text = lang.langENG.btnAddCustomer;
                btnChange.Text = lang.langENG.btnChange;
                btnOwed.Text = lang.langENG.btnOwed;
                btnPaid.Text = lang.langENG.btnPaid;

            }
            else
            {
                label1.Text = lang.langDEU.label1;
                label2.Text = lang.langDEU.label2;
                btnAddCustomer.Text = lang.langDEU.btnAddCustomer;
                btnChange.Text = lang.langDEU.btnChange;
                btnOwed.Text = lang.langDEU.btnOwed;
                btnPaid.Text = lang.langDEU.btnPaid;
            }
            this.customerList = new CustomerList();
            this.customerList.ReadCustomerList();
            UpdateDataGrid();
        }
        #region Binder
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            AddCustomerForm dialoge = new AddCustomerForm();

            if (DialogResult.OK == dialoge.ShowDialog())
            {
                Customer createdCust = dialoge.newCustomerreturn();
                createdCust.ReadLastCustNum(customerList.Data());
                customerList.AddNewCustomer(createdCust);
            }

            UpdateDataGrid();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            ChangeForm dialoge = new ChangeForm();
            dialoge.Customer = customerList.SelectedCustomer(this.selectedCustomerCustNr);
            if (DialogResult.Retry == dialoge.ShowDialog())
            {
                customerList.ChangedCustomer(dialoge.Customer);
            }
            UpdateDataGrid();
        }

        private void btnOwed_Click(object sender, EventArgs e)
        {
            if (this.selectedCustomerCustNr >= 10000 && this.amountchecked > 0)
            {


                Customer changebalance = customerList.SelectedCustomer(this.selectedCustomerCustNr);
                changebalance.Owed(this.amountchecked);

                customerList.ChangedCustomer(changebalance);
                this.tbxAmount.Text = String.Empty;
                this.btnOwed.Enabled = false;
                this.btnPaid.Enabled = false;
                UpdateDataGrid();
            }
        }

        private void tbxAmount_Validated(object sender, EventArgs e)
        {
            this.amountchecked = this.amountnotchecked;
        }

        private void tbxAmount_Validating(object sender, CancelEventArgs e)
        {
            if (Double.TryParse(this.tbxAmount.Text, out this.amountnotchecked) && this.selectedCustomerCustNr >= 10000)
            {
                this.erpMain.SetError(this.tbxAmount, "");
                this.btnOwed.Enabled = true;
                this.btnPaid.Enabled = true;
            }
            else
            {
                this.erpMain.SetError(this.tbxAmount, "Wrong Datatype or no customer selected!");
            }
        }

        private void btnPaid_Click(object sender, EventArgs e)
        {
            if (this.selectedCustomerCustNr >= 10000 && this.amountchecked > 0)
            {

                Customer changebalance = customerList.SelectedCustomer(this.selectedCustomerCustNr);
                changebalance.Paid(this.amountchecked);

                customerList.ChangedCustomer(changebalance);
                this.tbxAmount.Text = String.Empty;

                this.btnOwed.Enabled = false;
                this.btnPaid.Enabled = false;
                UpdateDataGrid();
            }
        }
        #endregion

        #region Forstenpointner


        private void dgvAnzeige_SelectionChanged(object sender, EventArgs e)
        {
            if (this.customerList.Data().Length > 0)
            {
                this.selectedCustomerCustNr = Convert.ToInt32(this.dgvAnzeige.Rows[this.dgvAnzeige.CurrentCell.RowIndex].Cells[0].Value.ToString());

            }


            // Customer searched by CustomerNumber
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            #region Search by Name

            // Search for string

            this.searchList = new CustomerList();
            bool foundItem = false;

            string searchBox = this.tbxSearch.Text;

            if (this.tbxSearch.Text != String.Empty)
            {

                //string value = this.customerList.FirstName;

                foreach (Customer customer in this.customerList.Data())
                {
                    // Loop stops if strings are not equal
                    if (customer != null)
                    {
                        bool equal = true;
                        string value = customer.Firstname;
                        for (int j = 0; j < searchBox.Length; j++)
                        {
                            if (value[j] != searchBox[j] || value.Length < searchBox.Length)
                            {
                                equal = false;
                                break;
                            }
                        }
                        if (equal)
                        {
                            foundItem = true;
                            this.searchList.AddNewCustomer(customer);
                        }

                    }


                }

                if (foundItem)
                {
                    // this.dgvAnzeige.DataSource = this.searchList.DataGridView();
                    UpdateDataGridForSearch();
                }
                else
                {
                    this.dgvAnzeige.Rows.Clear();
                }
            }
            else
            {
                UpdateDataGrid();
            }
            #endregion

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.customerList.WriteCustomerList();
            Application.Exit();
        }

        private void UpdateDataGrid()
        {
            // Delete Current Version
            this.dgvAnzeige.Rows.Clear();

            // Header
            if (this.customerAdded == false)
            {
                if (GlobalRes.GlobalLangENG == true)
                {
                    this.dgvAnzeige.ColumnCount = 6;
                    this.dgvAnzeige.Columns[0].Name = "First Name";
                    this.dgvAnzeige.Columns[1].Name = "Last Name";
                    this.dgvAnzeige.Columns[2].Name = "E Mail Name";
                    this.dgvAnzeige.Columns[3].Name = "Balance";
                    this.dgvAnzeige.Columns[4].Name = "Customer Number";
                    this.dgvAnzeige.Columns[5].Name = "Last Change";

                }
                else
                {
                    this.dgvAnzeige.ColumnCount = 6;
                    this.dgvAnzeige.Columns[0].Name = "Vorname";
                    this.dgvAnzeige.Columns[1].Name = "Nachname";
                    this.dgvAnzeige.Columns[2].Name = "E-Mail";
                    this.dgvAnzeige.Columns[3].Name = "Konto";
                    this.dgvAnzeige.Columns[4].Name = "Kundennummer";
                    this.dgvAnzeige.Columns[5].Name = "Letzte Änderung";
                }
                this.customerAdded = true;
            }
            // Writes DataGridView
            foreach (Customer customer in this.customerList.Data())
            {
                if (customer != null)
                {
                    this.dgvAnzeige.Rows.Add(customer.ToString().Split(';'));
                }
            }

            this.customerList.WriteCustomerList();
        }

        private void UpdateDataGridForSearch()
        {
            // Delete Current Version
            this.dgvAnzeige.Rows.Clear();

            // Header
            if (this.customerAdded == false)
            {
                this.dgvAnzeige.ColumnCount = 6;
                this.dgvAnzeige.Columns[0].Name = "First Name";
                this.dgvAnzeige.Columns[1].Name = "Last Name";
                this.dgvAnzeige.Columns[2].Name = "E Mail Name";
                this.dgvAnzeige.Columns[3].Name = "Balance";
                this.dgvAnzeige.Columns[4].Name = "Customer Number";
                this.dgvAnzeige.Columns[5].Name = "Last Change";

                this.customerAdded = true;
            }
            // Writes DataGridView
            foreach (Customer customer in this.searchList.Data())
            {
                if (customer != null)
                {
                    this.dgvAnzeige.Rows.Add(customer.ToString().Split(';'));
                }
            }
        }












        #endregion

     
    }
}
