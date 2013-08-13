namespace SisOxi.WinUI
{
    partial class EnfermedadReporteUI
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
            this.lstImpresionDiagnostica = new Telerik.WinControls.UI.RadListView();
            this.lblTitulo = new Telerik.WinControls.UI.RadLabel();
            this.btnReportes = new Telerik.WinControls.UI.RadButton();
            this.btnTratamiento = new Telerik.WinControls.UI.RadButton();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.btnBuscar = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.lstImpresionDiagnostica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTitulo)).BeginInit();
            this.lblTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnReportes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTratamiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // lstImpresionDiagnostica
            // 
            this.lstImpresionDiagnostica.AllowArbitraryItemHeight = true;
            this.lstImpresionDiagnostica.AllowEdit = false;
            this.lstImpresionDiagnostica.AllowRemove = false;
            this.lstImpresionDiagnostica.Font = new System.Drawing.Font("Yanone Kaffeesatz Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstImpresionDiagnostica.ItemSpacing = -1;
            this.lstImpresionDiagnostica.Location = new System.Drawing.Point(45, 69);
            this.lstImpresionDiagnostica.Name = "lstImpresionDiagnostica";
            this.lstImpresionDiagnostica.Size = new System.Drawing.Size(534, 174);
            this.lstImpresionDiagnostica.TabIndex = 94;
            this.lstImpresionDiagnostica.Text = "radListView1";
            this.lstImpresionDiagnostica.ViewType = Telerik.WinControls.UI.ListViewType.DetailsView;
            this.lstImpresionDiagnostica.CellFormatting += new Telerik.WinControls.UI.ListViewCellFormattingEventHandler(this.lstImpresionDiagnostica_CellFormatting);
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
            this.lblTitulo.Location = new System.Drawing.Point(161, 12);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            // 
            // 
            // 
            this.lblTitulo.RootElement.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lblTitulo.Size = new System.Drawing.Size(280, 51);
            this.lblTitulo.TabIndex = 93;
            this.lblTitulo.Text = "   SELECCIONE ENFERMEDAD";
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
            // radButton1
            // 
            this.radButton1.Font = new System.Drawing.Font("Yanone Kaffeesatz Light", 12F);
            this.radButton1.Image = global::SisOxi.WinUI.Properties.Resources.Gnome_Process_Stop_48;
            this.radButton1.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.radButton1.Location = new System.Drawing.Point(333, 266);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(108, 56);
            this.radButton1.TabIndex = 92;
            this.radButton1.Text = "Cancelar";
            this.radButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            ((Telerik.WinControls.UI.RadButtonElement)(this.radButton1.GetChildAt(0))).Image = global::SisOxi.WinUI.Properties.Resources.Gnome_Process_Stop_48;
            ((Telerik.WinControls.UI.RadButtonElement)(this.radButton1.GetChildAt(0))).TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            ((Telerik.WinControls.UI.RadButtonElement)(this.radButton1.GetChildAt(0))).ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            ((Telerik.WinControls.UI.RadButtonElement)(this.radButton1.GetChildAt(0))).Text = "Cancelar";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Yanone Kaffeesatz Light", 12F);
            this.btnBuscar.Image = global::SisOxi.WinUI.Properties.Resources.Dialog_Apply_48;
            this.btnBuscar.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBuscar.Location = new System.Drawing.Point(192, 266);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(108, 56);
            this.btnBuscar.TabIndex = 91;
            this.btnBuscar.Text = "Aceptar";
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnBuscar.GetChildAt(0))).Image = global::SisOxi.WinUI.Properties.Resources.Dialog_Apply_48;
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnBuscar.GetChildAt(0))).TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnBuscar.GetChildAt(0))).ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnBuscar.GetChildAt(0))).Text = "Aceptar";
            // 
            // EnfermedadReporteUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 342);
            this.Controls.Add(this.lstImpresionDiagnostica);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.radButton1);
            this.Controls.Add(this.btnBuscar);
            this.Name = "EnfermedadReporteUI";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "EnfermedadReporteUI";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.EnfermedadReporteUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lstImpresionDiagnostica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTitulo)).EndInit();
            this.lblTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnReportes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTratamiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadListView lstImpresionDiagnostica;
        private Telerik.WinControls.UI.RadLabel lblTitulo;
        private Telerik.WinControls.UI.RadButton btnReportes;
        private Telerik.WinControls.UI.RadButton btnTratamiento;
        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.UI.RadButton btnBuscar;
    }
}
