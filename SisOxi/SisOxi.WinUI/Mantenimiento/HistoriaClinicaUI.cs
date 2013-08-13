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
using SisOxi.VO;
using SisOxi.BUS;
using System.Speech.Recognition;
using SisOxi.VO.Seguridad;
using SisOxi.BUS.Seguridad;
using System.Reflection;

namespace SisOxi.WinUI
{
    public sealed partial class HistoriaClinicaUI : Telerik.WinControls.UI.RadForm
    {

        #region Variables Privadas
        //private static readonly HistoriaClinicaUI dis = new HistoriaClinicaUI();
        private PrincipalUI principalUI;
        bool IsModificarActivo = false;
        bool IsNuevoActivo = false;
        private HistoriaClinicaVO historiaClinica;
        private DatosClinicosVO datosClinico;
        double i = 0;
        private int PKHistoriaClinica=0;
        private int PKDatosClinicos=0;
        DataTable DTImpresionDiagnostica;
        #endregion

        //#region Escuchar
        //private void Escuchar()
        //{
        //    _sre.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(_sre_SpeechRecognized);
        //    _sre.SetInputToDefaultAudioDevice();
        //    _sre.LoadGrammar(new DictationGrammar());
            
        //}

        //private void PlayMicrofono()
        //{
        //    _sre.RecognizeAsync(RecognizeMode.Multiple);
        //}

        //private void StopMicrofono()
        //{
        //    _sre.RecognizeAsyncStop();
        //}


        //void _sre_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        //{
        //    foreach (RecognizedWordUnit word in e.Result.Words)
        //    {
        //        txtEnfermedadActual.Text += word.Text + " ";
        //    }

        //   // txtEnfermedadActual.Text += Environment.NewLine;

        //}



        //private SpeechRecognitionEngine _sre = new SpeechRecognitionEngine();
        //#endregion

        #region Constructores

        public HistoriaClinicaUI()
        {
            InitializeComponent();
        }

        public HistoriaClinicaUI(PrincipalUI principal)
        {
            InitializeComponent();
            principalUI = principal;
        }

        #endregion

        #region Metodos Base de Datos

        private void AgregarHistoriaClinica()
        {
                           
                    HistoriaClinicaVO historiaClinica = new HistoriaClinicaVO();
                    historiaClinica.codigoHistoriaClinica = txtCodigo.Text;
                    historiaClinica.nombres = txtNombres.Text.ValidarTextBox(txtNombres, "Nombre");
                    historiaClinica.apellidoMaterno = txtApellidoMaterno.Text;
                    historiaClinica.apellidoPaterno = txtApellidoPaterno.Text.ValidarTextBox(txtApellidoPaterno, "Apellido Paterno");
                    historiaClinica.centroTrabajo = txtCentroDeTrabajo.Text;
                    historiaClinica.departamentoDomicilio = txtDepartamento.Text;
                    historiaClinica.diistritoDomicilio = txtDistrito.Text;
                    historiaClinica.direccionDomiciliaria = txtDomicilio.Text;
                    historiaClinica.documentoIdentidad = txtDNI.Text.ValidarTextBox(txtDNI, "D.N.I.");
                    historiaClinica.domicilioContacto = txtDomicilioInformante.Text;
                    historiaClinica.edad = txtEdad.Text.ValidarTextBox(txtEdad, "Edad").ToInt("Edad");
                    historiaClinica.estadoCivil = cboEstadoCivil.Text.ValidarComboBox<string>(cboEstadoCivil, "Estado Civil");
                    historiaClinica.fechaNacimiento = dtpFecHistoriaClinica.Value;
                    historiaClinica.fono = txtFono.Text;
                    historiaClinica.fonoContacto = txtFonoInformante.Text;
                    historiaClinica.grupoEtnico = cboGrupoEtnico.Text.ValidarComboBox<string>(cboGrupoEtnico, "Grupo Etnico");
                    historiaClinica.lugarNacimiento = txtLugar.Text;
                    historiaClinica.nacionalidad = txtNacionalidad.Text;
                    historiaClinica.nombreContacto = txtNombreInformante.Text;
                    historiaClinica.ocupacion = txtOcupacion.Text;
                    historiaClinica.parentescoContacto = txtParentesco.Text;
                    historiaClinica.profesion = txtProfesion.Text;
                    historiaClinica.provincia = txtProvinciaLugarNacimiento.Text;
                    historiaClinica.provinciaDomicilio = txtProvincia.Text;
                    historiaClinica.apellidosContacto = txtApellidoInformante.Text;
                    if (rbtMasculino.Checked)
                    {
                        historiaClinica.sexo = rbtMasculino.Text;
                    }
                    else
                    {
                        historiaClinica.sexo = rbtFemenino.Text;
                    }
                    PKHistoriaClinica = new HistoriaClinicaBUS().AgregarHistoriaClinica(historiaClinica);
                    historiaClinica = new HistoriaClinicaBUS().BuscarHistoriaClinicaPorID(PKHistoriaClinica);
                    txtCodigo.Text = historiaClinica.codigoHistoriaClinica;
                    WinForm.MensajeBox(this, "Historia Clinica", "Historia Clinica Agregada!", MensajeBox.informacion);
                    AuditoriaVO auditoria = new AuditoriaVO();
                    auditoria.idEmpleado = PrincipalUI.idEmpleadogbl;
                    auditoria.idRegistro = PKHistoriaClinica;
                    auditoria.tabla = "HistoriaClinica";
                    auditoria.tipo = "INSERT";
                    auditoria.fecha = DateTime.Now.ToLocalTime();
                    new AuditoriaBUS().AgregarAuditoria(auditoria);
         
        }

