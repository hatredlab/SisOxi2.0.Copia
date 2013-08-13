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
using Telerik.WinControls.UI;
using WinFormTelerikDS;

namespace SisOxi.WinUI
{
    public partial class TipoExamenGabineteUI : Telerik.WinControls.UI.RadForm
    {

        #region Variables Privadas
        private bool IsModificarActivo = false;
        private bool IsNuevoActivo = false;
        private bool IsCboClicked = false;
        #endregion

        public TipoExamenGabineteUI()
        {
            InitializeComponent();
        }

        private void TipoExamenGabineteUI_Load(object sender, EventArgs e)
        {
            CargarFormulario();
            WinForm.TabEnterEnForm(this);
        }

        private void CargarFormulario()
        {
            WinFormTelerikDS.WinForm.ConvertirBordesRedondeadosLabelEnForm(this);
            ResetControles();
            CargarComboTipoExamen();
            cboTipoExamen.Focus();
            WinForm.TabEnterEnForm(this);
        }

        private void ResetControles()
        {
            WinForm.BloquearControlesEnForm(this);
            btnModificar.Enabled = true;
            cboTipoExamen.Enabled = true;
        }

        private void NuevoClickControles()
        {
            WinForm.DesbloquearControlesEnForm(this);
            cboTipoExamen.Enabled = false;
            cboTipoExamen.Text = "--Seleccione--";

        }

        private void ModificarClickControles()
        {
            WinForm.DesbloquearControlesEnForm(this);
            cboTipoExamen.Enabled = false;

        }

        #region Metodos Base de Datos

        private void AgregarTipoExamen()
        {
            TipoExamenVO tipoExamen = new TipoExamenVO();
            tipoExamen.nombre = txtNombre.Text;
            tipoExamen.descripcion = txtDescripcion.Text;
            int id = new TipoExamenBUS().AgregarTipoExamen(tipoExamen);
            AuditoriaVO auditoria = new AuditoriaVO();
            auditoria.idEmpleado = PrincipalUI.idEmpleadogbl;
            auditoria.idRegistro = id;
            auditoria.tabla = "TipoExamen";
            auditoria.tipo = "INSERT";
            auditoria.fecha = DateTime.Now.ToLocalTime();
            new AuditoriaBUS().AgregarAuditoria(auditoria);

        }

        private void ModificarTipoExamen()
        {
            TipoExamenVO tipoExamen = new TipoExamenVO();
            tipoExamen.idTipoExamen = Convert.ToInt32(cboTipoExamen.SelectedValue);
            tipoExamen.nombre = txtNombre.Text;
            tipoExamen.descripcion = txtDescripcion.Text;
            new TipoExamenBUS().ModificarTipoExamen(tipoExamen);
            AuditoriaVO auditoria = new AuditoriaVO();
            auditoria.idEmpleado = PrincipalUI.idEmpleadogbl;
            auditoria.idRegistro = tipoExamen.idTipoExamen;
            auditoria.tabla = "ExamenGabinete";
            auditoria.tipo = "UPDATE";
            auditoria.fecha = DateTime.Now.ToLocalTime();
            new AuditoriaBUS().AgregarAuditoria(auditoria);
        }

        private void CargarComboTipoExamen()
        {
            DataTable dt = new TipoExamenBUS().BuscarTipoExamen();
            cboTipoExamen.DisplayMember = "nombre";
            cboTipoExamen.ValueMember = "idTipoExamen";
            cboTipoExamen.DataSource = dt;
            cboTipoExamen.Text = "--Seleccione--";
            cboTipoExamen.SelectedIndex = -1;
            cboTipoExamen.AutoCompleteDataSource = dt;
            cboTipoExamen.DropDownListElement.AutoCompleteDataSource = dt;
            cboTipoExamen.DropDownListElement.AutoCompleteDisplayMember = "nombre";
            cboTipoExamen.DropDownStyle = RadDropDownStyle.DropDown;
            cboTipoExamen.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboTipoExamen.DropDownListElement.AutoCompleteSuggest.SuggestMode = SuggestMode.Contains;
            
        }

