using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE.Ventas;
using DA.Ventas;

namespace BL.Ventas
{
    public class MA_PROJECTBL
    {
        public void Registrar(EMA_PROJECT ee) { if (MA_PROJECTDA.GetByid(ee) == null) { MA_PROJECTDA.Insert(ee); } else { MA_PROJECTDA.Update(ee); } }
        public void Eliminar(EMA_PROJECT ee) { MA_PROJECTDA.Delete(ee); }
        public List<EMA_PROJECT> Listar(EMA_PROJECT ee) { return MA_PROJECTDA.GetAll(ee); }
        public EMA_PROJECT ListarxId(EMA_PROJECT ee) => MA_PROJECTDA.GetByid(ee);
    }
}
