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
        List<bool> tratamiento = new List<bool>();
        public TipoTratamientoUI(int PKHC,PrincipalUI P)
        {
            InitializeComponent();
            PKHistoriaClinica = PKHC;
            principalUI = P;
        }

        public TipoTratamientoUI(bool isNuevoX, HistoriaClinicaUI historiaClinicaUIX, DataTable ImpresionDianostica,List<bool> tr)
        {
            InitializeComponent();
            historiaClinicaUI = historiaClinicaUIX;
            DTImpresionDiagnostica = ImpresionDianostica;
            IsNuevo = isNuevoX;
            tratamiento = tr;
        }

        private void TipoTratamientoUI_Load(object sender, EventArgs e)
        {
            CargarFormulario();
            CargarLstImpresionDIagnostica();
        }

        private void CargarLstImpresionDIagnostica()
        {
            lstImpresionDiagnostica.DataSource = DTImpresionDiagnostica;
            List<int> columnasMostradas = new List<int> { 5 };
            for (int i = 0; i < lstImpresionDiagnostica.Columns.Count; i++)
            {
                if (!columnasMostradas.Contains(i))
                {
                    lstImpresionDiagnostica.Columns[i].Visible = false;
                }

            }
            lstImpresionDiagnostica.AllowEdit = false;
            lstImpresionDiagnostica.Columns[5].HeaderText = "Impresión Diagnóstica";
            lstImpresionDiagnostica.Columns[5].Width = 533;
            lstImpresionDiagnostica.Refresh();
            lstImpresionDiagnostica.Select();
        }

        private void CargarFormulario()
        {
            WinFormTelerikDS.WinForm.ConvertirBordesRedondeadosLabelEnForm(this);
            //CargarComboTipoTratamiento();
          //  CargarComboImpresionDiagnostica();
        }

        private void CargarComboTipoTratamiento()
        {
            lstImpresionDiagnostica.Refresh();
            DataTable dt = new DataTable();
            dt.Columns.Add("tipoTratamiento");
            string[] estadocivil = new string[2];
            ListViewSelectedItemCollection col = lstImpresionDiagnostica.SelectedItems;
            foreach (ListViewDataItem item in col)
            {
                if (item[8].ToString() == "true")
                {
                    estadocivil[0] = "Tratamiento Alterno";
                }
                else
                {
                    estadocivil[0] = "Tratamiento Camara Hiperbárica";
                    estadocivil[1] = "Tratamiento Alterno";

                }                
            }
           
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

        //private void CargarComboImpresionDiagnostica()
        //{
        //    cboImpresionDiagnostica.DataSource = DTImpresionDiagnostica;
        //    cboImpresionDiagnostica.DisplayMember = "nombre";
        //    cboImpresionDiagnostica.ValueMember = "idImpresionDiagnostica";
        //    cboImpresionDiagnostica.AutoCompleteDataSource = DTImpresionDiagnostica;
        //    cboImpresionDiagnostica.DropDownListElement.AutoCompleteDataSource = DTImpresionDiagnostica;
        //    cboImpresionDiagnostica.DropDownListElement.AutoCompleteDisplayMember = "nombre";
        //    cboImpresionDiagnostica.DropDownStyle = RadDropDownStyle.DropDown;
        //    cboImpresionDiagnostica.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        //    cboImpresionDiagnostica.DropDownListElement.AutoCompleteSuggest.SuggestMode = SuggestMode.Contains;
        //}

        private void radButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ListViewSelectedItemCollection col = lstImpresionDiagnostica.SelectedItems;
            int PKImpresionDiagnostica=0;
            foreach (ListViewDataItem item in col)
            {
                PKImpresionDiagnostica = item[0].ToString().ToInt();
            }
            try
            {
                if (cboTipoTratamiento.Text.ValidarComboBox<string>(cboTipoTratamiento, "Tipo de Tratamiento") == "Tratamiento Camara Hiperbárica")
                {
                    new TratamientoCamaraHiperbaricaUI(true, historiaClinicaUI, PKImpresionDiagnostica).ShowDialog();
                    this.Close();
                }
                else
                {
                    new TratamientoAlternoUI(true, historiaClinicaUI, PKImpresionDiagnostica).ShowDialog();
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
           // CargarComboTipoTratamiento();
        }

        private void lstImpresionDiagnostica_CellFormatting(object sender, ListViewCellFormattingEventArgs e)
        {

        }

        private void lstImpresionDiagnostica_CellFormatting_1(object sender, ListViewCellFormattingEventArgs e)
        {
            if (e.CellElement is DetailListViewHeaderCellElement)
            {
                e.CellElement.BackColor = Color.FromArgb(17, 105, 133);
                e.CellElement.ForeColor = Color.FromArgb(191, 219, 255);
                e.CellElement.BorderColor = Color.FromArgb(17, 105, 133);
                e.CellElement.Font = new Font(e.CellElement.Font.FontFamily.Name, 14);
                e.CellElement.NumberOfColors = 1;
            }
            else
            {
                e.CellElement.ResetValue(LightVisualElement.BackColorProperty);
            }
        }

        private void lstImpresionDiagnostica_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarComboTipoTratamiento();
            
        }

        private void lstImpresionDiagnostica_SelectedItemChanged(object sender, EventArgs e)
        {
            
        }
    }
}
