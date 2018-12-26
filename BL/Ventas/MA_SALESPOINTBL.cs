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
        public string Registrar(EMA_SALESPOINT ee) { if (MA_SALESPOINTDA.GetByid(ee) == null) {return MA_SALESPOINTDA.Insert(ee); } else { return MA_SALESPOINTDA.Update(ee); } }
        public string Eliminar(EMA_SALESPOINT ee) { return MA_SALESPOINTDA.Delete(ee); }
        public List<EMA_SALESPOINT> Listar(EMA_SALESPOINT ee) { return MA_SALESPOINTDA.GetAll(ee); }
        public EMA_SALESPOINT ListarxId(EMA_SALESPOINT ee) => MA_SALESPOINTDA.GetByid(ee);
    }
}
