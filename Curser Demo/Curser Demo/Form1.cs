using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Curser_Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            moveToBeg();
        }

        private void moveToBeg()
        {
            textBox1.Select(0, 0);
            textBox1.Focus();
            textBox1.ScrollToCaret();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            moveToEnd();
        }

        private void moveToEnd()
        {
            textBox1.Select(textBox1.Text.Length, 0);
            textBox1.Focus();
            textBox1.ScrollToCaret();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            moveAt(15);
        }

        private void moveAt(int charsFromStart)
        {
            textBox1.Select(charsFromStart, 0);
            textBox1.Focus();
            textBox1.ScrollToCaret();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            moveToLineStart(textBox1.GetLineFromCharIndex(textBox1.GetFirstCharIndexOfCurrentLine())); //same as moveToLineEnd(5) for fifth line
        }

        private void moveToLineStart(int lineNumber)
        {
            int skipChars = textBox1.GetFirstCharIndexFromLine(lineNumber);
            textBox1.Select(skipChars, 0) ;
            textBox1.Focus();
            textBox1.ScrollToCaret();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            moveToLineEnd(textBox1.GetLineFromCharIndex(textBox1.GetFirstCharIndexOfCurrentLine())); //same as moveToLineEnd(5) for fifth line
        }

        private void moveToLineEnd(int lineNumber)
        {
            int skipChars = textBox1.GetFirstCharIndexFromLine(lineNumber+1);
            if (skipChars == -1)   //to check for last line
            {
                textBox1.Select(textBox1.Text.Length,0);
            }
            else
            {
                textBox1.Select(skipChars - 1, 0);                    
            }
            textBox1.Focus();
            textBox1.ScrollToCaret();
        }

    }
}
