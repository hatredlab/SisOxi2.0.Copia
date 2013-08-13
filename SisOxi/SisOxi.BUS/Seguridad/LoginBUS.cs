using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using SisOxi.DAO;
using SisOxi.VO;
using System.Data;
using System.Reflection;


namespace SisOxi.BUS
{
    public class LoginBUS
    {

        public EmpleadoVO Log(LoginVO logeo, ref bool EsValido)
        {

            DataTable dt = new LoginDAL().Logear(logeo);
            EmpleadoVO empleado = new EmpleadoVO();
            if (dt.Rows.Count > 0)
            {
                EsValido = true;
                foreach (DataRow dr in dt.Rows)
                {
                    empleado.IdEmpleado = Convert.ToInt32(dr["idEmpleado"].ToString());
                    empleado.Dni = dr["dni"].ToString();
                    empleado.Nombres = dr["nombres"].ToString();
                    empleado.Apellidos = dr["apellidos"].ToString();
                }

            }
            return empleado;
        }

    }
}
