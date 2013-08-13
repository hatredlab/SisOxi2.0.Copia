using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace WinFormTelerikDS
{
    public static class MetodosExtensivos
    {

        public static T ValidarComboBox<T>(this Object value, Control ctrl, string nombreCombo)
        {

            RadDropDownList cbo = (RadDropDownList)ctrl;
            if (cbo.Text != "--Seleccione--")
            {
                return (T)value;
            }
            else
            {
                
                cbo.Select();
                throw ExcepcionesApp.Validar(nombreCombo);
            }

        }

        public static string ValidarTextBox(this Object value, Control ctrl, string nombreControl)
        {
            if(value.ToString() != string.Empty)
            {
                return value.ToString();
            }
            else
            {
                RadTextBox txt = (RadTextBox)ctrl;
                txt.Select();
                throw ExcepcionesApp.Validar(nombreControl);

            }
        }

        public static int ToInt(this string value, string nombreControl)
        {
            if (value != string.Empty)
            {
                return Convert.ToInt32(value);
            }
            else
            {
                throw ExcepcionesApp.Validar(nombreControl);
            }
        }

        public static int ToInt(this string value)
        {
            if (value != string.Empty)
            {
                return Convert.ToInt32(value);
            }
            else
            {
                throw new Exception();
            }
        }

        public static decimal ToDecimal(this string value, string nombreControl)
        {
            if (value != string.Empty)
            {
                return Convert.ToDecimal(value);
            }
            else
            {
                throw ExcepcionesApp.Validar(nombreControl);
            }
        }
    }
}
