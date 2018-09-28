using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Almacen
{
    public class EREP_INVKARDEX
    {
        public string TRANSACCION { get; set; }
        public string TIPO_TRANS { get; set; }
        public string SERIE { get; set; }
        public string NUMERO { get; set; }
        public string FECHA { get; set; }
        public string CODARTI { get; set; }
        public string DESARTI { get; set; }
        public string LOTE { get; set; }
        public double INICIAL { get; set; }
        public double INGRESO { get; set; }
        public double SALIDA { get; set; }
        public double SALDO { get; set; }
        public string ANEXO { get; set; }
    }
}
