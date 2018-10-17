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
    [RoutePrefix("CA_BANKACCOUNT")]
    public class CA_BANKACCOUNTController : ApiController
    {
        CA_BANKACCOUNTBL negocio = new CA_BANKACCOUNTBL();

        [HttpGet, Route("{ide}")]
        public IEnumerable<ECA_BANKACCOUNT> Get(int ide)
        {
            return negocio.Listar(new ECA_BANKACCOUNT { AB_IDCOMPANY = ide });
        }

        [HttpGet, Route("{ide}/xbanco/{idbanco}")]
        public IEnumerable<ECA_BANKACCOUNT> GetxBanco(int ide,string idbanco)
        {
            return negocio.ListarxBanco(new ECA_BANKACCOUNT {  AB_IDBANK = idbanco, AB_IDCOMPANY = ide });
        }
        
        [HttpGet, Route("{ide}/{id}")]
        public ECA_BANKACCOUNT Get(int ide, int id)
        {
            return negocio.ListarxId(new ECA_BANKACCOUNT { AB_ID = id, AB_IDCOMPANY = ide });
        }

        [HttpPost, Route("")]
        public void Post([FromBody]ECA_BANKACCOUNT value)
        {
            negocio.Registrar(value);
        }

        [HttpDelete, Route("{ide}/{id}")]
        public void Delete(int ide, int id)
        {
            negocio.Eliminar(new ECA_BANKACCOUNT { AB_ID = id, AB_IDCOMPANY = ide });
        }
    }
}
