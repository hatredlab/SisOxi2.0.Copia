using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisOxi.VO
{
    public class ImpresionDiagnosticaVO
    {
        #region campos
        private int _idImpresionDiagnostica;

        public int IdImpresionDiagnostica
        {
            get { return _idImpresionDiagnostica; }
            set { _idImpresionDiagnostica = value; }
        }

        private int _idImpresionDiagnosticaAlterna;

        public int idImpresionDiagnosticaAlterna
        {
            get { return _idImpresionDiagnosticaAlterna; }
            set { _idImpresionDiagnosticaAlterna = value; }
        }

        private int _idEnfermedad;

        public int IdEnfermedad
        {
            get { return _idEnfermedad; }
            set { _idEnfermedad = value; }
        }

        private int _idHistoriaClinica;

        public int IdHistoriaClinica
        {
            get { return _idHistoriaClinica; }
            set { _idHistoriaClinica = value; }
        }

        private string _observaciones;

        public string Observaciones
        {
            get { return _observaciones; }
            set { _observaciones = value; }
        }

        private string _nombreEnfermedad;

        public string NombreEnfermedad
        {
            get { return _nombreEnfermedad; }
            set { _nombreEnfermedad = value; }
        }
        #endregion
    }
}
