using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using SavGremlin.Source;
using SavGremlin.Forms;


namespace WindowsFormsApplication1.Source
{
    public partial class SavingsCategoryControl : UserControl
    {
        public SavingsCategory savData;

        public SavingsCategoryControl()
        {
            InitializeComponent();
        }

        public void addTransactions(List<Transaction> transactionValues)
        {
            foreach (Transaction t in transactionValues)
            {
                TransactionControl tmp = new TransactionControl(t.value, t.note);
                tmp.Dock = DockStyle.Top;
                transactionHistoryPanel.Controls.Add(tmp);
                tmp.refreshViews();
            }
        }

        public void addTransaction(Transaction input)
        {
            TransactionControl tmp = new TransactionControl(input.value, input.note);
            tmp.Dock = DockStyle.Top;
            transactionHistoryPanel.Controls.Add(tmp);
            tmp.refreshViews();
        }

        public void refreshViews()
        {
            categoryNameLabel.Text = savData.name;
            monthlyPercentageLabel.Text = savData.percentageMonthly.ToString();
            savingsGoalLabel.Text = savData.goal.ToString();
            currentTotalLabel.Text = savData.currentValue.ToString();

            transactionHistoryPanel.Controls.Clear();

            addTransactions(savData.transactions);
        }
    }
}
