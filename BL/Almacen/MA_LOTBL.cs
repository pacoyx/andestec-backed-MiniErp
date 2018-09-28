using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE.Almacen;
using DA.Almacen;

namespace BL.Almacen
{
    public class MA_LOTBL
    {
        public void Registrar(EMA_LOT ee) { if (MA_LOTDA.GetByid(ee) == null) { MA_LOTDA.Insert(ee); } else { MA_LOTDA.Update(ee); } }
        public void Eliminar(EMA_LOT ee) { MA_LOTDA.Delete(ee); }
        public List<EMA_LOT> Listar(EMA_LOT ee) { return MA_LOTDA.GetAll(ee); }
        public List<EMA_LOT> ListarxIdArticulo(EMA_LOT ee) { return MA_LOTDA.GetByidArticulo(ee); }
        public EMA_LOT ListarxId(EMA_LOT ee) => MA_LOTDA.GetByid(ee);
    }
}
