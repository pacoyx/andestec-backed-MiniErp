using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace BE.Almacen
{
    public class ETRA_GUIAING
    {
        public ETRA_WAREHOUSE Cabecera { get; set; }
        public List<ETRA_WAREHOUSE_LINE> Detalle { get; set; }
    }
}
