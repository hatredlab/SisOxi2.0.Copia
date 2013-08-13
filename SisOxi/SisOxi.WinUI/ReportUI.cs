using Microsoft.Reporting.WinForms;
using SisOxi.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.Charting;
using Telerik.WinControls;
using Telerik.WinControls.RichTextBox.Winforms;
using Telerik.WinControls.UI;
using WinFormTelerikDS;

namespace SisOxi.WinUI
{
    public enum Reporte
    {
        EnfermedadesAsociadas,
        ResultadosEnfermedad
    }

    public partial class ReportUI : Telerik.WinControls.UI.RadForm
    {
        
        
         List<string> conexion = new ConexionBUS().LeerConexion();
        string cadenaConexion = string.Empty;
        DataTable dtPie = new DataTable();
        PrincipalUI principalUI;
        public ReportUI(PrincipalUI p)
        {
            InitializeComponent();
            principalUI = p;
            //spr_ReporteEnfermedadesTratamientoCamaraHiperabaricaTableAdapter = new SisOxibariterapiaDataSetTableAdapters.spr_ReporteEnfermedadesTratamientoCamaraHiperbaricaTableAdapter();
        }


        public void CargarReporteEnfermedadesAsociadas(int idEnfermedad,string nombre)
        {
            rpvReporteCamaraHiperbarica.Visible = false;
            rpvReporteEdades.Visible = false;
            rpvReportePorSexo.Visible = false;
            rpvReporteEnfermedadesAsociadas.Visible = true;
            rpvResumenEnfermedad.Visible = false;
            ReportParameter[] parametros = new ReportParameter[1];
            parametros[0] = new ReportParameter("Enfermedad", nombre, false);
            rpvReporteEnfermedadesAsociadas.LocalReport.SetParameters(parametros);
            this.spr_ReporteEnfermedadAsociadaTableAdapter.Connection.ConnectionString = cadenaConexion;
            this.spr_ReporteEnfermedadAsociadaTableAdapter.Fill(this.SisOxibariterapiaDataSet.spr_ReporteEnfermedadAsociada,idEnfermedad);
            rpvReporteEnfermedadesAsociadas.RefreshReport();
            pvMenu.SelectedPage = pvPaginaDatosFiliacion;
            lblHelp.Visible = true;
            OcultarPestañas(0);
        }

        public void CargarReporteResultadosTratamiento(int idEnfermedad,string nombre)
        {
            rpvReporteCamaraHiperbarica.Visible = false;
            rpvReporteEdades.Visible = false;
            rpvReportePorSexo.Visible = false;
            rpvReporteEnfermedadesAsociadas.Visible = false;
            rpvResumenEnfermedad.Visible = true;
            ReportParameter[] parametros = new ReportParameter[1];
            parametros[0] = new ReportParameter("Enfermedad",nombre,false);
            rpvResumenEnfermedad.LocalReport.SetParameters(parametros);
            this.spr_ReporteResumenTratamientoCamaraTableAdapter.Connection.ConnectionString = cadenaConexion;
            this.spr_ReporteResumenTratamientoCamaraTableAdapter.Fill(this.SisOxibariterapiaDataSet.spr_ReporteResumenTratamientoCamara,idEnfermedad);
            rpvResumenEnfermedad.RefreshReport();
            
            pvMenu.SelectedPage = pvPaginaDatosFiliacion;
            rcViewPastel.Series.Clear();
            rcViewPastel.ShowTitle = false;
            rcViewPastel.ShowLegend = false;
            lblHelp.Visible = true;
            MostrarPestañas();
            GenerarGraficoBarrasRpvResultadosTratamiento(idEnfermedad);
        }
        
