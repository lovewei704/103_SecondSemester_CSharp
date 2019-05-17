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
            this.BinaryRadioBTN = new System.Windows.Forms.RadioButton();
            this.TextRadioBTN = new System.Windows.Forms.RadioButton();
            this.MidTermRatio_TB = new System.Windows.Forms.TextBox();
            this.FinalTermRatio_TB = new System.Windows.Forms.TextBox();
            this.NormalGradeRatio_TB = new System.Windows.Forms.TextBox();
            this.MidTermRatioLabel = new System.Windows.Forms.Label();
            this.FinalTermRatioLabel = new System.Windows.Forms.Label();
            this.NormalGradeRatio = new System.Windows.Forms.Label();
            this.EnterRatioBTN = new System.Windows.Forms.Button();
            this.ChooseMethodgroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // StudentID_TB
            // 
            this.StudentID_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FirstName_TB
            // 
            this.FirstName_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LastName_TB
            // 
            this.LastName_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MidTerm_TB
            // 
            this.MidTerm_TB.Enabled = false;
            this.MidTerm_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MidTerm_TB.TextChanged += new System.EventHandler(this.Score_TB_TextChanged);
            // 
            // FinalTerm_TB
            // 
            this.FinalTerm_TB.Enabled = false;
            this.FinalTerm_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FinalTerm_TB.TextChanged += new System.EventHandler(this.Score_TB_TextChanged);
            // 
            // NormalGrade_TB
            // 
            this.NormalGrade_TB.Enabled = false;
            this.NormalGrade_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NormalGrade_TB.TextChanged += new System.EventHandler(this.Score_TB_TextChanged);
            // 
            // Save_BTN
            // 
            this.Save_BTN.Enabled = false;
            this.Save_BTN.Location = new System.Drawing.Point(48, 241);
            this.Save_BTN.Name = "Save_BTN";
            this.Save_BTN.Size = new System.Drawing.Size(75, 23);
            this.Save_BTN.TabIndex = 12;
            this.Save_BTN.Text = "Save as";
            this.Save_BTN.UseVisualStyleBackColor = true;
            this.Save_BTN.Click += new System.EventHandler(this.Save_BTN_Click);
            // 
            // Enter_BTN
            // 
            this.Enter_BTN.Location = new System.Drawing.Point(129, 241);
            this.Enter_BTN.Name = "Enter_BTN";
            this.Enter_BTN.Size = new System.Drawing.Size(75, 23);
            this.Enter_BTN.TabIndex = 13;
            this.Enter_BTN.Text = "Enter";
            this.Enter_BTN.UseVisualStyleBackColor = true;
            this.Enter_BTN.Click += new System.EventHandler(this.Enter_BTN_Click);
            // 
            // Exit_BTN
            // 
            this.Exit_BTN.Location = new System.Drawing.Point(346, 241);
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
            this.ChooseMethodgroupBox.Location = new System.Drawing.Point(237, 12);
            this.ChooseMethodgroupBox.Name = "ChooseMethodgroupBox";
            this.ChooseMethodgroupBox.Size = new System.Drawing.Size(198, 63);
            this.ChooseMethodgroupBox.TabIndex = 15;
            this.ChooseMethodgroupBox.TabStop = false;
            this.ChooseMethodgroupBox.Text = "ChooseMethod";
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
            // MidTermRatio_TB
            // 
            this.MidTermRatio_TB.Location = new System.Drawing.Point(321, 103);
            this.MidTermRatio_TB.Name = "MidTermRatio_TB";
            this.MidTermRatio_TB.Size = new System.Drawing.Size(100, 22);
            this.MidTermRatio_TB.TabIndex = 18;
            this.MidTermRatio_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FinalTermRatio_TB
            // 
            this.FinalTermRatio_TB.Location = new System.Drawing.Point(321, 131);
            this.FinalTermRatio_TB.Name = "FinalTermRatio_TB";
            this.FinalTermRatio_TB.Size = new System.Drawing.Size(100, 22);
            this.FinalTermRatio_TB.TabIndex = 19;
            this.FinalTermRatio_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NormalGradeRatio_TB
            // 
            this.NormalGradeRatio_TB.Location = new System.Drawing.Point(321, 157);
            this.NormalGradeRatio_TB.Name = "NormalGradeRatio_TB";
            this.NormalGradeRatio_TB.Size = new System.Drawing.Size(100, 22);
            this.NormalGradeRatio_TB.TabIndex = 20;
            this.NormalGradeRatio_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MidTermRatioLabel
            // 
            this.MidTermRatioLabel.AutoSize = true;
            this.MidTermRatioLabel.Location = new System.Drawing.Point(241, 106);
            this.MidTermRatioLabel.Name = "MidTermRatioLabel";
            this.MidTermRatioLabel.Size = new System.Drawing.Size(74, 12);
            this.MidTermRatioLabel.TabIndex = 21;
            this.MidTermRatioLabel.Text = "MidTermRatio";
            // 
            // FinalTermRatioLabel
            // 
            this.FinalTermRatioLabel.AutoSize = true;
            this.FinalTermRatioLabel.Location = new System.Drawing.Point(237, 134);
            this.FinalTermRatioLabel.Name = "FinalTermRatioLabel";
            this.FinalTermRatioLabel.Size = new System.Drawing.Size(78, 12);
            this.FinalTermRatioLabel.TabIndex = 22;
            this.FinalTermRatioLabel.Text = "FinalTermRatio";
            // 
            // NormalGradeRatio
            // 
            this.NormalGradeRatio.AutoSize = true;
            this.NormalGradeRatio.Location = new System.Drawing.Point(222, 160);
            this.NormalGradeRatio.Name = "NormalGradeRatio";
            this.NormalGradeRatio.Size = new System.Drawing.Size(93, 12);
            this.NormalGradeRatio.TabIndex = 23;
            this.NormalGradeRatio.Text = "NormalGradeRatio";
            // 
            // EnterRatioBTN
            // 
            this.EnterRatioBTN.Location = new System.Drawing.Point(224, 185);
            this.EnterRatioBTN.Name = "EnterRatioBTN";
            this.EnterRatioBTN.Size = new System.Drawing.Size(197, 23);
            this.EnterRatioBTN.TabIndex = 24;
            this.EnterRatioBTN.Text = "Enter All Ratio";
            this.EnterRatioBTN.UseVisualStyleBackColor = true;
            this.EnterRatioBTN.Click += new System.EventHandler(this.EnterRatioBTN_Click);
            // 
            // CreateFileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 285);
            this.Controls.Add(this.EnterRatioBTN);
            this.Controls.Add(this.NormalGradeRatio);
            this.Controls.Add(this.FinalTermRatioLabel);
            this.Controls.Add(this.MidTermRatioLabel);
            this.Controls.Add(this.NormalGradeRatio_TB);
            this.Controls.Add(this.FinalTermRatio_TB);
            this.Controls.Add(this.MidTermRatio_TB);
            this.Controls.Add(this.ChooseMethodgroupBox);
            this.Controls.Add(this.Exit_BTN);
            this.Controls.Add(this.Enter_BTN);
            this.Controls.Add(this.Save_BTN);
            this.Name = "CreateFileForm";
            this.Text = "CreateFileForm";
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
            this.Controls.SetChildIndex(this.Save_BTN, 0);
            this.Controls.SetChildIndex(this.Enter_BTN, 0);
            this.Controls.SetChildIndex(this.Exit_BTN, 0);
            this.Controls.SetChildIndex(this.ChooseMethodgroupBox, 0);
            this.Controls.SetChildIndex(this.MidTermRatio_TB, 0);
            this.Controls.SetChildIndex(this.FinalTermRatio_TB, 0);
            this.Controls.SetChildIndex(this.NormalGradeRatio_TB, 0);
            this.Controls.SetChildIndex(this.MidTermRatioLabel, 0);
            this.Controls.SetChildIndex(this.FinalTermRatioLabel, 0);
            this.Controls.SetChildIndex(this.NormalGradeRatio, 0);
            this.Controls.SetChildIndex(this.EnterRatioBTN, 0);
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
        private System.Windows.Forms.TextBox MidTermRatio_TB;
        private System.Windows.Forms.TextBox FinalTermRatio_TB;
        private System.Windows.Forms.TextBox NormalGradeRatio_TB;
        private System.Windows.Forms.Label MidTermRatioLabel;
        private System.Windows.Forms.Label FinalTermRatioLabel;
        private System.Windows.Forms.Label NormalGradeRatio;
        private System.Windows.Forms.Button EnterRatioBTN;
    }
}

