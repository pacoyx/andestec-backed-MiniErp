using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE.Ventas;
using DA.Ventas;

namespace BL.Ventas
{
    public class MA_DOCUMENTSBL
    {
        public string Registrar(EMA_DOCUMENTS ee) { if (MA_DOCUMENTSDA.GetByid(ee) == null) {return MA_DOCUMENTSDA.Insert(ee); } else { return MA_DOCUMENTSDA.Update(ee); } }
        public string Eliminar(EMA_DOCUMENTS ee) {return MA_DOCUMENTSDA.Delete(ee); }
        public List<EMA_DOCUMENTS> Listar(EMA_DOCUMENTS ee) { return MA_DOCUMENTSDA.GetAll(ee); }
        public EMA_DOCUMENTS ListarxId(EMA_DOCUMENTS ee) => MA_DOCUMENTSDA.GetByid(ee);
    }
}
