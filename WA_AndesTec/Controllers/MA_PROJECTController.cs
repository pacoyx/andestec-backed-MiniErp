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
    [RoutePrefix("MA_PROJECT")]
    public class MA_PROJECTController : ApiController
    {
        MA_PROJECTBL negocio = new MA_PROJECTBL();

        [HttpGet, Route("{ide}")]
        public IEnumerable<EMA_PROJECT> GetTodo(int ide)
        {
            return negocio.Listar(new EMA_PROJECT { PJ_IDCOMPANY = ide });
        }

        [HttpGet, Route("{ide}/{id}")]
        public EMA_PROJECT GetPorProyecto(int ide, string id)
        {
            return negocio.ListarxId(new EMA_PROJECT { PJ_IDCOMPANY = ide, PJ_ID = id });
        }

        [HttpPost, Route("")]
        public string Post([FromBody]EMA_PROJECT value)
        {
            return negocio.Registrar(value);
        }

        [HttpPost, Route("")]
        public string Put(int id, [FromBody]EMA_PROJECT value)
        {
            return "";
        }

        [HttpDelete, Route("{ide}/{id}")]
        public string Delete(int ide, string id)
        {
            return negocio.Eliminar(new EMA_PROJECT { PJ_IDCOMPANY = ide, PJ_ID = id });
        }
    }
}
