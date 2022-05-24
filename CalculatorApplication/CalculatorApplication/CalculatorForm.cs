using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CalculatorApplication
{
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void concatinateStringsButton_Click(object sender, EventArgs e)
        {
            ConcatinationForm concat = new ConcatinationForm();
            concat.Show();
            
        }

        private void stringComparisonButton_Click(object sender, EventArgs e)
        {
            StringComparisonForm compare = new StringComparisonForm();
            compare.Show();
            
        }

        private void palindromeStringButton_Click(object sender, EventArgs e)
        {
            PalindromForm palindrome = new PalindromForm();
            palindrome.Show();
        }

        private void stringReverseButton_Click(object sender, EventArgs e)
        {
            StringReverseForm reverse = new StringReverseForm();
            reverse.Show();
        }
    }
}
