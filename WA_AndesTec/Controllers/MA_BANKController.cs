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
    [RoutePrefix("MA_BANK")]
    public class MA_BANKController : ApiController
    {
        MA_BANKBL negocio = new MA_BANKBL();
        [HttpGet, Route("{ide}")]
        public IEnumerable<EMA_BANK> Get(int ide)
        {
            return negocio.Listar(new EMA_BANK { BA_IDCOMPANY = ide });
        }

        [HttpGet, Route("{ide}/{id}")]
        public EMA_BANK Get(int ide, string id)
        {
            return negocio.ListarxId(new EMA_BANK { BA_IDBANK = id, BA_IDCOMPANY = ide });
        }

        [HttpPost, Route("")]
        public void Post([FromBody]EMA_BANK value)
        {
            negocio.Registrar(value);
        }
        
        [HttpDelete, Route("{ide}/{id}")]
        public void Delete(int ide, string id)
        {
            negocio.Eliminar(new EMA_BANK { BA_IDBANK = id, BA_IDCOMPANY = ide });
        }

    }
}
