using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Library;
using System.IO;
using BankUIForm_20150507;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace BankUIForm_20150507
{
    public partial class CreateFileForm : BankUIForm
    {
        // 宣告

        OpenFileReader_OR_Writer ToFile = new OpenFileReader_OR_Writer();
        BinaryFormatter formatter = new BinaryFormatter();
        Record ToRecord = new Record();
        Check ToCheck = new Check(false, true);

        public CreateFileForm()
        {
            InitializeComponent();

            // 顯示
            EnterBTN.Enabled = false;
        }

        private void SaveBTN_Click(object sender, EventArgs e)
        {
            // 開檔

            string filename = ToFile.ChooseSaveFile(saveFileDialog, "");
            ToFile.CreateFile(filename);

            // 顯示

            if(ToFile.check)
            {
                SaveBTN.Enabled = false;
                EnterBTN.Enabled = true;
            }
        }

        // 輸入
        private void EnterBTN_Click(object sender, EventArgs e)
        {
            // 宣告

            string[] values = GetTextBoxValues();
            bool checkaccout = false, checkfirst = false, checklast = false, checkbalance = false;

            // 各別偵錯

            checkaccout = ToCheck.checkint_OneSide(AccountTB.Text, "Account", 0, 1);
            if (checkaccout) ToRecord.Account = int.Parse(values[(int)TextBoxIndices.ACOCOUNT]);
            else AccountTB.Text = "";

            checkfirst = ToCheck.checkstring(FirstNameTB.Text, "First Name");
            if (checkfirst) ToRecord.FirstName = values[(int)TextBoxIndices.FIRST];
            else FirstNameTB.Text = "";

            checklast = ToCheck.checkstring(LastNameTB.Text, "Last Name");
            if (checklast) ToRecord.LastName = values[(int)TextBoxIndices.LAST];
            else LastNameTB.Text = "";

            checkbalance = ToCheck.checkdecimal_OneSide(BalanceTB.Text, "Balance", -1844674407370955169, 1);
            if (checkbalance) ToRecord.Balance = decimal.Parse(values[(int)TextBoxIndices.BALANCE]);
            else BalanceTB.Text = "";

            // IF 全對

            if (checkaccout && checkfirst && checklast && checkbalance)
            {
                if(TextRadioBTN.Checked)
                {
                    ToFile.FileWriter.WriteLine(ToRecord.Account + "," + ToRecord.FirstName + "," + ToRecord.LastName + "," + ToRecord.Balance);
                }
                if (BinaryRadioBtn.Checked)
                {
                    formatter.Serialize(ToFile.output, ToRecord);
                }
                ClearTextBoxes();
                ChooseMethodGroupBox.Enabled = false;
            }
        }

        // 離開
        private void ExitBTN_Click(object sender, EventArgs e)
        {
            // 偵錯

            if(ToFile.FileWriter!=null)
            {
                // 關檔
                try
                {
                    ToFile.FileWriter.Close();
                }
                catch(IOException)
                {
                    MessageBox.Show("Cannot close file", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            this.Close();
        }
    }
}
