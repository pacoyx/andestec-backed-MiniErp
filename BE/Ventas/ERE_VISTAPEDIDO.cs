using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Ventas
{
    public class ERE_VISTAPEDIDO
    {
        public ERE_VISTAPEDIDOCAB Cabecera { get; set; }
        public List<ERE_VISTAPEDIDODET> Detalle { get; set; }
    }
}
