namespace WindowsFormsApplication1.Source
{
    partial class SavingsCategoryControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.categoryNameLabel = new System.Windows.Forms.Label();
            this.monthlyPercentageLabel = new System.Windows.Forms.Label();
            this.savingsGoalLabel = new System.Windows.Forms.Label();
            this.currentTotalLabel = new System.Windows.Forms.Label();
            this.transactionHistoryPanel = new System.Windows.Forms.Panel();
            this.newTransactionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // categoryNameLabel
            // 
            this.categoryNameLabel.BackColor = System.Drawing.Color.Black;
            this.categoryNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryNameLabel.ForeColor = System.Drawing.Color.White;
            this.categoryNameLabel.Location = new System.Drawing.Point(-1, 0);
            this.categoryNameLabel.Name = "categoryNameLabel";
            this.categoryNameLabel.Size = new System.Drawing.Size(117, 23);
            this.categoryNameLabel.TabIndex = 0;
            this.categoryNameLabel.Text = "CategoryName";
            this.categoryNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // monthlyPercentageLabel
            // 
            this.monthlyPercentageLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.monthlyPercentageLabel.Location = new System.Drawing.Point(-1, 23);
            this.monthlyPercentageLabel.Name = "monthlyPercentageLabel";
            this.monthlyPercentageLabel.Size = new System.Drawing.Size(117, 23);
            this.monthlyPercentageLabel.TabIndex = 1;
            this.monthlyPercentageLabel.Text = "MonthlyPercentage";
            this.monthlyPercentageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // savingsGoalLabel
            // 
            this.savingsGoalLabel.BackColor = System.Drawing.Color.Lime;
            this.savingsGoalLabel.Location = new System.Drawing.Point(-1, 46);
            this.savingsGoalLabel.Name = "savingsGoalLabel";
            this.savingsGoalLabel.Size = new System.Drawing.Size(117, 23);
            this.savingsGoalLabel.TabIndex = 2;
            this.savingsGoalLabel.Text = "Goal";
            this.savingsGoalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // currentTotalLabel
            // 
            this.currentTotalLabel.BackColor = System.Drawing.Color.Red;
            this.currentTotalLabel.Location = new System.Drawing.Point(-1, 69);
            this.currentTotalLabel.Name = "currentTotalLabel";
            this.currentTotalLabel.Size = new System.Drawing.Size(117, 23);
            this.currentTotalLabel.TabIndex = 3;
            this.currentTotalLabel.Text = "CurrentTotal";
            this.currentTotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // transactionHistoryPanel
            // 
            this.transactionHistoryPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.transactionHistoryPanel.AutoScroll = true;
            this.transactionHistoryPanel.Location = new System.Drawing.Point(-1, 123);
            this.transactionHistoryPanel.Name = "transactionHistoryPanel";
            this.transactionHistoryPanel.Size = new System.Drawing.Size(113, 141);
            this.transactionHistoryPanel.TabIndex = 4;
            // 
            // newTransactionButton
            // 
            this.newTransactionButton.Location = new System.Drawing.Point(3, 95);
            this.newTransactionButton.Name = "newTransactionButton";
            this.newTransactionButton.Size = new System.Drawing.Size(109, 22);
            this.newTransactionButton.TabIndex = 5;
            this.newTransactionButton.Text = "+";
            this.newTransactionButton.UseVisualStyleBackColor = true;
            // 
            // SavingsCategoryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.newTransactionButton);
            this.Controls.Add(this.transactionHistoryPanel);
            this.Controls.Add(this.currentTotalLabel);
            this.Controls.Add(this.savingsGoalLabel);
            this.Controls.Add(this.monthlyPercentageLabel);
            this.Controls.Add(this.categoryNameLabel);
            this.Name = "SavingsCategoryControl";
            this.Size = new System.Drawing.Size(115, 263);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label categoryNameLabel;
        private System.Windows.Forms.Label monthlyPercentageLabel;
        private System.Windows.Forms.Label savingsGoalLabel;
        private System.Windows.Forms.Label currentTotalLabel;
        private System.Windows.Forms.Panel transactionHistoryPanel;
        public System.Windows.Forms.Button newTransactionButton;

    }
}
