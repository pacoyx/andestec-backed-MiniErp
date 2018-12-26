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
    [RoutePrefix("MA_USERSALESPOINT")]
    public class MA_USERSALESPOINTController : ApiController
    {
        MA_USERSALESPOINTBL negocio = new MA_USERSALESPOINTBL();

        [HttpGet, Route("{ide}")]
        public IEnumerable<EMA_USERSALESPOINT> Get(int ide)
        {
            return negocio.Listar(new EMA_USERSALESPOINT { US_IDCOMPANY = ide });
        }

        [HttpPost, Route("")]
        public string Post([FromBody]EMA_USERSALESPOINT value)
        {
            return negocio.Registrar(value);
        }

        [HttpDelete, Route("{ide}/{idu}/{idp}")]
        public string Delete(int ide, string idu,string idp)
        {
            return negocio.Eliminar(new EMA_USERSALESPOINT { US_IDUSER = idu, US_IDSALESPOINT = idp, US_IDCOMPANY = ide });
        }

    }
}
