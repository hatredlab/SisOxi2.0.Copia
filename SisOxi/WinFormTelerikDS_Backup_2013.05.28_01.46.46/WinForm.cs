using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.WinControls.UI;
using Telerik.WinControls;
using System.Windows.Forms;
using System.Drawing;

namespace WinFormTelerikDS
{
    
    public enum MensajeBox
    {
        pregunta,
        informacion,
        error,
        advertencia,
    };

    public class WinForm
    {
        public static void SplashScreen(RadForm form)
        {
            
            form.ControlBox = false;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.ShowIcon = false;
            form.FormBorderStyle = FormBorderStyle.None;
        }

        public static void LlamarFormAPanel(RadForm form, RadPanel panel)
        {

            panel.Controls.Clear();
            
            SplashScreen(form);
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            form.Parent = panel;
            form.Show();
        }

        public static void CambiarPanel(RadPanel pnlInfo, RadPanel pnlContenido, EBotones estadoBoton)
        {
            switch (estadoBoton)
            {
                case EBotones.Reset: pnlContenido.Visible = true;
                    pnlInfo.Visible = false;
                    break;
                case EBotones.Nuevo: pnlContenido.Visible = false;
                    pnlInfo.Visible = true;
                    break;
                case EBotones.Modificar: pnlContenido.Visible = false;
                    pnlInfo.Visible = true;
                    break;
                case EBotones.MOModificar: pnlContenido.Visible = true;
                    pnlInfo.Visible = false;
                    break;
                case EBotones.Cancelar: pnlContenido.Visible = true;
                    pnlInfo.Visible = false;
                    break;
                case EBotones.Ver: pnlContenido.Visible = false;
                    pnlInfo.Visible = true;
                    break;
            }
        }

        public static void CambiarPanel(RadPanel pnlInfo, RadPanel pnlContenido, EBotones estadoBoton, Boolean IsActivo)
        {
            if ((estadoBoton == EBotones.Nuevo && IsActivo == false) || (estadoBoton == EBotones.Modificar && IsActivo == false))
            {
                estadoBoton = EBotones.Reset;
            }

            switch (estadoBoton)
            {
                case EBotones.Reset: pnlContenido.Visible = true;
                    pnlInfo.Visible = false;
                    break;
                case EBotones.Nuevo: pnlContenido.Visible = false;
                    pnlInfo.Visible = true;
                    break;
                case EBotones.Modificar: pnlContenido.Visible = false;
                    pnlInfo.Visible = true;
                    break;
                case EBotones.MOModificar: pnlContenido.Visible = true;
                    pnlInfo.Visible = false;
                    break;
                case EBotones.Cancelar: pnlContenido.Visible = true;
                    pnlInfo.Visible = false;
                    break;
                case EBotones.Ver: pnlInfo.Visible = true;
                    pnlContenido.Visible = false;
                    break;
            }
        }

        public static void ConvertirBordesRedondeadosLabelEnPanel(RadPanel panel)
        {

            foreach (Control ctrl in panel.Controls)
            {
                if (ctrl is RadLabel && ctrl.Name != "lblTitulo")
                {
                    RadLabel rad = (RadLabel)ctrl;
                    rad.LabelElement.Shape = new RoundRectShape();
                    rad.BackColor = Color.Transparent;
                    Color color = Color.FromArgb(64, 64, 64);
                    rad.LabelElement.LabelFill.GradientStyle = GradientStyles.Solid;
                    rad.LabelElement.LabelFill.BackColor = color;
                }
            }
        }

        public static void ConvertirBordesRedondeadosLabelEnGroupBox(RadGroupBox panel)
        {

            foreach (Control ctrl in panel.Controls)
            {
                if (ctrl is RadLabel && ctrl.Name != "lblTitulo")
                {
                    RadLabel rad = (RadLabel)ctrl;
                    rad.LabelElement.Shape = new RoundRectShape();
                    rad.BackColor = Color.Transparent;
                    Color colorr = Color.FromArgb(191, 219, 255);
                    Color color = Color.FromArgb(17, 105, 133);
                    rad.LabelElement.ForeColor = colorr;
                    rad.LabelElement.LabelFill.GradientStyle = GradientStyles.Solid;
                    rad.LabelElement.LabelFill.BackColor = color;
                }
            }
        }

