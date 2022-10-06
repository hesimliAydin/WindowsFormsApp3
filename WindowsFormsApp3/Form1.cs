using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void undoBtn_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void redoBtn_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void cutBtn_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copyBtn_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteBtn_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionColor = Color.Red;
            MessageBox.Show(richTextBox1.SelectedText);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = dateTimePicker1.Value.ToLongDateString();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            richTextBox1.Text = monthCalendar1.SelectionStart.ToString();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox1.BackColor = Color.Green;
            }
            else
            {
                checkBox1.BackColor = Color.Blue;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox2.BackColor= Color.Green;
            }
            else
            {
                checkBox2.BackColor = Color.Blue;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                radioButton1.Text = "Visa Selected";
                radioButton2.Text = "Master";
            }
            else
            {
                radioButton1.Text = "Visa";
                radioButton2.Text = "Master Selected";
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
