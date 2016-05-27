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
                ((SavingsCategoryControl)((Button)sender).Parent).addTransaction(form.newTransaction);
            }

            saveAll();
        }

        private void onNewAccountAddition(object sender, EventArgs e)
        {
            NewTransactionForm form = new NewTransactionForm();

            if (form.ShowDialog() == DialogResult.OK)
            {
                ((SavingsAccountControl)((Button)sender).Parent).addMoney(form.newTransaction.value);
            }

            allocateFunds(form.newTransaction.value);

            saveAll();
        }

        public void allocateFunds(Decimal input)
        {
            // The ammount of money to be deposited during this cycle
            Decimal total = input;
            // The ammount of money left over (if any) after this cycle
            Decimal remainder = input;
            // Used to store the percentage we will attempt to store in a given account
            List<Decimal> percentages = new List<Decimal>();
            // The total percentage we will be allocating during this cycle - if this is not 1, we will adjust percentages until it is
            Decimal totalPercent = 0;
            // The number of accounts we will depositing in during this cycle - used to calculate percentage adjustments
            int activeaccounts = 0;


            // Continue allocating money until there is no money left to allocate
            while (total != 0)
            {
                // Clear values from our previous cycle
                activeaccounts = 0;
                totalPercent = 0;
                percentages.Clear();

                // First, compile the percentages we will be allocating in this cycle, based on the values in the currently displayed savings accounts
                foreach (Control c in savingsCategoryPanel.Controls)
                {
                    SavingsCategoryControl tmp = (SavingsCategoryControl)c;

                    // If we've already met the goal for this category, no need to add further money
                    if (tmp.savData.goal == tmp.savData.currentValue)
                    {
                        percentages.Add(0);
                    }
                    else
                    {
                        percentages.Add((Decimal)tmp.savData.percentageMonthly);
                        totalPercent += tmp.savData.percentageMonthly;

                        activeaccounts++;
                    }
                }

                if (totalPercent != 1)
                {
                    decimal addition = (totalPercent - 1) / activeaccounts;

                    for (int i = 0; i < percentages.Count; i++)
                    {
                        if (percentages[i] != 0)
                        {
                            percentages[i] -= addition;
                        }
                    }
                }

                for (int i = 0; i < savingsCategoryPanel.Controls.Count; i++)
                {
                    SavingsCategoryControl c = (SavingsCategoryControl)savingsCategoryPanel.Controls[i];

                    if ((c.savData.currentValue + (remainder * percentages[i])) >= c.savData.goal)
                    {
                        // Adding the ammount we should add would overshoot the goal - add only what's needed, leave the rest to be allocated next time
                        remainder -= c.savData.goal - c.savData.currentValue;
                        c.savData.currentValue = c.savData.goal;
                        c.refreshViews();
                    }
                    else
                    {
                        Decimal addition = remainder * percentages[i];
                        c.savData.currentValue += addition;
                        remainder -= addition;
                        c.refreshViews();
                    }
                }

                total = remainder;
            }
        }
    }
}
