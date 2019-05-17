using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using LibraryAPP_A103223013;
using StudentLibrary_A103223013;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

// A103223013_FinalTermExam_翁華威                 25/June/2015

namespace ReadFileForm_A103223013
{
    public partial class ReadFileForm : StudentUIForm
    {
        // 宣告 & 呼叫 //
        Check ToCheck = new Check();
        OpenFileRead_OR_Write ToFile = new OpenFileRead_OR_Write();
        StreamReader fileReader;
        BinaryFormatter reader = new BinaryFormatter();
        int checkFile = -1, TEXT_FILE = 0, BINARY_FILE = 1;

        // Initialize //

        public ReadFileForm()
        {
            InitializeComponent();
            Next_BTN.Enabled = false;
        }

        // 開檔案 按鈕
        private void OpenFile_BTN_Click(object sender, EventArgs e)
        {
            // 開檔

            string filename = "";
            filename = ToFile.ChooseOpenFile(openFileDialog, "");
            fileReader = ToFile.ReadFile(filename);

            // 顯示

            if(ToFile.check)
            {
                checkFile = checkFileIsTextOrBinary(fileReader.ReadLine(), ToFile);
                fileReader = ToFile.ReadFile(filename);

                if (checkFile != -1)
                {
                    Next_BTN.Text = "Start";
                    OpenFile_BTN.Enabled = false;
                    Next_BTN.Enabled = true;
                }
            }
        } // end OpenFile_BTN_Click

        // Next 按鈕
        private void Next_BTN_Click(object sender, EventArgs e)
        {
            Next_BTN.Text = "Next";
            // Text 讀檔 //

            if (checkFile == TEXT_FILE)
            {
                try
                {
                    string inputRecord = fileReader.ReadLine();
                    string[] inputFields;

                    if (inputRecord != null)
                    {
                        inputFields = inputRecord.Split(',');

                        StudentRecord ToRecord = new StudentRecord
                            (
                            int.Parse(inputFields[(int)TextBoxIdices.STUDENT_ID]),
                            inputFields[(int)TextBoxIdices.FIRST_NAME],
                            inputFields[(int)TextBoxIdices.LAST_NAME],
                            double.Parse(inputFields[(int)TextBoxIdices.MID_TERM]),
                            double.Parse(inputFields[(int)TextBoxIdices.FINAL_TERM]),
                            double.Parse(inputFields[(int)TextBoxIdices.NORMAL_GRADE]),
                            double.Parse(inputFields[(int)TextBoxIdices.AVERAGE])
                            );

                        SetTextBoxValues(inputFields);
                    }
                    else
                    {
                        checkFile = -1;
                        fileReader.Close();
                        OpenFile_BTN.Enabled = true;
                        Next_BTN.Enabled = false;
                        ClearTextboxes();
                        ToFile.check = false;
                        fileReader = null;

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


            // Binary 讀檔 //

            if (checkFile == BINARY_FILE)
            {
                try
                {
                    StudentRecord ToRecord = (StudentRecord)reader.Deserialize(ToFile.input);

                    string[] values = new string[]
                        {
                            ToRecord.StudentID.ToString(),
                            ToRecord.FirstName.ToString(),
                            ToRecord.LastName.ToString(),
                            ToRecord.MidTerm.ToString(),
                            ToRecord.FinalTerm.ToString(),
                            ToRecord.NormalGrade.ToString(),
                            ToRecord.Average.ToString()
                        };

                    SetTextBoxValues(values);
                }
                catch(SerializationException)
                {
                    ToFile.input.Close();
                    OpenFile_BTN.Enabled = true;
                    Next_BTN.Enabled = false;
                    ToFile.check = false;
                    fileReader = null;

                    checkFile = -1;
                    ClearTextboxes();

                    MessageBox.Show("No more record in file", string.Empty,
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                } // end try_catch
            } // end if (Binary_BTN.Checked)
        } // end Next_BTN_Click

        // 離開 按鈕 //
        private void Exit_BTN_Click(object sender, EventArgs e)
        {
            if (fileReader != null)
            {
                try
                {
                    fileReader.Close();
                }
                catch(IOException)
                {
                    MessageBox.Show("Cannot close file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            this.Close();
        } // end Exit_BTN_Click

        //檢查檔案為 Text 或是 Binary
        public int checkFileIsTextOrBinary(string strTmp, OpenFileRead_OR_Write file)
        {
            int intTmp;
            double doubleTmp;

            try
            {
                string[] strTmpArray = strTmp.Split(',');

                // TEXT //
                if ((int.TryParse(strTmpArray[0], out intTmp) && intTmp > 0) && (strTmpArray[1] != string.Empty) && (strTmpArray[2] != string.Empty) && (double.TryParse(strTmpArray[3], out doubleTmp)) && (double.Parse(strTmpArray[4]) > 0) && double.Parse(strTmpArray[4]) > 0)
                {
                    checkFile = TEXT_FILE;
                    ToFile.FileReader.Close();
                }

                // BINARY //
                else
                {
                    file.input.Seek(0, SeekOrigin.Begin);
                    StudentRecord tmpRecord = (StudentRecord)reader.Deserialize(file.input);
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
