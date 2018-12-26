using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE.Almacen;
using DA.Almacen;

namespace BL.Almacen
{
    public class MA_COMMODITY_TYPEBL
    {
        public string Registrar(EMA_COMMODITY_TYPE ee) { if (MA_COMMODITY_TYPEDA.GetByid(ee) == null) { return MA_COMMODITY_TYPEDA.Insert(ee); } else { return MA_COMMODITY_TYPEDA.Update(ee); } }
        public string Eliminar(EMA_COMMODITY_TYPE ee) { return MA_COMMODITY_TYPEDA.Delete(ee); }
        public List<EMA_COMMODITY_TYPE> Listar(EMA_COMMODITY_TYPE ee) { return MA_COMMODITY_TYPEDA.GetAll(ee); }
        public EMA_COMMODITY_TYPE ListarxId(EMA_COMMODITY_TYPE ee) => MA_COMMODITY_TYPEDA.GetByid(ee);
    }
}
