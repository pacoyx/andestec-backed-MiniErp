using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE.Caja;
using DA.Caja;

namespace BL.Caja
{
    public class CA_COLLECTION_LINEBL
    {
        public string Registrar(List<ECA_COLLECTION_LINE> ee) { return CA_COLLECTION_LINEDA.Insert(ee); }
        public List<EPLANILLADET> ListarPlanillaDetalle(int emp,int idpla) { return CA_COLLECTION_LINEDA.GetPlanillaDetalle(emp, idpla); }
    }
}
