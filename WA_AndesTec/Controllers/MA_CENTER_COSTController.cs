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
    [RoutePrefix("MA_CENTER_COST")]
    public class MA_CENTER_COSTController : ApiController
    {
        MA_CENTER_COSTBL negocio = new MA_CENTER_COSTBL();

        [HttpGet, Route("{ide}")]
        public IEnumerable<EMA_CENTER_COST> Get(int ide)    
        {
            return negocio.Listar(new EMA_CENTER_COST { ID_COMPANY = ide });
        }

        [HttpGet, Route("{ide}/{id}")]
        public EMA_CENTER_COST Get(int ide, int id)
        {
            return negocio.ListarxId(new EMA_CENTER_COST { ID_CENTER_COST = id, ID_COMPANY = ide });
        }

        [HttpPost, Route("")]
        public string Post([FromBody]EMA_CENTER_COST value)
        {
            return negocio.Registrar(value);
        }

        [HttpPut, Route("")]
        public string Put([FromBody]EMA_CENTER_COST value)
        {
            return negocio.Registrar(value);
        }

        [HttpDelete, Route("{ide}/{id}")]
        public string Delete(int ide, int id)
        {
            return negocio.Eliminar(new EMA_CENTER_COST { ID_CENTER_COST = id, ID_COMPANY = ide });
        }
    }
}