        private void GenerarGraficoBarrasRpvResultadosTratamiento(int idEnfermedad)
        {
            rcView.Series.Clear();
            rcView.Title = "      Grafico de Barras de la Eficacia de los Protocolos";
            rcView.ShowTitle = true;

            rcView.View.Palette = KnownPalette.Rainbow;
            SisOxibariterapiaDataSetTableAdapters.spr_ReporteResumenTratamientoCamaraTableAdapter da = new SisOxibariterapiaDataSetTableAdapters.spr_ReporteResumenTratamientoCamaraTableAdapter();
            SisOxibariterapiaDataSet.spr_ReporteResumenTratamientoCamaraDataTable dt = new WinUI.SisOxibariterapiaDataSet.spr_ReporteResumenTratamientoCamaraDataTable();
            da.Connection.ConnectionString = cadenaConexion;
            da.Fill(dt, idEnfermedad);
            int[] estadoPaciente = new int[5];
            string[] estadoPacienteString = {"Muy Bueno","Bueno","Regular","Malo","Muy Malo" };
            foreach (DataRow dr in dt.Rows)
            {
                if(dr["estadoPaciente"].ToString() == "Muy bueno")
                {
                    estadoPaciente[0]++;
                }
                else if(dr["estadoPaciente"].ToString() == "Bueno")
                {
                    estadoPaciente[1]++;
                }
                else if (dr["estadoPaciente"].ToString() == "Regular")
                {
                    estadoPaciente[2]++;
                }
                else if (dr["estadoPaciente"].ToString() == "Malo")
                {
                    estadoPaciente[3]++;
                }
                else if (dr["estadoPaciente"].ToString() == "Muy Malo")
                {
                    estadoPaciente[3]++;
                }
               

            }
            
            for (int i = 0; i < estadoPaciente.Length; i++)
            {
                BarSeries barSeries = new BarSeries("Paciente", "nombre");
                barSeries.Name = "Q1";
                barSeries.DataPoints.Add(new CategoricalDataPoint(Convert.ToInt32(estadoPaciente[i]), estadoPacienteString[i]));
                barSeries.ShowLabels = true;
                barSeries.LegendTitle = estadoPacienteString[i];
                this.rcView.Series.Add(barSeries);
            }

            rcView.View.Palette = KnownPalette.Cold;
            //rcView.ShowToolTip = true;
            
            

            this.rcView.ShowLegend = true;
            //this.rcView.Controllers.Add(new SmartLabelsController());
            this.rcView.ShowSmartLabels = true;
            this.rcView.LegendTitle = "Leyenda";
            this.rcView.ChartElement.LegendElement.TitleElement.Font = new Font(rcView.ChartElement.Font.FontFamily.Name, 18);
            foreach (LegendItemElement item in this.rcView.ChartElement.LegendElement.StackElement.Children)
            {
                item.Font = new Font(rcView.ChartElement.Font.FontFamily.Name, 14);
            }
            //this.rcView.ChartElement.LegendPosition = LegendPosition.Float;
            //this.rcView.ChartElement.LegendOffset = new Point(200, 0);
            //this.rcViewPastel.Series.Add(series);
            //pbLeyenda.Image = global::SisOxi.WinUI.Properties.Resources.LeyendaSexo1;
           
        }
        
