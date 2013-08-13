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

namespace SisOxi.WinUI
{
    public partial class TratamientoCamaraHiperbaricaUI : Telerik.WinControls.UI.RadForm
    {
        private HistoriaClinicaUI historiaClinicaUI;
        private int PKImpresionDiagnostica;
        private int PKTratamientoCamaraHiperbarica;
        private int FKEmpleado;
        private int PKSesionTratamiento;
        private bool IsNuevo=false;
        private TratamientoCamaraHiperbaricaVO tratamientoCamaraHiperbarica;
        private bool IsNuevaSesionActiva = false;
        private bool IsModificarSesionActiva = false;

        public TratamientoCamaraHiperbaricaUI()
        {
            InitializeComponent();
        }

        public TratamientoCamaraHiperbaricaUI(bool isNuevoX, HistoriaClinicaUI historiaClinicaUIX, int PK)
        {
            InitializeComponent();
            IsNuevo = isNuevoX;
            historiaClinicaUI = historiaClinicaUIX;
            PKImpresionDiagnostica = PK;
        }

        public TratamientoCamaraHiperbaricaUI(bool isNuevoX, HistoriaClinicaUI historiaClinicaUIX, int PK,TratamientoCamaraHiperbaricaVO tratamiento)
        {
            InitializeComponent();
            IsNuevo = isNuevoX;
            historiaClinicaUI = historiaClinicaUIX;
            PKImpresionDiagnostica = PK;
            tratamientoCamaraHiperbarica = tratamiento;
            PKTratamientoCamaraHiperbarica = tratamiento.IdTratamiento;
        }

        private void TratamientoUI_Load(object sender, EventArgs e)
        {
            //cboEstadoTratamiento.Select();
            WinForm.TabEnterEnForm(this);
            WinForm.TabEnterEnGroupBox(rgbSesiones);
            CargarComboEstadoTratamiento();
            CargarFormulario();
            CargarComboEmpleado();
            CargarDGVSesiones(PKTratamientoCamaraHiperbarica);
            
        }

        private void CargarComboEstadoTratamiento()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("tipoTratamiento");
            string[] estadocivil = { "Incompleto", "Completo" };
            for (int i = 0; i < estadocivil.Length; i++)
            {
                DataRow dr = dt.NewRow();
                dr[0] = estadocivil[i];
                dt.Rows.Add(dr);
            }

            cboEstadoTratamiento.DataSource = dt;
            cboEstadoTratamiento.DisplayMember = "tipoTratamiento";
            cboEstadoTratamiento.AutoCompleteDataSource = dt;
            cboEstadoTratamiento.DropDownListElement.AutoCompleteDataSource = dt;
            cboEstadoTratamiento.DropDownListElement.AutoCompleteDisplayMember = "tipoTratamiento";
            cboEstadoTratamiento.DropDownStyle = RadDropDownStyle.DropDown;
            cboEstadoTratamiento.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboEstadoTratamiento.DropDownListElement.AutoCompleteSuggest.SuggestMode = SuggestMode.Contains;
        }

        public void RecibirProtocolo(string protocolo)
        {
            txtProtocolo.Text = protocolo;
        }

        private void CargarComboEmpleado()
        {
            DataTable dt = new EmpleadoBUS().BuscarEmpleado("");
            cboTender.DisplayMember = "nombrefull";
            cboTender.ValueMember = "idEmpleado";
            cboTender.DataSource = dt;
            cboTender.SelectedIndex = -1;
            cboTender.AutoCompleteDataSource = dt;
            cboTender.DropDownListElement.AutoCompleteDataSource = dt;
            cboTender.DropDownListElement.AutoCompleteDisplayMember = "nombrefull";
            cboTender.DropDownStyle = RadDropDownStyle.DropDown;
            cboTender.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboTender.DropDownListElement.AutoCompleteSuggest.SuggestMode = SuggestMode.Contains;
            
        }

        private void AgregarTratamientoCamaraHiperbarica()
        {
            try
            {
                TratamientoCamaraHiperbaricaVO tratamientoA = new TratamientoCamaraHiperbaricaVO();
                tratamientoA.EstadoTratamiento = cboEstadoTratamiento.Text;
                tratamientoA.fechaInicioTratamiento = dtpFechaInicioTratamiento.Value;
                tratamientoA.idImpresionDiagnostica = PKImpresionDiagnostica;
                tratamientoA.ObservacionesTratamiento = txtObservacionesTratamiento.Text;
                tratamientoA.TipoTratamiento = "Camara Hiperbárica";
                tratamientoA.NroSesiones = Convert.ToInt32(txtNroSesiones.Text);
                tratamientoA.PromedioOxigeno = Convert.ToDecimal(txtPromedioOxigeno.Text);
                PKTratamientoCamaraHiperbarica = new TratamientoCamaraHiperbaricaBUS().AgregarTratamiento(tratamientoA);
                AuditoriaVO auditoria = new AuditoriaVO();
                auditoria.idEmpleado = PrincipalUI.idEmpleadogbl;
                auditoria.idRegistro = PKTratamientoCamaraHiperbarica;
                auditoria.tabla = "Tratamiento";
                auditoria.tipo = "INSERT";
                auditoria.fecha = DateTime.Now.ToLocalTime();
                new AuditoriaBUS().AgregarAuditoria(auditoria);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un Problema : " + ex.Message);
            }
        }

