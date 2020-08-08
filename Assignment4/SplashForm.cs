﻿using System;
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
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        // TIMER EVENT TO HIDE THIS FORM AND SHOW THE BMI FORM
        // THIS WILL ALSO DISABLE THE SPLASH FORM TIMER
        private void splashformtimer_Tick(object sender, EventArgs e)
        {
            Program.bmiCalculator.Show();
            this.Hide();
            splashformtimer.Enabled = false;
        }
    }
}
