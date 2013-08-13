using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using SisOxi.BUS;
using SisOxi.VO;
using WinFormTelerikDS;
using SisOxi.VO.Seguridad;
using SisOxi.BUS.Seguridad;


namespace SisOxi.WinUI
{
    public partial class LoginUI : Telerik.WinControls.UI.RadForm
    {
        private int idEmpleado;
        public LoginUI()
        {
            InitializeComponent();
        }

        private void LoginUI_Load(object sender, EventArgs e)
        {
            CargarFormulario();
        }

        private void CargarFormulario()
        {
            WinFormTelerikDS.WinForm.ConvertirBordesRedondeadosLabelEnForm(this);
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            new ConexionUI().ShowDialog();
        }

        private void radButton3_Click(object sender, EventArgs e)
        {
            LogearAlSistema();
            
        }

        public void SetCodigoEmpleado(int idEmpleado)
        {
            this.idEmpleado = idEmpleado;
           
        }

        public int GetCodigoEmpleado()
        {
            return this.idEmpleado;
        }

        private void LogearAlSistema()
        {
            LoginVO logeo = new LoginVO();
            bool EsValido = false;

            logeo.nombres = txtDni.Text;
            logeo.clave = txtClave.Text;
            EmpleadoVO empleado = new LoginBUS().Log(logeo, ref EsValido);

            if (EsValido)
            {
                AuditoriaVO auditoria = new AuditoriaVO();
                auditoria.idEmpleado = empleado.IdEmpleado;
                auditoria.idRegistro = empleado.IdEmpleado;
                auditoria.tabla = "Empleado";
                auditoria.tipo = "LOGIN EXITOSO";
                auditoria.fecha = DateTime.Now.ToLocalTime();
                new AuditoriaBUS().AgregarAuditoria(auditoria);
                WinForm.MensajeBox(this, "Acceso al Sistema", "Bienvenido : " + empleado.Nombres + " " + empleado.Apellidos, MensajeBox.informacion);
                SetCodigoEmpleado(empleado.IdEmpleado);
                this.DialogResult = DialogResult.OK;
                this.Close();
               // new PrincipalUI(empleado.IdEmpleado).Show();
                
            }
            else
            {
                WinForm.MensajeBox(this, "Acceso al Sistema", "Usuario Invalido!", MensajeBox.error);
                AuditoriaVO auditoria = new AuditoriaVO();
                auditoria.idEmpleado = 1;
                auditoria.idRegistro = 1;
                auditoria.tabla = "Empleado";
                auditoria.tipo = "LOGIN FALLIDO : "+txtDni.Text;
                auditoria.fecha = DateTime.Now.ToLocalTime();
                new AuditoriaBUS().AgregarAuditoria(auditoria);
            }
        }

        private void radLabel4_Click(object sender, EventArgs e)
        {

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