        private void BuscarTipoExamenPorID(int idTipoExamen)
        {
            TipoExamenVO tipoExamen = new TipoExamenBUS().BuscarTipoExamenPorID(idTipoExamen);
            txtNombre.Text = tipoExamen.nombre;
            txtDescripcion.Text = tipoExamen.descripcion;
        }

        #endregion

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (IsNuevoActivo)
            {
                if (WinForm.MensajeBox(this, "Tipos de Exámenes de Gabinete", "¿Desea Guardar el Tipo de Examen?", MensajeBox.pregunta) == DialogResult.Yes)
                {
                    AgregarTipoExamen();
                    WinForm.EventoClickBotonNuevo(btnNuevo, btnModificar, btnCancelar, ref IsNuevoActivo, ref IsModificarActivo);
                    WinForm.MensajeBox(this, "Tipos de Exámenes de Gabinete", "Tipo de Examen Agregado!", MensajeBox.informacion);
                    CargarComboTipoExamen();
                    WinForm.LimpiarControlesEnForm(this);
                    ResetControles();
                }

            }
            else
            {
                WinForm.DesbloquearControlesEnForm(this);
                WinForm.LimpiarControlesEnForm(this);
                WinForm.EventoClickBotonNuevo(btnNuevo, btnModificar, btnCancelar, ref IsNuevoActivo, ref IsModificarActivo);
                NuevoClickControles();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (cboTipoExamen.Text != "--Seleccione--")
            {
                if (IsModificarActivo)
                {
                    if (WinForm.MensajeBox(this, "Tipos de Exámenes de Gabinete", "¿Desea Modificar el Tipo de Examen?", MensajeBox.pregunta) == DialogResult.Yes)
                    {
                        ModificarTipoExamen();
                        WinForm.MensajeBox(this, "Tipos de Exámenes de Gabinete", "Tipo de Examen Modificado!", MensajeBox.informacion);
                        CargarComboTipoExamen();
                        WinForm.LimpiarControlesEnForm(this);
                        WinForm.EventoClickBotonModificar(btnNuevo, btnModificar, btnCancelar, ref IsNuevoActivo, ref IsModificarActivo);
                        ResetControles();
                    }
                    //else
                    //{
                    //    //WinForm.EventoClickBotonCancelar(btnNuevo, btnModificar, btnCancelar, ref IsNuevoActivo, ref IsModificarActivo);
                    //    //CargarComboEnfermedad();
                    //}
                    // WinForm.EventoClickBotonModificar(btnNuevo, btnModificar, btnCancelar, ref IsNuevoActivo, ref IsModificarActivo);
                }
                else
                {
                    WinForm.EventoClickBotonModificar(btnNuevo, btnModificar, btnCancelar, ref IsNuevoActivo, ref IsModificarActivo);
                    ModificarClickControles();
                }
            }
            else
            {
                WinForm.MensajeBox(this, "Enfermedad", "Seleccione la Enfermedad que desea Modificar!", MensajeBox.advertencia);
            }
        }

        private void cboTipoExamen_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            if (IsCboClicked == true)
            {
                BuscarTipoExamenPorID(Convert.ToInt32(cboTipoExamen.SelectedValue));
                IsCboClicked = false;
            }
        }
       

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            WinForm.LimpiarControlesEnForm(this);
            WinForm.EventoClickBotonCancelar(btnNuevo, btnModificar, btnCancelar, ref IsNuevoActivo, ref IsModificarActivo);
            ResetControles();
        }

        private void cboTipoExamen_PopupClosed_1(object sender, RadPopupClosedEventArgs args)
        {
            IsCboClicked = args.CloseReason == RadPopupCloseReason.Mouse;
        }
    }
}
