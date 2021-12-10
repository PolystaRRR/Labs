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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Открыть";
            openFileDialog.Filter = "RTF Files (.rtf)|.rtf";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                mainTB.LoadFile(openFileDialog.FileName);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Сохранить";
            saveFileDialog.Filter = "RTF Files |*.rtf";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                mainTB.SaveFile(saveFileDialog.FileName.Replace(".rtf", ".txt"), RichTextBoxStreamType.RichText);
        }

        private void applyToolStripMenuItem_Click(object sender, EventArgs e)
        {

            mainTB.Font = new Font(toolStripComboBox1.Font.FontFamily, Convert.ToInt32(toolStripComboBox1.Text));

        }

        private void centreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainTB.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void leftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainTB.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void rightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainTB.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void changeSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditForm editForm = new EditForm(this);
            editForm.MdiParent = this;
            editForm.Show();

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mainTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == (Keys.Control | Keys.S))
            {
                saveToolStripMenuItem_Click(sender, e);
            }
            if (e.KeyData== (Keys.Control | Keys.A))
            {
                mainTB.SelectAll();
            }
        }

    }
}
