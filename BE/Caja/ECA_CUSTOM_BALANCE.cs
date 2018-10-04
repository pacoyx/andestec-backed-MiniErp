using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Caja
{
    public class ECA_CUSTOM_BALANCE
    {
        public int CM_ID { get; set; }
        public int CM_CUSTOMER_ID { get; set; }
        public string CM_DOCUMENT_ID { get; set; }
        public string CM_SERIR_DOC { get; set; }
        public string CM_NUMBER_DOC { get; set; }
        public DateTime CM_DOC_DATE { get; set; }
        public DateTime CM_CADUCATE_DATE { get; set; }
        public string CM_SALES_ID { get; set; }
        public double CM_AMOUNT { get; set; }
        public double CM_AMOUNT_BALANCE { get; set; }
        public string CM_CURRENCY_ID { get; set; }
        public double CM_SELL_RATE { get; set; }
        public string CM_ISTATUS { get; set; }
        public string CM_TERMS { get; set; }
        public string CM_PLACE_SALES { get; set; }
        public string OC_AUSUARIO { get; set; }
        public DateTime OC_AFECREG { get; set; }
        public string OC_AMODIFICO { get; set; }
        public DateTime OC_AFECMOD { get; set; }
        public int CM_IDCOMPANY { get; set; }
    }
}
