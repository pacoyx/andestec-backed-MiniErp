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
        public string Post([FromBody]EMA_FAMILY value)
        {            
            return negocio.Registrar(value);            
        }

        [HttpPut, Route("")]
        public string Put([FromBody]EMA_FAMILY value)
        {
            return negocio.Registrar(value);
        }

        [HttpDelete, Route("{ide}/{id}")]
        public string Delete(int ide, int id)
        {
            return negocio.Eliminar(new EMA_FAMILY { ID_COMPANY = ide, ID_FAMILY = id });
        }
    }
}
