using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE.Almacen;
using DA.Almacen;


namespace BL.Almacen
{
    public class MA_FAMILY_SUBBL
    {
        public string Registrar(EMA_FAMILY_SUB ee) { if (MA_FAMILY_SUBDA.GetByid(ee) == null) {return MA_FAMILY_SUBDA.Insert(ee); } else { return MA_FAMILY_SUBDA.Update(ee); } }
        public string Eliminar(EMA_FAMILY_SUB ee) { return MA_FAMILY_SUBDA.Delete(ee); }
        public List<EMA_FAMILY_SUB> Listar(EMA_FAMILY_SUB ee) { return MA_FAMILY_SUBDA.GetAll(ee); }
        public EMA_FAMILY_SUB ListarxId(EMA_FAMILY_SUB ee) => MA_FAMILY_SUBDA.GetByid(ee);
        public List<EMA_FAMILY_SUB> ListarxFam(EMA_FAMILY_SUB ee) => MA_FAMILY_SUBDA.GetByFam(ee);
    }
}
