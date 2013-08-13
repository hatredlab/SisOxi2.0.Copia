using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace SisOxi.WinUI
{
    public partial class rptPacienteConTratamiento : Telerik.WinControls.UI.RadForm
    {
        public rptPacienteConTratamiento()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
            this.reportViewer1.RefreshReport();
        }

        private void rptPacienteConTratamiento_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'SisOxibariterapiaDataSet.spr_ReporteEnfermedadesPorSexo' Puede moverla o quitarla según sea necesario.
            
            // TODO: esta línea de código carga datos en la tabla 'SisOxibariterapiaDataSet.spr_ReporteEnfermedadesPorSexo' Puede moverla o quitarla según sea necesario.
           
            // TODO: esta línea de código carga datos en la tabla 'SisOxibariterapiaDataSet.spr_ReporteEnfermedadesPorSexo' Puede moverla o quitarla según sea necesario.
            //this.spr_ReporteEnfermedadesPorSexoTableAdapter.Fill(this.SisOxibariterapiaDataSet.spr_ReporteEnfermedadesPorSexo);
            SisOxi.WinUI.Reportes_Y_Consultas.ReporteDSTableAdapters.spr_ReporteEnfermedadesPorSexoTableAdapter adapter = new SisOxi.WinUI.Reportes_Y_Consultas.ReporteDSTableAdapters.spr_ReporteEnfermedadesPorSexoTableAdapter();
            SisOxi.WinUI.Reportes_Y_Consultas.ReporteDS.spr_ReporteEnfermedadesPorSexoDataTable  dt = new SisOxi.WinUI.Reportes_Y_Consultas.ReporteDS.spr_ReporteEnfermedadesPorSexoDataTable();
            adapter.Fill(dt);
            ////ReportParameter rp = new ReportParameter("categ", Convert.ToString(cboCategoria.SelectedValue));//
            ////this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { rp });
            ReportDataSource rpd = new ReportDataSource("DataSet1", (DataTable)dt);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rpd);
            reportViewer1.LocalReport.Refresh();
            reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();

        }
    }
}
