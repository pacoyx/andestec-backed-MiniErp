using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE.Caja;
using DA.Caja;

namespace BL.Caja
{
    public class CA_CUSTOM_BALANCEBL
    {
        public List<ECA_CUSTOM_BALANCE> ListarGetCarteraPorCliente(ECA_CUSTOM_BALANCE ee) { return CA_CUSTOM_BALANCEDA.GetCarteraPorCliente(ee); }
    }
}
