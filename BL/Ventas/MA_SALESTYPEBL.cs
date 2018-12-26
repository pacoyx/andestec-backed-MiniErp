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
        public string Registrar(EMA_SALESTYPE ee) { if (MA_SALESTYPEDA.GetByid(ee) == null) {return MA_SALESTYPEDA.Insert(ee); } else { return MA_SALESTYPEDA.Update(ee); } }
        public string Eliminar(EMA_SALESTYPE ee) { return MA_SALESTYPEDA.Delete(ee); }
        public List<EMA_SALESTYPE> Listar(EMA_SALESTYPE ee) { return MA_SALESTYPEDA.GetAll(ee); }
        public EMA_SALESTYPE ListarxId(EMA_SALESTYPE ee) => MA_SALESTYPEDA.GetByid(ee);
    }
}
