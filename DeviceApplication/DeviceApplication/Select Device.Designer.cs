
namespace DeviceApplication
{
    partial class selectDeviceForm
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
            this.deviceOneButton = new System.Windows.Forms.Button();
            this.deviceSecondButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // deviceOneButton
            // 
            this.deviceOneButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deviceOneButton.Location = new System.Drawing.Point(107, 361);
            this.deviceOneButton.Name = "deviceOneButton";
            this.deviceOneButton.Size = new System.Drawing.Size(198, 94);
            this.deviceOneButton.TabIndex = 0;
            this.deviceOneButton.Text = "Show Details";
            this.deviceOneButton.UseVisualStyleBackColor = true;
            this.deviceOneButton.Click += new System.EventHandler(this.deviceOneButton_Click);
            // 
            // deviceSecondButton
            // 
            this.deviceSecondButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deviceSecondButton.Location = new System.Drawing.Point(565, 352);
            this.deviceSecondButton.Name = "deviceSecondButton";
            this.deviceSecondButton.Size = new System.Drawing.Size(198, 103);
            this.deviceSecondButton.TabIndex = 1;
            this.deviceSecondButton.Text = "Show Details";
            this.deviceSecondButton.UseVisualStyleBackColor = true;
            this.deviceSecondButton.Click += new System.EventHandler(this.deviceSecondButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::DeviceApplication.Properties.Resources.deviceSecond;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(502, 79);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(321, 227);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::DeviceApplication.Properties.Resources.deviceOne;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(41, 79);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(321, 227);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // selectDeviceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 620);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.deviceSecondButton);
            this.Controls.Add(this.deviceOneButton);
            this.Name = "selectDeviceForm";
            this.Text = "Select Device";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button deviceOneButton;
        private System.Windows.Forms.Button deviceSecondButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

