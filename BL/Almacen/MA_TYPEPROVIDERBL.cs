using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE.Almacen;
using DA.Almacen;

namespace BL.Almacen
{
    public class MA_TYPEPROVIDERBL
    {
        public void Registrar(EMA_TYPEPROVIDER ee) { if (MA_TYPEPROVIDERDA.GetByid(ee) == null) { MA_TYPEPROVIDERDA.Insert(ee); } else { MA_TYPEPROVIDERDA.Update(ee); } }
        public void Eliminar(EMA_TYPEPROVIDER ee) { MA_TYPEPROVIDERDA.Delete(ee); }
        public List<EMA_TYPEPROVIDER> Listar(EMA_TYPEPROVIDER ee) { return MA_TYPEPROVIDERDA.GetAll(ee); }
        public EMA_TYPEPROVIDER ListarxId(EMA_TYPEPROVIDER ee) => MA_TYPEPROVIDERDA.GetByid(ee);
    }
}
