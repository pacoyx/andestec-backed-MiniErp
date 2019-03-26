using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE.Ventas;
using DA.Ventas;

namespace BL.Ventas
{
    public class MA_TYPEPRICEBL
    {
        public string Registrar(EMA_TYPEPRICE ee) { if (MA_TYPEPRICEDA.GetByid(ee) == null) {return MA_TYPEPRICEDA.Insert(ee); } else {return MA_TYPEPRICEDA.Update(ee); } }
        public string RegistrarArticuloTP(EMA_TIPPREDETALLE ee)
        {
            return MA_TYPEPRICEDA.InsertArticuloTP(ee);
        }
            public string Eliminar(EMA_TYPEPRICE ee) { return MA_TYPEPRICEDA.Delete(ee); }
        public List<EMA_TYPEPRICE> Listar(EMA_TYPEPRICE ee) { return MA_TYPEPRICEDA.GetAll(ee); }
        public EMA_TYPEPRICE ListarxId(EMA_TYPEPRICE ee) => MA_TYPEPRICEDA.GetByid(ee);
        public List<EMA_ARTICULOTP> ListarArticulosxTP(EMA_TYPEPRICE ee) { return MA_TYPEPRICEDA.GetArticulosxTP(ee); }
        public EMA_ARTICULOTP ListarTipoPrecioxId(EMA_TYPEPRICE ee) => MA_TYPEPRICEDA.GetTipoPrecioByid(ee);
    }
}
