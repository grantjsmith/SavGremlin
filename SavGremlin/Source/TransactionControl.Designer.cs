namespace WindowsFormsApplication1.Source
{
    partial class TransactionControl
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
            this.valueLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // valueLabel
            // 
            this.valueLabel.BackColor = System.Drawing.Color.Silver;
            this.valueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valueLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.valueLabel.Location = new System.Drawing.Point(3, 0);
            this.valueLabel.Name = "valueLabel";
            this.valueLabel.Size = new System.Drawing.Size(81, 25);
            this.valueLabel.TabIndex = 0;
            this.valueLabel.Text = "+ 124.23";
            this.valueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TransactionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.valueLabel);
            this.Name = "TransactionControl";
            this.Size = new System.Drawing.Size(87, 25);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label valueLabel;
    }
}
