using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using SisOxi.BUS;
using System.Data.SqlClient;
using WinFormTelerikDS;

namespace SisOxi.WinUI
{
    public partial class ConexionUI : Telerik.WinControls.UI.RadForm
    {
        public ConexionUI()
        {
            InitializeComponent();
        }

        private void Conexion_Load(object sender, EventArgs e)
        {
            cboAutenticacion.SelectedIndex = -1;
            cargarConexion();
            radLabel1.Select();
            WinFormTelerikDS.WinForm.ConvertirBordesRedondeadosLabelEnForm(this);
        }


        private void cargarConexion()
        {
            List<string> conexion = new ConexionBUS().LeerConexion();
            txtHostName.Text = conexion[0];
            txtBD.Text = conexion[1];




            if (conexion.Count < 4)
            {
                txtHostName.Text = conexion[0];
                txtBD.Text = conexion[1];
                cboAutenticacion.SelectedIndex = 0;
                
            }
            else
            {
                txtHostName.Text = conexion[0];
                txtBD.Text = conexion[1];
                cboAutenticacion.SelectedIndex = 1;
                txtUsuario.Text = conexion[2];
                txtClave.Text = conexion[3];
            }
        }

        private  void agregarConexion()
        {
            try
            {
             
                DialogResult resultado = RadMessageBox.Show(this, "¿Realmente desea cambiar la Conexion a BD?", "Conexion BD", MessageBoxButtons.YesNo, RadMessageIcon.Question);
                
                if (resultado == DialogResult.Yes)
                {
                    string Conexion = string.Empty;

                    if (cboAutenticacion.SelectedIndex == 1)
                    {
                        Conexion = @"Data Source=" + txtHostName.Text + ";Initial Catalog=" + txtBD.Text + ";user=" + txtUsuario.Text + ";password=" + txtClave.Text;
                    }
                    else
                    {
                        Conexion = @"Data Source=" + txtHostName.Text + ";Initial Catalog=" + txtBD.Text + ";Integrated Security=true";
                    }
                    new ConexionBUS().EstablecerConexion(Conexion);
                    SqlConnection con = new SqlConnection(Conexion);
                    con.Open();
                    WinForm.MensajeBox(this, "Conexion BD", "Conexion Establecida!", MensajeBox.informacion);
                    con.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Conexion Incorrecta!");
            }
        }

        private void radButton3_Click(object sender, EventArgs e)
        {
            agregarConexion();
            cargarConexion();
        }

        private void cboAutenticacion_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void cboAutenticacion_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            if (cboAutenticacion.SelectedIndex == 0)
            {
                txtUsuario.Text = string.Empty;
                txtUsuario.Enabled = false;
                txtClave.Text = string.Empty;
                txtClave.Enabled = false;
            }
            else
            {

                txtUsuario.Enabled = true;
                txtClave.Enabled = true;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            agregarConexion();
            cargarConexion();
        }

        private void txtHostName_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == WinForm.MensajeBox(this, "Configuracion de Conexión", "¿Desea salir de la Configuracion de Conexión?", MensajeBox.pregunta))
            {
                this.Close();
            }
        }

       
    }
}
