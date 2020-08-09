using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Name: Aditi Kapoor
 * Student number: 301108498
 * 
 * Description: BMI Calculator Project
 * 
 */

namespace BMICalculator
{
    public partial class BMICalculatorForm : Form
    {
        //Private variables
        private double _height;
        private double _weight;
        private double _result;

        public double UserHeight
        {
            get
            {
                return this._height;
            }
            set
            {
                this._height = value;
            }
        }

        public double UserWeight
        {
            get
            {
                return this._weight;
            }
            set
            {
                this._weight = value;
            }
        }

        public double Result
        {
            get
            {
                return this._result;
            }
            set
            {
                this._result = value;
            }
        }

        public BMICalculatorForm()
        {
            InitializeComponent();
        }

        private void CalculateBMIButton_Click(object sender, EventArgs e)
        {
            _calculatebmi();
        }

        private void _calculatebmi()
        {
            UserHeight = Convert.ToDouble(HeightTextBox.Text);
            UserWeight = Convert.ToDouble(WeightTextBox.Text);

            if (MetricButton.Checked)
            {
                Result = UserWeight / (UserHeight * UserHeight);
            }
            else
                if(ImperialButton.Checked)
            {
                Result = (UserWeight * 703) / (UserHeight * UserHeight);
            }
            

            BMITextBoxControl.Text = Convert.ToString(Math.Round(Result,1));

            if (Result < 18.5)
            {
                UserCondition.Text = "You are Underweight";
                UserCondition.BackColor = Color.DeepSkyBlue;
            }
            else if ((Result >= 18.5) && (Result < 25))
            {
                UserCondition.Text = "You are Normal";
                UserCondition.BackColor = Color.YellowGreen;
            }
            else if ((Result >= 25) && (Result < 29.9))
            {
                UserCondition.Text = "You are Overweight";
                UserCondition.BackColor = Color.Purple;
            }
            else
            {
                UserCondition.Text = "You are Obese";
                UserCondition.BackColor = Color.Coral;
            }
        }

        private void BMICalculatorForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BMICalculatorForm_Load(object sender, EventArgs e)
        {

        }
    }
}
