using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GUI_Friendly_PWM_ADC_GPIO_Application
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [MTAThread]
        static void Main()
        {
            Application.Run(new GUI());
        }
    }
}
