using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using BE.Ventas;
using BL.Ventas;

namespace WA_AndesTec.Controllers
{
    [EnableCors("*", "*", "*")]
    [RoutePrefix("MA_SELLER")]
    public class MA_SELLERController : ApiController
    {
        MA_SELLERBL negocio = new MA_SELLERBL();

        [HttpGet, Route("{ide}")]
        public IEnumerable<EMA_SELLER> Get(int ide)
        {
            return negocio.Listar(new EMA_SELLER { SE_IDCOMPANY = ide });
        }

        [HttpGet, Route("{ide}/{id}")]
        public EMA_SELLER Get(int ide, string id)
        {
            return negocio.ListarxId(new EMA_SELLER { SE_IDCOMPANY = ide, SE_ID = id });
        }

        [HttpPost, Route("")]
        public string Post([FromBody]EMA_SELLER value)
        {
            return negocio.Registrar(value);
        }

        [HttpPut, Route("")]
        public string Put(int id, [FromBody]EMA_SELLER value)
        {
            return negocio.Registrar(value);
        }

        [HttpDelete, Route("{ide}/{id}")]
        public string Delete(int ide, string id)
        {
            return negocio.Eliminar(new EMA_SELLER { SE_IDCOMPANY = ide, SE_ID = id });
        }
    }
}
