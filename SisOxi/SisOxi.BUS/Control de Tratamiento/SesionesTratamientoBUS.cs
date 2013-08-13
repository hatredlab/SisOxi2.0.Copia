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
    public class SesionesTratamientoBUS
    {
        public int AgregarSesionesTratamiento(SesionesTratamientoVO SesionesTratamiento)
        {
            return new SesionesTratamientoDAL().AgregarSesionesTratamiento(SesionesTratamiento);
        }

        public void ModificarSesionesTratamiento(SesionesTratamientoVO SesionesTratamiento)
        {
            new SesionesTratamientoDAL().ModificarSesionesTratamiento(SesionesTratamiento);
            
        }

        public DataTable BuscarSesionesPorTratamiento(int idTratamientoCamaraHiperbarica)
        {
            return new SesionesTratamientoDAL().BuscarSesionesPorTratamiento(idTratamientoCamaraHiperbarica);
        }
    }
}
