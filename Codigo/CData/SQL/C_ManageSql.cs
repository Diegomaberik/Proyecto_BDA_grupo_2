using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace CData.SQL
{

    public class Parametros
    {
        public string Nombre { get; set; }
        public object Valor { get; set; }
        public ParameterDirection Direccion { get; set; } = ParameterDirection.Input;

        public Parametros(string nombre, object valor, ParameterDirection direccion = ParameterDirection.Input)
        {
            Nombre = nombre;
            Valor = valor;
            Direccion = direccion;
        }
    }

    public class C_ManageSql
    {
        private ConnectionDB conn = new ConnectionDB();


        // Método para ejecutar procedimientos almacenados que retornan datos (SELECT)
        public DataTable ejecutaSP_Query(string nombre_sp, List<Parametros> lista)
        {
            using (var comando = new MySqlCommand(nombre_sp, conn.OpenConnection()))
            {
                comando.CommandType = CommandType.StoredProcedure;

                // Agregar parámetros si existen
                if (lista != null)
                {
                    foreach (var parametro in lista)
                    {
                        comando.Parameters.AddWithValue(parametro.Nombre, parametro.Valor ?? DBNull.Value);
                    }
                }

                using (var reader = comando.ExecuteReader())
                using (var tabla = new DataTable())
                {
                    tabla.Load(reader);
                    conn.CloseConnection();
                    return tabla;
                }
            }
        }

        public bool ejecutaSP_NonQuery(string nombre_sp, List<Parametros> lista)
        {
            using (var comando = new MySqlCommand(nombre_sp, conn.OpenConnection()))
            {
                comando.CommandType = CommandType.StoredProcedure;

                // Agregar parámetros si existen
                if (lista != null)
                {
                    foreach (var parametro in lista)
                    {
                        var sqlParam = comando.Parameters.AddWithValue(parametro.Nombre, parametro.Valor ?? DBNull.Value);
                        if (parametro.Direccion == ParameterDirection.Output)
                        {
                            sqlParam.Direction = ParameterDirection.Output;
                        }
                    }
                }
                Console.WriteLine(comando.ToString());
                var result = comando.ExecuteNonQuery();

                if (lista != null)
                {
                    foreach (var parametro in lista.Where(p => p.Direccion == ParameterDirection.Output))
                    {
                        parametro.Valor = comando.Parameters[parametro.Nombre].Value;
                    }
                    
                }

                conn.CloseConnection();

                return result > 0;
            }
        }



    }
}