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
    public class TipoExamenBUS
    {
        public int AgregarTipoExamen(TipoExamenVO tipoExamen)
        {
            return new TipoExamenDAL().AgregarTipoExamen(tipoExamen);
        }

        public void ModificarTipoExamen(TipoExamenVO tipoExamen)
        {
            new TipoExamenDAL().ModificarTipoExamen(tipoExamen);
        }

        public DataTable BuscarTipoExamen()
        {
            return new TipoExamenDAL().BuscarTipoExamen();
        }

        public TipoExamenVO BuscarTipoExamenPorID(int idTipoExamen)
        {
            DataTable dt = new TipoExamenDAL().BuscarTipoExamenPorID(idTipoExamen);
            TipoExamenVO tipoExamen = new TipoExamenVO();
            foreach (DataRow dr in dt.Rows)
            {
                tipoExamen.idTipoExamen = Convert.ToInt32(dr["idTipoExamen"]);
                tipoExamen.nombre = dr["nombre"].ToString();
                tipoExamen.descripcion = dr["descripcion"].ToString();
            }
            return tipoExamen;
        }
    }
}
