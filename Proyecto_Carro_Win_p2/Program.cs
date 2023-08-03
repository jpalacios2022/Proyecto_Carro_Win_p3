using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Proyecto_Carro_Win_p3
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
            Application.Run(new WinMenu());
        }
    }
}
