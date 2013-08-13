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
    public class TipoExamenDAL
    {
        private SqlConnection con = new ConexionBD().getConexion();

        public int AgregarTipoExamen(TipoExamenVO TipoExamen)
        {

            con.Open();

            SqlCommand command = new SqlCommand("spr_AgregarTipoExamen", con);

            command.CommandType = System.Data.CommandType.StoredProcedure;

           
            command.Parameters.AddWithValue("@nombre", TipoExamen.nombre);
            command.Parameters.AddWithValue("@descripcion", TipoExamen.descripcion);

            int idTipoExamen = Convert.ToInt32(command.ExecuteScalar());

            con.Close();
            return idTipoExamen;

        }

        public void ModificarTipoExamen(TipoExamenVO TipoExamen)
        {

            con.Open();

            SqlCommand command = new SqlCommand("spr_ModificarTipoExamen", con);

            command.CommandType = System.Data.CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@idTipoExamen", TipoExamen.idTipoExamen);
            command.Parameters.AddWithValue("@nombre", TipoExamen.nombre);
            command.Parameters.AddWithValue("@descripcion", TipoExamen.descripcion);

            command.ExecuteNonQuery();

            con.Close();

        }

        public DataTable BuscarTipoExamen()
        {

            con.Open();

            SqlCommand command = new SqlCommand("spr_BuscarTipoExamen", con);

            command.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public DataTable BuscarTipoExamenPorID(int idTipoExamen)
        {
            con.Open();

            SqlCommand command = new SqlCommand("spr_BuscarTipoExamenPorID", con);

            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@idTipoExamen", idTipoExamen);
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }

    }
}