        private void RadForm1_Load(object sender, EventArgs e)
        {
            btnCerrar.ButtonElement.Shape = new EllipseShape();
            btnInicio.ButtonElement.Shape = new EllipseShape();
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
            WinFormTelerikDS.WinForm.ConvertirBordesRedondeadosLabelEnPageView(rpvPastel);
            // TODO: esta línea de código carga datos en la tabla 'SisOxibariterapiaDataSet.spr_ReporteEnfermedadesPorRangoEdades' Puede moverla o quitarla según sea necesario.
            //this.spr_ReporteEnfermedadesPorRangoEdadesTableAdapter.Fill(this.SisOxibariterapiaDataSet.spr_ReporteEnfermedadesPorRangoEdades);
            // TODO: esta línea de código carga datos en la tabla 'SisOxibariterapiaDataSet.spr_ReporteEnfermedadesPorSexo' Puede moverla o quitarla según sea necesario.
            //this.spr_ReporteEnfermedadesPorSexoTableAdapter.Fill(this.SisOxibariterapiaDataSet.spr_ReporteEnfermedadesPorSexo);
            // TODO: esta línea de código carga datos en la tabla 'SisOxibariterapiaDataSet.spr_ReporteEnfermedadesPorRangoEdades' Puede moverla o quitarla según sea necesario.
            //this.spr_ReporteEnfermedadesPorRangoEdadesTableAdapter.Fill(this.SisOxibariterapiaDataSet.spr_ReporteEnfermedadesPorRangoEdades);

            //this.rpvReporteEdades.RefreshReport();
            //this.rpvReporteCamaraHiperbarica.RefreshReport();
            //this.rpvReporteEnfermedadesAsociadas.RefreshReport();

           // this.rpvResumenEnfermedad.RefreshReport();
        }

        
        private void CargarFormularioChartPorSexo()
        {
            
            //conexionBD.Add(dataSource);
            //conexionBD.Add(initialCatalog);
            //conexionBD.Add(user);
            //conexionBD.Add(password);
            rcView.Series.Clear();
            //SisOxibariterapiaDataSetTableAdapters.spr_ReporteEnfermedadesPorSexoTableAdapter da = new SisOxibariterapiaDataSetTableAdapters.spr_ReporteEnfermedadesPorSexoTableAdapter();
            //SisOxibariterapiaDataSet.spr_ReporteEnfermedadesPorSexoDataTable dt = new WinUI.SisOxibariterapiaDataSet.spr_ReporteEnfermedadesPorSexoDataTable();
            //da.Connection.ConnectionString = cadenaConexion;
            //da.Fill(dt);
            //rcView.DataSource = dt;
            //BarSeries barSeries = new BarSeries("Paciente", "Enfermedad");
            //barSeries.DataMember = "Paciente";
            //barSeries.LegendTitle = "Paciente";
            //rcView.Series.Add(barSeries);
            //rcView.ShowLegend = true;
            rcView.Title = "      Grafico de Barras para la Frencuencia en Sexo de Todas las Enfermedades";
            rcView.ShowTitle = true;
            BarSeries barSeries = new BarSeries("Paciente", "nombre");
            barSeries.Name = "Q1";
           
            BarSeries barSeries2 = new BarSeries("Performance", "RepresentativeName");
            barSeries2.Name = "Q2";
            BarSeries barSeries3 = new BarSeries("Performance", "RepresentativeName");
            barSeries3.Name = "Q2";
            SisOxibariterapiaDataSetTableAdapters.spr_ReporteEnfermedadesPorSexoTableAdapter da = new SisOxibariterapiaDataSetTableAdapters.spr_ReporteEnfermedadesPorSexoTableAdapter();
            SisOxibariterapiaDataSet.spr_ReporteEnfermedadesPorSexoDataTable dt = new WinUI.SisOxibariterapiaDataSet.spr_ReporteEnfermedadesPorSexoDataTable();
            da.Connection.ConnectionString = cadenaConexion;
            da.Fill(dt);
            DataTable dx = new DataTable();
            dx.Columns.Add("nombre");
            dx.Columns.Add("Femenino");
            dx.Columns.Add("Masculino");
            foreach (DataRow dr in dt.Rows)
            {
                dx.Rows.Add(dr["nombre"].ToString(),dr["Femenino"].ToString(),dr["Masculino"].ToString());
                barSeries.DataPoints.Add(new CategoricalDataPoint(Convert.ToDouble(dr["Paciente"].ToString()), dr["nombre"].ToString()));
                barSeries.ShowLabels = true;
                barSeries.LegendTitle = "Paciente";
                
                barSeries2.DataPoints.Add(new CategoricalDataPoint(Convert.ToDouble(dr["Femenino"].ToString()), dr["nombre"].ToString()));
                barSeries3.DataPoints.Add(new CategoricalDataPoint(Convert.ToDouble(dr["Masculino"].ToString()), dr["nombre"].ToString()));
                barSeries2.LegendTitle = "Femenino";
                barSeries2.ShowLabels = true;
                barSeries3.ShowLabels = true;
                barSeries3.LegendTitle = "Masculino";
                
            }
            
            
            rcView.View.Palette = KnownPalette.Cold;
            //rcView.ShowToolTip = true;
            this.rcView.Series.Add(barSeries);
            this.rcView.Series.Add(barSeries2);
            this.rcView.Series.Add(barSeries3);
            
            this.rcView.ShowLegend = true;
            //this.rcView.Controllers.Add(new SmartLabelsController());
            this.rcView.ShowSmartLabels = true;
            this.rcView.LegendTitle = "Leyenda";
            this.rcView.ChartElement.LegendElement.TitleElement.Font = new Font(rcView.ChartElement.Font.FontFamily.Name, 18);
            foreach (LegendItemElement item in this.rcView.ChartElement.LegendElement.StackElement.Children)
            {
                item.Font = new Font(rcView.ChartElement.Font.FontFamily.Name, 14);
            }
            //this.rcView.ChartElement.LegendPosition = LegendPosition.Float;
            //this.rcView.ChartElement.LegendOffset = new Point(200, 0);
            //this.rcViewPastel.Series.Add(series);
            //pbLeyenda.Image = global::SisOxi.WinUI.Properties.Resources.LeyendaSexo1;
            dtPie = dx;
            CargarCboEnfermedad(dx);
            
            
        
        }

