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
using System.IO;
using BankUIForm_20150507;
using Library;

namespace BankUIForm_20150507
{
    public partial class ReadSequentialAccessFile : BankUIForm
    {
        // 宣告 & 呼叫

        BinaryFormatter reader = new BinaryFormatter();
        OpenFileReader_OR_Writer ToFile = new OpenFileReader_OR_Writer();
        Record ToRecord = new Record();
        StreamReader fileReader;
        int checkFile = -1, TEXT_FILE = 0, BINARY_FILE = 1;
        string filename;

        // Initailize
        public ReadSequentialAccessFile()
        {
            InitializeComponent();
        }

        // 開檔 Button
        private void OpenBTN_Click(object sender, EventArgs e)
        {
            // 開檔

            filename = ToFile.ChooseOpenFile(openFileDialog, "");
            fileReader = ToFile.ReadFile(filename);


            // 顯示

            if (ToFile.check)
            {
                checkFile = checkFileIsTextOrBinary(fileReader.ReadLine(), ToFile);
                fileReader = ToFile.ReadFile(filename);

                if (checkFile != -1)
                {
                    NextBTN.Text = "Start";
                    OpenBTN.Enabled = false;
                    NextBTN.Enabled = true;
                }

            }
        } // OpenBTN END

        // Next Button
        private void NextBTN_Click(object sender, EventArgs e)
        {
            NextBTN.Text = "Next";
            
            // TEXT 讀檔
            if (checkFile == TEXT_FILE) 
            {
                try
                {
                    string inputRecord = fileReader.ReadLine();
                    string[] inputFields;

                    if (inputRecord != null)
                    {
                        inputFields = inputRecord.Split(',');

                        Record ToRecord = new Record
                            (
                            int.Parse(inputFields[(int)TextBoxIndices.ACOCOUNT]),
                            inputFields[(int)TextBoxIndices.FIRST],
                            inputFields[(int)TextBoxIndices.LAST],
                            decimal.Parse(inputFields[(int)TextBoxIndices.BALANCE])
                            );

                        SetTextBoxValues(inputFields);
                    }
                    else
                    {

                        fileReader.Close();
                        OpenBTN.Enabled = true;
                        NextBTN.Enabled = false;
                        ClearTextBoxes();

                        MessageBox.Show("No more records in file", string.Empty,
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                    } // end if_else

                }
                catch (IOException)
                {

                    MessageBox.Show("Error Reading from File", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                }// end try_catch
            } // end if (Text_BTN.Checked)


            // binary 讀檔 //

            if (checkFile == BINARY_FILE)
            {
                try
                {
                    Record ToRecord = (Record)reader.Deserialize(ToFile.input);

                    string[] values = new string[]
                        {
                            ToRecord.Account.ToString(),
                            ToRecord.FirstName.ToString(),
                            ToRecord.LastName.ToString(),
                            ToRecord.Balance.ToString()
                        };

                    SetTextBoxValues(values);
                }
                catch (SerializationException)
                {
                    ToFile.input.Close();
                    OpenBTN.Enabled = true;
                    NextBTN.Enabled = false;

                    ClearTextBoxes();

                    MessageBox.Show("No more record in file", string.Empty,
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                } // end try_catch
            } // end  if (BinaryRadioBTN.Checked)
        } // end NextBTN_Click

        // 離開
        private void ExitBTN_Click(object sender, EventArgs e)
        {
            // 偵錯

            if (fileReader != null)
            {
                // 關檔
                try
                { 
                    fileReader.Close();
                }
                catch (IOException)
                {
                    MessageBox.Show("Cannot close file", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            this.Close();
        }

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
                    Record tmpRecord = (Record)reader.Deserialize(file.input);
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
    }
}


