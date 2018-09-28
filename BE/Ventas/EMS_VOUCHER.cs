using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace BE.Ventas
{
    public class EMS_VOUCHER
    {
        public EMS_VOUCHERHE Cabecera { get; set; }

        public List<EMS_VOUCHERDE> Detalle { get; set; }
    }
}
