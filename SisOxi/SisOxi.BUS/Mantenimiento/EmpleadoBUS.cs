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
   public class EmpleadoBUS
    {
        public int AgregarEmpleado(EmpleadoVO empleado)
        {
            return new EmpleadoDAL().AgregarEmpleado(empleado);
        }

        public void ModificarEmpleado(EmpleadoVO empleado)
        {
            new EmpleadoDAL().Modificar(empleado);
        }

        public DataTable BuscarEmpleado(string apellidos)
        {
            return new EmpleadoDAL().BuscarEmpleado(apellidos);
        }

    }
}
