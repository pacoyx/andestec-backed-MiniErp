using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE.Ventas;
using DA.Ventas;

namespace BL.Ventas
{
    public class MA_PAYMENTTYPEBL
    {
        public string Registrar(EMA_PAYMENTTYPE ee) { if (MA_PAYMENTTYPEDA.GetByid(ee) == null) {return MA_PAYMENTTYPEDA.Insert(ee); } else { return MA_PAYMENTTYPEDA.Update(ee); } }
        public string Eliminar(EMA_PAYMENTTYPE ee) { return MA_PAYMENTTYPEDA.Delete(ee); }
        public List<EMA_PAYMENTTYPE> Listar(EMA_PAYMENTTYPE ee) { return MA_PAYMENTTYPEDA.GetAll(ee); }
        public EMA_PAYMENTTYPE ListarxId(EMA_PAYMENTTYPE ee) => MA_PAYMENTTYPEDA.GetByid(ee);
    }
}
