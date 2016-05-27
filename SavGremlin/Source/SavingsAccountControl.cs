using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SavGremlin.Source
{
    public partial class SavingsAccountControl : UserControl
    {
        public SavingsAccount data;

        public SavingsAccountControl()
        {
            InitializeComponent();
        }

        public void refreshViews()
        {
            accountNameLabel.Text = data.accountName;
            accountValueLabel.Text = data.accountValue.ToString();
        }

        public void addMoney(Decimal ammount)
        {
            data.accountValue += ammount;

            accountValueLabel.Text = data.accountValue.ToString();
        }
    }
}
