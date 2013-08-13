using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisOxi.VO
{
    public class SesionesTratamientoVO
    {
        #region campos
        private int _idSesionTratamiento;

        public int idSesionTratamiento
        {
            get { return _idSesionTratamiento; }
            set { _idSesionTratamiento = value; }
        }

        private DateTime _fechaSesion;

        public DateTime fechaSesion
        {
            get { return _fechaSesion; }
            set { _fechaSesion = value; }
        }

        private decimal _consumoOxigeno;

        public decimal consumoOxigeno
        {
            get { return _consumoOxigeno; }
            set { _consumoOxigeno = value; }
        }

        private string _notasTender;

        public string notasTender
        {
            get { return _notasTender; }
            set { _notasTender = value; }
        }

        private int _idTratamiento;

        public int idTratamiento
        {
            get { return _idTratamiento; }
            set { _idTratamiento = value; }
        }

        private int _idEmpleado;

        public int idEmpleado
        {
            get { return _idEmpleado; }
            set { _idEmpleado = value; }
        }

        private string _protocolo;

        public string protocolo
        {
            get { return _protocolo; }
            set { _protocolo = value; }
        }

        #endregion
    }
}