        private void ModificarHistoriaClinica()
        {
            
                historiaClinica.codigoHistoriaClinica = txtCodigo.Text;
                historiaClinica.nombres = txtNombres.Text.ValidarTextBox(txtNombres,"Nombre");
                historiaClinica.apellidoMaterno = txtApellidoMaterno.Text;
                historiaClinica.apellidoPaterno = txtApellidoPaterno.Text.ValidarTextBox(txtApellidoPaterno,"Apellido Paterno");
                historiaClinica.centroTrabajo = txtCentroDeTrabajo.Text;
                historiaClinica.departamentoDomicilio = txtDepartamento.Text;
                historiaClinica.diistritoDomicilio = txtDistrito.Text;
                historiaClinica.direccionDomiciliaria = txtDomicilio.Text;
                historiaClinica.documentoIdentidad = txtDNI.Text.ValidarTextBox(txtDNI,"D.N.I.");
                historiaClinica.domicilioContacto = txtDomicilioInformante.Text;
                historiaClinica.edad = txtEdad.Text.ValidarTextBox(txtEdad, "Edad").ToInt("Edad");
                historiaClinica.estadoCivil = cboEstadoCivil.Text.ValidarComboBox<string>(cboEstadoCivil,"Estado Civil");
                historiaClinica.fechaNacimiento = dtpFecHistoriaClinica.Value;
                historiaClinica.fono = txtFono.Text;
                historiaClinica.fonoContacto = txtFonoInformante.Text;
                historiaClinica.grupoEtnico = cboGrupoEtnico.Text.ValidarComboBox<string>(cboGrupoEtnico,"Grupo Etnico");
                historiaClinica.lugarNacimiento = txtLugar.Text;
                historiaClinica.nacionalidad = txtNacionalidad.Text;
                historiaClinica.nombreContacto = txtNombreInformante.Text;
                historiaClinica.ocupacion = txtOcupacion.Text;
                historiaClinica.parentescoContacto = txtParentesco.Text;
                historiaClinica.profesion = txtProfesion.Text;
                historiaClinica.provincia = txtProvinciaLugarNacimiento.Text;
                historiaClinica.provinciaDomicilio = txtProvincia.Text;
                historiaClinica.apellidosContacto = txtApellidoInformante.Text;
                if (rbtMasculino.Checked)
                {
                    historiaClinica.sexo = rbtMasculino.Text;
                }
                else
                {
                    historiaClinica.sexo = rbtFemenino.Text;
                }
                new HistoriaClinicaBUS().ModificarHistoriaClinica(historiaClinica);
                AuditoriaVO auditoria = new AuditoriaVO();
                auditoria.idEmpleado = PrincipalUI.idEmpleadogbl;
                auditoria.idRegistro = PKHistoriaClinica;
                auditoria.tabla = "HistoriaClinica";
                auditoria.tipo = "UPDATE";
                auditoria.fecha = DateTime.Now.ToLocalTime();
                new AuditoriaBUS().AgregarAuditoria(auditoria);
                WinForm.MensajeBox(this, "Historia Clinica", "Historia Clinica "+historiaClinica.codigoHistoriaClinica+" Modificada!", MensajeBox.informacion);
           
        }

        private void AgregarDatosClinicos()
        {
            
                DatosClinicosVO datosClinicos = new DatosClinicosVO();
                datosClinicos.idHistoriaClinica = PKHistoriaClinica;
                datosClinicos.enfermedadActual = txtEnfermedadActual.Text;
                datosClinicos.antecedenteFamiliares = txtAntecedentesFamiliares.Text;
                datosClinicos.antecedentesPatologicos = txtAntecedentesPatologicos.Text;
                datosClinicos.FC = txtFC.Text;
                datosClinicos.T = txtT.Text;
                datosClinicos.PA = txtPA.Text;
                datosClinicos.peso = txtPeso.Text;
                datosClinicos.talla = txtTalla.Text;
                datosClinicos.observacionesFisicas = txtObservacionesFisicas.Text;
                datosClinicos.examenesDeLaboratorio = txtExamenesDeLaboratorio.Text;
                PKDatosClinicos = new DatosClinicosBUS().AgregarDatosClinicos(datosClinicos);
                AuditoriaVO auditoria = new AuditoriaVO();
                auditoria.idEmpleado = PrincipalUI.idEmpleadogbl;
                auditoria.idRegistro = PKDatosClinicos;
                auditoria.tabla = "DatosClinicos";
                auditoria.tipo = "INSERT";
                auditoria.fecha = DateTime.Now.ToLocalTime();
                new AuditoriaBUS().AgregarAuditoria(auditoria);
           
        }

