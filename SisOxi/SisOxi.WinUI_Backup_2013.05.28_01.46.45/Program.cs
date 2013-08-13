using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SisOxi.WinUI
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
            
            LoginUI log = new LoginUI();
            //log.ShowDialog();
            if (log.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new PrincipalUI(log.GetCodigoEmpleado()));
            }
        }
    }
}
