using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Almacen
{
    public class ETRA_WAREHOUSE_LINE
    {
        public int ID_COMPANY { get; set; }
        public int ID_TRANSACTION_WAREHOUSE_LINE { get; set; }
        public string ID_WAREHOUSE { get; set; }
        public int ITEM { get; set; }
        public int ID_ARTICLE { get; set; }
        public string DESCRIPTION_ARTICLE { get; set; }
        public string LOT { get; set; }
        public string SERIE { get; set; }
        public int QTY { get; set; }
        public double COST { get; set; }
        public string COMMENT { get; set; }
        public int ISTATUS { get; set; }
        public string AUSUARIO { get; set; }
        public string AFECREG { get; set; }
        public string AMODIFICO { get; set; }
        public string AFECMOD { get; set; }
    }
}
