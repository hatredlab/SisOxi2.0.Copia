using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using WinFormTelerikDS;

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
            string proc = Process.GetCurrentProcess().ProcessName;
            Process[] processes = Process.GetProcessesByName(proc);
            LoginUI log = new LoginUI();
            log.StartPosition = FormStartPosition.CenterScreen;
            if (processes.Length > 1)
            {
                WinFormTelerikDS.WinForm.MensajeBox(log, "Sis Oxi", "La Aplicacion SisOxi ya se esta ejecutando", MensajeBox.informacion);
            }
            else
            {
                //Application.EnableVisualStyles();
                //Application.SetCompatibleTextRenderingDefault(false);



                if (log.ShowDialog() == DialogResult.OK)
                {

                    Application.EnableVisualStyles();
                    Application.Run(new PrincipalUI(log.GetCodigoEmpleado(), log.GetNombreEmpleado(), log.GetUsuario()));
                }

            }
        }
    }
}
