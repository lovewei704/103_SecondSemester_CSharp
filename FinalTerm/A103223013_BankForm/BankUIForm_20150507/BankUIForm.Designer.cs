namespace BankUIForm_20150507
{
    partial class BankUIForm
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
            this.AccountTB = new System.Windows.Forms.TextBox();
            this.AccountLB = new System.Windows.Forms.Label();
            this.FirstNameLB = new System.Windows.Forms.Label();
            this.FirstNameTB = new System.Windows.Forms.TextBox();
            this.LastNameLB = new System.Windows.Forms.Label();
            this.LastNameTB = new System.Windows.Forms.TextBox();
            this.BalanceLB = new System.Windows.Forms.Label();
            this.BalanceTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AccountTB
            // 
            this.AccountTB.Location = new System.Drawing.Point(103, 23);
            this.AccountTB.Name = "AccountTB";
            this.AccountTB.Size = new System.Drawing.Size(100, 22);
            this.AccountTB.TabIndex = 0;
            // 
            // AccountLB
            // 
            this.AccountLB.AutoSize = true;
            this.AccountLB.Location = new System.Drawing.Point(30, 33);
            this.AccountLB.Name = "AccountLB";
            this.AccountLB.Size = new System.Drawing.Size(44, 12);
            this.AccountLB.TabIndex = 1;
            this.AccountLB.Text = "Account";
            // 
            // FirstNameLB
            // 
            this.FirstNameLB.AutoSize = true;
            this.FirstNameLB.Location = new System.Drawing.Point(30, 75);
            this.FirstNameLB.Name = "FirstNameLB";
            this.FirstNameLB.Size = new System.Drawing.Size(55, 12);
            this.FirstNameLB.TabIndex = 3;
            this.FirstNameLB.Text = "First Name";
            // 
            // FirstNameTB
            // 
            this.FirstNameTB.Location = new System.Drawing.Point(103, 65);
            this.FirstNameTB.Name = "FirstNameTB";
            this.FirstNameTB.Size = new System.Drawing.Size(100, 22);
            this.FirstNameTB.TabIndex = 2;
            // 
            // LastNameLB
            // 
            this.LastNameLB.AutoSize = true;
            this.LastNameLB.Location = new System.Drawing.Point(30, 116);
            this.LastNameLB.Name = "LastNameLB";
            this.LastNameLB.Size = new System.Drawing.Size(54, 12);
            this.LastNameLB.TabIndex = 5;
            this.LastNameLB.Text = "Last Name";
            // 
            // LastNameTB
            // 
            this.LastNameTB.Location = new System.Drawing.Point(103, 106);
            this.LastNameTB.Name = "LastNameTB";
            this.LastNameTB.Size = new System.Drawing.Size(100, 22);
            this.LastNameTB.TabIndex = 4;
            // 
            // BalanceLB
            // 
            this.BalanceLB.AutoSize = true;
            this.BalanceLB.Location = new System.Drawing.Point(30, 160);
            this.BalanceLB.Name = "BalanceLB";
            this.BalanceLB.Size = new System.Drawing.Size(42, 12);
            this.BalanceLB.TabIndex = 7;
            this.BalanceLB.Text = "Balance";
            // 
            // BalanceTB
            // 
            this.BalanceTB.Location = new System.Drawing.Point(103, 150);
            this.BalanceTB.Name = "BalanceTB";
            this.BalanceTB.Size = new System.Drawing.Size(100, 22);
            this.BalanceTB.TabIndex = 6;
            // 
            // BankUIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 280);
            this.ControlBox = false;
            this.Controls.Add(this.BalanceLB);
            this.Controls.Add(this.BalanceTB);
            this.Controls.Add(this.LastNameLB);
            this.Controls.Add(this.LastNameTB);
            this.Controls.Add(this.FirstNameLB);
            this.Controls.Add(this.FirstNameTB);
            this.Controls.Add(this.AccountLB);
            this.Controls.Add(this.AccountTB);
            this.Name = "BankUIForm";
            this.Text = "BankUIForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AccountLB;
        private System.Windows.Forms.Label FirstNameLB;
        private System.Windows.Forms.Label LastNameLB;
        private System.Windows.Forms.Label BalanceLB;
        public System.Windows.Forms.TextBox AccountTB;
        public System.Windows.Forms.TextBox FirstNameTB;
        public System.Windows.Forms.TextBox LastNameTB;
        public System.Windows.Forms.TextBox BalanceTB;
    }
}

