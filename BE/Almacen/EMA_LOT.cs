using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Almacen
{
    public class EMA_LOT
    {
        public int IDCOMPANY { get; set; }
        public int IDARTICLE { get; set; }
        public string IDLOT { get; set; }
        public string DESCRIPTION { get; set; }
        public string EXPEDITION_DATE { get; set; }
        public string CADUCATE_DATE { get; set; }
        public string COMMENT { get; set; }
        public string ISTATUS { get; set; }
    }
}
