using SisOxi.VO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisOxi.BUS
{
    abstract public class TratamientoBUS
    {
        public abstract int AgregarTratamiento(TratamientoVO tratamiento);
        public abstract void ModificarTratamiento(TratamientoVO tratamiento);
        public abstract TratamientoVO BuscarTratamientoPorID(int idTratamiento);
        public abstract DataTable BuscarTratamientoPorIDImpresionDiagnostica(int idHistoriaClinica);
    }
}
