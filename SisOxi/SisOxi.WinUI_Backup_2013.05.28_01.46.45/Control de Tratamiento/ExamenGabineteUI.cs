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
    public partial class ExamenGabineteUI : Telerik.WinControls.UI.RadForm
    {

        #region Variables Privadas
        private int idHistoriaClinica;
        private bool IsNuevo = false;
        private ExamenGabineteVO examenGabinete;
        private HistoriaClinicaUI historiaClinicaUI;
        #endregion

        public ExamenGabineteUI()
        {
            InitializeComponent();
        }

     

        public ExamenGabineteUI(bool isNuevoX, HistoriaClinicaUI historiaClinicaX, int idHC,ExamenGabineteVO examenGabineteX)
        {
            InitializeComponent();
            historiaClinicaUI = historiaClinicaX;
            examenGabinete = examenGabineteX;
            idHistoriaClinica = idHC;
            IsNuevo = isNuevoX;
        }

        public ExamenGabineteUI(bool isNuevoX, HistoriaClinicaUI historiaClinica, int idHC)
        {
            InitializeComponent();
            historiaClinicaUI = historiaClinica;
            idHistoriaClinica = idHC;
            IsNuevo = isNuevoX;
            
        }



        private void ExamenGabineteUI_Load(object sender, EventArgs e)
        {
            CargarFormulario();
            if (IsNuevo == false)
            {
                cboTipoExamen.SelectedIndex = cboTipoExamen.FindStringExact(examenGabinete.Nombre);
                dtFechaExamen.Value = examenGabinete.fecha;
                txtObservaciones.Text = examenGabinete.observaciones;
            }
        }
     
        
        private void CargarFormulario()
        {
            WinFormTelerikDS.WinForm.ConvertirBordesRedondeadosLabelEnForm(this);
            //WinForm.BloquearTextBoxEnForm(this);
            CargarComboTipoExamen();
            cboTipoExamen.Focus();
            WinForm.TabEnterEnForm(this);
        }
        
        private void CargarComboTipoExamen()
        {
            DataTable dt = new TipoExamenBUS().BuscarTipoExamen();
            cboTipoExamen.DisplayMember = "nombre";
            cboTipoExamen.ValueMember = "idTipoExamen";
            cboTipoExamen.DataSource = dt;
            cboTipoExamen.Text = "--Seleccione--";
            cboTipoExamen.SelectedIndex = -1;
            cboTipoExamen.DataSource = dt;
            cboTipoExamen.DisplayMember = "nombre";
            cboTipoExamen.AutoCompleteDataSource = dt;
            cboTipoExamen.DropDownListElement.AutoCompleteDataSource = dt;
            cboTipoExamen.DropDownListElement.AutoCompleteDisplayMember = "nombre";
            cboTipoExamen.DropDownStyle = RadDropDownStyle.DropDown;
            cboTipoExamen.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboTipoExamen.DropDownListElement.AutoCompleteSuggest.SuggestMode = SuggestMode.Contains;
        }

        private void AgregarExamenDeGabinete()
        {
            try
            {
                ExamenGabineteVO examenG = new ExamenGabineteVO();
                examenG.idExamenGabinete = examenG.idExamenGabinete;
                examenG.idTipoExamen = Convert.ToInt32(cboTipoExamen.SelectedValue);
                examenG.idHistoriaClinica = idHistoriaClinica;
                examenG.fecha = dtFechaExamen.Value;
                examenG.observaciones = txtObservaciones.Text;
                int id = new ExamenGabineteBUS().AgregarExamen(examenG);
                AuditoriaVO auditoria = new AuditoriaVO();
                auditoria.idEmpleado = PrincipalUI.idEmpleadogbl;
                auditoria.idRegistro = id;
                auditoria.tabla = "ExamenGabinete";
                auditoria.tipo = "INSERT";
                auditoria.fecha = DateTime.Now.ToLocalTime();
                new AuditoriaBUS().AgregarAuditoria(auditoria);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ModificarExamenDeGabinete()
        {
            try
            {
                ExamenGabineteVO examenG = new ExamenGabineteVO();
                examenG.idExamenGabinete = examenGabinete.idExamenGabinete;
                examenG.idTipoExamen = Convert.ToInt32(cboTipoExamen.SelectedValue);
                examenG.idHistoriaClinica = idHistoriaClinica;
                examenG.fecha = dtFechaExamen.Value;
                examenG.observaciones = txtObservaciones.Text;
                new ExamenGabineteBUS().ModificarExamen(examenG);
                AuditoriaVO auditoria = new AuditoriaVO();
                auditoria.idEmpleado = PrincipalUI.idEmpleadogbl;
                auditoria.idRegistro = examenG.idExamenGabinete;
                auditoria.tabla = "ExamenGabinete";
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

                if (WinForm.MensajeBox(this, "Examen de Gabinete", "¿Desea Guardar el Examen de Gabinete?", MensajeBox.pregunta) == DialogResult.Yes)
                {
                    AgregarExamenDeGabinete();
                    WinForm.MensajeBox(this, "Examen de Gabinete", "Examen de Gabinete Agregado!", MensajeBox.informacion);
                    historiaClinicaUI.CargarListViewExamenGabinete();
                    this.Close();
                }
            }
            else
            {
                if (WinForm.MensajeBox(this, "Examen de Gabinete", "¿Desea Modificar el Examen de Gabinete?", MensajeBox.pregunta) == DialogResult.Yes)
                {
                    ModificarExamenDeGabinete();
                    WinForm.MensajeBox(this, "Examen de Gabinete", "Examen de Gabinete Modificado!", MensajeBox.informacion);
                    historiaClinicaUI.CargarListViewExamenGabinete();
                    this.Close();
                }
            }
        }
    }
}
