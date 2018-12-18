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
    [RoutePrefix("CA_COLLECTOR")]
    public class CA_COLLECTORController : ApiController
    {
        CA_COLLECTORBL negocio = new CA_COLLECTORBL();

        [HttpGet, Route("{ide}")]
        public IEnumerable<ECA_COLLECTOR> Get(int ide)
        {
            return negocio.Listar(new ECA_COLLECTOR { CO_IDCOMPANY = ide });
        }

        [HttpGet, Route("{ide}/{id}")]
        public ECA_COLLECTOR Get(int ide, string id)
        {
            return negocio.ListarxId(new ECA_COLLECTOR { CO_IDCOLLECTOR = id, CO_IDCOMPANY = ide });
        }

        [HttpPost, Route("")]
        public string Post([FromBody]ECA_COLLECTOR value)
        {
            return negocio.Registrar(value);
        }

        [HttpDelete, Route("{ide}/{id}")]
        public string Delete(int ide, string id)
        {
            return negocio.Eliminar(new ECA_COLLECTOR { CO_IDCOLLECTOR = id, CO_IDCOMPANY = ide });
        }
    }
}
