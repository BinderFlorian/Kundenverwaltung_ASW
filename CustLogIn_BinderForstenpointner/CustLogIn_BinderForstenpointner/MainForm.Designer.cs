namespace CustLogIn_BinderForstenpointner
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvAnzeige = new System.Windows.Forms.DataGridView();
            this.Euro = new System.Windows.Forms.Label();
            this.tbxAmount = new System.Windows.Forms.TextBox();
            this.btnPaid = new System.Windows.Forms.Button();
            this.btnOwed = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.erpMain = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnzeige)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpMain)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Customer";
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(475, 15);
            this.tbxSearch.Margin = new System.Windows.Forms.Padding(2);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(141, 20);
            this.tbxSearch.TabIndex = 18;
            this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(384, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Search by name:";
            // 
            // dgvAnzeige
            // 
            this.dgvAnzeige.AllowUserToOrderColumns = true;
            this.dgvAnzeige.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnzeige.Location = new System.Drawing.Point(7, 54);
            this.dgvAnzeige.Margin = new System.Windows.Forms.Padding(2);
            this.dgvAnzeige.MultiSelect = false;
            this.dgvAnzeige.Name = "dgvAnzeige";
            this.dgvAnzeige.RowTemplate.Height = 24;
            this.dgvAnzeige.Size = new System.Drawing.Size(654, 208);
            this.dgvAnzeige.TabIndex = 16;
            this.dgvAnzeige.SelectionChanged += new System.EventHandler(this.dgvAnzeige_SelectionChanged);
            // 
            // Euro
            // 
            this.Euro.AutoSize = true;
            this.Euro.Location = new System.Drawing.Point(601, 284);
            this.Euro.Name = "Euro";
            this.Euro.Size = new System.Drawing.Size(13, 13);
            this.Euro.TabIndex = 15;
            this.Euro.Text = "€";
            // 
            // tbxAmount
            // 
            this.tbxAmount.Location = new System.Drawing.Point(516, 281);
            this.tbxAmount.Name = "tbxAmount";
            this.tbxAmount.Size = new System.Drawing.Size(79, 20);
            this.tbxAmount.TabIndex = 14;
            this.tbxAmount.Validating += new System.ComponentModel.CancelEventHandler(this.tbxAmount_Validating);
            this.tbxAmount.Validated += new System.EventHandler(this.tbxAmount_Validated);
            // 
            // btnPaid
            // 
            this.btnPaid.Enabled = false;
            this.btnPaid.Location = new System.Drawing.Point(569, 307);
            this.btnPaid.Name = "btnPaid";
            this.btnPaid.Size = new System.Drawing.Size(47, 23);
            this.btnPaid.TabIndex = 13;
            this.btnPaid.Text = "Paid";
            this.btnPaid.UseVisualStyleBackColor = true;
            this.btnPaid.Click += new System.EventHandler(this.btnPaid_Click);
            // 
            // btnOwed
            // 
            this.btnOwed.Enabled = false;
            this.btnOwed.Location = new System.Drawing.Point(516, 307);
            this.btnOwed.Name = "btnOwed";
            this.btnOwed.Size = new System.Drawing.Size(47, 23);
            this.btnOwed.TabIndex = 12;
            this.btnOwed.Text = "Owed";
            this.btnOwed.UseVisualStyleBackColor = true;
            this.btnOwed.Click += new System.EventHandler(this.btnOwed_Click);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(151, 281);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(138, 40);
            this.btnChange.TabIndex = 11;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(7, 281);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(138, 40);
            this.btnAddCustomer.TabIndex = 10;
            this.btnAddCustomer.Text = "ADD";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // erpMain
            // 
            this.erpMain.ContainerControl = this;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvAnzeige);
            this.Controls.Add(this.Euro);
            this.Controls.Add(this.tbxAmount);
            this.Controls.Add(this.btnPaid);
            this.Controls.Add(this.btnOwed);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnAddCustomer);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnzeige)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvAnzeige;
        private System.Windows.Forms.Label Euro;
        private System.Windows.Forms.TextBox tbxAmount;
        private System.Windows.Forms.Button btnPaid;
        private System.Windows.Forms.Button btnOwed;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.ErrorProvider erpMain;
    }
}