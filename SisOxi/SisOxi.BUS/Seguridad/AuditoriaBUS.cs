using SisOxi.DAO.Seguridad;
using SisOxi.VO.Seguridad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisOxi.BUS.Seguridad
{
    public class AuditoriaBUS
    {
        public void AgregarAuditoria(AuditoriaVO auditoria)
        {
            new AuditoriaDAL().AgregarAuditoria(auditoria);
        }
    }
}
