using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// A103223013_MidTermExam_翁華威                 14/May/2015

namespace LibraryAPP_A103223013
{
    public class Function
    {
        public int CheckInt(int a,int b)
        {
            if (a < b)
                return -1;
            else if (a > b)
                return 1;
            else
                return 0;

        }// end CheckInt

        public double CheckDouble(double a, double b)
        {
            if (a < b)
                return -1;
            else if (a > b)
                return 1;
            else
                return 0;

        } // end CheckDouble
    }
}
