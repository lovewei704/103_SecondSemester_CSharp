using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Class_form_11_13;
using System.Windows.Forms;

namespace Library
{
    public class OpenFileReader_OR_Writer
    {
        public FileStream input, output;
        public bool check = false;
        public bool FileWriter_ON = false;
        public bool FileReader_ON = false;
        public StreamWriter FileWriter;
        public StreamReader FileReader;

        // Construction //

        public OpenFileReader_OR_Writer() { }

        public OpenFileReader_OR_Writer(bool WriteOn, bool ReadOn)
        {
            FileReader_ON = ReadOn;
            FileWriter_ON = WriteOn;
        }

        // End Construction //

        public string ChooseOpenFile(OpenFileDialog FileChooser, string initialDir)
        {
            string filename = "";
            DialogResult result;

            using (FileChooser)
            {
                FileChooser.InitialDirectory = initialDir;
                FileChooser.CheckFileExists = false;
                result = FileChooser.ShowDialog();
                filename = FileChooser.FileName;
            }// end using

            if (result == DialogResult.OK)
            {
                if (filename == string.Empty)
                    MessageBox.Show("Invalid File Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            } // end if_else

            return filename;
        } // end ChooseOpenFile

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
            }// end using

            if (result == DialogResult.OK)
            {
                if (filename == string.Empty)
                    MessageBox.Show("Invalid File Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            } // end if_else

            return filename;
        } // end ChooseFile

        public void CreateFile (string fileName)
        {
            if (fileName == string.Empty)
            {
                MessageBox.Show("Invalid File Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                check = false;
            }
            else
            {
                try
                {
                    output = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);
                    FileWriter = new StreamWriter(output);
                    check = true;
                }
                catch (IOException)
                {
                    MessageBox.Show("Error opening file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Environment.Exit(0);
                }
            }
        } // end CreateFile

        public StreamReader ReadFile(string fileName)
        {
            if (fileName == string.Empty)
            {
                MessageBox.Show("Invalid File Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                check = false;
            }
            else
            {
                try
                {
                    input = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                    FileReader = new StreamReader(input);
                    check = true;
                }
                catch (IOException)
                {
                    MessageBox.Show("Invalid File Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } // end try_catch
            } // end if_else

            return FileReader;

        } // end ReadFile

        public void ReadStringsIntoArray(ref string[] stringArray,string filename)
        {
            int index = 0, i = 1;
            FileReader = File.OpenText(filename);

            while (!FileReader.EndOfStream)
            {
                i++;
                if (FileReader.ReadLine()==string.Empty) break;
            } // end while（確認陣列空間大小）

            stringArray = new string[i];

            FileReader.Close();
            FileReader = File.OpenText(filename);

            while (index < stringArray.Length && !FileReader.EndOfStream)
            {
                stringArray[index] = FileReader.ReadLine();
                index++;
            } // end while （陣列填值）

            FileReader.Close();

        } // end ReadStringsIntoArray

        public void ReadDoubleIntoArray(ref double[] doubleArray, string filename)
        {
            int index = 0, i = 0;
            FileReader = File.OpenText(filename);

            while (!FileReader.EndOfStream)
            {
                try
                {
                    i++;
                    if (FileReader.ReadLine() == string.Empty) break;
                }
                catch
                {
                    MessageBox.Show("有資料不符合條件，請重新檢查");
                    Environment.Exit(0);
                }
            } // end while（確認陣列空間大小）

            doubleArray = new double[i];

            FileReader.Close();
            FileReader = File.OpenText(filename);

            while (index < doubleArray.Length && !FileReader.EndOfStream)
            {
                doubleArray[index] = double.Parse(FileReader.ReadLine());
                index++;
            } // end while (陣列填值)

            FileReader.Close();

        } // end ReadDoubleIntoArray

        public void ReadDoubleIntoList(ref List<double> intList, string filename)
        {
            FileReader = File.OpenText(filename);

            try
            {
                while (!FileReader.EndOfStream)
                {
                    intList.Add(int.Parse(FileReader.ReadLine()));
                } // end while (List填值)
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                Environment.Exit(0);
            } // end try catch

            FileReader.Close();

        } // end ReadIntIntoList



    }
}
