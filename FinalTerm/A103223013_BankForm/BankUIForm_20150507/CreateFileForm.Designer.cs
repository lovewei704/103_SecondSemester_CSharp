namespace BankUIForm_20150507
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
            this.SaveBTN = new System.Windows.Forms.Button();
            this.EnterBTN = new System.Windows.Forms.Button();
            this.ExitBTN = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.ChooseMethodGroupBox = new System.Windows.Forms.GroupBox();
            this.BinaryRadioBtn = new System.Windows.Forms.RadioButton();
            this.TextRadioBTN = new System.Windows.Forms.RadioButton();
            this.ChooseMethodGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SaveBTN
            // 
            this.SaveBTN.Location = new System.Drawing.Point(50, 198);
            this.SaveBTN.Name = "SaveBTN";
            this.SaveBTN.Size = new System.Drawing.Size(75, 23);
            this.SaveBTN.TabIndex = 8;
            this.SaveBTN.Text = "Save As";
            this.SaveBTN.UseVisualStyleBackColor = true;
            this.SaveBTN.Click += new System.EventHandler(this.SaveBTN_Click);
            // 
            // EnterBTN
            // 
            this.EnterBTN.Location = new System.Drawing.Point(140, 198);
            this.EnterBTN.Name = "EnterBTN";
            this.EnterBTN.Size = new System.Drawing.Size(75, 23);
            this.EnterBTN.TabIndex = 9;
            this.EnterBTN.Text = "Enter";
            this.EnterBTN.UseVisualStyleBackColor = true;
            this.EnterBTN.Click += new System.EventHandler(this.EnterBTN_Click);
            // 
            // ExitBTN
            // 
            this.ExitBTN.Location = new System.Drawing.Point(231, 198);
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
            // ChooseMethodGroupBox
            // 
            this.ChooseMethodGroupBox.Controls.Add(this.BinaryRadioBtn);
            this.ChooseMethodGroupBox.Controls.Add(this.TextRadioBTN);
            this.ChooseMethodGroupBox.Location = new System.Drawing.Point(231, 106);
            this.ChooseMethodGroupBox.Name = "ChooseMethodGroupBox";
            this.ChooseMethodGroupBox.Size = new System.Drawing.Size(111, 70);
            this.ChooseMethodGroupBox.TabIndex = 11;
            this.ChooseMethodGroupBox.TabStop = false;
            this.ChooseMethodGroupBox.Text = "ChooseMethod";
            // 
            // BinaryRadioBtn
            // 
            this.BinaryRadioBtn.AutoSize = true;
            this.BinaryRadioBtn.Location = new System.Drawing.Point(12, 41);
            this.BinaryRadioBtn.Name = "BinaryRadioBtn";
            this.BinaryRadioBtn.Size = new System.Drawing.Size(55, 16);
            this.BinaryRadioBtn.TabIndex = 1;
            this.BinaryRadioBtn.Text = "Binary";
            this.BinaryRadioBtn.UseVisualStyleBackColor = true;
            // 
            // TextRadioBTN
            // 
            this.TextRadioBTN.AutoSize = true;
            this.TextRadioBTN.Checked = true;
            this.TextRadioBTN.Location = new System.Drawing.Point(12, 19);
            this.TextRadioBTN.Name = "TextRadioBTN";
            this.TextRadioBTN.Size = new System.Drawing.Size(44, 16);
            this.TextRadioBTN.TabIndex = 0;
            this.TextRadioBTN.TabStop = true;
            this.TextRadioBTN.Text = "Text";
            this.TextRadioBTN.UseVisualStyleBackColor = true;
            // 
            // CreateFileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 269);
            this.Controls.Add(this.ChooseMethodGroupBox);
            this.Controls.Add(this.ExitBTN);
            this.Controls.Add(this.EnterBTN);
            this.Controls.Add(this.SaveBTN);
            this.Name = "CreateFileForm";
            this.Text = "CreateFileForm";
            this.Controls.SetChildIndex(this.SaveBTN, 0);
            this.Controls.SetChildIndex(this.EnterBTN, 0);
            this.Controls.SetChildIndex(this.ExitBTN, 0);
            this.Controls.SetChildIndex(this.ChooseMethodGroupBox, 0);
            this.ChooseMethodGroupBox.ResumeLayout(false);
            this.ChooseMethodGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveBTN;
        private System.Windows.Forms.Button EnterBTN;
        private System.Windows.Forms.Button ExitBTN;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.GroupBox ChooseMethodGroupBox;
        private System.Windows.Forms.RadioButton BinaryRadioBtn;
        private System.Windows.Forms.RadioButton TextRadioBTN;
    }
}