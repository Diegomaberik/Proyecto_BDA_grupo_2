using CData.SQL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNego
{
    public class C_Item
    {

        public int Id { get; set; }
        public string Descri { get; set; }
        public string Refere { get; set; }
        public decimal Prcvta { get; set; }

        public C_Item()
        {
            Id = 0;
            Descri = string.Empty;
            Refere = string.Empty;
            Prcvta = 0;
        }

        public C_Item(int id, string descri, string refere, decimal prcvta)
        {
            Id = id;
            Descri = descri;
            Refere = refere;
            Prcvta = prcvta;
        }

    }
}