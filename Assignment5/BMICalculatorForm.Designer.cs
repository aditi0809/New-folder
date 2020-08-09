namespace BMICalculator
{
    partial class BMICalculatorForm
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
            this.CalculateBMIButton = new System.Windows.Forms.Button();
            this.Height = new System.Windows.Forms.Label();
            this.Weight = new System.Windows.Forms.Label();
            this.HeightTextBox = new System.Windows.Forms.TextBox();
            this.WeightTextBox = new System.Windows.Forms.TextBox();
            this.MetricButton = new System.Windows.Forms.RadioButton();
            this.ImperialButton = new System.Windows.Forms.RadioButton();
            this.BMITextBoxControl = new System.Windows.Forms.TextBox();
            this.UserCondition = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CalculateBMIButton
            // 
            this.CalculateBMIButton.BackColor = System.Drawing.Color.Azure;
            this.CalculateBMIButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CalculateBMIButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.CalculateBMIButton.ForeColor = System.Drawing.Color.DarkGreen;
            this.CalculateBMIButton.Location = new System.Drawing.Point(60, 232);
            this.CalculateBMIButton.Name = "CalculateBMIButton";
            this.CalculateBMIButton.Size = new System.Drawing.Size(194, 42);
            this.CalculateBMIButton.TabIndex = 1;
            this.CalculateBMIButton.Text = "Calculate BMI";
            this.CalculateBMIButton.UseVisualStyleBackColor = false;
            this.CalculateBMIButton.Click += new System.EventHandler(this.CalculateBMIButton_Click);
            // 
            // Height
            // 
            this.Height.AutoSize = true;
            this.Height.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.Height.ForeColor = System.Drawing.Color.DarkGreen;
            this.Height.Location = new System.Drawing.Point(106, 76);
            this.Height.Name = "Height";
            this.Height.Size = new System.Drawing.Size(106, 26);
            this.Height.TabIndex = 4;
            this.Height.Text = "My height";
            // 
            // Weight
            // 
            this.Weight.AutoSize = true;
            this.Weight.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.Weight.ForeColor = System.Drawing.Color.DarkGreen;
            this.Weight.Location = new System.Drawing.Point(106, 147);
            this.Weight.Name = "Weight";
            this.Weight.Size = new System.Drawing.Size(110, 26);
            this.Weight.TabIndex = 5;
            this.Weight.Text = "My weight";
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.BackColor = System.Drawing.Color.Snow;
            this.HeightTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.HeightTextBox.ForeColor = System.Drawing.Color.Gray;
            this.HeightTextBox.Location = new System.Drawing.Point(93, 100);
            this.HeightTextBox.Multiline = true;
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.Size = new System.Drawing.Size(114, 25);
            this.HeightTextBox.TabIndex = 8;
            this.HeightTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // WeightTextBox
            // 
            this.WeightTextBox.BackColor = System.Drawing.Color.Snow;
            this.WeightTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.WeightTextBox.ForeColor = System.Drawing.Color.Gray;
            this.WeightTextBox.Location = new System.Drawing.Point(93, 171);
            this.WeightTextBox.Multiline = true;
            this.WeightTextBox.Name = "WeightTextBox";
            this.WeightTextBox.Size = new System.Drawing.Size(114, 25);
            this.WeightTextBox.TabIndex = 9;
            this.WeightTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MetricButton
            // 
            this.MetricButton.AutoSize = true;
            this.MetricButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MetricButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.MetricButton.ForeColor = System.Drawing.Color.DarkGreen;
            this.MetricButton.Location = new System.Drawing.Point(46, 27);
            this.MetricButton.Name = "MetricButton";
            this.MetricButton.Size = new System.Drawing.Size(92, 30);
            this.MetricButton.TabIndex = 10;
            this.MetricButton.TabStop = true;
            this.MetricButton.Text = "Metric";
            this.MetricButton.UseVisualStyleBackColor = true;
            // 
            // ImperialButton
            // 
            this.ImperialButton.AutoSize = true;
            this.ImperialButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ImperialButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.ImperialButton.ForeColor = System.Drawing.Color.DarkGreen;
            this.ImperialButton.Location = new System.Drawing.Point(167, 27);
            this.ImperialButton.Name = "ImperialButton";
            this.ImperialButton.Size = new System.Drawing.Size(111, 30);
            this.ImperialButton.TabIndex = 11;
            this.ImperialButton.TabStop = true;
            this.ImperialButton.Text = "Imperial";
            this.ImperialButton.UseVisualStyleBackColor = true;
            // 
            // BMITextBoxControl
            // 
            this.BMITextBoxControl.BackColor = System.Drawing.Color.Snow;
            this.BMITextBoxControl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BMITextBoxControl.Enabled = false;
            this.BMITextBoxControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.BMITextBoxControl.ForeColor = System.Drawing.Color.Gray;
            this.BMITextBoxControl.Location = new System.Drawing.Point(83, 313);
            this.BMITextBoxControl.Margin = new System.Windows.Forms.Padding(0);
            this.BMITextBoxControl.Multiline = true;
            this.BMITextBoxControl.Name = "BMITextBoxControl";
            this.BMITextBoxControl.ReadOnly = true;
            this.BMITextBoxControl.Size = new System.Drawing.Size(137, 39);
            this.BMITextBoxControl.TabIndex = 12;
            this.BMITextBoxControl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UserCondition
            // 
            this.UserCondition.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserCondition.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.UserCondition.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.UserCondition.Location = new System.Drawing.Point(12, 368);
            this.UserCondition.Multiline = true;
            this.UserCondition.Name = "UserCondition";
            this.UserCondition.Size = new System.Drawing.Size(280, 36);
            this.UserCondition.TabIndex = 13;
            this.UserCondition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BMICalculatorForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.GreenYellow;
            this.ClientSize = new System.Drawing.Size(304, 441);
            this.Controls.Add(this.UserCondition);
            this.Controls.Add(this.BMITextBoxControl);
            this.Controls.Add(this.ImperialButton);
            this.Controls.Add(this.MetricButton);
            this.Controls.Add(this.WeightTextBox);
            this.Controls.Add(this.HeightTextBox);
            this.Controls.Add(this.Weight);
            this.Controls.Add(this.Height);
            this.Controls.Add(this.CalculateBMIButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.ForeColor = System.Drawing.Color.Khaki;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "BMICalculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BMICalculatorForm_FormClosed);
            this.Load += new System.EventHandler(this.BMICalculatorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CalculateBMIButton;
        private System.Windows.Forms.Label Height;
        private System.Windows.Forms.Label Weight;
        private System.Windows.Forms.TextBox HeightTextBox;
        private System.Windows.Forms.TextBox WeightTextBox;
        private System.Windows.Forms.RadioButton MetricButton;
        private System.Windows.Forms.RadioButton ImperialButton;
        private System.Windows.Forms.TextBox BMITextBoxControl;
        private System.Windows.Forms.TextBox UserCondition;
    }
}

