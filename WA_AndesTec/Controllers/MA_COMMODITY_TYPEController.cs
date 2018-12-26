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
    [RoutePrefix("MA_COMMODITY_TYPE")]
    public class MA_COMMODITY_TYPEController : ApiController
    {
        MA_COMMODITY_TYPEBL negocio = new MA_COMMODITY_TYPEBL();

        [HttpGet, Route("{ide}")]
        public IEnumerable<EMA_COMMODITY_TYPE> Get(int ide)
        {
            return negocio.Listar(new EMA_COMMODITY_TYPE { ID_COMPANY = ide });
        }

        [HttpGet, Route("{ide}/{id}")]
        public EMA_COMMODITY_TYPE Get(int ide, string id)
        {
            return negocio.ListarxId(new EMA_COMMODITY_TYPE { ID_COMPANY = ide, ID_COMMODITY_TYPE = id });
        }

        [HttpPost, Route("")]
        public string Post([FromBody]EMA_COMMODITY_TYPE value)
        {
            return negocio.Registrar(value);
        }

        [HttpPut, Route("")]
        public string Put([FromBody]EMA_COMMODITY_TYPE value)
        {
            return negocio.Registrar(value);
        }

        [HttpDelete, Route("{ide}/{id}")]
        public string Delete(int ide, string id)
        {
            return negocio.Eliminar(new EMA_COMMODITY_TYPE { ID_COMPANY = ide, ID_COMMODITY_TYPE = id });
        }
    }
}
