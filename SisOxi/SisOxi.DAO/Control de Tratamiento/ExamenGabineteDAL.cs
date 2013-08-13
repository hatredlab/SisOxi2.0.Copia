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
    public class ExamenGabineteDAL
    {
        private SqlConnection con = new ConexionBD().getConexion();

        public int AgregarExamenGabinete(ExamenGabineteVO ExamenGabinete)
        {

            con.Open();

            SqlCommand command = new SqlCommand("spr_AgregarExamenGabinete", con);

            command.CommandType = System.Data.CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@observaciones", ExamenGabinete.observaciones);
            command.Parameters.AddWithValue("@idHistoriaClinica", ExamenGabinete.idHistoriaClinica);
            command.Parameters.AddWithValue("@idTipoExamen", ExamenGabinete.idTipoExamen);
            command.Parameters.AddWithValue("@fecha", ExamenGabinete.fecha);

            int idExamenGabinete = Convert.ToInt32(command.ExecuteScalar());

            con.Close();
            return idExamenGabinete;

        }

        public void ModificarExamenGabinete(ExamenGabineteVO ExamenGabinete)
        {

            con.Open();

            SqlCommand command = new SqlCommand("spr_ModificarExamenGabinete", con);

            command.CommandType = System.Data.CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@idExamenGabinete", ExamenGabinete.idExamenGabinete);
            command.Parameters.AddWithValue("@observaciones", ExamenGabinete.observaciones);
            command.Parameters.AddWithValue("@idHistoriaClinica", ExamenGabinete.idHistoriaClinica);
            command.Parameters.AddWithValue("@idTipoExamen", ExamenGabinete.idTipoExamen);
            command.Parameters.AddWithValue("@fecha", ExamenGabinete.fecha);

            command.ExecuteNonQuery();

            con.Close();

        }

        public DataTable BuscarExamen()
        {

            con.Open();

            SqlCommand command = new SqlCommand("spr_BuscarExamen", con);

            command.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public DataTable BuscarExamenPorID(int idExamenGabinete)
        {
            con.Open();

            SqlCommand command = new SqlCommand("spr_BuscarExamenPorID", con);

            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@idExamenGabinete", idExamenGabinete);
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        
         public DataTable BuscarExamenDeGabinetePorIDHistoriaClinica(int idHistoriaClinica)
        {
            con.Open();
            SqlCommand command = new SqlCommand("spr_BuscarExamenDeGabinetePorIDHistoriaClinica", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@idHistoriaClinica", idHistoriaClinica);
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
    }
}
