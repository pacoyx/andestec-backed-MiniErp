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
    [RoutePrefix("MA_TYPEPRICE")]
    public class MA_TYPEPRICEController : ApiController
    {
        MA_TYPEPRICEBL negocio = new MA_TYPEPRICEBL();

        [HttpGet, Route("{ide}")]
        public IEnumerable<EMA_TYPEPRICE> Get(int ide)
        {
            return negocio.Listar(new EMA_TYPEPRICE { TP_IDCOMPANY = ide });
        }

        [HttpGet, Route("{ide}/{id}")]
        public EMA_TYPEPRICE GetBYID(int ide, string id)
        {
            return negocio.ListarxId(new EMA_TYPEPRICE { TP_ID = id, TP_IDCOMPANY = ide });
        }

        [HttpPost, Route("")]
        public void Post([FromBody]EMA_TYPEPRICE value)
        {
            negocio.Registrar(value);
        }

        [HttpDelete, Route("{ide}/{id}")]
        public void Delete(int ide, string id)
        {
            negocio.Eliminar(new EMA_TYPEPRICE { TP_ID = id, TP_IDCOMPANY = ide });
        }
    }
}
