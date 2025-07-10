using CData.SQL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNego
{
    public class C_Producto : C_Item
    {

        public string Marca { get; set; }
        public decimal Prccpa { get; set; }
        public int Cantid { get; set; }

        private C_ManageSql sqlMan = new C_ManageSql();

        
        public C_Producto(int id, string descri, string refere, string marca, decimal prcvta, decimal prccpa, int cantid)
           : base(id, descri, refere, prcvta)
        {
            Marca = marca;
            Prccpa = prccpa;
            Cantid = cantid;
        }
        public C_Producto() : base()
        {
            Marca = string.Empty;
            Prccpa = 0;
            Cantid = 0;
        }

        public bool CreaProducto(C_Producto producto)
        {
            List<Parametros> parametros = new List<Parametros>
            {
                new Parametros("p_descri", producto.Descri),
                new Parametros("p_refere", producto.Refere),
                new Parametros("p_marca", producto.Marca),
                new Parametros("p_cantid", producto.Cantid),
                new Parametros("p_prcvta", producto.Prcvta),
                new Parametros("p_prccpa", producto.Prccpa)
            };

            return sqlMan.ejecutaSP_NonQuery("SP_CREA_PRODUCTO", parametros);
        }

        public DataTable GetProductos()
        {
            List<Parametros> parametros = new List<Parametros>
            {
                //new Parametros("nombre_tabla", "items")
            };

            return sqlMan.ejecutaSP_Query("SP_GET_ALL_ITEMS", null);
        }
        public C_Producto GetProducto(int id)
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

                return new C_Producto
                {
                    Id = Convert.ToInt32(fila[0]),
                    Descri = fila[3].ToString(),
                    Refere = fila[2].ToString(),
                    Marca = fila[4].ToString(),
                    Cantid = Convert.ToInt32(fila[5]),
                    Prcvta = Convert.ToDecimal(fila[7]),
                    Prccpa = Convert.ToDecimal(fila[6])
                };
            }

            // Si no hay registro anterior, retornar null
            return null;
        }


        public bool EditaProducto(C_Producto producto)
        {
            List<Parametros> parametros = new List<Parametros>
            {
                new Parametros("p_id", producto.Id),
                new Parametros("p_descri", producto.Descri),
                new Parametros("p_refere", producto.Refere),
                new Parametros("p_marca", producto.Marca),
                new Parametros("p_cantid", producto.Cantid),
                new Parametros("p_prcvta", producto.Prcvta),
                new Parametros("p_prccpa", producto.Prccpa)
            };

            return sqlMan.ejecutaSP_NonQuery("SP_ACTUALIZA_PRODUCTO", parametros);
        }


        public bool EliminaProducto(int id)
        {
            List<Parametros> parametros = new List<Parametros>
            {
                new Parametros("p_id", id)
            };

            return sqlMan.ejecutaSP_NonQuery("SP_ELIMINA_PRODUCTO", parametros);
        }

    }
}