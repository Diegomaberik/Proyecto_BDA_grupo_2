using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CData.SQL
{
    internal class ConnectionDB
    {
        //private static string cadena_conexion = "server=DESKTOP-BC6NDN5; database=DB_POE; Integrated Security=true";
        private static string cadena_conexion = "server=www.ecuinfo.net; database=ugds; user=ugcs; password=universidadCS2025;";
        private MySqlConnection connection_db = new MySqlConnection(cadena_conexion);

        internal MySqlConnection OpenConnection()
        {
            if (connection_db.State == System.Data.ConnectionState.Closed)
                connection_db.Open();
            return connection_db;
        }

        internal MySqlConnection CloseConnection()
        {
            if (connection_db.State == System.Data.ConnectionState.Open)
                connection_db.Close();
            return connection_db;
        }
    }
}