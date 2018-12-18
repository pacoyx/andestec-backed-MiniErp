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
        public string Registrar(EMA_UNITS ee) { if (MA_UNITSDA.GetByid(ee) == null) {return MA_UNITSDA.Insert(ee); } else { return MA_UNITSDA.Update(ee); } }
        public string Eliminar(EMA_UNITS ee) { return MA_UNITSDA.Delete(ee); }
        public List<EMA_UNITS> Listar(EMA_UNITS ee) { return MA_UNITSDA.GetAll(ee); }
        public EMA_UNITS ListarxId(EMA_UNITS ee) => MA_UNITSDA.GetByid(ee);
    }
}
