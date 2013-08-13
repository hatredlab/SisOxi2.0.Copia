using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SisOxi.VO;
using System.Data;
using System.Data.SqlClient;

namespace SisOxi.DAO
{
    public class EmpleadoDAL
    {
        private SqlConnection con = new ConexionBD().getConexion();

        public int AgregarEmpleado(EmpleadoVO Empleado)
        {

            con.Open();

            SqlCommand command = new SqlCommand("spr_AgregarEmpleado", con);

            command.CommandType = System.Data.CommandType.StoredProcedure;

          
            command.Parameters.AddWithValue("@nombres", Empleado.Nombres);
            command.Parameters.AddWithValue("@apellidos", Empleado.Apellidos);
            command.Parameters.AddWithValue("@direccionDomiciliaria", Empleado.DireccionDomiciliaria);
            command.Parameters.AddWithValue("@fono", Empleado.Fono);
            command.Parameters.AddWithValue("@clave", Empleado.Clave);
            command.Parameters.AddWithValue("@cargo", Empleado.Cargo);
            command.Parameters.AddWithValue("@dni", Empleado.Dni);

            int idPersona = Convert.ToInt32(command.ExecuteScalar());

            con.Close();
            return idPersona;

        }

        public void Modificar(EmpleadoVO Empleado)
        {

            con.Open();

            SqlCommand command = new SqlCommand("spr_ModificarEmpleado", con);

            command.CommandType = System.Data.CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@idEmpleado", Empleado.IdEmpleado);
            command.Parameters.AddWithValue("@nombres", Empleado.Nombres);
            command.Parameters.AddWithValue("@apellidos", Empleado.Apellidos);
            command.Parameters.AddWithValue("@direccionDomiciliaria", Empleado.DireccionDomiciliaria);
            command.Parameters.AddWithValue("@fono", Empleado.Fono);
            command.Parameters.AddWithValue("@clave", Empleado.Clave);
            command.Parameters.AddWithValue("@cargo", Empleado.Cargo);
            command.Parameters.AddWithValue("@dni", Empleado.Dni);

            command.ExecuteNonQuery();

            con.Close();

        }


        public DataTable BuscarEmpleado(string apellidos)
        {

            con.Open();

            SqlCommand command = new SqlCommand("spr_BuscarEmpleado", con);

            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@apellidos", apellidos);
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }

      
    }
}
