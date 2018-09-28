using BE.Almacen;
using BL.Almacen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace WA_AndesTec.Controllers
{
    [EnableCors("*", "*", "*")]
    [RoutePrefix("MA_FAMILY")]
    public class MA_FAMILYController : ApiController
    {
        MA_FAMILYBL negocio = new MA_FAMILYBL();

        [HttpGet, Route("{ide}")]        
        public IEnumerable<EMA_FAMILY> Get(int ide)
        {               
            return negocio.Listar(new EMA_FAMILY { ID_COMPANY = ide });
        }

        [HttpGet, Route("{ide}/{id}")]
        public EMA_FAMILY Get(int ide,int id)
        {               
            return negocio.ListarxId(new EMA_FAMILY { ID_COMPANY = ide, ID_FAMILY = id });
        }

        [HttpPost, Route("")]        
        public void Post([FromBody]EMA_FAMILY value)
        {            
            negocio.Registrar(value);            
        }

        [HttpPut, Route("")]
        public void Put([FromBody]EMA_FAMILY value)
        {
            negocio.Registrar(value);
        }

        [HttpDelete, Route("{ide}/{id}")]
        public void Delete(int ide, int id)
        {
            negocio.Eliminar(new EMA_FAMILY { ID_COMPANY = ide, ID_FAMILY = id });
        }
    }
}
