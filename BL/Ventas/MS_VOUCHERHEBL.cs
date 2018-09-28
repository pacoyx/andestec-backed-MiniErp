using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE.Ventas;
using DA.Ventas;

namespace BL.Ventas
{
    public class MS_VOUCHERHEBL
    {
        public string Registrar(EMS_VOUCHER orden)
        {
            return MS_VOUCHERHEDA.Insert(orden);
        }

        public List<ERE_LISTADOCOMPROBANTE> GetListadoComprobantes(int emp)
        {
            return MS_VOUCHERHEDA.GetListadoComprobantes(emp);
        }
            
        public ERE_VISTACOMPROBANTE ListarRepVistaComprobante(int ide, int idOrder)
        {
            ERE_VISTACOMPROBANTE ent = new ERE_VISTACOMPROBANTE
            {
                Cabecera = MS_VOUCHERHEDA.GetRepVistaComprobanteCab(ide, idOrder),
                Detalle = MS_VOUCHERHEDA.GetRepVistaComprobanteDet(idOrder)
            };
            return ent;
        }

    }
}
