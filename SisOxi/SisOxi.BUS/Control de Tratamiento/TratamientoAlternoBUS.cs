using SisOxi.DAO;
using SisOxi.VO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisOxi.BUS
{
    public class TratamientoAlternoBUS : TratamientoBUS
    {
        public override int AgregarTratamiento(TratamientoVO tratamiento)
        {
            return new TratamientoAlternoDAL().AgregarTratamiento(tratamiento);
        }

        public override void ModificarTratamiento(TratamientoVO tratamiento)
        {
            new TratamientoAlternoDAL().ModificarTratamiento(tratamiento);
        }

        public override TratamientoVO BuscarTratamientoPorID(int idTratamiento)
        {
            DataTable dt = new TratamientoAlternoDAL().BuscarTratamientoPorID(idTratamiento);
            TratamientoAlternoVO tratamientoAlterno = new TratamientoAlternoVO();
            foreach (DataRow dr in dt.Rows)
            {
                tratamientoAlterno.IdTratamiento = Convert.ToInt32(dr["idTratamiento"]);
                tratamientoAlterno.EstadoTratamiento = dr["estadoTratamiento"].ToString();
                tratamientoAlterno.ObservacionesTratamiento = dr["observacionesTratamiento"].ToString();
                tratamientoAlterno.idImpresionDiagnostica = Convert.ToInt32(dr["idImpresionDiagnostica"]);
                tratamientoAlterno.TipoTratamiento = dr["tipoTratamiento"].ToString();
                tratamientoAlterno.fechaInicioTratamiento = Convert.ToDateTime(dr["fechaInicioTratamiento"]);
            }
            return tratamientoAlterno;
        }

        public override DataTable BuscarTratamientoPorIDImpresionDiagnostica(int idImpresionDiagnostica)
        {
            return new TratamientoAlternoDAL().BuscarTratamientoPorIDImpresionDiagnostica(idImpresionDiagnostica);
        }
    }
}
