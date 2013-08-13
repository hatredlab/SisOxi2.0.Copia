using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using SisOxi.BUS;
using SisOxi.VO;
using System.Reflection;

namespace SisOxi.WinUI
{
    public partial class BuscarHistoriaClinicaUI : Telerik.WinControls.UI.RadForm
    {

        private HistoriaClinicaUI historiaClinicaUI;

        public BuscarHistoriaClinicaUI()
        {
            InitializeComponent();
        }

        public BuscarHistoriaClinicaUI(HistoriaClinicaUI historiaUI)
        {
            InitializeComponent();
            historiaClinicaUI = historiaUI;
        }

        private void BuscarHistoriaClinicaUI_Load(object sender, EventArgs e)
        {
            CargarFormulario();
        }

        private void BuscarHistoriaClinica(string busqueda)
        {
            dgvHistoriaClinica.DataSource = new HistoriaClinicaBUS().BuscarHistoriaClinica(busqueda);
            //List<int> columnasMostradas = new List<int> { 1, 2, 3, 4, 5, 7, 8 };
            //for (int i = 0; i < dgvHistoriaClinica.Columns.Count; i++)
            //{
            //    if (!columnasMostradas.Contains(i))
            //    {
            //        dgvHistoriaClinica.Columns[i].IsVisible = false;
            //    }

            //}
        }

        private void CargarFormulario()
        {
            WinFormTelerikDS.WinForm.ConvertirBordesRedondeadosLabelEnForm(this);
        }

        private void EnviaHistoriaClinica()
        {
            HistoriaClinicaVO historiaClinica = new HistoriaClinicaVO();
            DatosClinicosVO datosClinico = new DatosClinicosVO();
            PropertyInfo[] props = typeof(HistoriaClinicaVO).GetProperties();
            PropertyInfo[] props1 = typeof(DatosClinicosVO).GetProperties();
            int i = 0;
            foreach (PropertyInfo prop in props)
            {
                if (prop.PropertyType == typeof(int))
                {
                    prop.SetValue(historiaClinica, Convert.ToInt32(dgvHistoriaClinica.SelectedRows[0].Cells[dgvHistoriaClinica.Columns.IndexOf(char.ToLower(prop.Name[0]) + prop.Name.ToString().Substring(1))].Value), null);
                    i++;
                }
                else if (prop.PropertyType == typeof(DateTime))
                {
                    prop.SetValue(historiaClinica, Convert.ToDateTime(dgvHistoriaClinica.SelectedRows[0].Cells[dgvHistoriaClinica.Columns.IndexOf(char.ToLower(prop.Name[0]) + prop.Name.ToString().Substring(1))].Value), null);
                    i++;
                }
                else
                {
                    prop.SetValue(historiaClinica, dgvHistoriaClinica.SelectedRows[0].Cells[dgvHistoriaClinica.Columns.IndexOf(char.ToLower(prop.Name[0]) + prop.Name.ToString().Substring(1))].Value.ToString(), null);
                    i++;
                }
                
            }

            foreach (PropertyInfo prop in props1)
            {
                if (prop.PropertyType == typeof(int))
                {
                    prop.SetValue(datosClinico, Convert.ToInt32(dgvHistoriaClinica.SelectedRows[0].Cells[dgvHistoriaClinica.Columns.IndexOf(char.ToLower(prop.Name[0]) + prop.Name.ToString().Substring(1))].Value), null);
                    i++;
                }
                else if (prop.PropertyType == typeof(DateTime))
                {
                    prop.SetValue(datosClinico, Convert.ToDateTime(dgvHistoriaClinica.SelectedRows[0].Cells[dgvHistoriaClinica.Columns.IndexOf(char.ToLower(prop.Name[0]) + prop.Name.ToString().Substring(1))].Value), null);
                    i++;
                }
                else
                {
                    prop.SetValue(datosClinico, dgvHistoriaClinica.SelectedRows[0].Cells[dgvHistoriaClinica.Columns.IndexOf(char.ToLower(prop.Name[0]) + prop.Name.ToString().Substring(1))].Value.ToString(), null);
                    i++;
                }

            }

            historiaClinicaUI.RecibirHistoriaClinica(historiaClinica,datosClinico);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                BuscarHistoriaClinica(txtBusqueda.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo conectar a la BD");
            }
        }

        private void dgvHistoriaClinica_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            EnviaHistoriaClinica();
            this.Hide();
        }

        private void dgvHistoriaClinica_Click(object sender, EventArgs e)
        {

        }
    }
}
