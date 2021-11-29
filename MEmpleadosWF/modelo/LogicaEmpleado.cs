using MEmpleadosWF.modelo.excepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEmpleadosWF.modelo
{
    internal class LogicaEmpleado
    {
        private static LogicaEmpleado _instancia = null;
        private LogicaEmpleado() { }
        public static LogicaEmpleado GetInstancia()
        {
            if (_instancia == null)
                _instancia = new LogicaEmpleado();
            return _instancia;
        }

        //**********************************************

        internal List<Empleado> listarEmpleados()
        {
            List<Empleado> listEmpleados = DataEmpleado.GetInstancia().listarEmpleados();
            return listEmpleados;

        }
        internal List<Empleado> listarEmpleadosSinBaja()
        {
            List<Empleado> empleados_sin_baja = new List<Empleado>();
            List<Empleado> listEmpleados = DataEmpleado.GetInstancia().listarEmpleados();
            foreach (Empleado em in listEmpleados)
            {
                if (em.Bajalogica == false)
                {
                    empleados_sin_baja.Add(em);
                }
            }
            return empleados_sin_baja;
        }
        internal Empleado buscarEmpleado(short codigo)
        {
            Empleado empleado = null;
            List<Empleado> listEmpleados = DataEmpleado.GetInstancia().listarEmpleados();
            foreach (Empleado em in listEmpleados)
            {
                if (em.Codigo == codigo)
                {
                    empleado = em;
                }
            }
            return empleado;
        }
        internal Empleado buscarEmpleadosinBaja(short codigo)
        {
            Empleado empleado = null;
            List<Empleado> listEmpleados = DataEmpleado.GetInstancia().listarEmpleados();
            foreach (Empleado em in listEmpleados)
            {
                if (em.Codigo == codigo&&em.Bajalogica==false)
                {
                    empleado = em;
                }
            }
            return empleado;
        }



        //**********************************************

        internal string agregarEmpleado(Empleado emp)
        {
            string mensaje;
            Empleado buscarempleado = buscarEmpleado(emp.Codigo);
            if (buscarempleado != null)
            {
                if(buscarempleado.Bajalogica==true)
                {
                    DataEmpleado.GetInstancia().modificarBajaLEmpleado(buscarempleado.Codigo,false);
                    mensaje = "El empleado estaba con baja, ahora esta de regreso";
                    return mensaje;
                        
                }
                else
                {
                      throw new ExcepcionLogica("El Empleado esta activo en el sistema");
                }
              
            }
            DataEmpleado.GetInstancia().agregarEmpleado(emp);
             mensaje = "El Empleado se agrego con exito";
             return mensaje;
            
           

        }
        internal string modificarEmpleado(Empleado emp)
        {
            Empleado buscarempleado = buscarEmpleado(emp.Codigo);
            if (buscarempleado == null)
            {
                throw new ExcepcionLogica("El código del Empleado no existe en el sistema");
            }
            else
            {
                if(buscarempleado.Bajalogica==true)
                {
                    throw new ExcepcionLogica("El Empleado esta con baja y no se puede modificar");
                }
                DataEmpleado.GetInstancia().modificarEmpleado(emp);
                return "El Empleado se modifico con exito";
               
                
            }
          

        }
        internal string bajaEmpleado(short codigo)
        {
            Empleado buscarempleado = buscarEmpleado(codigo);
            if (buscarempleado == null)
            {
                throw new ExcepcionLogica("El codigo del Empleado no existe en el sistema");
            }
            else
            {
                if(buscarempleado.Bajalogica==true)
                {
                    throw new ExcepcionLogica("El Empleado ya está de baja");
                }
                DataEmpleado.GetInstancia().modificarBajaLEmpleado(codigo, true);
                return "El Empleado se dio de baja con exito";

            }

        }
    }
}