        public static void ConvertirBordesRedondeadosLabelEnForm(RadForm form)
        {

            foreach (Control ctrl in form.Controls)
            {
                if (ctrl is RadLabel && ctrl.Name != "lblTitulo")
                {
                    RadLabel rad = (RadLabel)ctrl;
                    rad.LabelElement.Shape = new RoundRectShape();
                    rad.BackColor = Color.Transparent;
                    Color colorr = Color.FromArgb(191, 219, 255);
                    Color color = Color.FromArgb(17, 105, 133);
                    rad.LabelElement.ForeColor = colorr;
                    rad.LabelElement.LabelFill.GradientStyle = GradientStyles.Solid;
                    rad.LabelElement.LabelFill.BackColor = color;
                }
            }
        }

        public static void ConvertirBordesRedondeadosLabelEnPageView(RadPageViewPage pvPage)
        {

            foreach (Control ctrl in pvPage.Controls)
            {
                if (ctrl is RadLabel && ctrl.Name != "lblTitulo")
                {
                    RadLabel rad = (RadLabel)ctrl;
                    rad.LabelElement.Shape = new RoundRectShape();
                    rad.BackColor = Color.Transparent;
                    Color colorr = Color.FromArgb(191, 219, 255);
                    Color color = Color.FromArgb(17, 105, 133);
                   // Color color = Color.FromArgb(200, 19, 105, 160);
                    rad.LabelElement.ForeColor = colorr;
                    rad.LabelElement.LabelFill.GradientStyle = GradientStyles.Solid;
                    rad.LabelElement.LabelFill.BackColor = color;
                }
            }
        }


        public static void LimpiarControlesEnForm(RadForm form)
        {
            foreach(Control ctrl in form.Controls)
            {
                if (ctrl is RadLabel)
                {
                    RadLabel lbl = (RadLabel)ctrl;
                    foreach (Control ctrl2 in lbl.Controls)
                    {
                        if (ctrl2 is RadTextBox)
                        {
                            RadTextBox txt = (RadTextBox)ctrl2;
                            //txtCodigo.Text = txtCodigo.Text + "/" + lbl.Controls.IndexOf(ctrl2).ToString() + lbl.Controls[lbl.Controls.IndexOf(ctrl2)].Name;
                            txt.Text = string.Empty;
                        }
                        else if (ctrl2 is RadDropDownList)
                        {
                            RadDropDownList cbo = (RadDropDownList)ctrl2;
                            cbo.Text = "--Seleccione--";
                            cbo.SelectedIndex = -1;
                        }
                        else if (ctrl2 is RadTimePicker)
                        {
                            RadTimePicker dtp = (RadTimePicker)ctrl2;
                            dtp.Value = DateTime.Now;
                        }
                        else if(ctrl2 is RichTextBox)
                        {
                            RichTextBox rtb = (RichTextBox)ctrl2;
                            rtb.Text = string.Empty;
                        }
                        //txtCodigo.Text = txtCodigo.Text + "/" + pvPaginaDatosFiliacion.Controls.IndexOf(ctrl).ToString() + pvPaginaDatosFiliacion.Controls[pvPaginaDatosFiliacion.Controls.IndexOf(ctrl)].Name;
                    }
                }
            }
        }

