using CData.SQL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNego
{
    public class C_FacDet
    {
        public int Id { get; set; }
        public int Id_fac { get; set; }
        public int Tipdet { get; set; }
        public int Id_ite { get; set; }
        public int Cantid { get; set; }
        public decimal Prcvta { get; set; }
        public decimal Totnet { get; set; }

    
        private C_ManageSql sqlMan = new C_ManageSql();

        public C_FacDet()
        {
            Id = 0;
            Id_fac = 0;
            Id_ite = 0;
            Tipdet = 0;
            Prcvta = 0;
            Cantid = 0;
            Totnet = 0;
        }

        public C_FacDet (int id, int idfac, int idite, int tipdet, int cantid, decimal prcvta, decimal totnet)
        {
            Id = id;
            Id_fac = idfac;
            Id_ite = idite;
            Tipdet = tipdet;
            Cantid = cantid;
            Prcvta = prcvta;
            Totnet = totnet;            
        }

        public bool GrabaDatos(C_FacDet facdet)
        {
            List<Parametros> parametros = new List<Parametros>
            {
                new Parametros("id_fac", facdet.Id_fac),
                new Parametros("id_ite", facdet.Id_ite),
                new Parametros("tipdet", facdet.Tipdet),
                new Parametros("prcvta", facdet.Prcvta),
                new Parametros("cantid", facdet.Cantid),
                new Parametros("totnet", facdet.Totnet)
            };

            return sqlMan.ejecutaSP_NonQuery("SP_GRABA_FACDET", parametros);
        }

        public DataTable GetDatos(int idfac)
        {
            List<Parametros> parametros = new List<Parametros>
            {
                new Parametros("idfac", idfac)
            };

            return sqlMan.ejecutaSP_Query("SP_GET_FACDET", parametros);
        }
    }
    
}