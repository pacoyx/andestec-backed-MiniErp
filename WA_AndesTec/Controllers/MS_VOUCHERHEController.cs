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
    [RoutePrefix("MS_VOUCHERHE")]
    public class MS_VOUCHERHEController : ApiController
    {
        MS_VOUCHERHEBL negocio = new MS_VOUCHERHEBL();

        [HttpGet, Route("{ide}/comprobantes")]
        public IEnumerable<ERE_LISTADOCOMPROBANTE> GetListaComprobantes(int ide)
        {
            return negocio.GetListadoComprobantes(ide);
        }
        
       
        [HttpPost, Route("")]
        public string Post([FromBody]EMS_VOUCHER value)
        {
            return negocio.Registrar(value);
        }

        [HttpGet, Route("{ide}/vista/{idcompro}")]
        public ERE_VISTACOMPROBANTE GetVistaComprobante(int ide, int idcompro)
        {
            return negocio.ListarRepVistaComprobante(ide, idcompro);
        }

    }
}