        public static void LimpiarControlesEnGroupBox(RadGroupBox form)
        {
            foreach (Control ctrl in form.Controls)
            {
                if (ctrl is RadLabel)
                {
                    RadLabel lbl = (RadLabel)ctrl;
                    foreach (Control ctrl2 in lbl.Controls)
                    {
                        if (ctrl2 is RadTextBox)
                        {
                            RadTextBox txt = (RadTextBox)ctrl2;
                            //txtCodigo.Text = txtCodigo.Text + "/" + lbl.Controls.IndexOf(ctrl2).ToString() + lbl.Controls[lbl.Controls.IndexOf(ctrl2)].Name;
                            txt.Text = string.Empty;
                        }
                        else if (ctrl2 is RadDropDownList)
                        {
                            RadDropDownList cbo = (RadDropDownList)ctrl2;
                            cbo.Text = "--Seleccione--";
                            cbo.SelectedIndex = -1;
                        }
                        else if (ctrl2 is RadTimePicker)
                        {
                            RadTimePicker dtp = (RadTimePicker)ctrl2;
                            dtp.Value = DateTime.Now;
                        }
                        else if (ctrl2 is RichTextBox)
                        {
                            RichTextBox rtb = (RichTextBox)ctrl2;
                            rtb.Text = string.Empty;
                        }
                        //txtCodigo.Text = txtCodigo.Text + "/" + pvPaginaDatosFiliacion.Controls.IndexOf(ctrl).ToString() + pvPaginaDatosFiliacion.Controls[pvPaginaDatosFiliacion.Controls.IndexOf(ctrl)].Name;
                    }
                }
            }
        }

        public static void LimpiarControlesEnRadPageView(RadPageViewPage form)
        {
            foreach (Control ctrl in form.Controls)
            {
                if (ctrl is RadLabel)
                {
                    RadLabel lbl = (RadLabel)ctrl;
                    foreach (Control ctrl2 in lbl.Controls)
                    {
                        if (ctrl2 is RadTextBox)
                        {
                            RadTextBox txt = (RadTextBox)ctrl2;
                            //txtCodigo.Text = txtCodigo.Text + "/" + lbl.Controls.IndexOf(ctrl2).ToString() + lbl.Controls[lbl.Controls.IndexOf(ctrl2)].Name;
                            txt.Text = string.Empty;
                        }
                        else if (ctrl2 is RadDropDownList)
                        {
                            RadDropDownList cbo = (RadDropDownList)ctrl2;
                            cbo.Text = "--Seleccione--";
                            cbo.SelectedIndex = -1;
                        }
                        else if (ctrl2 is RadTimePicker)
                        {
                            RadTimePicker dtp = (RadTimePicker)ctrl2;
                            dtp.Value = DateTime.Now;
                        }
                        else if (ctrl2 is RichTextBox)
                        {
                            RichTextBox rtb = (RichTextBox)ctrl2;
                            rtb.Text = string.Empty;
                        }
                        //txtCodigo.Text = txtCodigo.Text + "/" + pvPaginaDatosFiliacion.Controls.IndexOf(ctrl).ToString() + pvPaginaDatosFiliacion.Controls[pvPaginaDatosFiliacion.Controls.IndexOf(ctrl)].Name;
                    }
                }
            }
        }

        public static DialogResult MensajeBox(RadForm form,string titulo, string contenido, MensajeBox mensajeBox)
        {
            DialogResult resultado=DialogResult.Cancel;
             
            switch (mensajeBox)
            {
                   
                case WinFormTelerikDS.MensajeBox.advertencia :
                        resultado = RadMessageBox.Show(form,contenido, titulo, 
                                             MessageBoxButtons.OK, RadMessageIcon.Exclamation);
                    break;
                case WinFormTelerikDS.MensajeBox.pregunta:
                    resultado = RadMessageBox.Show(form, contenido, titulo,
                                             MessageBoxButtons.YesNo, RadMessageIcon.Question);
                    break;
                case WinFormTelerikDS.MensajeBox.error:
                    resultado = RadMessageBox.Show(form, contenido, titulo,
                                             MessageBoxButtons.OK, RadMessageIcon.Error);
                    break;
                case WinFormTelerikDS.MensajeBox.informacion:
                    resultado = RadMessageBox.Show(form, contenido, titulo,
                                             MessageBoxButtons.OK, RadMessageIcon.Info);
                    break;
                

            }

            return resultado;
            //DialogResult resultado = RadMessageBox.Show(this, "¿Realmente desea cambiar la Conexion a BD?", "Conexion BD", MessageBoxButtons.YesNo, RadMessageIcon.Question);
        }

