using SisOxi.DAO;
using SisOxi.VO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisOxi.BUS
{
    public class ImpresionDiagnosticaBUS
    {
        public int AgregarImpresionDiagnostica(ImpresionDiagnosticaVO impresionDiagnostica)
        {
            return new ImpresionDiagnosticaDAL().AgregarImpresionDiagnostica(impresionDiagnostica);
        }

        public void ModificarImpresionDiagnostica(ImpresionDiagnosticaVO impresionDiagnostica)
        {
            new ImpresionDiagnosticaDAL().ModificarImpresionDiagnostica(impresionDiagnostica);
        }

        public DataTable BuscarImpresionDiagnosticaPorIDHistoriaClinica(int idHistoriaClinica)
        {
            return new ImpresionDiagnosticaDAL().BuscarImpresionDiagnosticaPorIDHistoriaClinica(idHistoriaClinica);
         
        }

        public DataTable BuscarImpresionDiagnosticaPorIDImpresionDiagnosticaAlterna(int idImpresionDiagnosticaAlterna)
        {
            return new ImpresionDiagnosticaDAL().BuscarImpresionDiagnosticaPorIDImpresionDiagnosticaAlterna(idImpresionDiagnosticaAlterna);

        }

        public int EliminarImpresionDiagnosticaAlterna(int idImpresionDiagnosticaAlterna)
        {
            return new ImpresionDiagnosticaDAL().EliminarImpresionDiagnosticaAlterna(idImpresionDiagnosticaAlterna);
        }
    }
}
