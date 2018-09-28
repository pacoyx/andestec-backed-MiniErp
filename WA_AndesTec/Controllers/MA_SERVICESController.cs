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
    [RoutePrefix("MA_SERVICES")]
    public class MA_SERVICESController : ApiController
    {
        MA_SERVICESBL negocio = new MA_SERVICESBL();

        [HttpGet, Route("{ide}")]
        public IEnumerable<EMA_SERVICES> Get(int ide)
        {
            return negocio.Listar(new EMA_SERVICES { ID_COMPANY = ide });
        }

        [HttpGet, Route("{ide}/{id}")]
        public EMA_SERVICES Get(int ide,int id)
        {
            return negocio.ListarxId(new EMA_SERVICES { ID_COMPANY = ide ,ID_SERVICES = id});
        }

        [HttpPost, Route("")]
        public void Post([FromBody]EMA_SERVICES value)
        {
            negocio.Registrar(value);
        }

        [HttpPut, Route("")]
        public void Put([FromBody]EMA_SERVICES value)
        {
            negocio.Registrar(value);
        }

        [HttpDelete, Route("{ide}/{id}")]
        public void Delete(int ide, int id)
        {
            negocio.Eliminar(new EMA_SERVICES { ID_COMPANY = ide, ID_SERVICES = id });
        }
    }
}
