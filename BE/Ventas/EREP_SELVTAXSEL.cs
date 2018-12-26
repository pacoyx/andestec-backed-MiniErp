using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Ventas
{
    public class EREP_SELVTAXSEL
    {
        public string CLIENTE { get; set; }
        public string FECHA { get; set; }
        public string TIPDOC { get; set; }
        public string SERDOC { get; set; }
        public string NUMDOC { get; set; }
        public string MONEDA { get; set; }
        public double CANTI { get; set; }
        public double PRECUNIT { get; set; }
        public double TOTAL { get; set; }
    }
}
