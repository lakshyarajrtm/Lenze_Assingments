using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CalculatorApplication
{
    public partial class PalindromForm : Form
    {
        public PalindromForm()
        {
            InitializeComponent();
        }

        private void palindromeButton_Click(object sender, EventArgs e)
        {
            if(stringOneTextBox.Text == StringReverse(stringOneTextBox.Text))
            {
                answerTextBox.Text = "True";
            }
            else
            {
                answerTextBox.Text = "False";
            }
        }

        public string StringReverse(String inp)
        {
            Stack<char> s = new Stack<char>();
            string reverse = "";
            foreach(var i in inp)
            {
                s.Push(i);
            }
            while(s.Count > 0)
            {
                reverse += s.Pop();
            }

            return reverse;
        }
    }
}
