using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Almacen
{
    public class ETRA_WAREHOUSE_QTY_LOT
    {
        public int IDCOMPANY { get; set; }
        public string IDWAREHOUSE { get; set; }
        public int IDARTICLE { get; set; }
        public string IDLOT { get; set; }
        public double QTY { get; set; }
    }
}
