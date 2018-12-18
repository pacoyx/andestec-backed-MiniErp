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
    [RoutePrefix("MA_LOT")]
    public class MA_LOTController : ApiController
    {
        MA_LOTBL negocio = new MA_LOTBL();

        [HttpGet, Route("{ide}")]
        public IEnumerable<EMA_LOT> Get(int ide)
        {
            return negocio.Listar(new EMA_LOT { IDCOMPANY = ide });
        }

        [HttpGet, Route("{ide}/xarti/{ida}")]
        public IEnumerable<EMA_LOT> GetLotexArticulo(int ide,int ida)
        {
            return negocio.ListarxIdArticulo(new EMA_LOT { IDCOMPANY = ide, IDARTICLE = ida });
        }

        [HttpGet, Route("{ide}/{id}")]
        public EMA_LOT Get(int ide, string id)
        {
            return negocio.ListarxId(new EMA_LOT { IDCOMPANY = ide, IDLOT = id});
        }

        [HttpPost, Route("")]
        public string Post([FromBody]EMA_LOT value)
        {
            return negocio.Registrar(value);
        }

        [HttpPut, Route("")]
        public string Put([FromBody]EMA_LOT value)
        {
            return negocio.Registrar(value);
        }

        [HttpDelete, Route("{ide}/{id}")]
        public string Delete(int ide, string id)
        {
            return negocio.Eliminar(new EMA_LOT { IDCOMPANY = ide, IDLOT = id });
        }
    }
}
