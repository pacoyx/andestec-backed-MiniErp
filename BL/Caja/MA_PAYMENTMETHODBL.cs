using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE.Caja;
using DA.Caja;

namespace BL.Caja
{
    public class MA_PAYMENTMETHODBL
    {
        public string Registrar(EMA_PAYMENTMETHOD ee) { if (MA_PAYMENTMETHODDA.GetByid(ee) == null) { return MA_PAYMENTMETHODDA.Insert(ee); } else { return MA_PAYMENTMETHODDA.Update(ee); } }
        public string Eliminar(EMA_PAYMENTMETHOD ee) { return MA_PAYMENTMETHODDA.Delete(ee); }
        public List<EMA_PAYMENTMETHOD> Listar(EMA_PAYMENTMETHOD ee) { return MA_PAYMENTMETHODDA.GetAll(ee); }
        public EMA_PAYMENTMETHOD ListarxId(EMA_PAYMENTMETHOD ee) => MA_PAYMENTMETHODDA.GetByid(ee);
    }
}
