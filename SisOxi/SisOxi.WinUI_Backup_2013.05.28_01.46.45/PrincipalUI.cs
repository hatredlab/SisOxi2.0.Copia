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

        public PrincipalUI(int idEmpleado)
        {
            
                InitializeComponent();
                idEmpleadogbl = idEmpleado;
                      


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


        private void PrincipalUI_Load(object sender, EventArgs e)
        {
            //ThemeResolutionService.ApplicationThemeName = "Office2010Black";

            
            this.radCarousel1.CarouselElement.Children[1].Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            this.radCarousel1.CarouselElement.Children[4].Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            this.radCarousel1.CarouselElement.Children[3].Visibility = Telerik.WinControls.ElementVisibility.Hidden; 
            
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
            WinForm.LlamarFormAPanel(new RadForm1(), pnlContenido);
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
            RadForm1 paciente = null;

            paciente = (RadForm1)WinForm.EstaAbiertoFormulario(typeof(RadForm1));
            if (paciente == null)
            {
                paciente = new RadForm1();
                WinForm.LlamarFormAPanel(paciente, pnlContenido);
            }
            else
            {
                pnlContenido.Controls.Clear();
                WinForm.LlamarFormAPanel(paciente, pnlContenido);
            }
        }
    }
}
