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
    [RoutePrefix("MA_SALPOINTSERIE")]
    public class MA_SALPOINTSERIEController : ApiController
    {
        MA_SALPOINTSERIEBL negocio = new MA_SALPOINTSERIEBL();

        [HttpGet, Route("{ide}/{punto}")]
        public IEnumerable<EMA_SALPOINTSERIE> Get(int ide,string punto)
        {
            return negocio.Listar(new EMA_SALPOINTSERIE { SS_IDCOMPANY = ide, SS_IDPOINT = punto });
        }

        [HttpGet, Route("{ide}/{punto}/{doc}")]
        public IEnumerable<EMA_SALPOINTSERIE> GetSerieCorrelativo(int ide, string punto,string doc)
        {
            return negocio.ListarSerieCorrelativo(new EMA_SALPOINTSERIE { SS_IDCOMPANY = ide, SS_ID_DOCUMENT = doc, SS_IDPOINT = punto });
        }

        [HttpGet, Route("{ide}/comprobante/{punto}")]
        public IEnumerable<EMA_SALPOINTSERIE> GetDocxPtoVta(int ide, string punto)
        {
            return negocio.ListarDocxPtoVta(new EMA_SALPOINTSERIE { SS_IDCOMPANY = ide, SS_IDPOINT = punto });
        }

        [HttpPost, Route("")]
        public string Post([FromBody]EMA_SALPOINTSERIE value)
        {
            return negocio.Registrar(value);
        }

        [HttpPut, Route("")]
        public string Put(int id, [FromBody]EMA_SALPOINTSERIE value)
        {
            return negocio.Registrar(value);
        }

        [HttpDelete, Route("{ide}/{po}/{doc}/{se}")]
        public string Delete(int ide, string po, string doc, string se)
        {
            return negocio.Eliminar(new EMA_SALPOINTSERIE { SS_IDPOINT = po, SS_ID_DOCUMENT = doc, SS_SERIE = se, SS_IDCOMPANY = ide });
        }

    }
}
