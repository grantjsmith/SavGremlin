using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApplication1.Source;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            for (int i = 0; i < 8; i++)
            {
                SavingsCategoryControl tmp = new SavingsCategoryControl();
                tmp.Dock = DockStyle.Left;
                savingsCategoryPanel.Controls.Add(tmp);

                List<float> values = new List<float>();
                Random r = new Random();

                for (int j = 0; j < 20; j++)
                {
                    double mantissa = (r.NextDouble() * 2.0) - 1.0;
                    double exponent = Math.Pow(2.0, r.Next(-2, 2));
                    values.Add((float)(mantissa * exponent));
                }

                tmp.addTransactions(values);
            }
        }
    }
}
