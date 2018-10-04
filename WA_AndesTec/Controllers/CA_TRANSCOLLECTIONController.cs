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
    [RoutePrefix("CA_TRANSCOLLECTION")]
    public class CA_TRANSCOLLECTIONController : ApiController
    {
        CA_TRANSCOLLECTIONBL negocio = new CA_TRANSCOLLECTIONBL();
        [HttpGet, Route("{ide}")]
        public IEnumerable<ECA_TRANSCOLLECTION> Get(int ide)
        {
            return negocio.Listar(new ECA_TRANSCOLLECTION { TC_IDCOMPANY = ide });
        }

        [HttpGet, Route("{ide}/{id}")]
        public ECA_TRANSCOLLECTION Get(int ide, string id)
        {
            return negocio.ListarxId(new ECA_TRANSCOLLECTION { TC_IDTRANSCOLLECTION = id, TC_IDCOMPANY = ide });
        }

        [HttpPost, Route("")]
        public void Post([FromBody]ECA_TRANSCOLLECTION value)
        {
            negocio.Registrar(value);
        }

        [HttpDelete, Route("{ide}/{id}")]
        public void Delete(int ide, string id)
        {
            negocio.Eliminar(new ECA_TRANSCOLLECTION { TC_IDTRANSCOLLECTION = id, TC_IDCOMPANY = ide });
        }

    }
}
