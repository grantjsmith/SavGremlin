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
        static List<Color> currentValueGradientList;

        public SavingsCategory savData;

        public SavingsCategoryControl()
        {
            InitializeComponent();

            if (currentValueGradientList == null)
            {
                prepareColorGradients();
            }
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

            // Handle the gradient stuff
            int gradientindex =  (int) ((savData.currentValue / savData.goal) * 20);

            currentTotalLabel.BackColor = currentValueGradientList[gradientindex];

        }

        public static void prepareColorGradients()
        {
            currentValueGradientList = new List<Color>();

            currentValueGradientList.Add(System.Drawing.ColorTranslator.FromHtml("#FF0000"));
            currentValueGradientList.Add(System.Drawing.ColorTranslator.FromHtml("#FF1A00"));
            currentValueGradientList.Add(System.Drawing.ColorTranslator.FromHtml("#FF3500"));
            currentValueGradientList.Add(System.Drawing.ColorTranslator.FromHtml("#FF5000"));
            currentValueGradientList.Add(System.Drawing.ColorTranslator.FromHtml("#FF6B00"));
            currentValueGradientList.Add(System.Drawing.ColorTranslator.FromHtml("#FF8600"));
            currentValueGradientList.Add(System.Drawing.ColorTranslator.FromHtml("#FFA100"));
            currentValueGradientList.Add(System.Drawing.ColorTranslator.FromHtml("#FFBB00"));
            currentValueGradientList.Add(System.Drawing.ColorTranslator.FromHtml("#FFD600"));
            currentValueGradientList.Add(System.Drawing.ColorTranslator.FromHtml("#FFF100"));
            currentValueGradientList.Add(System.Drawing.ColorTranslator.FromHtml("#F1FF00"));
            currentValueGradientList.Add(System.Drawing.ColorTranslator.FromHtml("#D6FF00"));
            currentValueGradientList.Add(System.Drawing.ColorTranslator.FromHtml("#BBFF00"));
            currentValueGradientList.Add(System.Drawing.ColorTranslator.FromHtml("#A1FF00"));
            currentValueGradientList.Add(System.Drawing.ColorTranslator.FromHtml("#86FF00"));
            currentValueGradientList.Add(System.Drawing.ColorTranslator.FromHtml("#6BFF00"));
            currentValueGradientList.Add(System.Drawing.ColorTranslator.FromHtml("#50FF00"));
            currentValueGradientList.Add(System.Drawing.ColorTranslator.FromHtml("#35FF00"));
            currentValueGradientList.Add(System.Drawing.ColorTranslator.FromHtml("#1AFF00"));
            currentValueGradientList.Add(System.Drawing.ColorTranslator.FromHtml("#00FF00"));

        }
    }
}
