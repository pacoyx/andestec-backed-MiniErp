using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE.Caja;
using DA.Caja;

namespace BL.Caja
{
    public class CA_COLLECTORBL
    {
        public void Registrar(ECA_COLLECTOR ee) { if (CA_COLLECTORDA.GetByid(ee) == null) { CA_COLLECTORDA.Insert(ee); } else { CA_COLLECTORDA.Update(ee); } }
        public void Eliminar(ECA_COLLECTOR ee) { CA_COLLECTORDA.Delete(ee); }
        public List<ECA_COLLECTOR> Listar(ECA_COLLECTOR ee) { return CA_COLLECTORDA.GetAll(ee); }
        public ECA_COLLECTOR ListarxId(ECA_COLLECTOR ee) => CA_COLLECTORDA.GetByid(ee);
    }
}
