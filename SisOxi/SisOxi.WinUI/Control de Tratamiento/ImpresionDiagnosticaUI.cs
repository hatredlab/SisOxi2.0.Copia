using SisOxi.BUS;
using SisOxi.BUS.Seguridad;
using SisOxi.VO;
using SisOxi.VO.Seguridad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using WinFormTelerikDS;
using SisOxi.WinUI.Control_de_Tratamiento;

namespace SisOxi.WinUI
{
    public partial class ImpresionDiagnosticaUI : Telerik.WinControls.UI.RadForm
    {
        private int idHistoriaClinica;
        private bool IsNuevo=false;
        private ImpresionDiagnosticaVO impresionDiagnosticaX;
        private HistoriaClinicaUI historiaClinicaUI;
        private DataTable Enfermedades;

        public ImpresionDiagnosticaUI()
        {
            InitializeComponent();
        }

        public ImpresionDiagnosticaUI(bool isNuevo,int idHC)
        {
            InitializeComponent();
            idHistoriaClinica = idHC;
        }

        public ImpresionDiagnosticaUI(bool isNuevoX, HistoriaClinicaUI historiaClinica, int idHC,DataTable dt)
        {
            InitializeComponent();
            IsNuevo = isNuevoX;
            historiaClinicaUI = historiaClinica;
            idHistoriaClinica = idHC;
            Enfermedades = dt;
            impresionDiagnosticaX = new ImpresionDiagnosticaVO();
        }

        public ImpresionDiagnosticaUI(bool isNuevoX, HistoriaClinicaUI historiaClinica, int idHC,ImpresionDiagnosticaVO iD)
        {
            InitializeComponent();
            IsNuevo = isNuevoX;
            historiaClinicaUI = historiaClinica;
            idHistoriaClinica = idHC;
            impresionDiagnosticaX = iD;
            //Enfermedades = dt;
        }

      
        private void ImpresionDiagnosticaUI_Load(object sender, EventArgs e)
        {
            CargarFormulario();
            
        }

        private void CargarFormulario()
        {
            WinFormTelerikDS.WinForm.ConvertirBordesRedondeadosLabelEnForm(this);
            
            if (IsNuevo == false)
            {
                CargarListViewImpresionDiagnostica();
                CargarComboEnfermedadModificar();
                cboEnfermedad.SelectedIndex = cboEnfermedad.FindStringExact(impresionDiagnosticaX.NombreEnfermedad);
                txtObservaciones.Text = impresionDiagnosticaX.Observaciones;

            }
            else
            {
                CargarComboEnfermedadNuevo();
                WinForm.BloquearButtonsListEnRadGroupBox(rgbSesiones);
                
            }
            WinForm.TabEnterEnForm(this);
        }

        private void CargarComboEnfermedadNuevo()
        {
            DataTable dt = new EnfermedadBUS().BuscarEnfermedad(Enfermedades);
            cboEnfermedad.DisplayMember = "nombre";
            cboEnfermedad.ValueMember = "idEnfermedad";
            cboEnfermedad.DataSource = dt;
            cboEnfermedad.Text = "--Seleccione--";
            cboEnfermedad.SelectedIndex = -1;
            cboEnfermedad.DataSource = dt;
            cboEnfermedad.DisplayMember = "nombre";
            cboEnfermedad.AutoCompleteDataSource = dt;
            cboEnfermedad.DropDownListElement.AutoCompleteDataSource = dt;
            cboEnfermedad.DropDownListElement.AutoCompleteDisplayMember = "nombre";
            cboEnfermedad.DropDownStyle = RadDropDownStyle.DropDown;
            cboEnfermedad.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboEnfermedad.DropDownListElement.AutoCompleteSuggest.SuggestMode = SuggestMode.Contains;
        }

        private void CargarComboEnfermedadModificar()
        {
            DataTable dt = new EnfermedadBUS().BuscarEnfermedad();
            cboEnfermedad.DisplayMember = "nombre";
            cboEnfermedad.ValueMember = "idEnfermedad";
            cboEnfermedad.DataSource = dt;
            cboEnfermedad.Text = "--Seleccione--";
            cboEnfermedad.SelectedIndex = -1;
            cboEnfermedad.DataSource = dt;
            cboEnfermedad.DisplayMember = "nombre";
            cboEnfermedad.AutoCompleteDataSource = dt;
            cboEnfermedad.DropDownListElement.AutoCompleteDataSource = dt;
            cboEnfermedad.DropDownListElement.AutoCompleteDisplayMember = "nombre";
            cboEnfermedad.DropDownStyle = RadDropDownStyle.DropDown;
            cboEnfermedad.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboEnfermedad.DropDownListElement.AutoCompleteSuggest.SuggestMode = SuggestMode.Contains;
        }

