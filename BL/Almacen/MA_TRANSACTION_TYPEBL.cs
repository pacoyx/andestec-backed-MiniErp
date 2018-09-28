using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE.Almacen;
using DA.Almacen;

namespace BL.Almacen
{
    public class MA_TRANSACTION_TYPEBL
    {
        public void Registrar(EMA_TRANSACTION_TYPE ee) { if (MA_TRANSACTION_TYPEDA.GetByid(ee) == null) { MA_TRANSACTION_TYPEDA.Insert(ee); } else { MA_TRANSACTION_TYPEDA.Update(ee); } }
        public void Eliminar(EMA_TRANSACTION_TYPE ee) { MA_TRANSACTION_TYPEDA.Delete(ee); }
        public List<EMA_TRANSACTION_TYPE> Listar(EMA_TRANSACTION_TYPE ee) { return MA_TRANSACTION_TYPEDA.GetAll(ee); }
        public EMA_TRANSACTION_TYPE ListarxId(EMA_TRANSACTION_TYPE ee) => MA_TRANSACTION_TYPEDA.GetByid(ee);
        public List<EMA_TRANSACTION_TYPE> ListarxTipo(EMA_TRANSACTION_TYPE ee)
        {
            return MA_TRANSACTION_TYPEDA.GetAll(ee).Where(p => p.TT_INGSAL == ee.TT_INGSAL).ToList();
        }
    }
}
