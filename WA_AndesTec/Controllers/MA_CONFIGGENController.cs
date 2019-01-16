using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using BE.Herramientas;
using BL.Herramientas;

namespace WA_AndesTec.Controllers
{
    [EnableCors("*", "*", "*")]
    [RoutePrefix("MA_CONFIGGEN")]
    public class MA_CONFIGGENController : ApiController
    {
        MA_CONFIGGENBL negocio = new MA_CONFIGGENBL();

        [HttpGet, Route("{ide}")]
        public EMA_CONFIGGEN GetTodos(int ide)
        {            
            return negocio.ListarTodo(ide);
        }
        
        [HttpPut, Route("")]
        public string Put([FromBody]EMA_CONFIGGEN value)
        {
            return negocio.Actualizar(value);
        }

    }
}