        private void ModificarDatosClinicos()
        {
           
                DatosClinicosVO datosClinicos = new DatosClinicosVO();
                datosClinicos.idDatosClinicos = PKDatosClinicos;
                datosClinicos.idHistoriaClinica = PKHistoriaClinica;
                datosClinicos.enfermedadActual = txtEnfermedadActual.Text;
                datosClinicos.antecedenteFamiliares = txtAntecedentesFamiliares.Text;
                datosClinicos.antecedentesPatologicos = txtAntecedentesPatologicos.Text;
                datosClinicos.FC = txtFC.Text;
                datosClinicos.T = txtT.Text;
                datosClinicos.PA = txtPA.Text;
                datosClinicos.peso = txtPeso.Text;
                datosClinicos.talla = txtTalla.Text;
                datosClinicos.observacionesFisicas = txtObservacionesFisicas.Text;
                datosClinicos.examenesDeLaboratorio = txtExamenesDeLaboratorio.Text;
                new DatosClinicosBUS().ModificarDatosClinicos(datosClinicos);
                AuditoriaVO auditoria = new AuditoriaVO();
                auditoria.idEmpleado = PrincipalUI.idEmpleadogbl;
                auditoria.idRegistro = PKDatosClinicos;
                auditoria.tabla = "DatosClinicos";
                auditoria.tipo = "UPDATE";
                auditoria.fecha = DateTime.Now.ToLocalTime();
                new AuditoriaBUS().AgregarAuditoria(auditoria);
            
        }

        public void CargarListViewImpresionDiagnostica()
        {
            lstTratamiento.Items.Clear();
            lstTratamiento.Groups.Clear();
            lstTratamiento.Columns.Clear();
            DataTable dt = new ImpresionDiagnosticaBUS().BuscarImpresionDiagnosticaPorIDHistoriaClinica(PKHistoriaClinica);
            lstImpresionDiagnostica.DataSource = dt;
            string[] nombreColumna = {"idTratamiento","nroSesiones","estadoTratamiento","observacionesTratamiento","promedioOxigeno","tipoTratamiento","fechaInicioTratamiento","idImpresionDiagnostica","Camara","estadoPaciente"};
            for(int x=0;x<=9;x++)
            {
                lstTratamiento.Columns.Add(nombreColumna[x]);
                lstTratamiento.Columns[x].Visible = false;
            }
            lstTratamiento.Columns[5].Visible = true;
            lstTratamiento.Columns[5].Width = 641;
            lstTratamiento.Columns[5].HeaderText = "Tratamiento";
            DTImpresionDiagnostica = dt;
            
            int ii = 0;
            int numeroItem = 0;
            foreach( DataRow dr in dt.Rows)
            {
                CargarListViewTratamiento(dr[0].ToString().ToInt(), ii, dr["nombre"].ToString(), ref numeroItem);
                ii++;
            }
            List<int> columnasMostradas = new List<int> {5};
            for (int i = 0; i < lstImpresionDiagnostica.Columns.Count; i++)
            {
                if (!columnasMostradas.Contains(i))
                {
                    lstImpresionDiagnostica.Columns[i].Visible = false;
                }

            }
            lstImpresionDiagnostica.AllowEdit = false;
            lstImpresionDiagnostica.Columns[5].HeaderText = "Impresión Diagnóstica";
            lstImpresionDiagnostica.Columns[5].Width = 641;
            lstImpresionDiagnostica.Refresh();
            lstImpresionDiagnostica.Select();
        }

        public void CargarListViewExamenGabinete()
        {
            lstExamenGabinete.DataSource = new ExamenGabineteBUS().BuscarExamenDeGabinetePorIDHistoriaClinica(PKHistoriaClinica);
            List<int> columnasMostradas = new List<int> { 5 };
            for (int i = 0; i < lstExamenGabinete.Columns.Count; i++)
            {
                if (!columnasMostradas.Contains(i))
                {
                    lstExamenGabinete.Columns[i].Visible = false;
                }

            }
            lstExamenGabinete.AllowEdit = false;
            lstExamenGabinete.Columns[5].HeaderText = "Examen de Gabinete";
            lstExamenGabinete.Columns[5].Width = 641;
            lstExamenGabinete.Refresh();
        }

        private List<bool> IsConTratamientoCamaraHiperbarica = new List<bool>();
        public void CargarListViewTratamiento(int idImpresionDiagnostica, int indexGrupo, string nombreGrupo,ref int numeroItem)
        {
            
            DataTable dt = new TratamientoAlternoBUS().BuscarTratamientoPorIDImpresionDiagnostica(idImpresionDiagnostica);
            lstTratamiento.Groups.Add(new ListViewDataItemGroup(nombreGrupo));
            lstTratamiento.Groups[indexGrupo].Font = new Font(lstTratamiento.Font.FontFamily, 14);
            bool TieneCamara = false;
            foreach(DataRow dr in dt.Rows)
            {
                ListViewDataItem items = new ListViewDataItem();
                lstTratamiento.Items.Add(items);
                items[0] = dr[0].ToString();
                items[1] = dr[1].ToString();
                items[2] = dr[2].ToString();
                items[3] = dr[3].ToString();
                items[4] = dr[4].ToString();
                items[5] = dr[5].ToString();
                if(items[5].ToString() == "Camara Hiperbárica")
                {
                    TieneCamara = true;
                    items[8] = TieneCamara.ToString();
                }
                items[6] = dr[6].ToString();
                items[7] = dr[7].ToString();
                items[9] = dr[8].ToString();
                
                lstTratamiento.Items[numeroItem].Group = lstTratamiento.Groups[indexGrupo];
                numeroItem++;
            }

          
        
            lstTratamiento.Refresh();
           
        }

