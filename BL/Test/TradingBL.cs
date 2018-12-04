using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE.Test;
using DA.Test;

namespace BL.Test
{
    public class TradingBL
    {
        public string Registrar(TRADING ee) { if (TradingDA.GetByid(ee) == null) { return TradingDA.Insert(ee); } else { return TradingDA.Update(ee); } }
        public string Eliminar(TRADING ee) { return TradingDA.Delete(ee); }
        public List<TRADING> Listar() { return TradingDA.GetAll(); }
        public TRADING ListarxId(TRADING ee) => TradingDA.GetByid(ee);
    }
}
