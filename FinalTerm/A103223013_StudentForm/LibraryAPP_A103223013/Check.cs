using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// A103223013_FinalTermExam_翁華威                 25/June/2015

namespace LibraryAPP_A103223013
{
    public class Check
    {
        // 宣告 

        Function ToFunction = new Function();
        public double input_double;
        public int input_int;

        // checkFile
        public bool checkFile(string filename)
        {
            bool check = false;
            if(filename ==string.Empty)
            { 
                MessageBox.Show("沒有檔名");
            }
            else
            {
                check = true;
            }

            return check;
        } // end checkFile

        // checkint_OneSide
        public bool checkint_OneSide(string input,string key,int value, int flagvalue)
        {
            bool check = false;
            try
            {
                input_int = int.Parse(input);
                if (ToFunction.CheckInt(input_int, value) == flagvalue) check = true;
                else
                {
                    MessageBox.Show(key + "\t輸入錯誤，請重新輸入！");
                    if (flagvalue == 1) MessageBox.Show(key + " 要大於 " + value);
                    if (flagvalue == -1) MessageBox.Show(key + " 要小於 " + value);
                    if (flagvalue == 0) MessageBox.Show(key + " 要等於 " + value);
                }
            }
            catch
            {
                MessageBox.Show(key + "\t輸入錯誤，請重新輸入！");
            }

            return check;
        } // end checkint_OneSide

        // checkdouble_ForMinMax
        public bool checkdouble_ForMinMax(string input,string key,double min,double max)
        {
            bool check = false;
            try
            {
                input_double = double.Parse(input);
                if (input_double <= max && input_double >= min) check = true;
                else
                {
                    MessageBox.Show(key + "\t輸入錯誤，請重新輸入！");
                    MessageBox.Show(key + "要介於 [" + min + "] 到 [" + max + "] 之間");
                }
            }
            catch
            {
                MessageBox.Show(key + "\t輸入錯誤，請重新輸入！");
            }

            return check;
        } // end double (min/max)

        // checkstring
        public bool checkstring(string input,string key)
        {
            bool check = false;
            if (input != string.Empty) check = true;
            else
            {
                MessageBox.Show(key + "\t不能是空的，輸入錯誤，請重新輸入！");
            }

            return check;
        } // end checkstring
        
    }
}
