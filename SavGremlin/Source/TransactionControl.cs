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
        private Decimal transactionValue;
        private String note;

        public TransactionControl()
        {
            InitializeComponent();
        }

        public TransactionControl(Decimal value, String innote)
        {
            InitializeComponent();

            transactionValue = value;
            note = innote;
        }

        public void refreshViews()
        {
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

            noteToolTip.SetToolTip(valueLabel, note);
        }
    }
}
