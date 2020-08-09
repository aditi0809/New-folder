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
 * Description: Splash Form - 3sec
 * 
 */

namespace BMICalculator
{
    public partial class Splash : Form
    {
        public BMICalculatorForm BMICalculator
        {
            get
            {
                return Program.bmiCalculatorForm;
            }
        }

        public Splash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.BMICalculator.Show();
            this.Hide();
            timer1.Enabled = false;
        }

        private void Splash_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
