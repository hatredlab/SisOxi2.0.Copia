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
    public class EnfermedadBUS
    {
        public int AgregarEnfermedad(EnfermedadVO enfermedad)
        {
            return new EnfermedadDAL().AgregarEnfermedad(enfermedad);
        }

        public void ModificarEnfermedad(EnfermedadVO enfermedad)
        {
            new EnfermedadDAL().ModificarEnfermedad(enfermedad);
        }

        public DataTable BuscarEnfermedad(DataTable dt )
        {
            return new EnfermedadDAL().BuscarEnfermedad(dt);
        }

        public DataTable BuscarEnfermedad()
        {
            return new EnfermedadDAL().BuscarEnfermedad();
        }

        public DataTable BuscarEnfermedadAsociada(DataTable dt)
        {
            return new EnfermedadDAL().BuscarEnfermedadAsociada(dt);
        }

        public DataTable BuscarEnfermedadAsociada()
        {
            return new EnfermedadDAL().BuscarEnfermedadAsociada();
        }

        public EnfermedadVO BuscarEnfermedadPorID(int idEnfermedad)
        {
            DataTable dt = new EnfermedadDAL().BuscarEnfermedadPorID(idEnfermedad);
            EnfermedadVO enfermedad = new EnfermedadVO();
            foreach (DataRow dr in dt.Rows)
            {
                enfermedad.IdEnfermedad = Convert.ToInt32(dr["idEnfermedad"]);
                enfermedad.Nombre = dr["nombre"].ToString();
                enfermedad.Descripcion = dr["descripcion"].ToString();
                enfermedad.Tipo = dr["tipo"].ToString();
            }
            return enfermedad;
        }

        public DataTable ReporteEnfermedadesPorRangoEdadesII()
        {
            return new EnfermedadDAL().ReporteEnfermedadesPorRangoEdadesII();
        }
    }
}
