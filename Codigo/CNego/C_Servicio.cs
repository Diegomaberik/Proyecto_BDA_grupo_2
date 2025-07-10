using CData.SQL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNego
{
    public class C_Servicio : C_Item
    {
        private C_ManageSql sqlMan = new C_ManageSql();

        public bool CreaServicio(C_Servicio servicio)
        {
            List<Parametros> parametros = new List<Parametros>
            {
                new Parametros("s_descri", servicio.Descri),
                new Parametros("s_refere", servicio.Refere),
                new Parametros("s_prcvta", servicio.Prcvta)
            };

            return sqlMan.ejecutaSP_NonQuery("SP_CREA_SERVICIO", parametros);
        }

        public DataTable GetServicios()
        {
            List<Parametros> parametros = new List<Parametros>
            {
                //new Parametros("nombre_tabla", "items"),
                //new Parametros("opcion1", "1")
            };

            return sqlMan.ejecutaSP_Query("SP_GET_ALL_SERV", null);
        }
        public C_Servicio GetServicio(int id)
        {

            List<Parametros> parametros = new List<Parametros>
            {
               new Parametros("id", id),
               new Parametros("nombre_tabla", "items")
            };

            DataTable resultado = sqlMan.ejecutaSP_Query("SP_GET_RECORD", parametros);

            // Verificar si hay datos
            if (resultado.Rows.Count > 0)
            {

                DataRow fila = resultado.Rows[0];

                return new C_Servicio
                {
                    Id = Convert.ToInt32(fila[0]),
                    Descri = fila[3].ToString(),
                    Refere = fila[2].ToString(),
                    Prcvta = Convert.ToDecimal(fila[7])
                };
            }

            // Si no hay registro anterior, retornar null
            return null;
        }


        public bool EditaServicio(C_Servicio servicio)
        {
            List<Parametros> parametros = new List<Parametros>
            {
                new Parametros("s_id", servicio.Id),
                new Parametros("s_descri", servicio.Descri),
                new Parametros("s_refere", servicio.Refere),
                new Parametros("s_prcvta", servicio.Prcvta)
            };

            return sqlMan.ejecutaSP_NonQuery("SP_ACTUALIZA_SERVICIO", parametros);
        }


        public bool EliminaServicio(int id)
        {
            List<Parametros> parametros = new List<Parametros>
            {
                new Parametros("s_id", id)
            };

            return sqlMan.ejecutaSP_NonQuery("SP_ELIMINA_SERVICIO", parametros);
        }

    }
}