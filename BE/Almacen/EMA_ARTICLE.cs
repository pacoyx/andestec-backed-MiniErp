using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Almacen
{
    public class EMA_ARTICLE
    {
        public int ID_ARTICLE { get; set; }
        public int ID_COMPANY { get; set; }
        public int ID_COMMODITY_TYPE { get; set; }
        public string ID_UNIT { get; set; }
        public int ID_FAMILY { get; set; }
        public int ID_FAMILY_SUB { get; set; }
        public int SKU_ARTICLE { get; set; }        
        public string DESCRIPTION_ARTICLE { get; set; }
        public string COMMERCIAL_NAME { get; set; }
        public string TECHNICAL_NAME { get; set; }
        public string SIZE { get; set; }
        public string COLORS { get; set; }
        public string BRAND { get; set; }
        public string MODEL { get; set; }
        public string AIMAGE { get; set; }
        public string DATA_SHEET { get; set; }
        public string AUSUARIO { get; set; }
        public string AFECREG { get; set; }
        public string AMODIFICO { get; set; }
        public string AFECMOD { get; set; }
        public string AISSERVICE { get; set; }
    }
}
