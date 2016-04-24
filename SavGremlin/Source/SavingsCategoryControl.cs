using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Source
{
    public partial class SavingsCategoryControl : UserControl
    {
        public SavingsCategoryControl()
        {
            InitializeComponent();
        }

        public void addTransactions(List<float> transactionValues)
        {
            foreach (float value in transactionValues)
            {
                TransactionControl tmp = new TransactionControl(value);
                tmp.Dock = DockStyle.Top;
                transactionHistoryPanel.Controls.Add(tmp);
            }
        }
    }
}
