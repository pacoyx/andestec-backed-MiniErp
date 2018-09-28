using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE.Almacen;
using DA.Almacen;

namespace BL.Almacen
{
    public class MA_CUSTOMERBL
    {
        public void Registrar(EMA_CUSTOMER ee) { if (MA_CUSTOMERDA.GetByid(ee) == null) { MA_CUSTOMERDA.Insert(ee); } else { MA_CUSTOMERDA.Update(ee); } }
        public void Eliminar(EMA_CUSTOMER ee) { MA_CUSTOMERDA.Delete(ee); }
        public List<EMA_CUSTOMER> Listar(EMA_CUSTOMER ee) { return MA_CUSTOMERDA.GetAll(ee); }
        public EMA_CUSTOMER ListarxId(EMA_CUSTOMER ee) => MA_CUSTOMERDA.GetByid(ee);
        public List<EMA_CUSTOMER> ListarPorNombre(EMA_CUSTOMER ee)
        {
            return MA_CUSTOMERDA.GetAll(ee).Where(p => p.DESCRIPTION_CUSTOMER.Contains(ee.DESCRIPTION_CUSTOMER)).ToList();
        }
    }
}
