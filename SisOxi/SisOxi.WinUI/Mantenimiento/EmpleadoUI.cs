using SisOxi.BUS;
using SisOxi.BUS.Seguridad;
using SisOxi.VO;
using SisOxi.VO.Seguridad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using WinFormTelerikDS;

namespace SisOxi.WinUI
{
    public partial class EmpleadoUI : Telerik.WinControls.UI.RadForm
    {

        #region Variables Privadas

        private PrincipalUI principalUI;
       
        private bool IsModificarActivo = false;
        private bool IsNuevoActivo = false;
        private bool IsCboClicked = false;
        private bool validarBlanco = true;
        private int codigoEmpleado;
        #endregion

        public EmpleadoUI()
        {
            InitializeComponent();
        }

        public EmpleadoUI(PrincipalUI p)
        {
            InitializeComponent();
            principalUI = p;
        }

        private void EmpleadoUI_Load(object sender, EventArgs e)
        {
            btnCerrar.ButtonElement.Shape = new EllipseShape();
            btnInicio.ButtonElement.Shape = new EllipseShape();
            CargarFormulario();
            BuscarEmpleado(txtBuscar.Text);
            
            //WinForm.TabEnterEnForm(this);
            dgvEmpleado.AutoGenerateColumns = false;
        }


        private void BuscarEmpleado(string apellidos)
        {
            try
            {
              dgvEmpleado.DataSource = new EmpleadoBUS().BuscarEmpleado(apellidos);
     
            }
            catch (Exception)
            {
                
                throw;
            }
          
        }

        //private void TabEnter(KeyPressEventArgs e)
        //{ 
        //   if (e.KeyChar == (char)(Keys.Enter))
        //      {
        //      e.Handled = true; 
        //      SendKeys.Send("{TAB}");
        //      }
          
        //}

        private bool ValidarCasillasBlanco()
        {
            epCasillasBlanco.SetError(txtNombre,"");
            epCasillasBlanco.SetError(txtApellido,"");
            epCasillasBlanco.SetError(txtNombre,"");
            epCasillasBlanco.SetError(txtClave,"");

            if (txtNombre.Text=="") 
	        {
		    epCasillasBlanco.SetError(txtNombre,"Debe Ingresar un Nombre");
            validarBlanco=false;
	        }

            if (txtApellido.Text == "")
            {
                epCasillasBlanco.SetError(txtApellido, "Debe Ingresar un Apellido");
                validarBlanco = false;
            }

            if (txtNombre.Text == "")
            {
                epCasillasBlanco.SetError(txtNombre, "Debe Ingresar un DNI");
                validarBlanco = false;
            }

            if (txtClave.Text == "")
            {
                epCasillasBlanco.SetError(txtClave, "Debe Ingresar una Clave");
                validarBlanco = false;
            }

            return validarBlanco;

        }

        private void CargarFormulario()
        {
           // WinFormTelerikDS.WinForm.LlamarFormAPanel(this, principal.pnlContenido);
            WinFormTelerikDS.WinForm.ConvertirBordesRedondeadosLabelEnForm(this);
            WinForm.TabEnterEnForm(this);
            WinForm.BloquearControlesEnForm(this);
            txtBuscar.Enabled = true;
            WinForm.PermitirSoloNumeros(txtDNI);

            
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            
            epCasillasBlanco.SetError(txtDNI, "");
            if (IsNuevoActivo)
            {
             
                    if (ValidarCasillasBlanco())
                    {
                        if (txtDNI.Text.Length <= 11)
                        {
                            if (WinForm.MensajeBox(this, "Empleado", "¿Desea Guardar al Empleado?", MensajeBox.pregunta) == DialogResult.Yes)
                            {
                                AgregarEmpleado();
                                BuscarEmpleado(txtBuscar.Text);    
                                WinForm.MensajeBox(this, "Empleado", "Empleado Agregado!", MensajeBox.advertencia);
                                WinForm.LimpiarControlesEnForm(this);
                            }

                         
                        }
                        else
                        {
                           
                            epCasillasBlanco.SetError(txtNombre, "Debe ser menor o igual a 11 Digitos");
                        }
                     }
                     else
                     {
                            //WinForm.EventoClickBotonCancelar(btnNuevo, btnModificar, btnCancelar, ref IsNuevoActivo, ref IsModificarActivo);
                     }
                        
                 
                WinForm.EventoClickBotonNuevo(btnNuevo, btnModificar, btnCancelar, ref IsNuevoActivo, ref IsModificarActivo);
            }
            else
            {
                WinForm.DesbloquearControlesEnForm(this);
                WinForm.LimpiarControlesEnForm(this);
                WinForm.EventoClickBotonNuevo(btnNuevo, btnModificar, btnCancelar, ref IsNuevoActivo, ref IsModificarActivo);
            }
        }

        private void AgregarEmpleado()
        {
            EmpleadoVO empleado = new EmpleadoVO();
            empleado.Nombres = txtNombre.Text;
            empleado.Apellidos = txtApellido.Text;
            empleado.DireccionDomiciliaria = txtDireccion.Text;
            empleado.Fono = txtTelefono.Text;
            empleado.Dni = txtDNI.Text;
            empleado.Clave = txtClave.Text;
            empleado.Cargo = cboCargo.Text;
            int id = new EmpleadoBUS().AgregarEmpleado(empleado);
            AuditoriaVO auditoria = new AuditoriaVO();
            auditoria.idEmpleado = PrincipalUI.idEmpleadogbl;
            auditoria.idRegistro = id;
            auditoria.tabla = "Empleado";
            auditoria.tipo = "INSERT";
            auditoria.fecha = DateTime.Now.ToLocalTime();
            new AuditoriaBUS().AgregarAuditoria(auditoria);

        }

