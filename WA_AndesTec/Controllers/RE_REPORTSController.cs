using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using BE.Ventas;
using BE.Almacen;
using BE.Caja;
using BL.Reportes;

namespace WA_AndesTec.Controllers
{

    [EnableCors("*", "*", "*")]
    [RoutePrefix("RE_REPORTS")]
    public class RE_REPORTSController : ApiController
    {
        RE_REPORTSBL negocio= new RE_REPORTSBL();

        [HttpGet, Route("{ide}/{alm}/kardex/{f1}/{f2}/{usu}")]
        public IEnumerable<EREP_INVKARDEX> GetRepAlmacenKardex(int ide,string alm,string f1,string f2,string usu)
        {
            return negocio.GetRepAlmacenKardex(new ETRA_WAREHOUSE()
            {
                ID_WAREHOUSE = alm,
                TRANSACTION_DATE = f1,
                AFECREG = f2,
                ID_COMPANY = ide,
                AUSUARIO = usu
            }
            );
        }

        [HttpGet, Route("{ide}/transaccion/{tt}/{alm}/{ayo}/{mes}")]
        public IEnumerable<EREP_INVTRANSAC> GetRepAlmacenTransacciones(int ide, string tt,string alm,int ayo,int mes)
        {
            return negocio.GetRepAlmacenTransacciones(new ETRA_WAREHOUSE()
            {                
                TRANSACTION_TYPE = tt,                
                ID_WAREHOUSE = alm,
                TRANSACTION_DATE = new DateTime(ayo,mes,1).ToShortDateString(),
                ID_COMPANY = ide
            }
            );
        }

        [HttpGet, Route("{ide}/stock/{alm}")]
        public IEnumerable<EREP_INVSTOCK> GetRepAlmacenStock(int ide, string alm)
        {
            return negocio.GetRepAlmacenStock(new ETRA_WAREHOUSE()
            {
                ID_WAREHOUSE = alm,
                ID_COMPANY = ide
            }
            );
        }

        [HttpGet, Route("{ide}/vtaxven/{vend}/{f1}/{f2}")]
        public IEnumerable<EREP_SELVTAXSEL> GetRepVentasxVendedor(int ide, string vend,string f1, string f2)
        {
            return negocio.GetRepVentasxVendedor(new EMS_VOUCHERHE()
            {
                VH_IDSELLER = vend,
                VH_VOUCHERDATE = f1,
                VH_DELIVERDATE = f2,
                VH_IDCOMPANY = ide
            }
            );
        }

        [HttpGet, Route("{ide}/vtaxart/{art}/{f1}/{f2}")]
        public IEnumerable<EREP_SELVTAXARTI> GetRepVentasxArticulo(int ide, int art, string f1, string f2)
        {
            return negocio.GetRepVentasxArticulo(new EMS_VOUCHERHE()
            {
                VH_IDORDER = art,
                VH_VOUCHERDATE = f1,
                VH_DELIVERDATE = f2,
                VH_IDCOMPANY = ide
            }
            );
        }

        [HttpGet, Route("{ide}/vtaxcli/{cli}/{f1}/{f2}")]
        public IEnumerable<EREP_SELVTAXCUSTO> GetRepVentasxCliente(int ide, int cli, string f1, string f2)
        {
            return negocio.GetRepVentasxCliente(new EMS_VOUCHERHE()
            {
                VH_IDCUSTOMER = cli,
                VH_VOUCHERDATE = f1,
                VH_DELIVERDATE = f2,
                VH_IDCOMPANY = ide
            }
            );
        }

        [HttpGet, Route("{ide}/regventas/{f1}/{f2}")]
        public IEnumerable<EREP_REGVENTAS> GetRepRegistroVentas(int ide, string f1, string f2)
        {
            return negocio.GetRepRegVentas(new EMS_VOUCHERHE()
            {
                VH_VOUCHERDATE = f1,
                VH_DELIVERDATE = f2,
                VH_IDCOMPANY = ide
            }
            );
        }

        [HttpGet, Route("{ide}/docpencob/{tipo}/{cli}/{f1}/{f2}")]
        public IEnumerable<ERE_DOCPENDICOB> GetRepDocPendientescobranza(int ide,string tipo, int cli, string f1, string f2)
        {
            return negocio.GetRepDocPendicob(new EMS_VOUCHERHE()
            {
                VH_ISTATUS = tipo,
                VH_IDCUSTOMER = cli,
                VH_VOUCHERDATE = f1,
                VH_DELIVERDATE = f2,
                VH_IDCOMPANY = ide
            }
            );
        }

        [HttpGet, Route("{ide}/vtasxdia/{f1}/{f2}")]
        public IEnumerable<EREP_VTASXDIA> GetRepVentasxDia(int ide, string f1, string f2)
        {
            return negocio.GetRepVtasxDia(new EMS_VOUCHERHE()
            {
                VH_VOUCHERDATE = f1,
                VH_DELIVERDATE = f2,
                VH_IDCOMPANY = ide
            }
            );
        }



    }
}
