using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sbyteTypeBtn_Click(object sender, EventArgs e)
        {
            sbyteTypeLabel.Text = sizeof(sbyte).ToString()  + "\n" + + sbyte.MinValue + "\n" + sbyte.MaxValue;
        }

        private void ulongTypeBtn_Click(object sender, EventArgs e)
        {
            ulongTypeLabel.Text = sizeof(ulong).ToString() + "\n" + ulong.MinValue + "\n " + ulong.MaxValue;
        }

        private void shortTypeBtn_Click(object sender, EventArgs e)
        {
            shortTypeLabel.Text = sizeof(short).ToString() + "\n" + short.MinValue + "\n" + short.MaxValue;
        }

        private void decimalTypeBtn_Click(object sender, EventArgs e)
        {
            decimalTypeLabel.Text = sizeof(decimal).ToString() + "\n" + decimal.MinValue + "\n " + decimal.MaxValue;
        }
     
    }
}
