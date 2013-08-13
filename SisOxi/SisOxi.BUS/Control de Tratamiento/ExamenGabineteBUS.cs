using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using SisOxi.VO;
using SisOxi.DAO;

namespace SisOxi.BUS
{
    public class ExamenGabineteBUS
    {
        public int AgregarExamen(ExamenGabineteVO examen)
        {
            return new ExamenGabineteDAL().AgregarExamenGabinete(examen);
        }

        public void ModificarExamen(ExamenGabineteVO examen)
        {
            new ExamenGabineteDAL().ModificarExamenGabinete(examen);
        }

        public DataTable BuscarExamen()
        {
            return new ExamenGabineteDAL().BuscarExamen();
        }

        public DataTable BuscarExamenDeGabinetePorIDHistoriaClinica(int idHistoriaClinica)
        {
            return new ExamenGabineteDAL().BuscarExamenDeGabinetePorIDHistoriaClinica(idHistoriaClinica);

        }
    }
}
