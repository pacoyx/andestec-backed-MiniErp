using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE.Almacen;
using DA.Almacen;


namespace BL.Almacen
{
    public class MA_SERVICESBL
    {
        public void Registrar(EMA_SERVICES ee) { if (MA_SERVICESDA.GetByid(ee) == null) { MA_SERVICESDA.Insert(ee); } else { MA_SERVICESDA.Update(ee); } }
        public void Eliminar(EMA_SERVICES ee) { MA_SERVICESDA.Delete(ee); }
        public List<EMA_SERVICES> Listar(EMA_SERVICES ee) { return MA_SERVICESDA.GetAll(ee); }
        public EMA_SERVICES ListarxId(EMA_SERVICES ee) => MA_SERVICESDA.GetByid(ee);
    }
}
