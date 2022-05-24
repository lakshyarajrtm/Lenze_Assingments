
namespace CalculatorApplication
{
    partial class PalindromForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.stringOneLabel = new System.Windows.Forms.Label();
            this.stringOneTextBox = new System.Windows.Forms.TextBox();
            this.answerTextBox = new System.Windows.Forms.TextBox();
            this.palindromeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // stringOneLabel
            // 
            this.stringOneLabel.AutoSize = true;
            this.stringOneLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stringOneLabel.Location = new System.Drawing.Point(168, 103);
            this.stringOneLabel.Name = "stringOneLabel";
            this.stringOneLabel.Size = new System.Drawing.Size(114, 28);
            this.stringOneLabel.TabIndex = 10;
            this.stringOneLabel.Text = "Enter String";
            // 
            // stringOneTextBox
            // 
            this.stringOneTextBox.Location = new System.Drawing.Point(362, 110);
            this.stringOneTextBox.Name = "stringOneTextBox";
            this.stringOneTextBox.Size = new System.Drawing.Size(270, 22);
            this.stringOneTextBox.TabIndex = 9;
            // 
            // answerTextBox
            // 
            this.answerTextBox.Location = new System.Drawing.Point(268, 168);
            this.answerTextBox.Name = "answerTextBox";
            this.answerTextBox.Size = new System.Drawing.Size(309, 22);
            this.answerTextBox.TabIndex = 13;
            // 
            // palindromeButton
            // 
            this.palindromeButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.palindromeButton.Location = new System.Drawing.Point(315, 225);
            this.palindromeButton.Name = "palindromeButton";
            this.palindromeButton.Size = new System.Drawing.Size(164, 81);
            this.palindromeButton.TabIndex = 12;
            this.palindromeButton.Text = "Is Palindrome";
            this.palindromeButton.UseVisualStyleBackColor = true;
            this.palindromeButton.Click += new System.EventHandler(this.palindromeButton_Click);
            // 
            // PalindromForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.answerTextBox);
            this.Controls.Add(this.palindromeButton);
            this.Controls.Add(this.stringOneLabel);
            this.Controls.Add(this.stringOneTextBox);
            this.Name = "PalindromForm";
            this.Text = "PalindromForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label stringOneLabel;
        private System.Windows.Forms.TextBox stringOneTextBox;
        private System.Windows.Forms.TextBox answerTextBox;
        private System.Windows.Forms.Button palindromeButton;
    }
}