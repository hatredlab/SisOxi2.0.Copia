using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.Charting;
using Telerik.WinControls.UI;
using SisOxi.BUS;

namespace SisOxi.WinUI
{
    public partial class RadForm1 : Telerik.WinControls.UI.RadForm
    {

        List<string> conexion = new ConexionBUS().LeerConexion();
        string cadenaConexion = string.Empty;

        public RadForm1()
        {
            InitializeComponent();
        }

        private void RadForm1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'SisOxibariterapiaDataSet.spr_ReporteEnfermedadesTratamientoCamaraHiperbarica' Puede moverla o quitarla según sea necesario.
            if (conexion.Count > 3)
            {
                cadenaConexion = @"Data Source=" + conexion[0] + ";Initial Catalog=" + conexion[1] + ";user="+conexion[2]+";password="+conexion[3];
            }
            else
            {
                cadenaConexion = @"Data Source=" + conexion[0] + ";Initial Catalog=" + conexion[1] + ";Integrated Security=true";
            }

            WinFormTelerikDS.WinForm.ConvertirBordesRedondeadosLabelEnForm(this);
            // TODO: esta línea de código carga datos en la tabla 'SisOxibariterapiaDataSet.spr_ReporteEnfermedadesPorRangoEdades' Puede moverla o quitarla según sea necesario.
            //this.spr_ReporteEnfermedadesPorRangoEdadesTableAdapter.Fill(this.SisOxibariterapiaDataSet.spr_ReporteEnfermedadesPorRangoEdades);
            // TODO: esta línea de código carga datos en la tabla 'SisOxibariterapiaDataSet.spr_ReporteEnfermedadesPorSexo' Puede moverla o quitarla según sea necesario.
            //this.spr_ReporteEnfermedadesPorSexoTableAdapter.Fill(this.SisOxibariterapiaDataSet.spr_ReporteEnfermedadesPorSexo);
            // TODO: esta línea de código carga datos en la tabla 'SisOxibariterapiaDataSet.spr_ReporteEnfermedadesPorRangoEdades' Puede moverla o quitarla según sea necesario.
            //this.spr_ReporteEnfermedadesPorRangoEdadesTableAdapter.Fill(this.SisOxibariterapiaDataSet.spr_ReporteEnfermedadesPorRangoEdades);

            //this.rpvReporteEdades.RefreshReport();
            //this.rpvReporteCamaraHiperbarica.RefreshReport();
        }

