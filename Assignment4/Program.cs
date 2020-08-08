using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4
{
    static class Program
    {
        // PUBLIC STATIC FIELDS
        public static SplashForm splashform;
        public static BMICalculator bmiCalculator;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            //  INSTANTIATING THE FORM OBJECTS
            splashform = new SplashForm();
            bmiCalculator = new BMICalculator();

            //  DECLARING FROM WHERE THE APPLICATION WILL START
            Application.Run(splashform);
        }
    }
}
