using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE.Almacen;
using DA.Almacen;

namespace BL.Almacen
{
    public class MA_PROVIDERBL
    {
        public void Registrar(EMA_PROVIDER ee) { if (MA_PROVIDERDA.GetByid(ee) == null) { MA_PROVIDERDA.Insert(ee); } else { MA_PROVIDERDA.Update(ee); } }
        public void Eliminar(EMA_PROVIDER ee) { MA_PROVIDERDA.Delete(ee); }
        public List<EMA_PROVIDER> Listar(EMA_PROVIDER ee) { return MA_PROVIDERDA.GetAll(ee); }
        public EMA_PROVIDER ListarxId(EMA_PROVIDER ee) => MA_PROVIDERDA.GetByid(ee);
        public List<EMA_PROVIDER> ListarxPatron(EMA_PROVIDER ee) { return MA_PROVIDERDA.GetAll(ee).Where(p=>p.DESCRIPTION_PROVIDER.Contains(ee.DESCRIPTION_PROVIDER)).ToList(); }
    }
}
