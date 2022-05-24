using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CalculatorApplication
{
    public partial class ConcatinationForm : Form
    {
        public ConcatinationForm()
        {
            InitializeComponent();
        }

        private void stringConcatinationButton_Click(object sender, EventArgs e)
        {
            string s1 = stringOneTextBox.Text;
            string s2 = stringTwoTextBox.Text;

            answerTextBox.Text = s1 + s2;
        }
    }
}
