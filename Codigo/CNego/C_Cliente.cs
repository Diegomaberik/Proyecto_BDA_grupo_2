using CData.SQL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNego
{
    public class C_Cliente : C_Persona
    {
        private C_ManageSql sqlMan = new C_ManageSql();

        public bool CreaCliente(C_Cliente cliente)
        {
            List<Parametros> parametros = new List<Parametros>
            {
                new Parametros("nombre", cliente.Nombre),
                new Parametros("cedula", cliente.Cedula),
                new Parametros("telefe", cliente.Telefono),
                new Parametros("correo", cliente.Correo),
                new Parametros("direcc", cliente.Direccion)
            };

            return sqlMan.ejecutaSP_NonQuery("SP_CREA_CLIENTE", parametros);
        }

        public DataTable GetClientes()
        {
            List<Parametros> parametros = new List<Parametros>
            {
                new Parametros("nombre_tabla", "cliente")
            };

            return sqlMan.ejecutaSP_Query("SP_GET_ALL", parametros);
        }
        public C_Cliente? GetCliente(string id)
        {
            List<Parametros> parametros = new List<Parametros>
            {
               new Parametros("nombre_tabla", "cliente"),
               new Parametros("id", id)
            };

            DataTable resultado = sqlMan.ejecutaSP_Query("SP_GET_RECORD", parametros);

            // Verificar si hay datos
            if (resultado.Rows.Count > 0)
            {
                DataRow fila = resultado.Rows[0];
                return new C_Cliente
                {
                    Id = fila[0]?.ToString() ?? string.Empty,
                    Cedula = fila[1]?.ToString() ?? string.Empty,
                    Nombre = fila[2]?.ToString() ?? string.Empty,
                    Correo = fila[3]?.ToString() ?? string.Empty,
                    Direccion = fila[4]?.ToString() ?? string.Empty,
                    Telefono = fila[5]?.ToString() ?? string.Empty
                };
            }
            // Si no hay registro anterior, retornar null
            return null;
        }


        public bool EditaCliente(C_Cliente cliente)
        {
            List<Parametros> parametros = new List<Parametros>
            {
                new Parametros("id_cliente", cliente.Id),
                new Parametros("cedula", cliente.Cedula),
                new Parametros("nombre", cliente.Nombre),
                new Parametros("telefe", cliente.Telefono),
                new Parametros("correo", cliente.Correo),
                new Parametros("direcc", cliente.Direccion)
            };

            return sqlMan.ejecutaSP_NonQuery("SP_ACTUALIZA_CLIENTE", parametros);
        }


        public bool EliminaCliente(string id)
        {
            List<Parametros> parametros = new List<Parametros>
            {
                new Parametros("id_cliente", id)
            };

            return sqlMan.ejecutaSP_NonQuery("SP_ELIMINA_CLIENTE", parametros);
        }


    }

}