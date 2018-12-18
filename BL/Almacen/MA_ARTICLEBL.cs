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
        public string Registrar(EMA_ARTICLE ee) { if (MA_ARTICLEDA.GetByid(ee) == null) { return MA_ARTICLEDA.Insert(ee); } else { return MA_ARTICLEDA.Update(ee); } }
        public string Eliminar(EMA_ARTICLE ee) { return MA_ARTICLEDA.Delete(ee); }
        public List<EMA_ARTICLE> Listar(EMA_ARTICLE ee) { return MA_ARTICLEDA.GetAll(ee); }
        public EMA_ARTICLE ListarxId(EMA_ARTICLE ee) => MA_ARTICLEDA.GetByid(ee);
        public List<EMA_ARTICLE> ListarxNombre(EMA_ARTICLE ee)
        {
            if (ee.DESCRIPTION_ARTICLE == "9z")
            {
                return MA_ARTICLEDA.GetAll(ee).OrderBy(x => x.DESCRIPTION_ARTICLE).ToList();
            }
            else
            {
                return MA_ARTICLEDA.GetAll(ee).Where(p => p.DESCRIPTION_ARTICLE.ToLower().
                Contains(ee.DESCRIPTION_ARTICLE.ToLower())).OrderBy(x => x.DESCRIPTION_ARTICLE).ToList();
            }
        }
        public List<EMA_ARTICLE> ListarxNombreLotes(EMA_ARTICLE ee)
        {
            if (ee.DESCRIPTION_ARTICLE == "9z")
            {
                return MA_ARTICLEDA.GetAll(ee).Where(y=> y.SKU_ARTICLE == "1").OrderBy(x => x.DESCRIPTION_ARTICLE).ToList();
            }
            else
            {
                return MA_ARTICLEDA.GetAll(ee).Where(p => p.DESCRIPTION_ARTICLE.ToLower().
                Contains(ee.DESCRIPTION_ARTICLE.ToLower())).Where(y => y.SKU_ARTICLE == "1").OrderBy(x => x.DESCRIPTION_ARTICLE).ToList();
            }
        }

    }
}
