using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using BE.Caja;
using BL.Caja;


namespace WA_AndesTec.Controllers
{
    [EnableCors("*", "*", "*")]
    [RoutePrefix("CA_CUSTOM_BALANCE")]
    public class CA_CUSTOM_BALANCEController : ApiController
    {
        CA_CUSTOM_BALANCEBL negocio = new CA_CUSTOM_BALANCEBL();

        [HttpGet, Route("{ide}/{idcli}")]
        public IEnumerable<ECA_CUSTOM_BALANCE>Get(int ide, int idcli)
        {
            return negocio.ListarGetCarteraPorCliente(new ECA_CUSTOM_BALANCE { CM_CUSTOMER_ID = idcli, CM_IDCOMPANY = ide });
        }

    }
}
