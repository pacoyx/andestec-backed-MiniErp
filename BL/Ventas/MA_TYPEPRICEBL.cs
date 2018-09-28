using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE.Ventas;
using DA.Ventas;

namespace BL.Ventas
{
    public class MA_TYPEPRICEBL
    {
        public void Registrar(EMA_TYPEPRICE ee) { if (MA_TYPEPRICEDA.GetByid(ee) == null) { MA_TYPEPRICEDA.Insert(ee); } else { MA_TYPEPRICEDA.Update(ee); } }
        public void Eliminar(EMA_TYPEPRICE ee) { MA_TYPEPRICEDA.Delete(ee); }
        public List<EMA_TYPEPRICE> Listar(EMA_TYPEPRICE ee) { return MA_TYPEPRICEDA.GetAll(ee); }
        public EMA_TYPEPRICE ListarxId(EMA_TYPEPRICE ee) => MA_TYPEPRICEDA.GetByid(ee);
    }
}
