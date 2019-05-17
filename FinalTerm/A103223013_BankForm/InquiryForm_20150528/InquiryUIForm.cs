using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InquiryForm_20150528
{
    public struct Menu_Option
    {
        public enum btn_enums
        {
            OpenFile,
            CreditBalance,
            DebitBalance,
            ZeroBalance,
            Max,
            Min,
            LevelDistribution,
            Graph,
            Done,
            Exit
        }

        static List<string> strings = new List<string>()
         {
            "Open File",
            "Credit Balance",
            "Debit Balance",
            "Zero Balance",
            "Max",
            "Min",
            "Level Distribution",
            "Graph",
            "Done",
            "Exit"
         };

        public string GetString(Menu_Option.btn_enums value) { return strings[(int)value]; }
    }

    public partial class InquiryUIForm : Form
    {
        public InquiryUIForm()
        {
            InitializeComponent();
            installButtonByEnum();
        }

        public Menu_Option.btn_enums[] menus = 
        {
            Menu_Option.btn_enums.OpenFile,
            Menu_Option.btn_enums.CreditBalance,
            Menu_Option.btn_enums.DebitBalance,
            Menu_Option.btn_enums.ZeroBalance,
            Menu_Option.btn_enums.Max,
            Menu_Option.btn_enums.Min,
            Menu_Option.btn_enums.LevelDistribution,
            Menu_Option.btn_enums.Graph,
            Menu_Option.btn_enums.Done,
            Menu_Option.btn_enums.Exit
        };

        // Change Button's Text From menus(ENUM) //
        public Button[] installButtonByEnum()
        {
            Menu_Option gradeEnum;

            Button[] optionBtns = 
            {
                OpenFileBTN,
                CreditBalanceBTN,
                DebitBalanceBTN,
                ZeroBalanceBTN,
                MaxBTN,
                MinBTN,
                LevelDistBTN,
                GraphBTN,
                DoneBTN,
                ExitBTN
            };

            for (int ButtonIndex = 0; ButtonIndex < optionBtns.Length; ButtonIndex++)
            {
                optionBtns[ButtonIndex].Text = gradeEnum.GetString(menus[ButtonIndex]);
            }

            SettingButtons(optionBtns);
            return optionBtns;
        }

        // Enabled Buttons //
        public void SettingButtons(Button[] optionButtons)
        {
            for (int ButtonIndex = 1; ButtonIndex < optionButtons.Length - 1; ButtonIndex++)
            {
                optionButtons[ButtonIndex].Enabled = false;
            }
        }
    }
}
