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
    public partial class EnfermedadUI : Telerik.WinControls.UI.RadForm
    {

        #region Variables Privadas
        private bool IsModificarActivo = false;
        private bool IsNuevoActivo = false;
        private bool IsCboClicked = false;
        private bool IsCboTipoEnfermedadClicked = false;
        private bool IsNuevoAsociado = false;
        private bool IsModificarAsociado = false;
        #endregion

        public EnfermedadUI()
        {
            InitializeComponent();
        }

        private void EnfermedadUI_Load(object sender, EventArgs e)
        {
            CargarFormulario();
            CargarCboEnfermedad();
            WinForm.TabEnterEnForm(this);
        }

        private void CargarFormulario()
        {
            WinFormTelerikDS.WinForm.ConvertirBordesRedondeadosLabelEnForm(this);
       
            radLabel3.Text = @"  Decripcion de la 
     Enfermedad";
            CargarComboEnfermedad();
            WinForm.EventoClickBotonCancelar(btnNuevo, btnModificar, btnCancelar, ref IsNuevoActivo, ref IsModificarActivo);
            ResetEstadoControles();
        }

        private void ResetEstadoControles()
        {
            WinForm.BloquearControlesEnForm(this);
            btnModificar.Enabled = true;
            cboEnfermedad.Enabled = true;
            cboTipoEnfermedad.Enabled = true;

        }

        private void NuevoClickEstadoControles()
        {
            WinForm.DesbloquearControlesEnForm(this);
            cboEnfermedad.Enabled = false;
            cboEnfermedad.Text = "--Seleccione--";
        }

        private void ModificarClickEstadoControles()
        {
            WinForm.DesbloquearControlesEnForm(this);
            cboEnfermedad.Enabled = false;
           
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (IsNuevoActivo)
            {
                if (WinForm.MensajeBox(this, "Enfermedad", "¿Desea Guardar la Enfermedad?", MensajeBox.pregunta) == DialogResult.Yes)
                {
                    AgregarEnfermedad();
                    WinForm.MensajeBox(this, "Enfermedad", "Enfermedad Agregada!", MensajeBox.advertencia);
                    CargarComboEnfermedad();
                    WinForm.LimpiarControlesEnForm(this);
                    ResetEstadoControles();
                }
             
            }
            else
            {
                WinForm.LimpiarControlesEnForm(this);
                WinForm.EventoClickBotonNuevo(btnNuevo, btnModificar, btnCancelar, ref IsNuevoActivo, ref IsModificarActivo);
                NuevoClickEstadoControles();
            }
        }

        #region Metodos Base de Datos

        private void AgregarEnfermedad()
        {
            EnfermedadVO enfermedad = new EnfermedadVO();
            enfermedad.Nombre = txtNombre.Text;
            enfermedad.Descripcion = txtDescripcion.Text;
            enfermedad.Tipo = cboTipoEnfermedad.Text;
            int id = new EnfermedadBUS().AgregarEnfermedad(enfermedad);
            AuditoriaVO auditoria = new AuditoriaVO();
            auditoria.idEmpleado = PrincipalUI.idEmpleadogbl;
            auditoria.idRegistro = id;
            auditoria.tabla = "Enfermedad";
            auditoria.tipo = "INSERT";
            auditoria.fecha = DateTime.Now.ToLocalTime();
            new AuditoriaBUS().AgregarAuditoria(auditoria);
            
        }

        private void ModificarEnfermedad()
        {
            EnfermedadVO enfermedad = new EnfermedadVO();
            enfermedad.IdEnfermedad = Convert.ToInt32(cboEnfermedad.SelectedValue);
            enfermedad.Nombre = txtNombre.Text;
            enfermedad.Descripcion = txtDescripcion.Text;
            enfermedad.Tipo = cboTipoEnfermedad.Text;
            new EnfermedadBUS().ModificarEnfermedad(enfermedad);
            AuditoriaVO auditoria = new AuditoriaVO();
            auditoria.idEmpleado = PrincipalUI.idEmpleadogbl;
            auditoria.idRegistro = enfermedad.IdEnfermedad;
            auditoria.tabla = "Enfermedad";
            auditoria.tipo = "UPDATE";
            auditoria.fecha = DateTime.Now.ToLocalTime();
            new AuditoriaBUS().AgregarAuditoria(auditoria);
        }

        private void CargarComboEnfermedad()
        {
            DataTable dt = new EnfermedadBUS().BuscarEnfermedad();
            cboEnfermedad.DisplayMember = "nombre";
            cboEnfermedad.ValueMember = "idEnfermedad";
            cboEnfermedad.DataSource = dt;
            cboEnfermedad.Text = "--Seleccione--";
            cboEnfermedad.SelectedIndex = -1;
            cboEnfermedad.DataSource = dt;
            cboEnfermedad.DisplayMember = "nombre";
            cboEnfermedad.AutoCompleteDataSource = dt;
            cboEnfermedad.DropDownListElement.AutoCompleteDataSource = dt;
            cboEnfermedad.DropDownListElement.AutoCompleteDisplayMember = "nombre";
            cboEnfermedad.DropDownStyle = RadDropDownStyle.DropDown;
            cboEnfermedad.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboEnfermedad.DropDownListElement.AutoCompleteSuggest.SuggestMode = SuggestMode.Contains;
        }

        private void BuscarEnfermedadPorID(int idEnfermedad)
        {
            EnfermedadVO enfermedad = new EnfermedadBUS().BuscarEnfermedadPorID(idEnfermedad);
            txtNombre.Text = enfermedad.Nombre;
            txtDescripcion.Text = enfermedad.Descripcion;
            cboTipoEnfermedad.SelectedIndex = cboTipoEnfermedad.FindStringExact(enfermedad.Tipo);
        }

        #endregion

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (cboEnfermedad.Text != "--Seleccione--")
            {
                if (IsModificarActivo)
                {
                    if (WinForm.MensajeBox(this, "Enfermedad", "¿Desea Modificar la Enfermedad?", MensajeBox.pregunta) == DialogResult.Yes)
                    {
                        ModificarEnfermedad();
                        WinForm.MensajeBox(this, "Enfermedad", "Enfermedad Modificada!", MensajeBox.advertencia);
                        CargarComboEnfermedad();
                        WinForm.LimpiarControlesEnForm(this);
                        WinForm.EventoClickBotonModificar(btnNuevo, btnModificar, btnCancelar, ref IsNuevoActivo, ref IsModificarActivo);
                        ResetEstadoControles();
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
                    ModificarClickEstadoControles();
                }
            }
            else
            {
                WinForm.MensajeBox(this, "Enfermedad", "Seleccione la Enfermedad que desea Modificar!", MensajeBox.error);
            }
        }

        private void cboEnfermedad_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            if (IsCboClicked == true)
            {
                BuscarEnfermedadPorID(Convert.ToInt32(cboEnfermedad.SelectedValue));
                IsCboClicked = false;
            }
            //else
            //{
            //    IsCboClicked = true;
            //}
       }

        private void cboEnfermedad_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void cboEnfermedad_PopupClosed(object sender, Telerik.WinControls.UI.RadPopupClosedEventArgs args)
        {
            IsCboClicked = args.CloseReason == RadPopupCloseReason.Mouse;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            WinForm.LimpiarControlesEnForm(this);
            WinForm.EventoClickBotonCancelar(btnNuevo, btnModificar, btnCancelar, ref IsNuevoActivo, ref IsModificarActivo);
            ResetEstadoControles();
        }

        private void rgbSesiones_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevaEnfermedadAsociada_Click(object sender, EventArgs e)
        {
            if (IsNuevoAsociado)
            {
                if (WinForm.MensajeBox(this, "Enfermedad", "¿Desea Guardar la Enfermedad?", MensajeBox.pregunta) == DialogResult.Yes)
                {
                    AgregarEnfermedad();
                    WinForm.MensajeBox(this, "Enfermedad", "Enfermedad Agregada!", MensajeBox.advertencia);
                    CargarComboEnfermedad();
                    WinForm.LimpiarControlesEnForm(this);
                }

            }
            else
            {
                WinForm.LimpiarControlesEnForm(this);
                WinForm.EventoClickBotonNuevo(btnNuevo, btnModificar, btnCancelar, ref IsNuevoActivo, ref IsModificarActivo);
            }
        }

        private void CargarCboEnfermedad()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("tipo");
            string[] estadocivil = { "Enfermedad Principal", "Enfermedad Asociada"};
            for (int i = 0; i < estadocivil.Length; i++)
            {
                DataRow dr = dt.NewRow();
                dr[0] = estadocivil[i];
                dt.Rows.Add(dr);
            }

            cboTipoEnfermedad.DataSource = dt;
            cboTipoEnfermedad.DisplayMember = "tipo";
            cboTipoEnfermedad.Text = "--Seleccione--";
            cboTipoEnfermedad.SelectedIndex = -1;
            cboTipoEnfermedad.AutoCompleteDataSource = dt;
            cboTipoEnfermedad.DropDownListElement.AutoCompleteDataSource = dt;
            cboTipoEnfermedad.DropDownListElement.AutoCompleteDisplayMember = "estadoCivil";
            cboTipoEnfermedad.DropDownStyle = RadDropDownStyle.DropDown;
            cboTipoEnfermedad.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboTipoEnfermedad.DropDownListElement.AutoCompleteSuggest.SuggestMode = SuggestMode.Contains;
        }

        private void cboTipoEnfermedad_PopupClosed(object sender, RadPopupClosedEventArgs args)
        {
            IsCboTipoEnfermedadClicked = args.CloseReason == RadPopupCloseReason.Mouse;
        }

        private void cboTipoEnfermedad_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            if (IsCboTipoEnfermedadClicked == true)
            {
                if(cboTipoEnfermedad.SelectedIndex == 0)
                {
                    CargarComboEnfermedad();
                    txtDescripcion.Text = string.Empty;
                    txtNombre.Text = string.Empty;
                }
                else
                {
                    CargarComboEnfermedadAsociada();
                    txtDescripcion.Text = string.Empty;
                    txtNombre.Text = string.Empty;
                }
                IsCboTipoEnfermedadClicked = false;
            }
        }

        private void CargarComboEnfermedadAsociada()
        {
            DataTable dt = new EnfermedadBUS().BuscarEnfermedadAsociada();
            cboEnfermedad.DisplayMember = "nombre";
            cboEnfermedad.ValueMember = "idEnfermedad";
            cboEnfermedad.DataSource = dt;
            cboEnfermedad.Text = "--Seleccione--";
            cboEnfermedad.SelectedIndex = -1;
            cboEnfermedad.DataSource = dt;
            cboEnfermedad.DisplayMember = "nombre";
            cboEnfermedad.AutoCompleteDataSource = dt;
            cboEnfermedad.DropDownListElement.AutoCompleteDataSource = dt;
            cboEnfermedad.DropDownListElement.AutoCompleteDisplayMember = "nombre";
            cboEnfermedad.DropDownStyle = RadDropDownStyle.DropDown;
            cboEnfermedad.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboEnfermedad.DropDownListElement.AutoCompleteSuggest.SuggestMode = SuggestMode.Contains;
        }
    }
}
