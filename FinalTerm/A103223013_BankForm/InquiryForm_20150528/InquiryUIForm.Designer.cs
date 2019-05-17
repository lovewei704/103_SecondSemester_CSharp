namespace InquiryForm_20150528
{
    partial class InquiryUIForm
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Account = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OpenFileBTN = new System.Windows.Forms.Button();
            this.CreditBalanceBTN = new System.Windows.Forms.Button();
            this.DebitBalanceBTN = new System.Windows.Forms.Button();
            this.ZeroBalanceBTN = new System.Windows.Forms.Button();
            this.GraphBTN = new System.Windows.Forms.Button();
            this.LevelDistBTN = new System.Windows.Forms.Button();
            this.MinBTN = new System.Windows.Forms.Button();
            this.MaxBTN = new System.Windows.Forms.Button();
            this.DoneBTN = new System.Windows.Forms.Button();
            this.ExitBTN = new System.Windows.Forms.Button();
            this.displayTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Account,
            this.FirstName,
            this.LastName,
            this.Balance});
            this.dataGridView.Location = new System.Drawing.Point(12, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(543, 270);
            this.dataGridView.TabIndex = 0;
            // 
            // Account
            // 
            this.Account.HeaderText = "Account";
            this.Account.Name = "Account";
            this.Account.Width = 125;
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "FirstName";
            this.FirstName.Name = "FirstName";
            this.FirstName.Width = 125;
            // 
            // LastName
            // 
            this.LastName.HeaderText = "LastName";
            this.LastName.Name = "LastName";
            this.LastName.Width = 125;
            // 
            // Balance
            // 
            this.Balance.HeaderText = "Balance";
            this.Balance.Name = "Balance";
            this.Balance.Width = 125;
            // 
            // OpenFileBTN
            // 
            this.OpenFileBTN.Location = new System.Drawing.Point(27, 299);
            this.OpenFileBTN.Name = "OpenFileBTN";
            this.OpenFileBTN.Size = new System.Drawing.Size(95, 37);
            this.OpenFileBTN.TabIndex = 2;
            this.OpenFileBTN.Text = "Open File";
            this.OpenFileBTN.UseVisualStyleBackColor = true;
            // 
            // CreditBalanceBTN
            // 
            this.CreditBalanceBTN.Location = new System.Drawing.Point(166, 299);
            this.CreditBalanceBTN.Name = "CreditBalanceBTN";
            this.CreditBalanceBTN.Size = new System.Drawing.Size(95, 37);
            this.CreditBalanceBTN.TabIndex = 3;
            this.CreditBalanceBTN.Text = "Credit Balance";
            this.CreditBalanceBTN.UseVisualStyleBackColor = true;
            // 
            // DebitBalanceBTN
            // 
            this.DebitBalanceBTN.Location = new System.Drawing.Point(306, 299);
            this.DebitBalanceBTN.Name = "DebitBalanceBTN";
            this.DebitBalanceBTN.Size = new System.Drawing.Size(89, 37);
            this.DebitBalanceBTN.TabIndex = 4;
            this.DebitBalanceBTN.Text = "Debit Balance";
            this.DebitBalanceBTN.UseVisualStyleBackColor = true;
            // 
            // ZeroBalanceBTN
            // 
            this.ZeroBalanceBTN.Location = new System.Drawing.Point(438, 299);
            this.ZeroBalanceBTN.Name = "ZeroBalanceBTN";
            this.ZeroBalanceBTN.Size = new System.Drawing.Size(89, 37);
            this.ZeroBalanceBTN.TabIndex = 5;
            this.ZeroBalanceBTN.Text = "Zero Balance";
            this.ZeroBalanceBTN.UseVisualStyleBackColor = true;
            // 
            // GraphBTN
            // 
            this.GraphBTN.Location = new System.Drawing.Point(438, 342);
            this.GraphBTN.Name = "GraphBTN";
            this.GraphBTN.Size = new System.Drawing.Size(89, 37);
            this.GraphBTN.TabIndex = 9;
            this.GraphBTN.Text = "Graph";
            this.GraphBTN.UseVisualStyleBackColor = true;
            // 
            // LevelDistBTN
            // 
            this.LevelDistBTN.Location = new System.Drawing.Point(306, 342);
            this.LevelDistBTN.Name = "LevelDistBTN";
            this.LevelDistBTN.Size = new System.Drawing.Size(89, 37);
            this.LevelDistBTN.TabIndex = 8;
            this.LevelDistBTN.Text = "Level Dist";
            this.LevelDistBTN.UseVisualStyleBackColor = true;
            // 
            // MinBTN
            // 
            this.MinBTN.Location = new System.Drawing.Point(166, 342);
            this.MinBTN.Name = "MinBTN";
            this.MinBTN.Size = new System.Drawing.Size(95, 37);
            this.MinBTN.TabIndex = 7;
            this.MinBTN.Text = "Min";
            this.MinBTN.UseVisualStyleBackColor = true;
            // 
            // MaxBTN
            // 
            this.MaxBTN.Location = new System.Drawing.Point(27, 342);
            this.MaxBTN.Name = "MaxBTN";
            this.MaxBTN.Size = new System.Drawing.Size(95, 37);
            this.MaxBTN.TabIndex = 6;
            this.MaxBTN.Text = "Max";
            this.MaxBTN.UseVisualStyleBackColor = true;
            // 
            // DoneBTN
            // 
            this.DoneBTN.Location = new System.Drawing.Point(590, 323);
            this.DoneBTN.Name = "DoneBTN";
            this.DoneBTN.Size = new System.Drawing.Size(89, 37);
            this.DoneBTN.TabIndex = 10;
            this.DoneBTN.Text = "Done";
            this.DoneBTN.UseVisualStyleBackColor = true;
            // 
            // ExitBTN
            // 
            this.ExitBTN.Location = new System.Drawing.Point(696, 323);
            this.ExitBTN.Name = "ExitBTN";
            this.ExitBTN.Size = new System.Drawing.Size(89, 37);
            this.ExitBTN.TabIndex = 11;
            this.ExitBTN.Text = "Exit";
            this.ExitBTN.UseVisualStyleBackColor = true;
            // 
            // displayTextBox
            // 
            this.displayTextBox.Location = new System.Drawing.Point(570, 14);
            this.displayTextBox.Multiline = true;
            this.displayTextBox.Name = "displayTextBox";
            this.displayTextBox.ReadOnly = true;
            this.displayTextBox.Size = new System.Drawing.Size(241, 268);
            this.displayTextBox.TabIndex = 12;
            this.displayTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // InquiryUIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 397);
            this.ControlBox = false;
            this.Controls.Add(this.displayTextBox);
            this.Controls.Add(this.ExitBTN);
            this.Controls.Add(this.DoneBTN);
            this.Controls.Add(this.GraphBTN);
            this.Controls.Add(this.LevelDistBTN);
            this.Controls.Add(this.MinBTN);
            this.Controls.Add(this.MaxBTN);
            this.Controls.Add(this.ZeroBalanceBTN);
            this.Controls.Add(this.DebitBalanceBTN);
            this.Controls.Add(this.CreditBalanceBTN);
            this.Controls.Add(this.OpenFileBTN);
            this.Controls.Add(this.dataGridView);
            this.Name = "InquiryUIForm";
            this.Text = "InquiryUIForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView;
        public System.Windows.Forms.DataGridViewTextBoxColumn Account;
        public System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        public System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        public System.Windows.Forms.DataGridViewTextBoxColumn Balance;
        public System.Windows.Forms.Button OpenFileBTN;
        public System.Windows.Forms.Button CreditBalanceBTN;
        public System.Windows.Forms.Button DebitBalanceBTN;
        public System.Windows.Forms.Button ZeroBalanceBTN;
        public System.Windows.Forms.Button GraphBTN;
        public System.Windows.Forms.Button LevelDistBTN;
        public System.Windows.Forms.Button MinBTN;
        public System.Windows.Forms.Button MaxBTN;
        public System.Windows.Forms.Button DoneBTN;
        public System.Windows.Forms.Button ExitBTN;
        public System.Windows.Forms.TextBox displayTextBox;

    }
}

