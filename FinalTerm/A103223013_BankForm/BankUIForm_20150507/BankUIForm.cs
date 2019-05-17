using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankUIForm_20150507
{
    public partial class BankUIForm : Form
    {
        protected int TextBoxCount = 4;

        public enum TextBoxIndices
        {
            ACOCOUNT,
            FIRST,
            LAST,
            BALANCE
        }

        public BankUIForm()
        {
            InitializeComponent();
        }
        
        public void ClearTextBoxes()
        {
            foreach(Control guiControl in Controls)
            {
                if(guiControl is TextBox)
                {
                    ((TextBox)guiControl).Clear();
                }
            }
        }

        public void SetTextBoxValues(string[] values)
        {
            if(values.Length!=TextBoxCount)
            {
                throw (new ArgumentException("There must be" + TextBoxCount + "strings in the array"));
            }
            else
            {
                AccountTB.Text = values[(int)TextBoxIndices.ACOCOUNT];
                FirstNameTB.Text = values[(int)TextBoxIndices.FIRST];
                LastNameTB.Text = values[(int)TextBoxIndices.LAST];
                BalanceTB.Text = values[(int)TextBoxIndices.BALANCE];
            }
        }

        public string[] GetTextBoxValues()
        {
            string[] values = new string[TextBoxCount];

            values[(int)TextBoxIndices.ACOCOUNT] = AccountTB.Text;
            values[(int)TextBoxIndices.FIRST] = FirstNameTB.Text;
            values[(int)TextBoxIndices.LAST] = LastNameTB.Text;
            values[(int)TextBoxIndices.BALANCE] = BalanceTB.Text;

            return values;
        }
    }
}
