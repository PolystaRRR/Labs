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
            BtnClick(sbyteTypeLabel, 3, typeof(sbyte));
        }

        private void ulongTypeBtn_Click(object sender, EventArgs e)
        {
            BtnClick(ulongTypeLabel, 64, typeof(ulong));
        }

        private void shortTypeBtn_Click(object sender, EventArgs e)
        {
            BtnClick(shortTypeLabel, 16, typeof(short));
        }

        private void decimalTypeBtn_Click(object sender, EventArgs e)
        {
            BtnClick(decimalTypeLabel, 12, typeof(decimal));
        }
        /// <summary>
        /// Handler for different types
        /// </summary>
        /// <param name="label">Label for output info</param>
        /// <param name="typeSize"> Size of type</param>
        /// <param name="valueType"> Current type</param>
        private static void BtnClick(Label label, short typeSize, Type valueType)
        {
            if (valueType == typeof(sbyte))
                label.Text = $"sbyte min value: {sbyte.MinValue}\n" +
                $"sbyte max value: {sbyte.MaxValue}\n" + $"sbyte size is {typeSize} bit";

            else if (valueType == typeof(ulong)) label.Text = $"ulong min value: {ulong.MinValue}\n" +
            $"ulong max value: {ulong.MaxValue}\n" + $"ulong size is {typeSize} bit";

            else if (valueType == typeof(short)) label.Text = $"short min value: {short.MinValue}\n" +
            $"short max value: {short.MaxValue}\n" + $"short size is {typeSize} bit";

            else if (valueType == typeof(decimal)) label.Text = $"decimal min value: {decimal.MinValue}\n" +
            $"decimal max value: {decimal.MaxValue}\n" + $"decimal size is {typeSize} bit";
        }
    }
}
