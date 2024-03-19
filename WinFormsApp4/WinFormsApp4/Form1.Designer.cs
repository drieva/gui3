namespace HurricaneApp
{
    partial class Form1
    {
        private void InitializeComponent()
        {
            this.calculateButton = new System.Windows.Forms.Button();
            this.windSpeedLabel = new System.Windows.Forms.Label();
            this.windSpeedTextBox = new System.Windows.Forms.TextBox();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(89, 91);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 0;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // windSpeedLabel
            // 
            this.windSpeedLabel.AutoSize = true;
            this.windSpeedLabel.Location = new System.Drawing.Point(12, 33);
            this.windSpeedLabel.Name = "windSpeedLabel";
            this.windSpeedLabel.Size = new System.Drawing.Size(64, 13);
            this.windSpeedLabel.TabIndex = 1;
            this.windSpeedLabel.Text = "Wind Speed";
            // 
            // windSpeedTextBox
            // 
            this.windSpeedTextBox.Location = new System.Drawing.Point(82, 30);
            this.windSpeedTextBox.Name = "windSpeedTextBox";
            this.windSpeedTextBox.Size = new System.Drawing.Size(100, 20);
            this.windSpeedTextBox.TabIndex = 2;
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Location = new System.Drawing.Point(12, 147);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(49, 13);
            this.categoryLabel.TabIndex = 3;
            this.categoryLabel.Text = "Category";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 193);
            this.Controls.Add(this.categoryLabel);
            this.Controls.Add(this.windSpeedTextBox);
            this.Controls.Add(this.windSpeedLabel);
            this.Controls.Add(this.calculateButton);
            this.Name = "Form1";
            this.Text = "Hurricane";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label windSpeedLabel;
        private System.Windows.Forms.TextBox windSpeedTextBox;
        private System.Windows.Forms.Label categoryLabel;
    }
}
