using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEmpleadosWF.modelo.excepciones
{
    internal class ExcepcionPersistencia : ExcepcionPersonalizada
    {
        internal ExcepcionPersistencia()
        {
        }

        internal ExcepcionPersistencia(string message) : base(message)
        {
        }

        internal ExcepcionPersistencia(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
