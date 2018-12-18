using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE.Almacen;
using DA.Almacen;

namespace BL.Almacen
{
    public class MA_WAREHOUSEBL
    {
        public string Registrar(EMA_WAREHOUSE ee) { if (MA_WAREHOUSEDA.GetByid(ee) == null) {return MA_WAREHOUSEDA.Insert(ee); } else { return MA_WAREHOUSEDA.Update(ee); } }
        public string Eliminar(EMA_WAREHOUSE ee) { return MA_WAREHOUSEDA.Delete(ee); }
        public List<EMA_WAREHOUSE> Listar(EMA_WAREHOUSE ee) { return MA_WAREHOUSEDA.GetAll(ee); }
        public EMA_WAREHOUSE ListarxId(EMA_WAREHOUSE ee) => MA_WAREHOUSEDA.GetByid(ee);
    }
}
