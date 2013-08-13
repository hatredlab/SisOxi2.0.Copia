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
    public partial class Reporte : Telerik.WinControls.UI.RadForm
    {
        public Reporte()
        {
            InitializeComponent();
        }

        private void Reporte_Load(object sender, EventArgs e)
        {
            
            //DataTable data = new SisOxibariterapiaDataSet.spr_ReporteEnfermedadPorEnfermedadesAsociadasDataTable(); 	//This would be your own DataTable, 
            ////none particular features requested.
            //string dsName = "SisOxibariterapiaDataSet", displayName = ""; // These are your display name 
            
            //ReportDataSource ds = new ReportDataSource(dsName, data);
            
            //WinFormTelerikDS.GeneradorReporte gen = new WinFormTelerikDS.GeneradorReporte(data,dsName);
            
            //reportViewer1.LocalReport.DataSources.Add(ds);
            //reportViewer1.LocalReport.DisplayName = displayName;
            //reportViewer1.LocalReport.LoadReportDefinition(gen.GeneraReport());
            //this.spr_ReporteEnfermedadPorEnfermedadesAsociadasTableAdapter.Fill(this.SisOxibariterapiaDataSet.spr_ReporteEnfermedadPorEnfermedadesAsociadas,1);
           
        }
    }
}
