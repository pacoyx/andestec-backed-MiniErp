using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using BE.Almacen;
using BL.Almacen;


namespace WA_AndesTec.Controllers
{
    [EnableCors("*", "*", "*")]
    [RoutePrefix("MA_DOCTRANS_TYPE")]
    public class MA_DOCTRANS_TYPEController : ApiController
    {
        MA_DOCTRANS_TYPEBL negocio = new MA_DOCTRANS_TYPEBL();

        [HttpGet, Route("{ide}")]
        public IEnumerable<EMA_DOCTRANS_TYPE> Get(int ide)
        {
            return negocio.Listar(new EMA_DOCTRANS_TYPE { DT_ID_COMPANY = ide });
        }

        [HttpGet, Route("{ide}/{id}")]
        public EMA_DOCTRANS_TYPE Get(int ide, string id)
        {
            return negocio.ListarxId(new EMA_DOCTRANS_TYPE { DT_ID = id, DT_ID_COMPANY = ide });
        }

        [HttpPost, Route("")]
        public void Post([FromBody]EMA_DOCTRANS_TYPE value)
        {
            negocio.Registrar(value);
        }

        [HttpPut, Route("")]
        public void Put(int id, [FromBody]EMA_DOCTRANS_TYPE value)
        {
            negocio.Registrar(value);
        }

        [HttpDelete, Route("{ide}/{id}")]
        public void Delete(int ide, string id)
        {
            negocio.Eliminar(new EMA_DOCTRANS_TYPE { DT_ID = id, DT_ID_COMPANY = ide });
        }
    }
}
