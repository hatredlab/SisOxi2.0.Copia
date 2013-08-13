using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisOxi.VO
{
    public class EmpleadoVO
    {
        #region campos
        private int _idEmpleado;

        public int IdEmpleado
        {
            get { return _idEmpleado; }
            set { _idEmpleado = value; }
        }

        private string _nombres;

        public string Nombres
        {
            get { return _nombres; }
            set { _nombres = value; }
        }

        private string _apellidos;

        public string Apellidos
        {
            get { return _apellidos; }
            set { _apellidos = value; }
        }

        private string _direccionDomiciliaria;

        public string DireccionDomiciliaria
        {
            get { return _direccionDomiciliaria; }
            set { _direccionDomiciliaria = value; }
        }

        private string _fono;

        public string Fono
        {
            get { return _fono; }
            set { _fono = value; }
        }

        private string _cargo;

        public string Cargo
        {
            get { return _cargo; }
            set { _cargo = value; }
        }

        private string _dni;

        public string Dni
        {
            get { return _dni; }
            set { _dni = value; }
        }

        private string _clave;

        public string Clave
        {
            get { return _clave; }
            set { _clave = value; }
        }
        #endregion
    }
}
