using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labs.part_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void operandTB_Leave(object sender, EventArgs e)
        {
            string str = OperandTB.Text;
            if (str.StartsWith("https://virtual.ulstu.ru/")&str.LastIndexOf('i') == 9)
               
                eventBtn.Enabled = true;
            else eventBtn.Enabled = false;
        }

    }
}
