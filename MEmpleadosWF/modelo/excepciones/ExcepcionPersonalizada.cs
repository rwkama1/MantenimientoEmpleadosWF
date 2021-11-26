using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEmpleadosWF.modelo.excepciones
{
    internal class ExcepcionPersonalizada : Exception
    {
        internal ExcepcionPersonalizada()
        {
        }

        internal ExcepcionPersonalizada(string message) : base(message)
        {
            
        }

        internal ExcepcionPersonalizada(string message, Exception innerException) : base(message, innerException) 
        {

        }
    }
}
