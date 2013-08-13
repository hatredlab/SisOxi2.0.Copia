using SisOxi.VO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisOxi.DAO
{
    public class TratamientoAlternoDAL : TratamientoDAO
    {
        public override int AgregarTratamiento(TratamientoVO tratamiento)
        {
            con.Open();

            SqlCommand command = new SqlCommand("spr_AgregarTratamientoAlterno", con);

            command.CommandType = System.Data.CommandType.StoredProcedure;
            TratamientoAlternoVO claseVO = (TratamientoAlternoVO)tratamiento;
            command.Parameters.AddWithValue("@estadoTratamiento", claseVO.EstadoTratamiento);
            command.Parameters.AddWithValue("@observacionesTratamiento", claseVO.ObservacionesTratamiento);
            command.Parameters.AddWithValue("@idImpresionDiagnostica", claseVO.idImpresionDiagnostica);
            command.Parameters.AddWithValue("@tipoTratamiento", claseVO.TipoTratamiento);
            command.Parameters.AddWithValue("@fechaInicioTratamiento", claseVO.fechaInicioTratamiento);

            int idTratamiento = Convert.ToInt32(command.ExecuteScalar());

            con.Close();
            return idTratamiento;
        }

        public override void ModificarTratamiento(TratamientoVO tratamiento)
        {
            con.Open();

            SqlCommand command = new SqlCommand("spr_ModificarTratamientoAlterno", con);

            command.CommandType = System.Data.CommandType.StoredProcedure;
            TratamientoAlternoVO claseVO = (TratamientoAlternoVO)tratamiento;
            command.Parameters.AddWithValue("@idTratamiento", claseVO.IdTratamiento);
            command.Parameters.AddWithValue("@estadoTratamiento", claseVO.EstadoTratamiento);
            command.Parameters.AddWithValue("@observacionesTratamiento", claseVO.ObservacionesTratamiento);
            command.Parameters.AddWithValue("@idImpresionDiagnostica", claseVO.idImpresionDiagnostica);
            command.Parameters.AddWithValue("@tipoTratamiento", claseVO.TipoTratamiento);
            command.Parameters.AddWithValue("@fechaInicioTratamiento", claseVO.fechaInicioTratamiento);

            command.ExecuteNonQuery();

            con.Close();
        }

        public override DataTable BuscarTratamientoPorID(int idTratamiento)
        {
            con.Open();
            SqlCommand command = new SqlCommand("spr_BuscarTratamientoPorID", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@idTratamiento", idTratamiento);
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public override DataTable BuscarTratamientoPorIDImpresionDiagnostica(int idImpresionDiagnostica)
        {
            con.Open();
            SqlCommand command = new SqlCommand("spr_BuscarTratamientoPorIDImpresionDiagnostica", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@idImpresionDiagnostica", idImpresionDiagnostica);
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
    }
}
