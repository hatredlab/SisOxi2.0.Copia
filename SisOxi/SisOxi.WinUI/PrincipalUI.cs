using MouseKeyboardActivityMonitor;
using MouseKeyboardActivityMonitor.WinApi;
using SisOxi.WinUI.Seguridad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.RichTextBox.Winforms;
using WinFormTelerikDS;

namespace SisOxi.WinUI
{
    public partial class PrincipalUI : Telerik.WinControls.UI.RadForm
    {
        public static int idEmpleadogbl;
        private HistoriaClinicaUI historia;
        public static string nombreEmpleadogbl;

        public PrincipalUI()
        {
            LoginUI log = new LoginUI();
            log.ShowDialog();
            if (log.ShowDialog() == DialogResult.OK)
            {
                InitializeComponent();
                log.Close();
            }
            
            
        }

        public PrincipalUI(int idEmpleado,string nombreEmpleado)
        {
            
                InitializeComponent();
                idEmpleadogbl = idEmpleado;
                nombreEmpleadogbl = nombreEmpleado;


        }

        private void radButton1_Click(object sender, EventArgs e)
        {

            //LoadingUI l = new LoadingUI();
            //l.Show();
            //RetornarFormulario();
            //l.Close();

            HistoriaClinicaUI historia = null;

            historia = (HistoriaClinicaUI)WinForm.EstaAbiertoFormulario(typeof(HistoriaClinicaUI));
            if (historia == null)
            {
                historia = new HistoriaClinicaUI(this);
                WinForm.LlamarFormAPanel(historia, pnlContenido);
            }
            else
            {
                pnlContenido.Controls.Clear();
                WinForm.LlamarFormAPanel(historia, pnlContenido);
            }
        }

        void historia_Closed(object sender, EventArgs e)
        {
            historia = null;
        }
        //private async void RetornarFormulario()
        //{
        //    HistoriaClinicaUI result = await MetodoAsyncrono();
        //    WinForm.SplashScreen(result);
        //    WinForm.LlamarFormAPanel(result, pnlContenido);
        //    result.Show();

        //}

        //private Task<HistoriaClinicaUI> MetodoAsyncrono()
        //{
        //    return Task.Run<HistoriaClinicaUI>(() => MetodoFormulario());
        //}

        //private HistoriaClinicaUI MetodoFormulario()
        //{
        //    HistoriaClinicaUI frm = new HistoriaClinicaUI();

        //    return frm;
        //}

        #region Bloqueo

        private int tiempo = 0;
        private string usuario;

        public PrincipalUI(int idEmpleado, string nombreEmpleado, string usu)
        {

            InitializeComponent();
            idEmpleadogbl = idEmpleado;
            nombreEmpleadogbl = nombreEmpleado;
            usuario = usu;
            this.radCarousel1.CarouselElement.Children[1].Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            this.radCarousel1.CarouselElement.Children[4].Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            this.radCarousel1.CarouselElement.Children[3].Visibility = Telerik.WinControls.ElementVisibility.Hidden;
        }

        private MouseHookListener m_mouseListener;
        private KeyboardHookListener m_keyboardListener;
        //private Mouseho

        // Subroutine for activating the hook
        public void Activar()
        {
            // Note: for an application hook, use the AppHooker class instead
            m_mouseListener = new MouseHookListener(new GlobalHooker());
            m_keyboardListener = new KeyboardHookListener(new GlobalHooker());
            // The listener is not enabled by default
            m_mouseListener.Enabled = true;
            m_keyboardListener.Enabled = true;
            // Set the event handler
            // recommended to use the Extended handlers, which allow input suppression among other additional information
           // m_mouseListener.MouseDownExt += MouseListener_MouseDownExt;
            m_mouseListener.MouseMoveExt += MouseListener_MouseMove;
            m_keyboardListener.KeyDown += KeyBoardListener_KeyDown;
        }

        public void Desactivar()
        {
            m_mouseListener.Dispose();
        }

