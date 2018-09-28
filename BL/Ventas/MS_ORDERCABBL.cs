using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE.Ventas;
using DA.Ventas;

namespace BL.Ventas
{
    public class MS_ORDERCABBL
    {
        public string Registrar(EMS_ORDER orden)
        {
            return MS_ORDERCABDA.Insert(orden);
        }

        public List<ERE_LISTADOPEDIDO> GetListadoPedidos(int emp) {
            return MS_ORDERCABDA.GetListadoPedidos(emp);
        }

        public List<ERE_LISTADOPEDIDOAYU> GetListadoPedidosAyuda(int emp, int idcliente)
        {
            return MS_ORDERCABDA.GetListadoPedidosAyuda(emp, idcliente);
        }

        public ERE_VISTAPEDIDO ListarRepVistaPedido(int ide, int idOrder)
        {
            ERE_VISTAPEDIDO ent = new ERE_VISTAPEDIDO();
            ent.Cabecera = MS_ORDERCABDA.GetRepVistaPedidoCab(ide, idOrder);
            ent.Detalle = MS_ORDERCABDA.GetRepVistaPedidoDet(idOrder);
            return ent;
        }

        public List<ERE_VISTAPEDIDODET> GetListarVistaPedidoDet(int idcliente)
        {
            return MS_ORDERCABDA.GetRepVistaPedidoDet(idcliente);
        }

        public List<ERE_VISTAPEDIDODET> GetListaPedidoaFac(int idcliente)
        {
            return MS_ORDERCABDA.GetListaPedidoaFac(idcliente);
        }

    }
}
