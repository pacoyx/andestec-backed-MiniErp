using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Caja
{
    public class ECA_COLLECTION_LINE
    {
        public int CL_ID { get; set; }
        public int CL_ITEM { get; set; }
        public string CL_TYPE_DOC { get; set; }
        public string CL_SERIE_DOC { get; set; }
        public string CL_NUMBER_DOC { get; set; }
        public string CL_TYPE_OPERATION { get; set; }
        public DateTime CL_DATE { get; set; }
        public double CL_AMOUNT { get; set; }
        public string CL_CURRENCY_ID { get; set; }
        public double CL_SELL_RATE { get; set; }
        public string CL_COMMENT { get; set; }
        public string CL_SALES_ID { get; set; }
        public string CL_BANK_ID { get; set; }
        public string CL_DOC_REF { get; set; }
        public string CL_SERIE_REF { get; set; }
        public string CL_NUM_REF { get; set; }
        public string CL_BANK_BUSSINESS { get; set; }
        public string CL_ACCOUNT_BANK_CHECK { get; set; }
        public string CL_PAYMENT_METHOD { get; set; }
        public string CL_OPT_AN { get; set; }
        public DateTime CL_DATE_REF { get; set; }
    }

}
