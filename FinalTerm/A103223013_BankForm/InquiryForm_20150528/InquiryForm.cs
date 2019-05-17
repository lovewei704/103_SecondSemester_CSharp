using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using BankUIForm_20150507;
using System.IO;
using Library;

namespace InquiryForm_20150528
{
    public partial class InquiryForm : InquiryUIForm
    {
        // 宣告 & 呼叫 //
        Function ToFuction = new Function();
        OpenFileReader_OR_Writer ToFile = new OpenFileReader_OR_Writer();
        Record ToRecord = new Record();

        BinaryFormatter binaryReader = new BinaryFormatter();
        List<Record> RecordList = new List<Record>();
        StreamReader fileReader;
        Button[] optionBtns;

        string filename;
        string showString = "";
        int checkFile = -1, TEXT_FILE = 0, BINARY_FILE = 1;
        const int CREDIT = 0, DEBIT = 1, ZERO = 2;

        int[] Distributions = new int[3];
        string[] Titles = new string[3] { "Credit Balance", "Debit Balance", "Zero Balance" };

        // Initialize //
        public InquiryForm()
        {
            InitializeComponent();
            optionBtns = installButtonByEnum();
        } // InquiryForm END

        // 離開 Button //
        private void ExitBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        } // ExitBTN END

        // 讀檔 Button //
        private void OpenFileBTN_Click(object sender, EventArgs e)
        {
            filename = ToFile.ChooseOpenFile(openFileDialog1, "");

            if (ToFile.check)
            {
                fileReader = ToFile.ReadFile(filename);
                checkFile = checkFileIsTextOrBinary(fileReader.ReadLine(), ToFile);

                if (checkFile != -1)
                {
                    AddDataIntoList();  // 將資料放入LIST
                    Distribution(RecordList);                // 分配       
                    ChangeColor();                           // 改變顏色


                    // 顯示按鍵 (Enabled)
                    optionBtns[0].Enabled = false;
                    for (int ButtonIndex = 1; ButtonIndex < optionBtns.Length - 1; ButtonIndex++)
                    {
                        optionBtns[ButtonIndex].Enabled = true;
                    }
                }
            }
            else
            {
                MessageBox.Show("Error Reading from File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        } // OpenFileBTN END

        //檢查檔案為 Text 或是 Binary
        public int checkFileIsTextOrBinary(string strTmp, OpenFileReader_OR_Writer file)
        {
            int intTmp;
            double doubleTmp;

            try
            {
                string[] strTmpArray = strTmp.Split(',');

                // TEXT //
                if ((int.TryParse(strTmpArray[0], out intTmp) && intTmp > 0) && (strTmpArray[1] != string.Empty) && (strTmpArray[2] != string.Empty) && (double.TryParse(strTmpArray[3], out doubleTmp)))
                {
                    checkFile = TEXT_FILE;
                    ToFile.FileReader.Close();
                }

                // BINARY //
                else
                {
                    file.input.Seek(0, SeekOrigin.Begin);
                    Record tmpRecord = (Record)binaryReader.Deserialize(file.input);
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

        // 把資料放入RecordList
        public void AddDataIntoList()
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

                    Record ToRecord = new Record
                        (
                        int.Parse(inputFields[(int)BankUIForm.TextBoxIndices.ACOCOUNT]),
                        inputFields[(int)BankUIForm.TextBoxIndices.FIRST],
                        inputFields[(int)BankUIForm.TextBoxIndices.LAST],
                        decimal.Parse(inputFields[(int)BankUIForm.TextBoxIndices.BALANCE])
                        );

                    RecordList.Add(ToRecord);

                    dataGridView.Rows.Add(new object[] { inputFields[0], inputFields[1], inputFields[2], inputFields[3] });
                }
            }

            // 如果檔案為BINARY
            if (checkFile == BINARY_FILE)
            {
                try
                {
                    while (binaryReader != null)
                    {
                        Record ToRecord = (Record)binaryReader.Deserialize(ToFile.input);

                        ToRecord = new Record
                            (
                            int.Parse(ToRecord.Account.ToString()),
                            ToRecord.FirstName.ToString(),
                            ToRecord.LastName.ToString(),
                            decimal.Parse(ToRecord.Balance.ToString())
                            );

                        dataGridView.Rows.Add(new object[] { ToRecord.Account, ToRecord.FirstName, ToRecord.LastName, ToRecord.Balance });
                        RecordList.Add(ToRecord);
                    }
                }
                catch (SerializationException)
                {
                    ToFile.input.Close();
                } // end try_catch
            }
        } // AddDataIntoList END

        // 顯示 [Credit]、[Debit]、[Zero] 餘額 Button
        private void getBalances_Click(object sender, System.EventArgs e)
        {
            Button senderButton = (Button)sender;
            string accountType = senderButton.Text;
            dataGridView.Rows.Clear();

            //ToFile.input.Seek(0, SeekOrigin.Begin);

            foreach (var ele in RecordList)
            {
                if (BalanceCheck(ele.Balance, accountType))
                {
                    dataGridView.Rows.Add(new object[] { ele.Account, ele.FirstName, ele.LastName, ele.Balance });
                }
            }
            // 變更顏色
            ChangeColor();
        } // getBalances(Credit、Debit、Zero) BTN  END

        // 篩選資料 為 Credit 、 Debit  OR  Zero
        private bool BalanceCheck(decimal balance, string accountType)
        {
            if (balance > 0M) { if (accountType == "Credit Balance") return true; } // 大於 0
            if (balance < 0M) { if (accountType == "Debit Balance") return true; }  // 小於 0
            if (balance == 0M) { if (accountType == "Zero Balance") return true; }  // 等於 0

            return false;
        } // BalanceCheck END

        // 由大到小 ＆ 由小到大 ＆ Level Distribution 按鈕
        private void getMinMaxOrDistribution_Click(object sender, System.EventArgs e)
        {
            Button senderButton = (Button)sender;
            string accountType = senderButton.Text;
            dataGridView.Rows.Clear();
            DisplayAllDataInRows(RecordList);

            if (accountType == "Max") { dataGridView.Sort(dataGridView.Columns[3], System.ComponentModel.ListSortDirection.Descending); } // 如果按 MAX 將資料作降序
            if (accountType == "Min") { dataGridView.Sort(dataGridView.Columns[3], System.ComponentModel.ListSortDirection.Ascending); }  // 如果按 MIN 將資料作升序
            if (accountType == "Level Distribution") { Distribution(RecordList); }                                                        // Level Distribution 按鈕
        } // getMinMaxOrDistribution BTN END

        // 分配
        public void Distribution(List<Record> recordList)
        {
            Distributions = new int[3];
            displayTextBox.Text = "Level Distributon : \r\n\r\n";

            foreach (var ele in recordList)
            {
                if (ele.Balance > 0) Distributions[CREDIT]++;  // >0
                if (ele.Balance < 0) Distributions[DEBIT]++;   // <0
                if (ele.Balance == 0) Distributions[ZERO]++;   // =0
            }

            showString = "";
            for (int i = 0; i < Titles.Length; i++) showString += string.Format(Titles[i] + "\t" + Distributions[i] + "\r\n");
            displayTextBox.Text += showString;
        } // Distribution END

        // 顯示所有資料
        public void DisplayAllDataInRows(List<Record> recordList)
        {
            foreach (var ele in recordList)
            {
                dataGridView.Rows.Add(ele.Account, ele.FirstName, ele.LastName, ele.Balance);
            }

            ChangeColor(); 
        } // DisplayAllDataInRows END

        // 更改顏色
        public void ChangeColor()
        {
            for (int index = 0; index < dataGridView.RowCount; index++)
            {
                int amount = int.Parse(dataGridView.Rows[index].Cells[3].Value.ToString());

                if (amount > 0) dataGridView.Rows[index].Cells[3].Style.BackColor = Color.Green;
                if (amount < 0) dataGridView.Rows[index].Cells[3].Style.BackColor = Color.Red;
                if (amount == 0) dataGridView.Rows[index].Cells[3].Style.BackColor = Color.Yellow;
            }
        } // ChangeColor END

        // Graph Button
        private void GraphBTN_Click(object sender, EventArgs e)
        {
            ZedGraphForm zedGraph = new ZedGraphForm(showString);
            zedGraph.Show();
        } // GraphBTN END

        // 重置所有東西
        private void DoneBTN_Click(object sender, EventArgs e)
        {
            dataGridView.Rows.Clear();
            RecordList.Clear();
            Distributions = new int[3];
            showString = "";
            displayTextBox.Text = "";

            // 顯示/隱藏按鈕 (Enabled)
            optionBtns[0].Enabled = true;
            for (int ButtonIndex = 1; ButtonIndex < optionBtns.Length - 1; ButtonIndex++)
            {
                optionBtns[ButtonIndex].Enabled = false;
            }

        } // DoneBTN END

    }
}