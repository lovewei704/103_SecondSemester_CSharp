using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using LibraryAPP_A103223013;
using StudentLibrary_A103223013;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using ZedGraph;

// A103223013_FinalTermExam_翁華威                 25/June/2015

namespace InquiryForm
{
    public partial class InquiryForm : InquiryUIForm
    {
        // 宣告 & 呼叫 //
        Function ToFuction = new Function();
        OpenFileRead_OR_Write ToFile = new OpenFileRead_OR_Write();
        StudentRecord ToRecord = new StudentRecord();

        BinaryFormatter binaryReader = new BinaryFormatter();
        List<StudentRecord> RecordList = new List<StudentRecord>();
        StreamReader fileReader;
        Button[] optionBtns;

        string filename;
        string MidTermString = "", FinalTermString = "", NormalGradeString = "", LevelString = "";
        int checkFile = -1, TEXT_FILE = 0, BINARY_FILE = 1;
        int RadioSelect = AVERAGE;
        const int PASS = 0, JUSTPASS = 1, FAIL = 2;
        const int ALEVEL = 0, BLEVEL = 1, CLEVEL = 2, DLEVEL = 3, FLEVEL = 4;
        const int MIDTERM = 0, FINALTERM = 1, NORMALGRADE = 2, AVERAGE = 3;

        int[] ResultDistributions = new int[3];
        int[] LevelsDistribution = new int[5];
        string[] Titles = new string[3] { "Pass Score", "Just Pass Score", "Fail  Score" };
        string[] LevelTitles = new string[5] { "A Level", "B Level", "C Level", "D Level", "F Level" };

        public InquiryForm()        // Initialize
        {
            InitializeComponent();
            optionBtns = installButtonByEnum();
        } // InquiryForm END

        private void ExitBTN_Click(object sender, EventArgs e)      // 離開 Button
        {
            this.Close();
        } // ExitBTN END