        private void CargarComboEstadoCivil()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("estadoCivil");
            string[] estadocivil = { "Soltero", "Casado", "Viudo", "Divorciado" };
            for (int i = 0; i < estadocivil.Length; i++)
            {
                DataRow dr = dt.NewRow();
                dr[0] = estadocivil[i];
                dt.Rows.Add(dr);
            }

            cboEstadoCivil.DataSource = dt;
            cboEstadoCivil.DisplayMember = "estadoCivil";
            cboEstadoCivil.AutoCompleteDataSource = dt;
            cboEstadoCivil.DropDownListElement.AutoCompleteDataSource = dt;
            cboEstadoCivil.DropDownListElement.AutoCompleteDisplayMember = "estadoCivil";
            cboEstadoCivil.DropDownStyle = RadDropDownStyle.DropDown;
            cboEstadoCivil.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboEstadoCivil.DropDownListElement.AutoCompleteSuggest.SuggestMode = SuggestMode.Contains;

        }

        private void CargarComboGrupoEtnico()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("grupoEtnico");
            string[] estadocivil = { "Blancoide", "Indigena", "Mestizo", "Mulato","Zambo" };
            for (int i = 0; i < estadocivil.Length; i++)
            {
                DataRow dr = dt.NewRow();
                dr[0] = estadocivil[i];
                dt.Rows.Add(dr);
            }

