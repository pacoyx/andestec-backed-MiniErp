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
    [RoutePrefix("MA_CREDITCARD")]
    public class MA_CREDITCARDController : ApiController
    {
        MA_CREDITCARDBL negocio = new MA_CREDITCARDBL();
        [HttpGet, Route("{ide}")]
        public IEnumerable<EMA_CREDITCARD> Get(int ide)
        {
            return negocio.Listar(new EMA_CREDITCARD { CC_IDCOMPANY = ide });
        }

        [HttpGet, Route("{ide}/{id}")]
        public EMA_CREDITCARD Get(int ide, string id)
        {
            return negocio.ListarxId(new EMA_CREDITCARD { CC_ID = id, CC_IDCOMPANY = ide });
        }

        [HttpPost, Route("")]
        public string Post([FromBody]EMA_CREDITCARD value)
        {
            return negocio.Registrar(value);
        }

        [HttpDelete, Route("{ide}/{id}")]
        public string Delete(int ide, string id)
        {
            return negocio.Eliminar(new EMA_CREDITCARD { CC_ID = id, CC_IDCOMPANY = ide });
        }
    }
}
