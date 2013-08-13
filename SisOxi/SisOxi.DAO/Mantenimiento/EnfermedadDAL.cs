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
    public class EnfermedadDAL
    {
        private SqlConnection con = new ConexionBD().getConexion();

        public int AgregarEnfermedad(EnfermedadVO Enfermedad)
        {

            con.Open();

            SqlCommand command = new SqlCommand("spr_AgregarEnfermedad", con);

            command.CommandType = System.Data.CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@nombre", Enfermedad.Nombre);
            command.Parameters.AddWithValue("@descripcion", Enfermedad.Descripcion);
            command.Parameters.AddWithValue("@tipo", Enfermedad.Tipo);
            int idEnfermedad = Convert.ToInt32(command.ExecuteScalar());

            con.Close();
            return idEnfermedad;

        }

        public void ModificarEnfermedad(EnfermedadVO Enfermedad)
        {

            con.Open();

            SqlCommand command = new SqlCommand("spr_ModificarEnfermedad", con);

            command.CommandType = System.Data.CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@idEnfermedad", Enfermedad.IdEnfermedad);
            command.Parameters.AddWithValue("@nombre", Enfermedad.Nombre);
            command.Parameters.AddWithValue("@descripcion", Enfermedad.Descripcion);
            command.Parameters.AddWithValue("@tipo", Enfermedad.Tipo);
            command.ExecuteNonQuery();

            con.Close();

        }

        public DataTable BuscarEnfermedad(DataTable dtt)
        {

            con.Open();

            SqlCommand command = new SqlCommand("spr_BuscarEnfermedadHistoria", con);
            

            command.CommandType = System.Data.CommandType.StoredProcedure;
            
            command.Parameters.AddWithValue("@enfermedad", dtt);
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public DataTable BuscarEnfermedad()
        {

            con.Open();

            SqlCommand command = new SqlCommand("spr_BuscarEnfermedad", con);

            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public DataTable BuscarEnfermedadAsociada(DataTable dtt)
        {

            con.Open();

            SqlCommand command = new SqlCommand("spr_BuscarEnfermedadHistoriaAsociada", con);


            command.CommandType = System.Data.CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@enfermedad", dtt);
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public DataTable BuscarEnfermedadAsociada()
        {

            con.Open();

            SqlCommand command = new SqlCommand("spr_BuscarEnfermedadAsociada", con);

            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public DataTable BuscarEnfermedadPorID(int idEnfermedad)
        {
            con.Open();

            SqlCommand command = new SqlCommand("spr_BuscarEnfermedadPorID", con);

            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("idEnfermedad", idEnfermedad);
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public DataTable ReporteEnfermedadesPorRangoEdadesII()
        {
            con.Open();

            SqlCommand command = new SqlCommand("spr_ReporteEnfermedadesPorRangoEdadesII", con);

            command.CommandType = System.Data.CommandType.StoredProcedure;
    
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }

        
    }
}
