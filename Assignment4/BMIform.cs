using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4
{
    public partial class BMICalculator : Form
    {
        // PUBLIC FIELD
        public decimal Bmi;
        public BMICalculator()
        {
            InitializeComponent();
        }

        // CODE FOR DISPLAYING OUTPUT TO THE MULTILINE TEXTBOX
        public void multilineoutput(decimal calculatedbmi)
        {
            decimal result = calculatedbmi;
            if (result < (decimal)18.50)
            {
                multilinetextbox.Text = "Result: According to BMI, you are underweight. ";
            }
            else if (result >= (decimal)18.50 && result <= (decimal)24.9)
            {
                multilinetextbox.Text = "Result: According to BMI, you are normal. ";
            }
            else if (result >= 25 && result <= (decimal)29.9)
            {
                multilinetextbox.Text = "Result: According to BMI, you are overweight. ";
            }
            else if (result >= 30)
            {
                multilinetextbox.Text = "Result: According to BMI, you are obese. ";
            }
        }

        // ACTION THAT WILL HAPPEN WHEN THE CALCULATE BMI  BUTTON WILL BE PRESSED
        private void calculatebutton_Click(object sender, EventArgs e)
        {
            decimal wt = weight.Value;
            decimal ht = height.Value;
            if (metricradiobutton.Checked)
            {
                Bmi = wt / ((ht/100) * (ht/100));
                calculatedbmi.Text = "Your BMI is " + Bmi.ToString("N2");
                multilineoutput(Bmi);
            }

            if (imperialradiobutton.Checked)
            {
                Bmi = (wt *703)/ (ht * ht);
                calculatedbmi.Text = "Your BMI is " + Bmi.ToString("N2");
                multilineoutput(Bmi);
            }
        }

        //THIS METHOD WILL CLOSE BOTH, THE BMI AND (HIDDEN)SPLASH FORM
        private void BMICalculator_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
