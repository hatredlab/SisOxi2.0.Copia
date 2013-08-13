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
    public class ImpresionDiagnosticaDAL
    {
        private SqlConnection con = new ConexionBD().getConexion();

        public int AgregarImpresionDiagnostica(ImpresionDiagnosticaVO ImpresionDiagnostica)
        {

            con.Open();

            SqlCommand command = new SqlCommand("spr_AgregarImpresionDiagnostica", con);

            command.CommandType = System.Data.CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@observaciones", ImpresionDiagnostica.Observaciones);
            command.Parameters.AddWithValue("@idEnfermedad", ImpresionDiagnostica.IdEnfermedad);
            command.Parameters.AddWithValue("@idHistoriaClinica", ImpresionDiagnostica.IdHistoriaClinica);
            if (ImpresionDiagnostica.idImpresionDiagnosticaAlterna == 0)
            {
                command.Parameters.AddWithValue("@idImpresionDiagnosticaAlterna", DBNull.Value);
            }
            else
            {
                command.Parameters.AddWithValue("@idImpresionDiagnosticaAlterna", ImpresionDiagnostica.idImpresionDiagnosticaAlterna);
            }
            
            int idImpresionDiagnostica = Convert.ToInt32(command.ExecuteScalar());

            con.Close();
            return idImpresionDiagnostica;

        }

        public void ModificarImpresionDiagnostica(ImpresionDiagnosticaVO ImpresionDiagnostica)
        {

            con.Open();

            SqlCommand command = new SqlCommand("spr_ModificarImpresionDiagnostica", con);

            command.CommandType = System.Data.CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@idImpresionDiagnostica", ImpresionDiagnostica.IdImpresionDiagnostica);
            command.Parameters.AddWithValue("@observaciones", ImpresionDiagnostica.Observaciones);
            command.Parameters.AddWithValue("@idEnfermedad", ImpresionDiagnostica.IdEnfermedad);
            command.Parameters.AddWithValue("@idHistoriaClinica", ImpresionDiagnostica.IdHistoriaClinica);
            if (ImpresionDiagnostica.idImpresionDiagnosticaAlterna == 0)
            {
                command.Parameters.AddWithValue("@idImpresionDiagnosticaAlterna", DBNull.Value);
            }
            else
            {
                command.Parameters.AddWithValue("@idImpresionDiagnosticaAlterna", ImpresionDiagnostica.idImpresionDiagnosticaAlterna);
            }
            command.ExecuteNonQuery();

            con.Close();

        }

        public DataTable BuscarImpresionDiagnosticaPorIDHistoriaClinica(int idHistoriaClinica)
        {
            con.Open();
            SqlCommand command = new SqlCommand("spr_BuscarImpresionDiagnosticaPorIDHistoriaClinica", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@idHistoriaClinica", idHistoriaClinica);
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public DataTable BuscarImpresionDiagnosticaPorIDImpresionDiagnosticaAlterna(int idImpresionDiagnosticaAlterna)
        {
            con.Open();
            SqlCommand command = new SqlCommand("spr_BuscarImpresionDiagnosticaPorIDImpresionDiagnosticaAlterna", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@idImpresionDiagnosticaAlterna", idImpresionDiagnosticaAlterna);
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public int EliminarImpresionDiagnosticaAlterna(int idImpresionDiagnosticaAlterna)
        {

            con.Open();

            SqlCommand command = new SqlCommand("spr_EliminarImpresionDiagnosticaAlterna", con);

            command.CommandType = System.Data.CommandType.StoredProcedure;

           
            command.Parameters.AddWithValue("@idImpresionDiagnosticaAlterna", idImpresionDiagnosticaAlterna);
            int idImpresionDiagnostica = Convert.ToInt32(command.ExecuteScalar());

            con.Close();
            return idImpresionDiagnostica;

        }
    }
}
