namespace BankUIForm_20150507
{
    partial class ReadSequentialAccessFile
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
            this.OpenBTN = new System.Windows.Forms.Button();
            this.NextBTN = new System.Windows.Forms.Button();
            this.ExitBTN = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // AccountTB
            // 
            this.AccountTB.BackColor = System.Drawing.Color.White;
            this.AccountTB.Location = new System.Drawing.Point(113, 23);
            this.AccountTB.ReadOnly = true;
            this.AccountTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FirstNameTB
            // 
            this.FirstNameTB.BackColor = System.Drawing.Color.White;
            this.FirstNameTB.Location = new System.Drawing.Point(113, 65);
            this.FirstNameTB.ReadOnly = true;
            this.FirstNameTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LastNameTB
            // 
            this.LastNameTB.BackColor = System.Drawing.Color.White;
            this.LastNameTB.Location = new System.Drawing.Point(113, 106);
            this.LastNameTB.ReadOnly = true;
            this.LastNameTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BalanceTB
            // 
            this.BalanceTB.BackColor = System.Drawing.Color.White;
            this.BalanceTB.Location = new System.Drawing.Point(113, 150);
            this.BalanceTB.ReadOnly = true;
            this.BalanceTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // OpenBTN
            // 
            this.OpenBTN.Location = new System.Drawing.Point(12, 200);
            this.OpenBTN.Name = "OpenBTN";
            this.OpenBTN.Size = new System.Drawing.Size(75, 23);
            this.OpenBTN.TabIndex = 8;
            this.OpenBTN.Text = "Open File";
            this.OpenBTN.UseVisualStyleBackColor = true;
            this.OpenBTN.Click += new System.EventHandler(this.OpenBTN_Click);
            // 
            // NextBTN
            // 
            this.NextBTN.Enabled = false;
            this.NextBTN.Location = new System.Drawing.Point(93, 200);
            this.NextBTN.Name = "NextBTN";
            this.NextBTN.Size = new System.Drawing.Size(75, 23);
            this.NextBTN.TabIndex = 9;
            this.NextBTN.Text = "Start";
            this.NextBTN.UseVisualStyleBackColor = true;
            this.NextBTN.Click += new System.EventHandler(this.NextBTN_Click);
            // 
            // ExitBTN
            // 
            this.ExitBTN.Location = new System.Drawing.Point(174, 200);
            this.ExitBTN.Name = "ExitBTN";
            this.ExitBTN.Size = new System.Drawing.Size(75, 23);
            this.ExitBTN.TabIndex = 10;
            this.ExitBTN.Text = "Exit";
            this.ExitBTN.UseVisualStyleBackColor = true;
            this.ExitBTN.Click += new System.EventHandler(this.ExitBTN_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // ReadSequentialAccessFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 245);
            this.Controls.Add(this.ExitBTN);
            this.Controls.Add(this.NextBTN);
            this.Controls.Add(this.OpenBTN);
            this.Name = "ReadSequentialAccessFile";
            this.Text = "ReadSequentialAccessFile";
            this.Controls.SetChildIndex(this.AccountTB, 0);
            this.Controls.SetChildIndex(this.FirstNameTB, 0);
            this.Controls.SetChildIndex(this.LastNameTB, 0);
            this.Controls.SetChildIndex(this.BalanceTB, 0);
            this.Controls.SetChildIndex(this.OpenBTN, 0);
            this.Controls.SetChildIndex(this.NextBTN, 0);
            this.Controls.SetChildIndex(this.ExitBTN, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OpenBTN;
        private System.Windows.Forms.Button NextBTN;
        private System.Windows.Forms.Button ExitBTN;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}