        private void AgregarImpresionDiagnostica()
        {
            try
            {
                ImpresionDiagnosticaVO impresionDiagnostica = new ImpresionDiagnosticaVO();
               
                impresionDiagnostica.IdEnfermedad = Convert.ToInt32(cboEnfermedad.SelectedValue);
                impresionDiagnostica.IdHistoriaClinica = idHistoriaClinica;
                impresionDiagnostica.Observaciones = txtObservaciones.Text;
                impresionDiagnosticaX.IdHistoriaClinica = idHistoriaClinica;
                impresionDiagnosticaX.IdImpresionDiagnostica = new ImpresionDiagnosticaBUS().AgregarImpresionDiagnostica(impresionDiagnostica);
                AuditoriaVO auditoria = new AuditoriaVO();
                auditoria.idEmpleado = PrincipalUI.idEmpleadogbl;
                auditoria.idRegistro = impresionDiagnosticaX.IdImpresionDiagnostica;
                auditoria.tabla = "ImpresionDiagnostica";
                auditoria.tipo = "INSERT";
                auditoria.fecha = DateTime.Now.ToLocalTime();
                new AuditoriaBUS().AgregarAuditoria(auditoria);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ModificarImpresionDiagnostica()
        {
            try
            {
                ImpresionDiagnosticaVO impresionDiagnostica = new ImpresionDiagnosticaVO();
                impresionDiagnostica.IdImpresionDiagnostica = impresionDiagnosticaX.IdImpresionDiagnostica;
                impresionDiagnostica.IdEnfermedad = Convert.ToInt32(cboEnfermedad.SelectedValue);
                impresionDiagnostica.IdHistoriaClinica = idHistoriaClinica;
                impresionDiagnostica.Observaciones = txtObservaciones.Text;
                new ImpresionDiagnosticaBUS().ModificarImpresionDiagnostica(impresionDiagnostica);
                AuditoriaVO auditoria = new AuditoriaVO();
                auditoria.idEmpleado = PrincipalUI.idEmpleadogbl;
                auditoria.idRegistro = impresionDiagnostica.IdImpresionDiagnostica;
                auditoria.tabla = "ImpresionDiagnostica";
                auditoria.tipo = "UPDATE";
                auditoria.fecha = DateTime.Now.ToLocalTime();
                new AuditoriaBUS().AgregarAuditoria(auditoria);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (IsNuevo)
            {

                if (WinForm.MensajeBox(this, "Impresión Diagnóstica", "¿Desea Guardar la Impresión Diagnóstica?", MensajeBox.pregunta) == DialogResult.Yes)
                {
                    AgregarImpresionDiagnostica();
                    WinForm.MensajeBox(this, "Impresión Diagnóstica", "Impresión Diagnóstica Agregada!", MensajeBox.informacion);
                    historiaClinicaUI.CargarListViewImpresionDiagnostica();
                    WinForm.DesbloquearButtonsListEnRadGroupBox(rgbSesiones);
                }
            }
            else
            {
                if (WinForm.MensajeBox(this, "Impresión Diagnóstica", "¿Desea Modificar la Impresión Diagnóstica?", MensajeBox.pregunta) == DialogResult.Yes)
                {
                    ModificarImpresionDiagnostica();
                    WinForm.MensajeBox(this, "Impresión Diagnóstica", "Impresión Diagnóstica Modificada!", MensajeBox.informacion);
                    historiaClinicaUI.CargarListViewImpresionDiagnostica();
                    
                }
            }
               
            

        }

        private void radButton3_Click(object sender, EventArgs e)
        {
            if (lstEnfermedadesAsociadas.Items.Count <= 3)
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("nombre", typeof(string));

                foreach (ListViewDataItem item in lstEnfermedadesAsociadas.Items)
                {
                    dt.Rows.Add(item["nombre"].ToString());

                }
                new EnfermedadAsociadaUI(true, impresionDiagnosticaX, this, dt).ShowDialog();
            }
            else
            {
                WinForm.MensajeBox(this, "Enfermedades Asociadas", "Se ha llegado al maximo de Enfermedades Asociadas (4)!", MensajeBox.advertencia);
            }
        }

        public void CargarListViewImpresionDiagnostica()
        {
            
            DataTable dt = new ImpresionDiagnosticaBUS().BuscarImpresionDiagnosticaPorIDImpresionDiagnosticaAlterna(impresionDiagnosticaX.IdImpresionDiagnostica);
            lstEnfermedadesAsociadas.DataSource = dt;
            
            List<int> columnasMostradas = new List<int> { 5 };
            for (int i = 0; i < lstEnfermedadesAsociadas.Columns.Count; i++)
            {
                if (!columnasMostradas.Contains(i))
                {
                    lstEnfermedadesAsociadas.Columns[i].Visible = false;
                }

            }
            lstEnfermedadesAsociadas.AllowEdit = false;
            lstEnfermedadesAsociadas.Columns[5].HeaderText = "Enfermedad Asociada";
            lstEnfermedadesAsociadas.Columns[5].Width = 464;
            lstEnfermedadesAsociadas.Refresh();
            lstEnfermedadesAsociadas.Select();
        }

        private ImpresionDiagnosticaVO SeleccionarItemLstImpresionDiagnostica()
        {
            ImpresionDiagnosticaVO impresionDiagnostica = new ImpresionDiagnosticaVO();
            ListViewSelectedItemCollection col = lstEnfermedadesAsociadas.SelectedItems;
            foreach (ListViewDataItem item in col)
            {
                //impresionDiagnostica.IdImpresionDiagnostica = Convert.ToInt32(item[0]);
                //impresionDiagnostica.Observaciones = item[1].ToString();
                //impresionDiagnostica.IdEnfermedad = Convert.ToInt32(item[2]);
                //impresionDiagnostica.IdHistoriaClinica = Convert.ToInt32(item[3]);
                //impresionDiagnostica.NombreEnfermedad = item[4].ToString();
                impresionDiagnostica = Clases.LlenarObjetoConRegistroListViewDataItem<ImpresionDiagnosticaVO>(item);
                impresionDiagnostica.NombreEnfermedad = item["nombre"].ToString();
            }

            return impresionDiagnostica;
        }

        private void lstEnfermedadesAsociadas_CellFormatting(object sender, ListViewCellFormattingEventArgs e)
        {
            if (e.CellElement is DetailListViewHeaderCellElement)
            {
                e.CellElement.BackColor = Color.FromArgb(17, 105, 133);
                e.CellElement.ForeColor = Color.FromArgb(191, 219, 255);
                e.CellElement.BorderColor = Color.FromArgb(17, 105, 133);
                e.CellElement.Font = new Font(e.CellElement.Font.FontFamily.Name, 14);
                e.CellElement.NumberOfColors = 1;
            }
            else
            {
                e.CellElement.ResetValue(LightVisualElement.BackColorProperty);
            }
        }

        private void btnVerEnfermedad_Click(object sender, EventArgs e)
        {
            if (lstEnfermedadesAsociadas.SelectedItems.Count > 0)
            {
                new EnfermedadAsociadaUI(false, SeleccionarItemLstImpresionDiagnostica(), this).ShowDialog();
            }
            else
            {
                WinForm.MensajeBox(this, "Enfermedades Asociadas", "No ha seleccionado una Enfermedad Asociada!", MensajeBox.advertencia);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lstEnfermedadesAsociadas.SelectedItems.Count > 0)
            {
                if (WinForm.MensajeBox(this, "Enfermedad Asociada", "¿Desea Eliminar la Enfermedad Asociada?", MensajeBox.pregunta) == DialogResult.Yes)
                {
                    new ImpresionDiagnosticaBUS().EliminarImpresionDiagnosticaAlterna(SeleccionarItemLstImpresionDiagnostica().IdImpresionDiagnostica);
                    WinForm.MensajeBox(this, "Enfermedad Asociada", "Enfermedad Asociada Eliminada!", MensajeBox.informacion);
                    CargarListViewImpresionDiagnostica();
             
                }
            }
            else
            {
                WinForm.MensajeBox(this, "Enfermedades Asociadas", "No ha seleccionado una Enfermedad Asociada!", MensajeBox.advertencia);
            }
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
