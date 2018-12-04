using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using BE.Test;
using BL.Test;

namespace WA_AndesTec.Controllers
{
    [EnableCors("*", "*", "*")]
    [RoutePrefix("Trading")]
    public class TradingController : ApiController
    {
        TradingBL negocio = new TradingBL();

        [HttpGet, Route("")]
        public IEnumerable<TRADING> GetAll()
        {
            return negocio.Listar();
        }

        [HttpGet, Route("id/{id}")]
        public TRADING GetxId(int id)
        {
            return negocio.ListarxId( new TRADING { ID = id });
        }

        [HttpPost, Route("")]
        public string Post([FromBody]TRADING value)
        {
            return negocio.Registrar(value);
        }

        [HttpDelete, Route("del/{id}")]
        public string Delete(int id)
        {
            return negocio.Eliminar(new TRADING { ID = id });
        }

    }
}
