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
    public partial class ImpresionDiagnosticaUI : Telerik.WinControls.UI.RadForm
    {
        private int idHistoriaClinica;
        private bool IsNuevo=false;
        private ImpresionDiagnosticaVO impresionDiagnosticaX;
        private HistoriaClinicaUI historiaClinicaUI;

        public ImpresionDiagnosticaUI()
        {
            InitializeComponent();
        }

        public ImpresionDiagnosticaUI(bool isNuevo,int idHC)
        {
            InitializeComponent();
            idHistoriaClinica = idHC;
        }

        public ImpresionDiagnosticaUI(bool isNuevoX, HistoriaClinicaUI historiaClinica, int idHC)
        {
            InitializeComponent();
            IsNuevo = isNuevoX;
            historiaClinicaUI = historiaClinica;
            idHistoriaClinica = idHC;
        }

        public ImpresionDiagnosticaUI(bool isNuevoX, HistoriaClinicaUI historiaClinica, int idHC,ImpresionDiagnosticaVO iD)
        {
            InitializeComponent();
            IsNuevo = isNuevoX;
            historiaClinicaUI = historiaClinica;
            idHistoriaClinica = idHC;
            impresionDiagnosticaX = iD;
            
        }

      
        private void ImpresionDiagnosticaUI_Load(object sender, EventArgs e)
        {
            CargarFormulario();
            
        }

        private void CargarFormulario()
        {
            WinFormTelerikDS.WinForm.ConvertirBordesRedondeadosLabelEnForm(this);
            CargarComboEnfermedad();
            if (IsNuevo == false)
            {
                cboEnfermedad.SelectedIndex = cboEnfermedad.FindStringExact(impresionDiagnosticaX.NombreEnfermedad);
                txtObservaciones.Text = impresionDiagnosticaX.Observaciones;
            }
            WinForm.TabEnterEnForm(this);
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

        private void AgregarImpresionDiagnostica()
        {
            try
            {
                ImpresionDiagnosticaVO impresionDiagnostica = new ImpresionDiagnosticaVO();
               
                impresionDiagnostica.IdEnfermedad = Convert.ToInt32(cboEnfermedad.SelectedValue);
                impresionDiagnostica.IdHistoriaClinica = idHistoriaClinica;
                impresionDiagnostica.Observaciones = txtObservaciones.Text;
                int id = new ImpresionDiagnosticaBUS().AgregarImpresionDiagnostica(impresionDiagnostica);
                AuditoriaVO auditoria = new AuditoriaVO();
                auditoria.idEmpleado = PrincipalUI.idEmpleadogbl;
                auditoria.idRegistro = id;
                auditoria.tabla = "ImpresionDiagnostica";
                auditoria.tipo = "INSERT";
                auditoria.fecha = DateTime.Now.ToLocalTime();
                new AuditoriaBUS().AgregarAuditoria(auditoria);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ModificarImpresionDiagnostica()
        {
            try
            {
                ImpresionDiagnosticaVO impresionDiagnostica = new ImpresionDiagnosticaVO();
                impresionDiagnostica.IdImpresionDiagnostica = impresionDiagnosticaX.IdImpresionDiagnostica;
                impresionDiagnostica.IdEnfermedad = Convert.ToInt32(cboEnfermedad.SelectedValue);
                impresionDiagnostica.IdHistoriaClinica = idHistoriaClinica;
                impresionDiagnostica.Observaciones = txtObservaciones.Text;
                new ImpresionDiagnosticaBUS().ModificarImpresionDiagnostica(impresionDiagnostica);
                AuditoriaVO auditoria = new AuditoriaVO();
                auditoria.idEmpleado = PrincipalUI.idEmpleadogbl;
                auditoria.idRegistro = impresionDiagnostica.IdImpresionDiagnostica;
                auditoria.tabla = "ImpresionDiagnostica";
                auditoria.tipo = "UPDATE";
                auditoria.fecha = DateTime.Now.ToLocalTime();
                new AuditoriaBUS().AgregarAuditoria(auditoria);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (IsNuevo)
            {

                if (WinForm.MensajeBox(this, "Impresión Diagnóstica", "¿Desea Guardar la Impresión Diagnóstica?", MensajeBox.pregunta) == DialogResult.Yes)
                {
                    AgregarImpresionDiagnostica();
                    WinForm.MensajeBox(this, "Impresión Diagnóstica", "Impresión Diagnóstica Agregada!", MensajeBox.informacion);
                    historiaClinicaUI.CargarListViewImpresionDiagnostica();
                    this.Close();
                }
            }
            else
            {
                if (WinForm.MensajeBox(this, "Impresión Diagnóstica", "¿Desea Modificar la Impresión Diagnóstica?", MensajeBox.pregunta) == DialogResult.Yes)
                {
                    ModificarImpresionDiagnostica();
                    WinForm.MensajeBox(this, "Impresión Diagnóstica", "Impresión Diagnóstica Modificada!", MensajeBox.informacion);
                    historiaClinicaUI.CargarListViewImpresionDiagnostica();
                    this.Close();
                }
            }
                //else
                //{
                //    //WinForm.EventoClickBotonCancelar(btnNuevo, btnModificar, btnCancelar, ref IsNuevoActivo, ref IsModificarActivo);
                //    CargarComboEnfermedad();
                //}
                //WinForm.EventoClickBotonNuevo(btnNuevo, btnModificar, btnCancelar, ref IsNuevoActivo, ref IsModificarActivo);
            

        }
    }
}
