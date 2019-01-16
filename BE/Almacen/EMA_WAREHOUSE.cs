using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Almacen
{
    public class EMA_WAREHOUSE
    {
        public string ID_WAREHOUSE { get; set; }
        public string DESCRIPCION { get; set; }
        public string DIRECCION { get; set; }
        public int ID_COMPANY { get; set; }
        public int NUMCORRE_I { get; set; }
        public int NUMCORRE_S { get; set; }
    }
}