            cboGrupoEtnico.DataSource = dt;
            cboGrupoEtnico.DisplayMember = "grupoEtnico";
            cboGrupoEtnico.AutoCompleteDataSource = dt;
            cboGrupoEtnico.DropDownListElement.AutoCompleteDataSource = dt;
            cboGrupoEtnico.DropDownListElement.AutoCompleteDisplayMember = "grupoEtnico";
            cboGrupoEtnico.DropDownStyle = RadDropDownStyle.DropDown;
            cboGrupoEtnico.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboGrupoEtnico.DropDownListElement.AutoCompleteSuggest.SuggestMode = SuggestMode.Contains;

        }

        #endregion

        #region Eventos

        private void VolverPrimeraPagina()
        {
            pvMenu.SelectedPage = pvPaginaDatosFiliacion;
        }

        private void PacienteUI_Load(object sender, EventArgs e)
        {
            btnCerrar.ButtonElement.Shape = new EllipseShape();
            btnInicio.ButtonElement.Shape = new EllipseShape();
            //Escuchar();
            //Assembly lAssembly = Assembly.GetAssembly(typeof(HistoriaClinicaUI));
            ////Telerik.WinControls.ThemeResolutionService.LoadPackageResource("Telerik.WinControls.Themes.Office2010.tssp"); 
            //ThemeResolutionService.LoadPackageResource(lAssembly,"SisOxi.WinUI.ControlDefaultButtonShape.tssp");
            //ThemeResolutionService.ApplicationThemeName = "ControlDefaultButtonShape";
            //btnBuscar.ButtonElement.Shape = new Telerik.WinControls.RoundRectShape();
            //btnCancelar.ButtonElement.Shape = new Telerik.WinControls.EllipseShape();
            //btnNuevo.ButtonElement.Shape = new Telerik.WinControls.EllipseShape();
            CargarFormulario();
            //cboEstadoCivil.DropDownListElement.AutoCompleteSuggest.SuggestMode = SuggestMode.Contains;
             //.DropDownListElement.AutoCompleteSuggest.SuggestMode = SuggestMode.Contains;
           // Escuchar();
        }

        private void radButton12_Click(object sender, EventArgs e)
        {
            
          //  new ImpresionDiagnosticaUI(true,this,PKHistoriaClinica).Show();
        }

        private void radButton6_Click(object sender, EventArgs e)
        {
            new ExamenGabineteUI().Show();
        }

        private void radButton1_Click_1(object sender, EventArgs e)
        {
            new TipoExamenGabineteUI().Show();
        }

        private void btnEnfermedades_Click(object sender, EventArgs e)
        {
            new EnfermedadUI().Show();
        }

        private void btnTipoTratamiento_Click(object sender, EventArgs e)
        {
            //new TipoTratamientoUI(this, principalUI).Show();
        }

        private void btnNuevoT_Click(object sender, EventArgs e)
        {
            //new TipoTratamientoUI().Show();
        }

        private void radTextBox11_Enter(object sender, EventArgs e)
        {

        }

        private void txtFC_Leave(object sender, EventArgs e)
        {

        }

        private void radTextBox11_Leave(object sender, EventArgs e)
        {

        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            new BuscarHistoriaClinicaUI(this).Show();
        }

        private void radButton3_Click(object sender, EventArgs e)
        {
            //TratamientoCamaraHiperbaricaUI tratamiento = new TratamientoCamaraHiperbaricaUI(this, principalUI);
            //WinForm.SplashScreen(tratamiento);
            //WinForm.LlamarFormAPanel(tratamiento, principalUI.pnlContenido);

        }

        private void btnAnalisis_Click(object sender, EventArgs e)
        {
            
        }

        private void dtpFecHistoriaClinica_ValueChanged(object sender, EventArgs e)
        {

        }

      
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (IsNuevoActivo)
            {
                DialogResult result = WinForm.MensajeBox(this, "Historia Clinica", "¿Realmente desea Agregar la Historia Clinica?", MensajeBox.pregunta);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        AgregarHistoriaClinica();
                        AgregarDatosClinicos();
                        CargarListViewImpresionDiagnostica();
                        CargarListViewExamenGabinete();
                        btnBuscar.Enabled = true;
                        MostrarPestañas();
                        HistoriaClinicaVO historia = new HistoriaClinicaBUS().BuscarHistoriaClinicaPorID(PKHistoriaClinica);
                        txtCodigo.Text = historia.codigoHistoriaClinica;
                        lblTitulo.Text = "  Nro Historia : " + historia.codigoHistoriaClinica + " - Paciente : " + historia.nombres + " " + historia.apellidoPaterno + " " + historia.apellidoMaterno;
                        WinForm.EventoClickBotonNuevo(btnNuevo, btnModificar, btnCancelar, ref IsNuevoActivo, ref IsModificarActivo);
                    }
                    catch(Exception ex)
                    {
                        if (ex is ExcepcionesApp)
                        {
                            WinForm.MensajeBox(this, "Validacion de Informacion", "Advertencia : " + ex.Message, MensajeBox.advertencia);
                        }
                        else
                        {
                            WinForm.MensajeBox(this, "Error de Sistema", "Ocurrio un Error :\n" + ex.Message, MensajeBox.error);
                        }
                    }
                } 
            }
            else
            {
                VolverPrimeraPagina();
                OcultarPestañas();
                WinForm.LimpiarControlesEnRadPageView(pvPaginaDatosFiliacion);
                WinForm.LimpiarControlesEnRadPageView(pvPaginaEnfermedadActual);
                WinForm.LimpiarControlesEnRadPageView(pvPaginaExamenFisico);
                WinForm.DesbloquearControlesPageView(pvPaginaExamenFisico);
                WinForm.DesbloquearControlesPageView(pvPaginaEnfermedadActual);
                WinForm.DesbloquearControlesPageView(pvPaginaDatosFiliacion);
                WinForm.EventoClickBotonNuevo(btnNuevo, btnModificar, btnCancelar, ref IsNuevoActivo, ref IsModificarActivo);
                txtNombres.Select();
                txtCodigo.Text = "<Auto>";
                txtCodigo.Enabled = false;
                lblTitulo.Text = "<Ingresando Nueva Historia Clinica>";
                btnBuscar.Enabled = false;
            }
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            new EnfermedadUI().Show();
        }

        private void radButton5_Click(object sender, EventArgs e)
        {
            new ExamenGabineteUI().Show();
        }

        private void radButton8_Click(object sender, EventArgs e)
        {
            //new TratamientoCamaraHiperbaricaUI(this, principalUI).Show();

        }

        #endregion

        #region Metodos Formulario

        private void OcultarPestañas()
        {
            RadPageViewStripElement stripElement = (RadPageViewStripElement)this.pvMenu.ViewElement;

            i = 0;
            foreach (RadPageViewStripItem item in stripElement.ItemContainer.ItemLayout.Children)
            {
                if (i > 2)
                {
                    item.Visibility = ElementVisibility.Hidden;
                }
                 i++;
            }
        }

        private void MostrarPestañas()
        {
            RadPageViewStripElement stripElement = (RadPageViewStripElement)this.pvMenu.ViewElement;
                        
            foreach (RadPageViewStripItem item in stripElement.ItemContainer.ItemLayout.Children)
            {
                if (i > 2)
                {
                    item.Visibility = ElementVisibility.Visible;
                }
                i++;
            }
        }

        private void CargarFormulario()
        {
            WinForm.ConvertirBordesRedondeadosLabelEnPageView(pvPaginaDatosFiliacion);
            WinForm.ConvertirBordesRedondeadosLabelEnPageView(pvPaginaExamenFisico);
            WinForm.ConvertirBordesRedondeadosLabelEnPageView(pvPaginaEnfermedadActual);
            WinForm.ConvertirBordesRedondeadosLabelEnPageView(pvPaginaPlan);
            WinForm.ConvertirBordesRedondeadosLabelEnForm(this);
            Font newfont = new Font(this.pvMenu.Font.FontFamily, 14);
            WinForm.ConvertirBordesRedondeadosLabelEnPageView(pvPaginaImpresionDiagnostica);
            RadPageViewStripElement stripElement = (RadPageViewStripElement)this.pvMenu.ViewElement;
            foreach (RadPageViewStripItem item in stripElement.ItemContainer.ItemLayout.Children)
            {
                item.Font = newfont;
            }
            CargarComboEstadoCivil();
            CargarComboGrupoEtnico();
            WinForm.LimpiarControlesEnRadPageView(pvPaginaDatosFiliacion);
            WinForm.LimpiarControlesEnRadPageView(pvPaginaEnfermedadActual);
            WinForm.LimpiarControlesEnRadPageView(pvPaginaExamenFisico);
            WinForm.BloquearControlesEnPageView(pvPaginaEnfermedadActual);
            WinForm.BloquearControlesEnPageView(pvPaginaDatosFiliacion);
            WinForm.BloquearControlesEnPageView(pvPaginaExamenFisico);
            WinForm.EventoClickBotonCancelar(btnNuevo, btnModificar, btnCancelar, ref IsNuevoActivo, ref IsModificarActivo);
            WinForm.TabEnterEnPageView(pvPaginaDatosFiliacion);
            OcultarPestañas();
            WinForm.PermitirSoloNumeros(txtDNI);
            WinForm.PermitirSoloNumeros(txtEdad);
            
        }

        

        public void RecibirHistoriaClinica(HistoriaClinicaVO historia,DatosClinicosVO datosClinicos)
        {
            historiaClinica = historia;
            datosClinico = datosClinicos;
            PKHistoriaClinica = historiaClinica.idHistoriaClinica;
            lblTitulo.Text = "  Nro Historia : " + historiaClinica.codigoHistoriaClinica + " - Paciente : " + historiaClinica.nombres + " " + historiaClinica.apellidoPaterno + " " + historiaClinica.apellidoMaterno;
            txtCodigo.Text = historiaClinica.codigoHistoriaClinica;
            txtNombres.Text = historiaClinica.nombres;
            txtApellidoMaterno.Text=historiaClinica.apellidoMaterno;
            txtApellidoPaterno.Text=historiaClinica.apellidoPaterno;
            txtCentroDeTrabajo.Text=historiaClinica.centroTrabajo;
            txtDepartamento.Text=historiaClinica.departamentoDomicilio;
            txtDistrito.Text=historiaClinica.diistritoDomicilio;
            txtDomicilio.Text=historiaClinica.direccionDomiciliaria;
            txtDNI.Text=historiaClinica.documentoIdentidad;
            txtDomicilioInformante.Text=historiaClinica.domicilioContacto;
            txtEdad.Text=historiaClinica.edad.ToString() ;
            cboEstadoCivil.SelectedIndex = cboEstadoCivil.FindStringExact(historiaClinica.estadoCivil);
            dtpFecHistoriaClinica.Value=historiaClinica.fechaNacimiento;
            txtFono.Text=historiaClinica.fono ;
            if (historiaClinica.sexo == "Femenino")
            {
                rbtFemenino.Checked = true;
            }
            else
            {
                rbtMasculino.Checked = true;
            }
            txtFonoInformante.Text=historiaClinica.fonoContacto  ;
            cboGrupoEtnico.Text=historiaClinica.grupoEtnico  ;
            txtLugar.Text=historiaClinica.lugarNacimiento  ;
            txtNacionalidad.Text=historiaClinica.nacionalidad  ;
            txtNombreInformante.Text=historiaClinica.nombreContacto;
            txtOcupacion.Text=historiaClinica.ocupacion;
            txtParentesco.Text=historiaClinica.parentescoContacto;
            txtProfesion.Text=historiaClinica.profesion;
            txtProvinciaLugarNacimiento.Text=historiaClinica.provincia;
            txtProvincia.Text=historiaClinica.provinciaDomicilio;
            txtApellidoInformante.Text = historiaClinica.apellidosContacto;
            //datos
            PKDatosClinicos = datosClinicos.idDatosClinicos;
            txtAntecedentesFamiliares.Text = datosClinicos.antecedenteFamiliares;
            txtAntecedentesPatologicos.Text = datosClinicos.antecedentesPatologicos;
            txtEnfermedadActual.Text = datosClinicos.enfermedadActual;
            txtExamenesDeLaboratorio.Text = datosClinicos.examenesDeLaboratorio;
            txtFC.Text = datosClinicos.FC;
            txtPA.Text = datosClinicos.PA;
            txtT.Text = datosClinicos.T;
            txtPeso.Text = datosClinicos.peso;
            txtTalla.Text = datosClinicos.talla;
            txtObservacionesFisicas.Text = datosClinicos.observacionesFisicas;
            
            CargarListViewImpresionDiagnostica();
            CargarListViewExamenGabinete();
            //CargarListViewTratamiento();
            MostrarPestañas();
            btnModificar.Enabled = true;
            VolverPrimeraPagina();
        }

        #endregion

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (IsModificarActivo)
            {
                DialogResult result = WinForm.MensajeBox(this, "Historia Clinica", "¿Realmente desea Modificar la Historia Clinica : "+txtCodigo.Text+"?", MensajeBox.pregunta);
                if (result == DialogResult.Yes)
                {
                    ModificarHistoriaClinica();
                    ModificarDatosClinicos();
                    // RecibirHistoriaClinica(historiaClinica,datosClinicos);
                    WinForm.EventoClickBotonModificar(btnNuevo, btnModificar, btnCancelar, ref IsNuevoActivo, ref IsModificarActivo);
                    MostrarPestañas();
                    WinForm.BloquearControlesEnPageView(pvPaginaDatosFiliacion);
                    WinForm.BloquearControlesEnPageView(pvPaginaExamenFisico);
                    WinForm.BloquearControlesEnPageView(pvPaginaEnfermedadActual);
                    btnBuscar.Enabled = true;
                }
            }
            else
            {
                VolverPrimeraPagina();
                WinForm.DesbloquearControlesPageView(pvPaginaExamenFisico);
                WinForm.DesbloquearControlesPageView(pvPaginaEnfermedadActual);
                WinForm.DesbloquearControlesPageView(pvPaginaDatosFiliacion);
                WinForm.EventoClickBotonModificar(btnNuevo, btnModificar, btnCancelar, ref IsNuevoActivo, ref IsModificarActivo);
                OcultarPestañas();
                txtCodigo.Enabled = false;
                btnBuscar.Enabled = false;
            }
        }

        private void timerFadeIn_Tick(object sender, EventArgs e)
        {
            //i += 0.05;
            //if (i >= 1)
            //{//if form is fully visible, we execute the Fade Out Effect
            //    this.Opacity = 1;
            //    timerFadeIn.Enabled = false;//stop the Fade In Effect
            //    timerFadeOut.Enabled = true;//start the Fade Out Effect
            //    return;
            //}
            //this.Opacity = i;
        }

        //private void btnModificarID_Click(object sender, EventArgs e)
        //{
        //    //ImpresionDiagnosticaVO impresionDiagnostica = lstImpresionDiagnostica.SelectedValue ;

        //   new ImpresionDiagnosticaUI(false,this,PKHistoriaClinica,SeleccionarItemLstImpresionDiagnostica()).Show();
        //}

        //private void btnVerDiagnostico_Click(object sender, EventArgs e)
        //{
        //    new ImpresionDiagnosticaUI(true, this, PKHistoriaClinica).Show();
        //}

        private ImpresionDiagnosticaVO SeleccionarItemLstImpresionDiagnostica()
        {
            ImpresionDiagnosticaVO impresionDiagnostica = new ImpresionDiagnosticaVO();
            ListViewSelectedItemCollection col = lstImpresionDiagnostica.SelectedItems;
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

        private ExamenGabineteVO SeleccionarItemLstExamenGabinete()
        {
            ExamenGabineteVO examenG = new ExamenGabineteVO();
            ListViewSelectedItemCollection col = lstExamenGabinete.SelectedItems;
            foreach (ListViewDataItem item in col)
            {
                examenG = Clases.LlenarObjetoConRegistroListViewDataItem<ExamenGabineteVO>(item);
            }

            return examenG;
        }

        private T SeleccionarItemLstTratamiento<T>() where T:class,new()
        {

            ListViewSelectedItemCollection col = lstTratamiento.SelectedItems;
            T objeto = Activator.CreateInstance(typeof(T)) as T;

            foreach (ListViewDataItem item in col)
            {

                if (objeto == typeof(TratamientoAlternoVO))
                {
                    objeto = Clases.LlenarObjetoConRegistroListViewDataItem<T>(item);
                    
                }
                else
                {
                    objeto = Clases.LlenarObjetoConRegistroListViewDataItem<T>(item);
                   
                }
            }
            return objeto;
            
        }

        private void lstImpresionDiagnostica_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtObservacionesDiagnostico.Text = SeleccionarItemLstImpresionDiagnostica().Observaciones;
        }

        private void radButton5_Click_1(object sender, EventArgs e)
        {

        }

        private void btnModificarT_Click(object sender, EventArgs e)
        {

        }

        private void radButton8_Click_1(object sender, EventArgs e)
        {
            new TipoTratamientoUI(PKHistoriaClinica,principalUI).Show();
        }

        private void pvMenu_SelectedPageChanged(object sender, EventArgs e)
        {

        }

        private void radButton1_Click_2(object sender, EventArgs e)
        {
            new TipoExamenGabineteUI().ShowDialog();
        }

        private void btnTipoTratamiento_Click_1(object sender, EventArgs e)
        {
            new TipoTratamientoUI(PKHistoriaClinica,principalUI).Show();
        }

        private void btnEnfermedades_Click_1(object sender, EventArgs e)
        {
            new EnfermedadUI().ShowDialog();
        }

        private void radButton3_Click_1(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("nombre",typeof(string));
            
            foreach (ListViewDataItem item in lstImpresionDiagnostica.Items)
            {
                dt.Rows.Add(item[5].ToString());
                
            }
            new ImpresionDiagnosticaUI(true,this,PKHistoriaClinica,dt).ShowDialog();
        }

        private void btnVerDiagnostico_Click_1(object sender, EventArgs e)
        {
            //DataTable dt = new DataTable();
            //dt.Columns.Add("nombre", typeof(string));

            //foreach (ListViewDataItem item in lstImpresionDiagnostica.Items)
            //{
            //    dt.Rows.Add(item["nombre"].ToString());

            //}
            if (lstImpresionDiagnostica.SelectedItems.Count > 0 )
            {
                new ImpresionDiagnosticaUI(false, this, PKHistoriaClinica, SeleccionarItemLstImpresionDiagnostica()).ShowDialog();
            }
            else
            {
                WinForm.MensajeBox(this, "Diagnostico", "No ha seleccionado un Diagnostico!", MensajeBox.advertencia);
            }
        }

        private void radButton4_Click(object sender, EventArgs e)
        {
            new ExamenGabineteUI(true,this,PKHistoriaClinica).ShowDialog();
        }

        private void radButton5_Click_2(object sender, EventArgs e)
        {
            if(lstExamenGabinete.SelectedItems.Count>0)
            {
                new ExamenGabineteUI(false,this,PKHistoriaClinica,SeleccionarItemLstExamenGabinete()).ShowDialog();
            }
            else
            {
                WinForm.MensajeBox(this, "Examen de Gabinete", "No ha seleccionado un Examen de Gabinete!", MensajeBox.advertencia);
            }
        }

        private void radButton6_Click_1(object sender, EventArgs e)
        {
            new TipoTratamientoUI(true,this,DTImpresionDiagnostica,IsConTratamientoCamaraHiperbarica).ShowDialog();
        }

        private void radButton7_Click(object sender, EventArgs e)
        {
            if (lstTratamiento.SelectedItems.Count > 0)
            {
                ListViewSelectedItemCollection col = lstTratamiento.SelectedItems;
                foreach (ListViewDataItem item in col)
                {
    
                        if (item[5].ToString() == "Camara Hiperbárica")
                        {
                            new TratamientoCamaraHiperbaricaUI(false, this, item[7].ToString().ToInt(), SeleccionarItemLstTratamiento<TratamientoCamaraHiperbaricaVO>()).ShowDialog();
                            break;
                        }
                        else
                        {
                            new TratamientoAlternoUI(false, this, item[7].ToString().ToInt(), SeleccionarItemLstTratamiento<TratamientoAlternoVO>()).ShowDialog();
                            break;
                        }
                }
            }
            else
            {
                WinForm.MensajeBox(this, "Tratamiento", "No ha seleccionado un Tratamiento!", MensajeBox.advertencia);
            }
        }

        private void txtEnfermedadActual_Enter(object sender, EventArgs e)
        {
           // Escuchar();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            principalUI.pnlContenido.Controls.Clear();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult dr = WinForm.MensajeBox(this, "Historia Clinica", "¿Realmente desea cancelar la Operacion?", MensajeBox.pregunta);
            if (dr == DialogResult.Yes)
            {
                if (IsModificarActivo)
                {
                    WinForm.BloquearControlesEnPageView(pvPaginaEnfermedadActual);
                    WinForm.BloquearControlesEnPageView(pvPaginaDatosFiliacion);
                    WinForm.BloquearControlesEnPageView(pvPaginaExamenFisico);
                    WinForm.EventoClickBotonCancelar(btnNuevo, btnModificar, btnCancelar, ref IsNuevoActivo, ref IsModificarActivo);
                    MostrarPestañas();
                    btnModificar.Enabled = true;
                    RecibirHistoriaClinica(historiaClinica, datosClinico);
                    btnBuscar.Enabled = false;
                }
                else
                {
                    WinForm.EventoClickBotonCancelar(btnNuevo, btnModificar, btnCancelar, ref IsNuevoActivo, ref IsModificarActivo);
                    WinForm.LimpiarControlesEnRadPageView(pvPaginaDatosFiliacion);
                    WinForm.LimpiarControlesEnRadPageView(pvPaginaEnfermedadActual);
                    WinForm.LimpiarControlesEnRadPageView(pvPaginaExamenFisico);
                    WinForm.BloquearControlesEnPageView(pvPaginaEnfermedadActual);
                    WinForm.BloquearControlesEnPageView(pvPaginaDatosFiliacion);
                    WinForm.BloquearControlesEnPageView(pvPaginaExamenFisico);
                    lblTitulo.Text = "<Porfavor Presione en Buscar o Nuevo>";
                    btnBuscar.Enabled = true;
                }
            }
        }

        private void dtpFecHistoriaClinica_Opened(object sender, EventArgs e)
        {

        }

        private void radButton5_Click_3(object sender, EventArgs e)
        {
            //if (radButton5.Text == "Hablar")
            //{
            //    PlayMicrofono();
            //    radButton5.Text = "Cancelar";
            //    radButton5.Image = global::SisOxi.WinUI.Properties.Resources.Gnome_Process_Stop_32;
            //}
            //else
            //{
            //    StopMicrofono();
            //    radButton5.Text = "Hablar";
            //    radButton5.Image = global::SisOxi.WinUI.Properties.Resources.Gnome_Audio_Input_Microphone_32;
            //}
        }

        private void lstImpresionDiagnostica_CellFormatting(object sender, ListViewCellFormattingEventArgs e)
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

        private void lstTratamiento_CellFormatting(object sender, ListViewCellFormattingEventArgs e)
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

        private void lstExamenGabinete_CellFormatting(object sender, ListViewCellFormattingEventArgs e)
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

        private void radButton8_Click_2(object sender, EventArgs e)
        {
            if(DialogResult.Yes == WinForm.MensajeBox(this,"Salir de la Aplicacion","¿Desea salir de la Aplicacion?",MensajeBox.pregunta))
            {
                Application.Exit();
            }
        }

        private void radButton2_Click_1(object sender, EventArgs e)
        {
            if (DialogResult.Yes == WinForm.MensajeBox(this, "Cerrar Ventana", "¿Desea Cerrar esta ventana?", MensajeBox.pregunta))
            {
                this.Close();
            }
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

       


       

       
    }
}
