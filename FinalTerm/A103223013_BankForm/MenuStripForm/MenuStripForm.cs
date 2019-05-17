using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankUIForm_20150507;
using InquiryForm_20150528;

namespace MenuStripForm
{
    public partial class MenuStripForm : Form
    {
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

        // ReadForm //
        private void readFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReadSequentialAccessFile Read = new ReadSequentialAccessFile();
            Read.MdiParent = this;
            Read.Show();
        }

        // InquiryForm //
        private void inquiryFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InquiryForm Inquiry = new InquiryForm();
            Inquiry.MdiParent = this;
            Inquiry.Show();
        }

        // Exit //
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // 排列 //

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

        // END 排列 //
    }
}
