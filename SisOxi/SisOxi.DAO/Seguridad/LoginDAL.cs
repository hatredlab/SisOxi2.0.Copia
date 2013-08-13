using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using SisOxi.VO;
using System.Data;

namespace SisOxi.DAO
{
    public class LoginDAL
    {
        private SqlConnection con = new ConexionBD().getConexion();

        public DataTable Logear(LoginVO login)
        {

            con.Open();

            SqlCommand command = new SqlCommand("spr_LogeoSistema", con);

            command.CommandType = System.Data.CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@NOMBREUSUARIO", login.nombres);
            command.Parameters.AddWithValue("@CLAVEUSUARIO", login.clave);
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
       
        }
    }
}





