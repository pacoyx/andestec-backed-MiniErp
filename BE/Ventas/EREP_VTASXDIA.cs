using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Ventas
{
    public class EREP_VTASXDIA
    {
        public string CLIENTE { get; set; }
        public string FECHA { get; set; }
        public string TIPDOC { get; set; }
        public string SERDOC { get; set; }
        public string NUMDOC { get; set; }
        public string MONEDA { get; set; }
        public double VALORVTA { get; set; }
        public double IMPUESTO { get; set; }
        public double TOTAL { get; set; }
        public double TC { get; set; }
        public string TIPOPAGO { get; set; }
        public string TARJETA { get; set; }
        public string NUMOPE { get; set; }
        public double MONTOPAGADO { get; set; }

    }
}
