using SisOxi.DAO;
using SisOxi.VO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormTelerikDS;

namespace SisOxi.BUS
{
    public class TratamientoCamaraHiperbaricaBUS : TratamientoBUS
    {
        public override int AgregarTratamiento(TratamientoVO tratamiento)
        {
            return new TratamientoCamaraHiperbaricaDAL().AgregarTratamiento(tratamiento);
        }

        public override void ModificarTratamiento(TratamientoVO tratamiento)
        {
            new TratamientoCamaraHiperbaricaDAL().ModificarTratamiento(tratamiento);
        }

        public override TratamientoVO BuscarTratamientoPorID(int idTratamiento)
        {
            DataTable dt = new TratamientoCamaraHiperbaricaDAL().BuscarTratamientoPorID(idTratamiento);
            TratamientoCamaraHiperbaricaVO tratamientoCamaraHiperbarica = new TratamientoCamaraHiperbaricaVO();
            foreach (DataRow dr in dt.Rows)
            {
                
               tratamientoCamaraHiperbarica = Clases.LlenarObjetoConRegistroDataRow<TratamientoCamaraHiperbaricaVO>(dr);
            }
            return tratamientoCamaraHiperbarica;
        }

        public override DataTable BuscarTratamientoPorIDImpresionDiagnostica(int idHistoriaClinica)
        {
            return new TratamientoCamaraHiperbaricaDAL().BuscarTratamientoPorIDImpresionDiagnostica(idHistoriaClinica);
        }
    }
}
