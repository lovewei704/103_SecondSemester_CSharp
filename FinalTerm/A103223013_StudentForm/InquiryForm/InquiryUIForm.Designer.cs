namespace InquiryForm
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
            this.displayTextBox = new System.Windows.Forms.TextBox();
            this.ExitBTN = new System.Windows.Forms.Button();
            this.DoneBTN = new System.Windows.Forms.Button();
            this.GraphBTN = new System.Windows.Forms.Button();
            this.DescendingOrderBTN = new System.Windows.Forms.Button();
            this.AscendingOrderBTN = new System.Windows.Forms.Button();
            this.FailScoreBTN = new System.Windows.Forms.Button();
            this.JustPassScoreBTN = new System.Windows.Forms.Button();
            this.PassScoreBTN = new System.Windows.Forms.Button();
            this.OpenFileBTN = new System.Windows.Forms.Button();
            this.ChooseShowModeGroupBox = new System.Windows.Forms.GroupBox();
            this.ShowAllScoreRadioBTN = new System.Windows.Forms.RadioButton();
            this.NormalGradeRadioBTN = new System.Windows.Forms.RadioButton();
            this.FinalTermRadioBTN = new System.Windows.Forms.RadioButton();
            this.MidTermRadioBTN = new System.Windows.Forms.RadioButton();
            this.StudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MidTerm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FinalTerm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NormalGrade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Average = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ALevelBTN = new System.Windows.Forms.Button();
            this.BLevelBTN = new System.Windows.Forms.Button();
            this.CLevelBTN = new System.Windows.Forms.Button();
            this.DLevelBTN = new System.Windows.Forms.Button();
            this.FLevelBTN = new System.Windows.Forms.Button();
            this.LevelDistributionBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.ChooseShowModeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentID,
            this.FirstName,
            this.LastName,
            this.MidTerm,
            this.FinalTerm,
            this.NormalGrade,
            this.Average});
            this.dataGridView.Location = new System.Drawing.Point(12, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(919, 270);
            this.dataGridView.TabIndex = 13;
            // 
            // displayTextBox
            // 
            this.displayTextBox.Location = new System.Drawing.Point(945, 14);
            this.displayTextBox.Multiline = true;
            this.displayTextBox.Name = "displayTextBox";
            this.displayTextBox.ReadOnly = true;
            this.displayTextBox.Size = new System.Drawing.Size(241, 268);
            this.displayTextBox.TabIndex = 24;
            this.displayTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ExitBTN
            // 
            this.ExitBTN.Location = new System.Drawing.Point(1069, 305);
            this.ExitBTN.Name = "ExitBTN";
            this.ExitBTN.Size = new System.Drawing.Size(98, 43);
            this.ExitBTN.TabIndex = 23;
            this.ExitBTN.Text = "Exit";
            this.ExitBTN.UseVisualStyleBackColor = true;
            // 
            // DoneBTN
            // 
            this.DoneBTN.Location = new System.Drawing.Point(965, 305);
            this.DoneBTN.Name = "DoneBTN";
            this.DoneBTN.Size = new System.Drawing.Size(98, 43);
            this.DoneBTN.TabIndex = 22;
            this.DoneBTN.Text = "Done";
            this.DoneBTN.UseVisualStyleBackColor = true;
            // 
            // GraphBTN
            // 
            this.GraphBTN.Location = new System.Drawing.Point(734, 302);
            this.GraphBTN.Name = "GraphBTN";
            this.GraphBTN.Size = new System.Drawing.Size(98, 42);
            this.GraphBTN.TabIndex = 21;
            this.GraphBTN.Text = "Graph";
            this.GraphBTN.UseVisualStyleBackColor = true;
            // 
            // DescendingOrderBTN
            // 
            this.DescendingOrderBTN.Location = new System.Drawing.Point(630, 301);
            this.DescendingOrderBTN.Name = "DescendingOrderBTN";
            this.DescendingOrderBTN.Size = new System.Drawing.Size(98, 43);
            this.DescendingOrderBTN.TabIndex = 19;
            this.DescendingOrderBTN.Text = "Descending Order";
            this.DescendingOrderBTN.UseVisualStyleBackColor = true;
            // 
            // AscendingOrderBTN
            // 
            this.AscendingOrderBTN.Location = new System.Drawing.Point(526, 301);
            this.AscendingOrderBTN.Name = "AscendingOrderBTN";
            this.AscendingOrderBTN.Size = new System.Drawing.Size(98, 43);
            this.AscendingOrderBTN.TabIndex = 18;
            this.AscendingOrderBTN.Text = "Ascending Order";
            this.AscendingOrderBTN.UseVisualStyleBackColor = true;
            // 
            // FailScoreBTN
            // 
            this.FailScoreBTN.Location = new System.Drawing.Point(422, 302);
            this.FailScoreBTN.Name = "FailScoreBTN";
            this.FailScoreBTN.Size = new System.Drawing.Size(98, 42);
            this.FailScoreBTN.TabIndex = 17;
            this.FailScoreBTN.Text = "Fail Score";
            this.FailScoreBTN.UseVisualStyleBackColor = true;
            // 
            // JustPassScoreBTN
            // 
            this.JustPassScoreBTN.Location = new System.Drawing.Point(318, 301);
            this.JustPassScoreBTN.Name = "JustPassScoreBTN";
            this.JustPassScoreBTN.Size = new System.Drawing.Size(98, 42);
            this.JustPassScoreBTN.TabIndex = 16;
            this.JustPassScoreBTN.Text = "Just Pass Score";
            this.JustPassScoreBTN.UseVisualStyleBackColor = true;
            // 
            // PassScoreBTN
            // 
            this.PassScoreBTN.Location = new System.Drawing.Point(214, 300);
            this.PassScoreBTN.Name = "PassScoreBTN";
            this.PassScoreBTN.Size = new System.Drawing.Size(98, 43);
            this.PassScoreBTN.TabIndex = 15;
            this.PassScoreBTN.Text = "Pass Score";
            this.PassScoreBTN.UseVisualStyleBackColor = true;
            // 
            // OpenFileBTN
            // 
            this.OpenFileBTN.Location = new System.Drawing.Point(27, 300);
            this.OpenFileBTN.Name = "OpenFileBTN";
            this.OpenFileBTN.Size = new System.Drawing.Size(116, 81);
            this.OpenFileBTN.TabIndex = 14;
            this.OpenFileBTN.Text = "Open File";
            this.OpenFileBTN.UseVisualStyleBackColor = true;
            // 
            // ChooseShowModeGroupBox
            // 
            this.ChooseShowModeGroupBox.Controls.Add(this.ShowAllScoreRadioBTN);
            this.ChooseShowModeGroupBox.Controls.Add(this.NormalGradeRadioBTN);
            this.ChooseShowModeGroupBox.Controls.Add(this.FinalTermRadioBTN);
            this.ChooseShowModeGroupBox.Controls.Add(this.MidTermRadioBTN);
            this.ChooseShowModeGroupBox.Location = new System.Drawing.Point(27, 296);
            this.ChooseShowModeGroupBox.Name = "ChooseShowModeGroupBox";
            this.ChooseShowModeGroupBox.Size = new System.Drawing.Size(116, 115);
            this.ChooseShowModeGroupBox.TabIndex = 25;
            this.ChooseShowModeGroupBox.TabStop = false;
            this.ChooseShowModeGroupBox.Text = "Choose Show Mode";
            this.ChooseShowModeGroupBox.Visible = false;
            // 
            // ShowAllScoreRadioBTN
            // 
            this.ShowAllScoreRadioBTN.AutoSize = true;
            this.ShowAllScoreRadioBTN.Checked = true;
            this.ShowAllScoreRadioBTN.Location = new System.Drawing.Point(6, 88);
            this.ShowAllScoreRadioBTN.Name = "ShowAllScoreRadioBTN";
            this.ShowAllScoreRadioBTN.Size = new System.Drawing.Size(95, 16);
            this.ShowAllScoreRadioBTN.TabIndex = 3;
            this.ShowAllScoreRadioBTN.TabStop = true;
            this.ShowAllScoreRadioBTN.Text = "Show All Score";
            this.ShowAllScoreRadioBTN.UseVisualStyleBackColor = true;
            // 
            // NormalGradeRadioBTN
            // 
            this.NormalGradeRadioBTN.AutoSize = true;
            this.NormalGradeRadioBTN.Location = new System.Drawing.Point(6, 66);
            this.NormalGradeRadioBTN.Name = "NormalGradeRadioBTN";
            this.NormalGradeRadioBTN.Size = new System.Drawing.Size(90, 16);
            this.NormalGradeRadioBTN.TabIndex = 2;
            this.NormalGradeRadioBTN.Text = "Normal-Grade";
            this.NormalGradeRadioBTN.UseVisualStyleBackColor = true;
            // 
            // FinalTermRadioBTN
            // 
            this.FinalTermRadioBTN.AutoSize = true;
            this.FinalTermRadioBTN.Location = new System.Drawing.Point(7, 44);
            this.FinalTermRadioBTN.Name = "FinalTermRadioBTN";
            this.FinalTermRadioBTN.Size = new System.Drawing.Size(75, 16);
            this.FinalTermRadioBTN.TabIndex = 1;
            this.FinalTermRadioBTN.Text = "Final-Term";
            this.FinalTermRadioBTN.UseVisualStyleBackColor = true;
            // 
            // MidTermRadioBTN
            // 
            this.MidTermRadioBTN.AutoSize = true;
            this.MidTermRadioBTN.Location = new System.Drawing.Point(7, 22);
            this.MidTermRadioBTN.Name = "MidTermRadioBTN";
            this.MidTermRadioBTN.Size = new System.Drawing.Size(71, 16);
            this.MidTermRadioBTN.TabIndex = 0;
            this.MidTermRadioBTN.Text = "Mid-Term";
            this.MidTermRadioBTN.UseVisualStyleBackColor = true;
            // 
            // StudentID
            // 
            this.StudentID.HeaderText = "StudentID";
            this.StudentID.Name = "StudentID";
            this.StudentID.Width = 125;
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
            // MidTerm
            // 
            this.MidTerm.HeaderText = "Mid-Term";
            this.MidTerm.Name = "MidTerm";
            this.MidTerm.Width = 125;
            // 
            // FinalTerm
            // 
            this.FinalTerm.HeaderText = "Final-Term";
            this.FinalTerm.Name = "FinalTerm";
            this.FinalTerm.Width = 125;
            // 
            // NormalGrade
            // 
            this.NormalGrade.HeaderText = "Normal-Grade";
            this.NormalGrade.Name = "NormalGrade";
            this.NormalGrade.Width = 125;
            // 
            // Average
            // 
            this.Average.HeaderText = "Average";
            this.Average.Name = "Average";
            this.Average.Width = 125;
            // 
            // ALevelBTN
            // 
            this.ALevelBTN.Location = new System.Drawing.Point(254, 349);
            this.ALevelBTN.Name = "ALevelBTN";
            this.ALevelBTN.Size = new System.Drawing.Size(98, 43);
            this.ALevelBTN.TabIndex = 26;
            this.ALevelBTN.Text = "A   Level";
            this.ALevelBTN.UseVisualStyleBackColor = true;
            // 
            // BLevelBTN
            // 
            this.BLevelBTN.Location = new System.Drawing.Point(358, 349);
            this.BLevelBTN.Name = "BLevelBTN";
            this.BLevelBTN.Size = new System.Drawing.Size(98, 43);
            this.BLevelBTN.TabIndex = 27;
            this.BLevelBTN.Text = "B  Level";
            this.BLevelBTN.UseVisualStyleBackColor = true;
            // 
            // CLevelBTN
            // 
            this.CLevelBTN.Location = new System.Drawing.Point(462, 350);
            this.CLevelBTN.Name = "CLevelBTN";
            this.CLevelBTN.Size = new System.Drawing.Size(98, 43);
            this.CLevelBTN.TabIndex = 28;
            this.CLevelBTN.Text = "C  Level";
            this.CLevelBTN.UseVisualStyleBackColor = true;
            // 
            // DLevelBTN
            // 
            this.DLevelBTN.Location = new System.Drawing.Point(566, 349);
            this.DLevelBTN.Name = "DLevelBTN";
            this.DLevelBTN.Size = new System.Drawing.Size(98, 43);
            this.DLevelBTN.TabIndex = 29;
            this.DLevelBTN.Text = "D  Level";
            this.DLevelBTN.UseVisualStyleBackColor = true;
            // 
            // FLevelBTN
            // 
            this.FLevelBTN.Location = new System.Drawing.Point(670, 350);
            this.FLevelBTN.Name = "FLevelBTN";
            this.FLevelBTN.Size = new System.Drawing.Size(98, 43);
            this.FLevelBTN.TabIndex = 30;
            this.FLevelBTN.Text = "F  Level";
            this.FLevelBTN.UseVisualStyleBackColor = true;
            // 
            // LevelDistributionBTN
            // 
            this.LevelDistributionBTN.Location = new System.Drawing.Point(774, 350);
            this.LevelDistributionBTN.Name = "LevelDistributionBTN";
            this.LevelDistributionBTN.Size = new System.Drawing.Size(98, 43);
            this.LevelDistributionBTN.TabIndex = 31;
            this.LevelDistributionBTN.Text = "Level Distribution";
            this.LevelDistributionBTN.UseVisualStyleBackColor = true;
            // 
            // InquiryUIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 423);
            this.Controls.Add(this.LevelDistributionBTN);
            this.Controls.Add(this.FLevelBTN);
            this.Controls.Add(this.DLevelBTN);
            this.Controls.Add(this.CLevelBTN);
            this.Controls.Add(this.BLevelBTN);
            this.Controls.Add(this.ALevelBTN);
            this.Controls.Add(this.ChooseShowModeGroupBox);
            this.Controls.Add(this.PassScoreBTN);
            this.Controls.Add(this.JustPassScoreBTN);
            this.Controls.Add(this.OpenFileBTN);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.displayTextBox);
            this.Controls.Add(this.ExitBTN);
            this.Controls.Add(this.DoneBTN);
            this.Controls.Add(this.GraphBTN);
            this.Controls.Add(this.DescendingOrderBTN);
            this.Controls.Add(this.AscendingOrderBTN);
            this.Controls.Add(this.FailScoreBTN);
            this.Name = "InquiryUIForm";
            this.Text = "InquiryForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ChooseShowModeGroupBox.ResumeLayout(false);
            this.ChooseShowModeGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView;
        public System.Windows.Forms.TextBox displayTextBox;
        public System.Windows.Forms.Button ExitBTN;
        public System.Windows.Forms.Button DoneBTN;
        public System.Windows.Forms.Button GraphBTN;
        public System.Windows.Forms.Button DescendingOrderBTN;
        public System.Windows.Forms.Button AscendingOrderBTN;
        public System.Windows.Forms.Button FailScoreBTN;
        public System.Windows.Forms.Button JustPassScoreBTN;
        public System.Windows.Forms.Button PassScoreBTN;
        public System.Windows.Forms.Button OpenFileBTN;
        public System.Windows.Forms.GroupBox ChooseShowModeGroupBox;
        public System.Windows.Forms.RadioButton NormalGradeRadioBTN;
        public System.Windows.Forms.RadioButton FinalTermRadioBTN;
        public System.Windows.Forms.RadioButton MidTermRadioBTN;
        public System.Windows.Forms.RadioButton ShowAllScoreRadioBTN;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MidTerm;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinalTerm;
        private System.Windows.Forms.DataGridViewTextBoxColumn NormalGrade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Average;
        public System.Windows.Forms.Button ALevelBTN;
        public System.Windows.Forms.Button BLevelBTN;
        public System.Windows.Forms.Button CLevelBTN;
        public System.Windows.Forms.Button DLevelBTN;
        public System.Windows.Forms.Button FLevelBTN;
        public System.Windows.Forms.Button LevelDistributionBTN;
    }
}

