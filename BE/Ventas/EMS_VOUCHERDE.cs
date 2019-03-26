using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Ventas
{
    public class EMS_VOUCHERDE
    {   
        public int VD_IDVOUCHERHE { get; set; }
        public int VD_ITEM { get; set; }
        public int VD_IDARTICULO { get; set; }
        public string VD_DEARTICULO { get; set; }
        public double VD_QTY { get; set; }
        public double VD_UNITPRICE { get; set; }
        public double VD_TOTALPRICE { get; set; }
        public string VD_COMMENT { get; set; }
        public string VD_ISTATUS { get; set; }
        public int VD_IDORDER { get; set; }
        public string VD_IDLOTE { get; set; }
        public double VD_XIGV { get; set; }
        public double VD_XSUBT { get; set; }
        public double VD_XTOT { get; set; }

    }
}
