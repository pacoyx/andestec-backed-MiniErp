using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE.Almacen;
using DA.Almacen;

namespace BL.Almacen
{
    public class MA_UNITSBL
    {
        public void Registrar(EMA_UNITS ee) { if (MA_UNITSDA.GetByid(ee) == null) { MA_UNITSDA.Insert(ee); } else { MA_UNITSDA.Update(ee); } }
        public void Eliminar(EMA_UNITS ee) { MA_UNITSDA.Delete(ee); }
        public List<EMA_UNITS> Listar(EMA_UNITS ee) { return MA_UNITSDA.GetAll(ee); }
        public EMA_UNITS ListarxId(EMA_UNITS ee) => MA_UNITSDA.GetByid(ee);
    }
}
