using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisOxi.VO.Seguridad
{
    public class AuditoriaVO
    {
        private int _idAuditoria;

        public int idAuditoria
        {
            get { return _idAuditoria; }
            set { _idAuditoria = value; }
        }

        private int _idEmpleado;

        public int idEmpleado
        {
            get { return _idEmpleado; }
            set { _idEmpleado = value; }
        }

        private int _idRegistro;

        public int idRegistro
        {
            get { return _idRegistro; }
            set { _idRegistro = value; }
        }

        private string _tipo;

        public string tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }

        private string _tabla;

        public string tabla
        {
            get { return _tabla; }
            set { _tabla = value; }
        }

        private DateTime _fecha;

        public DateTime fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }

    }
}
