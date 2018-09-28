using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE.Ventas;
using DA.Ventas;

namespace BL.Ventas
{
    public class MA_SALESTYPEBL
    {
        public void Registrar(EMA_SALESTYPE ee) { if (MA_SALESTYPEDA.GetByid(ee) == null) { MA_SALESTYPEDA.Insert(ee); } else { MA_SALESTYPEDA.Update(ee); } }
        public void Eliminar(EMA_SALESTYPE ee) { MA_SALESTYPEDA.Delete(ee); }
        public List<EMA_SALESTYPE> Listar(EMA_SALESTYPE ee) { return MA_SALESTYPEDA.GetAll(ee); }
        public EMA_SALESTYPE ListarxId(EMA_SALESTYPE ee) => MA_SALESTYPEDA.GetByid(ee);
    }
}
