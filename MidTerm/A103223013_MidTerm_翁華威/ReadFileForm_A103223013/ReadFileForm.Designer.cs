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
            this.ChooseMethodGroupBox = new System.Windows.Forms.GroupBox();
            this.Text_BTN = new System.Windows.Forms.RadioButton();
            this.Binary_BTN = new System.Windows.Forms.RadioButton();
            this.ChooseMethodGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // OpenFile_BTN
            // 
            this.OpenFile_BTN.Location = new System.Drawing.Point(63, 191);
            this.OpenFile_BTN.Name = "OpenFile_BTN";
            this.OpenFile_BTN.Size = new System.Drawing.Size(75, 23);
            this.OpenFile_BTN.TabIndex = 12;
            this.OpenFile_BTN.Text = "Open File";
            this.OpenFile_BTN.UseVisualStyleBackColor = true;
            this.OpenFile_BTN.Click += new System.EventHandler(this.OpenFile_BTN_Click);
            // 
            // Next_BTN
            // 
            this.Next_BTN.Location = new System.Drawing.Point(144, 191);
            this.Next_BTN.Name = "Next_BTN";
            this.Next_BTN.Size = new System.Drawing.Size(75, 23);
            this.Next_BTN.TabIndex = 13;
            this.Next_BTN.Text = "Next";
            this.Next_BTN.UseVisualStyleBackColor = true;
            this.Next_BTN.Click += new System.EventHandler(this.Next_BTN_Click);
            // 
            // Exit_BTN
            // 
            this.Exit_BTN.Location = new System.Drawing.Point(235, 191);
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
            // ChooseMethodGroupBox
            // 
            this.ChooseMethodGroupBox.Controls.Add(this.Binary_BTN);
            this.ChooseMethodGroupBox.Controls.Add(this.Text_BTN);
            this.ChooseMethodGroupBox.Location = new System.Drawing.Point(235, 106);
            this.ChooseMethodGroupBox.Name = "ChooseMethodGroupBox";
            this.ChooseMethodGroupBox.Size = new System.Drawing.Size(98, 68);
            this.ChooseMethodGroupBox.TabIndex = 15;
            this.ChooseMethodGroupBox.TabStop = false;
            this.ChooseMethodGroupBox.Text = "ChooseMethod";
            // 
            // Text_BTN
            // 
            this.Text_BTN.AutoSize = true;
            this.Text_BTN.Checked = true;
            this.Text_BTN.Location = new System.Drawing.Point(6, 21);
            this.Text_BTN.Name = "Text_BTN";
            this.Text_BTN.Size = new System.Drawing.Size(44, 16);
            this.Text_BTN.TabIndex = 0;
            this.Text_BTN.TabStop = true;
            this.Text_BTN.Text = "Text";
            this.Text_BTN.UseVisualStyleBackColor = true;
            // 
            // Binary_BTN
            // 
            this.Binary_BTN.AutoSize = true;
            this.Binary_BTN.Location = new System.Drawing.Point(6, 43);
            this.Binary_BTN.Name = "Binary_BTN";
            this.Binary_BTN.Size = new System.Drawing.Size(55, 16);
            this.Binary_BTN.TabIndex = 1;
            this.Binary_BTN.Text = "Binary";
            this.Binary_BTN.UseVisualStyleBackColor = true;
            // 
            // ReadFileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 219);
            this.Controls.Add(this.ChooseMethodGroupBox);
            this.Controls.Add(this.Exit_BTN);
            this.Controls.Add(this.Next_BTN);
            this.Controls.Add(this.OpenFile_BTN);
            this.Name = "ReadFileForm";
            this.Text = "ReadFile";
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
            this.Controls.SetChildIndex(this.ChooseMethodGroupBox, 0);
            this.ChooseMethodGroupBox.ResumeLayout(false);
            this.ChooseMethodGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OpenFile_BTN;
        private System.Windows.Forms.Button Next_BTN;
        private System.Windows.Forms.Button Exit_BTN;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.GroupBox ChooseMethodGroupBox;
        private System.Windows.Forms.RadioButton Binary_BTN;
        private System.Windows.Forms.RadioButton Text_BTN;
    }
}

