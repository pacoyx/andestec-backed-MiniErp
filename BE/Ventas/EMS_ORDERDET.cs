using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Ventas
{
    public class EMS_ORDERDET
    {
        public int OD_IDORDERCAB { get; set; }
        public int OD_ITEM { get; set; }
        public int OD_IDARTICULO { get; set; }
        public string OD_DEARTICULO { get; set; }
        public double OD_QTY { get; set; }
        public double OD_UNITPRICE { get; set; }
        public double OD_TOTALPRICE { get; set; }
        public string OD_ISTATUS { get; set; }
        public double OD_QTY_DISPA { get; set; }
    }
}
