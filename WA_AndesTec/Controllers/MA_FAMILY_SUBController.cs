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
    [RoutePrefix("MA_FAMILY_SUB")]
    public class MA_FAMILY_SUBController : ApiController
    {
        MA_FAMILY_SUBBL negocio = new MA_FAMILY_SUBBL();

        [HttpGet, Route("{ide}")]
        public IEnumerable<EMA_FAMILY_SUB> Get(int ide)
        {
            return negocio.Listar(new EMA_FAMILY_SUB { ID_COMPANY = ide });
        }

        [HttpGet, Route("{ide}/{id}")]
        public EMA_FAMILY_SUB Get(int ide, int id)
        {
            return negocio.ListarxId(new EMA_FAMILY_SUB { ID_COMPANY = ide, ID_FAMILY_SUB = id });
        }

        [HttpGet, Route("{ide}/fam/{idFam}")]
        public IEnumerable<EMA_FAMILY_SUB> GetxFamilia(int ide, int idFam)
        {
            return negocio.ListarxFam(new EMA_FAMILY_SUB { ID_COMPANY = ide, ID_FAMILY = idFam });
        }

        [HttpPost, Route("")]
        public string Post([FromBody]EMA_FAMILY_SUB value)
        {
            return negocio.Registrar(value);
        }

        [HttpPut, Route("")]
        public string Put([FromBody]EMA_FAMILY_SUB value)
        {
            return negocio.Registrar(value);
        }

        [HttpDelete, Route("{ide}/{id}")]
        public string Delete(int ide, int id)
        {
            return negocio.Eliminar(new EMA_FAMILY_SUB { ID_COMPANY = ide, ID_FAMILY_SUB = id });
        }
    }
}
