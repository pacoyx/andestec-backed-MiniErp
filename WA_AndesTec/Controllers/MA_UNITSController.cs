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
    [RoutePrefix("MA_UNITS")]
    public class MA_UNITSController : ApiController
    {
        MA_UNITSBL negocio = new MA_UNITSBL();

        [HttpGet, Route("{ide}")]
        public IEnumerable<EMA_UNITS> Get(int ide)
        {
            return negocio.Listar(new EMA_UNITS { ID_COMPANY = ide });
        }

        [HttpGet, Route("{ide}/{id}")]
        public EMA_UNITS Get(int ide,string id)
        {
            return negocio.ListarxId(new EMA_UNITS { ID_COMPANY = ide, ID_UNIT = id });
        }

        [HttpPost, Route("")]
        public string Post([FromBody]EMA_UNITS value)
        {
            return negocio.Registrar(value);
        }

        [HttpPut, Route("{id}")]
        public string Put([FromBody]EMA_UNITS value)
        {
            return negocio.Registrar(value);
        }

        [HttpDelete, Route("{ide}/{id}")]
        public string Delete(int ide, string id)
        {
            return negocio.Eliminar(new EMA_UNITS { ID_COMPANY = ide, ID_UNIT = id });
        }
    }
}
