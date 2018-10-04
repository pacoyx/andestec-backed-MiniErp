using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE.Caja;
using DA.Caja;

namespace BL.Caja
{
    public class CA_TRANSCOLLECTIONBL
    {
        public void Registrar(ECA_TRANSCOLLECTION ee) { if (CA_TRANSCOLLECTIONDA.GetByid(ee) == null) { CA_TRANSCOLLECTIONDA.Insert(ee); } else { CA_TRANSCOLLECTIONDA.Update(ee); } }
        public void Eliminar(ECA_TRANSCOLLECTION ee) { CA_TRANSCOLLECTIONDA.Delete(ee); }
        public List<ECA_TRANSCOLLECTION> Listar(ECA_TRANSCOLLECTION ee) { return CA_TRANSCOLLECTIONDA.GetAll(ee); }
        public ECA_TRANSCOLLECTION ListarxId(ECA_TRANSCOLLECTION ee) => CA_TRANSCOLLECTIONDA.GetByid(ee);
    }
}
