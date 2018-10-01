using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Almacen
{
    public class EMA_PROVIDER
    {
        public int ID_PROVIDER { get; set; }
        public int ID_COMPANY{ get; set; }
        public string DESCRIPTION_PROVIDER { get; set; }
        public string DOCUMENT_TYPE_PROVIDER { get; set; }
        public string NUMBER_DOCUMENT { get; set; }
        public string COMMERCIAL_TYPE { get; set; }
        public string PROVIDER_TYPE { get; set; }
        public string CONTACT { get; set; }
        public string MOVIL_CONTACT { get; set; }
        public string EMAIL { get; set; }
        public string ISTATUS { get; set; }
        public string AUSUARIO { get; set; }
        public string AFECREG { get; set; }
        public string AMODIFICO { get; set; }
        public string AFECMOD { get; set; }
    }
}
