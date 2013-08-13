using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisOxi.VO
{
    public class DatosClinicosVO
    {
        #region campos
        private int _idDatosClinicos;

        public int idDatosClinicos
        {
            get { return _idDatosClinicos; }
            set { _idDatosClinicos = value; }
        }

        private string _enfermedadActual;

        public string enfermedadActual
        {
            get { return _enfermedadActual; }
            set { _enfermedadActual = value; }
        }

        private string _antecedenteFamiliares;

        public string antecedenteFamiliares
        {
            get { return _antecedenteFamiliares; }
            set { _antecedenteFamiliares = value; }
        }

        private string _antecedentesPatologicos;

        public string antecedentesPatologicos
        {
            get { return _antecedentesPatologicos; }
            set { _antecedentesPatologicos = value; }
        }

        private string _FC;

        public string FC
        {
            get { return _FC; }
            set { _FC = value; }
        }

        private string _T;

        public string T
        {
            get { return _T; }
            set { _T = value; }
        }

        private string _PA;

        public string PA
        {
            get { return _PA; }
            set { _PA = value; }
        }

        private string _peso;

        public string peso
        {
            get { return _peso; }
            set { _peso = value; }
        }

        private string _talla;

        public string talla
        {
            get { return _talla; }
            set { _talla = value; }
        }

        private string _observacionesFisicas;

        public string observacionesFisicas
        {
            get { return _observacionesFisicas; }
            set { _observacionesFisicas = value; }
        }

        private string _examenesDeLaboratorio;

        public string examenesDeLaboratorio
        {
            get { return _examenesDeLaboratorio; }
            set { _examenesDeLaboratorio = value; }
        }

        private int _idHistoriaClinica;

        public int idHistoriaClinica
        {
            get { return _idHistoriaClinica; }
            set { _idHistoriaClinica = value; }
        }
        #endregion
    }
}
