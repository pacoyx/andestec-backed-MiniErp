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
    [RoutePrefix("MS_ORDERCAB")]
    public class MS_ORDERCABController : ApiController
    {
        MS_ORDERCABBL negocio = new MS_ORDERCABBL();

        [HttpGet, Route("{ide}/pedidos/{ayo}/{mes}")]
        public IEnumerable<ERE_LISTADOPEDIDO> GetListadPedidos(int ide,int ayo, int mes)
        {
            return negocio.GetListadoPedidos(ide, ayo, mes);
        }

        [HttpGet, Route("{ide}/ayuda/{cli}")]
        public IEnumerable<ERE_LISTADOPEDIDOAYU> GetListadPedidosAyuda(int ide,int cli)
        {
            return negocio.GetListadoPedidosAyuda(ide, cli);
        }

        [HttpGet, Route("vista/afacturar/{cli}")]
        public IEnumerable<ERE_VISTAPEDIDODET> GetListaPedidoaFacturar(int cli)
        {
            return negocio.GetListaPedidoaFac(cli);
        }

        [HttpPost, Route("")]
        public string Post([FromBody]EMS_ORDER value)
        {
            return negocio.Registrar(value);
        }

        [HttpGet, Route("{ide}/vista/{idorder}")]
        public ERE_VISTAPEDIDO GetVistaPedido(int ide, int idorder)
        {
            return negocio.ListarRepVistaPedido(ide, idorder);
        }
        
    }
}
