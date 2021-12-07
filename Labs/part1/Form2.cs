using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labs.part1
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






        private void operationTB_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Add
                || e.KeyCode == Keys.Divide
                || e.KeyCode == Keys.Multiply
                || e.KeyCode == Keys.OemMinus
                || e.KeyCode == Keys.E
                || e.KeyCode == Keys.Back)
                {
                    e.SuppressKeyPress = false;
                }
                else
                {
                    throw new Exception("Non-exist operation");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FillDebug(ex);
                operationTB.Clear();
            }
        }

        private void firstOperandTB_Leave(object sender, EventArgs e)
        {
            try
            {
                double result = double.Parse(firstOperandTB.Text);
                double.TryParse(firstOperandTB.Text, out result);
            }
            catch (FormatException ex)
            {
                FillDebug(ex);
            }
        }

        private void secondOperandTB_Leave(object sender, EventArgs e)
        {
            try
            {
                double result = double.Parse(secondOperandTB.Text);
                double.TryParse(secondOperandTB.Text, out result);
            }
            catch (FormatException ex)
            {
                FillDebug(ex);
            }
        }
        private static void FillDebug(Exception ex)
    {
        MessageBox.Show($"Обработка исключения класса {ex.GetType()}");

        TextWriterTraceListener conWriter = new TextWriterTraceListener(Console.Out);
        Trace.Listeners.Add(conWriter);

        Debug.Indent();
        Debug.WriteLine("Автоматический вывод из буфера: " + Trace.AutoFlush.ToString());
        Trace.WriteLine("Trace: " + "Exception is " + ex.GetType().ToString());
        Debug.Unindent();
        Trace.Flush();
    }
    }
    
}