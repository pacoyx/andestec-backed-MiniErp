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
    [RoutePrefix("TRA_WAREHOUSE_QTY")]
    public class TRA_WAREHOUSE_QTYController : ApiController
    {
        TRA_WAREHOUSE_QTYBL negocio = new TRA_WAREHOUSE_QTYBL();

        [HttpGet, Route("{ide}")]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpGet, Route("{ide}/{id}/{alm}")]
        public ETRA_WAREHOUSE_QTY GetstockxArti(int ide,int id,string alm)
        {
            return negocio.StockxArti(new ETRA_WAREHOUSE_QTY { IDCOMPANY = ide, IDARTICLE = id,IDWAREHOUSE = alm });
        }

        [HttpGet, Route("lote/{ide}/{id}/{alm}")]
        public double GetstockTotalxLote(int ide, int id, string alm)
        {
            return negocio.StockTotalxLote(new ETRA_WAREHOUSE_QTY { IDCOMPANY = ide, IDARTICLE = id, IDWAREHOUSE = alm });
        }

        [HttpGet, Route("{ide}/{id}/{alm}/{lote}")]
        public ERE_LISTA07 GetstockxLote(int ide, int id, string alm,string lote)
        {
            return negocio.StockxLote(new ETRA_WAREHOUSE_QTY_LOT { IDCOMPANY = ide, IDARTICLE = id, IDWAREHOUSE = alm, IDLOT = lote });
        }
        
        public void Post([FromBody]string value) { }
        public void Put(int id, [FromBody]string value) { }
        public void Delete(int id) { }
    }
}
