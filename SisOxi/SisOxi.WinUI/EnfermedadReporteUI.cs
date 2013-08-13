using SisOxi.BUS;
using SisOxi.VO;
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
    public partial class EnfermedadReporteUI : Telerik.WinControls.UI.RadForm
    {

        private ReportUI reporte;
        private Reporte enumReporte;

        public EnfermedadReporteUI(ReportUI Preporte,Reporte Penumreporte)
        {
            InitializeComponent();
            reporte = Preporte;
            enumReporte = Penumreporte;
        }

        private void EnfermedadReporteUI_Load(object sender, EventArgs e)
        {
            CargarLstImpresionDIagnostica();
        }

        private void CargarLstImpresionDIagnostica()
        {
            lstImpresionDiagnostica.DataSource = new EnfermedadBUS().BuscarEnfermedad();
            List<int> columnasMostradas = new List<int> { 1 };
            for (int i = 0; i < lstImpresionDiagnostica.Columns.Count; i++)
            {
                if (!columnasMostradas.Contains(i))
                {
                    lstImpresionDiagnostica.Columns[i].Visible = false;
                }

            }
            lstImpresionDiagnostica.AllowEdit = false;
            lstImpresionDiagnostica.Columns[1].HeaderText = "Enfermedad";
            lstImpresionDiagnostica.Columns[1].Width = 533;
            lstImpresionDiagnostica.Refresh();
            lstImpresionDiagnostica.Select();
        }

        private EnfermedadVO SeleccionarItemLstImpresionDiagnostica()
        {
            EnfermedadVO enfermedad = new EnfermedadVO();
            ListViewSelectedItemCollection col = lstImpresionDiagnostica.SelectedItems;
            foreach (ListViewDataItem item in col)
            {
                //impresionDiagnostica.IdImpresionDiagnostica = Convert.ToInt32(item[0]);
                //impresionDiagnostica.Observaciones = item[1].ToString();
                //impresionDiagnostica.IdEnfermedad = Convert.ToInt32(item[2]);
                //impresionDiagnostica.IdHistoriaClinica = Convert.ToInt32(item[3]);
                //impresionDiagnostica.NombreEnfermedad = item[4].ToString();
                enfermedad = Clases.LlenarObjetoConRegistroListViewDataItem<EnfermedadVO>(item);
                //enfermedad.Nombre = item["nombre"].ToString();
            }

            return enfermedad;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (Reporte.EnfermedadesAsociadas == enumReporte)
            {
                reporte.CargarReporteEnfermedadesAsociadas(SeleccionarItemLstImpresionDiagnostica().IdEnfermedad, SeleccionarItemLstImpresionDiagnostica().Nombre);
            }
            else if(Reporte.ResultadosEnfermedad == enumReporte)
            {
                reporte.CargarReporteResultadosTratamiento(SeleccionarItemLstImpresionDiagnostica().IdEnfermedad, SeleccionarItemLstImpresionDiagnostica().Nombre);
            }
            this.Close();
        }

        private void lstImpresionDiagnostica_CellFormatting(object sender, ListViewCellFormattingEventArgs e)
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
    }
}
