namespace ReadFileForm_A103223013
{
    partial class ReadFileForm
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
            this.OpenFile_BTN = new System.Windows.Forms.Button();
            this.Next_BTN = new System.Windows.Forms.Button();
            this.Exit_BTN = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // StudentID_TB
            // 
            this.StudentID_TB.BackColor = System.Drawing.Color.White;
            this.StudentID_TB.ReadOnly = true;
            this.StudentID_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FirstName_TB
            // 
            this.FirstName_TB.BackColor = System.Drawing.Color.White;
            this.FirstName_TB.ReadOnly = true;
            this.FirstName_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LastName_TB
            // 
            this.LastName_TB.BackColor = System.Drawing.Color.White;
            this.LastName_TB.ReadOnly = true;
            this.LastName_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MidTerm_TB
            // 
            this.MidTerm_TB.BackColor = System.Drawing.Color.White;
            this.MidTerm_TB.ReadOnly = true;
            this.MidTerm_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FinalTerm_TB
            // 
            this.FinalTerm_TB.BackColor = System.Drawing.Color.White;
            this.FinalTerm_TB.ReadOnly = true;
            this.FinalTerm_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NormalGrade_TB
            // 
            this.NormalGrade_TB.BackColor = System.Drawing.Color.White;
            this.NormalGrade_TB.ReadOnly = true;
            this.NormalGrade_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Average_TB
            // 
            this.Average_TB.BackColor = System.Drawing.Color.White;
            // 
            // OpenFile_BTN
            // 
            this.OpenFile_BTN.Location = new System.Drawing.Point(12, 219);
            this.OpenFile_BTN.Name = "OpenFile_BTN";
            this.OpenFile_BTN.Size = new System.Drawing.Size(75, 23);
            this.OpenFile_BTN.TabIndex = 12;
            this.OpenFile_BTN.Text = "Open File";
            this.OpenFile_BTN.UseVisualStyleBackColor = true;
            this.OpenFile_BTN.Click += new System.EventHandler(this.OpenFile_BTN_Click);
            // 
            // Next_BTN
            // 
            this.Next_BTN.Location = new System.Drawing.Point(93, 219);
            this.Next_BTN.Name = "Next_BTN";
            this.Next_BTN.Size = new System.Drawing.Size(75, 23);
            this.Next_BTN.TabIndex = 13;
            this.Next_BTN.Text = "Next";
            this.Next_BTN.UseVisualStyleBackColor = true;
            this.Next_BTN.Click += new System.EventHandler(this.Next_BTN_Click);
            // 
            // Exit_BTN
            // 
            this.Exit_BTN.Location = new System.Drawing.Point(174, 219);
            this.Exit_BTN.Name = "Exit_BTN";
            this.Exit_BTN.Size = new System.Drawing.Size(75, 23);
            this.Exit_BTN.TabIndex = 14;
            this.Exit_BTN.Text = "Exit";
            this.Exit_BTN.UseVisualStyleBackColor = true;
            this.Exit_BTN.Click += new System.EventHandler(this.Exit_BTN_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // ReadFileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 272);
            this.Controls.Add(this.Exit_BTN);
            this.Controls.Add(this.Next_BTN);
            this.Controls.Add(this.OpenFile_BTN);
            this.Name = "ReadFileForm";
            this.Text = "ReadFile";
            this.Controls.SetChildIndex(this.Average_Label, 0);
            this.Controls.SetChildIndex(this.Average_TB, 0);
            this.Controls.SetChildIndex(this.StudentID_LB, 0);
            this.Controls.SetChildIndex(this.StudentID_TB, 0);
            this.Controls.SetChildIndex(this.FirstName_LB, 0);
            this.Controls.SetChildIndex(this.FirstName_TB, 0);
            this.Controls.SetChildIndex(this.LastName_LB, 0);
            this.Controls.SetChildIndex(this.LastName_TB, 0);
            this.Controls.SetChildIndex(this.MidTerm_LB, 0);
            this.Controls.SetChildIndex(this.MidTerm_TB, 0);
            this.Controls.SetChildIndex(this.FinalTerm_LB, 0);
            this.Controls.SetChildIndex(this.FinalTerm_TB, 0);
            this.Controls.SetChildIndex(this.NormalGrade_LB, 0);
            this.Controls.SetChildIndex(this.NormalGrade_TB, 0);
            this.Controls.SetChildIndex(this.OpenFile_BTN, 0);
            this.Controls.SetChildIndex(this.Next_BTN, 0);
            this.Controls.SetChildIndex(this.Exit_BTN, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OpenFile_BTN;
        private System.Windows.Forms.Button Next_BTN;
        private System.Windows.Forms.Button Exit_BTN;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

