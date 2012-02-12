using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

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

            SplashImageForm f = new SplashImageForm();

            //f.Shown += new EventHandler((o, e) =>
            //{
            //    System.Threading.Thread t = new System.Threading.Thread(() =>
            //    {
            //        System.Threading.Thread.Sleep(2000);
            //        f.Invoke(new Action(() => { f.Close(); }));

            //    });
            //    t.IsBackground = true;
            //    t.Start();
            //});

            // Application.Run(f);

            Application.Run(new loginForm());
        }
    }
}
