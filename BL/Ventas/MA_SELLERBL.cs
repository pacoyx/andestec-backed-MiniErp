using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE.Ventas;
using DA.Ventas;

namespace BL.Ventas
{
    public class MA_SELLERBL
    {
        public void Registrar(EMA_SELLER ee) { if (MA_SELLERDA.GetByid(ee) == null) { MA_SELLERDA.Insert(ee); } else { MA_SELLERDA.Update(ee); } }
        public void Eliminar(EMA_SELLER ee) { MA_SELLERDA.Delete(ee); }
        public List<EMA_SELLER> Listar(EMA_SELLER ee) { return MA_SELLERDA.GetAll(ee); }
        public EMA_SELLER ListarxId(EMA_SELLER ee) => MA_SELLERDA.GetByid(ee);
    }
}
