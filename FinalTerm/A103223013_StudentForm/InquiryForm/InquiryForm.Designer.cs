namespace InquiryForm
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
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.ChooseShowModeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExitBTN
            // 
            this.ExitBTN.Click += new System.EventHandler(this.ExitBTN_Click);
            // 
            // DoneBTN
            // 
            this.DoneBTN.Click += new System.EventHandler(this.DoneBTN_Click);
            // 
            // GraphBTN
            // 
            this.GraphBTN.Location = new System.Drawing.Point(733, 300);
            this.GraphBTN.Click += new System.EventHandler(this.GraphBTN_Click);
            // 
            // DescendingOrderBTN
            // 
            this.DescendingOrderBTN.Location = new System.Drawing.Point(629, 299);
            this.DescendingOrderBTN.Click += new System.EventHandler(this.getAscendingOrDescending_Click);
            // 
            // AscendingOrderBTN
            // 
            this.AscendingOrderBTN.Location = new System.Drawing.Point(525, 299);
            this.AscendingOrderBTN.Click += new System.EventHandler(this.getAscendingOrDescending_Click);
            // 
            // FailScoreBTN
            // 
            this.FailScoreBTN.Location = new System.Drawing.Point(421, 300);
            this.FailScoreBTN.Click += new System.EventHandler(this.getScores_Click);
            // 
            // JustPassScoreBTN
            // 
            this.JustPassScoreBTN.Location = new System.Drawing.Point(317, 299);
            this.JustPassScoreBTN.Click += new System.EventHandler(this.getScores_Click);
            // 
            // PassScoreBTN
            // 
            this.PassScoreBTN.Location = new System.Drawing.Point(213, 298);
            this.PassScoreBTN.Click += new System.EventHandler(this.getScores_Click);
            // 
            // OpenFileBTN
            // 
            this.OpenFileBTN.Click += new System.EventHandler(this.OpenFileBTN_Click);
            // 
            // ChooseShowModeGroupBox
            // 
            this.ChooseShowModeGroupBox.Location = new System.Drawing.Point(27, 294);
            // 
            // NormalGradeRadioBTN
            // 
            this.NormalGradeRadioBTN.CheckedChanged += new System.EventHandler(this.RadioButtons_CheckedChanged);
            // 
            // FinalTermRadioBTN
            // 
            this.FinalTermRadioBTN.CheckedChanged += new System.EventHandler(this.RadioButtons_CheckedChanged);
            // 
            // MidTermRadioBTN
            // 
            this.MidTermRadioBTN.CheckedChanged += new System.EventHandler(this.RadioButtons_CheckedChanged);
            // 
            // ShowAllScoreRadioBTN
            // 
            this.ShowAllScoreRadioBTN.Size = new System.Drawing.Size(62, 16);
            this.ShowAllScoreRadioBTN.Text = "Average";
            this.ShowAllScoreRadioBTN.CheckedChanged += new System.EventHandler(this.RadioButtons_CheckedChanged);
            // 
            // ALevelBTN
            // 
            this.ALevelBTN.Click += new System.EventHandler(this.LevelBTN_Click);
            // 
            // BLevelBTN
            // 
            this.BLevelBTN.Click += new System.EventHandler(this.LevelBTN_Click);
            // 
            // CLevelBTN
            // 
            this.CLevelBTN.Click += new System.EventHandler(this.LevelBTN_Click);
            // 
            // DLevelBTN
            // 
            this.DLevelBTN.Click += new System.EventHandler(this.LevelBTN_Click);
            // 
            // FLevelBTN
            // 
            this.FLevelBTN.Click += new System.EventHandler(this.LevelBTN_Click);
            // 
            // LevelDistributionBTN
            // 
            this.LevelDistributionBTN.Click += new System.EventHandler(this.LevelDistributionBTN_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // InquiryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 420);
            this.Name = "InquiryForm";
            this.ChooseShowModeGroupBox.ResumeLayout(false);
            this.ChooseShowModeGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}