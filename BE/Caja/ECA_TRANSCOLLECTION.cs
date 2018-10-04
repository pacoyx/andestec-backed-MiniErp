using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Caja
{
   public class ECA_TRANSCOLLECTION
    {
        public string TC_IDTRANSCOLLECTION { get; set; }
        public string TC_DESCRIPTION { get; set; }
        public string TC_IDCURRENCY { get; set; }
        public string TC_TYPECASH { get; set; }
        public string TC_TYPEDEPOSIT { get; set; }
        public string TC_TYPEAPPDPOC { get; set; }
        public string TC_TYPEPROVIDER { get; set; }
        public string TC_TYPECARD { get; set; }
        public string TC_ISTATUS { get; set; }
        public int TC_IDCOMPANY { get; set; }
    }

}
