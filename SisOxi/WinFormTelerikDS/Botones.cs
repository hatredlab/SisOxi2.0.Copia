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
    public enum EBotones
    {
        Reset,
        Nuevo,
        Modificar,
        MOModificar,
        Cancelar,
        Ver,
    };

    public class Botones
    {
        public static void AsignarIconoBotonNuevo(RadButton boton, ref Boolean IsGuardarActivo)
        {
            if (IsGuardarActivo)
            {
                boton.Image = global::WinFormTelerikDS.Properties.Resources.Gnome_Document_New_48;
                boton.Text = "Nuevo";
                IsGuardarActivo = false;
            }
            else
            {
                boton.Image = global::WinFormTelerikDS.Properties.Resources.Gnome_Media_Floppy_48;
                boton.Text = "Guardar";
                IsGuardarActivo = true;

            }
        }

        public static void AsignarIconoBotonModificar(RadButton boton, ref Boolean IsModificarActivo)
        {
            if (IsModificarActivo)
            {
                boton.Image = global::WinFormTelerikDS.Properties.Resources.Gnome_Accessories_Text_Editor_48;
                boton.Text = "Modificar";
                IsModificarActivo = false;
            }
            else
            {
                boton.Image = global::WinFormTelerikDS.Properties.Resources.Gnome_Media_Floppy_48;
                boton.Text = "Guardar";
                IsModificarActivo = true;

            }
        }

        public static void AsignarBloqueoBotones(RadButton btnNuevo, RadButton btnModificar, RadButton btnCancelar, EBotones estadoBoton, ref Boolean IsGuardarActivo, ref Boolean IsModificarActivo)
        {
            if ((estadoBoton == EBotones.Nuevo && IsGuardarActivo == false) || (estadoBoton == EBotones.Modificar && IsModificarActivo == false))
            {
                estadoBoton = EBotones.Reset;
            }


            switch (estadoBoton)
            {
                case EBotones.Reset: btnNuevo.Enabled = true;
                    btnModificar.Enabled = true;
                    btnCancelar.Enabled = false;
                    IsGuardarActivo = true;
                    IsModificarActivo = true;
                    AsignarIconoBotonModificar(btnModificar, ref IsModificarActivo);
                    AsignarIconoBotonNuevo(btnNuevo, ref IsGuardarActivo);
                    break;

                case EBotones.Nuevo: btnNuevo.Enabled = true;
                    btnModificar.Enabled = false;
                    btnCancelar.Enabled = true;
                    break;

                case EBotones.Modificar: btnNuevo.Enabled = false;
                    btnModificar.Enabled = true;
                    btnCancelar.Enabled = true;
                    break;

                case EBotones.MOModificar: btnNuevo.Enabled = true;
                    btnModificar.Enabled = true;
                    btnCancelar.Enabled = false;
                    break;

                case EBotones.Cancelar: btnNuevo.Enabled = true;
                    btnModificar.Enabled = false;
                    btnCancelar.Enabled = false;
                    IsGuardarActivo = true;
                    IsModificarActivo = true;
                    AsignarIconoBotonModificar(btnModificar, ref IsModificarActivo);
                    AsignarIconoBotonNuevo(btnNuevo, ref IsGuardarActivo);
                    break;

                case EBotones.Ver: btnNuevo.Enabled = true;
                    btnModificar.Enabled = true;
                    btnCancelar.Enabled = false;
                    IsGuardarActivo = true;
                    IsModificarActivo = true;
                    AsignarIconoBotonModificar(btnModificar, ref IsModificarActivo);
                    AsignarIconoBotonNuevo(btnNuevo, ref IsGuardarActivo);
                    break;

                default: break;

            }
        }

        public static void AsignarBloqueoBotones(RadButton btnModificar, RadButton btnCancelar, EBotones estadoBoton,ref Boolean IsModificarActivo)
        {
            if (estadoBoton == EBotones.Modificar && IsModificarActivo == false)
            {
                estadoBoton = EBotones.Reset;
            }


            switch (estadoBoton)
            {
                case EBotones.Reset: 
                    btnModificar.Enabled = true;
                    btnCancelar.Enabled = false;
                
                    IsModificarActivo = true;
                    AsignarIconoBotonModificar(btnModificar, ref IsModificarActivo);
                    
                    break;

                case EBotones.Nuevo: 
                    btnModificar.Enabled = false;
                    btnCancelar.Enabled = true;
                    break;

                case EBotones.Modificar: 
                    btnModificar.Enabled = true;
                    btnCancelar.Enabled = true;
                    break;

                case EBotones.MOModificar: 
                    btnModificar.Enabled = true;
                    btnCancelar.Enabled = false;
                    break;

                case EBotones.Cancelar: 
                    btnModificar.Enabled = true;
                    btnCancelar.Enabled = false;
                    
                    IsModificarActivo = true;
                    AsignarIconoBotonModificar(btnModificar, ref IsModificarActivo);
                    
                    break;

                case EBotones.Ver:
                    btnModificar.Enabled = true;
                    btnCancelar.Enabled = false;
                    
                    IsModificarActivo = true;
                    AsignarIconoBotonModificar(btnModificar, ref IsModificarActivo);
                   
                    break;

                default: break;

            }
        }


    }
}
