using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisOxi.VO
{
    public class ExamenGabineteVO
    {
        #region campos

        private int _idExamenGabinete;

        public int idExamenGabinete
        {
            get { return _idExamenGabinete; }
            set { _idExamenGabinete = value; }
        }

        private string _observaciones;

        public string observaciones
        {
            get { return _observaciones; }
            set { _observaciones = value; }
        }

        private int _idHistoriaClinica;

        public int idHistoriaClinica
        {
            get { return _idHistoriaClinica; }
            set { _idHistoriaClinica = value; }
        }

        private int _idTipoExamen;

        public int idTipoExamen
        {
            get { return _idTipoExamen; }
            set { _idTipoExamen = value; }
        }

        private DateTime _fecha;

        public DateTime fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }

        private string _nombre;

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        
        #endregion
    }
}
