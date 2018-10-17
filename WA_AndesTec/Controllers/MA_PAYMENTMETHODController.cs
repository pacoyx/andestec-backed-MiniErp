using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using BE.Caja;
using BL.Caja;

namespace WA_AndesTec.Controllers
{
    [EnableCors("*", "*", "*")]
    [RoutePrefix("MA_PAYMENTMETHOD")]
    public class MA_PAYMENTMETHODController : ApiController
    {
        MA_PAYMENTMETHODBL negocio = new MA_PAYMENTMETHODBL();

        [HttpGet, Route("{ide}")]
        public IEnumerable<EMA_PAYMENTMETHOD> Get(int ide)
        {
            return negocio.Listar(new EMA_PAYMENTMETHOD { PM_IDCOMPANY = ide });
        }

        [HttpGet, Route("{ide}/{id}")]
        public EMA_PAYMENTMETHOD Get(int ide, string id)
        {
            return negocio.ListarxId(new EMA_PAYMENTMETHOD { PM_ID = id, PM_IDCOMPANY = ide });
        }

        [HttpPost, Route("")]
        public string Post([FromBody]EMA_PAYMENTMETHOD value)
        {
            return negocio.Registrar(value);
        }

        [HttpDelete, Route("{ide}/{id}")]
        public string Delete(int ide, string id)
        {
            return negocio.Eliminar(new EMA_PAYMENTMETHOD { PM_ID = id, PM_IDCOMPANY = ide });
        }
    }
}
