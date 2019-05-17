namespace CreateFileForm_A103223013
{
    partial class CreateFileForm
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
            this.Save_BTN = new System.Windows.Forms.Button();
            this.Enter_BTN = new System.Windows.Forms.Button();
            this.Exit_BTN = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.ChooseMethodgroupBox = new System.Windows.Forms.GroupBox();
            this.TextRadioBTN = new System.Windows.Forms.RadioButton();
            this.BinaryRadioBTN = new System.Windows.Forms.RadioButton();
            this.ChooseMethodgroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Save_BTN
            // 
            this.Save_BTN.Location = new System.Drawing.Point(46, 190);
            this.Save_BTN.Name = "Save_BTN";
            this.Save_BTN.Size = new System.Drawing.Size(75, 23);
            this.Save_BTN.TabIndex = 12;
            this.Save_BTN.Text = "Save as";
            this.Save_BTN.UseVisualStyleBackColor = true;
            this.Save_BTN.Click += new System.EventHandler(this.Save_BTN_Click);
            // 
            // Enter_BTN
            // 
            this.Enter_BTN.Location = new System.Drawing.Point(127, 190);
            this.Enter_BTN.Name = "Enter_BTN";
            this.Enter_BTN.Size = new System.Drawing.Size(75, 23);
            this.Enter_BTN.TabIndex = 13;
            this.Enter_BTN.Text = "Enter";
            this.Enter_BTN.UseVisualStyleBackColor = true;
            this.Enter_BTN.Click += new System.EventHandler(this.Enter_BTN_Click);
            // 
            // Exit_BTN
            // 
            this.Exit_BTN.Location = new System.Drawing.Point(265, 190);
            this.Exit_BTN.Name = "Exit_BTN";
            this.Exit_BTN.Size = new System.Drawing.Size(75, 23);
            this.Exit_BTN.TabIndex = 14;
            this.Exit_BTN.Text = "Exit";
            this.Exit_BTN.UseVisualStyleBackColor = true;
            this.Exit_BTN.Click += new System.EventHandler(this.Exit_BTN_Click);
            // 
            // ChooseMethodgroupBox
            // 
            this.ChooseMethodgroupBox.Controls.Add(this.BinaryRadioBTN);
            this.ChooseMethodgroupBox.Controls.Add(this.TextRadioBTN);
            this.ChooseMethodgroupBox.Location = new System.Drawing.Point(237, 68);
            this.ChooseMethodgroupBox.Name = "ChooseMethodgroupBox";
            this.ChooseMethodgroupBox.Size = new System.Drawing.Size(103, 68);
            this.ChooseMethodgroupBox.TabIndex = 15;
            this.ChooseMethodgroupBox.TabStop = false;
            this.ChooseMethodgroupBox.Text = "ChooseMethod";
            // 
            // TextRadioBTN
            // 
            this.TextRadioBTN.AutoSize = true;
            this.TextRadioBTN.Checked = true;
            this.TextRadioBTN.Location = new System.Drawing.Point(6, 19);
            this.TextRadioBTN.Name = "TextRadioBTN";
            this.TextRadioBTN.Size = new System.Drawing.Size(44, 16);
            this.TextRadioBTN.TabIndex = 0;
            this.TextRadioBTN.TabStop = true;
            this.TextRadioBTN.Text = "Text";
            this.TextRadioBTN.UseVisualStyleBackColor = true;
            // 
            // BinaryRadioBTN
            // 
            this.BinaryRadioBTN.AutoSize = true;
            this.BinaryRadioBTN.Location = new System.Drawing.Point(6, 40);
            this.BinaryRadioBTN.Name = "BinaryRadioBTN";
            this.BinaryRadioBTN.Size = new System.Drawing.Size(55, 16);
            this.BinaryRadioBTN.TabIndex = 1;
            this.BinaryRadioBTN.Text = "Binary";
            this.BinaryRadioBTN.UseVisualStyleBackColor = true;
            // 
            // CreateFileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 235);
            this.Controls.Add(this.ChooseMethodgroupBox);
            this.Controls.Add(this.Exit_BTN);
            this.Controls.Add(this.Enter_BTN);
            this.Controls.Add(this.Save_BTN);
            this.Name = "CreateFileForm";
            this.Text = "CreateFileForm";
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
            this.Controls.SetChildIndex(this.Save_BTN, 0);
            this.Controls.SetChildIndex(this.Enter_BTN, 0);
            this.Controls.SetChildIndex(this.Exit_BTN, 0);
            this.Controls.SetChildIndex(this.ChooseMethodgroupBox, 0);
            this.ChooseMethodgroupBox.ResumeLayout(false);
            this.ChooseMethodgroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Save_BTN;
        private System.Windows.Forms.Button Enter_BTN;
        private System.Windows.Forms.Button Exit_BTN;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.GroupBox ChooseMethodgroupBox;
        private System.Windows.Forms.RadioButton BinaryRadioBTN;
        private System.Windows.Forms.RadioButton TextRadioBTN;
    }
}

