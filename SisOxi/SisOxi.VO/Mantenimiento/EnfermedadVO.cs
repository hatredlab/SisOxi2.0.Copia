using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisOxi.VO
{
    public class EnfermedadVO
    {

        #region campos
        private int _idEnfermedad;

        public int IdEnfermedad
        {
            get { return _idEnfermedad; }
            set { _idEnfermedad = value; }
        }

        private string _nombre;

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        private string _descripcion;

        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        private string _tipo;

        public string Tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }

        #endregion

    }
}
