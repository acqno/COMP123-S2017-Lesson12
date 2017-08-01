using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Name: Alvin Quijano
 * Date: August 1, 2017
 * Desc: This is a Demo application to showcase User Interface control
 * Version: 0.1 - Created the project
 */

namespace COMP123_S2017_Lesson12
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Demo());
        }
    }
}
