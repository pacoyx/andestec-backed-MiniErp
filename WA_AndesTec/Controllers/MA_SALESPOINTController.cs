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
    [RoutePrefix("MA_SALESPOINT")]
    public class MA_SALESPOINTController : ApiController
    {
        MA_SALESPOINTBL negocio = new MA_SALESPOINTBL();

        [HttpGet, Route("{ide}")]
        public IEnumerable<EMA_SALESPOINT> GetTodo(int ide)
        {
            return negocio.Listar(new EMA_SALESPOINT { SP_IDCOMPANY = ide });
        }

        [HttpGet, Route("{ide}/{id}")]
        public EMA_SALESPOINT GetPorTipo(int ide, string id)
        {
            return negocio.ListarxId(new EMA_SALESPOINT { SP_IDCOMPANY = ide, SP_ID = id }); ;
        }

        [HttpPost, Route("")]
        public void Post([FromBody]EMA_SALESPOINT value)
        {
            negocio.Registrar(value);
        }

        [HttpPost, Route("")]
        public void Put(int id, [FromBody]EMA_SALESPOINT value)
        {
            negocio.Registrar(value);
        }

        [HttpDelete, Route("{ide}/{id}")]
        public void Delete(int ide, string id)
        {
            negocio.Eliminar(new EMA_SALESPOINT { SP_IDCOMPANY = ide, SP_ID = id });
        }
    }
}
