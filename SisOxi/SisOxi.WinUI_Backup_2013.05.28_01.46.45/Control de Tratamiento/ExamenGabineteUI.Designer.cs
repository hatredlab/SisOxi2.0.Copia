namespace SisOxi.WinUI
{
    partial class ExamenGabineteUI
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
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.txtObservaciones = new Telerik.WinControls.UI.RadTextBox();
            this.dtFechaExamen = new Telerik.WinControls.UI.RadDateTimePicker();
            this.radLabel22 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.cboTipoExamen = new Telerik.WinControls.UI.RadDropDownList();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.btnNuevo = new Telerik.WinControls.UI.RadButton();
            this.lblTitulo = new Telerik.WinControls.UI.RadLabel();
            this.btnReportes = new Telerik.WinControls.UI.RadButton();
            this.btnTratamiento = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            this.radLabel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaExamen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel22)).BeginInit();
            this.radLabel22.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            this.radLabel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboTipoExamen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNuevo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTitulo)).BeginInit();
            this.lblTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnReportes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTratamiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radLabel3
            // 
            this.radLabel3.AutoSize = false;
            this.radLabel3.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.radLabel3.Controls.Add(this.txtObservaciones);
            this.radLabel3.Font = new System.Drawing.Font("Yanone Kaffeesatz Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.radLabel3.Location = new System.Drawing.Point(112, 185);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(489, 186);
            this.radLabel3.TabIndex = 5;
            this.radLabel3.Text = "   Observaciones";
            this.radLabel3.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.radLabel3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservaciones.Location = new System.Drawing.Point(144, 14);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            // 
            // 
            // 
            this.txtObservaciones.RootElement.StretchVertically = true;
            this.txtObservaciones.Size = new System.Drawing.Size(324, 158);
            this.txtObservaciones.TabIndex = 6;
            this.txtObservaciones.TabStop = false;
            // 
            // dtFechaExamen
            // 
            this.dtFechaExamen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFechaExamen.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtFechaExamen.Location = new System.Drawing.Point(144, 7);
            this.dtFechaExamen.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtFechaExamen.MinDate = new System.DateTime(((long)(0)));
            this.dtFechaExamen.Name = "dtFechaExamen";
            this.dtFechaExamen.NullableValue = new System.DateTime(2013, 1, 31, 16, 22, 15, 996);
            this.dtFechaExamen.NullDate = new System.DateTime(((long)(0)));
            this.dtFechaExamen.Size = new System.Drawing.Size(324, 22);
            this.dtFechaExamen.TabIndex = 4;
            this.dtFechaExamen.TabStop = false;
            this.dtFechaExamen.Text = "jueves, 31 de enero de 2013";
            this.dtFechaExamen.Value = new System.DateTime(2013, 1, 31, 16, 22, 15, 996);
            // 
            // radLabel22
            // 
            this.radLabel22.AutoSize = false;
            this.radLabel22.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.radLabel22.Controls.Add(this.dtFechaExamen);
            this.radLabel22.Font = new System.Drawing.Font("Yanone Kaffeesatz Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.radLabel22.Location = new System.Drawing.Point(112, 139);
            this.radLabel22.Name = "radLabel22";
            this.radLabel22.Size = new System.Drawing.Size(489, 35);
            this.radLabel22.TabIndex = 3;
            this.radLabel22.Text = "Fecha del Examen";
            this.radLabel22.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.radLabel22.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // radLabel4
            // 
            this.radLabel4.AutoSize = false;
            this.radLabel4.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.radLabel4.Controls.Add(this.cboTipoExamen);
            this.radLabel4.Font = new System.Drawing.Font("Yanone Kaffeesatz Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.radLabel4.Location = new System.Drawing.Point(112, 93);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(489, 35);
            this.radLabel4.TabIndex = 1;
            this.radLabel4.Text = "  Tipo Examen";
            this.radLabel4.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.radLabel4.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // cboTipoExamen
            // 
            this.cboTipoExamen.DropDownAnimationEnabled = true;
            this.cboTipoExamen.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.cboTipoExamen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoExamen.Location = new System.Drawing.Point(144, 6);
            this.cboTipoExamen.MaxDropDownItems = 0;
            this.cboTipoExamen.Name = "cboTipoExamen";
            this.cboTipoExamen.ShowImageInEditorArea = true;
            this.cboTipoExamen.Size = new System.Drawing.Size(324, 22);
            this.cboTipoExamen.TabIndex = 2;
            this.cboTipoExamen.Text = "   --Seleccione Tipo--";
            // 
            // radButton1
            // 
            this.radButton1.Font = new System.Drawing.Font("Yanone Kaffeesatz Light", 12F);
            this.radButton1.Image = global::SisOxi.WinUI.Properties.Resources.Gnome_Process_Stop_48;
            this.radButton1.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.radButton1.Location = new System.Drawing.Point(21, 175);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(70, 72);
            this.radButton1.TabIndex = 90;
            this.radButton1.Text = "Cancelar";
            this.radButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Yanone Kaffeesatz Light", 12F);
            this.btnNuevo.Image = global::SisOxi.WinUI.Properties.Resources.Gnome_Media_Floppy_48;
            this.btnNuevo.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNuevo.Location = new System.Drawing.Point(21, 92);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(70, 72);
            this.btnNuevo.TabIndex = 7;
            this.btnNuevo.Text = "Guardar";
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = false;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Controls.Add(this.btnReportes);
            this.lblTitulo.Controls.Add(this.btnTratamiento);
            this.lblTitulo.Font = new System.Drawing.Font("Yanone Kaffeesatz Regular", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(105)))), ((int)(((byte)(133)))));
            this.lblTitulo.Image = global::SisOxi.WinUI.Properties.Resources.Accessories_Dictionary_64;
            this.lblTitulo.Location = new System.Drawing.Point(189, 4);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            // 
            // 
            // 
            this.lblTitulo.RootElement.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lblTitulo.Size = new System.Drawing.Size(268, 83);
            this.lblTitulo.TabIndex = 84;
            this.lblTitulo.Text = "   EXAMENES DE GABINETE";
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
            // ExamenGabineteUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 385);
            this.Controls.Add(this.radButton1);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.radLabel4);
            this.Controls.Add(this.radLabel22);
            this.Controls.Add(this.radLabel3);
            this.Name = "ExamenGabineteUI";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Examen de Gabinete";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.ExamenGabineteUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            this.radLabel3.ResumeLayout(false);
            this.radLabel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaExamen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel22)).EndInit();
            this.radLabel22.ResumeLayout(false);
            this.radLabel22.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            this.radLabel4.ResumeLayout(false);
            this.radLabel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboTipoExamen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNuevo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTitulo)).EndInit();
            this.lblTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnReportes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTratamiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadTextBox txtObservaciones;
        private Telerik.WinControls.UI.RadDateTimePicker dtFechaExamen;
        private Telerik.WinControls.UI.RadLabel radLabel22;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadDropDownList cboTipoExamen;
        private Telerik.WinControls.UI.RadLabel lblTitulo;
        private Telerik.WinControls.UI.RadButton btnReportes;
        private Telerik.WinControls.UI.RadButton btnTratamiento;
        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.UI.RadButton btnNuevo;
    }
}
