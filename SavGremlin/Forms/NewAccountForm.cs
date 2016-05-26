using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SavGremlin.Source;

namespace SavGremlin.Forms
{
    public partial class NewAccountForm : Form
    {
        public SavingsAccount newAccount;

        public NewAccountForm()
        {
            InitializeComponent();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            newAccount = new SavingsAccount();

            newAccount.accountName = accountNameBox.Text;
            newAccount.accountValue = 0;

            this.DialogResult = DialogResult.OK;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
