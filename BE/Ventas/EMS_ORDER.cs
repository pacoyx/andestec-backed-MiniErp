using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace BE.Ventas
{
    public class EMS_ORDER
    {
        public EMS_ORDERCAB Cabecera { get; set; }
        public List<EMS_ORDERDET> Detalle { get; set; }
    }
}
