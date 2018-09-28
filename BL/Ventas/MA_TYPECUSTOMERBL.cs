using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE.Ventas;
using DA.Ventas;

namespace BL.Ventas
{
    public class MA_TYPECUSTOMERBL
    {
        public void Registrar(EMA_TYPECUSTOMER ee) { if (MA_TYPECUSTOMERDA.GetByid(ee) == null) { MA_TYPECUSTOMERDA.Insert(ee); } else { MA_TYPECUSTOMERDA.Update(ee); } }
        public void Eliminar(EMA_TYPECUSTOMER ee) { MA_TYPECUSTOMERDA.Delete(ee); }
        public List<EMA_TYPECUSTOMER> Listar(EMA_TYPECUSTOMER ee) { return MA_TYPECUSTOMERDA.GetAll(ee); }
        public EMA_TYPECUSTOMER ListarxId(EMA_TYPECUSTOMER ee) => MA_TYPECUSTOMERDA.GetByid(ee);
    }
}
