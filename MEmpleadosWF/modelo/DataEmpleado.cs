using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

using MEmpleadosWF.modelo.excepciones;

namespace MEmpleadosWF
{
    internal class DataEmpleado
    {
        private static DataEmpleado _instancia = null;
        private DataEmpleado() { }
        public static DataEmpleado GetInstancia()
        {
            if (_instancia == null)
                _instancia = new DataEmpleado();
            return _instancia;
        }
       internal  List<Empleado> listarEmpleados()
        {
            string consulta = "select* from Empleado;";
            MySqlConnection cnn = Conexion.conexion();
            MySqlCommand comand = new MySqlCommand(consulta,cnn);
            List<Empleado> listempleado = new List<Empleado>();
          
            try
            {
                cnn.Open();
                MySqlDataReader _lector = comand.ExecuteReader();
                if(_lector.HasRows)
                {
                    while(_lector.Read())
                    {
                        short codigo = (short)_lector["Codigo"];
                        string nombre = (string)_lector["Nombre"];
                        DateTime fechanac = (DateTime)_lector["FechaNac"];
                        DateTime fechaing = (DateTime)_lector["FechaIng"];
                        decimal salarioxh = (decimal)_lector["SalarioXH"];
                        bool bajalogica = (bool)_lector["BajaL"];
                        Empleado emp = new Empleado(codigo,nombre,fechanac,fechaing,
                            salarioxh,bajalogica);
                        listempleado.Add(emp);
                    }

                }
                _lector.Close();

            }
            catch(Exception ex)
            {
                throw new ExcepcionPersistencia("No se pudo listar los empleados",ex);
            }
            finally
            {
                cnn.Close();
            }
            return listempleado;

        }
       internal  void agregarEmpleado(Empleado emp)
        {
            MySqlConnection cnn = Conexion.conexion();
            try
            {
                string consulta = "INSERT INTO Empleado (Codigo, Nombre, FechaNac, FechaIng, SalarioXH) VALUES (@Codigo,@Nombre,@FechaNac,@FechaIng,@SalarioXH);";
               
                MySqlCommand _comando = new MySqlCommand(consulta, cnn);
                _comando.Parameters.AddWithValue("@Codigo", emp.Codigo);
                _comando.Parameters.AddWithValue("@Nombre", emp.Nombre);
                _comando.Parameters.AddWithValue("@FechaNac", emp.Fecha_nacimiento);
                _comando.Parameters.AddWithValue("@FechaIng", emp.Fecha_ingreso);
                _comando.Parameters.AddWithValue("@SalarioXH", emp.Salarioxhora);
                cnn.Open();
                _comando.ExecuteNonQuery();
             
            }
            catch (Exception ex)
            {
                throw new ExcepcionPersistencia("No se pudo agregar el empleado", ex);
            }
            finally
            {
                cnn.Close();
            }
          

        }

       internal  void modificarEmpleado(Empleado emp)
        {
            MySqlConnection cnn = Conexion.conexion();
            try
            {
                string consulta = "UPDATE Empleado SET Nombre=@Nombre,FechaNac=@FechaNac,FechaIng=@FechaIng,SalarioXH=@SalarioXH where Codigo=@Codigo;";

                MySqlCommand _comando = new MySqlCommand(consulta, cnn);
                _comando.Parameters.AddWithValue("@Codigo", emp.Codigo);
                _comando.Parameters.AddWithValue("@Nombre", emp.Nombre);
                _comando.Parameters.AddWithValue("@FechaNac", emp.Fecha_nacimiento);
                _comando.Parameters.AddWithValue("@FechaIng", emp.Fecha_ingreso);
                _comando.Parameters.AddWithValue("@SalarioXH", emp.Salarioxhora);
                cnn.Open();
                _comando.ExecuteNonQuery();
             

            }
            catch (Exception ex)
            {
                throw new ExcepcionPersistencia("No se pudo modificar el empleado", ex);
            }
            finally
            {
                cnn.Close();
            }


        }

       internal  void modificarBajaLEmpleado(short codigo,bool baja)
        {
            MySqlConnection cnn = Conexion.conexion();
            try
            {
                string consulta = " UPDATE Empleado SET BajaL=@BajaL where Codigo=@Codigo;";

                MySqlCommand _comando = new MySqlCommand(consulta, cnn);
                _comando.Parameters.AddWithValue("@Codigo", codigo);
                _comando.Parameters.AddWithValue("@BajaL", baja);

                cnn.Open();
                _comando.ExecuteNonQuery();
               

            }
            catch (Exception ex)
            {
                throw new ExcepcionPersistencia("No se pudo eliminar el empleado", ex);
            }
            finally
            {
                cnn.Close();
            }


        }
    }
}