        private void ModificarTratamientoCamaraHiperbarica()
        {
            try
            {
                TratamientoCamaraHiperbaricaVO tratamientoA = new TratamientoCamaraHiperbaricaVO();
                tratamientoA.IdTratamiento = PKTratamientoCamaraHiperbarica;
                tratamientoA.EstadoTratamiento = cboEstadoTratamiento.Text;
                tratamientoA.fechaInicioTratamiento = dtpFechaInicioTratamiento.Value;
                tratamientoA.idImpresionDiagnostica = PKImpresionDiagnostica;
                tratamientoA.ObservacionesTratamiento = txtObservacionesTratamiento.Text;
                tratamientoA.TipoTratamiento = "Camara Hiperbárica";
                tratamientoA.NroSesiones = Convert.ToInt32(txtNroSesiones.Text);
                tratamientoA.PromedioOxigeno = Convert.ToDecimal(txtPromedioOxigeno.Text);
                new TratamientoCamaraHiperbaricaBUS().ModificarTratamiento(tratamientoA);
                AuditoriaVO auditoria = new AuditoriaVO();
                auditoria.idEmpleado = PrincipalUI.idEmpleadogbl;
                auditoria.idRegistro = PKTratamientoCamaraHiperbarica;
                auditoria.tabla = "Tratamiento";
                auditoria.tipo = "UPDATE";
                auditoria.fecha = DateTime.Now.ToLocalTime();
                new AuditoriaBUS().AgregarAuditoria(auditoria);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un Problema : " + ex.Message);
            }
        }

        private void AgregarSesionTratamientoCamaraHiperbarica()
        {
                SesionesTratamientoVO sesion = new SesionesTratamientoVO();
                
                sesion.idTratamiento = PKTratamientoCamaraHiperbarica;
                sesion.notasTender = txtNotasTender.Text;
                sesion.fechaSesion = dtpFechaSesion.Value;
                sesion.consumoOxigeno = txtConsumoO2.Text.ValidarTextBox(txtConsumoO2,"Consumo de O2").ToDecimal("Consumo de O2");
                sesion.idEmpleado = cboTender.SelectedValue.ValidarComboBox<int>(cboTender,"Empleado");
                sesion.protocolo = txtProtocolo.Text;
                int id = new SesionesTratamientoBUS().AgregarSesionesTratamiento(sesion);
                AuditoriaVO auditoria = new AuditoriaVO();
                auditoria.idEmpleado = PrincipalUI.idEmpleadogbl;
                auditoria.idRegistro = id;
                auditoria.tabla = "SesionesTratamiento";
                auditoria.tipo = "INSERT";
                auditoria.fecha = DateTime.Now.ToLocalTime();
                new AuditoriaBUS().AgregarAuditoria(auditoria);
           
        }

        private void ModificarSesionTratamientoCamaraHiperbarica()
        {
                SesionesTratamientoVO sesion = new SesionesTratamientoVO();
                sesion.idSesionTratamiento = Convert.ToInt32(dgvSesiones.SelectedRows[0].Cells[0].Value);
                sesion.idTratamiento = PKTratamientoCamaraHiperbarica;
                sesion.notasTender = txtNotasTender.Text;
                sesion.fechaSesion = dtpFechaSesion.Value;
                sesion.consumoOxigeno = txtConsumoO2.Text.ValidarTextBox(txtConsumoO2, "Consumo de O2").ToDecimal("Consumo de O2");
                sesion.idEmpleado = cboTender.SelectedValue.ValidarComboBox<int>(cboTender, "Empleado");
                sesion.protocolo = txtProtocolo.Text;
                new SesionesTratamientoBUS().ModificarSesionesTratamiento(sesion);
                AuditoriaVO auditoria = new AuditoriaVO();
                auditoria.idEmpleado = PrincipalUI.idEmpleadogbl;
                auditoria.idRegistro = sesion.idSesionTratamiento;
                auditoria.tabla = "SesionesTratamiento";
                auditoria.tipo = "UPDATE";
                auditoria.fecha = DateTime.Now.ToLocalTime();
                new AuditoriaBUS().AgregarAuditoria(auditoria);

        }