        public static void TabEnterEnForm(RadForm form)
        {
            foreach(Control ctrl in form.Controls)
            {
                if (ctrl is RadLabel)
                {
                    RadLabel lbl = (RadLabel)ctrl;
                    foreach (Control ctrl2 in lbl.Controls)
                    {
                        if (ctrl2 is RadTextBox)
                        {
                            RadTextBox txt = (RadTextBox)ctrl2;
                            //txtCodigo.Text = txtCodigo.Text + "/" + lbl.Controls.IndexOf(ctrl2).ToString() + lbl.Controls[lbl.Controls.IndexOf(ctrl2)].Name;
                            txt.Text = string.Empty;
                            txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(delegate(object s, KeyPressEventArgs e)
                            {
                            if (e.KeyChar == (char)(Keys.Enter))
                            {
                                e.Handled = true;
                                SendKeys.Send("{TAB}");
                            }
                            });
                        }
                        else if (ctrl2 is RadDropDownList)
                        {
                            RadDropDownList rdl = (RadDropDownList)ctrl2;
                            rdl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(delegate(object s, KeyPressEventArgs e)
                            {
                                if (e.KeyChar == (char)(Keys.Enter))
                                {
                                    e.Handled = true;
                                    SendKeys.Send("{TAB}");
                                }
                            });
                        }
                        else if (ctrl2 is RadDateTimePicker)
                        {
                            RadDateTimePicker rdl = (RadDateTimePicker)ctrl2;
                            rdl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(delegate(object s, KeyPressEventArgs e)
                            {
                                if (e.KeyChar == (char)(Keys.Enter))
                                {
                                    e.Handled = true;
                                    SendKeys.Send("{TAB}");
                                }
                                else if (e.KeyChar == (char)(Keys.Space))
                                {
                                    rdl.Show();
                                }
                            });

                        }

                        else if (ctrl2 is RadioButton)
                        {
                            RadioButton rdl = (RadioButton)ctrl2;
                            rdl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(delegate(object s, KeyPressEventArgs e)
                            {
                                if (e.KeyChar == (char)(Keys.Enter))
                                {
                                    e.Handled = true;
                                    SendKeys.Send("{TAB}");
                                }
                            });
                        }
                        //txtCodigo.Text = txtCodigo.Text + "/" + pvPaginaDatosFiliacion.Controls.IndexOf(ctrl).ToString() + pvPaginaDatosFiliacion.Controls[pvPaginaDatosFiliacion.Controls.IndexOf(ctrl)].Name;
                    }
                }
            }
        }

        public static RadForm EstaAbiertoFormulario(Type FormType)
        {
            foreach (RadForm OpenForm in Application.OpenForms)
            {
                if (OpenForm.GetType() == FormType)
                    return OpenForm;
            }

            return null;
        }

