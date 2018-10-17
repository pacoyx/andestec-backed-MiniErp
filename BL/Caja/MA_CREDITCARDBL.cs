using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE.Caja;
using DA.Caja;

namespace BL.Caja
{
    public class MA_CREDITCARDBL
    {
        public string Registrar(EMA_CREDITCARD ee) { if ( MA_CREDITCARDDA.GetByid(ee) == null) {return MA_CREDITCARDDA.Insert(ee); } else {return MA_CREDITCARDDA.Update(ee); } }
        public string Eliminar(EMA_CREDITCARD ee) {return MA_CREDITCARDDA.Delete(ee); }
        public List<EMA_CREDITCARD> Listar(EMA_CREDITCARD ee) { return MA_CREDITCARDDA.GetAll(ee); }        
        public EMA_CREDITCARD ListarxId(EMA_CREDITCARD ee) => MA_CREDITCARDDA.GetByid(ee);
    }
}
