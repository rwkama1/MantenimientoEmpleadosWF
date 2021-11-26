using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEmpleadosWF.modelo.excepciones
{
    internal class ExcepcionLogica : ExcepcionPersonalizada
    {
        internal ExcepcionLogica()
        {
        }

        internal ExcepcionLogica(string message) : base(message)
        {
        }

        internal ExcepcionLogica(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
