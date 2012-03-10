using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using _2103Project.Action;
using _2103Project.Entities;

namespace _2103Project
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

            //SplashImageForm f = new SplashImageForm();

            //Application.Run(f);

            //System.Threading.Thread.Sleep(2000);


            //f.Close()

            Application.Run(new loginSelectForm());
        }
    }
}
