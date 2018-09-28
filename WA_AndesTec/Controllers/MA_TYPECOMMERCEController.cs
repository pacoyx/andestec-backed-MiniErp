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
    [RoutePrefix("MA_TYPECOMMERCE")]
    public class MA_TYPECOMMERCEController : ApiController
    {
        MA_TYPECOMMERCEBL negocio = new MA_TYPECOMMERCEBL();

        [HttpGet, Route("{ide}")]
        public IEnumerable<EMA_TYPECOMMERCE> Get(int ide)
        {
            return negocio.Listar(new EMA_TYPECOMMERCE { TC_IDCOMPANY = ide });
        }

        [HttpGet, Route("{ide}/{id}")]
        public EMA_TYPECOMMERCE GetBYID(int ide, string id)
        {
            return negocio.ListarxId(new EMA_TYPECOMMERCE { TC_ID = id, TC_IDCOMPANY = ide });
        }


        [HttpPost, Route("")]
        public void Post([FromBody]EMA_TYPECOMMERCE value)
        {
            negocio.Registrar(value);
        }


        [HttpDelete, Route("{ide}/{id}")]
        public void Delete(int ide, string id)
        {
            negocio.Eliminar(new EMA_TYPECOMMERCE { TC_ID = id, TC_IDCOMPANY = ide });
        }
    }
}
