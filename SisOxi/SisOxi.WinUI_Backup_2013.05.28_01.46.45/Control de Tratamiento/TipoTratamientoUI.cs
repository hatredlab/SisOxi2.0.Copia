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
    public partial class TipoTratamientoUI : Telerik.WinControls.UI.RadForm
    {
        private PrincipalUI principalUI;
        private HistoriaClinicaUI historiaClinicaUI;
        private int PKHistoriaClinica;
        private DataTable DTImpresionDiagnostica;
        private bool IsNuevo;

        public TipoTratamientoUI(int PKHC,PrincipalUI P)
        {
            InitializeComponent();
            PKHistoriaClinica = PKHC;
            principalUI = P;
        }

        public TipoTratamientoUI(bool isNuevoX, HistoriaClinicaUI historiaClinicaUIX, DataTable ImpresionDianostica)
        {
            InitializeComponent();
            historiaClinicaUI = historiaClinicaUIX;
            DTImpresionDiagnostica = ImpresionDianostica;
            IsNuevo = isNuevoX;
        }

        private void TipoTratamientoUI_Load(object sender, EventArgs e)
        {
            CargarFormulario();
        }

        private void CargarFormulario()
        {
            WinFormTelerikDS.WinForm.ConvertirBordesRedondeadosLabelEnForm(this);
            CargarComboTipoTratamiento();
            CargarComboImpresionDiagnostica();
        }

        private void CargarComboTipoTratamiento()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("tipoTratamiento");
            string[] estadocivil = { "Tratamiento Camara Hiperbárica", "Tratamiento Alterno" };
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
            cboTipoTratamiento.Text = "--Seleccione--";
            cboTipoTratamiento.SelectedIndex = -1; 
        }

        private void CargarComboImpresionDiagnostica()
        {
            cboImpresionDiagnostica.DataSource = DTImpresionDiagnostica;
            cboImpresionDiagnostica.DisplayMember = "nombre";
            cboImpresionDiagnostica.ValueMember = "idImpresionDiagnostica";
            cboImpresionDiagnostica.AutoCompleteDataSource = DTImpresionDiagnostica;
            cboImpresionDiagnostica.DropDownListElement.AutoCompleteDataSource = DTImpresionDiagnostica;
            cboImpresionDiagnostica.DropDownListElement.AutoCompleteDisplayMember = "nombre";
            cboImpresionDiagnostica.DropDownStyle = RadDropDownStyle.DropDown;
            cboImpresionDiagnostica.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboImpresionDiagnostica.DropDownListElement.AutoCompleteSuggest.SuggestMode = SuggestMode.Contains;
        }

        private void radButton1_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboTipoTratamiento.SelectedIndex == 0)
                {
                    new TratamientoCamaraHiperbaricaUI(true, historiaClinicaUI, cboImpresionDiagnostica.SelectedValue.ToString().ToInt()).Show();
                    this.Close();
                }
                else
                {
                    new TratamientoAlternoUI(true, historiaClinicaUI, cboImpresionDiagnostica.SelectedValue.ToString().ToInt()).Show();
                    this.Close();
                }
            }
            catch(Exception ex)
            {
                if (ex is ExcepcionesApp)
                {
                    WinForm.MensajeBox(this, "Validacion de Informacion", "Advertencia : " + ex.Message, MensajeBox.advertencia);
                }
                else
                {
                    WinForm.MensajeBox(this, "Error de Sistema", "Ocurrio un Error :\n" + ex.Message, MensajeBox.error);
                }
            }
        }

        private void cboImpresionDiagnostica_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            CargarComboTipoTratamiento();
        }
    }
}
