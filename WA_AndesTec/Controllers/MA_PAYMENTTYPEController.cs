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
    [RoutePrefix("MA_PAYMENTTYPE")]
    public class MA_PAYMENTTYPEController : ApiController
    {
        MA_PAYMENTTYPEBL negocio = new MA_PAYMENTTYPEBL();

        [HttpGet, Route("{ide}")]
        public IEnumerable<EMA_PAYMENTTYPE> GetTodo(int ide)
        {
            return negocio.Listar(new EMA_PAYMENTTYPE { PT_IDCOMPANY = ide });
        }

        [HttpGet, Route("{ide}/{id}")]
        public EMA_PAYMENTTYPE Get(int ide,string id)
        {
            return negocio.ListarxId(new EMA_PAYMENTTYPE { PT_IDCOMPANY = ide, PT_ID = id });
        }

        [HttpPost, Route("")]
        public void Post([FromBody]EMA_PAYMENTTYPE value)
        {
            negocio.Registrar(value);
        }

        [HttpPost, Route("")]
        public void Put(int id, [FromBody]EMA_PAYMENTTYPE value)
        {
        }

        [HttpDelete, Route("{ide}/{id}")]
        public void Delete(int ide, string id)
        {
            negocio.Eliminar(new EMA_PAYMENTTYPE { PT_IDCOMPANY = ide, PT_ID = id });
        }
    }
}
