using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Almacen
{
    public class ETRA_WAREHOUSE
    {
        public int ID_COMPANY { get; set; }
        public int ID_TRANSACTION_WAREHOUSE { get; set; }
        public string ID_WAREHOUSE { get; set; }
        public string ITRANSACTION { get; set; }
        public string TRANSACTION_TYPE { get; set; }
        public string DOCUMENT_TYPE { get; set; }
        public string ID_SERIE { get; set; }
        public int ID_CORRELATIVE { get; set; }
        public string TRANSACTION_DATE { get; set; }
        public string TRANSACCION_CURRENCY { get; set; }
        public int ISTATUS { get; set; }
        public string AUSUARIO { get; set; }
        public string AFECREG { get; set; }
        public string AMODIFICO { get; set; }
        public string AFECMOD { get; set; }
        public string TIPOPER { get; set; }
        public int PERSONA { get; set; }
        public int IDCC { get; set; }
        public string COMMENT { get; set; }
    }
}
