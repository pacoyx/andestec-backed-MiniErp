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
        public string Registrar(EMA_FAMILY ee) { if (MA_FAMILYDA.GetByid(ee) == null) { return MA_FAMILYDA.Insert(ee); } else { return MA_FAMILYDA.Update(ee); } }
        public string Eliminar(EMA_FAMILY ee) { return MA_FAMILYDA.Delete(ee); }
        public List<EMA_FAMILY> Listar(EMA_FAMILY ee) { return MA_FAMILYDA.GetAll(ee); } 
        public EMA_FAMILY ListarxId(EMA_FAMILY ee) => MA_FAMILYDA.GetByid(ee);
    }
}
