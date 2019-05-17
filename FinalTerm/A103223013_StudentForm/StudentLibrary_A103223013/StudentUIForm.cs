using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// A103223013_FinalTermExam_翁華威                 25/June/2015

namespace StudentLibrary_A103223013
{
    public partial class StudentUIForm : Form
    {
        protected int TextBoxCount = 7;

        public enum TextBoxIdices
        {
            STUDENT_ID,
            FIRST_NAME,
            LAST_NAME,
            MID_TERM,
            FINAL_TERM,
            NORMAL_GRADE,
            AVERAGE
        } // end enum TextBoxIdices

        public StudentUIForm()
        {
            InitializeComponent();
        }

        // 清除Textbox
        public void ClearTextboxes()
        {
            foreach(Control guiControl in Controls)
            {
                if (guiControl is TextBox)
                {
                    if (guiControl.Name != "MidTermRatio_TB" && guiControl.Name != "FinalTermRatio_TB" && guiControl.Name != "NormalGradeRatio_TB")
                    {
                        ((TextBox)guiControl).Clear();
                    }
                }
            }
        }// end ClearTextboxes

        // Set Values
        public void SetTextBoxValues(string[] values)
        {
            if(values.Length!=TextBoxCount)
            {
                throw (new ArgumentException("There must be " + TextBoxCount + " strings in the array"));
            }
            else
            {
                StudentID_TB.Text = values[(int)TextBoxIdices.STUDENT_ID];
                FirstName_TB.Text = values[(int)TextBoxIdices.FIRST_NAME];
                LastName_TB.Text = values[(int)TextBoxIdices.LAST_NAME];
                MidTerm_TB.Text = values[(int)TextBoxIdices.MID_TERM];
                FinalTerm_TB.Text = values[(int)TextBoxIdices.FINAL_TERM];
                NormalGrade_TB.Text = values[(int)TextBoxIdices.NORMAL_GRADE];
                Average_TB.Text = values[(int)TextBoxIdices.AVERAGE];
            }
        } // end SetTextBoxValues

        // Get Values
        public string[] GetTextBoxValues()
        {
            string[] values = new string[TextBoxCount];

            values[(int)TextBoxIdices.STUDENT_ID] = StudentID_TB.Text;
            values[(int)TextBoxIdices.FIRST_NAME] = FirstName_TB.Text;
            values[(int)TextBoxIdices.LAST_NAME] = LastName_TB.Text;
            values[(int)TextBoxIdices.MID_TERM] = MidTerm_TB.Text;
            values[(int)TextBoxIdices.FINAL_TERM] = FinalTerm_TB.Text;
            values[(int)TextBoxIdices.NORMAL_GRADE] = NormalGrade_TB.Text;
            values[(int)TextBoxIdices.AVERAGE] = Average_TB.Text;

            return values;
        } // end GetTextBoxValues
    }
}
