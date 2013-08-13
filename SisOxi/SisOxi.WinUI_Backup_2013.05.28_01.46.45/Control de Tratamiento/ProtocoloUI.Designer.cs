namespace SisOxi.WinUI
{
    partial class ProtocoloUI
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
            this.dgvTablaDeConversiones = new Telerik.WinControls.UI.RadGridView();
            this.radLabel7 = new Telerik.WinControls.UI.RadLabel();
            this.rbtC = new System.Windows.Forms.RadioButton();
            this.rbtA = new System.Windows.Forms.RadioButton();
            this.rbtB = new System.Windows.Forms.RadioButton();
            this.radButton3 = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaDeConversiones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaDeConversiones.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel7)).BeginInit();
            this.radLabel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTablaDeConversiones
            // 
            this.dgvTablaDeConversiones.AutoSizeRows = true;
            this.dgvTablaDeConversiones.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dgvTablaDeConversiones.Location = new System.Drawing.Point(24, 78);
            // 
            // dgvTablaDeConversiones
            // 
            this.dgvTablaDeConversiones.MasterTemplate.AllowAddNewRow = false;
            this.dgvTablaDeConversiones.MasterTemplate.AllowCellContextMenu = false;
            this.dgvTablaDeConversiones.MasterTemplate.AllowColumnChooser = false;
            this.dgvTablaDeConversiones.MasterTemplate.AllowColumnReorder = false;
            this.dgvTablaDeConversiones.MasterTemplate.AllowDeleteRow = false;
            this.dgvTablaDeConversiones.MasterTemplate.AllowDragToGroup = false;
            this.dgvTablaDeConversiones.MasterTemplate.AllowEditRow = false;
            this.dgvTablaDeConversiones.MasterTemplate.AllowRowResize = false;
            this.dgvTablaDeConversiones.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.dgvTablaDeConversiones.MasterTemplate.EnableGrouping = false;
            this.dgvTablaDeConversiones.Name = "dgvTablaDeConversiones";
            this.dgvTablaDeConversiones.Size = new System.Drawing.Size(539, 404);
            this.dgvTablaDeConversiones.TabIndex = 4;
            this.dgvTablaDeConversiones.Text = "dgvConversiones";
            // 
            // radLabel7
            // 
            this.radLabel7.AutoSize = false;
            this.radLabel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.radLabel7.Controls.Add(this.rbtC);
            this.radLabel7.Controls.Add(this.rbtA);
            this.radLabel7.Controls.Add(this.rbtB);
            this.radLabel7.Font = new System.Drawing.Font("Yanone Kaffeesatz Light", 14F);
            this.radLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.radLabel7.Location = new System.Drawing.Point(24, 24);
            this.radLabel7.Name = "radLabel7";
            this.radLabel7.Size = new System.Drawing.Size(411, 35);
            this.radLabel7.TabIndex = 66;
            this.radLabel7.Text = "  Tabla de Conversiones";
            this.radLabel7.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.radLabel7.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // rbtC
            // 
            this.rbtC.AutoSize = true;
            this.rbtC.Font = new System.Drawing.Font("Yanone Kaffeesatz Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtC.Location = new System.Drawing.Point(355, 6);
            this.rbtC.Name = "rbtC";
            this.rbtC.Size = new System.Drawing.Size(35, 26);
            this.rbtC.TabIndex = 32;
            this.rbtC.Text = "C";
            this.rbtC.UseVisualStyleBackColor = true;
            // 
            // rbtA
            // 
            this.rbtA.AutoSize = true;
            this.rbtA.Checked = true;
            this.rbtA.Font = new System.Drawing.Font("Yanone Kaffeesatz Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtA.Location = new System.Drawing.Point(240, 5);
            this.rbtA.Name = "rbtA";
            this.rbtA.Size = new System.Drawing.Size(36, 26);
            this.rbtA.TabIndex = 30;
            this.rbtA.TabStop = true;
            this.rbtA.Text = "A";
            this.rbtA.UseVisualStyleBackColor = true;
            // 
            // rbtB
            // 
            this.rbtB.AutoSize = true;
            this.rbtB.Font = new System.Drawing.Font("Yanone Kaffeesatz Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtB.Location = new System.Drawing.Point(299, 5);
            this.rbtB.Name = "rbtB";
            this.rbtB.Size = new System.Drawing.Size(35, 26);
            this.rbtB.TabIndex = 31;
            this.rbtB.Text = "B";
            this.rbtB.UseVisualStyleBackColor = true;
            // 
            // radButton3
            // 
            this.radButton3.Font = new System.Drawing.Font("Yanone Kaffeesatz Light", 12F);
            this.radButton3.Image = global::SisOxi.WinUI.Properties.Resources.Dialog_Apply_32;
            this.radButton3.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.radButton3.Location = new System.Drawing.Point(457, 24);
            this.radButton3.Name = "radButton3";
            this.radButton3.Size = new System.Drawing.Size(106, 35);
            this.radButton3.TabIndex = 78;
            this.radButton3.Text = " Aceptar";
            this.radButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radButton3.Click += new System.EventHandler(this.radButton3_Click);
            // 
            // ProtocoloUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 503);
            this.Controls.Add(this.radButton3);
            this.Controls.Add(this.radLabel7);
            this.Controls.Add(this.dgvTablaDeConversiones);
            this.Name = "ProtocoloUI";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Protocolos";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.ProtocoloUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaDeConversiones.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaDeConversiones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel7)).EndInit();
            this.radLabel7.ResumeLayout(false);
            this.radLabel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView dgvTablaDeConversiones;
        private Telerik.WinControls.UI.RadLabel radLabel7;
        private Telerik.WinControls.UI.RadButton radButton3;
        private System.Windows.Forms.RadioButton rbtC;
        private System.Windows.Forms.RadioButton rbtA;
        private System.Windows.Forms.RadioButton rbtB;
    }
}