        private  void CargarCboEnfermedad(DataTable dt)
        {
           
            cboEnfermedad.DisplayMember = "nombre";
            //cboEnfermedad.ValueMember = "idEnfermedad";
            cboEnfermedad.DataSource = dt;
            //cboEnfermedad.Text = "--Seleccione--";
            cboEnfermedad.SelectedIndex = 0;
            cboEnfermedad.DataSource = dt;
            cboEnfermedad.Text = "--Seleccione--";
            cboEnfermedad.DisplayMember = "nombre";
            cboEnfermedad.AutoCompleteDataSource = dt;
            cboEnfermedad.DropDownListElement.AutoCompleteDataSource = dt;
            cboEnfermedad.DropDownListElement.AutoCompleteDisplayMember = "nombre";
            cboEnfermedad.DropDownStyle = RadDropDownStyle.DropDown;
            cboEnfermedad.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboEnfermedad.DropDownListElement.AutoCompleteSuggest.SuggestMode = SuggestMode.Contains;
            
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
                barSeries.LegendTitle = "Edad Minima";
                barSeries.ShowLabels = true;
                barSeries2.DataPoints.Add(new CategoricalDataPoint(Convert.ToDouble(dr["Promedio"].ToString()), dr["nombre"].ToString()));
                barSeries2.ShowLabels = true;
                barSeries2.LegendTitle = "Edad Promedio";
                barSeries3.DataPoints.Add(new CategoricalDataPoint(Convert.ToDouble(dr["EdadMax"].ToString()), dr["nombre"].ToString()));
                barSeries3.ShowLabels = true;
                barSeries3.LegendTitle = "Edad Maxima";
            }

            rcView.View.Palette = KnownPalette.Cold;
            
            CargarCboEnfermedad(new EnfermedadBUS().ReporteEnfermedadesPorRangoEdadesII());
            this.rcView.Series.Add(barSeries);
            this.rcView.Series.Add(barSeries2);
            this.rcView.Series.Add(barSeries3);
            this.rcView.ShowLegend = true;
            //this.rcView.Controllers.Add(new SmartLabelsController());
            this.rcView.ShowSmartLabels = true;
            this.rcView.LegendTitle = "Leyenda";
            this.rcView.ChartElement.LegendElement.TitleElement.Font = new Font(rcView.ChartElement.Font.FontFamily.Name, 18);
            foreach (LegendItemElement item in this.rcView.ChartElement.LegendElement.StackElement.Children)
            {
                item.Font = new Font(rcView.ChartElement.Font.FontFamily.Name, 14);
                
            }
           // pbLeyenda.Image = global::SisOxi.WinUI.Properties.Resources.LeyendaEdad;

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
                barSeries.LegendTitle = "Nro Sesiones Minimas";
                barSeries.ShowLabels = true;
                
                barSeries2.DataPoints.Add(new CategoricalDataPoint(Convert.ToDouble(dr["PromedioNroSesiones"].ToString()), dr["nombre"].ToString()));
                barSeries2.ShowLabels = true;
                barSeries2.LegendTitle = "Nro Sesiones Promedio";
                
                barSeries3.DataPoints.Add(new CategoricalDataPoint(Convert.ToDouble(dr["NroSesionesMax"].ToString()), dr["nombre"].ToString()));
                barSeries3.ShowLabels = true;
                barSeries3.LegendTitle = "Nro Sesiones Maxima";
             
            }

            rcView.View.Palette = KnownPalette.Cold;

