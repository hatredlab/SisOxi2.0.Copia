using SisOxi.VO.Seguridad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisOxi.DAO.Seguridad
{
    public class AuditoriaDAL
    {
        private SqlConnection con = new ConexionBD().getConexion();

        public void AgregarAuditoria(AuditoriaVO Auditoria)

        {

            con.Open();

            SqlCommand command = new SqlCommand("spr_AgregarAuditoria",con);

            command.CommandType = System.Data.CommandType.StoredProcedure;

            command.Parameters.AddWithValue( "@idEmpleado", Auditoria.idEmpleado );
            command.Parameters.AddWithValue( "@idRegistro", Auditoria.idRegistro );
            command.Parameters.AddWithValue( "@tipo", Auditoria.tipo );
            command.Parameters.AddWithValue( "@tabla", Auditoria.tabla );
            command.Parameters.AddWithValue( "@fecha", Auditoria.fecha );

            command.ExecuteNonQuery();

            con.Close();

        }

    }
}
