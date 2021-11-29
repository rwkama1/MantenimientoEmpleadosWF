using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MEmpleadosWF.modelo.excepciones;
using MySql.Data.MySqlClient;

namespace MEmpleadosWF
{
    internal class Conexion
    {
        private static string server = "localhost";
        private static string database = "BDMEmpleados";
        private static string username = "root";
        private static string password = "root";
        private static string _cnn = "Server=" + server + ";Uid=" + username  + ";Pwd=" + password + ";Database=" + database+";SslMode=None";
              internal static MySqlConnection conexion()
        {
            try
            {
                MySqlConnection cnn = new MySqlConnection(_cnn);
                return cnn;
            }
            catch(Exception ex)
            {
                throw new ExcepcionPersistencia("Error al conectar a MySQL", ex);
            }
           
         }
    }
}
