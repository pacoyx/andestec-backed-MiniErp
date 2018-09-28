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
    [RoutePrefix("TRA_WAREHOUSE")]
    public class TRA_WAREHOUSEController : ApiController
    {
        TRA_WAREHOUSEBL negocio = new TRA_WAREHOUSEBL();

        [HttpGet, Route("{ide}/documentos")]
        public IEnumerable<ERE_LISTA01> Get(int ide)
        {
            return negocio.Listar(ide);
        }

        [HttpGet, Route("{ide}/Stock/{alm}")]
        public IEnumerable<ERE_LISTA02> GetStockxAlmacen(int ide,string alm)
        {
            return negocio.ListarStockxAlmacen(ide,alm);
        }

        [HttpGet, Route("{ide}/stock/detalle/{idarti}")]
        public IEnumerable<ERE_LISTA03> GetDetStockxAlmacen(int ide, int idarti)
        {
            return negocio.ListarDetalleStockxAlmacen(ide, idarti);
        }

        [HttpGet, Route("{ide}/vista/{idtrans}")]
        public ERE_LISTA06 GetVistaDocumento(int ide, int idtrans)
        {
            return negocio.ListarRepVistaDocumento(ide, idtrans);
        }

        [HttpGet, Route("{ide}/vistacab/{idtrans}")]
        public ERE_LISTA04 GetVistaDocCab(int ide, int idtrans)
        {
            return negocio.ListarRepVistaDocCab(ide, idtrans);
        }

        [HttpGet, Route("vistadet/{idtrans}")]
        public IEnumerable<ERE_LISTA05> GetVistaDocDet(int idtrans)
        {
            return negocio.ListarRepVistaDocDet(idtrans);
        }
        
        [HttpPost, Route("")]
        public void Post([FromBody]ETRA_GUIAING value)
        {
            negocio.Registrar(value);
        }

        public void Put(int id, [FromBody]string value) { }
        public void Delete(int id) { }
    }
}
