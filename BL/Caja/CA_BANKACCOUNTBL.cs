using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE.Caja;
using DA.Caja;

namespace BL.Caja
{
    public class CA_BANKACCOUNTBL
    {
        public void Registrar(ECA_BANKACCOUNT ee) { if (CA_BANKACCOUNTDA.GetByid(ee) == null) { CA_BANKACCOUNTDA.Insert(ee); } else { CA_BANKACCOUNTDA.Update(ee); } }
        public void Eliminar(ECA_BANKACCOUNT ee) { CA_BANKACCOUNTDA.Delete(ee); }
        public List<ECA_BANKACCOUNT> Listar(ECA_BANKACCOUNT ee) { return CA_BANKACCOUNTDA.GetAll(ee); }
        public List<ECA_BANKACCOUNT> ListarxBanco(ECA_BANKACCOUNT ee) { return CA_BANKACCOUNTDA.GetByBank(ee); }
        public ECA_BANKACCOUNT ListarxId(ECA_BANKACCOUNT ee) => CA_BANKACCOUNTDA.GetByid(ee);
    }
}
