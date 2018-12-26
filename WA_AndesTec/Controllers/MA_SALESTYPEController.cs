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
    [RoutePrefix("MA_SALESTYPE")]
    public class MA_SALESTYPEController : ApiController
    {
        MA_SALESTYPEBL negocio = new MA_SALESTYPEBL();

        [HttpGet, Route("{ide}")]
        public IEnumerable<EMA_SALESTYPE> GetTodo(int ide)
        {
            return negocio.Listar(new EMA_SALESTYPE { ST_IDCOMPANY = ide });
        }

        [HttpGet, Route("{ide}/{id}")]
        public EMA_SALESTYPE GetPorTipo(int ide, string id)
        {
            return negocio.ListarxId(new EMA_SALESTYPE { ST_IDCOMPANY = ide ,ST_ID = id}); ;
        }

        [HttpPost, Route("")]
        public string Post([FromBody]EMA_SALESTYPE value)
        {
            return negocio.Registrar(value);
        }

        [HttpPost, Route("")]
        public string Put(int id, [FromBody]EMA_SALESTYPE value)
        {
            return "";
        }

        [HttpDelete, Route("{ide}/{id}")]
        public string Delete(int ide,string id)
        {
            return negocio.Eliminar(new EMA_SALESTYPE { ST_IDCOMPANY = ide, ST_ID = id });
        }
    }
}
