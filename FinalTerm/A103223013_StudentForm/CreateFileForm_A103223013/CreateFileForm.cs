﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using LibraryAPP_A103223013;
using System.IO;
using StudentLibrary_A103223013;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

// A103223013_FinalTermExam_翁華威                 25/June/2015

namespace CreateFileForm_A103223013
{
    public partial class CreateFileForm : StudentUIForm
    {
         //  宣告 & 呼叫 //
        OpenFileRead_OR_Write ToFile = new OpenFileRead_OR_Write();
        BinaryFormatter formatter = new BinaryFormatter();
        StudentRecord ToRecord = new StudentRecord();
        Check ToCheck = new Check();

        double MidRatio, FinalRatio, NormalRatio;
        bool RatioCheck = false;

        //  Initialize  //
        public CreateFileForm()
        {
            InitializeComponent();
            Enter_BTN.Enabled = false;
        }

        // 存檔 Button
        private void Save_BTN_Click(object sender, EventArgs e)
        {
            // 開檔
            string filename = ToFile.ChooseSaveFile(saveFileDialog, "");
            ToFile.CreateFile(filename);

            // 顯示
            if(ToFile.check)
            {
                Save_BTN.Enabled = false;
                Enter_BTN.Enabled = true;
            }

        } // end Save_BTN_Click

        // Enter Button
        private void Enter_BTN_Click(object sender, EventArgs e)
        {
            // 宣告

            string[] values = GetTextBoxValues();
            bool checkid, checkfirst, checklast, checkmid, checkfinal, checknormal;

            // 偵錯 + 輸入

            // 偵錯ID
            checkid = ToCheck.checkint_OneSide(StudentID_TB.Text, "Student ID", 0, 1);
            if (checkid) ToRecord.StudentID = int.Parse(values[(int)TextBoxIdices.STUDENT_ID]);
            else StudentID_TB.Text = "";

            // 偵錯First Name
            checkfirst = ToCheck.checkstring(FirstName_TB.Text, "First Name");
            if (checkfirst) ToRecord.FirstName = values[(int)TextBoxIdices.FIRST_NAME];
            else FirstName_TB.Text = "";

            // 偵錯 Last Name
            checklast = ToCheck.checkstring(LastName_TB.Text, "Last Name");
            if (checklast) ToRecord.LastName = values[(int)TextBoxIdices.LAST_NAME];
            else LastName_TB.Text = "";

            // 偵錯 MidTerm
            checkmid = ToCheck.checkdouble_ForMinMax(MidTerm_TB.Text, "Mid-Term", 0, 100);
            if (checkmid) ToRecord.MidTerm = double.Parse(values[(int)TextBoxIdices.MID_TERM]);
            else MidTerm_TB.Text = "";
            
            // 偵錯 FinalTerm
            checkfinal = ToCheck.checkdouble_ForMinMax(FinalTerm_TB.Text, "Final-Term", 0, 100);
            if (checkfinal) ToRecord.FinalTerm = double.Parse(values[(int)TextBoxIdices.FINAL_TERM]);
            else FinalTerm_TB.Text = "";

            //偵錯 Normal Grade
            checknormal = ToCheck.checkdouble_ForMinMax(NormalGrade_TB.Text, "Normal-Grade", 0, 100);
            if (checknormal) ToRecord.NormalGrade = double.Parse(values[(int)TextBoxIdices.NORMAL_GRADE]);
            else NormalGrade_TB.Text = "";

            // if 全部都對
            if (checkid && checkfirst && checklast && checkmid && checkfinal && checknormal && RatioCheck)
            {
                ToRecord.Average = double.Parse(Average_TB.Text);

                // TXT
                if (TextRadioBTN.Checked)
                {
                    ToFile.FileWriter.WriteLine(ToRecord.StudentID + "," + ToRecord.FirstName
                        + "," + ToRecord.LastName + "," + ToRecord.MidTerm + "," + ToRecord.FinalTerm + "," + ToRecord.NormalGrade + "," + ToRecord.Average);
                }

                // Binary
                if (BinaryRadioBTN.Checked)
                {
                    formatter.Serialize(ToFile.output, ToRecord);
                }

                ClearTextboxes();
                ChooseMethodgroupBox.Enabled = false;
                NormalGradeRatio_TB.Enabled = false;
                FinalTermRatio_TB.Enabled = false;
                MidTermRatio_TB.Enabled = false;
            }

        } // end Enter_BTN_Click

        // 離開 Button
        private void Exit_BTN_Click(object sender, EventArgs e)
        {
            if (ToFile.FileWriter != null)
            {
                try
                {
                    ToFile.FileWriter.Close();
                    MessageBox.Show("存檔成功");
                }
                catch(IOException)
                {
                    MessageBox.Show("Cannot close file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            this.Close();
        }// end Exit_BTN_Click

        // 輸入 Ratio 按鈕
        private void EnterRatioBTN_Click(object sender, EventArgs e)
        {
            // 偵錯 MidTermRatio
            bool checkMidRatio = ToCheck.checkdouble_ForMinMax(MidTermRatio_TB.Text, "Mid Ratio", 0, 1);
            if (checkMidRatio) MidRatio = double.Parse(MidTermRatio_TB.Text);
            else MidTermRatio_TB.Text = "";

            // 偵錯 FinalTermRatio
            bool checkFinalRatio = ToCheck.checkdouble_ForMinMax(FinalTermRatio_TB.Text, "Final Ratio", 0, 1);
            if (checkFinalRatio) FinalRatio = double.Parse(FinalTermRatio_TB.Text);
            else FinalTermRatio_TB.Text = "";
            
            // 偵錯 NormalGradeRatio
            bool checkNormalRatio = ToCheck.checkdouble_ForMinMax(NormalGradeRatio_TB.Text, "Normal Grade Ratio", 0, 1);
            if (checkNormalRatio) NormalRatio = double.Parse(NormalGradeRatio_TB.Text);
            else NormalGradeRatio_TB.Text = "";

            // if 沒有全對
            if (checkFinalRatio && checkMidRatio && checkNormalRatio)
            {
               // if 3者加起來不等於1
                if ((MidRatio + FinalRatio + NormalRatio) != 1)
                {
                    MessageBox.Show("三個比率加起來要等於 [1]，請重新輸入");
                    MidTermRatio_TB.Text = "";
                    FinalTermRatio_TB.Text = "";
                    NormalGradeRatio_TB.Text = "";
                }
                else
                {
                    NormalGradeRatio_TB.Enabled = false;
                    FinalTermRatio_TB.Enabled = false;
                    MidTermRatio_TB.Enabled = false;
                    EnterRatioBTN.Enabled = false;
                    RatioCheck = true;

                    Save_BTN.Enabled = true;
                    NormalGrade_TB.Enabled = true;
                    FinalTerm_TB.Enabled = true;
                    MidTerm_TB.Enabled = true;
                }
            }
        } // end EnterRatioBTN_Click

        // 成績TEXT 變動
        private void Score_TB_TextChanged(object sender, EventArgs e)
        {
            TextBox senderTextBox = (TextBox)sender;
            string Type = senderTextBox.Name;

            try
            {
                if (RatioCheck) Average_TB.Text = ((double.Parse(MidTerm_TB.Text) * MidRatio) + (double.Parse(FinalTerm_TB.Text) * FinalRatio) + (double.Parse(NormalGrade_TB.Text) * NormalRatio)).ToString();
            }
            catch { }
        } // END Score_TB_TextChanged
    }
}