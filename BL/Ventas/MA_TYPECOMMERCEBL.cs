using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE.Ventas;
using DA.Ventas;

namespace BL.Ventas
{
    public class MA_TYPECOMMERCEBL
    {
        public string Registrar(EMA_TYPECOMMERCE ee) { if (MA_TYPECOMMERCEDA.GetByid(ee) == null) {return MA_TYPECOMMERCEDA.Insert(ee); } else {return MA_TYPECOMMERCEDA.Update(ee); } }
        public string Eliminar(EMA_TYPECOMMERCE ee) { return MA_TYPECOMMERCEDA.Delete(ee); }
        public List<EMA_TYPECOMMERCE> Listar(EMA_TYPECOMMERCE ee) { return MA_TYPECOMMERCEDA.GetAll(ee); }
        public EMA_TYPECOMMERCE ListarxId(EMA_TYPECOMMERCE ee) => MA_TYPECOMMERCEDA.GetByid(ee);
    }
}
