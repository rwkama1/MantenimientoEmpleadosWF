using MEmpleadosWF.modelo.excepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEmpleadosWF
{
    internal class Empleado
    {
        private short codigo;
        private string nombre;
        private DateTime fecha_nacimiento;
        private DateTime fecha_ingreso;
        private decimal salarioxhora;
        private bool bajalogica;

        
        public short Codigo
        {
            get { return codigo; }
            set
            {
                if (value <= 0 || value > 9999)
                {
                    throw new ExcepcionLogica("El código del empleado debe ser menor a 9999 y mayor a 0");
                }

                codigo = value;
            }
        }
        public string Nombre
        {
            get { return nombre; }
            set
            {
                if (value.Trim().Length==0 || value.Trim().Length > 100)
                {
                    throw new ExcepcionLogica("El nombre del empleado debe contener menos de 100 caracteres y no debe estar vacio");
                } 

                nombre = value;
            }
        }
        public DateTime Fecha_nacimiento {
            get { return fecha_nacimiento; }
            set
            {
                fecha_nacimiento = value;
            }
        }
        public DateTime Fecha_ingreso
        {
            get { return fecha_ingreso; }
            set
            {
                if (value.Year < Fecha_nacimiento.Year)
                {
                    throw new ExcepcionLogica("La fecha de nacimiento no puede ser mayor a la fecha de ingreso");
                }

                fecha_ingreso = value;
            }
        }
        public decimal Salarioxhora
        {
            get { return salarioxhora; }
            set
            {
                if (value > 9999 || value<1000)
                {
                    throw new ExcepcionLogica("El salario por hora del empleado debe tener 4 enteros y 2 decimales");
                }
                salarioxhora = value;
            }
        }
        public bool Bajalogica
        {
            get { return bajalogica; }
            set
            {
                bajalogica = value;
            }
        }
       
   
        public int Antiguedad_En_Años
        {
            get { 
                
            DateTime fecha_actual = DateTime.Now;
            int antiguedad = fecha_actual.Year - Fecha_ingreso.Year;
            return antiguedad;

            }
        }
        public string Adicional_Al_Salario
        {
            get {
                DateTime fecha_actual = DateTime.Now;
                int cuarto_año = Fecha_ingreso.Year + 4;
                int adicional = fecha_actual.Year - cuarto_año;
                return "$ "+adicional;
            }
        }
        public Empleado(short pcodigo, string pnombre, DateTime pfecha_nacimiento, DateTime pfecha_ingreso, decimal psalarioxhora, bool pbajalogica)
        {
            Codigo = pcodigo;
            Nombre = pnombre;
            Fecha_nacimiento = pfecha_nacimiento;
            Fecha_ingreso = pfecha_ingreso;
            Salarioxhora = psalarioxhora;
            Bajalogica = pbajalogica;
        }

    }
}
