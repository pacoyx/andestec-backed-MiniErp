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
    [RoutePrefix("MA_DOCUMENTS")]
    public class MA_DOCUMENTSController : ApiController
    {
        MA_DOCUMENTSBL negocio = new MA_DOCUMENTSBL();

        [HttpGet, Route("{ide}")]
        public IEnumerable<EMA_DOCUMENTS> Get(int ide)
        {
            return negocio.Listar(new EMA_DOCUMENTS { ID_COMPANY = ide });
        }

        [HttpGet, Route("{ide}/{id}")]
        public EMA_DOCUMENTS Get(int ide, string id)
        {
            return negocio.ListarxId(new EMA_DOCUMENTS { ID_DOCUMENT = id, ID_COMPANY = ide });
        }

        [HttpPost, Route("")]
        public string Post([FromBody]EMA_DOCUMENTS value)
        {
            return negocio.Registrar(value);
        }

        [HttpPut, Route("{id}")]
        public string Put(int id, [FromBody]EMA_DOCUMENTS value)
        {
            return negocio.Registrar(value);
        }

        [HttpDelete, Route("{ide}/{id}")]
        public string Delete(int ide, string id)
        {
            return negocio.Eliminar(new EMA_DOCUMENTS { ID_DOCUMENT = id, ID_COMPANY = ide });
        }
    }
}