        private void CargarFormulario()
        {
            if (IsNuevo == false)
            {
                radLabel3.Text = @"  Notas
 Tender";
                LlenarCamposTratamientoCamaraHiperbarica();
                txtPromedioOxigeno.Enabled = false;
                WinForm.BloquearControlesEnGroupBox(rgbSesiones);
            }
            else
            {
                WinForm.BloquearControlesEnGroupBox(rgbSesiones);
                WinForm.DesbloquearControlesEnForm(this);
                WinForm.LimpiarControlesEnForm(this);
                WinForm.LimpiarControlesEnGroupBox(rgbSesiones);
                txtPromedioOxigeno.Text = "0,00";
                txtPromedioOxigeno.Enabled = false;
                btnModificarSesion.Enabled = false;
                btnNuevaSesion.Enabled = false;
            }
            WinForm.ConvertirBordesRedondeadosLabelEnForm(this);
            rgbSesiones.Font = new System.Drawing.Font(rgbSesiones.Font.FontFamily, 14);
            rgbSesiones.GetChildAt(0).GetChildAt(0).GetChildAt(1).Visibility = Telerik.WinControls.ElementVisibility.Visible;
            rgbSesiones.GroupBoxElement.Header.ForeColor = Color.FromArgb(17, 105, 133);
            WinForm.ConvertirBordesRedondeadosLabelEnGroupBox(rgbSesiones);
            WinForm.PermitirSoloNumeros(txtNroSesiones);
            WinForm.PermitirSoloNumeros(txtConsumoO2);
            
        }

        private void LlenarCamposTratamientoCamaraHiperbarica()
        {
            txtNroSesiones.Text = tratamientoCamaraHiperbarica.NroSesiones.ToString();
            txtPromedioOxigeno.Text = tratamientoCamaraHiperbarica.PromedioOxigeno.ToString();
            txtObservacionesTratamiento.Text = tratamientoCamaraHiperbarica.ObservacionesTratamiento;
            dtpFechaInicioTratamiento.Value = tratamientoCamaraHiperbarica.fechaInicioTratamiento;
            cboEstadoTratamiento.SelectedIndex = cboEstadoTratamiento.FindStringExact(tratamientoCamaraHiperbarica.EstadoTratamiento);
        }

