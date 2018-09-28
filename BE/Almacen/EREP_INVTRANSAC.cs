using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Almacen
{
    public class EREP_INVTRANSAC
    {
        public string ALMACEN { get; set; }
        public string SERIE { get; set; }
        public string NUMERO { get; set; }
        public string FECHA { get; set; }
        public string CODARTI { get; set; }
        public string DESARTI { get; set; }
        public string LOTE { get; set; }
        public double CANTIDAD { get; set; }
        public double COSTO { get; set; }
        public double TOTAL { get; set; }
        public string GLOSA { get; set; }
        public string ANEXO { get; set; }
    }
}