            this.rcView.Series.Add(barSeries);
            this.rcView.Series.Add(barSeries2);
            this.rcView.Series.Add(barSeries3);
            this.rcView.ShowLegend = true;
            this.rcView.ShowSmartLabels = true;
            this.rcView.LegendTitle = "Leyenda";
            this.rcView.ChartElement.LegendElement.TitleElement.Font = new Font(rcView.ChartElement.Font.FontFamily.Name, 18);
            foreach (LegendItemElement item in this.rcView.ChartElement.LegendElement.StackElement.Children)
            {
                item.Font = new Font(rcView.ChartElement.Font.FontFamily.Name, 14);
            }
            //pbLeyenda.Image = global::SisOxi.WinUI.Properties.Resources.LeyendaCamaraHiperbarica;

        }

        //private void CargarFormularioEnfermedadesAsociadas()
        //{
        //    rcView.Series.Clear();

        //    BarSeries barSeries = new BarSeries("Performance", "RepresentativeName");
        //    barSeries.Name = "Q1";
        //    BarSeries barSeries2 = new BarSeries("Performance", "RepresentativeName");
        //    barSeries2.Name = "Q2";
        //    BarSeries barSeries3 = new BarSeries("Performance", "RepresentativeName");
        //    barSeries3.Name = "Q2";
        //    SisOxibariterapiaDataSetTableAdapters.spr_ReporteEnfermedadPorEnfermedadesAsociadasTableAdapter da = new SisOxibariterapiaDataSetTableAdapters.spr_ReporteEnfermedadPorEnfermedadesAsociadasTableAdapter();
        //    SisOxibariterapiaDataSet.spr_ReporteEnfermedadPorEnfermedadesAsociadasDataTable dt = new WinUI.SisOxibariterapiaDataSet.spr_ReporteEnfermedadPorEnfermedadesAsociadasDataTable();
        //    da.Connection.ConnectionString = cadenaConexion;
        //    //da.Fill(dt);
        //    //foreach (DataRow dr in dt.Rows)
        //    //{
        //    //    barSeries.DataPoints.Add(new CategoricalDataPoint(Convert.ToDouble(dr["NroSesionesMin"].ToString()), dr["nombre"].ToString()));
        //    //    barSeries.LegendTitle = "Nro Sesiones Minimas";
        //    //    barSeries.ShowLabels = true;

        //    //    barSeries2.DataPoints.Add(new CategoricalDataPoint(Convert.ToDouble(dr["PromedioNroSesiones"].ToString()), dr["nombre"].ToString()));
        //    //    barSeries2.ShowLabels = true;
        //    //    barSeries2.LegendTitle = "Nro Sesiones Promedio";

        //    //    barSeries3.DataPoints.Add(new CategoricalDataPoint(Convert.ToDouble(dr["NroSesionesMax"].ToString()), dr["nombre"].ToString()));
        //    //    barSeries3.ShowLabels = true;
        //    //    barSeries3.LegendTitle = "Nro Sesiones Maxima";

        //    //}

        //    rcView.View.Palette = KnownPalette.Cold;

        //    this.rcView.Series.Add(barSeries);
        //    this.rcView.Series.Add(barSeries2);
        //    this.rcView.Series.Add(barSeries3);
        //    this.rcView.ShowLegend = true;
        //    this.rcView.ShowSmartLabels = true;
        //    this.rcView.LegendTitle = "Leyenda";
        //    this.rcView.ChartElement.LegendElement.TitleElement.Font = new Font(rcView.ChartElement.Font.FontFamily.Name, 18);
        //    foreach (LegendItemElement item in this.rcView.ChartElement.LegendElement.StackElement.Children)
        //    {
        //        item.Font = new Font(rcView.ChartElement.Font.FontFamily.Name, 14);
        //    }
        //    //pbLeyenda.Image = global::SisOxi.WinUI.Properties.Resources.LeyendaCamaraHiperbarica;

        //}


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
            // TODO: esta línea de código carga datos en la tabla 'SisOxibariterapiaDataSet.spr_ReporteEnfermedadesPorSexo' Puede moverla o quitarla según sea necesario.
            try
            {
                string test = cboTipoTratamiento.Text.ValidarComboBox<string>(cboTipoTratamiento,"Tipo de Reporte");
                if (cboTipoTratamiento.SelectedIndex == 0)
                {
                    rpvReporteCamaraHiperbarica.Visible = false;
                    rpvReporteEdades.Visible = false;
                    rpvReportePorSexo.Visible = true;
                    rpvReporteEnfermedadesAsociadas.Visible = false;
                    rpvResumenEnfermedad.Visible = false;
                    this.spr_ReporteEnfermedadesPorSexoTableAdapter.Connection.ConnectionString = cadenaConexion;
                    this.spr_ReporteEnfermedadesPorSexoTableAdapter.Fill(this.SisOxibariterapiaDataSet.spr_ReporteEnfermedadesPorSexo);
                    rpvReportePorSexo.RefreshReport();
                    CargarFormularioChartPorSexo();
                    pvMenu.SelectedPage = pvPaginaDatosFiliacion;
                    rcViewPastel.Series.Clear();
                    rcViewPastel.ShowTitle = false;
                    rcViewPastel.ShowLegend = false;
                    lblHelp.Visible = true;
                    MostrarPestañas();

                }
                else if (cboTipoTratamiento.SelectedIndex == 1)
                {
                    rpvReporteCamaraHiperbarica.Visible = false;
                    rpvReporteEdades.Visible = true;
                    rpvReportePorSexo.Visible = false;
                    rpvResumenEnfermedad.Visible = false;
                    rpvReporteEnfermedadesAsociadas.Visible = false;
                    this.spr_ReporteEnfermedadesPorRangoEdadesTableAdapter.Connection.ConnectionString = cadenaConexion;
                    this.spr_ReporteEnfermedadesPorRangoEdadesTableAdapter.Fill(this.SisOxibariterapiaDataSet.spr_ReporteEnfermedadesPorRangoEdades);
                    rpvReporteEdades.RefreshReport();
                    CargarFormularioChartPorEdades();
                    pvMenu.SelectedPage = pvPaginaDatosFiliacion;
                    rcViewPastel.Series.Clear();
                    rcViewPastel.ShowTitle = false;
                    rcViewPastel.ShowLegend = false;
                    lblHelp.Visible = true;
                    MostrarPestañas();
                    // TODO: esta línea de código carga datos en la tabla 'SisOxibariterapiaDataSet.spr_ReporteEnfermedadesPorSexo' Puede moverla o quitarla según sea necesario.
                }
                else if (cboTipoTratamiento.SelectedIndex == 2)
                {
                    rpvReporteCamaraHiperbarica.Visible = true;
                    rpvReporteEdades.Visible = false;
                    rpvReportePorSexo.Visible = false;
                    rpvResumenEnfermedad.Visible = false;
                    rpvReporteEnfermedadesAsociadas.Visible = false;
                    this.spr_ReporteEnfermedadesTratamientoCamaraHiperbaricaTableAdapter.Connection.ConnectionString = cadenaConexion;
                    this.spr_ReporteEnfermedadesTratamientoCamaraHiperbaricaTableAdapter.Fill(this.SisOxibariterapiaDataSet.spr_ReporteEnfermedadesTratamientoCamaraHiperbarica);
                    rpvReporteCamaraHiperbarica.RefreshReport();
                    CargarFormularioCamaraHiperbarica();
                    pvMenu.SelectedPage = pvPaginaDatosFiliacion;
                    rcViewPastel.Series.Clear();
                    rcViewPastel.ShowTitle = false;
                    rcViewPastel.ShowLegend = false;
                    lblHelp.Visible = true;
                    OcultarPestañas(1);
                }
                else if(cboTipoTratamiento.SelectedIndex ==3)
                {
                    new EnfermedadReporteUI(this,Reporte.EnfermedadesAsociadas).ShowDialog();
                }
                else if (cboTipoTratamiento.SelectedIndex == 4)
                {
                    new EnfermedadReporteUI(this,Reporte.ResultadosEnfermedad).ShowDialog();
                }
                else
                {
                    rpvResumenEnfermedad.Visible = false;
                    rpvReporteCamaraHiperbarica.Visible = false;
                    rpvReporteEdades.Visible = false;
                    rpvReportePorSexo.Visible = false;
                    rpvReporteEnfermedadesAsociadas.Visible = true;
                    //this.spr_ReporteEnfermedadPorEnfermedadesAsociadasTableAdapter.Connection.ConnectionString = cadenaConexion;
                    ////this.spr_ReporteEnfermedadPorEnfermedadesAsociadasTableAdapter.Fill(this.SisOxibariterapiaDataSet.spr_ReporteEnfermedadPorEnfermedadesAsociadas);
                    //rpvReporteEnfermedadesAsociadas.RefreshReport();
                    //CargarFormularioEnfermedadesAsociadas();
                    pvMenu.SelectedPage = pvPaginaDatosFiliacion;
                    rcViewPastel.Series.Clear();
                    rcViewPastel.ShowTitle = false;
                    rcViewPastel.ShowLegend = false;
                    lblHelp.Visible = true;
                    OcultarPestañas(1);
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

        private void OcultarPestañas(int nroPestañas)
        {
            RadPageViewStripElement stripElement = (RadPageViewStripElement)this.pvMenu.ViewElement;
            int i = 0;
            foreach (RadPageViewStripItem item in stripElement.ItemContainer.ItemLayout.Children)
            {
                if (i > nroPestañas)
                {
                    item.Visibility = ElementVisibility.Hidden;
                }
                else
                {
                    item.Visibility = ElementVisibility.Visible;
                }
                i++;
            }
        }

        private void MostrarPestañas()
        {
            RadPageViewStripElement stripElement = (RadPageViewStripElement)this.pvMenu.ViewElement;
            int i = 0;
            foreach (RadPageViewStripItem item in stripElement.ItemContainer.ItemLayout.Children)
            {
               
                    item.Visibility = ElementVisibility.Visible;
                
            }
        }

        private void rpvReporteCamaraHiperbarica_Load(object sender, EventArgs e)
        {

        }

        //private void InitializeComponent()
        //{
        //    ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
        //    this.SuspendLayout();
             
        //     RadForm1
             
        //    this.ClientSize = new System.Drawing.Size(292, 266);
        //    this.Name = "RadForm1";
             
             
             
        //    this.RootElement.ApplyShapeToControl = true;
        //    this.Load += new System.EventHandler(this.RadForm1_Load_1);
        //    ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
        //    this.ResumeLayout(false);

        //}

        private void RadForm1_Load_1(object sender, EventArgs e)
        {

        }

       

        private void RadForm1_Load_2(object sender, EventArgs e)
        {

        }

        

        private void ReportesUI_Load(object sender, EventArgs e)
        {

        }

        private void rcView_LabelFormatting(object sender, ChartViewLabelFormattingEventArgs e)
        {
            OhlcLabelElement label = e.LabelElement as OhlcLabelElement;
            label.Font = new Font(rcView.ChartElement.Font.FontFamily.Name, 12);
            label.BackColor = Color.Transparent;
            label.NumberOfColors = 1;
            label.BorderColor = e.Series.BackColor;
                       
            
        }

        private void radButton1_Click(object sender, EventArgs e)
        {

        }

        private void cboEnfermedad_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            //if (cboTipoTratamiento.SelectedIndex == 0)
            //{
            //    CargarPastelSexo();
            //}
            //else if (cboTipoTratamiento.SelectedIndex == 1)
            //{
            //    CargarPastelEdades();
            //}
           
        }


        private void CargarPastelEdades()
        {

            
            rcViewPastel.Series.Clear();
            rcViewPastel.Select();
            rcViewPastel.Title = "      Grafico de Pastel para la Frecuencia entre Rango de Edades en : " + cboEnfermedad.Text;
            rcViewPastel.ShowTitle = true;

            this.rcViewPastel.ChartElement.LegendPosition = LegendPosition.Float;
            this.rcViewPastel.ChartElement.LegendOffset = new Point(680, 40);

            foreach (DataRow dr in new EnfermedadBUS().ReporteEnfermedadesPorRangoEdadesII().Rows)
            {
                if (dr[0].ToString() == cboEnfermedad.Text)
                {
                    this.rcViewPastel.AreaType = ChartAreaType.Pie;
                    //DataTable dtt = new DataTable();
                    //dtt.Columns.Add("Sexo");
                    //dtt.Columns.Add("Valor");
                    //dtt.Rows.Add("Femenino", dr[1].ToString());
                    //dtt.Rows.Add("Masculino", dr[2].ToString());
                    rcViewPastel.View.Palette = KnownPalette.Rainbow;
                    PieSeries series = new PieSeries();
                    //series.DataMember = "Valor";

                    //series.DataSource = dtt;
                    series.ShowLabels = true;

                    this.rcViewPastel.ShowLegend = true;

                    this.rcViewPastel.LegendTitle = "Leyenda";

                    series.DataPoints.Add(new PieDataPoint(Convert.ToDouble(dr[2]), "0-10"));
                    series.DataPoints.Add(new PieDataPoint(Convert.ToDouble(dr[3]), "11-20"));
                    series.DataPoints.Add(new PieDataPoint(Convert.ToDouble(dr[4]), "21-30"));
                    series.DataPoints.Add(new PieDataPoint(Convert.ToDouble(dr[5]), "31-40"));
                    series.DataPoints.Add(new PieDataPoint(Convert.ToDouble(dr[6]), "41-50"));
                    series.DataPoints.Add(new PieDataPoint(Convert.ToDouble(dr[7]), "51-60"));
                    series.DataPoints.Add(new PieDataPoint(Convert.ToDouble(dr[8]), "61-70"));
                    series.DataPoints.Add(new PieDataPoint(Convert.ToDouble(dr[9]), "71-80"));
                    series.DataPoints.Add(new PieDataPoint(Convert.ToDouble(dr[10]), "81+"));

                    string[] regionNames = new string[] { "0-10","11-20","21-30","31-40","41-50","51-60","61-70","71-80","81+" };

                    this.rcViewPastel.Series.Add(series);
                    
                    for (int i = 0; i < series.DataPoints.Count; i++)
                    {
                        ((PieDataPoint)series.DataPoints[i]).Name = regionNames[i];
                        this.rcViewPastel.ChartElement.LegendElement.Items[i].Title = regionNames[i];
                        
                    }

                    
                    this.rcViewPastel.ChartElement.LegendElement.TitleElement.Font = new Font(rcView.ChartElement.Font.FontFamily.Name, 18);
                    foreach (LegendItemElement item in this.rcViewPastel.ChartElement.LegendElement.StackElement.Children)
                    {
                        item.Font = new Font(rcViewPastel.ChartElement.Font.FontFamily.Name, 10);
                    }
                    break;
                }
            }
        }

        private void CargarPastelSexo()
        {
            rcViewPastel.Series.Clear();
            rcViewPastel.Title = "      Grafico de Pastel para la Frecuencia de Sexo en : " + cboEnfermedad.Text;
            rcViewPastel.ShowTitle = true;

            this.rcViewPastel.ChartElement.LegendPosition = LegendPosition.Float;
            this.rcViewPastel.ChartElement.LegendOffset = new Point(600, 100);

            foreach (DataRow dr in dtPie.Rows)
            {
                if (dr[0].ToString() == cboEnfermedad.Text)
                {
                    this.rcViewPastel.AreaType = ChartAreaType.Pie;
                    //DataTable dtt = new DataTable();
                    //dtt.Columns.Add("Sexo");
                    //dtt.Columns.Add("Valor");
                    //dtt.Rows.Add("Femenino", dr[1].ToString());
                    //dtt.Rows.Add("Masculino", dr[2].ToString());
                    rcViewPastel.View.Palette = KnownPalette.Cold;
                    PieSeries series = new PieSeries();
                    //series.DataMember = "Valor";

                    //series.DataSource = dtt;
                    this.rcViewPastel.ShowLegend = true;

                    this.rcViewPastel.LegendTitle = "Leyenda";

                    series.DataPoints.Add(new PieDataPoint(Convert.ToDouble(dr[1]), "Masculino"));
                    series.DataPoints.Add(new PieDataPoint(Convert.ToDouble(dr[2]), "Femenino"));
                    string[] regionNames = new string[] { "Femenino", "Masculino" };

                    this.rcViewPastel.Series.Add(series);
                    for (int i = 0; i < series.DataPoints.Count; i++)
                    {
                        ((PieDataPoint)series.DataPoints[i]).Name = regionNames[i];
                        this.rcViewPastel.ChartElement.LegendElement.Items[i].Title = regionNames[i];

                    }

                    series.ShowLabels = true;

                    
                    this.rcViewPastel.ChartElement.LegendElement.TitleElement.Font = new Font(rcView.ChartElement.Font.FontFamily.Name, 18);
                    foreach (LegendItemElement item in this.rcViewPastel.ChartElement.LegendElement.StackElement.Children)
                    {
                        item.Font = new Font(rcViewPastel.ChartElement.Font.FontFamily.Name, 14);
                    }
                    break;
                }
            }
        }

        private void rcViewPastel_LabelFormatting(object sender, ChartViewLabelFormattingEventArgs e)
        {

            e.LabelElement.Font = new Font(rcViewPastel.ChartElement.Font.FontFamily.Name, 14);
            e.LabelElement.BackColor = Color.Transparent;
            e.LabelElement.NumberOfColors = 1;
            e.LabelElement.BorderColor = e.Series.BackColor;
        }

        private void radButton1_Click_1(object sender, EventArgs e)
        {
            if (cboTipoTratamiento.SelectedIndex == 0)
            {
                lblHelp.Visible = false;
                CargarPastelSexo();
            }
            else if (cboTipoTratamiento.SelectedIndex == 1)
            {
                lblHelp.Visible = false;
                CargarPastelEdades();
            }
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            principalUI.pnlContenido.Controls.Clear();
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == WinForm.MensajeBox(this, "Cerrar Ventana", "¿Desea Cerrar esta ventana?", MensajeBox.pregunta))
            {
                this.Close();
            }
        }

        private void pvPaginaDatosFiliacion_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pvMenu_SelectedPageChanged(object sender, EventArgs e)
        {

        }

        private void radButton2_Click_1(object sender, EventArgs e)
        {
           
        }

    }
    
    
}