        private void CargarDGVSesiones(int idTratamiento)
        {
            try
            {
                dgvSesiones.DataSource = new SesionesTratamientoBUS().BuscarSesionesPorTratamiento(idTratamiento);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un Problema : " + ex.Message);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            
        }

        private void radButton3_Click(object sender, EventArgs e)
        {
            new ProtocoloUI(this).Show();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (IsNuevo)
            {

                if (WinForm.MensajeBox(this, "Tratamiento Camara Hiperbarica", "¿Desea Guardar el Tratamiento de Camara Hiperbarica?", MensajeBox.pregunta) == DialogResult.Yes)
                {
                    AgregarTratamientoCamaraHiperbarica();
                    WinForm.MensajeBox(this, "Tratamiento Camara Hiperbarica", "Tratamiento Tratamiento de Camara Hiperbarica Agregado!", MensajeBox.advertencia);
                    historiaClinicaUI.CargarListViewImpresionDiagnostica();
                    tratamientoCamaraHiperbarica = (TratamientoCamaraHiperbaricaVO)new TratamientoCamaraHiperbaricaBUS().BuscarTratamientoPorID(PKTratamientoCamaraHiperbarica);
                    LlenarCamposTratamientoCamaraHiperbarica();
                    btnNuevaSesion.Enabled = true;
                    btnModificarSesion.Enabled = true;
                }
            }
            else
            {
                if (WinForm.MensajeBox(this, "Tratamiento Camara Hiperbarica", "¿Desea Modificar el Tratamiento de Camara Hiperbarica?", MensajeBox.pregunta) == DialogResult.Yes)
                {
                    ModificarTratamientoCamaraHiperbarica();
                    WinForm.MensajeBox(this, "Tratamiento Camara Hiperbarica", "Tratamiento Tratamiento de Camara Hiperbarica Modificado!", MensajeBox.advertencia);
                    historiaClinicaUI.CargarListViewImpresionDiagnostica();
                    tratamientoCamaraHiperbarica = (TratamientoCamaraHiperbaricaVO) new TratamientoCamaraHiperbaricaBUS().BuscarTratamientoPorID(PKTratamientoCamaraHiperbarica);
                    LlenarCamposTratamientoCamaraHiperbarica();
                    
                }
            }
        }

        private void btnNuevaSesion_Click(object sender, EventArgs e)
        {
            if (IsNuevaSesionActiva)
            {
                if (WinForm.MensajeBox(this, "Sesiones de Tratamiento", "¿Desea Guardar la Sesion de Tratamiento?", MensajeBox.pregunta) == DialogResult.Yes)
                {
                    try
                    {
                        AgregarSesionTratamientoCamaraHiperbarica();
                        historiaClinicaUI.CargarListViewImpresionDiagnostica();
                        WinForm.MensajeBox(this, "Sesiones de Tratamiento", "Sesion de Tratamiento Agregada!", MensajeBox.advertencia);
                        CargarDGVSesiones(PKTratamientoCamaraHiperbarica);
                        WinForm.LimpiarControlesEnGroupBox(rgbSesiones);
                        WinForm.EventoClickBotonNuevo(btnNuevaSesion, btnModificarSesion, btnCancelar, ref IsNuevaSesionActiva, ref IsModificarSesionActiva);
                        tratamientoCamaraHiperbarica = (TratamientoCamaraHiperbaricaVO)new TratamientoCamaraHiperbaricaBUS().BuscarTratamientoPorID(PKTratamientoCamaraHiperbarica);
                        LlenarCamposTratamientoCamaraHiperbarica();
                        WinForm.BloquearControlesEnGroupBox(rgbSesiones);
                        btnModificarSesion.Enabled = true;
                    }
                    catch(Exception ex)
                    {
                        WinForm.MensajeBox(this, "Validacion de Campos", "Ocurrio un Error : "+ex.Message, MensajeBox.advertencia);
                    }
                }

            }
            else
            {
                WinForm.LimpiarControlesEnGroupBox(rgbSesiones);
                WinForm.EventoClickBotonNuevo(btnNuevaSesion, btnModificarSesion,btnCancelar, ref IsNuevaSesionActiva, ref IsModificarSesionActiva);
                WinForm.DesbloquearControlesEnGroupBox(rgbSesiones);
                txtConsumoO2.Select();
            }
        }

        private void dgvSesiones_CellClick(object sender, GridViewCellEventArgs e)
        {
            cboTender.SelectedIndex = cboTender.FindStringExact(dgvSesiones.SelectedRows[0].Cells["nombrefull"].Value.ToString());
            txtNotasTender.Text = dgvSesiones.SelectedRows[0].Cells["notasTender"].Value.ToString();
            txtProtocolo.Text = dgvSesiones.SelectedRows[0].Cells["protocolo"].Value.ToString();
            txtConsumoO2.Text = dgvSesiones.SelectedRows[0].Cells["consumoOxigeno"].Value.ToString();
            dtpFechaSesion.Value = Convert.ToDateTime(dgvSesiones.SelectedRows[0].Cells["fechaSesion"].Value.ToString());
            FKEmpleado = Convert.ToInt32(dgvSesiones.SelectedRows[0].Cells["idEmpleado"].Value.ToString());
            PKSesionTratamiento = Convert.ToInt32(dgvSesiones.SelectedRows[0].Cells["idSesionTratamiento"].Value.ToString());
        }

        private void btnModificarSesion_Click(object sender, EventArgs e)
        {
            if (IsModificarSesionActiva)
            {
                if (WinForm.MensajeBox(this, "Sesiones de Tratamiento", "¿Desea Modificar la Sesion de Tratamiento?", MensajeBox.pregunta) == DialogResult.Yes)
                {
                    ModificarSesionTratamientoCamaraHiperbarica();
                    historiaClinicaUI.CargarListViewImpresionDiagnostica();
                    WinForm.MensajeBox(this, "Sesiones de Tratamiento", "Sesion de Tratamiento Modificada!", MensajeBox.advertencia);
                    CargarDGVSesiones(PKTratamientoCamaraHiperbarica);
                    WinForm.DesbloquearControlesEnGroupBox(rgbSesiones);
                    WinForm.EventoClickBotonModificar(btnNuevaSesion, btnModificarSesion, btnCancelar, ref IsNuevaSesionActiva, ref IsModificarSesionActiva);
                    btnModificarSesion.Enabled = true;
                    tratamientoCamaraHiperbarica = (TratamientoCamaraHiperbaricaVO)new TratamientoCamaraHiperbaricaBUS().BuscarTratamientoPorID(PKTratamientoCamaraHiperbarica);
                    LlenarCamposTratamientoCamaraHiperbarica();
                }

            }
            else
            {
                WinForm.DesbloquearControlesEnGroupBox(rgbSesiones);
                WinForm.EventoClickBotonModificar(btnNuevaSesion, btnModificarSesion, btnCancelar, ref IsNuevaSesionActiva, ref IsModificarSesionActiva);
            }
        }
    }
}
