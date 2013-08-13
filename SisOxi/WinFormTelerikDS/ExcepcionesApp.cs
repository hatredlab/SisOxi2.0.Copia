using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormTelerikDS
{
    public class ExcepcionesApp : ApplicationException
    {
        public ExcepcionesApp() : base() { }
        public ExcepcionesApp(string s) : base(s) { }
        public ExcepcionesApp(string s, Exception ex) : base(s, ex) { }


        public static ExcepcionesApp Validar(string control)
        {

            return new ExcepcionesApp("\n\tPorfavor ingrese un valor valido para " + control);
        }


    }
}
