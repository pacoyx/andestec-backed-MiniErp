using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Ventas
{
    public class ERE_VISTAPEDIDODET
    {
        public int IDORDER { get; set; }
        public int ITEM { get; set; }
        public int IDARTICULO { get; set; }
        public string ARTICULO { get; set; }
        public string UNIDAD { get; set; }
        public double CANTIDAD { get; set; }
        public double PRECIO { get; set; }
        public double TOTAL { get; set; }
        public string ESTADO { get; set; }
        public double CANTIDADDES { get; set; }
        public string ESLOTE { get; set; }
        public double IVA { get; set; }
    }
}
