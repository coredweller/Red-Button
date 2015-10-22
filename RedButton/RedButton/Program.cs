﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RedButton
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault( false );
            //Application.Run( new Form1() );

            // Show the system tray icon.
            using ( ProcessIcon pi = new ProcessIcon() ) {
                pi.Display();

                // Make sure the application runs!
                Application.Run();
            }
        }
    }
}
