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

// A103223013_MidTermExam_翁華威                 14/May/2015

namespace ReadFileForm_A103223013
{
    public partial class ReadFileForm : StudentUIForm
    {
        Check ToCheck = new Check();
        OpenFileRead_OR_Write ToFile = new OpenFileRead_OR_Write();
        StreamReader fileReader;
        BinaryFormatter reader = new BinaryFormatter();

        public ReadFileForm()
        {
            InitializeComponent();
            Next_BTN.Enabled = false;
        }

        private void OpenFile_BTN_Click(object sender, EventArgs e)
        {
            // 開檔

            string filename = ToFile.ChooseOpenFile(openFileDialog, "");
            fileReader = ToFile.ReadFile(filename);

            // 顯示
            
            if(ToFile.check)
            {
                OpenFile_BTN.Enabled = false;
                Next_BTN.Enabled = true;
                ChooseMethodGroupBox.Enabled = false;
            }
        } // end OpenFile_BTN_Click

        private void Next_BTN_Click(object sender, EventArgs e)
        {

            // Text 讀檔 //

            if (Text_BTN.Checked)
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
                            double.Parse(inputFields[(int)TextBoxIdices.NORMAL_GRADE])
                            );

                        SetTextBoxValues(inputFields);
                    }
                    else
                    {

                        fileReader.Close();
                        OpenFile_BTN.Enabled = true;
                        Next_BTN.Enabled = false;
                        ClearTextboxes();

                        MessageBox.Show("No more records in file", string.Empty,
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ChooseMethodGroupBox.Enabled = true;

                    } // end if_else

                }
                catch (IOException)
                {

                    MessageBox.Show("Error Reading from File", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                }// end try_catch
            } // end if (Text_BTN.Checked)


            // Binary 讀檔 //

            if (Binary_BTN.Checked)
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
                            ToRecord.NormalGrade.ToString()
                        };

                    SetTextBoxValues(values);
                }
                catch(SerializationException)
                {
                    ToFile.input.Close();
                    OpenFile_BTN.Enabled = true;
                    Next_BTN.Enabled = false;

                    ClearTextboxes();

                    MessageBox.Show("No more record in file", string.Empty,
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ChooseMethodGroupBox.Enabled = true;

                } // end try_catch
            } // end if (Binary_BTN.Checked)
        } // end Next_BTN_Click

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
    }
}