        public static void TabEnterEnGroupBox(RadGroupBox form)
        {
            foreach (Control ctrl in form.Controls)
            {
                if (ctrl is RadLabel)
                {
                    RadLabel lbl = (RadLabel)ctrl;
                    foreach (Control ctrl2 in lbl.Controls)
                    {
                        if (ctrl2 is RadTextBox)
                        {
                            RadTextBox txt = (RadTextBox)ctrl2;
                            //txtCodigo.Text = txtCodigo.Text + "/" + lbl.Controls.IndexOf(ctrl2).ToString() + lbl.Controls[lbl.Controls.IndexOf(ctrl2)].Name;
                            txt.Text = string.Empty;
                            txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(delegate(object s, KeyPressEventArgs e)
                            {
                                if (e.KeyChar == (char)(Keys.Enter))
                                {
                                    e.Handled = true;
                                    SendKeys.Send("{TAB}");
                                }
                            });
                        }
                        else if (ctrl2 is RadDropDownList)
                        {
                            RadDropDownList rdl = (RadDropDownList)ctrl2;
                            rdl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(delegate(object s, KeyPressEventArgs e)
                            {
                                if (e.KeyChar == (char)(Keys.Enter))
                                {
                                    e.Handled = true;
                                    SendKeys.Send("{TAB}");
                                }

                            });
                        }

                        else if (ctrl2 is RadDateTimePicker)
                        {
                            RadDateTimePicker rdl = (RadDateTimePicker)ctrl2;
                            rdl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(delegate(object s, KeyPressEventArgs e)
                            {
                                if (e.KeyChar == (char)(Keys.Enter))
                                {
                                    e.Handled = true;
                                    SendKeys.Send("{TAB}");
                                }
                                else if (e.KeyChar == (char)(Keys.Space))
                                {
                                    rdl.Show();
                                }
                            });

                        }

                        else if (ctrl2 is RadioButton)
                        {
                            RadioButton rdl = (RadioButton)ctrl2;
                            rdl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(delegate(object s, KeyPressEventArgs e)
                            {
                                if (e.KeyChar == (char)(Keys.Enter))
                                {
                                    e.Handled = true;
                                    SendKeys.Send("{TAB}");
                                }
                            });
                        }

                        //txtCodigo.Text = txtCodigo.Text + "/" + pvPaginaDatosFiliacion.Controls.IndexOf(ctrl).ToString() + pvPaginaDatosFiliacion.Controls[pvPaginaDatosFiliacion.Controls.IndexOf(ctrl)].Name;
                    }
                }
            }
        }

        public static void TabEnterEnPageView(RadPageViewPage form)
        {
            foreach (Control ctrl in form.Controls)
            {
                if (ctrl is RadLabel)
                {
                    RadLabel lbl = (RadLabel)ctrl;
                    foreach (Control ctrl2 in lbl.Controls)
                    {
                        if (ctrl2 is RadTextBox)
                        {
                            RadTextBox txt = (RadTextBox)ctrl2;
                            //txtCodigo.Text = txtCodigo.Text + "/" + lbl.Controls.IndexOf(ctrl2).ToString() + lbl.Controls[lbl.Controls.IndexOf(ctrl2)].Name;
                            txt.Text = string.Empty;
                            txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(delegate(object s, KeyPressEventArgs e)
                            {
                                if (e.KeyChar == (char)(Keys.Enter))
                                {
                                    e.Handled = true;
                                    SendKeys.Send("{TAB}");
                                }
                            });
                        }
                        else if (ctrl2 is RadDropDownList)
                        {
                            RadDropDownList rdl = (RadDropDownList)ctrl2;
                            rdl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(delegate(object s, KeyPressEventArgs e)
                            {
                                if (e.KeyChar == (char)(Keys.Enter))
                                {
                                    e.Handled = true;
                                    SendKeys.Send("{TAB}");
                                }
                                
                            });
                        }

                        else if (ctrl2 is RadDateTimePicker)
                        {
                            RadDateTimePicker rdl = (RadDateTimePicker)ctrl2;
                            rdl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(delegate(object s, KeyPressEventArgs e)
                            {
                                if (e.KeyChar == (char)(Keys.Enter))
                                {
                                    e.Handled = true;
                                    SendKeys.Send("{TAB}");
                                }
                                else if (e.KeyChar == (char)(Keys.Space))
                                {
                                    rdl.Show();
                                }
                            });
                            
                        }

                        else if (ctrl2 is RadioButton)
                        {
                            RadioButton rdl = (RadioButton)ctrl2;
                            rdl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(delegate(object s, KeyPressEventArgs e)
                            {
                                if (e.KeyChar == (char)(Keys.Enter))
                                {
                                    e.Handled = true;
                                    SendKeys.Send("{TAB}");
                                }
                            });
                        }

                        //txtCodigo.Text = txtCodigo.Text + "/" + pvPaginaDatosFiliacion.Controls.IndexOf(ctrl).ToString() + pvPaginaDatosFiliacion.Controls[pvPaginaDatosFiliacion.Controls.IndexOf(ctrl)].Name;
                    }
                }
            }
        }

