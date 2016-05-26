using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApplication1.Source;
using SavGremlin.Forms;
using System.IO;
using System.Globalization;
using SavGremlin.Source;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            loadAll();
        }

        private void newCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewSavCategoryForm form = new NewSavCategoryForm();

            if (form.ShowDialog() == DialogResult.OK)
            {
                SavingsCategoryControl tmp = new SavingsCategoryControl();

                tmp.savData = form.newCategory;
                tmp.Dock = DockStyle.Left;
                tmp.refreshViews();
                savingsCategoryPanel.Controls.Add(tmp);

                saveAll();
            }
        }

        private void newAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewAccountForm form = new NewAccountForm();

            if (form.ShowDialog() == DialogResult.OK)
            {
                SavingsAccountControl tmp = new SavingsAccountControl();

                tmp.data = form.newAccount;
                tmp.Dock = DockStyle.Left;
                tmp.refreshViews();
                accountsPanel.Controls.Add(tmp);

                saveAll();
            }
        }

        public void saveAll()
        {
            System.Collections.Specialized.StringCollection data = new System.Collections.Specialized.StringCollection();

            foreach (Control c in savingsCategoryPanel.Controls)
            {
                SavingsCategoryControl tmp = (SavingsCategoryControl) c;

                data.Add(tmp.savData.collapseToString());
            }

            System.Collections.Specialized.StringCollection accounts = new System.Collections.Specialized.StringCollection();

            foreach (Control c in accountsPanel.Controls)
            {
                SavingsAccountControl tmp = (SavingsAccountControl) c;

                accounts.Add(tmp.data.collapseToString());
            }

            SavGremlin.Properties.Settings.Default.Categories = data;
            SavGremlin.Properties.Settings.Default.Accounts = accounts;
            SavGremlin.Properties.Settings.Default.Save();
        }

        public void loadAll()
        {
            if (SavGremlin.Properties.Settings.Default.Categories != null)
            {
                foreach (String cat in SavGremlin.Properties.Settings.Default.Categories)
                {
                    SavingsCategoryControl tmp = new SavingsCategoryControl();

                    tmp.newTransactionButton.Click += new EventHandler(this.onNewTransaction);
                    tmp.savData = SavingsCategory.inflateFromString(cat);
                    tmp.refreshViews();
                    tmp.Dock = DockStyle.Left;
                    savingsCategoryPanel.Controls.Add(tmp);
                }
            }

            if (SavGremlin.Properties.Settings.Default.Accounts != null)
            {
                foreach (String cat in SavGremlin.Properties.Settings.Default.Accounts)
                {
                    SavingsAccountControl tmp = new SavingsAccountControl();

                    tmp.addButton.Click += new EventHandler(this.onNewAccountAddition);
                    tmp.data = SavingsAccount.inflateFromString(cat);
                    tmp.refreshViews();
                    tmp.Dock = DockStyle.Left;
                    accountsPanel.Controls.Add(tmp);
                }
            }
        }

        private void clearCategoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SavGremlin.Properties.Settings.Default.Categories = null;
            SavGremlin.Properties.Settings.Default.Save();

            savingsCategoryPanel.Controls.Clear();
        }

        private void onNewTransaction(object sender, EventArgs e)
        {
            NewTransactionForm form = new NewTransactionForm();

            if (form.ShowDialog() == DialogResult.OK)
            {
                ((SavingsCategoryControl)sender).addTransaction(form.newTransaction);
            }

            saveAll();
        }

        private void onNewAccountAddition(object sender, EventArgs e)
        {
            NewTransactionForm form = new NewTransactionForm();

            if (form.ShowDialog() == DialogResult.OK)
            {
                ((SavingsAccountControl)sender).addMoney(form.newTransaction.value);
            }

            saveAll();
        }


    }
}
