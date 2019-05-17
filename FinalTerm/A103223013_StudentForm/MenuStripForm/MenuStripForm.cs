using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentLibrary_A103223013;
using CreateFileForm_A103223013;
using ReadFileForm_A103223013;

// A103223013_FinalTermExam_翁華威                 25/June/2015

namespace MenuStripForm
{
    public partial class MenuStripForm : Form
    {
        // Initialize //
        public MenuStripForm()
        {
            InitializeComponent();
        }

        // CreateForm //
        private void createFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateFileForm Create = new CreateFileForm();
            Create.MdiParent = this;
            Create.Show();
        }

        // ReadFileForm //
        private void readFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReadFileForm Read = new ReadFileForm();
            Read.MdiParent = this;
            Read.Show();
        }

        // InquiryForm //
        private void inquiryFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InquiryForm.InquiryForm Inquiry = new InquiryForm.InquiryForm();
            Inquiry.MdiParent = this;
            Inquiry.Show();
        }

        // 離開 //
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

         //  排列方式  //

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        // END 排列方式  //
    }
}
