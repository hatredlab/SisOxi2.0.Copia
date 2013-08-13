using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using SisOxi.DAO;
using SisOxi.VO;
using WinFormTelerikDS;

namespace SisOxi.BUS
{
    public class HistoriaClinicaBUS
    {
        public DataTable BuscarHistoriaClinica(string busqueda)
        {
            return new HistoriaClinicaDAL().BuscarHistoriaClinica(busqueda);
        }

        public int AgregarHistoriaClinica(HistoriaClinicaVO historiaClinica)
        {
           int idHistoriaClinica = new HistoriaClinicaDAL().AgregarHistoriaClinica(historiaClinica);
           return idHistoriaClinica;
        }

        public void ModificarHistoriaClinica(HistoriaClinicaVO historiaClinica)
        {
            new HistoriaClinicaDAL().ModificarHistoriaClinica(historiaClinica);
        }

        public HistoriaClinicaVO BuscarHistoriaClinicaPorID(int idHistoriaClinica)
        {
            DataTable dt = new HistoriaClinicaDAL().BuscarHistoriaClinicaPorID(idHistoriaClinica);
            HistoriaClinicaVO historia = new HistoriaClinicaVO();
            foreach(DataRow dr in dt.Rows)
            {
                historia=Clases.LlenarObjetoConRegistroDataRow<HistoriaClinicaVO>(dr);
            }
            return historia;
        }

    }
}
