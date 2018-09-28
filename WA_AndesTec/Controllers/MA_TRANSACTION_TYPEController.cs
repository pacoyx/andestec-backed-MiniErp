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
    [RoutePrefix("MA_TRANSACTION_TYPE")]
    public class MA_TRANSACTION_TYPEController : ApiController
    {
        MA_TRANSACTION_TYPEBL negocio = new MA_TRANSACTION_TYPEBL();

        // GET: api/MA_TRANSACTION_TYPE
        [HttpGet, Route("{ide}")]
        public IEnumerable<EMA_TRANSACTION_TYPE> Get(int ide)
        {
            return negocio.Listar(new EMA_TRANSACTION_TYPE { TT_ID_COMPANY = ide });
        }

        // GET: api/MA_TRANSACTION_TYPE/5
        [HttpGet, Route("{ide}/{id}")]
        public EMA_TRANSACTION_TYPE Get(int ide, string id)
        {
            return negocio.ListarxId(new EMA_TRANSACTION_TYPE { TT_CODIGO = id, TT_ID_COMPANY = ide });
        }

        // GET: api/MA_TRANSACTION_TYPE/5        
        [HttpGet, Route("{ide}/buscar/{tipo}")]
        public IEnumerable<EMA_TRANSACTION_TYPE> GetBuscarPorTipo(int ide, string tipo)
        {
            return negocio.ListarxTipo(new EMA_TRANSACTION_TYPE { TT_INGSAL = tipo, TT_ID_COMPANY = ide });
        }

        // POST: api/MA_TRANSACTION_TYPE
        [HttpPost, Route("")]
        public void Post([FromBody]EMA_TRANSACTION_TYPE value)
        {
            negocio.Registrar(value);
        }

        // PUT: api/MA_TRANSACTION_TYPE/5
        [HttpPut, Route("{id}")]
        public void Put(int id, [FromBody]EMA_TRANSACTION_TYPE value)
        {
            negocio.Registrar(value);
        }

        // DELETE: api/MA_TRANSACTION_TYPE/5
        [HttpDelete, Route("{ide}/{id}")]
        public void Delete(int ide, string id)
        {
            negocio.Eliminar(new EMA_TRANSACTION_TYPE { TT_CODIGO = id, TT_ID_COMPANY = ide });
        }
    }
}
