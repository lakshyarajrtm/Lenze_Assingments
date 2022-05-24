using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CalculatorApplication
{
    public partial class StringReverseForm : Form
    {
        public StringReverseForm()
        {
            InitializeComponent();
        }

        private void StringReverseForm_Load(object sender, EventArgs e)
        {

        }

        private void palindromeButton_Click(object sender, EventArgs e)
        {
            answerTextBox.Text = StringReverse(stringOneTextBox.Text);
        }

        public string StringReverse(String inp)
        {
            Stack<char> s = new Stack<char>();
            string reverse = "";
            foreach (var i in inp)
            {
                s.Push(i);
            }
            while (s.Count > 0)
            {
                reverse += s.Pop();
            }

            return reverse;
        }
    }
}
