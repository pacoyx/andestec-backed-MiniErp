using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Ventas
{
    public class ERE_VISTACOMPROBANTE
    {
        public ERE_VISTACOMPROBANTECAB Cabecera { get; set; }
        public List<ERE_VISTACOMPROBANTEDET> Detalle { get; set; }
    }
}
