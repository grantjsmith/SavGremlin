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
    public partial class TransactionControl : UserControl
    {
        private float transactionValue;

        public TransactionControl()
        {
            InitializeComponent();
        }

        public TransactionControl(float value)
        {
            InitializeComponent();

            transactionValue = value;

            if (transactionValue > 0)
            {
                valueLabel.Text = String.Format("+ {0:C2}", transactionValue);
                valueLabel.ForeColor = Color.Green;
            }
            else
            {
                valueLabel.Text = String.Format("- {0:C2}", Math.Abs(transactionValue));
                valueLabel.ForeColor = Color.Red;
            }
        }
    }
}