        public static void BloquearControlesEnForm(RadForm form)
        {
            foreach (Control ctrl in form.Controls)
            {
                if (ctrl is RadLabel)
                {
                    RadLabel lbl = (RadLabel)ctrl;
                    foreach (Control ctrl2 in lbl.Controls)
                    {
                        if (ctrl2 is RadTextBox)
                        {
                            RadTextBox txt = (RadTextBox)ctrl2;
                            //txtCodigo.Text = txtCodigo.Text + "/" + lbl.Controls.IndexOf(ctrl2).ToString() + lbl.Controls[lbl.Controls.IndexOf(ctrl2)].Name;
                            txt.Enabled = false;
                        }
                        else if (ctrl2 is RadDropDownList)
                        {
                            RadDropDownList cbo = (RadDropDownList)ctrl2;
                            cbo.Enabled = false;
                        }
                        else if (ctrl2 is RadDateTimePicker)
                        {
                            RadDateTimePicker dtp = (RadDateTimePicker)ctrl2;
                            dtp.Enabled = false;
                        }
                        else if (ctrl2 is RichTextBox)
                        {
                            RichTextBox rtb = (RichTextBox)ctrl2;
                            rtb.Enabled = false;
                        }
                        //txtCodigo.Text = txtCodigo.Text + "/" + pvPaginaDatosFiliacion.Controls.IndexOf(ctrl).ToString() + pvPaginaDatosFiliacion.Controls[pvPaginaDatosFiliacion.Controls.IndexOf(ctrl)].Name;
                    }
                }
            }
        }


        public static void BloquearControlesEnPageView(RadPageViewPage form)
        {
            foreach (Control ctrl in form.Controls)
            {
                if (ctrl is RadLabel)
                {
                    RadLabel lbl = (RadLabel)ctrl;
                    foreach (Control ctrl2 in lbl.Controls)
                    {
                        if (ctrl2 is RadTextBox)
                        {
                            RadTextBox txt = (RadTextBox)ctrl2;
                            //txtCodigo.Text = txtCodigo.Text + "/" + lbl.Controls.IndexOf(ctrl2).ToString() + lbl.Controls[lbl.Controls.IndexOf(ctrl2)].Name;
                            txt.Enabled = false;
                        }
                        else if (ctrl2 is RadDropDownList)
                        {
                            RadDropDownList cbo = (RadDropDownList)ctrl2;
                            cbo.Enabled = false;
                        }
                        else if (ctrl2 is RadDateTimePicker)
                        {
                            RadDateTimePicker dtp = (RadDateTimePicker)ctrl2;
                            dtp.Enabled = false;
                        }
                        else if (ctrl2 is RichTextBox)
                        {
                            RichTextBox rtb = (RichTextBox)ctrl2;
                            rtb.Enabled = false;
                        }
                        //txtCodigo.Text = txtCodigo.Text + "/" + pvPaginaDatosFiliacion.Controls.IndexOf(ctrl).ToString() + pvPaginaDatosFiliacion.Controls[pvPaginaDatosFiliacion.Controls.IndexOf(ctrl)].Name;
                    }
                }
            }
        }


        public static void BloquearControlesEnGroupBox(RadGroupBox form)
        {
            foreach (Control ctrl in form.Controls)
            {
                if (ctrl is RadLabel)
                {
                    RadLabel lbl = (RadLabel)ctrl;
                    foreach (Control ctrl2 in lbl.Controls)
                    {
                        if (ctrl2 is RadTextBox)
                        {
                            RadTextBox txt = (RadTextBox)ctrl2;
                            //txtCodigo.Text = txtCodigo.Text + "/" + lbl.Controls.IndexOf(ctrl2).ToString() + lbl.Controls[lbl.Controls.IndexOf(ctrl2)].Name;
                            txt.Enabled = false;
                        }
                        else if (ctrl2 is RadDropDownList)
                        {
                            RadDropDownList cbo = (RadDropDownList)ctrl2;
                            cbo.Enabled = false;
                        }
                        else if (ctrl2 is RadDateTimePicker)
                        {
                            RadDateTimePicker dtp = (RadDateTimePicker)ctrl2;
                            dtp.Enabled = false;
                        }
                        else if (ctrl2 is RichTextBox)
                        {
                            RichTextBox rtb = (RichTextBox)ctrl2;
                            rtb.Enabled = false;
                        }
                        //txtCodigo.Text = txtCodigo.Text + "/" + pvPaginaDatosFiliacion.Controls.IndexOf(ctrl).ToString() + pvPaginaDatosFiliacion.Controls[pvPaginaDatosFiliacion.Controls.IndexOf(ctrl)].Name;
                    }
                }
            }
        }

