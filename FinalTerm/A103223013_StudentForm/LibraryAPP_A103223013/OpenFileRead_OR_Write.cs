using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

// A103223013_FinalTermExam_翁華威                 25/June/2015

namespace LibraryAPP_A103223013
{
    public class OpenFileRead_OR_Write
    {
        // 宣告 //

        public FileStream input, output;
        public bool check = false;
        public StreamWriter FileWriter;
        public StreamReader FileReader;

        public string ChooseOpenFile(OpenFileDialog FileChooser,string initialDir)
        {
            check = false;
            string filename = "";
            FileChooser.FileName = "";
            DialogResult result;

            using (FileChooser)
            {
                FileChooser.InitialDirectory = initialDir;
                FileChooser.CheckFileExists = false;
                result = FileChooser.ShowDialog();
                filename = FileChooser.FileName;
            }//end using

            if(result == DialogResult.OK)
            {
                if (filename == string.Empty)
                {
                    MessageBox.Show("Invalid File Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    check = false;
                }
                else
                {
                    MessageBox.Show("Filename Select ==> " + filename);
                    check = true;
                }
            }
            else if(result == DialogResult.Cancel)
            {
                MessageBox.Show("Select result ==> Cancel");
                check = false;
            }// end if_else

            return filename;

        } // end string ChooseOpenFile

        public string ChooseSaveFile(SaveFileDialog FileChooser, string initialDir)
        {
            string filename = "";
            DialogResult result;

            using (FileChooser)
            {
                FileChooser.InitialDirectory = initialDir;
                FileChooser.CheckFileExists = false;
                result = FileChooser.ShowDialog();
                filename = FileChooser.FileName;
            }//end using

            if (result == DialogResult.OK)
            {
                if (filename == string.Empty)
                {
                    MessageBox.Show("Invalid File Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    check = false;
                }
                else
                {
                    MessageBox.Show("Filename Select ==> " + filename);
                    check = true;
                }
            }
            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show("Select result ==> Cancel");
                check = false;
            }// end if_else

            return filename;

        } // end string ChooseSaveFile

        public void CreateFile(string filename)
        {
            if(filename == string.Empty)
            {                   
                MessageBox.Show("Invalid File Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                check = false;
            }
            else
            {
                try
                {

                    output = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.Write);
                    FileWriter = new StreamWriter(output);
                    check = true;

                }
                catch(IOException)
                {

                    MessageBox.Show("Error opening file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    check = false;
                } // end try_catch
            } // end if_else
        } // end CreateFile

        public StreamReader ReadFile(string filename)
        {
            check = false;
            if (filename == string.Empty)
            {
                MessageBox.Show("Invalid File Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                check = false;
            }
            else
            {
                try
                {
                    input = new FileStream(filename, FileMode.Open, FileAccess.Read);
                    FileReader = new StreamReader(input);
                    check = true;

                }
                catch (IOException)
                {

                    MessageBox.Show("Error opening file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    check = false;

                } // end try_catch
            } // end if_else

            return FileReader;

        }// end ReadFile
    }
}
