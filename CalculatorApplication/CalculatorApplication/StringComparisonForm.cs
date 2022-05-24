using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CalculatorApplication
{
    public partial class StringComparisonForm : Form
    {
        public StringComparisonForm()
        {
            InitializeComponent();
        }

        private void StringComparisonForm_Load(object sender, EventArgs e)
        {

        }

        private void stringCompareButton_Click(object sender, EventArgs e)
        {
            if (stringOneTextBox.Text.Equals(stringTwoTextBox.Text)){
                answerTextBox.Text = "True";
            }
            else
            {
                answerTextBox.Text = "False";
            }
        }
    }
}
