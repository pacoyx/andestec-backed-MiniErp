using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE.Ventas;
using DA.Ventas;

namespace BL.Ventas
{
    public class MA_SALESPOINTBL
    {
        public void Registrar(EMA_SALESPOINT ee) { if (MA_SALESPOINTDA.GetByid(ee) == null) { MA_SALESPOINTDA.Insert(ee); } else { MA_SALESPOINTDA.Update(ee); } }
        public void Eliminar(EMA_SALESPOINT ee) { MA_SALESPOINTDA.Delete(ee); }
        public List<EMA_SALESPOINT> Listar(EMA_SALESPOINT ee) { return MA_SALESPOINTDA.GetAll(ee); }
        public EMA_SALESPOINT ListarxId(EMA_SALESPOINT ee) => MA_SALESPOINTDA.GetByid(ee);
    }
}
