using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Almacen
{
    public class EMA_CUSTOMER
    {
        public int ID_CUSTOMER { get; set; }
        public int ID_COMPANY { get; set; }
        public string DESCRIPTION_CUSTOMER { get; set; }
        public string DOCUMENT_TYPE_CUSTOMER { get; set; }
        public string NUMBER_DOCUMENT { get; set; }
        public string NIF_ADDRESS { get; set; }
        public string DELIVERY_ADDRESS { get; set; }
        public string COMMERCIAL_TYPE { get; set; }
        public string CUSTOMER_TYPE { get; set; }
        public int PRICE_TYPE { get; set; }
        public int SALES { get; set; }
        public double CREDIT_LIMIT_LOCAL { get; set; }
        public double CREDIT_LIMIT_USD { get; set; }
        public string CONTACT { get; set; }
        public string MOVIL_CONTACT { get; set; }
        public string EMAIL { get; set; }
        public int ISTATUS { get; set; }
        public int SALES_CODE { get; set; }
        public string AUSUARIO { get; set; }
        public string AFECREG { get; set; }
        public string AMODIFICO { get; set; }
        public string AFECMOD { get; set; }
    }
}
