using CData.SQL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNego
{
    public class C_Tecnico : C_Persona
    {

        private C_ManageSql sqlMan = new C_ManageSql();

        public bool CreaTecnico(C_Tecnico tecnico)
        {
            List<Parametros> parametros = new List<Parametros>
            {
                new Parametros("nombre", tecnico.Nombre),
                new Parametros("cedula", tecnico.Cedula),
                new Parametros("telefe", tecnico.Telefono),
                new Parametros("correo", tecnico.Correo),
                new Parametros("direcc", tecnico.Direccion)
            };

            return sqlMan.ejecutaSP_NonQuery("SP_CREA_TECNICO", parametros);
        }

        public DataTable GetTecnicos()
        {
            List<Parametros> parametros = new List<Parametros>
            {
                new Parametros("nombre_tabla", "tecnico")
            };

            return sqlMan.ejecutaSP_Query("SP_GET_ALL", parametros);
        }
        public C_Tecnico GetTecnico(string id)
        {

            List<Parametros> parametros = new List<Parametros>
            {
               new Parametros("id", id),
               new Parametros("nombre_tabla", "tecnico")
            };

            DataTable resultado = sqlMan.ejecutaSP_Query("SP_GET_RECORD", parametros);

            // Verificar si hay datos
            if (resultado.Rows.Count > 0)
            {


                DataRow fila = resultado.Rows[0];

                return new C_Tecnico
                {
                    Id = fila[0].ToString(),
                    Cedula = fila[1].ToString(),
                    Nombre = fila[2].ToString(),
                    Correo = fila[3].ToString(),
                    Direccion = fila[4].ToString(),
                    Telefono = fila[5].ToString()
                };
            }

            // Si no hay registro anterior, retornar null
            return null;
        }


        public bool EditaTecnico(C_Tecnico tecnico)
        {
            List<Parametros> parametros = new List<Parametros>
            {
                new Parametros("id_tec", tecnico.Id),
                new Parametros("nombre", tecnico.Nombre),
                new Parametros("cedula", tecnico.Cedula),
                new Parametros("telefe", tecnico.Telefono),
                new Parametros("correo", tecnico.Correo),
                new Parametros("direcc", tecnico.Direccion)
            };

            return sqlMan.ejecutaSP_NonQuery("SP_ACTUALIZA_TECNICO", parametros);
        }


        public bool EliminaTecnico(string id)
        {
            List<Parametros> parametros = new List<Parametros>
            {
                new Parametros("id_tec", id)
            };

            return sqlMan.ejecutaSP_NonQuery("SP_ELIMINA_TECNICO", parametros);
        }


    }

}