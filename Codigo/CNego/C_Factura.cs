using CData.SQL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CNego
{
    public class C_Factura
    {
        public int Id { get; set; }
        public string Id_cli { get; set; }
        public int Id_ord { get; set; }
        public string Id_tec { get; set; }
        public decimal Totbru { get; set; }
        public decimal Totiva { get; set; }
        public decimal Totnet { get; set; }
        public string Estado { get; set; }
        public string Obsini { get; set; }
        public string Obsfin { get; set; }
        public DateTime Fecfac { get; set; }



        private C_ManageSql sqlMan = new C_ManageSql();

        public C_Factura()
        {
            Id = 0;
            Id_cli = string.Empty;
            Id_tec = string.Empty;
            Id_ord = 0;
            Estado = "A";
            Obsini = string.Empty;
            Obsfin = string.Empty;
            Fecfac = DateTime.Now;
            Totnet = 0;
            Totiva = 0;
            Totbru = 0;
        }

        public C_Factura(int id, string idCli, string idTec, int idOrd, string estado, string obsini, string obsfin, decimal totbru, decimal totiva, decimal totnet, DateTime fecfac)
        {
            Id = id;
            Id_cli = idCli;
            Id_tec = idTec;
            Id_ord = idOrd;
            Estado = estado;
            Obsini = obsini;
            Obsfin = obsfin;
            Fecfac = fecfac;
            Totbru = totbru;
            Totiva = totiva;
            Totnet = totnet;
        }

        public DataTable GetFacturas()
        {
            List<Parametros> parametros = new List<Parametros>
            {
                new Parametros("nombre_tabla", "factura")
            };

            return sqlMan.ejecutaSP_Query("SP_GET_ALL", parametros);
        }

        public int GrabaFactura(C_Factura factura)
        {
            int ultimoId;
            List<Parametros> parametros = new List<Parametros>
            {
                new Parametros("id_cli", factura.Id_cli),
                new Parametros("id_tec", factura.Id_tec),
                new Parametros("fecfac", factura.Fecfac),
                new Parametros("id_ord", factura.Id_ord),
                new Parametros("totbru", factura.Totbru),
                new Parametros("totiva", factura.Totiva),
                new Parametros("totnet", factura.Totnet),
                new Parametros("obsfin", factura.Obsini),
                new Parametros("obsini", factura.Obsfin),
                new Parametros("estado", "1"),
                new Parametros("ultimoId", 0, ParameterDirection.Output)
            };

            sqlMan.ejecutaSP_NonQuery("SP_GRABA_FACTURA", parametros);
            ultimoId = Convert.ToInt32(parametros.First(p => p.Nombre == "ultimoId").Valor);

            return ultimoId;
        }

        public DataTable GetFacturas(string tipo)
        {
            List<Parametros> parametros = new List<Parametros>
            {
                new Parametros("tipo", tipo)
            };

            return sqlMan.ejecutaSP_Query("SP_GET_ALL", parametros);
        }

        public C_Factura GetFactura(int id)
        {

            List<Parametros> parametros = new List<Parametros>
            {
               new Parametros("id", id),
               new Parametros("nombre_tabla", "factura")
            };

            DataTable resultado = sqlMan.ejecutaSP_Query("SP_GET_RECORD", parametros);

            // Verificar si hay datos
            if (resultado.Rows.Count > 0)
            {


                DataRow fila = resultado.Rows[0];

                return new C_Factura
                {
                    Id = Convert.ToInt32(fila[0]),
                    Id_cli = fila[1].ToString(),
                    Id_ord = Convert.ToInt32(fila[2].ToString()),
                    Id_tec = fila[3].ToString(),
                    Totbru = Convert.ToDecimal(fila[4].ToString()),
                    Totiva = Convert.ToDecimal(fila[5].ToString()),
                    Totnet = Convert.ToDecimal(fila[6].ToString()),
                    Estado = fila[7].ToString(),
                    Obsini = fila[8].ToString(),
                    Obsfin = fila[9].ToString(),
                    Fecfac = Convert.ToDateTime(fila[10])
                    

                };
            }

            // Si no hay registro anterior, retornar null
            return null;
        }

    }

}