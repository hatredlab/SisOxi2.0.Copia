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

namespace SisOxi.WinUI.Control_de_Tratamiento
{
    public partial class EnfermedadAsociadaUI : Telerik.WinControls.UI.RadForm
    {
        private ImpresionDiagnosticaUI impresionDiagnosticaUI;
        private ImpresionDiagnosticaVO impresionDiagnosticaVO;
        private DataTable Enfermedades;
        private bool IsNuevo = false;
        
        public EnfermedadAsociadaUI()
        {
            InitializeComponent();
        }

        public EnfermedadAsociadaUI(bool IsNuevo,ImpresionDiagnosticaVO impresionDiagnosticaVO,ImpresionDiagnosticaUI impresionDiagnosticaUI)
        {
            InitializeComponent();
            this.IsNuevo = IsNuevo;
            this.impresionDiagnosticaVO = impresionDiagnosticaVO;
            this.impresionDiagnosticaUI = impresionDiagnosticaUI;
        }

        public EnfermedadAsociadaUI(bool IsNuevo, ImpresionDiagnosticaVO impresionDiagnosticaVO, ImpresionDiagnosticaUI impresionDiagnosticaUI,DataTable Enfermedades)
        {
            InitializeComponent();
            this.IsNuevo = IsNuevo;
            this.Enfermedades = Enfermedades;
            this.impresionDiagnosticaVO = impresionDiagnosticaVO;
            this.impresionDiagnosticaUI = impresionDiagnosticaUI;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            if (IsNuevo)
            {

                if (WinForm.MensajeBox(this, "Enfermedad Asociada", "¿Desea Guardar la Enfermedad Asociada?", MensajeBox.pregunta) == DialogResult.Yes)
                {
                    AgregarEnfermedadAsociada();
                    WinForm.MensajeBox(this, "Enfermedad Asociada", "Impresión Enfermedad Asociada!", MensajeBox.informacion);
                    impresionDiagnosticaUI.CargarListViewImpresionDiagnostica();
                    this.Close();
                }
            }
            else
            {
                if (WinForm.MensajeBox(this, "Enfermedad Asociada", "¿Desea Modificar la Enfermedad Asociada?", MensajeBox.pregunta) == DialogResult.Yes)
                {
                    ModificarEnfermedadAsociada();
                    WinForm.MensajeBox(this, "Impresión Diagnóstica", "Impresión Diagnóstica Modificada!", MensajeBox.informacion);
                    impresionDiagnosticaUI.CargarListViewImpresionDiagnostica();
                    this.Close();
                    
                    
                }
            }
            

        }

        private void ModificarEnfermedadAsociada()
        {
            try
            {
                ImpresionDiagnosticaVO impresionDiagnostica = new ImpresionDiagnosticaVO();
                impresionDiagnostica.IdImpresionDiagnostica = impresionDiagnosticaVO.IdImpresionDiagnostica;
                impresionDiagnostica.idImpresionDiagnosticaAlterna = impresionDiagnosticaVO.idImpresionDiagnosticaAlterna;
                impresionDiagnostica.IdEnfermedad = Convert.ToInt32(cboEnfermedad.SelectedValue);
                impresionDiagnostica.IdHistoriaClinica = impresionDiagnosticaVO.IdHistoriaClinica;
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

        private void AgregarEnfermedadAsociada()
        {
            try
            {
                ImpresionDiagnosticaVO impresionDiagnostica = new ImpresionDiagnosticaVO();

                impresionDiagnostica.IdEnfermedad = Convert.ToInt32(cboEnfermedad.SelectedValue);
                impresionDiagnostica.idImpresionDiagnosticaAlterna = impresionDiagnosticaVO.IdImpresionDiagnostica;
                impresionDiagnostica.IdHistoriaClinica = impresionDiagnosticaVO.IdHistoriaClinica;
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


        private void EnfermedadAsociadaUI_Load(object sender, EventArgs e)
        {
            WinForm.ConvertirBordesRedondeadosLabelEnForm(this);
            if(IsNuevo)
            {
                CargarComboEnfermedadNuevo();
            }
            else
            {
                CargarComboEnfermedadModificar();
                cboEnfermedad.SelectedIndex = cboEnfermedad.FindStringExact(impresionDiagnosticaVO.NombreEnfermedad);
                txtObservaciones.Text = impresionDiagnosticaVO.Observaciones;
               
            }
        }

        private void CargarComboEnfermedadNuevo()
        {
            DataTable dt = new EnfermedadBUS().BuscarEnfermedadAsociada(Enfermedades);
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

        private void CargarComboEnfermedadModificar()
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

        private void radButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
