namespace SisOxi.WinUI
{
    partial class PrincipalUI
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
            Telerik.WinControls.UI.CarouselEllipsePath carouselEllipsePath1 = new Telerik.WinControls.UI.CarouselEllipsePath();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrincipalUI));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.radCarousel1 = new Telerik.WinControls.UI.RadCarousel();
            this.btnEmpleado = new Telerik.WinControls.UI.RadButtonElement();
            this.donutShape1 = new Telerik.WinControls.Tests.DonutShape();
            this.btnHistoriaClinica = new Telerik.WinControls.UI.RadButtonElement();
            this.btnReportes = new Telerik.WinControls.UI.RadButtonElement();
            this.btnAyuda = new Telerik.WinControls.UI.RadButtonElement();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.ellipseShape1 = new Telerik.WinControls.EllipseShape();
            this.roundRectShape1 = new Telerik.WinControls.RoundRectShape(this.components);
            this.qaShape1 = new Telerik.WinControls.Tests.QAShape();
            this.trackBarLThumbShape1 = new Telerik.WinControls.UI.TrackBarLThumbShape();
            this.customShape1 = new Telerik.WinControls.OldShapeEditor.CustomShape();
            this.mediaShape1 = new Telerik.WinControls.Tests.MediaShape();
            this.officeShape1 = new Telerik.WinControls.UI.OfficeShape();
            this.pnlContenido = new Telerik.WinControls.UI.RadPanel();
            this.tmrActividad = new System.Windows.Forms.Timer(this.components);
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radCarousel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlContenido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlMenu.Controls.Add(this.radCarousel1);
            this.pnlMenu.Controls.Add(this.radLabel1);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(1028, 128);
            this.pnlMenu.TabIndex = 0;
            // 
            // radCarousel1
            // 
            carouselEllipsePath1.Center = new Telerik.WinControls.UI.Point3D(52.121212121212125D, 43.558282208588956D, 0D);
            carouselEllipsePath1.FinalAngle = -100D;
            carouselEllipsePath1.InitialAngle = -90D;
            carouselEllipsePath1.U = new Telerik.WinControls.UI.Point3D(6.9090909090909092D, 0.30674846625766872D, -50D);
            carouselEllipsePath1.V = new Telerik.WinControls.UI.Point3D(-29.939393939393938D, 5.8282208588957056D, -60D);
            carouselEllipsePath1.ZScale = 500D;
            this.radCarousel1.CarouselPath = carouselEllipsePath1;
            this.radCarousel1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.btnEmpleado,
            this.btnHistoriaClinica,
            this.btnReportes,
            this.btnAyuda});
            this.radCarousel1.Location = new System.Drawing.Point(191, 9);
            this.radCarousel1.Name = "radCarousel1";
            this.radCarousel1.Size = new System.Drawing.Size(825, 113);
            this.radCarousel1.TabIndex = 2;
            this.radCarousel1.Text = "radCarousel1";
            this.radCarousel1.ThemeName = "ControlDefault";
            ((Telerik.WinControls.UI.RadRepeatButtonElement)(this.radCarousel1.GetChildAt(0).GetChildAt(4))).AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            // 
            // btnEmpleado
            // 
            this.btnEmpleado.AccessibleDescription = "Empleado";
            this.btnEmpleado.AccessibleName = "Empleado";
            this.btnEmpleado.Font = new System.Drawing.Font("Yanone Kaffeesatz Regular", 15F);
            this.btnEmpleado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(66)))), ((int)(((byte)(139)))));
            this.btnEmpleado.Image = global::SisOxi.WinUI.Properties.Resources.Gnome_System_Users_64;
            this.btnEmpleado.Name = "btnEmpleado";
            this.btnEmpleado.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnEmpleado.Shape = this.ellipseShape1;
            this.btnEmpleado.Text = "Empleado";
            this.btnEmpleado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEmpleado.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.btnEmpleado.Click += new System.EventHandler(this.radButtonElement2_Click);
            // 
            // btnHistoriaClinica
            // 
            this.btnHistoriaClinica.AccessibleDescription = "  Historia Clinica";
            this.btnHistoriaClinica.AccessibleName = "  Historia Clinica";
            this.btnHistoriaClinica.Font = new System.Drawing.Font("Yanone Kaffeesatz Regular", 15F);
            this.btnHistoriaClinica.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(66)))), ((int)(((byte)(139)))));
            this.btnHistoriaClinica.Image = global::SisOxi.WinUI.Properties.Resources.Im_Msn_64;
            this.btnHistoriaClinica.Name = "btnHistoriaClinica";
            this.btnHistoriaClinica.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnHistoriaClinica.Shape = this.ellipseShape1;
            this.btnHistoriaClinica.Text = "  Historia Clinica";
            this.btnHistoriaClinica.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHistoriaClinica.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.btnHistoriaClinica.Click += new System.EventHandler(this.radButtonElement1_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.AccessibleDescription = "Reportes";
            this.btnReportes.AccessibleName = "Reportes";
            this.btnReportes.Font = new System.Drawing.Font("Yanone Kaffeesatz Regular", 15F);
            this.btnReportes.Image = global::SisOxi.WinUI.Properties.Resources.Gnome_Task_Due_64;
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnReportes.Shape = this.ellipseShape1;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReportes.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.btnReportes.Click += new System.EventHandler(this.radButtonElement3_Click);
            // 
            // btnAyuda
            // 
            this.btnAyuda.AccessibleDescription = "Ayuda";
            this.btnAyuda.AccessibleName = "Ayuda";
            this.btnAyuda.Font = new System.Drawing.Font("Yanone Kaffeesatz Regular", 15F);
            this.btnAyuda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(66)))), ((int)(((byte)(139)))));
            this.btnAyuda.Image = global::SisOxi.WinUI.Properties.Resources.Gnome_System_Help_64;
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnAyuda.Shape = this.ellipseShape1;
            this.btnAyuda.Text = "Ayuda";
            this.btnAyuda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAyuda.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // radLabel1
            // 
            this.radLabel1.BackColor = System.Drawing.Color.Transparent;
            this.radLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.ForeColor = System.Drawing.Color.OliveDrab;
            this.radLabel1.Image = global::SisOxi.WinUI.Properties.Resources.logo2;
            this.radLabel1.Location = new System.Drawing.Point(25, 12);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(152, 103);
            this.radLabel1.TabIndex = 1;
            // 
            // customShape1
            // 
            this.customShape1.Dimension = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // pnlContenido
            // 
            this.pnlContenido.BackgroundImage = global::SisOxi.WinUI.Properties.Resources.back___copia;
            this.pnlContenido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenido.Location = new System.Drawing.Point(0, 128);
            this.pnlContenido.Name = "pnlContenido";
            this.pnlContenido.Size = new System.Drawing.Size(1028, 634);
            this.pnlContenido.TabIndex = 1;
            // 
            // tmrActividad
            // 
            this.tmrActividad.Interval = 1000;
            this.tmrActividad.Tick += new System.EventHandler(this.tmrActividad_Tick);
            // 
            // PrincipalUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 762);
            this.Controls.Add(this.pnlContenido);
            this.Controls.Add(this.pnlMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PrincipalUI";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Sistema Oxibariterapia";
            this.ThemeName = "ControlDefault";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PrincipalUI_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radCarousel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlContenido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        //private Telerik.WinControls.Themes.Office2010BlackTheme office2010BlackTheme1;
        public Telerik.WinControls.UI.RadPanel pnlContenido;
        private Telerik.WinControls.UI.RadCarousel radCarousel1;
        private Telerik.WinControls.UI.RadButtonElement btnHistoriaClinica;
        private Telerik.WinControls.UI.RadButtonElement btnEmpleado;
        private Telerik.WinControls.UI.RadButtonElement btnReportes;
        private Telerik.WinControls.EllipseShape ellipseShape1;
        private Telerik.WinControls.RoundRectShape roundRectShape1;
        private Telerik.WinControls.Tests.QAShape qaShape1;
        private Telerik.WinControls.UI.TrackBarLThumbShape trackBarLThumbShape1;
        private Telerik.WinControls.OldShapeEditor.CustomShape customShape1;
        private Telerik.WinControls.UI.OfficeShape officeShape1;
        private Telerik.WinControls.Tests.MediaShape mediaShape1;
        private Telerik.WinControls.Tests.DonutShape donutShape1;
        private Telerik.WinControls.UI.RadButtonElement btnAyuda;
        private System.Windows.Forms.Timer tmrActividad;
    }
}
