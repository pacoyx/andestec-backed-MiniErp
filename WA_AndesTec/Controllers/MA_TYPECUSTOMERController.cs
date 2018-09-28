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
    [RoutePrefix("MA_TYPECUSTOMER")]
    public class MA_TYPECUSTOMERController : ApiController
    {
        MA_TYPECUSTOMERBL negocio = new MA_TYPECUSTOMERBL();
        [HttpGet, Route("{ide}")]
        public IEnumerable<EMA_TYPECUSTOMER> Get(int ide)
        {
            return negocio.Listar(new EMA_TYPECUSTOMER { TC_IDCOMPANY = ide });
        }

        [HttpGet, Route("{ide}/{id}")]
        public EMA_TYPECUSTOMER GetBYID(int ide, string id)
        {
            return negocio.ListarxId(new EMA_TYPECUSTOMER { TC_ID = id, TC_IDCOMPANY = ide });
        }


        [HttpPost, Route("")]
        public void Post([FromBody]EMA_TYPECUSTOMER value)
        {
            negocio.Registrar(value);
        }


        [HttpDelete, Route("{ide}/{id}")]
        public void Delete(int ide, string id)
        {
            negocio.Eliminar(new EMA_TYPECUSTOMER { TC_ID = id, TC_IDCOMPANY = ide });
        }

    }
}
