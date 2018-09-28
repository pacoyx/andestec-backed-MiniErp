using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Ventas
{
    public class ERE_LISTADOCOMPROBANTE
    {
        public int IDCOMPRO { get; set; }
        public string NUMERO { get; set; }
        public string FECHAEMI { get; set; }
        public string FECHAENT { get; set; }
        public string CLIENTE { get; set; }
        public string GLOSA { get; set; }
        public string ESTADO { get; set; }
    }
}
