using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Herramientas
{
    public class EMA_CURRENCY_EXCHANGE
    {
        public string CHANGEDATE { get; set; }
        public string IDCURRENCY { get; set; }
        public double BUY { get; set; }
        public double SELL { get; set; }
        public int IDEMPRESA { get; set; }
    }

}
