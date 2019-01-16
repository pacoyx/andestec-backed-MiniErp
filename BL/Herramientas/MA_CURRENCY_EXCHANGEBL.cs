using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE.Herramientas;
using DA.Herramientas;

namespace BL.Herramientas
{
    public class MA_CURRENCY_EXCHANGEBL
    {
        public string Registrar(EMA_CURRENCY_EXCHANGE ee) { return MA_CURRENCY_EXCHANGEDA.Insert(ee); }
        public string Actualizar(EMA_CURRENCY_EXCHANGE ee) { return MA_CURRENCY_EXCHANGEDA.Update(ee); }
        public string Eliminar(EMA_CURRENCY_EXCHANGE ee) { return MA_CURRENCY_EXCHANGEDA.Delete(ee); }
        public List<EMA_CURRENCY_EXCHANGE> ListarPorMes(EMA_CURRENCY_EXCHANGE ee) { return MA_CURRENCY_EXCHANGEDA.GetxYearMonth(ee); }
        public EMA_CURRENCY_EXCHANGE ListarxFecha(EMA_CURRENCY_EXCHANGE ee) { return MA_CURRENCY_EXCHANGEDA.GetByDate(ee); }
        
    }

}
