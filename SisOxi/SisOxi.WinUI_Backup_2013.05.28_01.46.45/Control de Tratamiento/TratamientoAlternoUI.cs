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
    public partial class TratamientoAlternoUI : Telerik.WinControls.UI.RadForm
    {

        #region Variables Privadas
        private int PKImpresionDiagnostica;
        private bool IsNuevo = false;
        private TratamientoAlternoVO tratamientoAlterno;
        private HistoriaClinicaUI historiaClinicaUI;
        #endregion

        public TratamientoAlternoUI()
        {
            InitializeComponent();
        }

        public TratamientoAlternoUI(bool isNuevoX,HistoriaClinicaUI historiaClinicaUIX,int PK,TratamientoAlternoVO tratamientoAlternoX)
        {
            InitializeComponent();
            IsNuevo = isNuevoX;
            historiaClinicaUI = historiaClinicaUIX;
            PKImpresionDiagnostica = PK;
            tratamientoAlterno = tratamientoAlternoX;
        }

        public TratamientoAlternoUI(bool isNuevoX, HistoriaClinicaUI historiaClinicaUIX, int PK)
        {
            InitializeComponent();
            IsNuevo = isNuevoX;
            historiaClinicaUI = historiaClinicaUIX;
            PKImpresionDiagnostica = PK;
            
        }

        private void TratamientoAlternoUI_Load(object sender, EventArgs e)
        {
            CargarFormulario();
            CargarComboTipoTratamiento();
            if (IsNuevo == false)
            {
                cboTipoTratamiento.SelectedIndex = cboTipoTratamiento.FindStringExact(tratamientoAlterno.TipoTratamiento);
                cboEstadoTratamiento.SelectedIndex = cboEstadoTratamiento.FindStringExact(tratamientoAlterno.EstadoTratamiento);
                txtObservacionesTratamiento.Text = tratamientoAlterno.ObservacionesTratamiento;
                dtpFechaInicioTratamiento.Value = tratamientoAlterno.fechaInicioTratamiento;
            }

            
        }

        private void CargarComboTipoTratamiento()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("tipoTratamiento");
            string[] estadocivil = { "Tratamiento Medico", "Tratamiento Analgesico", "Tratamiento Antibiotico", "Tratamiento Antiflamatorio" };
            for (int i = 0; i < estadocivil.Length; i++)
            {
                DataRow dr = dt.NewRow();
                dr[0] = estadocivil[i];
                dt.Rows.Add(dr);
            }

            cboTipoTratamiento.DataSource = dt;
            cboTipoTratamiento.DisplayMember = "tipoTratamiento";
            cboTipoTratamiento.AutoCompleteDataSource = dt;
            cboTipoTratamiento.DropDownListElement.AutoCompleteDataSource = dt;
            cboTipoTratamiento.DropDownListElement.AutoCompleteDisplayMember = "tipoTratamiento";
            cboTipoTratamiento.DropDownStyle = RadDropDownStyle.DropDown;
            cboTipoTratamiento.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboTipoTratamiento.DropDownListElement.AutoCompleteSuggest.SuggestMode = SuggestMode.Contains;
        }

        

        private void CargarFormulario()
        {
            WinFormTelerikDS.WinForm.ConvertirBordesRedondeadosLabelEnForm(this);
            //WinForm.BloquearTextBoxEnForm(this);
            dtpFechaInicioTratamiento.Value = DateTime.Now;
            WinForm.TabEnterEnForm(this);
            cboEstadoTratamiento.SelectedIndex = -1;
            cboTipoTratamiento.SelectedIndex = -1;
        }

        private void AgregarTratamientoAlterno()
        {
            try
            {
                TratamientoAlternoVO tratamientoA = new TratamientoAlternoVO();
                tratamientoA.EstadoTratamiento = cboEstadoTratamiento.Text;
                tratamientoA.fechaInicioTratamiento = dtpFechaInicioTratamiento.Value;
                tratamientoA.idImpresionDiagnostica = PKImpresionDiagnostica;
                tratamientoA.ObservacionesTratamiento = txtObservacionesTratamiento.Text;
                tratamientoA.TipoTratamiento = cboTipoTratamiento.Text;
                int id = new TratamientoAlternoBUS().AgregarTratamiento(tratamientoA);
                AuditoriaVO auditoria = new AuditoriaVO();
                auditoria.idEmpleado = PrincipalUI.idEmpleadogbl;
                auditoria.idRegistro = id;
                auditoria.tabla = "Tratamiento";
                auditoria.tipo = "INSERT";
                auditoria.fecha = DateTime.Now.ToLocalTime();
                new AuditoriaBUS().AgregarAuditoria(auditoria);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ModificarTratamientoAlterno()
        {
            try
            {
                TratamientoAlternoVO tratamientoA = new TratamientoAlternoVO();
                tratamientoA.IdTratamiento = tratamientoAlterno.IdTratamiento;
                tratamientoA.EstadoTratamiento = cboEstadoTratamiento.Text;
                tratamientoA.fechaInicioTratamiento = dtpFechaInicioTratamiento.Value;
                tratamientoA.idImpresionDiagnostica = PKImpresionDiagnostica;
                tratamientoA.ObservacionesTratamiento = txtObservacionesTratamiento.Text;
                tratamientoA.TipoTratamiento = cboTipoTratamiento.Text;
                new TratamientoAlternoBUS().ModificarTratamiento(tratamientoA);
                AuditoriaVO auditoria = new AuditoriaVO();
                auditoria.idEmpleado = PrincipalUI.idEmpleadogbl;
                auditoria.idRegistro = tratamientoA.IdTratamiento;
                auditoria.tabla = "Tratamiento";
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

                if (WinForm.MensajeBox(this, "Tratamiento Alterno", "¿Desea Guardar el Tratamiento Alterno?", MensajeBox.pregunta) == DialogResult.Yes)
                {
                    AgregarTratamientoAlterno();
                    WinForm.MensajeBox(this, "Tratamiento Alterno", "Tratamiento Agregado!", MensajeBox.informacion);
                    historiaClinicaUI.CargarListViewImpresionDiagnostica();
                    this.Close();
                }
            }
            else
            {
                if (WinForm.MensajeBox(this, "Tratamiento Alterno", "¿Desea Modificar el Tratamiento Alterno?", MensajeBox.pregunta) == DialogResult.Yes)
                {
                    ModificarTratamientoAlterno();
                    WinForm.MensajeBox(this, "Tratamiento Alterno", "Tratamiento Alterno Modificado!", MensajeBox.informacion);
                    historiaClinicaUI.CargarListViewImpresionDiagnostica();
                    this.Close();
                }
            }
        }
    }
}
