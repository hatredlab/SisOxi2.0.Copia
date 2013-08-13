using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace WinFormTelerikDS
{
    public class Clases
    {
        public static T LlenarObjetoConRegistroDataRow<T>(DataRow dr) where T:class,new()
        {
            T objeto = Activator.CreateInstance(typeof(T)) as T;

            PropertyInfo[] props = typeof(T).GetProperties();
            int i = 0;
            foreach (PropertyInfo prop in props)
            {
                if (prop.PropertyType == typeof(int))
                {
                    prop.SetValue(objeto, Convert.ToInt32(dr[char.ToLower(prop.Name[0])+prop.Name.ToString().Substring(1)]), null);
                    
                }
                else if (prop.PropertyType == typeof(DateTime))
                {
                    prop.SetValue(objeto, Convert.ToDateTime(dr[char.ToLower(prop.Name[0]) + prop.Name.ToString().Substring(1)]), null);
                    i++;
                }
                else if (prop.PropertyType == typeof(decimal))
                {
                    prop.SetValue(objeto, Convert.ToDecimal(dr[char.ToLower(prop.Name[0]) + prop.Name.ToString().Substring(1)]), null);
                    i++;
                }
                else
                {
                    prop.SetValue(objeto, dr[char.ToLower(prop.Name[0]) + prop.Name.ToString().Substring(1)].ToString(), null);
                    i++;
                }

            }

            return objeto;
        }

        public static T LlenarObjetoConRegistroListViewDataItem<T>(ListViewDataItem dr) where T : class,new()
        {
            T objeto = Activator.CreateInstance(typeof(T)) as T;

            PropertyInfo[] props = typeof(T).GetProperties();
            int i = 0;
            foreach (PropertyInfo prop in props)
            {
                if (prop.PropertyType == typeof(int))
                {
                    prop.SetValue(objeto, Convert.ToInt32(dr[char.ToLower(prop.Name[0]) + prop.Name.ToString().Substring(1)]), null);
                    i++;
                }
                else if (prop.PropertyType == typeof(DateTime))
                {
                    prop.SetValue(objeto, Convert.ToDateTime(dr[char.ToLower(prop.Name[0]) + prop.Name.ToString().Substring(1)]), null);
                    i++;
                }
                else if (prop.PropertyType == typeof(decimal))
                {
                    prop.SetValue(objeto, Convert.ToDecimal(dr[char.ToLower(prop.Name[0]) + prop.Name.ToString().Substring(1)]), null);
                    i++;
                }
                else
                {
                    prop.SetValue(objeto, dr[char.ToLower(prop.Name[0]) + prop.Name.ToString().Substring(1)].ToString(), null);
                    i++;
                }

            }

            return objeto;
        }
    }
}
