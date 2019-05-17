namespace InquiryForm_20150528
{
    partial class InquiryForm
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // OpenFileBTN
            // 
            this.OpenFileBTN.Click += new System.EventHandler(this.OpenFileBTN_Click);
            // 
            // CreditBalanceBTN
            // 
            this.CreditBalanceBTN.Click += new System.EventHandler(this.getBalances_Click);
            // 
            // DebitBalanceBTN
            // 
            this.DebitBalanceBTN.Click += new System.EventHandler(this.getBalances_Click);
            // 
            // ZeroBalanceBTN
            // 
            this.ZeroBalanceBTN.Click += new System.EventHandler(this.getBalances_Click);
            // 
            // GraphBTN
            // 
            this.GraphBTN.Click += new System.EventHandler(this.GraphBTN_Click);
            // 
            // LevelDistBTN
            // 
            this.LevelDistBTN.Click += new System.EventHandler(this.getMinMaxOrDistribution_Click);
            // 
            // MinBTN
            // 
            this.MinBTN.Click += new System.EventHandler(this.getMinMaxOrDistribution_Click);
            // 
            // MaxBTN
            // 
            this.MaxBTN.Click += new System.EventHandler(this.getMinMaxOrDistribution_Click);
            // 
            // DoneBTN
            // 
            this.DoneBTN.Click += new System.EventHandler(this.DoneBTN_Click);
            // 
            // ExitBTN
            // 
            this.ExitBTN.Click += new System.EventHandler(this.ExitBTN_Click);
            // 
            // displayTextBox
            // 
            this.displayTextBox.BackColor = System.Drawing.Color.White;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // InquiryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 397);
            this.ControlBox = true;
            this.Name = "InquiryForm";
            this.Text = "InquiryForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}