        public static void DesbloquearControlesEnGroupBox(RadGroupBox form)
        {
            foreach (Control ctrl in form.Controls)
            {
                if (ctrl is RadLabel)
                {
                    RadLabel lbl = (RadLabel)ctrl;
                    foreach (Control ctrl2 in lbl.Controls)
                    {
                        if (ctrl2 is RadTextBox)
                        {
                            RadTextBox txt = (RadTextBox)ctrl2;
                            //txtCodigo.Text = txtCodigo.Text + "/" + lbl.Controls.IndexOf(ctrl2).ToString() + lbl.Controls[lbl.Controls.IndexOf(ctrl2)].Name;
                            txt.Enabled = true;
                        }
                        else if (ctrl2 is RadDropDownList)
                        {
                            RadDropDownList cbo = (RadDropDownList)ctrl2;
                            cbo.Enabled = true;
                        }
                        else if (ctrl2 is RadDateTimePicker)
                        {
                            RadDateTimePicker dtp = (RadDateTimePicker)ctrl2;
                            dtp.Enabled = true;
                        }
                        else if (ctrl2 is RichTextBox)
                        {
                            RichTextBox rtb = (RichTextBox)ctrl2;
                            rtb.Enabled = true;
                        }

                    }
                }
            }
        }

        public static void DesbloquearControlesEnForm(RadForm form)
        {
            foreach (Control ctrl in form.Controls)
            {
                if (ctrl is RadLabel)
                {
                    RadLabel lbl = (RadLabel)ctrl;
                    foreach (Control ctrl2 in lbl.Controls)
                    {
                        if (ctrl2 is RadTextBox)
                        {
                            RadTextBox txt = (RadTextBox)ctrl2;
                            //txtCodigo.Text = txtCodigo.Text + "/" + lbl.Controls.IndexOf(ctrl2).ToString() + lbl.Controls[lbl.Controls.IndexOf(ctrl2)].Name;
                            txt.Enabled = true;
                        }
                        else if (ctrl2 is RadDropDownList)
                        {
                            RadDropDownList cbo = (RadDropDownList)ctrl2;
                            cbo.Enabled = true;
                        }
                        else if (ctrl2 is RadDateTimePicker)
                        {
                            RadDateTimePicker dtp = (RadDateTimePicker)ctrl2;
                            dtp.Enabled = true;
                        }
                        else if (ctrl2 is RichTextBox)
                        {
                            RichTextBox rtb = (RichTextBox)ctrl2;
                            rtb.Enabled = true;
                        }
                        
                    }
                }
            }
        }

        public static void DesbloquearControlesPageView(RadPageViewPage form)
        {
            foreach (Control ctrl in form.Controls)
            {
                if (ctrl is RadLabel)
                {
                    RadLabel lbl = (RadLabel)ctrl;
                    foreach (Control ctrl2 in lbl.Controls)
                    {
                        if (ctrl2 is RadTextBox)
                        {
                            RadTextBox txt = (RadTextBox)ctrl2;
                            //txtCodigo.Text = txtCodigo.Text + "/" + lbl.Controls.IndexOf(ctrl2).ToString() + lbl.Controls[lbl.Controls.IndexOf(ctrl2)].Name;
                            txt.Enabled = true;
                        }
                        else if (ctrl2 is RadDropDownList)
                        {
                            RadDropDownList cbo = (RadDropDownList)ctrl2;
                            cbo.Enabled = true;
                        }
                        else if (ctrl2 is RadDateTimePicker)
                        {
                            RadDateTimePicker dtp = (RadDateTimePicker)ctrl2;
                            dtp.Enabled = true;
                        }
                        else if (ctrl2 is RichTextBox)
                        {
                            RichTextBox rtb = (RichTextBox)ctrl2;
                            rtb.Enabled = true;
                        }

                    }
                }
            }
        }

