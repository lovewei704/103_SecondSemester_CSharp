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

namespace InquiryForm
{
    public struct Menu_Option
    {
        public enum btn_enums
        {
            OpenFile,
            PassScore,
            JustPassScore,
            FailScore,
            AscendingOrder,
            DescendingOrder,
            Graph,
            ALevel,
            BLevel,
            CLevel,
            DLevel,
            FLevel,
            LevelDistribution,
            Done,
            Exit
        }

        static List<string> strings = new List<string>()
         {
            "Open File",
            "Pass Score",
            "Just Pass Score",
            "Fail Score",
            "Ascending Order",
            "Descending Order",
            "Graph",
            "A  Level",
            "B  Level",
            "C  Level",
            "D  Level",
            "F  Level",
            "Level Distribution",
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
            Menu_Option.btn_enums.PassScore,
            Menu_Option.btn_enums.JustPassScore,
            Menu_Option.btn_enums.FailScore,
            Menu_Option.btn_enums.AscendingOrder,
            Menu_Option.btn_enums.DescendingOrder,
            Menu_Option.btn_enums.Graph,
            Menu_Option.btn_enums.ALevel,
            Menu_Option.btn_enums.BLevel,
            Menu_Option.btn_enums.CLevel,
            Menu_Option.btn_enums.DLevel,
            Menu_Option.btn_enums.FLevel,
            Menu_Option.btn_enums.LevelDistribution,
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
                PassScoreBTN,
                JustPassScoreBTN,
                FailScoreBTN,
                AscendingOrderBTN,
                DescendingOrderBTN,
                GraphBTN,
                ALevelBTN,
                BLevelBTN,
                CLevelBTN,
                DLevelBTN,
                FLevelBTN,
                LevelDistributionBTN,
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
