using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LengthAndCharacterCount
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LengthBtn_Click(object sender, EventArgs e)
        {
            textBox2.Text = "Length: " + textBox1.Text.Length;
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void CountBtn_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            string s2 = "";
            for (int i = 0; i < s.Length; i++)
            {
                s2 += "[" + i + "]='" + s[i] + "' ";
            }
            textBox2.Text = s2;
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This program is free to use. Enjoy!");
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void WordCountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            this.Hide();
            f2.ShowDialog();
        }
    }
}