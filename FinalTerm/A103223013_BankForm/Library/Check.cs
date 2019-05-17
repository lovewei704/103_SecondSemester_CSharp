using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public class Check
    {
        // 全域變數 //

        Function ToFunction = new Function();
        public decimal input_decimal;
        public double input_double;
        public int input_int;

        public bool ConsoleMode_ON { get; set; }
        public bool WindowFormMode_ON { get; set; }


        //    建構子    //

        public Check() { }

        public Check(bool Console_ON, bool WindowForm_ON)
        {
            ConsoleMode_ON = Console_ON;
            WindowFormMode_ON = WindowForm_ON;
        }

        //  End  建構子 //


        public bool checkFile(string fileName)
        {
            bool check = false;
            if (fileName == string.Empty)
            {
                if(ConsoleMode_ON)Console.WriteLine("沒有檔名！");
                if (WindowFormMode_ON) MessageBox.Show("沒有檔名！");
            }
            else
            {
                check = true;
            }
            return check;

        }//end check file

        // flagvalue = -1,0,1  ---->  <,=,>  
        public bool checkint_OneSide(string input,string key,int value, int flagvalue)
        {
            bool check = false;
            try
            {
                input_int = int.Parse(input);
                if (ToFunction.CheckInt(input_int, value) == flagvalue) check = true;
                else
                {
                    if (WindowFormMode_ON)
                    {
                        MessageBox.Show(key + "\t輸入錯誤，請重新輸入！");
                        if (flagvalue == 1) MessageBox.Show(key + "\t要大於 " + value);
                        if (flagvalue == -1) MessageBox.Show(key + "\t要小於 " + value);
                        if (flagvalue == 0) MessageBox.Show(key + "\t要等於 " + value);
                    }
                    if (ConsoleMode_ON)
                    {
                        Console.WriteLine(key + "\t輸入錯誤，請重新輸入！");
                        if (flagvalue == 1) Console.WriteLine(key + "\t要大於 " + value);
                        if (flagvalue == -1) Console.WriteLine(key + "\t要小於 " + value);
                        if (flagvalue == 0) Console.WriteLine(key + "\t要等於 " + value);
                    }
                }
            }
            catch 
            {
                if(WindowFormMode_ON)MessageBox.Show(key + "\t輸入錯誤，請重新輸入！");
                if (ConsoleMode_ON) Console.WriteLine(key + "\t輸入錯誤，請重新輸入！");
            }

            return check;
        } // end check int

        public bool checkdecimal_OneSide(string input, string key, decimal value, decimal flagvalue)
        {
            bool check = false;

            try
            {
                input_decimal = decimal.Parse(input);
                if (ToFunction.CheckDecimal(input_decimal, value) == flagvalue) check = true;
                else
                {
                    if (WindowFormMode_ON)
                    {
                        MessageBox.Show(key + "\t輸入錯誤，請重新輸入！");
                        if (flagvalue == 1) MessageBox.Show(key + "\t要大於 " + value);
                        if (flagvalue == -1) MessageBox.Show(key + "\t要小於 " + value);
                        if (flagvalue == 0) MessageBox.Show(key + "\t要等於 " + value);
                    }
                    if (ConsoleMode_ON)
                    {
                        Console.WriteLine(key + "\t輸入錯誤，請重新輸入！");
                        if (flagvalue == 1) Console.WriteLine(key + "\t要大於 " + value);
                        if (flagvalue == -1) Console.WriteLine(key + "\t要小於 " + value);
                        if (flagvalue == 0) Console.WriteLine(key + "\t要等於 " + value);
                    }
                }
            }
            catch
            {
                if (WindowFormMode_ON) MessageBox.Show(key + "\t輸入錯誤，請重新輸入！");
                if (ConsoleMode_ON) Console.WriteLine(key + "\t輸入錯誤，請重新輸入！");
            }
            return check;
        } // end check decimal

        public bool checkdouble_OneSide(string input, string key, double value, double flagvalue)
        {
            bool check = false;

            try
            {
                input_double = double.Parse(input);
                if (ToFunction.CheckDouble(input_double, value) == flagvalue) check = true;
                else
                {
                    if (WindowFormMode_ON)
                    {
                        MessageBox.Show(key + "\t輸入錯誤，請重新輸入！");
                        if (flagvalue == 1) MessageBox.Show(key + "\t要大於 " + value);
                        if (flagvalue == -1) MessageBox.Show(key + "\t要小於 " + value);
                        if (flagvalue == 0) MessageBox.Show(key + "\t要等於 " + value);
                    }
                    if (ConsoleMode_ON)
                    {
                        Console.WriteLine(key + "\t輸入錯誤，請重新輸入！");
                        if (flagvalue == 1) Console.WriteLine(key + "\t要大於 " + value);
                        if (flagvalue == -1) Console.WriteLine(key + "\t要小於 " + value);
                        if (flagvalue == 0) Console.WriteLine(key + "\t要等於 " + value);
                    }
                }
            }
            catch 
            {
                if (WindowFormMode_ON) MessageBox.Show(key + "\t輸入錯誤，請重新輸入！");
                if (ConsoleMode_ON) Console.WriteLine(key + "\t輸入錯誤，請重新輸入！");
            }
            return check;
        } // end check double

        public bool checkdouble_ForMinMax(string input, string key, double min, double max)
        {
            bool check = false;
            try
            {
                input_double = double.Parse(input);
                if (input_double <= max && input_double >= min) check = true;
                else
                {
                    if (WindowFormMode_ON)
                    {
                        MessageBox.Show(key + "\t輸入錯誤，請重新輸入！");
                        MessageBox.Show(key + " 要介於 [" + min + "] 到 [" + max + "] 之間");
                    }
                    if (ConsoleMode_ON)
                    {
                        Console.WriteLine(key + "\t輸入錯誤，請重新輸入！");
                        Console.WriteLine(key + " 要介於 [" + min + "] 到 [" + max + "] 之間");
                    }
                }
            }
            catch
            {
                if (WindowFormMode_ON) MessageBox.Show(key + "\t輸入錯誤，請重新輸入！");
                if (ConsoleMode_ON) Console.WriteLine(key + "\t輸入錯誤，請重新輸入！");
            }
            return check;
        }// end double (min/max)

        public bool checkint_ForMinMax(string input, string key, int min, int max)
        {
            bool check = false;
            try
            {
                input_int = int.Parse(input);
                if (input_int <= max && input_int >= min) check = true;
                else
                {
                    if (WindowFormMode_ON)
                    {
                        MessageBox.Show(key + "\t輸入錯誤，請重新輸入！");
                        MessageBox.Show(key + " 要介於 [" + min + "] 到 [" + max + "] 之間");
                    }
                    if (ConsoleMode_ON)
                    {
                        Console.WriteLine(key + "\t輸入錯誤，請重新輸入！");
                        Console.WriteLine(key + " 要介於 [" + min + "] 到 [" + max + "] 之間");
                    }
                }
            }
            catch 
            {
                if (WindowFormMode_ON) MessageBox.Show(key + "\t輸入錯誤，請重新輸入！");
                if (ConsoleMode_ON) Console.WriteLine(key + "\t輸入錯誤，請重新輸入！");
            }
            return check;
        }// end check int(min/max)

        public bool checkstring(string input, string key)
        {
            bool check = false;
            if (input != string.Empty) check = true;
            else
            {
                if (WindowFormMode_ON) MessageBox.Show(key + "不能是空的，輸入錯誤，請重新輸入！");
                if (ConsoleMode_ON) Console.WriteLine(key + "不能是空的，輸入錯誤，請重新輸入！");
            }
            return check;
        }// end check string

        public bool checkintForConsoleLoop(string input, string key)
        {
            bool check = false;

            return check;
        }

        public bool checkdoubleForConsoleLoop(string input, string key)
        {
            bool check = false;

            return check;
        }
    }
}
