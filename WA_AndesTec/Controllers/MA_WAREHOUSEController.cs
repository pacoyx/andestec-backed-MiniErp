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
    [EnableCors("*","*","*")]
    [RoutePrefix("MA_WAREHOUSE")]
    public class MA_WAREHOUSEController : ApiController
    {
        MA_WAREHOUSEBL negocio = new MA_WAREHOUSEBL();

        [HttpGet, Route("{ide}")]
        public IEnumerable<EMA_WAREHOUSE> Get(int ide)
        {            
            return negocio.Listar(new EMA_WAREHOUSE { ID_COMPANY = ide });
        }

        [HttpGet, Route("{ide}/{id}")]
        public EMA_WAREHOUSE Get(int ide, string id)
        {
            EMA_WAREHOUSE ent = new EMA_WAREHOUSE { ID_COMPANY = ide, ID_WAREHOUSE = id };
            return negocio.ListarxId(ent);  
        }

        [HttpPost, Route("")]
        public void Post([FromBody]EMA_WAREHOUSE value)
        {
            negocio.Registrar(value);
        }

        [HttpPut, Route("{id}")]
        public void Put([FromBody]EMA_WAREHOUSE value)
        {
            negocio.Registrar(value);
        }

        [HttpDelete, Route("{ide}/{id}")]
        public void Delete(int ide, string id)
        {
            negocio.Eliminar(new EMA_WAREHOUSE { ID_COMPANY = ide, ID_WAREHOUSE = id });
        }
    }
}
