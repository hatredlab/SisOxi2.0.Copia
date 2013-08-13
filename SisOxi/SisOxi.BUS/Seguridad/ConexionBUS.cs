using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisOxi.BUS
{
    public class ConexionBUS
    {
        public List<string> LeerConexion()
        {
            return new SisOxi.DAO.ConexionBD().LeerConexion();
        }

        public void EstablecerConexion(string conexion)
        {
            new SisOxi.DAO.ConexionBD().EstablecerConexion(conexion);
        }
    }
}
