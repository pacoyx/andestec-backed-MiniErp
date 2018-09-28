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
        public void Registrar(EMA_DOCUMENTS ee) { if (MA_DOCUMENTSDA.GetByid(ee) == null) { MA_DOCUMENTSDA.Insert(ee); } else { MA_DOCUMENTSDA.Update(ee); } }
        public void Eliminar(EMA_DOCUMENTS ee) { MA_DOCUMENTSDA.Delete(ee); }
        public List<EMA_DOCUMENTS> Listar(EMA_DOCUMENTS ee) { return MA_DOCUMENTSDA.GetAll(ee); }
        public EMA_DOCUMENTS ListarxId(EMA_DOCUMENTS ee) => MA_DOCUMENTSDA.GetByid(ee);
    }
}
