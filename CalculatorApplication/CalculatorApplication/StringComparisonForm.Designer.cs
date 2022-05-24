
namespace CalculatorApplication
{
    partial class StringComparisonForm
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
            this.answerTextBox = new System.Windows.Forms.TextBox();
            this.stringCompareButton = new System.Windows.Forms.Button();
            this.stringSecondLabel = new System.Windows.Forms.Label();
            this.stringOneLabel = new System.Windows.Forms.Label();
            this.stringTwoTextBox = new System.Windows.Forms.TextBox();
            this.stringOneTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // answerTextBox
            // 
            this.answerTextBox.Location = new System.Drawing.Point(204, 269);
            this.answerTextBox.Name = "answerTextBox";
            this.answerTextBox.Size = new System.Drawing.Size(354, 22);
            this.answerTextBox.TabIndex = 11;
            // 
            // stringCompareButton
            // 
            this.stringCompareButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stringCompareButton.Location = new System.Drawing.Point(296, 326);
            this.stringCompareButton.Name = "stringCompareButton";
            this.stringCompareButton.Size = new System.Drawing.Size(173, 58);
            this.stringCompareButton.TabIndex = 10;
            this.stringCompareButton.Text = "Compare";
            this.stringCompareButton.UseVisualStyleBackColor = true;
            this.stringCompareButton.Click += new System.EventHandler(this.stringCompareButton_Click);
            // 
            // stringSecondLabel
            // 
            this.stringSecondLabel.AutoSize = true;
            this.stringSecondLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stringSecondLabel.Location = new System.Drawing.Point(140, 164);
            this.stringSecondLabel.Name = "stringSecondLabel";
            this.stringSecondLabel.Size = new System.Drawing.Size(131, 28);
            this.stringSecondLabel.TabIndex = 9;
            this.stringSecondLabel.Text = "String second";
            // 
            // stringOneLabel
            // 
            this.stringOneLabel.AutoSize = true;
            this.stringOneLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stringOneLabel.Location = new System.Drawing.Point(140, 67);
            this.stringOneLabel.Name = "stringOneLabel";
            this.stringOneLabel.Size = new System.Drawing.Size(102, 28);
            this.stringOneLabel.TabIndex = 8;
            this.stringOneLabel.Text = "String one";
            // 
            // stringTwoTextBox
            // 
            this.stringTwoTextBox.Location = new System.Drawing.Point(391, 170);
            this.stringTwoTextBox.Name = "stringTwoTextBox";
            this.stringTwoTextBox.Size = new System.Drawing.Size(270, 22);
            this.stringTwoTextBox.TabIndex = 7;
            // 
            // stringOneTextBox
            // 
            this.stringOneTextBox.Location = new System.Drawing.Point(391, 73);
            this.stringOneTextBox.Name = "stringOneTextBox";
            this.stringOneTextBox.Size = new System.Drawing.Size(270, 22);
            this.stringOneTextBox.TabIndex = 6;
            // 
            // StringComparisonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.answerTextBox);
            this.Controls.Add(this.stringCompareButton);
            this.Controls.Add(this.stringSecondLabel);
            this.Controls.Add(this.stringOneLabel);
            this.Controls.Add(this.stringTwoTextBox);
            this.Controls.Add(this.stringOneTextBox);
            this.Name = "StringComparisonForm";
            this.Text = "StringComparison";
            this.Load += new System.EventHandler(this.StringComparisonForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox answerTextBox;
        private System.Windows.Forms.Button stringCompareButton;
        private System.Windows.Forms.Label stringSecondLabel;
        private System.Windows.Forms.Label stringOneLabel;
        private System.Windows.Forms.TextBox stringTwoTextBox;
        private System.Windows.Forms.TextBox stringOneTextBox;
    }
}