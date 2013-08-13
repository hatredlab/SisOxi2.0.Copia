using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisOxi.VO
{
    public class TratamientoCamaraHiperbaricaVO : TratamientoVO
    {
        
        #region campos
        
        private int _nroSesiones;

        public int NroSesiones
        {
            get { return _nroSesiones; }
            set { _nroSesiones = value; }
        }

               
        private decimal _promedioOxigeno;

        public decimal PromedioOxigeno
        {
            get { return _promedioOxigeno; }
            set { _promedioOxigeno = value; }
        }

        
        #endregion
    }
}