        private void CargarFormularioChartPorSexo()
        {
            //conexionBD.Add(dataSource);
            //conexionBD.Add(initialCatalog);
            //conexionBD.Add(user);
            //conexionBD.Add(password);
            rcView.Series.Clear();
            BarSeries barSeries = new BarSeries("Performance", "RepresentativeName");
            barSeries.Name = "Q1";
            BarSeries barSeries2 = new BarSeries("Performance", "RepresentativeName");
            barSeries2.Name = "Q2";
            BarSeries barSeries3 = new BarSeries("Performance", "RepresentativeName");
            barSeries3.Name = "Q2";
            SisOxibariterapiaDataSetTableAdapters.spr_ReporteEnfermedadesPorSexoTableAdapter da = new SisOxibariterapiaDataSetTableAdapters.spr_ReporteEnfermedadesPorSexoTableAdapter();
            SisOxibariterapiaDataSet.spr_ReporteEnfermedadesPorSexoDataTable dt = new WinUI.SisOxibariterapiaDataSet.spr_ReporteEnfermedadesPorSexoDataTable();
            da.Connection.ConnectionString = cadenaConexion;
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                barSeries.DataPoints.Add(new CategoricalDataPoint(Convert.ToDouble(dr["Paciente"].ToString()), dr["nombre"].ToString()));
                barSeries.ShowLabels = true;
                barSeries2.DataPoints.Add(new CategoricalDataPoint(Convert.ToDouble(dr["Femenino"].ToString()), dr["nombre"].ToString()));
                barSeries3.DataPoints.Add(new CategoricalDataPoint(Convert.ToDouble(dr["Masculino"].ToString()), dr["nombre"].ToString()));
                barSeries2.ShowLabels = true;
                barSeries3.ShowLabels = true;
            }
            rcView.View.Palette = KnownPalette.Cold;
            //rcView.ShowToolTip = true;
            this.rcView.Series.Add(barSeries);
            this.rcView.Series.Add(barSeries2);
            this.rcView.Series.Add(barSeries3);
            pbLeyenda.Image = global::SisOxi.WinUI.Properties.Resources.LeyendaSexo1;
        }

        private void CargarFormularioChartPorEdades()
        {
            rcView.Series.Clear();

            BarSeries barSeries = new BarSeries("Performance", "RepresentativeName");
            barSeries.Name = "Q1";
            BarSeries barSeries2 = new BarSeries("Performance", "RepresentativeName");
            barSeries2.Name = "Q2";
            BarSeries barSeries3 = new BarSeries("Performance", "RepresentativeName");
            barSeries3.Name = "Q2";
            SisOxibariterapiaDataSetTableAdapters.spr_ReporteEnfermedadesPorRangoEdadesTableAdapter da = new SisOxibariterapiaDataSetTableAdapters.spr_ReporteEnfermedadesPorRangoEdadesTableAdapter();
            SisOxibariterapiaDataSet.spr_ReporteEnfermedadesPorRangoEdadesDataTable dt = new WinUI.SisOxibariterapiaDataSet.spr_ReporteEnfermedadesPorRangoEdadesDataTable();
            da.Connection.ConnectionString = cadenaConexion;
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                barSeries.DataPoints.Add(new CategoricalDataPoint(Convert.ToDouble(dr["EdadMin"].ToString()), dr["nombre"].ToString()));

                barSeries.ShowLabels = true;
                barSeries2.DataPoints.Add(new CategoricalDataPoint(Convert.ToDouble(dr["Promedio"].ToString()), dr["nombre"].ToString()));
                barSeries2.ShowLabels = true;
                barSeries3.DataPoints.Add(new CategoricalDataPoint(Convert.ToDouble(dr["EdadMax"].ToString()), dr["nombre"].ToString()));
                barSeries3.ShowLabels = true;
            }

            rcView.View.Palette = KnownPalette.Cold;

            this.rcView.Series.Add(barSeries);
            this.rcView.Series.Add(barSeries2);
            this.rcView.Series.Add(barSeries3);
            pbLeyenda.Image = global::SisOxi.WinUI.Properties.Resources.LeyendaEdad;

        }

        private void CargarFormularioCamaraHiperbarica()
        {
            rcView.Series.Clear();

            BarSeries barSeries = new BarSeries("Performance", "RepresentativeName");
            barSeries.Name = "Q1";
            BarSeries barSeries2 = new BarSeries("Performance", "RepresentativeName");
            barSeries2.Name = "Q2";
            BarSeries barSeries3 = new BarSeries("Performance", "RepresentativeName");
            barSeries3.Name = "Q2";
            SisOxibariterapiaDataSetTableAdapters.spr_ReporteEnfermedadesTratamientoCamaraHiperbaricaTableAdapter da = new SisOxibariterapiaDataSetTableAdapters.spr_ReporteEnfermedadesTratamientoCamaraHiperbaricaTableAdapter();
            SisOxibariterapiaDataSet.spr_ReporteEnfermedadesTratamientoCamaraHiperbaricaDataTable dt = new WinUI.SisOxibariterapiaDataSet.spr_ReporteEnfermedadesTratamientoCamaraHiperbaricaDataTable();
            da.Connection.ConnectionString = cadenaConexion;
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                barSeries.DataPoints.Add(new CategoricalDataPoint(Convert.ToDouble(dr["NroSesionesMin"].ToString()), dr["nombre"].ToString()));

                barSeries.ShowLabels = true;
                barSeries2.DataPoints.Add(new CategoricalDataPoint(Convert.ToDouble(dr["PromedioNroSesiones"].ToString()), dr["nombre"].ToString()));
                barSeries2.ShowLabels = true;
                barSeries3.DataPoints.Add(new CategoricalDataPoint(Convert.ToDouble(dr["NroSesionesMax"].ToString()), dr["nombre"].ToString()));
                barSeries3.ShowLabels = true;
            }

            rcView.View.Palette = KnownPalette.Cold;

            this.rcView.Series.Add(barSeries);
            this.rcView.Series.Add(barSeries2);
            this.rcView.Series.Add(barSeries3);
            pbLeyenda.Image = global::SisOxi.WinUI.Properties.Resources.LeyendaCamaraHiperbarica;

        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'SisOxibariterapiaDataSet.spr_ReporteEnfermedadesPorSexo' Puede moverla o quitarla según sea necesario.
            if (cboTipoTratamiento.SelectedIndex == 0)
            {
                rpvReporteCamaraHiperbarica.Visible = false;
                rpvReporteEdades.Visible = false;
                rpvReportePorSexo.Visible = true;
                this.spr_ReporteEnfermedadesPorSexoTableAdapter.Connection.ConnectionString = cadenaConexion;
                this.spr_ReporteEnfermedadesPorSexoTableAdapter.Fill(this.SisOxibariterapiaDataSet.spr_ReporteEnfermedadesPorSexo);
                rpvReportePorSexo.RefreshReport();
                CargarFormularioChartPorSexo();

            }
            else if (cboTipoTratamiento.SelectedIndex == 1)
            {
                rpvReporteCamaraHiperbarica.Visible = false;
                rpvReporteEdades.Visible = true;
                rpvReportePorSexo.Visible = false;
                this.spr_ReporteEnfermedadesPorRangoEdadesTableAdapter.Connection.ConnectionString = cadenaConexion;
                this.spr_ReporteEnfermedadesPorRangoEdadesTableAdapter.Fill(this.SisOxibariterapiaDataSet.spr_ReporteEnfermedadesPorRangoEdades);
                rpvReporteEdades.RefreshReport();
                CargarFormularioChartPorEdades();
                // TODO: esta línea de código carga datos en la tabla 'SisOxibariterapiaDataSet.spr_ReporteEnfermedadesPorSexo' Puede moverla o quitarla según sea necesario.
            }
            else
            {
                rpvReporteCamaraHiperbarica.Visible = true;
                rpvReporteEdades.Visible = false;
                rpvReportePorSexo.Visible = false;
                this.spr_ReporteEnfermedadesTratamientoCamaraHiperbaricaTableAdapter.Connection.ConnectionString = cadenaConexion;
                this.spr_ReporteEnfermedadesTratamientoCamaraHiperbaricaTableAdapter.Fill(this.SisOxibariterapiaDataSet.spr_ReporteEnfermedadesTratamientoCamaraHiperbarica);
                rpvReporteCamaraHiperbarica.RefreshReport();
                CargarFormularioCamaraHiperbarica();
            }


        }

        private void rpvReporteCamaraHiperbarica_Load(object sender, EventArgs e)
        {

        }
    }
}
