using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE.Almacen;
using DA.Almacen;

namespace BL.Almacen
{
    public class MA_ARTICLEBL
    {
        public void Registrar(EMA_ARTICLE ee) { if (MA_ARTICLEDA.GetByid(ee) == null) { MA_ARTICLEDA.Insert(ee); } else { MA_ARTICLEDA.Update(ee); } }
        public void Eliminar(EMA_ARTICLE ee) { MA_ARTICLEDA.Delete(ee); }
        public List<EMA_ARTICLE> Listar(EMA_ARTICLE ee) { return MA_ARTICLEDA.GetAll(ee); }
        public EMA_ARTICLE ListarxId(EMA_ARTICLE ee) => MA_ARTICLEDA.GetByid(ee);
        public List<EMA_ARTICLE> ListarxNombre(EMA_ARTICLE ee)
        {
            if (ee.DESCRIPTION_ARTICLE == "@")
            {
                return MA_ARTICLEDA.GetAll(ee);
            }
            else {
                return MA_ARTICLEDA.GetAll(ee).Where(p => p.DESCRIPTION_ARTICLE.Contains(ee.DESCRIPTION_ARTICLE)).ToList();
            }
        }
        
    }
}
