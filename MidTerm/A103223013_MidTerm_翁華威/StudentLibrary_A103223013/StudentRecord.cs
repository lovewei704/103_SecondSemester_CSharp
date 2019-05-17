using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// A103223013_MidTermExam_翁華威                 14/May/2015

namespace StudentLibrary_A103223013
{
    [Serializable]
    public class StudentRecord
    {
        public int StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double MidTerm { get; set; }
        public double FinalTerm { get; set; }
        public double NormalGrade { get; set; }

        public StudentRecord()
            : this(0,string.Empty,string.Empty,0,0,0)
        {
        } // end constructor

        public StudentRecord(int studentIDValue,string firstNameValue,string lastNameValue,double midTermValue,double finalTermValue,double normalGradeValue)
        {
            StudentID = studentIDValue;
            FirstName = firstNameValue;
            LastName = lastNameValue;
            MidTerm = midTermValue;
            FinalTerm = finalTermValue;
            NormalGrade = normalGradeValue;

        }// end constructor

    } // end class StudentRecord
}
