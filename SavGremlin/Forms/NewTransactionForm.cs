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
    public partial class NewTransactionForm : Form
    {
        public Transaction newTransaction;

        public NewTransactionForm()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            newTransaction = new Transaction();

            newTransaction.value = Convert.ToDouble(transactionValueBox.Text);
            newTransaction.note = noteBox.Text;

            this.DialogResult = DialogResult.OK;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
