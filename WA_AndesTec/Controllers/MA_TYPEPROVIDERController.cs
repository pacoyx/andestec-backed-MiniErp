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
    [RoutePrefix("MA_TYPEPROVIDER")]
    public class MA_TYPEPROVIDERController : ApiController
    {
        MA_TYPEPROVIDERBL negocio = new MA_TYPEPROVIDERBL();

        [HttpGet, Route("{ide}")]
        public IEnumerable<EMA_TYPEPROVIDER> Get(int ide)
        {
            return negocio.Listar(new EMA_TYPEPROVIDER { TP_IDCOMPANY = ide });
        }

        [HttpGet, Route("{ide}/{id}")]
        public EMA_TYPEPROVIDER Get(int ide, string id)
        {
            return negocio.ListarxId(new EMA_TYPEPROVIDER { TP_ID = id, TP_IDCOMPANY = ide });
        }

        [HttpPost, Route("")]
        public string Post([FromBody]EMA_TYPEPROVIDER value)
        {
            return negocio.Registrar(value);
        }

        [HttpDelete, Route("{ide}/{id}")]
        public string Delete(int ide, string id)
        {
            return negocio.Eliminar(new EMA_TYPEPROVIDER { TP_ID = id, TP_IDCOMPANY = ide });
        }
    }
}
