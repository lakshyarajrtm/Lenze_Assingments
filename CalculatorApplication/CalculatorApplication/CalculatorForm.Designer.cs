
namespace CalculatorApplication
{
    partial class CalculatorForm
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
            this.concatinateStringsButton = new System.Windows.Forms.Button();
            this.stringReverseButton = new System.Windows.Forms.Button();
            this.palindromeStringButton = new System.Windows.Forms.Button();
            this.stringComparisonButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // concatinateStringsButton
            // 
            this.concatinateStringsButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.concatinateStringsButton.Location = new System.Drawing.Point(465, 79);
            this.concatinateStringsButton.Name = "concatinateStringsButton";
            this.concatinateStringsButton.Size = new System.Drawing.Size(154, 75);
            this.concatinateStringsButton.TabIndex = 0;
            this.concatinateStringsButton.Text = "Concatinate Strings";
            this.concatinateStringsButton.UseVisualStyleBackColor = true;
            this.concatinateStringsButton.Click += new System.EventHandler(this.concatinateStringsButton_Click);
            // 
            // stringReverseButton
            // 
            this.stringReverseButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stringReverseButton.Location = new System.Drawing.Point(465, 283);
            this.stringReverseButton.Name = "stringReverseButton";
            this.stringReverseButton.Size = new System.Drawing.Size(154, 75);
            this.stringReverseButton.TabIndex = 1;
            this.stringReverseButton.Text = "String Reverse";
            this.stringReverseButton.UseVisualStyleBackColor = true;
            this.stringReverseButton.Click += new System.EventHandler(this.stringReverseButton_Click);
            // 
            // palindromeStringButton
            // 
            this.palindromeStringButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.palindromeStringButton.Location = new System.Drawing.Point(106, 283);
            this.palindromeStringButton.Name = "palindromeStringButton";
            this.palindromeStringButton.Size = new System.Drawing.Size(154, 75);
            this.palindromeStringButton.TabIndex = 2;
            this.palindromeStringButton.Text = "Palindrome String";
            this.palindromeStringButton.UseVisualStyleBackColor = true;
            this.palindromeStringButton.Click += new System.EventHandler(this.palindromeStringButton_Click);
            // 
            // stringComparisonButton
            // 
            this.stringComparisonButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stringComparisonButton.Location = new System.Drawing.Point(106, 79);
            this.stringComparisonButton.Name = "stringComparisonButton";
            this.stringComparisonButton.Size = new System.Drawing.Size(154, 75);
            this.stringComparisonButton.TabIndex = 3;
            this.stringComparisonButton.Text = "String Comparison";
            this.stringComparisonButton.UseVisualStyleBackColor = true;
            this.stringComparisonButton.Click += new System.EventHandler(this.stringComparisonButton_Click);
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 450);
            this.Controls.Add(this.stringComparisonButton);
            this.Controls.Add(this.palindromeStringButton);
            this.Controls.Add(this.stringReverseButton);
            this.Controls.Add(this.concatinateStringsButton);
            this.Name = "CalculatorForm";
            this.Text = "Calculate";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button concatinateStringsButton;
        private System.Windows.Forms.Button stringReverseButton;
        private System.Windows.Forms.Button palindromeStringButton;
        private System.Windows.Forms.Button stringComparisonButton;
    }
}

