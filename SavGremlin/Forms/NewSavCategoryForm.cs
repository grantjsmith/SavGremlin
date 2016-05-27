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
    public partial class NewSavCategoryForm : Form
    {
        public SavingsCategory newCategory;

        public NewSavCategoryForm()
        {
            InitializeComponent();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            // Add the new category to the saved categories
            newCategory = new SavingsCategory();

            newCategory.name = nameBox.Text;
            newCategory.percentageMonthly = Convert.ToDecimal(monthlyPercentageBox.Text) * (Decimal) .01;
            newCategory.goal = Convert.ToInt32(goalBox.Text);
            newCategory.currentValue = Convert.ToDecimal(currentValueBox.Text);

            newCategory.transactions = new List<Transaction>();

            this.DialogResult = DialogResult.OK;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