        private void OpenFileBTN_Click(object sender, EventArgs e)      // 讀檔 Button //
        {
            filename = ToFile.ChooseOpenFile(openFileDialog, "");

            if (ToFile.check) // 如果成功開檔
            {
                fileReader = ToFile.ReadFile(filename);
                checkFile = checkFileIsTextOrBinary(fileReader.ReadLine(), ToFile);

                if (checkFile != -1)
                {
                    AddDataIntoList();  // 將資料放入LIST
                    Distribution(RecordList);  // 分配成績
                    LevelDistribution(RecordList); // 分配成績
                    displayTextBox.Text = string.Format("Level Distribution:\r\n\r\nMid-Term Scores:\r\n" + MidTermString 
                        + "\r\n\r\nFinal-Term Scores:\r\n" + FinalTermString + "\r\n\r\nNormal-Grade Scores:\r\n" + NormalGradeString);  // 顯示在表單上
                    ChangeColor();  // 改變顏色 

                    // 顯示 //
                    optionBtns[0].Visible = false;
                    ChooseShowModeGroupBox.Visible = true;
                    for (int ButtonIndex = 4; ButtonIndex < optionBtns.Length - 1; ButtonIndex++) optionBtns[ButtonIndex].Enabled = true;

                }
            }
            else
            {
                MessageBox.Show("Error Reading from File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } // OpenFileBTN END

        public int checkFileIsTextOrBinary(string strTmp, OpenFileRead_OR_Write file)       //檢查檔案為 Text 或是 Binary
        {
            int intTmp;
            double doubleTmp;

            try
            {
                string[] strTmpArray = strTmp.Split(',');

                // TEXT //
                if ((int.TryParse(strTmpArray[0], out intTmp) && intTmp > 0) && (strTmpArray[1] != string.Empty) && (strTmpArray[2] != string.Empty) && (double.TryParse(strTmpArray[3], out doubleTmp)) && (double.TryParse(strTmpArray[4], out doubleTmp)) && (double.TryParse(strTmpArray[5], out doubleTmp)))
                {
                    checkFile = TEXT_FILE;
                    ToFile.FileReader.Close();
                }

                // BINARY //
                else
                {
                    file.input.Seek(0, SeekOrigin.Begin);
                    StudentRecord tmpRecord = (StudentRecord)binaryReader.Deserialize(file.input);
                    file.input.Seek(0, SeekOrigin.Begin);
                    checkFile = BINARY_FILE;
                    ToFile.FileReader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return checkFile;
        } // checkFileIsTextOrBinary END

        public void AddDataIntoList()       // 把資料放入RecordList
        {
            dataGridView.Rows.Clear();
            fileReader = ToFile.ReadFile(filename);

            // 如果檔案為TEXT
            if (checkFile == TEXT_FILE) 
            {
                while (!fileReader.EndOfStream)
                {
                    string inputRecord = fileReader.ReadLine();
                    string[] inputFields;
                    inputFields = inputRecord.Split(',');

                    StudentRecord ToRecord = new StudentRecord
                        (
                        int.Parse(inputFields[(int)StudentUIForm.TextBoxIdices.STUDENT_ID]),
                        inputFields[(int)StudentUIForm.TextBoxIdices.FIRST_NAME],
                        inputFields[(int)StudentUIForm.TextBoxIdices.LAST_NAME],
                        double.Parse(inputFields[(int)StudentUIForm.TextBoxIdices.MID_TERM]),
                        double.Parse(inputFields[(int)StudentUIForm.TextBoxIdices.FINAL_TERM]),
                        double.Parse(inputFields[(int)StudentUIForm.TextBoxIdices.NORMAL_GRADE]),
                        double.Parse(inputFields[(int)StudentUIForm.TextBoxIdices.AVERAGE])
                        );

                    RecordList.Add(ToRecord);
                    dataGridView.Rows.Add(new object[] { inputFields[0], inputFields[1], inputFields[2], inputFields[3], inputFields[4], inputFields[5], inputFields[6] });
                }
            }

            // 如果檔案為BINARY
            if (checkFile == BINARY_FILE)
            {
                try
                {
                    while (binaryReader != null)
                    {
                        StudentRecord ToRecord = (StudentRecord)binaryReader.Deserialize(ToFile.input);

                        ToRecord = new StudentRecord
                            (
                            int.Parse(ToRecord.StudentID.ToString()),
                            ToRecord.FirstName.ToString(),
                            ToRecord.LastName.ToString(),
                            double.Parse(ToRecord.MidTerm.ToString()),
                            double.Parse(ToRecord.FinalTerm.ToString()),
                            double.Parse(ToRecord.NormalGrade.ToString()),
                            double.Parse(ToRecord.Average.ToString())
                            );

                        RecordList.Add(ToRecord);
                        dataGridView.Rows.Add(new object[] { ToRecord.StudentID, ToRecord.FirstName, ToRecord.LastName, ToRecord.MidTerm, ToRecord.FinalTerm, ToRecord.NormalGrade, ToRecord.Average });
                    }
                }
                catch (SerializationException) { ToFile.input.Close(); } // end try_catch
            }
        } // AddDataIntoList END

        private void getScores_Click(object sender, System.EventArgs e)     // 顯示 [Pass]、[Just Pass]、[Fail] 成績 Button
        {
            Button senderButton = (Button)sender;
            string accountType = senderButton.Text;
            dataGridView.Rows.Clear();

            foreach (var ele in RecordList)
            {
                switch (RadioSelect)
                {
                    case MIDTERM:
                        if (ScoreCheck(ele.MidTerm, accountType)) dataGridView.Rows.Add(new object[] { ele.StudentID, ele.FirstName, ele.LastName, ele.MidTerm, null, null, null });
                        break;
                    case FINALTERM:
                        if (ScoreCheck(ele.FinalTerm, accountType)) dataGridView.Rows.Add(new object[] { ele.StudentID, ele.FirstName, ele.LastName, null, ele.FinalTerm, null, null });
                        break;
                    case NORMALGRADE:
                        if (ScoreCheck(ele.NormalGrade, accountType)) dataGridView.Rows.Add(new object[] { ele.StudentID, ele.FirstName, ele.LastName, null, null, ele.NormalGrade, null });
                        break;

                } // end Switch
            }

            displayTextBox.Text = string.Format("Level Distribution:\r\n\r\nMid-Term Scores:\r\n" + MidTermString
                             + "\r\n\r\nFinal-Term Scores:\r\n" + FinalTermString + "\r\n\r\nNormal-Grade Scores:\r\n" + NormalGradeString);  // 顯示在表單上
            ChangeColor();            // 變更顏色

        } // getBalances(Pass、JustPass、Fail) BTN  END

        private bool ScoreCheck(double score, string accountType)       // 篩選資料 為 Pass 、 Fail  OR  Just Pass
        {
            if (score > 60) { if (accountType == "Pass Score") return true; } // 大於 60
            if (score < 60) { if (accountType == "Fail Score") return true; }  // 小於 60
            if (score == 60) { if (accountType == "Just Pass Score") return true; }  // 等於 60

            return false;
        } // ScoreCheck END

        private void getAscendingOrDescending_Click(object sender, System.EventArgs e)      // 由大到小 ＆ 由小到大 按鈕
        {
            Button senderButton = (Button)sender;
            string accountType = senderButton.Text;
            dataGridView.Rows.Clear();
            DisplayAllDataInRows(RecordList);

            // Switch  升降序 //
            switch (RadioSelect)
            {
                case MIDTERM:
                    if (accountType == "Ascending Order") { dataGridView.Sort(dataGridView.Columns[3], System.ComponentModel.ListSortDirection.Ascending); }
                    if (accountType == "Descending Order") { dataGridView.Sort(dataGridView.Columns[3], System.ComponentModel.ListSortDirection.Descending); }
                    break;
                case FINALTERM:
                    if (accountType == "Ascending Order") { dataGridView.Sort(dataGridView.Columns[4], System.ComponentModel.ListSortDirection.Ascending); }
                    if (accountType == "Descending Order") { dataGridView.Sort(dataGridView.Columns[4], System.ComponentModel.ListSortDirection.Descending); }
                    break;
                case NORMALGRADE:
                    if (accountType == "Ascending Order") { dataGridView.Sort(dataGridView.Columns[5], System.ComponentModel.ListSortDirection.Ascending); }
                    if (accountType == "Descending Order") { dataGridView.Sort(dataGridView.Columns[5], System.ComponentModel.ListSortDirection.Descending); }
                    break;
                case AVERAGE:
                    if (accountType == "Ascending Order") { dataGridView.Sort(dataGridView.Columns[6], System.ComponentModel.ListSortDirection.Ascending); }
                    if (accountType == "Descending Order") { dataGridView.Sort(dataGridView.Columns[6], System.ComponentModel.ListSortDirection.Descending); }
                    break;
            }

        } // getAscendingOrDescending BTN END

        public void Distribution(List<StudentRecord> recordList)        // 分配
        {
            //  MidTerm  Distribution //
            foreach (var ele in recordList)
            {
                if (ele.MidTerm > 60) ResultDistributions[PASS]++;  // >60
                if (ele.MidTerm == 60) ResultDistributions[JUSTPASS]++;   // =60
                if (ele.MidTerm < 60) ResultDistributions[FAIL]++;   // <60
            }
            MidTermString = "";
            for (int i = 0; i < Titles.Length; i++) MidTermString += string.Format(Titles[i] + "\t" + ResultDistributions[i] + "\r\n");
            ResultDistributions = new int[3];

            //  FinalTerm  Distribution //
            foreach (var ele in recordList)
            {
                if (ele.FinalTerm > 60) ResultDistributions[PASS]++;  // >60
                if (ele.FinalTerm == 60) ResultDistributions[JUSTPASS]++;   // =60
                if (ele.FinalTerm < 60) ResultDistributions[FAIL]++;   // <60
            }
            FinalTermString = "";
            for (int i = 0; i < Titles.Length; i++) FinalTermString += string.Format(Titles[i] + "\t" + ResultDistributions[i] + "\r\n");
            ResultDistributions = new int[3];

            //  NormalGrade  Distribution //
            foreach (var ele in recordList)
            {
                if (ele.MidTerm > 60) ResultDistributions[PASS]++;  // >60
                if (ele.MidTerm == 60) ResultDistributions[JUSTPASS]++;   // =60
                if (ele.MidTerm < 60) ResultDistributions[FAIL]++;   // <60
            }
            NormalGradeString = "";
            for (int i = 0; i < Titles.Length; i++) NormalGradeString += string.Format(Titles[i] + "\t" + ResultDistributions[i] + "\r\n");

        } // Distribution END

        public void DisplayAllDataInRows(List<StudentRecord> recordList)        // 顯示所有資料
        {
            dataGridView.Rows.Clear();

            foreach (var ele in recordList)
            {
                switch (RadioSelect)
                {
                    case MIDTERM:
                        dataGridView.Rows.Add(ele.StudentID, ele.FirstName, ele.LastName, ele.MidTerm, null, null, null);
                        break;
                    case FINALTERM:
                        dataGridView.Rows.Add(ele.StudentID, ele.FirstName, ele.LastName, null, ele.FinalTerm, null, null);
                        break;
                    case NORMALGRADE:
                        dataGridView.Rows.Add(ele.StudentID, ele.FirstName, ele.LastName, null, null, ele.NormalGrade, null);
                        break;
                    case AVERAGE:
                        dataGridView.Rows.Add(ele.StudentID, ele.FirstName, ele.LastName, ele.MidTerm, ele.FinalTerm, ele.NormalGrade, ele.Average);
                        break;
                }
            }

            ChangeColor();
        } // DisplayAllDataInRows END

        public void ChangeColor()       // 更改顏色
        {
            for (int index = 0; index < dataGridView.RowCount; index++)
            {
                switch (RadioSelect)
                {
                    case MIDTERM:
                        ColorSupport(index, 3, double.Parse(dataGridView.Rows[index].Cells[3].Value.ToString()));
                        break;
                    case FINALTERM:
                        ColorSupport(index, 4, double.Parse(dataGridView.Rows[index].Cells[4].Value.ToString()));
                        break;
                    case NORMALGRADE:
                        ColorSupport(index, 5, double.Parse(dataGridView.Rows[index].Cells[5].Value.ToString()));
                        break;
                    case AVERAGE:
                        ColorSupport(index, 3, double.Parse(dataGridView.Rows[index].Cells[3].Value.ToString()));
                        ColorSupport(index, 4, double.Parse(dataGridView.Rows[index].Cells[4].Value.ToString()));
                        ColorSupport(index, 5, double.Parse(dataGridView.Rows[index].Cells[5].Value.ToString()));
                        LevelColorSupport(index, 6, double.Parse(dataGridView.Rows[index].Cells[6].Value.ToString()));
                        break;
                }
            }
        } // ChangeColor END

        private void GraphBTN_Click(object sender, EventArgs e)     // 圖表
        {
            ZedGraphForm zedGraph;
            switch (RadioSelect)
            {
                case MIDTERM:
                    zedGraph = new ZedGraphForm(MidTermString,"Mid-Term");   
                    zedGraph.Show();
                    zedGraph = new ZedGraphForm(LevelString, "Level Distribution");
                    zedGraph.Show();
                    break;
                case FINALTERM:
                    zedGraph = new ZedGraphForm(FinalTermString,"Final-Term");
                    zedGraph.Show();
                    zedGraph = new ZedGraphForm(LevelString, "Level Distribution");
                    zedGraph.Show();
                    break;
                case NORMALGRADE:
                    zedGraph = new ZedGraphForm(NormalGradeString,"Normal-Grade");
                    zedGraph.Show();
                    zedGraph = new ZedGraphForm(LevelString, "Level Distribution");
                    zedGraph.Show();
                    break;
                case AVERAGE:
                    zedGraph = new ZedGraphForm(MidTermString,"Mid-Term");
                    zedGraph.Show();
                    zedGraph = new ZedGraphForm(FinalTermString,"Final-Term");
                    zedGraph.Show();
                    zedGraph = new ZedGraphForm(NormalGradeString,"Normal-Grade");
                    zedGraph.Show();
                    zedGraph = new ZedGraphForm(LevelString, "Level Distribution");
                    zedGraph.Show();
                    break;
            }
            
        } // GraphBTN END

        private void DoneBTN_Click(object sender, EventArgs e)      // 重置所有東西
        {
            dataGridView.Rows.Clear();
            RecordList.Clear();
            ResultDistributions = new int[3];
            LevelsDistribution = new int[5];
            displayTextBox.Text = "";
            LevelString = "";

            // 顯示/隱藏按鈕 (Enabled)
            optionBtns[0].Visible = true;
            ChooseShowModeGroupBox.Visible = false;
            for (int ButtonIndex = 1; ButtonIndex < optionBtns.Length - 1; ButtonIndex++) optionBtns[ButtonIndex].Enabled = false;

        } // DoneBTN END

        private void RadioButtons_CheckedChanged(object sender, EventArgs e)        // RadioButton 選擇
        {
            RadioButton senderButton = (RadioButton)sender;
            string accountType = senderButton.Text;
            for (int ButtonIndex = 1; ButtonIndex < optionBtns.Length - 2; ButtonIndex++) optionBtns[ButtonIndex].Enabled = true;
            displayTextBox.Text = string.Format("Level Distribution:\r\n\r\nMid-Term Scores:\r\n" + MidTermString + "\r\n\r\nFinal-Term Scores:\r\n" + FinalTermString + "\r\n\r\nNormal-Grade Scores:\r\n" + NormalGradeString);  // 顯示在表單上

            switch (accountType)
            {
                case "Mid-Term":
                    RadioSelect = MIDTERM;
                    for (int ButtonIndex = 7; ButtonIndex < 13; ButtonIndex++) optionBtns[ButtonIndex].Enabled = false;
                    break;
                case "Final-Term":
                    RadioSelect = FINALTERM;
                    for (int ButtonIndex = 7; ButtonIndex < 13; ButtonIndex++) optionBtns[ButtonIndex].Enabled = false;
                    break;
                case "Normal-Grade":
                    RadioSelect = NORMALGRADE;
                    for (int ButtonIndex = 7; ButtonIndex < 13; ButtonIndex++) optionBtns[ButtonIndex].Enabled = false;
                    break;
                case "Average":
                    RadioSelect = AVERAGE;
                    for (int ButtonIndex = 1; ButtonIndex < 4; ButtonIndex++) optionBtns[ButtonIndex].Enabled = false;
                    break;
            } 
            DisplayAllDataInRows(RecordList);

        } //  RadioButtons_CheckedChanged END

        private void ColorSupport(int RowIndex, int CellIndex, double amount) // Color 輔助工具
        {
            if (amount > 60) dataGridView.Rows[RowIndex].Cells[CellIndex].Style.BackColor = Color.Green;
            if (amount < 60) dataGridView.Rows[RowIndex].Cells[CellIndex].Style.BackColor = Color.Red;
            if (amount == 60) dataGridView.Rows[RowIndex].Cells[CellIndex].Style.BackColor = Color.Yellow;
        }

        private void LevelColorSupport(int RowIndex, int CellIndex, double amount) // Color 輔助工具
        {
            double Score = amount / 10;

            switch ((int)Score)
            {
                case 10:
                case 9:
                    dataGridView.Rows[RowIndex].Cells[CellIndex].Style.BackColor = Color.Green;
                    break;
                case 8:
                    dataGridView.Rows[RowIndex].Cells[CellIndex].Style.BackColor = Color.GreenYellow;
                    break;
                case 7:
                    dataGridView.Rows[RowIndex].Cells[CellIndex].Style.BackColor = Color.Lime;
                    break;
                case 6:
                    dataGridView.Rows[RowIndex].Cells[CellIndex].Style.BackColor = Color.Yellow;
                    break;
                default:
                    dataGridView.Rows[RowIndex].Cells[CellIndex].Style.BackColor = Color.Red;
                    break;
            }
        }

        private void LevelBTN_Click(object sender, EventArgs e) // level 按鈕
        {
            Button senderButton = (Button)sender;
            string accountType = senderButton.Text;
            dataGridView.Rows.Clear();

            foreach (var ele in RecordList)
            {
                if (LevelCheck(ele.Average, accountType)) dataGridView.Rows.Add(new object[] { ele.StudentID, ele.FirstName, ele.LastName, ele.MidTerm, ele.FinalTerm, ele.NormalGrade, ele.Average });
            }

            displayTextBox.Text = string.Format("Level Distribution:\r\n\r\n" + LevelString);
            ChangeColor();            // 變更顏色

        }

        private bool LevelCheck(double score, string accountType)       // 篩選資料 Level
        {
            double Score = score / 10;

            switch ((int)Score)
            {
                case 10:
                case 9:
                    if (accountType == "A  Level") return true;
                    break;
                case 8:
                    if (accountType == "B  Level") return true;
                    break;
                case 7:
                    if (accountType == "C  Level") return true;
                    break;
                case 6:
                    if (accountType == "D  Level") return true;
                    break;
                default:
                    if (accountType == "F  Level") return true;
                    break;
            }

            return false;
        } // LevelCheck END

        public void LevelDistribution(List<StudentRecord> recordList)        // 分配
        {
            foreach (var ele in recordList)
            {
                switch ((int)(ele.Average/10))
                {
                    case 10:
                    case 9:
                        ++LevelsDistribution[ALEVEL];
                        break;
                    case 8:
                        ++LevelsDistribution[BLEVEL];
                        break;
                    case 7:
                        ++LevelsDistribution[CLEVEL];
                        break;
                    case 6:
                        ++LevelsDistribution[DLEVEL];
                        break;
                    default:
                        ++LevelsDistribution[FLEVEL];
                        break;
                }
            }

            for (int i = 0; i < LevelTitles.Length; i++) LevelString += string.Format(LevelTitles[i] + "\t" + LevelsDistribution[i] + "\r\n");
        }

        private void LevelDistributionBTN_Click(object sender, EventArgs e)  // level distribution 按鈕
        {
            DisplayAllDataInRows(RecordList);
            displayTextBox.Text = string.Format("Level Distribution:\r\n\r\n" + LevelString);
        } // Distribution END
    }
}
