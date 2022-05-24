
namespace CalculatorApplication
{
    partial class ConcatinationForm
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
            this.stringOneTextBox = new System.Windows.Forms.TextBox();
            this.stringTwoTextBox = new System.Windows.Forms.TextBox();
            this.stringSecondLabel = new System.Windows.Forms.Label();
            this.stringOneLabel = new System.Windows.Forms.Label();
            this.stringConcatinationButton = new System.Windows.Forms.Button();
            this.answerTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // stringOneTextBox
            // 
            this.stringOneTextBox.Location = new System.Drawing.Point(367, 74);
            this.stringOneTextBox.Name = "stringOneTextBox";
            this.stringOneTextBox.Size = new System.Drawing.Size(270, 22);
            this.stringOneTextBox.TabIndex = 0;
            // 
            // stringTwoTextBox
            // 
            this.stringTwoTextBox.Location = new System.Drawing.Point(367, 171);
            this.stringTwoTextBox.Name = "stringTwoTextBox";
            this.stringTwoTextBox.Size = new System.Drawing.Size(270, 22);
            this.stringTwoTextBox.TabIndex = 1;
            // 
            // stringSecondLabel
            // 
            this.stringSecondLabel.AutoSize = true;
            this.stringSecondLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stringSecondLabel.Location = new System.Drawing.Point(116, 165);
            this.stringSecondLabel.Name = "stringSecondLabel";
            this.stringSecondLabel.Size = new System.Drawing.Size(131, 28);
            this.stringSecondLabel.TabIndex = 3;
            this.stringSecondLabel.Text = "String second";
            // 
            // stringOneLabel
            // 
            this.stringOneLabel.AutoSize = true;
            this.stringOneLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stringOneLabel.Location = new System.Drawing.Point(116, 68);
            this.stringOneLabel.Name = "stringOneLabel";
            this.stringOneLabel.Size = new System.Drawing.Size(102, 28);
            this.stringOneLabel.TabIndex = 2;
            this.stringOneLabel.Text = "String one";
            // 
            // stringConcatinationButton
            // 
            this.stringConcatinationButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stringConcatinationButton.Location = new System.Drawing.Point(272, 327);
            this.stringConcatinationButton.Name = "stringConcatinationButton";
            this.stringConcatinationButton.Size = new System.Drawing.Size(173, 58);
            this.stringConcatinationButton.TabIndex = 4;
            this.stringConcatinationButton.Text = "Calcuate";
            this.stringConcatinationButton.UseVisualStyleBackColor = true;
            this.stringConcatinationButton.Click += new System.EventHandler(this.stringConcatinationButton_Click);
            // 
            // answerTextBox
            // 
            this.answerTextBox.Location = new System.Drawing.Point(180, 270);
            this.answerTextBox.Name = "answerTextBox";
            this.answerTextBox.Size = new System.Drawing.Size(354, 22);
            this.answerTextBox.TabIndex = 5;
            // 
            // ConcatinationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.answerTextBox);
            this.Controls.Add(this.stringConcatinationButton);
            this.Controls.Add(this.stringSecondLabel);
            this.Controls.Add(this.stringOneLabel);
            this.Controls.Add(this.stringTwoTextBox);
            this.Controls.Add(this.stringOneTextBox);
            this.Name = "ConcatinationForm";
            this.Text = "ConcatinationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox stringOneTextBox;
        private System.Windows.Forms.TextBox stringTwoTextBox;
        private System.Windows.Forms.Label stringSecondLabel;
        private System.Windows.Forms.Label stringOneLabel;
        private System.Windows.Forms.Button stringConcatinationButton;
        private System.Windows.Forms.TextBox answerTextBox;
    }
}