        public static void PermitirSoloNumeros(RadTextBox txt)
        {
            txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(delegate(object s, KeyPressEventArgs e)
            {
                if (Char.IsDigit(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            });
            
        }

        #region Metodos Para Clicks

        public static void EventoClickBotonNuevo(RadButton btnNuevo, RadButton btnModificar, RadButton btnCancelar, ref Boolean IsGuardarActivo, ref Boolean IsModificarActivo)
        {
            Botones.AsignarIconoBotonNuevo(btnNuevo, ref IsGuardarActivo);
            Botones.AsignarBloqueoBotones(btnNuevo, btnModificar, btnCancelar, EBotones.Nuevo, ref IsGuardarActivo, ref IsModificarActivo);
            //CambiarPanel(pnlInfo, pnlContenido, EBotones.Nuevo, IsGuardarActivo);
        }

        public static void EventoClickBotonModificar(RadButton btnNuevo, RadButton btnModificar, RadButton btnCancelar, ref Boolean IsGuardarActivo, ref Boolean IsModificarActivo)
        {
            Botones.AsignarIconoBotonModificar(btnModificar, ref IsModificarActivo);
            Botones.AsignarBloqueoBotones(btnNuevo, btnModificar, btnCancelar, EBotones.Modificar, ref IsGuardarActivo, ref IsModificarActivo);
           // WinForm.CambiarPanel(pnlInfo, pnlContenido, EBotones.Modificar, IsModificarActivo);
        }

        public static void EventoClickBotonModificar(RadButton btnModificar, RadButton btnCancelar, ref Boolean IsModificarActivo)
        {
            Botones.AsignarIconoBotonModificar(btnModificar, ref IsModificarActivo);
            Botones.AsignarBloqueoBotones(btnModificar, btnCancelar, EBotones.Modificar,ref IsModificarActivo);
            // WinForm.CambiarPanel(pnlInfo, pnlContenido, EBotones.Modificar, IsModificarActivo);
        }

        public static void EventoClickBotonCancelar(RadButton btnNuevo, RadButton btnModificar, RadButton btnCancelar, ref Boolean IsGuardarActivo, ref Boolean IsModificarActivo)
        {
            Botones.AsignarBloqueoBotones(btnNuevo, btnModificar, btnCancelar, EBotones.Cancelar, ref IsGuardarActivo, ref IsModificarActivo);
           // WinForm.CambiarPanel(pnlInfo, pnlContenido, EBotones.Cancelar);
        }

        public static void EventoClickCeldaDataGridView(RadButton btnNuevo, RadButton btnModificar, RadButton btnCancelar, ref Boolean IsGuardarActivo, ref Boolean IsModificarActivo)
        {
            Botones.AsignarBloqueoBotones(btnNuevo, btnModificar, btnCancelar, EBotones.MOModificar, ref IsGuardarActivo, ref IsModificarActivo);

        }

        public static void EventoClickBotonVer(RadButton btnNuevo, RadButton btnModificar, RadButton btnCancelar, ref Boolean IsGuardarActivo, ref Boolean IsModificarActivo, RadPanel pnlInfo, RadPanel pnlContenido)
        {
            Botones.AsignarIconoBotonNuevo(btnNuevo, ref IsGuardarActivo);
            Botones.AsignarBloqueoBotones(btnNuevo, btnModificar, btnCancelar, EBotones.Ver, ref IsGuardarActivo, ref IsModificarActivo);
            CambiarPanel(pnlInfo, pnlContenido, EBotones.Ver, IsGuardarActivo);
        }

        #endregion


    }
}
