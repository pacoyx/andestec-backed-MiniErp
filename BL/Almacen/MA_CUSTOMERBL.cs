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
        public string Registrar(EMA_CUSTOMER ee) { if (MA_CUSTOMERDA.GetByid(ee) == null) {return MA_CUSTOMERDA.Insert(ee); } else {return MA_CUSTOMERDA.Update(ee); } }
        public string Eliminar(EMA_CUSTOMER ee) {return MA_CUSTOMERDA.Delete(ee); }
        public List<EMA_CUSTOMER> Listar(EMA_CUSTOMER ee) { return MA_CUSTOMERDA.GetAll(ee); }
        public EMA_CUSTOMER ListarxId(EMA_CUSTOMER ee) => MA_CUSTOMERDA.GetByid(ee);
        public List<EMA_CUSTOMER> ListarPorNombre(EMA_CUSTOMER ee)
        {
            if (ee.DESCRIPTION_CUSTOMER == "9z")
            {
                return MA_CUSTOMERDA.GetAll(ee).ToList();
            }
            else {
                return MA_CUSTOMERDA.GetAll(ee).Where(p => p.DESCRIPTION_CUSTOMER.ToLower().
                Contains(ee.DESCRIPTION_CUSTOMER.ToLower())).OrderBy(x => x.DESCRIPTION_CUSTOMER).ToList();
            }
            
        }

        public EMA_CUSTOMER ListarPorDocumento(EMA_CUSTOMER ee)
        {
            if (ee.NUMBER_DOCUMENT == "9z")
            {
                return MA_CUSTOMERDA.GetByid(ee);
            }
            else
            {
                return MA_CUSTOMERDA.GetAll(ee).Where(p => p.NUMBER_DOCUMENT.ToLower().
                Equals(ee.NUMBER_DOCUMENT.ToLower())).SingleOrDefault();
                
            }

        }
    }
}
