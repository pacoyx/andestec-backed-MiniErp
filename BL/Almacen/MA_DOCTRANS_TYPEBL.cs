using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE.Almacen;
using DA.Almacen;

namespace BL.Almacen
{
    public class MA_DOCTRANS_TYPEBL
    {
        public void Registrar(EMA_DOCTRANS_TYPE ee) { if (MA_DOCTRANS_TYPEDA.GetByid(ee) == null) { MA_DOCTRANS_TYPEDA.Insert(ee); } else { MA_DOCTRANS_TYPEDA.Update(ee); } }
        public void Eliminar(EMA_DOCTRANS_TYPE ee) { MA_DOCTRANS_TYPEDA.Delete(ee); }
        public List<EMA_DOCTRANS_TYPE> Listar(EMA_DOCTRANS_TYPE ee) { return MA_DOCTRANS_TYPEDA.GetAll(ee); }
        public EMA_DOCTRANS_TYPE ListarxId(EMA_DOCTRANS_TYPE ee) => MA_DOCTRANS_TYPEDA.GetByid(ee);
    }
}
