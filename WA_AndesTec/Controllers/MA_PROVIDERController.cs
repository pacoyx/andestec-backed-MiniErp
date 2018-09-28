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
    [RoutePrefix("MA_PROVIDER")]
    public class MA_PROVIDERController : ApiController
    {
        MA_PROVIDERBL negocio = new MA_PROVIDERBL();

        [HttpGet, Route("{ide}")]
        public IEnumerable<EMA_PROVIDER> Get(int ide)
        {
            return negocio.Listar(new EMA_PROVIDER { ID_COMPANY = ide });
        }

        [HttpGet, Route("{ide}/{id}")]
        public EMA_PROVIDER Get(int ide, int id)
        {
            return negocio.ListarxId(new EMA_PROVIDER { ID_COMPANY = ide ,ID_PROVIDER = id});
        }

        [HttpGet, Route("{ide}/buscar/{dato}")]
        public IEnumerable<EMA_PROVIDER> GetBuscarPatron(int ide,string dato)
        {
            return negocio.ListarxPatron(new EMA_PROVIDER { ID_COMPANY = ide, DESCRIPTION_PROVIDER = dato });
        }

        [HttpPost, Route("")]
        public void Post([FromBody]EMA_PROVIDER value)
        {
            negocio.Registrar(value);
        }

        [HttpPut, Route("")]
        public void Put([FromBody]EMA_PROVIDER value)
        {
            negocio.Registrar(value);
        }

        [HttpDelete, Route("{ide}/{id}")]
        public void Delete(int ide, int id)
        {
            negocio.Eliminar(new EMA_PROVIDER { ID_COMPANY = ide, ID_PROVIDER = id });
        }
    }
}
