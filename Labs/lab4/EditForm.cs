using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labs.lab4
{
    public partial class EditForm : Form
    {
        public EditForm(Form form)
        {
            InitializeComponent();
            MdiParent = form;
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void trueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MdiParent.ShowIcon = true;
        }

        private void falseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MdiParent.ShowIcon = false;                                                   
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
