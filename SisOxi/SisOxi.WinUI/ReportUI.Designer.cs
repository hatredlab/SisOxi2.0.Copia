namespace SisOxi.WinUI
{
    partial class ReportUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Telerik.WinControls.UI.RadListDataItem radListDataItem1 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem2 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem3 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem4 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem5 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.CartesianArea cartesianArea1 = new Telerik.WinControls.UI.CartesianArea();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Telerik.WinControls.UI.CartesianArea cartesianArea2 = new Telerik.WinControls.UI.CartesianArea();
            this.cboTipoTratamiento = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabel18 = new Telerik.WinControls.UI.RadLabel();
            this.pvPaginaPlan = new Telerik.WinControls.UI.RadPageViewPage();
            this.rcView = new Telerik.WinControls.UI.RadChartView();
            this.pvPaginaDatosFiliacion = new Telerik.WinControls.UI.RadPageViewPage();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.rpvResumenEnfermedad = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rpvReporteEnfermedadesAsociadas = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rpvReporteCamaraHiperbarica = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rpvReporteEdades = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rpvReportePorSexo = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pvMenu = new Telerik.WinControls.UI.RadPageView();
            this.rpvPastel = new Telerik.WinControls.UI.RadPageViewPage();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.cboEnfermedad = new Telerik.WinControls.UI.RadDropDownList();
            this.rcViewPastel = new Telerik.WinControls.UI.RadChartView();
            this.lblHelp = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.btnCerrar = new Telerik.WinControls.UI.RadButton();
            this.btnInicio = new Telerik.WinControls.UI.RadButton();
            this.btnBuscar = new Telerik.WinControls.UI.RadButton();
            this.lblTitulo = new Telerik.WinControls.UI.RadLabel();
            this.btnReportes = new Telerik.WinControls.UI.RadButton();
            this.btnTratamiento = new Telerik.WinControls.UI.RadButton();
            this.spr_ReporteResumenTratamientoCamaraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SisOxibariterapiaDataSet = new SisOxi.WinUI.SisOxibariterapiaDataSet();
            this.spr_ReporteEnfermedadAsociadaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spr_ReporteEnfermedadesTratamientoCamaraHiperbaricaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spr_ReporteEnfermedadesPorRangoEdadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spr_ReporteEnfermedadesPorSexoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spr_ReporteEnfermedadesPorSexoTableAdapter = new SisOxi.WinUI.SisOxibariterapiaDataSetTableAdapters.spr_ReporteEnfermedadesPorSexoTableAdapter();
            this.spr_ReporteEnfermedadesPorRangoEdadesTableAdapter = new SisOxi.WinUI.SisOxibariterapiaDataSetTableAdapters.spr_ReporteEnfermedadesPorRangoEdadesTableAdapter();
            this.spr_ReporteEnfermedadesTratamientoCamaraHiperbaricaTableAdapter = new SisOxi.WinUI.SisOxibariterapiaDataSetTableAdapters.spr_ReporteEnfermedadesTratamientoCamaraHiperbaricaTableAdapter();
            this.spr_ReporteEnfermedadPorEnfermedadesAsociadasTableAdapter = new SisOxi.WinUI.SisOxibariterapiaDataSetTableAdapters.spr_ReporteEnfermedadAsociadaTableAdapter();
            this.spr_ReporteEnfermedadAsociadaTableAdapter = new SisOxi.WinUI.SisOxibariterapiaDataSetTableAdapters.spr_ReporteEnfermedadAsociadaTableAdapter();
            this.spr_ReporteResumenTratamientoCamaraTableAdapter = new SisOxi.WinUI.SisOxibariterapiaDataSetTableAdapters.spr_ReporteResumenTratamientoCamaraTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.cboTipoTratamiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel18)).BeginInit();
            this.radLabel18.SuspendLayout();
            this.pvPaginaPlan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rcView)).BeginInit();
            this.pvPaginaDatosFiliacion.SuspendLayout();
            this.pnlPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pvMenu)).BeginInit();
            this.pvMenu.SuspendLayout();
            this.rpvPastel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            this.radLabel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboEnfermedad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rcViewPastel)).BeginInit();
            this.rcViewPastel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblHelp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnInicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTitulo)).BeginInit();
            this.lblTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnReportes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTratamiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spr_ReporteResumenTratamientoCamaraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SisOxibariterapiaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spr_ReporteEnfermedadAsociadaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spr_ReporteEnfermedadesTratamientoCamaraHiperbaricaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spr_ReporteEnfermedadesPorRangoEdadesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spr_ReporteEnfermedadesPorSexoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // cboTipoTratamiento
            // 
            this.cboTipoTratamiento.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.cboTipoTratamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            radListDataItem1.Text = "Reporte de Frencuencia de Enfermedades Por Sexo";
            radListDataItem1.TextWrap = true;
            radListDataItem2.Text = "Reporte de Frencuencia de Enfermedades Por Rango de Edades";
            radListDataItem2.TextWrap = true;
            radListDataItem3.Text = "Reporte de Enfermedades Tratadas con Camara Hiperbarica";
            radListDataItem3.TextWrap = true;
            radListDataItem4.Text = "Reporte de Enfermedades Asociadas a Pacientes";
            radListDataItem4.TextWrap = true;
            radListDataItem5.Text = "Reporte de Resultados de Tratamiento Camara Hiperbarica";
            radListDataItem5.TextWrap = true;
            this.cboTipoTratamiento.Items.Add(radListDataItem1);
            this.cboTipoTratamiento.Items.Add(radListDataItem2);
            this.cboTipoTratamiento.Items.Add(radListDataItem3);
            this.cboTipoTratamiento.Items.Add(radListDataItem4);
            this.cboTipoTratamiento.Items.Add(radListDataItem5);
            this.cboTipoTratamiento.Location = new System.Drawing.Point(179, 6);
            this.cboTipoTratamiento.Name = "cboTipoTratamiento";
            this.cboTipoTratamiento.Size = new System.Drawing.Size(561, 22);
            this.cboTipoTratamiento.TabIndex = 49;
            this.cboTipoTratamiento.Text = "--Seleccione--";
            // 
            // radLabel18
            // 
            this.radLabel18.AutoSize = false;
            this.radLabel18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.radLabel18.Controls.Add(this.cboTipoTratamiento);
            this.radLabel18.Font = new System.Drawing.Font("Yanone Kaffeesatz Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.radLabel18.Location = new System.Drawing.Point(27, 88);
            this.radLabel18.Name = "radLabel18";
            this.radLabel18.Size = new System.Drawing.Size(780, 35);
            this.radLabel18.TabIndex = 86;
            this.radLabel18.Text = "  Seleccione Reporte";
            this.radLabel18.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.radLabel18.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // pvPaginaPlan
            // 
            this.pvPaginaPlan.Controls.Add(this.rcView);
            this.pvPaginaPlan.Location = new System.Drawing.Point(5, 36);
            this.pvPaginaPlan.Name = "pvPaginaPlan";
            this.pvPaginaPlan.Size = new System.Drawing.Size(988, 388);
            this.pvPaginaPlan.Text = "Grafico de Barras";
            // 
            // rcView
            // 
            this.rcView.AreaDesign = cartesianArea1;
            this.rcView.Location = new System.Drawing.Point(7, 14);
            this.rcView.Name = "rcView";
            this.rcView.ShowGrid = false;
            this.rcView.Size = new System.Drawing.Size(970, 350);
            this.rcView.TabIndex = 0;
            this.rcView.Text = "radChartView1";
            this.rcView.LabelFormatting += new Telerik.WinControls.UI.ChartViewLabelFormattingEventHandler(this.rcView_LabelFormatting);
            // 
            // pvPaginaDatosFiliacion
            // 
            this.pvPaginaDatosFiliacion.Controls.Add(this.pnlPrincipal);
            this.pvPaginaDatosFiliacion.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.pvPaginaDatosFiliacion.Location = new System.Drawing.Point(5, 36);
            this.pvPaginaDatosFiliacion.Name = "pvPaginaDatosFiliacion";
            this.pvPaginaDatosFiliacion.Size = new System.Drawing.Size(988, 388);
            this.pvPaginaDatosFiliacion.Text = "Reporte";
            this.pvPaginaDatosFiliacion.Paint += new System.Windows.Forms.PaintEventHandler(this.pvPaginaDatosFiliacion_Paint);
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Controls.Add(this.rpvResumenEnfermedad);
            this.pnlPrincipal.Controls.Add(this.rpvReporteEnfermedadesAsociadas);
            this.pnlPrincipal.Controls.Add(this.rpvReporteCamaraHiperbarica);
            this.pnlPrincipal.Controls.Add(this.rpvReporteEdades);
            this.pnlPrincipal.Controls.Add(this.rpvReportePorSexo);
            this.pnlPrincipal.Location = new System.Drawing.Point(7, 16);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(978, 360);
            this.pnlPrincipal.TabIndex = 88;
            // 
            // rpvResumenEnfermedad
            // 
            this.rpvResumenEnfermedad.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.spr_ReporteResumenTratamientoCamaraBindingSource;
            this.rpvResumenEnfermedad.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvResumenEnfermedad.LocalReport.ReportEmbeddedResource = "SisOxi.WinUI.spr_ReporteResumenTratamientoCamara.rdlc";
            this.rpvResumenEnfermedad.Location = new System.Drawing.Point(0, 0);
            this.rpvResumenEnfermedad.Name = "rpvResumenEnfermedad";
            this.rpvResumenEnfermedad.Size = new System.Drawing.Size(978, 360);
            this.rpvResumenEnfermedad.TabIndex = 4;
            // 
            // rpvReporteEnfermedadesAsociadas
            // 
            this.rpvReporteEnfermedadesAsociadas.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.spr_ReporteEnfermedadAsociadaBindingSource;
            this.rpvReporteEnfermedadesAsociadas.LocalReport.DataSources.Add(reportDataSource2);
            this.rpvReporteEnfermedadesAsociadas.LocalReport.ReportEmbeddedResource = "SisOxi.WinUI.rpt_ReporteEnfermedadAsociada.rdlc";
            this.rpvReporteEnfermedadesAsociadas.Location = new System.Drawing.Point(0, 0);
            this.rpvReporteEnfermedadesAsociadas.Name = "rpvReporteEnfermedadesAsociadas";
            this.rpvReporteEnfermedadesAsociadas.Size = new System.Drawing.Size(978, 360);
            this.rpvReporteEnfermedadesAsociadas.TabIndex = 3;
            // 
            // rpvReporteCamaraHiperbarica
            // 
            this.rpvReporteCamaraHiperbarica.AutoScroll = true;
            this.rpvReporteCamaraHiperbarica.DocumentMapWidth = 87;
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.spr_ReporteEnfermedadesTratamientoCamaraHiperbaricaBindingSource;
            this.rpvReporteCamaraHiperbarica.LocalReport.DataSources.Add(reportDataSource3);
            this.rpvReporteCamaraHiperbarica.LocalReport.ReportEmbeddedResource = "SisOxi.WinUI.rpt_ReporteEnfermedadesPorTratamientoCamaraHiperbarica.rdlc";
            this.rpvReporteCamaraHiperbarica.Location = new System.Drawing.Point(0, 0);
            this.rpvReporteCamaraHiperbarica.Name = "rpvReporteCamaraHiperbarica";
            this.rpvReporteCamaraHiperbarica.Size = new System.Drawing.Size(970, 355);
            this.rpvReporteCamaraHiperbarica.TabIndex = 2;
            this.rpvReporteCamaraHiperbarica.Load += new System.EventHandler(this.rpvReporteCamaraHiperbarica_Load);
            // 
            // rpvReporteEdades
            // 
            reportDataSource4.Name = "DataSet1";
            reportDataSource4.Value = this.spr_ReporteEnfermedadesPorRangoEdadesBindingSource;
            this.rpvReporteEdades.LocalReport.DataSources.Add(reportDataSource4);
            this.rpvReporteEdades.LocalReport.ReportEmbeddedResource = "SisOxi.WinUI.rpt_ReporteEnfermedadesPorEdades.rdlc";
            this.rpvReporteEdades.Location = new System.Drawing.Point(-1, 0);
            this.rpvReporteEdades.Name = "rpvReporteEdades";
            this.rpvReporteEdades.Size = new System.Drawing.Size(970, 355);
            this.rpvReporteEdades.TabIndex = 1;
            // 
            // rpvReportePorSexo
            // 
            reportDataSource5.Name = "DataSet1";
            reportDataSource5.Value = this.spr_ReporteEnfermedadesPorSexoBindingSource;
            this.rpvReportePorSexo.LocalReport.DataSources.Add(reportDataSource5);
            this.rpvReportePorSexo.LocalReport.ReportEmbeddedResource = "SisOxi.WinUI.rpt_ReporteEnfermedadesPorSexo.rdlc";
            this.rpvReportePorSexo.Location = new System.Drawing.Point(0, 0);
            this.rpvReportePorSexo.Name = "rpvReportePorSexo";
            this.rpvReportePorSexo.Size = new System.Drawing.Size(970, 355);
            this.rpvReportePorSexo.TabIndex = 0;
            // 
            // pvMenu
            // 
            this.pvMenu.Controls.Add(this.pvPaginaDatosFiliacion);
            this.pvMenu.Controls.Add(this.pvPaginaPlan);
            this.pvMenu.Controls.Add(this.rpvPastel);
            this.pvMenu.Font = new System.Drawing.Font("Yanone Kaffeesatz Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pvMenu.Location = new System.Drawing.Point(15, 136);
            this.pvMenu.Name = "pvMenu";
            // 
            // 
            // 
            this.pvMenu.RootElement.Padding = new System.Windows.Forms.Padding(0);
            this.pvMenu.SelectedPage = this.pvPaginaPlan;
            this.pvMenu.Size = new System.Drawing.Size(998, 429);
            this.pvMenu.TabIndex = 90;
            this.pvMenu.SelectedPageChanged += new System.EventHandler(this.pvMenu_SelectedPageChanged);
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.pvMenu.GetChildAt(0))).StripButtons = Telerik.WinControls.UI.StripViewButtons.None;
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.pvMenu.GetChildAt(0))).ItemAlignment = Telerik.WinControls.UI.StripViewItemAlignment.Near;
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.pvMenu.GetChildAt(0))).ItemFitMode = Telerik.WinControls.UI.StripViewItemFitMode.None;
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.pvMenu.GetChildAt(0))).StripAlignment = Telerik.WinControls.UI.StripViewAlignment.Top;
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.pvMenu.GetChildAt(0))).ItemSpacing = 0;
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.pvMenu.GetChildAt(0))).ItemContentOrientation = Telerik.WinControls.UI.PageViewContentOrientation.Auto;
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.pvMenu.GetChildAt(0))).Padding = new System.Windows.Forms.Padding(0);
            // 
            // rpvPastel
            // 
            this.rpvPastel.Controls.Add(this.radButton1);
            this.rpvPastel.Controls.Add(this.radLabel4);
            this.rpvPastel.Controls.Add(this.rcViewPastel);
            this.rpvPastel.Location = new System.Drawing.Point(5, 36);
            this.rpvPastel.Name = "rpvPastel";
            this.rpvPastel.Size = new System.Drawing.Size(988, 388);
            this.rpvPastel.Text = "Grafico de Pastel";
            // 
            // radButton1
            // 
            this.radButton1.Font = new System.Drawing.Font("Yanone Kaffeesatz Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radButton1.Image = global::SisOxi.WinUI.Properties.Resources.Gnome_Applications_Graphics_32;
            this.radButton1.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.radButton1.Location = new System.Drawing.Point(658, 5);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(129, 35);
            this.radButton1.TabIndex = 92;
            this.radButton1.Text = "Graficar";
            this.radButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click_1);
            ((Telerik.WinControls.UI.RadButtonElement)(this.radButton1.GetChildAt(0))).Image = global::SisOxi.WinUI.Properties.Resources.Gnome_Applications_Graphics_32;
            ((Telerik.WinControls.UI.RadButtonElement)(this.radButton1.GetChildAt(0))).TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            ((Telerik.WinControls.UI.RadButtonElement)(this.radButton1.GetChildAt(0))).ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            ((Telerik.WinControls.UI.RadButtonElement)(this.radButton1.GetChildAt(0))).Text = "Graficar";
            // 
            // radLabel4
            // 
            this.radLabel4.AutoSize = false;
            this.radLabel4.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.radLabel4.Controls.Add(this.cboEnfermedad);
            this.radLabel4.Font = new System.Drawing.Font("Yanone Kaffeesatz Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.radLabel4.Location = new System.Drawing.Point(13, 5);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(618, 35);
            this.radLabel4.TabIndex = 91;
            this.radLabel4.Text = "   Enfermedad";
            this.radLabel4.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.radLabel4.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // cboEnfermedad
            // 
            this.cboEnfermedad.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.cboEnfermedad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEnfermedad.Location = new System.Drawing.Point(128, 6);
            this.cboEnfermedad.Name = "cboEnfermedad";
            this.cboEnfermedad.Size = new System.Drawing.Size(467, 22);
            this.cboEnfermedad.TabIndex = 2;
            this.cboEnfermedad.Text = "   --Seleccione Tipo--";
            this.cboEnfermedad.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.cboEnfermedad_SelectedIndexChanged);
            // 
            // rcViewPastel
            // 
            this.rcViewPastel.AreaDesign = cartesianArea2;
            this.rcViewPastel.Controls.Add(this.lblHelp);
            this.rcViewPastel.Controls.Add(this.radLabel1);
            this.rcViewPastel.Location = new System.Drawing.Point(13, 55);
            this.rcViewPastel.Name = "rcViewPastel";
            this.rcViewPastel.ShowGrid = false;
            this.rcViewPastel.Size = new System.Drawing.Size(964, 319);
            this.rcViewPastel.TabIndex = 90;
            this.rcViewPastel.Text = "Grafico de Barras";
            this.rcViewPastel.LabelFormatting += new Telerik.WinControls.UI.ChartViewLabelFormattingEventHandler(this.rcViewPastel_LabelFormatting);
            ((Telerik.WinControls.UI.RadChartElement)(this.rcViewPastel.GetChildAt(0))).Shape = null;
            // 
            // lblHelp
            // 
            this.lblHelp.BackColor = System.Drawing.Color.Transparent;
            this.lblHelp.Font = new System.Drawing.Font("Yanone Kaffeesatz Light", 16F, System.Drawing.FontStyle.Italic);
            this.lblHelp.Location = new System.Drawing.Point(200, 161);
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.Size = new System.Drawing.Size(488, 29);
            this.lblHelp.TabIndex = 1;
            this.lblHelp.Text = "< El Grafico no ha sido generado, Porfavor Seleccione un Enfermedad>";
            // 
            // radLabel1
            // 
            this.radLabel1.AutoSize = false;
            this.radLabel1.BackColor = System.Drawing.Color.White;
            this.radLabel1.Location = new System.Drawing.Point(3, 0);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(40, 33);
            this.radLabel1.TabIndex = 0;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Yanone Kaffeesatz Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Image = global::SisOxi.WinUI.Properties.Resources.Gnome_Process_Stop_32;
            this.btnCerrar.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCerrar.Location = new System.Drawing.Point(873, 5);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(59, 58);
            this.btnCerrar.TabIndex = 92;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCerrar.Click += new System.EventHandler(this.radButton2_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.Font = new System.Drawing.Font("Yanone Kaffeesatz Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.Image = global::SisOxi.WinUI.Properties.Resources.Gnome_Go_Home_32;
            this.btnInicio.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnInicio.Location = new System.Drawing.Point(938, 5);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(58, 58);
            this.btnInicio.TabIndex = 91;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Yanone Kaffeesatz Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = global::SisOxi.WinUI.Properties.Resources.Gnome_Edit_Find_48;
            this.btnBuscar.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBuscar.Location = new System.Drawing.Point(849, 84);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(148, 51);
            this.btnBuscar.TabIndex = 87;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnBuscar.GetChildAt(0))).Image = global::SisOxi.WinUI.Properties.Resources.Gnome_Edit_Find_48;
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnBuscar.GetChildAt(0))).TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnBuscar.GetChildAt(0))).ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnBuscar.GetChildAt(0))).Text = "Buscar";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = false;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Controls.Add(this.btnReportes);
            this.lblTitulo.Controls.Add(this.btnTratamiento);
            this.lblTitulo.Font = new System.Drawing.Font("Yanone Kaffeesatz Regular", 14F);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(105)))), ((int)(((byte)(133)))));
            this.lblTitulo.Image = global::SisOxi.WinUI.Properties.Resources.Gnome_Task_Due_64;
            this.lblTitulo.Location = new System.Drawing.Point(327, 5);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            // 
            // 
            // 
            this.lblTitulo.RootElement.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lblTitulo.Size = new System.Drawing.Size(360, 66);
            this.lblTitulo.TabIndex = 85;
            this.lblTitulo.Text = "   Reportes OXIBARITERAPIA S.C.R.L.";
            this.lblTitulo.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitulo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            // 
            // btnReportes
            // 
            this.btnReportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportes.Image = global::SisOxi.WinUI.Properties.Resources.Gnome_Task_Due_48;
            this.btnReportes.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnReportes.Location = new System.Drawing.Point(966, 9);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(122, 84);
            this.btnReportes.TabIndex = 40;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnTratamiento
            // 
            this.btnTratamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTratamiento.Image = global::SisOxi.WinUI.Properties.Resources.Im_Aim_48;
            this.btnTratamiento.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTratamiento.Location = new System.Drawing.Point(825, 9);
            this.btnTratamiento.Name = "btnTratamiento";
            this.btnTratamiento.Size = new System.Drawing.Size(122, 84);
            this.btnTratamiento.TabIndex = 39;
            this.btnTratamiento.Text = "Tratamiento";
            this.btnTratamiento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // spr_ReporteResumenTratamientoCamaraBindingSource
            // 
            this.spr_ReporteResumenTratamientoCamaraBindingSource.DataMember = "spr_ReporteResumenTratamientoCamara";
            this.spr_ReporteResumenTratamientoCamaraBindingSource.DataSource = this.SisOxibariterapiaDataSet;
            // 
            // SisOxibariterapiaDataSet
            // 
            this.SisOxibariterapiaDataSet.DataSetName = "SisOxibariterapiaDataSet";
            this.SisOxibariterapiaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spr_ReporteEnfermedadAsociadaBindingSource
            // 
            this.spr_ReporteEnfermedadAsociadaBindingSource.DataMember = "spr_ReporteEnfermedadAsociada";
            this.spr_ReporteEnfermedadAsociadaBindingSource.DataSource = this.SisOxibariterapiaDataSet;
            // 
            // spr_ReporteEnfermedadesTratamientoCamaraHiperbaricaBindingSource
            // 
            this.spr_ReporteEnfermedadesTratamientoCamaraHiperbaricaBindingSource.DataMember = "spr_ReporteEnfermedadesTratamientoCamaraHiperbarica";
            this.spr_ReporteEnfermedadesTratamientoCamaraHiperbaricaBindingSource.DataSource = this.SisOxibariterapiaDataSet;
            // 
            // spr_ReporteEnfermedadesPorRangoEdadesBindingSource
            // 
            this.spr_ReporteEnfermedadesPorRangoEdadesBindingSource.DataMember = "spr_ReporteEnfermedadesPorRangoEdades";
            this.spr_ReporteEnfermedadesPorRangoEdadesBindingSource.DataSource = this.SisOxibariterapiaDataSet;
            // 
            // spr_ReporteEnfermedadesPorSexoBindingSource
            // 
            this.spr_ReporteEnfermedadesPorSexoBindingSource.DataMember = "spr_ReporteEnfermedadesPorSexo";
            this.spr_ReporteEnfermedadesPorSexoBindingSource.DataSource = this.SisOxibariterapiaDataSet;
            // 
            // spr_ReporteEnfermedadesPorSexoTableAdapter
            // 
            this.spr_ReporteEnfermedadesPorSexoTableAdapter.ClearBeforeFill = true;
            // 
            // spr_ReporteEnfermedadesPorRangoEdadesTableAdapter
            // 
            this.spr_ReporteEnfermedadesPorRangoEdadesTableAdapter.ClearBeforeFill = true;
            // 
            // spr_ReporteEnfermedadesTratamientoCamaraHiperbaricaTableAdapter
            // 
            this.spr_ReporteEnfermedadesTratamientoCamaraHiperbaricaTableAdapter.ClearBeforeFill = true;
            // 
            // spr_ReporteEnfermedadPorEnfermedadesAsociadasTableAdapter
            // 
            this.spr_ReporteEnfermedadPorEnfermedadesAsociadasTableAdapter.ClearBeforeFill = true;
            // 
            // spr_ReporteEnfermedadAsociadaTableAdapter
            // 
            this.spr_ReporteEnfermedadAsociadaTableAdapter.ClearBeforeFill = true;
            // 
            // spr_ReporteResumenTratamientoCamaraTableAdapter
            // 
            this.spr_ReporteResumenTratamientoCamaraTableAdapter.ClearBeforeFill = true;
            // 
            // ReportUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 591);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnInicio);
            this.Controls.Add(this.pvMenu);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.radLabel18);
            this.Controls.Add(this.lblTitulo);
            this.Name = "ReportUI";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "RadForm1";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.RadForm1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cboTipoTratamiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel18)).EndInit();
            this.radLabel18.ResumeLayout(false);
            this.radLabel18.PerformLayout();
            this.pvPaginaPlan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rcView)).EndInit();
            this.pvPaginaDatosFiliacion.ResumeLayout(false);
            this.pnlPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pvMenu)).EndInit();
            this.pvMenu.ResumeLayout(false);
            this.rpvPastel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            this.radLabel4.ResumeLayout(false);
            this.radLabel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboEnfermedad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rcViewPastel)).EndInit();
            this.rcViewPastel.ResumeLayout(false);
            this.rcViewPastel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblHelp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnInicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTitulo)).EndInit();
            this.lblTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnReportes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTratamiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spr_ReporteResumenTratamientoCamaraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SisOxibariterapiaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spr_ReporteEnfermedadAsociadaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spr_ReporteEnfermedadesTratamientoCamaraHiperbaricaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spr_ReporteEnfermedadesPorRangoEdadesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spr_ReporteEnfermedadesPorSexoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource spr_ReporteEnfermedadesPorSexoBindingSource;
        private SisOxibariterapiaDataSet SisOxibariterapiaDataSet;
        private SisOxibariterapiaDataSetTableAdapters.spr_ReporteEnfermedadesPorSexoTableAdapter spr_ReporteEnfermedadesPorSexoTableAdapter;
        private Telerik.WinControls.UI.RadLabel lblTitulo;
        private Telerik.WinControls.UI.RadButton btnReportes;
        private Telerik.WinControls.UI.RadButton btnTratamiento;
        private Telerik.WinControls.UI.RadDropDownList cboTipoTratamiento;
        private Telerik.WinControls.UI.RadLabel radLabel18;
        private System.Windows.Forms.BindingSource spr_ReporteEnfermedadesPorRangoEdadesBindingSource;
        private SisOxibariterapiaDataSetTableAdapters.spr_ReporteEnfermedadesPorRangoEdadesTableAdapter spr_ReporteEnfermedadesPorRangoEdadesTableAdapter;
        private Telerik.WinControls.UI.RadButton btnBuscar;
        private System.Windows.Forms.BindingSource spr_ReporteEnfermedadesTratamientoCamaraHiperbaricaBindingSource;
        private Telerik.WinControls.UI.RadPageViewPage pvPaginaPlan;
        private Telerik.WinControls.UI.RadPageViewPage pvPaginaDatosFiliacion;
        private System.Windows.Forms.Panel pnlPrincipal;
        private Microsoft.Reporting.WinForms.ReportViewer rpvReporteCamaraHiperbarica;
        private Microsoft.Reporting.WinForms.ReportViewer rpvReporteEdades;
        private Microsoft.Reporting.WinForms.ReportViewer rpvReportePorSexo;
        private Telerik.WinControls.UI.RadPageView pvMenu;
        private Telerik.WinControls.UI.RadPageViewPage rpvPastel;
        private Telerik.WinControls.UI.RadChartView rcViewPastel;
        private Telerik.WinControls.UI.RadChartView rcView;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadDropDownList cboEnfermedad;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.UI.RadLabel lblHelp;
        private Telerik.WinControls.UI.RadButton btnCerrar;
        private Telerik.WinControls.UI.RadButton btnInicio;
        private SisOxibariterapiaDataSetTableAdapters.spr_ReporteEnfermedadesTratamientoCamaraHiperbaricaTableAdapter spr_ReporteEnfermedadesTratamientoCamaraHiperbaricaTableAdapter;
        private SisOxi.WinUI.SisOxibariterapiaDataSetTableAdapters.spr_ReporteEnfermedadAsociadaTableAdapter spr_ReporteEnfermedadPorEnfermedadesAsociadasTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer rpvReporteEnfermedadesAsociadas;
        private System.Windows.Forms.BindingSource spr_ReporteEnfermedadAsociadaBindingSource;
        private SisOxibariterapiaDataSetTableAdapters.spr_ReporteEnfermedadAsociadaTableAdapter spr_ReporteEnfermedadAsociadaTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer rpvResumenEnfermedad;
        private System.Windows.Forms.BindingSource spr_ReporteResumenTratamientoCamaraBindingSource;
        private SisOxibariterapiaDataSetTableAdapters.spr_ReporteResumenTratamientoCamaraTableAdapter spr_ReporteResumenTratamientoCamaraTableAdapter;

        
    }
}
