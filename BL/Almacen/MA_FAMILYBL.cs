using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE.Almacen;
using DA.Almacen;

namespace BL.Almacen
{
    public class MA_FAMILYBL
    {
        public void Registrar(EMA_FAMILY ee) { if (MA_FAMILYDA.GetByid(ee) == null) { MA_FAMILYDA.Insert(ee); } else { MA_FAMILYDA.Update(ee); } }
        public void Eliminar(EMA_FAMILY ee) { MA_FAMILYDA.Delete(ee); }
        public List<EMA_FAMILY> Listar(EMA_FAMILY ee) { return MA_FAMILYDA.GetAll(ee); } 
        public EMA_FAMILY ListarxId(EMA_FAMILY ee) => MA_FAMILYDA.GetByid(ee);
    }
}
