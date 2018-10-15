using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE.Caja;
using DA.Caja;

namespace BL.Caja
{
    public class CA_COLLECTIONBL
    {
        public Int64 Registrar(ECA_COLLECTION ee) { return CA_COLLECTIONDA.Insert(ee); }
        public List<ECA_COLLECTION> Listar(ECA_COLLECTION ee) { return CA_COLLECTIONDA.GetAll(ee); }
    }
}