        private void KeyBoardListener_KeyDown(object sender, KeyEventArgs e)
        {
            tiempo = 0;

        }

        private void MouseListener_MouseMove(object sender, MouseEventExtArgs e)
        {
            tiempo = 0;
            
        }

        private void tmrActividad_Tick(object sender, EventArgs e)
        {
            tiempo++;
            if (tiempo == 15)
            {

                BloqueoLoginUI logeo = new BloqueoLoginUI(usuario);
                m_mouseListener.MouseMoveExt -= MouseListener_MouseMove;
                m_keyboardListener.KeyDown -= KeyBoardListener_KeyDown;
                if (DialogResult.OK == logeo.ShowDialog())
                {
                    tiempo = 0;
                    m_mouseListener.MouseMoveExt += MouseListener_MouseMove;
                    m_keyboardListener.KeyDown += KeyBoardListener_KeyDown;
                }

            }
        }

        #endregion
        private void PrincipalUI_Load(object sender, EventArgs e)
        {
            //ThemeResolutionService.ApplicationThemeName = "Office2010Black";
            Activar();
            tmrActividad.Enabled = true;
            this.Text = "SISTEMA OXIBARITERAPIA / USUARIO : " + nombreEmpleadogbl;
            
            new HistoriaClinicaUI().Show();
            //Color color = Color.FromArgb(19, 182, 220);
            //btnHistoriaClinica.ButtonElement.ForeColor = color;
            //btnEmpleado.ButtonElement.ForeColor = color;
            //btnReportes.ButtonElement.ForeColor = color;
        }

        private void radButton1_Click_1(object sender, EventArgs e)
        {
            EmpleadoUI paciente = new EmpleadoUI(this);

            //WinForm.SplashScreen(paciente);
            WinForm.LlamarFormAPanel(paciente, pnlContenido);
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            WinForm.LlamarFormAPanel(new ReportUI(this), pnlContenido);
        }

        private void radButtonElement1_Click(object sender, EventArgs e)
        {
            HistoriaClinicaUI historia = null;

            historia = (HistoriaClinicaUI)WinForm.EstaAbiertoFormulario(typeof(HistoriaClinicaUI));
            if (historia == null)
            {
                historia = new HistoriaClinicaUI(this);
                WinForm.LlamarFormAPanel(historia, pnlContenido);
            }
            else
            {
                pnlContenido.Controls.Clear();
                WinForm.LlamarFormAPanel(historia, pnlContenido);
            }
        }

        private void radButtonElement2_Click(object sender, EventArgs e)
        {
            //EmpleadoUI paciente = new EmpleadoUI(this);

            ////WinForm.SplashScreen(paciente);
            //WinForm.LlamarFormAPanel(paciente, pnlContenido);

            EmpleadoUI paciente = null;

            paciente = (EmpleadoUI)WinForm.EstaAbiertoFormulario(typeof(EmpleadoUI));
            if (paciente == null)
            {
                paciente = new EmpleadoUI(this);
                WinForm.LlamarFormAPanel(paciente, pnlContenido);
            }
            else
            {
                pnlContenido.Controls.Clear();
                WinForm.LlamarFormAPanel(paciente, pnlContenido);
            }
        }

        private void radButtonElement3_Click(object sender, EventArgs e)
        {
            ReportUI paciente = null;

            paciente = (ReportUI)WinForm.EstaAbiertoFormulario(typeof(ReportUI));
            if (paciente == null)
            {
                paciente = new ReportUI(this);
                WinForm.LlamarFormAPanel(paciente, pnlContenido);
            }
            else
            {
                pnlContenido.Controls.Clear();
                WinForm.LlamarFormAPanel(paciente, pnlContenido);
            }
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            string path = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            path = "file://" + System.IO.Path.Combine(path, "SisOxi.chm");
            Help.ShowHelp(this, path);
            //Help.ShowHelp(this, @"file://C:\Users\Charlie\Desktop\SisOxi.chm");
        }

        
    }
}
