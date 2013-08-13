    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using SisOxi.VO;

namespace SisOxi.DAO
{
    public class HistoriaClinicaDAL
    {
        private SqlConnection con = new ConexionBD().getConexion();
        
        public int AgregarHistoriaClinica(HistoriaClinicaVO HistoriaClinica)
        {

            con.Open();

            SqlCommand command = new SqlCommand("spr_AgregarHistoriaClinica", con);

            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@nombres", HistoriaClinica.nombres);
            command.Parameters.AddWithValue("@apellidoPaterno", HistoriaClinica.apellidoPaterno);
            command.Parameters.AddWithValue("@codigoHistoriaClinica", HistoriaClinica.codigoHistoriaClinica);
            command.Parameters.AddWithValue("@apellidoMaterno", HistoriaClinica.apellidoMaterno);
            command.Parameters.AddWithValue("@documentoIdentidad", HistoriaClinica.documentoIdentidad);
            command.Parameters.AddWithValue("@estadoCivil", HistoriaClinica.estadoCivil);
            command.Parameters.AddWithValue("@edad", HistoriaClinica.edad);
            command.Parameters.AddWithValue("@sexo", HistoriaClinica.sexo);
            command.Parameters.AddWithValue("@profesion", HistoriaClinica.profesion);
            command.Parameters.AddWithValue("@fechaNacimiento", HistoriaClinica.fechaNacimiento);
            command.Parameters.AddWithValue("@lugarNacimiento", HistoriaClinica.lugarNacimiento);
            command.Parameters.AddWithValue("@provincia", HistoriaClinica.provincia);
            command.Parameters.AddWithValue("@ocupacion", HistoriaClinica.ocupacion);
            command.Parameters.AddWithValue("@centroTrabajo", HistoriaClinica.centroTrabajo);
            command.Parameters.AddWithValue("@direccionDomiciliaria", HistoriaClinica.direccionDomiciliaria);
            command.Parameters.AddWithValue("@fono", HistoriaClinica.fono);
            command.Parameters.AddWithValue("@diistritoDomicilio", HistoriaClinica.diistritoDomicilio);
            command.Parameters.AddWithValue("@provinciaDomicilio", HistoriaClinica.provinciaDomicilio);
            command.Parameters.AddWithValue("@nombreContacto", HistoriaClinica.nombreContacto);
            command.Parameters.AddWithValue("@parentescoContacto", HistoriaClinica.parentescoContacto);
            command.Parameters.AddWithValue("@domicilioContacto", HistoriaClinica.domicilioContacto);
            command.Parameters.AddWithValue("@fonoContacto", HistoriaClinica.fonoContacto);
            command.Parameters.AddWithValue("@grupoEtnico", HistoriaClinica.grupoEtnico);
            command.Parameters.AddWithValue("@nacionalidad", HistoriaClinica.nacionalidad);
            command.Parameters.AddWithValue("@departamentoDomicilio", HistoriaClinica.departamentoDomicilio);
            command.Parameters.AddWithValue("@apellidosContacto", HistoriaClinica.apellidosContacto);

            int idHistoriaClinica = Convert.ToInt32(command.ExecuteScalar());
            con.Close();
            return idHistoriaClinica;

        }

        public void ModificarHistoriaClinica(HistoriaClinicaVO HistoriaClinica)
        {

            con.Open();

            SqlCommand command = new SqlCommand("spr_ModificarHistoriaClinica", con);

            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@idHistoriaClinica", HistoriaClinica.idHistoriaClinica);
            command.Parameters.AddWithValue("@nombres", HistoriaClinica.nombres);
            command.Parameters.AddWithValue("@apellidoPaterno", HistoriaClinica.apellidoPaterno);
            command.Parameters.AddWithValue("@codigoHistoriaClinica", HistoriaClinica.codigoHistoriaClinica);
            command.Parameters.AddWithValue("@apellidoMaterno", HistoriaClinica.apellidoMaterno);
            command.Parameters.AddWithValue("@documentoIdentidad", HistoriaClinica.documentoIdentidad);
            command.Parameters.AddWithValue("@estadoCivil", HistoriaClinica.estadoCivil);
            command.Parameters.AddWithValue("@edad", HistoriaClinica.edad);
            command.Parameters.AddWithValue("@sexo", HistoriaClinica.sexo);
            command.Parameters.AddWithValue("@profesion", HistoriaClinica.profesion);
            command.Parameters.AddWithValue("@fechaNacimiento", HistoriaClinica.fechaNacimiento);
            command.Parameters.AddWithValue("@lugarNacimiento", HistoriaClinica.lugarNacimiento);
            command.Parameters.AddWithValue("@provincia", HistoriaClinica.provincia);
            command.Parameters.AddWithValue("@ocupacion", HistoriaClinica.ocupacion);
            command.Parameters.AddWithValue("@centroTrabajo", HistoriaClinica.centroTrabajo);
            command.Parameters.AddWithValue("@direccionDomiciliaria", HistoriaClinica.direccionDomiciliaria);
            command.Parameters.AddWithValue("@fono", HistoriaClinica.fono);
            command.Parameters.AddWithValue("@diistritoDomicilio", HistoriaClinica.diistritoDomicilio);
            command.Parameters.AddWithValue("@provinciaDomicilio", HistoriaClinica.provinciaDomicilio);
            command.Parameters.AddWithValue("@nombreContacto", HistoriaClinica.nombreContacto);
            command.Parameters.AddWithValue("@parentescoContacto", HistoriaClinica.parentescoContacto);
            command.Parameters.AddWithValue("@domicilioContacto", HistoriaClinica.domicilioContacto);
            command.Parameters.AddWithValue("@fonoContacto", HistoriaClinica.fonoContacto);
            command.Parameters.AddWithValue("@grupoEtnico", HistoriaClinica.grupoEtnico);
            command.Parameters.AddWithValue("@nacionalidad", HistoriaClinica.nacionalidad);
            command.Parameters.AddWithValue("@departamentoDomicilio", HistoriaClinica.departamentoDomicilio);
            command.Parameters.AddWithValue("@apellidosContacto", HistoriaClinica.apellidosContacto);

            command.ExecuteNonQuery();

            con.Close();

        }


        public DataTable BuscarHistoriaClinica(string busqueda)
        {
            con.Open();
            SqlCommand command = new SqlCommand("spr_BuscarHistoriaClinica", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@busqueda", busqueda);
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public DataTable BuscarHistoriaClinicaPorID(int idHistoriaClinica)
        {
            con.Open();
            SqlCommand command = new SqlCommand("spr_BuscarHistoriaClinicaPorID", con);
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
