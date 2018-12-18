using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Ventas
{
    public class EMS_VOUCHERHE
    {
        public int VH_IDVOUCHER { get; set; }
        public string VH_TDOC { get; set; }
        public string VH_SDOC { get; set; }
        public int VH_NDOC { get; set; }
        public int VH_IDORDER { get; set; }
        public int VH_IDGUIDE { get; set; }
        public string VH_GSSER { get; set; }
        public string VH_GSNUM { get; set; }
        public string VH_VOUCHERDATE { get; set; }
        public string VH_DELIVERDATE { get; set; }
        public string VH_IDSELLER { get; set; }
        public string VH_IDCURRENCY { get; set; }
        public int VH_IDCUSTOMER { get; set; }
        public string VH_DELIVERYADD { get; set; }
        public string VH_IDPAYMENTTYPE { get; set; }
        public int VH_IDCENCOST { get; set; }
        public string VH_IDPROJECT { get; set; }
        public string VH_IDSALESTYPE { get; set; }
        public string VH_IDWILCARD { get; set; }
        public string VH_COMMENT { get; set; }
        public string VH_ISTATUS { get; set; }
        public string VH_ACTIVE { get; set; }
        public string VH_AUSUARIO { get; set; }
        public string VH_AFECREG { get; set; }
        public string VH_AMODIFICO { get; set; }
        public string VH_AFECMOD { get; set; }
        public int VH_IDCOMPANY { get; set; }
        public string VH_ISCASHCARD { get; set; }
        public string VH_CARDTYPE { get; set; }
        public string VH_OPENUMCARD { get; set; }
        public double VH_PAYAMOUNT { get; set; }
        public double VH_CHANGEAMOUNT { get; set; }
        public double VH_SUBTOT { get; set; }
        public double VH_TAX { get; set; }
        public double VH_TOT { get; set; }
        public string VH_IDSALESPOINT { get; set; }
    }
}
