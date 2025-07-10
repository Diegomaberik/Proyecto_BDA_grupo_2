using CData.SQL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNego
{
    public class C_OrdDet
    {
        public int Id { get; set; }
        public int Id_ord { get; set; }
        public int Tipdet { get; set; }
        public int Id_ite { get; set; }
        public decimal Prcvta { get; set; }
        public int Cantid { get; set; }
        public string Estado { get; set; }
        public string Observ { get; set; }
        public DateTime Fecdet { get; set; }


    
        private C_ManageSql sqlMan = new C_ManageSql();

        public C_OrdDet()
        {
            Id = 0;
            Id_ord = 0;
            Id_ite = 0;
            Tipdet = 0;
            Prcvta = 0;
            Cantid = 0;
            Estado = "A";
            Observ = string.Empty;
            Fecdet = DateTime.Now;
        }

        public C_OrdDet (int id, int idord, int idite, int tipdet, int cantid, decimal prcvta, string estado, string observ)
        {
            Id = id;
            Id_ord = idord;
            Id_ite = idite;
            Tipdet = tipdet;
            Cantid = cantid;
            Prcvta = prcvta;
            Estado = estado;
            Observ = observ;
            Fecdet = DateTime.Now;            
        }

        public bool GrabaDetalle(C_OrdDet orddet)
        {
            List<Parametros> parametros = new List<Parametros>
            {
                new Parametros("id_ord", orddet.Id_ord),
                new Parametros("id_ite", orddet.Id_ite),
                new Parametros("fecdet", orddet.Fecdet),
                new Parametros("tipdet", orddet.Tipdet),
                new Parametros("prcvta", orddet.Prcvta),
                new Parametros("cantid", orddet.Cantid),
                new Parametros("observ", orddet.Observ),
                new Parametros("estado", "A")
            };

            return sqlMan.ejecutaSP_NonQuery("SP_GRABA_ORDDET", parametros);
        }

        public DataTable GetDetalles(int idord)
        {
            List<Parametros> parametros = new List<Parametros>
            {
                new Parametros("idord", idord)
            };

            return sqlMan.ejecutaSP_Query("SP_GET_ORDDET", parametros);
        }
    }
    
}