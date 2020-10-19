namespace DistanceCalculator
{
    partial class Form1
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
            this.speedLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.speedTextBox = new System.Windows.Forms.TextBox();
            this.hoursTextBox = new System.Windows.Forms.TextBox();
            this.hoursLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // speedLabel
            // 
            this.speedLabel.AutoSize = true;
            this.speedLabel.Location = new System.Drawing.Point(102, 59);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(117, 13);
            this.speedLabel.TabIndex = 0;
            this.speedLabel.Text = "Vehicle Speed in MPH:";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(105, 210);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 1;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // speedTextBox
            // 
            this.speedTextBox.Location = new System.Drawing.Point(275, 59);
            this.speedTextBox.Name = "speedTextBox";
            this.speedTextBox.Size = new System.Drawing.Size(100, 20);
            this.speedTextBox.TabIndex = 2;
            this.speedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // hoursTextBox
            // 
            this.hoursTextBox.Location = new System.Drawing.Point(275, 113);
            this.hoursTextBox.Name = "hoursTextBox";
            this.hoursTextBox.Size = new System.Drawing.Size(100, 20);
            this.hoursTextBox.TabIndex = 4;
            this.hoursTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // hoursLabel
            // 
            this.hoursLabel.AutoSize = true;
            this.hoursLabel.Location = new System.Drawing.Point(102, 113);
            this.hoursLabel.Name = "hoursLabel";
            this.hoursLabel.Size = new System.Drawing.Size(83, 13);
            this.hoursLabel.TabIndex = 3;
            this.hoursLabel.Text = "Hours Traveled:";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(300, 210);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 309);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.hoursTextBox);
            this.Controls.Add(this.hoursLabel);
            this.Controls.Add(this.speedTextBox);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.speedLabel);
            this.Name = "Form1";
            this.Text = "Distance Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label speedLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.TextBox speedTextBox;
        private System.Windows.Forms.TextBox hoursTextBox;
        private System.Windows.Forms.Label hoursLabel;
        private System.Windows.Forms.Button exitButton;
    }
}

