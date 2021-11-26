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
        private static string server = "bdwfqxhlxjhlsm1frxu2-mysql.services.clever-cloud.com";
        private static string database = "bdwfqxhlxjhlsm1frxu2";
        private static string username = "uweiywvggqxernlv";
        private static string password = "DlJAFAnm591MtvjCx3FM";
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
