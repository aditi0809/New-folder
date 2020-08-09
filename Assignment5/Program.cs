using System;
using System.Collections.Generic;
using System.Linq;
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
    static class Program
    {
        /// <summary>
        /// The BMI Calculator will calculate the standard body mass of a person
        /// </summary>

        public static BMICalculatorForm bmiCalculatorForm;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            bmiCalculatorForm = new BMICalculatorForm();
            Application.Run(new Splash());

    }
}
}
