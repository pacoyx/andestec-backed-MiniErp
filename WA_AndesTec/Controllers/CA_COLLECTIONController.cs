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
    [RoutePrefix("CA_COLLECTION")]
    public class CA_COLLECTIONController : ApiController
    {
        CA_COLLECTIONBL negocio = new CA_COLLECTIONBL();
        CA_COLLECTION_LINEBL negociodet = new CA_COLLECTION_LINEBL();

        //lista planillas de tabla cabecera
        [HttpGet, Route("{ide}/{f1}/{f2}")]
        public IEnumerable<ECA_COLLECTION> Get(int ide,string f1,string f2)
        {
            return negocio.Listar(new ECA_COLLECTION { CO_IDCOMPANY = ide, FECHAINI = f1, FECHAFIN = f2 });
        }

        //lista detalle de planillas
        [HttpGet, Route("{ide}/LISDET/{idpla}")]
        public IEnumerable<EPLANILLADET> GetPlanillaDet(int ide, int idpla)
        {
            return negociodet.ListarPlanillaDetalle(ide, idpla);
        }

        //graba Cabecera
        [HttpPost, Route("")]
        public Int64 Post([FromBody]ECA_COLLECTION value)
        {
            return negocio.Registrar(value);
        }

        //graba detalle
        [HttpPost, Route("REGDOC")]
        public string Post([FromBody]List<ECA_COLLECTION_LINE> value)
        {
            return negociodet.Registrar(value);
        }

    }
}
