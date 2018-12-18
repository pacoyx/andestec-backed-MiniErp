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
    [RoutePrefix("MA_ARTICLE")]
    public class MA_ARTICLEController : ApiController
    {
        MA_ARTICLEBL negocio = new MA_ARTICLEBL();

        
        [HttpGet, Route("{ide}")]
        public IEnumerable<EMA_ARTICLE> Get(int ide)
        {
           return negocio.Listar(new EMA_ARTICLE { ID_COMPANY = ide });
        }

        
        [HttpGet, Route("{ide}/{id}")]
        public EMA_ARTICLE Get(int ide, int id)
        {
            return negocio.ListarxId(new EMA_ARTICLE { ID_ARTICLE = id, ID_COMPANY = ide });
        }

        
        [HttpGet, Route("{ide}/buscar/{dato}")]
        public IEnumerable<EMA_ARTICLE>GETBuscarPorNombre(int ide, string dato)
        {
            return negocio.ListarxNombre(new EMA_ARTICLE { ID_COMPANY = ide, DESCRIPTION_ARTICLE = dato });            
        }

        [HttpGet, Route("{ide}/buscarLotes/{dato}")]
        public IEnumerable<EMA_ARTICLE> GETBuscarPorNombreLotes(int ide, string dato)
        {
            return negocio.ListarxNombreLotes(new EMA_ARTICLE { ID_COMPANY = ide, DESCRIPTION_ARTICLE = dato });
        }

        [HttpPost, Route("")]
        public string Post([FromBody]EMA_ARTICLE value)
        {
           return negocio.Registrar(value);
        }

        
        [HttpPut, Route("{id}")]
        public string Put(int id, [FromBody]EMA_ARTICLE value)
        {
           return negocio.Registrar(value);
        }

        
        [HttpDelete, Route("{ide}/{id}")]
        public string Delete(int ide, int id)
        {
            return negocio.Eliminar(new EMA_ARTICLE { ID_ARTICLE = id, ID_COMPANY = ide });
        }
    }
}
