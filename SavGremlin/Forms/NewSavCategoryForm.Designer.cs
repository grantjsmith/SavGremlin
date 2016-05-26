namespace SavGremlin.Forms
{
    partial class NewSavCategoryForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nameBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.monthlyPercentageBox = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.createButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.goalBox = new System.Windows.Forms.TextBox();
            this.currentValueBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(131, 12);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(100, 20);
            this.nameBox.TabIndex = 0;
            this.nameBox.Text = "-";
            this.nameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nameLabel
            // 
            this.nameLabel.Location = new System.Drawing.Point(12, 15);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(100, 17);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Category Name: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Monthly Percentage:";
            // 
            // monthlyPercentageBox
            // 
            this.monthlyPercentageBox.Location = new System.Drawing.Point(131, 36);
            this.monthlyPercentageBox.Mask = "%99";
            this.monthlyPercentageBox.Name = "monthlyPercentageBox";
            this.monthlyPercentageBox.PromptChar = ' ';
            this.monthlyPercentageBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.monthlyPercentageBox.Size = new System.Drawing.Size(100, 20);
            this.monthlyPercentageBox.TabIndex = 3;
            this.monthlyPercentageBox.Text = "5";
            this.monthlyPercentageBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.monthlyPercentageBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Goal: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Current Value:";
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(44, 118);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(75, 23);
            this.createButton.TabIndex = 8;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(125, 118);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // goalBox
            // 
            this.goalBox.Location = new System.Drawing.Point(131, 62);
            this.goalBox.Name = "goalBox";
            this.goalBox.Size = new System.Drawing.Size(100, 20);
            this.goalBox.TabIndex = 10;
            // 
            // currentValueBox
            // 
            this.currentValueBox.Location = new System.Drawing.Point(131, 88);
            this.currentValueBox.Name = "currentValueBox";
            this.currentValueBox.Size = new System.Drawing.Size(100, 20);
            this.currentValueBox.TabIndex = 11;
            // 
            // NewSavCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 147);
            this.Controls.Add(this.currentValueBox);
            this.Controls.Add(this.goalBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.monthlyPercentageBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameBox);
            this.Name = "NewSavCategoryForm";
            this.Text = "NewSavCategoryForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox monthlyPercentageBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox goalBox;
        private System.Windows.Forms.TextBox currentValueBox;
    }
}