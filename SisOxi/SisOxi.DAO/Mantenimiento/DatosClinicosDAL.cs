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
    public class DatosClinicosDAL
    {
        private SqlConnection con = new ConexionBD().getConexion();

        public int AgregarDatosClinicos(DatosClinicosVO DatosClinicos)
        {

            con.Open();

            SqlCommand command = new SqlCommand("spr_AgregarDatosClinicos", con);

            command.CommandType = System.Data.CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@enfermedadActual", DatosClinicos.enfermedadActual);
            command.Parameters.AddWithValue("@antecedenteFamiliares", DatosClinicos.antecedenteFamiliares);
            command.Parameters.AddWithValue("@antecedentesPatologicos", DatosClinicos.antecedentesPatologicos);
            command.Parameters.AddWithValue("@FC", DatosClinicos.FC);
            command.Parameters.AddWithValue("@T", DatosClinicos.T);
            command.Parameters.AddWithValue("@PA", DatosClinicos.PA);
            command.Parameters.AddWithValue("@peso", DatosClinicos.peso);
            command.Parameters.AddWithValue("@talla", DatosClinicos.talla);
            command.Parameters.AddWithValue("@observacionesFisicas", DatosClinicos.observacionesFisicas);
            command.Parameters.AddWithValue("@examenesDeLaboratorio", DatosClinicos.examenesDeLaboratorio);
            command.Parameters.AddWithValue("@idHistoriaClinica", DatosClinicos.idHistoriaClinica);

            int idDatosClinicos = Convert.ToInt32(command.ExecuteScalar());

            con.Close();

            return idDatosClinicos;

        }

        public void ModificarDatosClinicos(DatosClinicosVO DatosClinicos)
        {

            con.Open();

            SqlCommand command = new SqlCommand("spr_ModificarDatosClinicos", con);

            command.CommandType = System.Data.CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@idDatosClinicos", DatosClinicos.idDatosClinicos);
            command.Parameters.AddWithValue("@enfermedadActual", DatosClinicos.enfermedadActual);
            command.Parameters.AddWithValue("@antecedenteFamiliares", DatosClinicos.antecedenteFamiliares);
            command.Parameters.AddWithValue("@antecedentesPatologicos", DatosClinicos.antecedentesPatologicos);
            command.Parameters.AddWithValue("@FC", DatosClinicos.FC);
            command.Parameters.AddWithValue("@T", DatosClinicos.T);
            command.Parameters.AddWithValue("@PA", DatosClinicos.PA);
            command.Parameters.AddWithValue("@peso", DatosClinicos.peso);
            command.Parameters.AddWithValue("@talla", DatosClinicos.talla);
            command.Parameters.AddWithValue("@observacionesFisicas", DatosClinicos.observacionesFisicas);
            command.Parameters.AddWithValue("@examenesDeLaboratorio", DatosClinicos.examenesDeLaboratorio);
            command.Parameters.AddWithValue("@idHistoriaClinica", DatosClinicos.idHistoriaClinica);

            command.ExecuteNonQuery();

            con.Close();

        }

    }
}
