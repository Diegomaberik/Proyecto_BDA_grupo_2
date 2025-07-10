using CData.SQL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNego
{
    public class C_Orden
    {
        public int Id { get; set; }
        public string Id_cli { get; set; }
        public string Id_tec { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Imei { get; set; }
        public string Estado { get; set; }
        public string Observ { get; set; }
        public DateTime Fecing { get; set; }
        public DateTime? Fecfac { get; set; }



        private C_ManageSql sqlMan = new C_ManageSql();

        public C_Orden()
        {
            Id = 0;
            Id_cli = string.Empty;
            Id_tec = string.Empty;
            Marca = string.Empty;
            Modelo = string.Empty;
            Modelo = string.Empty;
            Imei = string.Empty;
            Estado = "A";
            Observ = string.Empty;
            Fecing = DateTime.Now;
            Fecfac = null;
        }

        public C_Orden(int id, string idCli, string idTec, string marca, string modelo, string imei, string estado, string observ, DateTime fecing, DateTime fecfac)
        {
            Id = id;
            Id_cli = idCli;
            Id_tec = idTec;
            Marca = marca;
            Modelo = modelo;
            Imei = imei;
            Estado = estado;
            Observ = observ;
            Fecing = fecing;
            Fecfac = fecfac;
        }

        public DataTable GetOrdenes(string tipo)
        {
            List<Parametros> parametros = new List<Parametros>
            {
                new Parametros("tipo", tipo)
            };

            return sqlMan.ejecutaSP_Query("SP_GET_ORDENES", parametros);
        }

        public bool GrabaOrden(C_Orden orden)
        {
            List<Parametros> parametros = new List<Parametros>
            {
                new Parametros("id_cli", orden.Id_cli),
                new Parametros("id_tec", orden.Id_tec),
                new Parametros("fecing", orden.Fecing),
                new Parametros("marca", orden.Marca),
                new Parametros("modelo", orden.Modelo),
                new Parametros("imei", orden.Imei),
                new Parametros("observ", orden.Observ),
                new Parametros("estado", "1")
            };

            return sqlMan.ejecutaSP_NonQuery("SP_CREA_ORDEN", parametros);
        }

        public C_Orden GetOrden(int id)
        {

            List<Parametros> parametros = new List<Parametros>
            {
               new Parametros("id", id),
               new Parametros("nombre_tabla", "orden")
            };

            DataTable resultado = sqlMan.ejecutaSP_Query("SP_GET_RECORD", parametros);

            // Verificar si hay datos
            if (resultado.Rows.Count > 0)
            {


                DataRow fila = resultado.Rows[0];

                return new C_Orden
                {
                    Id = Convert.ToInt32(fila[0]),
                    Id_cli = fila[1].ToString(),
                    Id_tec = fila[2].ToString(),
                    Marca = fila[3].ToString(),
                    Modelo = fila[4].ToString(),
                    Imei = fila[5].ToString(),
                    Observ = fila[6].ToString(),
                    Fecing = Convert.ToDateTime(fila[7]),
                    Fecfac = fila.IsNull(8) ? (DateTime?)null : Convert.ToDateTime(fila[8]),
                    Estado = fila[9].ToString()
                };
            }

            // Si no hay registro anterior, retornar null
            return null;
        }

    }

}