        private void ModificarEmpleado()
        {
            EmpleadoVO empleado = new EmpleadoVO();
            empleado.IdEmpleado = codigoEmpleado;
            empleado.Nombres = txtNombre.Text;
            empleado.Apellidos = txtApellido.Text;
            empleado.DireccionDomiciliaria = txtDireccion.Text;
            empleado.Fono = txtTelefono.Text;
            empleado.Dni = txtDNI.Text;
            empleado.Clave = txtClave.Text;
            empleado.Cargo = cboCargo.Text;
            new EmpleadoBUS().ModificarEmpleado(empleado);
            AuditoriaVO auditoria = new AuditoriaVO();
            auditoria.idEmpleado = PrincipalUI.idEmpleadogbl;
            auditoria.idRegistro = empleado.IdEmpleado;
            auditoria.tabla = "Empleado";
            auditoria.tipo = "UPDATE";
            auditoria.fecha = DateTime.Now.ToLocalTime();
            new AuditoriaBUS().AgregarAuditoria(auditoria);
        }

        private void lblPacient_Click(object sender, EventArgs e)
        {
        
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            //TabEnter(e);
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtCargo_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (IsModificarActivo)
            {
                epCasillasBlanco.SetError(txtNombre, "");

                if (ValidarCasillasBlanco())
                {
                    if (txtNombre.Text.Length <= 11)
                    {
                        if (WinForm.MensajeBox(this, "Empleado", "¿Desea Modificar al Empleado?", MensajeBox.pregunta) == DialogResult.Yes)
                        {
                            ModificarEmpleado();
                            BuscarEmpleado(txtBuscar.Text);
                            WinForm.MensajeBox(this, "Empleado", "Empleado Modificado!", MensajeBox.advertencia);
                            WinForm.BloquearControlesEnForm(this);
                        }


                    }
                    else
                    {

                        epCasillasBlanco.SetError(txtNombre, "Debe ser menor o igual a 11 Digitos");
                    }
                }
                else
                {
                    //WinForm.EventoClickBotonCancelar(btnNuevo, btnModificar, btnCancelar, ref IsNuevoActivo, ref IsModificarActivo);
                }


                WinForm.EventoClickBotonModificar(btnNuevo, btnModificar, btnCancelar, ref IsNuevoActivo, ref IsModificarActivo);
            }
            else
            {
                WinForm.DesbloquearControlesEnForm(this);
                WinForm.EventoClickBotonModificar(btnNuevo, btnModificar, btnCancelar, ref IsNuevoActivo, ref IsModificarActivo);
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

            BuscarEmpleado(txtBuscar.Text);    
                
        }

        private void dgvEmpleado_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if(DialogResult.Yes == WinForm.MensajeBox(this,"Cancelar","¿Realmente desea cancelar la Operacion?",MensajeBox.pregunta));
            {
                WinForm.EventoClickBotonCancelar(btnNuevo,btnModificar,btnCancelar,ref IsNuevoActivo,ref IsModificarActivo);
                WinForm.BloquearControlesEnForm(this);
                WinForm.LimpiarControlesEnForm(this);
            }
        }

        private void dgvEmpleado_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            if (dgvEmpleado.SelectedRows.Count > 0)
            {
                codigoEmpleado = Convert.ToInt32(dgvEmpleado.SelectedRows[0].Cells[0].Value);
                txtNombre.Text = Convert.ToString(dgvEmpleado.SelectedRows[0].Cells[1].Value);
                txtApellido.Text = Convert.ToString(dgvEmpleado.SelectedRows[0].Cells[2].Value);
                txtDNI.Text = dgvEmpleado.SelectedRows[0].Cells[3].Value.ToString();
                cboCargo.SelectedIndex = cboCargo.FindStringExact(Convert.ToString(dgvEmpleado.SelectedRows[0].Cells[4].Value));
                txtDireccion.Text = Convert.ToString(dgvEmpleado.SelectedRows[0].Cells[5].Value);
                txtTelefono.Text = Convert.ToString(dgvEmpleado.SelectedRows[0].Cells[6].Value);
                txtClave.Text = Convert.ToString(dgvEmpleado.SelectedRows[0].Cells[7].Value);
                lblTitulo.Text = "  Empleado : "+txtNombre.Text +" " +txtApellido.Text;

            }

            btnModificar.Enabled = true;

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarEmpleado(txtBuscar.Text); 
        }

        private void txtBuscar_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            principalUI.pnlContenido.Controls.Clear();
        }

        private void radButton8_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == WinForm.MensajeBox(this, "Salir de la Aplicacion", "¿Desea salir de la Aplicacion?", MensajeBox.pregunta))
            {
                Application.Exit();
            }
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == WinForm.MensajeBox(this, "Cerrar Ventana", "¿Desea Cerrar esta ventana?", MensajeBox.pregunta))
            {
                this.Close();
            }
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

    }
}
