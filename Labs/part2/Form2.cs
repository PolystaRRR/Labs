using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labs.part2_3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        

       

        private void startCalcLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var firstValue = double.Parse(firstOperandTB.Text.TrimEnd().TrimStart());
            double secondValue = double.Parse(secondOperandTB.Text.TrimEnd().TrimStart());


            startCalcLabel.Text = operationTB.Text.TrimEnd().TrimStart() == "+" ? (firstValue + secondValue).ToString()
            : operationTB.Text.TrimEnd().TrimStart() == "-" ? (firstValue - secondValue).ToString()
            : operationTB.Text.TrimEnd().TrimStart() == "*" ? (firstValue * secondValue).ToString()
            : operationTB.Text.PadLeft(0) == "/" ? (firstValue / secondValue).ToString()
            : operationTB.Text.PadLeft(0) == "e" ? (Math.Pow(firstValue, secondValue).ToString()) : "Недопустимо";
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            firstOperandTB.Width = 150;
            secondOperandTB.Width = 150;
            operationTB.Width = 150;
            startCalcLabel.Width = 200;
            firstOperandTB.UseWaitCursor = true;
            secondOperandTB.UseWaitCursor = true;
        }
    }
}
