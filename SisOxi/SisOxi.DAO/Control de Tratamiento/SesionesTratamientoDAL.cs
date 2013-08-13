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
    public class SesionesTratamientoDAL
    {
        private SqlConnection con = new ConexionBD().getConexion();

        public int AgregarSesionesTratamiento(SesionesTratamientoVO SesionesTratamiento)
        {

            con.Open();

            SqlCommand command = new SqlCommand("spr_AgregarSesionesTratamiento", con);

            command.CommandType = System.Data.CommandType.StoredProcedure;

            
            command.Parameters.AddWithValue("@fechaSesion", SesionesTratamiento.fechaSesion);
            command.Parameters.AddWithValue("@consumoOxigeno", SesionesTratamiento.consumoOxigeno);
            command.Parameters.AddWithValue("@notasTender", SesionesTratamiento.notasTender);
            command.Parameters.AddWithValue("@idTratamiento", SesionesTratamiento.idTratamiento);
            command.Parameters.AddWithValue("@idEmpleado", SesionesTratamiento.idEmpleado);
            
            command.Parameters.AddWithValue("@protocolo", SesionesTratamiento.protocolo);
            int idSesionTratamiento = Convert.ToInt32(command.ExecuteScalar());

            con.Close();
            return idSesionTratamiento;

        }

        public void ModificarSesionesTratamiento(SesionesTratamientoVO SesionesTratamiento)
        {

            con.Open();

            SqlCommand command = new SqlCommand("spr_ModificarSesionesTratamiento", con);

            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@idSesionTratamiento", SesionesTratamiento.idSesionTratamiento);
            command.Parameters.AddWithValue("@fechaSesion", SesionesTratamiento.fechaSesion);
            command.Parameters.AddWithValue("@consumoOxigeno", SesionesTratamiento.consumoOxigeno);
            command.Parameters.AddWithValue("@notasTender", SesionesTratamiento.notasTender);
            command.Parameters.AddWithValue("@idTratamiento", SesionesTratamiento.idTratamiento);
            command.Parameters.AddWithValue("@idEmpleado", SesionesTratamiento.idEmpleado);

            command.Parameters.AddWithValue("@protocolo", SesionesTratamiento.protocolo);
            command.ExecuteNonQuery();

            con.Close();

        }

        public DataTable BuscarSesionesPorTratamiento(int idTratamientoCamaraHiperbarica)
        {
            con.Open();

            SqlCommand command = new SqlCommand("spr_SeleccionarSesionesPorTratamiento", con);

            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@idTratamiento", idTratamientoCamaraHiperbarica);
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
    }
}
