using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public class Function
    {
        public double LowestValue, HighestValue;
        public int LowestCountForArray = 0, HighestCountForArray = 0;
        public int A_level = 0, B_level = 0, C_level = 0, D_level = 0, F_level = 0, Level;

        public int CheckInt(int a, int b)
        {
            if (a < b)
                return -1;
            else if (a > b)
                return 1;
            else
                return 0;
        }//end checkint

        public double CheckDouble(double a, double b)
        {
            if (a < b)
                return -1;
            else if (a > b)
                return 1;
            else
                return 0;
        }//end checkdouble

        public decimal CheckDecimal(decimal a, decimal b)
        {
            if (a < b)
                return -1;
            else if (a > b)
                return 1;
            else
                return 0;
        }//end checkdecimal

        public double GetMinimum(double[] Amounts)
        {
            LowestValue = Amounts[0];

            for (int count = 0; count < Amounts.Length; count++)
            {
                if (Amounts[count] < LowestValue)
                {
                    LowestValue = Amounts[count];
                   LowestCountForArray = count;
                }
            }

            return LowestValue;
        } // end 計算最小值

        public double GetMaximum(double[] Amoumts)
        {
            HighestValue = Amoumts[0];

            for (int count = 0; count < Amoumts.Length; count++)
            {
                if (Amoumts[count] > HighestValue)
                {
                    HighestValue = Amoumts[count];
                    HighestCountForArray = count;
                }
            }
            return HighestValue;
        } // end 計算最大值

        public double GetAverage(double[] Amounts)
        {
            double total = 0;

            foreach (double grade in Amounts)
                total += grade;

            return (double)total / Amounts.Length;
        }// end 計算平均

        public void Switch(double[] Amounts)
        {
            foreach (int grade in Amounts)
            {
                switch (grade / 10)
                {
                    case 10:
                    case 9:
                        ++A_level;
                        break;
                    case 8:
                        ++B_level;
                        break;
                    case 7:
                        ++C_level;
                        break;
                    case 6:
                        ++D_level;
                        break;
                    default:
                        ++F_level;
                        break;
                }
            }
        } // END Switch

        public int GetA_Level()
        {
            return A_level;
        }

        public int GetB_Level()
        {
            return B_level;
        }

        public int GetC_Level()
        {
            return C_level;
        }

        public int GetD_Level()
        {
            return D_level;
        }

        public int GetF_Level()
        {
            return F_level;
        }

        public double GetMinimum_DoubleForList(List<double> AmountsList)
        {
            LowestValue = AmountsList[0];

            for (int count = 0; count < AmountsList.Count; count++)
            {
                if (AmountsList[count] < LowestValue)
                {
                    LowestValue = AmountsList[count];
                    LowestCountForArray = count;
                }
            }

            return LowestValue;
        } // end 計算最小值

        public double GetMaximum_DoubleForList(List<double> AmountsList)
        {
            HighestValue = AmountsList[0];

            for (int count = 0; count < AmountsList.Count; count++)
            {
                if (AmountsList[count] > HighestValue)
                {
                    HighestValue = AmountsList[count];
                    HighestCountForArray = count;
                }
            }
            return HighestValue;
        } // end 計算最大值

        public double GetAverage_DoubleForList(List<double> AmountsList)
        {
            double total = 0;

            foreach (double grade in AmountsList)
                total += grade;

            return (double)total / AmountsList.Count;
        }// end 計算平均

        public int AboveAverage_ForList(List<double> AmountsList,double average)
        {
            int numAbove = 0;

            foreach(double Amount in AmountsList)
            {
                if (Amount > average)
                    ++numAbove;
            }

            return numAbove;
        } // end AboveAverage_ForList

        public int BelowAverage_ForList(List<double> AmountsList,double average)
        {
            int numBelow = 0;

            foreach (double Amount in AmountsList)
            {
                if (Amount < average)
                    ++numBelow;
            }

            return numBelow;
        } // end BelowAverage_ForList

 // =================================================================================================================== //

        // LINQ 切割 大於平均 ( Array )
        public IEnumerable<double> LINQ_DoubleArray_FilteredAboveAverage(double[] Amounts, double average)
        {
            var filtered =
                from amount in Amounts
                where amount > average
                select amount;

            return filtered;
        }

        // LINQ 切割 小於平均 ( Array )
        public IEnumerable<double> LINQ_DoubleArray_FilteredBelowAverage(double[] Amounts, double average)
        {
            var filtered =
                from amount in Amounts
                where amount < average
                select amount;

            return filtered;
        }

        // LINQ 排列 由小到大 ( Array )
        public IEnumerable<double> LINQ_DoubleArray_Sort_Ascending(double[] Amounts)
        {
            var sorted =
                from amount in Amounts
                orderby amount
                select amount;

            return sorted;
        }

        // LINQ 排列 由大到小 ( Array )
        public IEnumerable<double> LINQ_DoubleArray_Sort_Descending(double[] Amounts)
        {
            var sorted =
                from amount in Amounts
                orderby amount descending
                select amount;

            return sorted;
        }

// =================================================================================================================== //

        // LINQ 切割 大於平均 ( List )
        public IEnumerable<double> LINQ_DoubleList_FilteredAboveAverage(List<double> AmountsList, double average)
        {
            var filtered =
                from amount in AmountsList
                where amount > average
                select amount;

            return filtered;
        }

        // LINQ 切割 小於平均 ( List )
        public IEnumerable<double> LINQ_DoubleList_FilteredBelowAverage(List<double> AmountsList, double average)
        {
            var filtered =
                from amount in AmountsList
                where amount < average
                select amount;

            return filtered;
        }

        // LINQ 排列 由小到大 ( List )
        public IEnumerable<double> LINQ_DoubleList_Sort_Ascending(List<double> AmountsList)
        {
            var sorted =
                from amount in AmountsList
                orderby amount
                select amount;

            return sorted;
        }

        // LINQ 排列 由大到小 ( List )
        public IEnumerable<double> LINQ_DoubleList_Sort_Descending(List<double> AmountsList)
        {
            var sorted =
                from amount in AmountsList
                orderby amount descending
                select amount;

            return sorted;
        }

        public decimal GetMinimumInDecimal(decimal[] Amounts)
        {
            decimal LowestValue = Amounts[0];

            for (int count = 0; count < Amounts.Length; count++)
            {
                if (Amounts[count] < LowestValue)
                {
                    LowestValue = Amounts[count];
                    LowestCountForArray = count;
                }
            }

            return LowestValue;
        } // end 計算最小值

        public decimal GetMaximumInDecimal(decimal[] Amoumts)
        {
            decimal HighestValue = Amoumts[0];

            for (int count = 0; count < Amoumts.Length; count++)
            {
                if (Amoumts[count] > HighestValue)
                {
                    HighestValue = Amoumts[count];
                    HighestCountForArray = count;
                }
            }
            return HighestValue;
        } // end 計算最大值

    } // end Class Function
}
