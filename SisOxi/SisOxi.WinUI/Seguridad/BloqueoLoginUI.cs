using SisOxi.BUS;
using SisOxi.VO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using WinFormTelerikDS;

namespace SisOxi.WinUI.Seguridad
{
    public partial class BloqueoLoginUI : Telerik.WinControls.UI.RadForm
    {
        public BloqueoLoginUI()
        {
            InitializeComponent();
        }

        private string usu;

        public BloqueoLoginUI(string usuario)
        {
            InitializeComponent();
            usu = usuario;
        }

        private void LogearAlSistema()
        {
            LoginVO logeo = new LoginVO();
            bool EsValido = false;

            logeo.nombres = usu;
            logeo.clave = txtClave.Text;
            EmpleadoVO empleado = new LoginBUS().Log(logeo, ref EsValido);

            if (EsValido)
            {


                WinForm.MensajeBox(this, "Acceso al Sistema", "Bienvenido de nuevo : " + empleado.Nombres + " " + empleado.Apellidos, MensajeBox.informacion);

                this.DialogResult = DialogResult.OK;
                this.Close();
                // new PrincipalUI(empleado.IdEmpleado).Show();

            }
            else
            {
                WinForm.MensajeBox(this, "Acceso al Sistema", "No ha podido acceder al Sistema", MensajeBox.advertencia);
            }
        }
        private void BloqueoLoginUI_Load(object sender, EventArgs e)
        {
            WinForm.ConvertirBordesRedondeadosLabelEnForm(this);
            lblTitulo.Text = "Acceso al Sistemaa : " + usu;
        }

        private void radButton3_Click(object sender, EventArgs e)
        {
            LogearAlSistema();
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == WinForm.MensajeBox(this, "Salir de la Aplicacion", "¿Desea salir de la Aplicacion?", MensajeBox.pregunta))
            {

                Application.Exit();
            }
        }
    }
}
