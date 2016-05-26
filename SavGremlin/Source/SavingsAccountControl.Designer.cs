namespace SavGremlin.Source
{
    partial class SavingsAccountControl
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
            this.accountNameLabel = new System.Windows.Forms.Label();
            this.accountValueLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // accountNameLabel
            // 
            this.accountNameLabel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.accountNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountNameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.accountNameLabel.Location = new System.Drawing.Point(0, 0);
            this.accountNameLabel.Name = "accountNameLabel";
            this.accountNameLabel.Size = new System.Drawing.Size(108, 28);
            this.accountNameLabel.TabIndex = 0;
            this.accountNameLabel.Text = "Account Name";
            this.accountNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // accountValueLabel
            // 
            this.accountValueLabel.BackColor = System.Drawing.SystemColors.InfoText;
            this.accountValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountValueLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.accountValueLabel.Location = new System.Drawing.Point(0, 28);
            this.accountValueLabel.Name = "accountValueLabel";
            this.accountValueLabel.Size = new System.Drawing.Size(108, 26);
            this.accountValueLabel.TabIndex = 1;
            this.accountValueLabel.Text = "Account Value";
            this.accountValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(3, 58);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(102, 23);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "+";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // SavingsAccountControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.accountValueLabel);
            this.Controls.Add(this.accountNameLabel);
            this.Name = "SavingsAccountControl";
            this.Size = new System.Drawing.Size(108, 85);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label accountNameLabel;
        private System.Windows.Forms.Label accountValueLabel;
        public System.Windows.Forms.Button addButton;
    }
}
