namespace SisOxi.WinUI
{
    partial class TipoTratamientoUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TipoTratamientoUI));
            this.radLabel18 = new Telerik.WinControls.UI.RadLabel();
            this.cboTipoTratamiento = new Telerik.WinControls.UI.RadDropDownList();
            this.lstImpresionDiagnostica = new Telerik.WinControls.UI.RadListView();
            this.cboImpresionDiagnostica = new Telerik.WinControls.UI.RadDropDownList();
            this.lblTitulo = new Telerik.WinControls.UI.RadLabel();
            this.btnReportes = new Telerik.WinControls.UI.RadButton();
            this.btnTratamiento = new Telerik.WinControls.UI.RadButton();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.btnBuscar = new Telerik.WinControls.UI.RadButton();
            this.roundRectShape1 = new Telerik.WinControls.RoundRectShape(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.radLabel18)).BeginInit();
            this.radLabel18.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboTipoTratamiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstImpresionDiagnostica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboImpresionDiagnostica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTitulo)).BeginInit();
            this.lblTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnReportes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTratamiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radLabel18
            // 
            this.radLabel18.AutoSize = false;
            this.radLabel18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.radLabel18.Controls.Add(this.cboTipoTratamiento);
            this.radLabel18.Font = new System.Drawing.Font("Yanone Kaffeesatz Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.radLabel18.Location = new System.Drawing.Point(28, 261);
            this.radLabel18.Name = "radLabel18";
            this.radLabel18.Size = new System.Drawing.Size(536, 35);
            this.radLabel18.TabIndex = 77;
            this.radLabel18.Text = "  Tipo de Tratamiento";
            this.radLabel18.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.radLabel18.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // cboTipoTratamiento
            // 
            this.cboTipoTratamiento.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.cboTipoTratamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            radListDataItem1.Text = "Camara Hiperbarica";
            radListDataItem1.TextWrap = true;
            radListDataItem2.Text = "Tratamiento Alterno";
            radListDataItem2.TextWrap = true;
            this.cboTipoTratamiento.Items.Add(radListDataItem1);
            this.cboTipoTratamiento.Items.Add(radListDataItem2);
            this.cboTipoTratamiento.Location = new System.Drawing.Point(160, 6);
            this.cboTipoTratamiento.Name = "cboTipoTratamiento";
            this.cboTipoTratamiento.Size = new System.Drawing.Size(356, 22);
            this.cboTipoTratamiento.TabIndex = 49;
            this.cboTipoTratamiento.Text = "--Seleccione--";
            // 
            // lstImpresionDiagnostica
            // 
            this.lstImpresionDiagnostica.AllowArbitraryItemHeight = true;
            this.lstImpresionDiagnostica.AllowEdit = false;
            this.lstImpresionDiagnostica.AllowRemove = false;
            this.lstImpresionDiagnostica.Font = new System.Drawing.Font("Yanone Kaffeesatz Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstImpresionDiagnostica.ItemSpacing = -1;
            this.lstImpresionDiagnostica.Location = new System.Drawing.Point(30, 72);
            this.lstImpresionDiagnostica.Name = "lstImpresionDiagnostica";
            this.lstImpresionDiagnostica.Size = new System.Drawing.Size(534, 174);
            this.lstImpresionDiagnostica.TabIndex = 90;
            this.lstImpresionDiagnostica.Text = "radListView1";
            this.lstImpresionDiagnostica.ViewType = Telerik.WinControls.UI.ListViewType.DetailsView;
            this.lstImpresionDiagnostica.SelectedItemChanged += new System.EventHandler(this.lstImpresionDiagnostica_SelectedItemChanged);
            this.lstImpresionDiagnostica.SelectedIndexChanged += new System.EventHandler(this.lstImpresionDiagnostica_SelectedIndexChanged);
            this.lstImpresionDiagnostica.CellFormatting += new Telerik.WinControls.UI.ListViewCellFormattingEventHandler(this.lstImpresionDiagnostica_CellFormatting_1);
            // 
            // cboImpresionDiagnostica
            // 
            this.cboImpresionDiagnostica.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.cboImpresionDiagnostica.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            radListDataItem3.Text = "Camara Hiperbarica";
            radListDataItem3.TextWrap = true;
            radListDataItem4.Text = "Tratamiento Alterno";
            radListDataItem4.TextWrap = true;
            this.cboImpresionDiagnostica.Items.Add(radListDataItem3);
            this.cboImpresionDiagnostica.Items.Add(radListDataItem4);
            this.cboImpresionDiagnostica.Location = new System.Drawing.Point(160, 6);
            this.cboImpresionDiagnostica.Name = "cboImpresionDiagnostica";
            this.cboImpresionDiagnostica.Size = new System.Drawing.Size(356, 22);
            this.cboImpresionDiagnostica.TabIndex = 49;
            this.cboImpresionDiagnostica.Text = "--Seleccione--";
            this.cboImpresionDiagnostica.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.cboImpresionDiagnostica_SelectedIndexChanged);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = false;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Controls.Add(this.btnReportes);
            this.lblTitulo.Controls.Add(this.btnTratamiento);
            this.lblTitulo.Font = new System.Drawing.Font("Yanone Kaffeesatz Regular", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(105)))), ((int)(((byte)(133)))));
            this.lblTitulo.Image = global::SisOxi.WinUI.Properties.Resources._33272_icon;
            this.lblTitulo.Location = new System.Drawing.Point(195, 15);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            // 
            // 
            // 
            this.lblTitulo.RootElement.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lblTitulo.Size = new System.Drawing.Size(215, 51);
            this.lblTitulo.TabIndex = 88;
            this.lblTitulo.Text = "   TIPO TRATAMIENTO";
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
            this.radButton1.Location = new System.Drawing.Point(294, 311);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(108, 56);
            this.radButton1.TabIndex = 86;
            this.radButton1.Text = "Cancelar";
            this.radButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.radButton1.GetChildAt(0))).Image = global::SisOxi.WinUI.Properties.Resources.Gnome_Process_Stop_48;
            ((Telerik.WinControls.UI.RadButtonElement)(this.radButton1.GetChildAt(0))).TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            ((Telerik.WinControls.UI.RadButtonElement)(this.radButton1.GetChildAt(0))).ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            ((Telerik.WinControls.UI.RadButtonElement)(this.radButton1.GetChildAt(0))).Text = "Cancelar";
            ((Telerik.WinControls.UI.RadButtonElement)(this.radButton1.GetChildAt(0))).Shape = this.roundRectShape1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Yanone Kaffeesatz Light", 12F);
            this.btnBuscar.Image = global::SisOxi.WinUI.Properties.Resources.Dialog_Apply_48;
            this.btnBuscar.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBuscar.Location = new System.Drawing.Point(163, 311);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(108, 56);
            this.btnBuscar.TabIndex = 85;
            this.btnBuscar.Text = "Aceptar";
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnBuscar.GetChildAt(0))).Image = global::SisOxi.WinUI.Properties.Resources.Dialog_Apply_48;
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnBuscar.GetChildAt(0))).TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnBuscar.GetChildAt(0))).ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnBuscar.GetChildAt(0))).Text = "Aceptar";
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnBuscar.GetChildAt(0))).Shape = this.roundRectShape1;
            // 
            // roundRectShape1
            // 
            this.roundRectShape1.Radius = 20;
            // 
            // TipoTratamientoUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 394);
            this.Controls.Add(this.lstImpresionDiagnostica);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.radButton1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.radLabel18);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TipoTratamientoUI";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tipo de Tratamiento";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.TipoTratamientoUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radLabel18)).EndInit();
            this.radLabel18.ResumeLayout(false);
            this.radLabel18.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboTipoTratamiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstImpresionDiagnostica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboImpresionDiagnostica)).EndInit();
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

        private Telerik.WinControls.UI.RadLabel radLabel18;
        private Telerik.WinControls.UI.RadDropDownList cboTipoTratamiento;
        private Telerik.WinControls.UI.RadButton btnBuscar;
        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.UI.RadLabel lblTitulo;
        private Telerik.WinControls.UI.RadButton btnReportes;
        private Telerik.WinControls.UI.RadButton btnTratamiento;
        private Telerik.WinControls.UI.RadListView lstImpresionDiagnostica;
        private Telerik.WinControls.UI.RadDropDownList cboImpresionDiagnostica;
        private Telerik.WinControls.RoundRectShape roundRectShape1;
    }
}
