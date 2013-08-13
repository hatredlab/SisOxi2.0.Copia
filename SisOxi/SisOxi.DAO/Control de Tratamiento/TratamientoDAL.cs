using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SisOxi.VO;
using System.Data;
using System.Data.SqlClient;

namespace SisOxi.DAO
{
    public abstract class TratamientoDAO
    {
        protected SqlConnection con = new ConexionBD().getConexion();

        public abstract int AgregarTratamiento(TratamientoVO tratamiento);
        public abstract void ModificarTratamiento(TratamientoVO tratamiento);
        public abstract DataTable BuscarTratamientoPorID(int idTratamiento);
        public abstract DataTable BuscarTratamientoPorIDImpresionDiagnostica(int idImpresionDiagnostica);
        
    }
}
