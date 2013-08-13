using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisOxi.VO
{
    public class TratamientoVO
    {
        #region campos

        private int _idTratamiento;

        public int IdTratamiento
        {
            get { return _idTratamiento; }
            set { _idTratamiento = value; }
        }

        private int _idImpresionDiagnostica;

        public int idImpresionDiagnostica
        {
            get { return _idImpresionDiagnostica; }
            set { _idImpresionDiagnostica = value; }
        }

        private string _estadoTratamiento;

        public string EstadoTratamiento
        {
            get { return _estadoTratamiento; }
            set { _estadoTratamiento = value; }
        }

        private string _estadoPaciente;

        public string EstadoPaciente
        {
            get { return _estadoPaciente; }
            set { _estadoPaciente = value; }
        }

        private string _observacionesTratamiento; 

        public string ObservacionesTratamiento
        {
            get { return _observacionesTratamiento; }
            set { _observacionesTratamiento = value; }
        }

        private string _tipoTratamiento;

        public string TipoTratamiento
        {
            get { return _tipoTratamiento; }
            set { _tipoTratamiento = value; }
        }

        private DateTime _fechaInicioTratamiento;

        public DateTime fechaInicioTratamiento
        {
            get { return _fechaInicioTratamiento; }
            set { _fechaInicioTratamiento = value; }
        }


        #endregion
    }
}
