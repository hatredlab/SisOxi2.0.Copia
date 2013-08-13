namespace SisOxi.WinUI
{
    partial class ImpresionDiagnosticaUI
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
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn1 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 0", "Enfermedad Asociada");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImpresionDiagnosticaUI));
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.cboEnfermedad = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.txtObservaciones = new System.Windows.Forms.RichTextBox();
            this.rgbSesiones = new Telerik.WinControls.UI.RadGroupBox();
            this.lstEnfermedadesAsociadas = new Telerik.WinControls.UI.RadListView();
            this.btnEliminar = new Telerik.WinControls.UI.RadButton();
            this.roundRectShape1 = new Telerik.WinControls.RoundRectShape(this.components);
            this.btnAgregar = new Telerik.WinControls.UI.RadButton();
            this.btnVerEnfermedad = new Telerik.WinControls.UI.RadButton();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.lblTitulo = new Telerik.WinControls.UI.RadLabel();
            this.btnReportes = new Telerik.WinControls.UI.RadButton();
            this.btnTratamiento = new Telerik.WinControls.UI.RadButton();
            this.btnNuevo = new Telerik.WinControls.UI.RadButton();
            this.donutShape1 = new Telerik.WinControls.Tests.DonutShape();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            this.radLabel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboEnfermedad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            this.radLabel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgbSesiones)).BeginInit();
            this.rgbSesiones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstEnfermedadesAsociadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVerEnfermedad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTitulo)).BeginInit();
            this.lblTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnReportes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTratamiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNuevo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radLabel4
            // 
            this.radLabel4.AutoSize = false;
            this.radLabel4.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.radLabel4.Controls.Add(this.cboEnfermedad);
            this.radLabel4.Font = new System.Drawing.Font("Yanone Kaffeesatz Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.radLabel4.Location = new System.Drawing.Point(103, 85);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(663, 35);
            this.radLabel4.TabIndex = 1;
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
            this.cboEnfermedad.Size = new System.Drawing.Size(508, 22);
            this.cboEnfermedad.TabIndex = 2;
            this.cboEnfermedad.Text = "   --Seleccione Tipo--";
            // 
            // radLabel3
            // 
            this.radLabel3.AutoSize = false;
            this.radLabel3.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.radLabel3.Controls.Add(this.txtObservaciones);
            this.radLabel3.Font = new System.Drawing.Font("Yanone Kaffeesatz Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.radLabel3.Location = new System.Drawing.Point(103, 129);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(663, 165);
            this.radLabel3.TabIndex = 3;
            this.radLabel3.Text = "   Observaciones";
            this.radLabel3.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.radLabel3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservaciones.Location = new System.Drawing.Point(128, 8);
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(508, 148);
            this.txtObservaciones.TabIndex = 4;
            this.txtObservaciones.TabStop = false;
            this.txtObservaciones.Text = "";
            // 
            // rgbSesiones
            // 
            this.rgbSesiones.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.rgbSesiones.BackColor = System.Drawing.Color.Transparent;
            this.rgbSesiones.Controls.Add(this.lstEnfermedadesAsociadas);
            this.rgbSesiones.Controls.Add(this.btnEliminar);
            this.rgbSesiones.Controls.Add(this.btnAgregar);
            this.rgbSesiones.Controls.Add(this.btnVerEnfermedad);
            this.rgbSesiones.Font = new System.Drawing.Font("Yanone Kaffeesatz Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rgbSesiones.ForeColor = System.Drawing.Color.White;
            this.rgbSesiones.HeaderText = "Enfermedades Asociadas";
            this.rgbSesiones.Location = new System.Drawing.Point(103, 309);
            this.rgbSesiones.Name = "rgbSesiones";
            // 
            // 
            // 
            this.rgbSesiones.RootElement.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            this.rgbSesiones.Size = new System.Drawing.Size(685, 245);
            this.rgbSesiones.TabIndex = 93;
            this.rgbSesiones.Text = "Enfermedades Asociadas";
            // 
            // lstEnfermedadesAsociadas
            // 
            this.lstEnfermedadesAsociadas.AllowArbitraryItemHeight = true;
            this.lstEnfermedadesAsociadas.AllowEdit = false;
            this.lstEnfermedadesAsociadas.AllowRemove = false;
            listViewDetailColumn1.HeaderText = "Enfermedad Asociada";
            listViewDetailColumn1.Width = 464F;
            this.lstEnfermedadesAsociadas.Columns.AddRange(new Telerik.WinControls.UI.ListViewDetailColumn[] {
            listViewDetailColumn1});
            this.lstEnfermedadesAsociadas.Font = new System.Drawing.Font("Yanone Kaffeesatz Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstEnfermedadesAsociadas.ItemSpacing = -1;
            this.lstEnfermedadesAsociadas.Location = new System.Drawing.Point(21, 38);
            this.lstEnfermedadesAsociadas.Name = "lstEnfermedadesAsociadas";
            this.lstEnfermedadesAsociadas.Size = new System.Drawing.Size(465, 185);
            this.lstEnfermedadesAsociadas.TabIndex = 96;
            this.lstEnfermedadesAsociadas.Text = "radListView1";
            this.lstEnfermedadesAsociadas.ViewType = Telerik.WinControls.UI.ListViewType.DetailsView;
            this.lstEnfermedadesAsociadas.CellFormatting += new Telerik.WinControls.UI.ListViewCellFormattingEventHandler(this.lstEnfermedadesAsociadas_CellFormatting);
            ((Telerik.WinControls.UI.DetailListViewElement)(this.lstEnfermedadesAsociadas.GetChildAt(0).GetChildAt(0))).AllowArbitraryItemHeight = true;
            ((Telerik.WinControls.UI.DetailsListViewContainer)(this.lstEnfermedadesAsociadas.GetChildAt(0).GetChildAt(0).GetChildAt(0))).Shape = null;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Yanone Kaffeesatz Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Image = global::SisOxi.WinUI.Properties.Resources.Gnome_Dialog_Error_32;
            this.btnEliminar.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEliminar.Location = new System.Drawing.Point(502, 165);
            this.btnEliminar.Name = "btnEliminar";
            // 
            // 
            // 
            this.btnEliminar.RootElement.Shape = this.roundRectShape1;
            this.btnEliminar.Size = new System.Drawing.Size(161, 58);
            this.btnEliminar.TabIndex = 95;
            this.btnEliminar.Text = "<html>Eliminar Enfermedad<br> Asociada</html>";
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnEliminar.GetChildAt(0))).Image = global::SisOxi.WinUI.Properties.Resources.Gnome_Dialog_Error_32;
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnEliminar.GetChildAt(0))).TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnEliminar.GetChildAt(0))).ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnEliminar.GetChildAt(0))).Text = "<html>Eliminar Enfermedad<br> Asociada</html>";
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnEliminar.GetChildAt(0))).Shape = this.roundRectShape1;
            // 
            // roundRectShape1
            // 
            this.roundRectShape1.Radius = 20;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Yanone Kaffeesatz Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Image = global::SisOxi.WinUI.Properties.Resources.Add;
            this.btnAgregar.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAgregar.Location = new System.Drawing.Point(502, 38);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(161, 58);
            this.btnAgregar.TabIndex = 94;
            this.btnAgregar.Text = "<html>Agregar Enfermedad<br> Asociada</html>";
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregar.Click += new System.EventHandler(this.radButton3_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnAgregar.GetChildAt(0))).Image = global::SisOxi.WinUI.Properties.Resources.Add;
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnAgregar.GetChildAt(0))).TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnAgregar.GetChildAt(0))).ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnAgregar.GetChildAt(0))).Text = "<html>Agregar Enfermedad<br> Asociada</html>";
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnAgregar.GetChildAt(0))).Shape = this.roundRectShape1;
            // 
            // btnVerEnfermedad
            // 
            this.btnVerEnfermedad.Font = new System.Drawing.Font("Yanone Kaffeesatz Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerEnfermedad.Image = global::SisOxi.WinUI.Properties.Resources.Gnome_Zoom_Fit_Best_48;
            this.btnVerEnfermedad.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnVerEnfermedad.Location = new System.Drawing.Point(502, 101);
            this.btnVerEnfermedad.Name = "btnVerEnfermedad";
            this.btnVerEnfermedad.Size = new System.Drawing.Size(161, 58);
            this.btnVerEnfermedad.TabIndex = 93;
            this.btnVerEnfermedad.Text = "<html>Ver Enfermedad <br>Asociada</html>";
            this.btnVerEnfermedad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVerEnfermedad.Click += new System.EventHandler(this.btnVerEnfermedad_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnVerEnfermedad.GetChildAt(0))).Image = global::SisOxi.WinUI.Properties.Resources.Gnome_Zoom_Fit_Best_48;
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnVerEnfermedad.GetChildAt(0))).TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnVerEnfermedad.GetChildAt(0))).ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnVerEnfermedad.GetChildAt(0))).Text = "<html>Ver Enfermedad <br>Asociada</html>";
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnVerEnfermedad.GetChildAt(0))).Shape = this.roundRectShape1;
            // 
            // radButton1
            // 
            this.radButton1.Font = new System.Drawing.Font("Yanone Kaffeesatz Light", 12F);
            this.radButton1.Image = global::SisOxi.WinUI.Properties.Resources.Gnome_Process_Stop_48;
            this.radButton1.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.radButton1.Location = new System.Drawing.Point(14, 168);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(70, 72);
            this.radButton1.TabIndex = 88;
            this.radButton1.Text = "Cancelar";
            this.radButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.radButton1.GetChildAt(0))).Image = global::SisOxi.WinUI.Properties.Resources.Gnome_Process_Stop_48;
            ((Telerik.WinControls.UI.RadButtonElement)(this.radButton1.GetChildAt(0))).TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            ((Telerik.WinControls.UI.RadButtonElement)(this.radButton1.GetChildAt(0))).ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            ((Telerik.WinControls.UI.RadButtonElement)(this.radButton1.GetChildAt(0))).Text = "Cancelar";
            ((Telerik.WinControls.UI.RadButtonElement)(this.radButton1.GetChildAt(0))).Shape = this.roundRectShape1;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = false;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Controls.Add(this.btnReportes);
            this.lblTitulo.Controls.Add(this.btnTratamiento);
            this.lblTitulo.Font = new System.Drawing.Font("Yanone Kaffeesatz Regular", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(105)))), ((int)(((byte)(133)))));
            this.lblTitulo.Image = global::SisOxi.WinUI.Properties.Resources.DNA_Double_Helix;
            this.lblTitulo.Location = new System.Drawing.Point(321, 12);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            // 
            // 
            // 
            this.lblTitulo.RootElement.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lblTitulo.Size = new System.Drawing.Size(268, 59);
            this.lblTitulo.TabIndex = 87;
            this.lblTitulo.Text = "   IMPRESIÓN DIAGNÓSTICA";
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
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Yanone Kaffeesatz Light", 12F);
            this.btnNuevo.Image = global::SisOxi.WinUI.Properties.Resources.Gnome_Media_Floppy_48;
            this.btnNuevo.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNuevo.Location = new System.Drawing.Point(14, 85);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(70, 72);
            this.btnNuevo.TabIndex = 5;
            this.btnNuevo.TabStop = false;
            this.btnNuevo.Text = "Guardar";
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnNuevo.GetChildAt(0))).Image = global::SisOxi.WinUI.Properties.Resources.Gnome_Media_Floppy_48;
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnNuevo.GetChildAt(0))).TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnNuevo.GetChildAt(0))).ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnNuevo.GetChildAt(0))).Text = "Guardar";
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnNuevo.GetChildAt(0))).Shape = this.roundRectShape1;
            // 
            // ImpresionDiagnosticaUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 553);
            this.Controls.Add(this.rgbSesiones);
            this.Controls.Add(this.radButton1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.radLabel4);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.btnNuevo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ImpresionDiagnosticaUI";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Impresion Diagnostica";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.ImpresionDiagnosticaUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            this.radLabel4.ResumeLayout(false);
            this.radLabel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboEnfermedad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            this.radLabel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rgbSesiones)).EndInit();
            this.rgbSesiones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lstEnfermedadesAsociadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVerEnfermedad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTitulo)).EndInit();
            this.lblTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnReportes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTratamiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNuevo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel lblTitulo;
        private Telerik.WinControls.UI.RadButton btnReportes;
        private Telerik.WinControls.UI.RadButton btnTratamiento;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadDropDownList cboEnfermedad;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadButton btnNuevo;
        private Telerik.WinControls.UI.RadButton radButton1;
        private System.Windows.Forms.RichTextBox txtObservaciones;
        private Telerik.WinControls.RoundRectShape roundRectShape1;
        private Telerik.WinControls.UI.RadGroupBox rgbSesiones;
        private Telerik.WinControls.UI.RadButton btnEliminar;
        private Telerik.WinControls.UI.RadButton btnAgregar;
        private Telerik.WinControls.UI.RadButton btnVerEnfermedad;
        private Telerik.WinControls.UI.RadListView lstEnfermedadesAsociadas;
        private Telerik.WinControls.Tests.DonutShape donutShape1;
    }
}
