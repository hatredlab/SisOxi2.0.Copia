using SisOxi.DAO;
using SisOxi.VO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisOxi.BUS
{
    public class DatosClinicosBUS
    {
        public int AgregarDatosClinicos(DatosClinicosVO datosClinicos)
        {
            return new DatosClinicosDAL().AgregarDatosClinicos(datosClinicos);
        }

        public void ModificarDatosClinicos(DatosClinicosVO datosClinicos)
        {
            new DatosClinicosDAL().ModificarDatosClinicos(datosClinicos);
        }
    }
}
