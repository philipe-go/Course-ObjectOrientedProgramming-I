//Student Management Windows Application
//created by Philipe Gouveia - 1910072 @ Jun 05th, 2019
//solution created to apply knowledge of OOP into a 3 tiers application - Data, Business and Client

using System;
using System.Windows.Forms;

namespace StudentAppWindows
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
            Application.Run(new Form1());
        }
    }
}
