using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using BE.Herramientas;
using BL.Herramientas;

namespace WA_AndesTec.Controllers
{
    [EnableCors("*", "*", "*")]
    [RoutePrefix("MA_CURRENCY_EXCHANGE")]
    public class MA_CURRENCY_EXCHANGEController : ApiController
    {
        MA_CURRENCY_EXCHANGEBL negocio = new MA_CURRENCY_EXCHANGEBL();

        [HttpGet, Route("{ide}/{ayo}/{mes}")]
        public IEnumerable<EMA_CURRENCY_EXCHANGE> GetPorMes(int ide, int ayo, int mes)
        {
            var fecha = new DateTime(ayo, mes, 1);
            return negocio.ListarPorMes(new EMA_CURRENCY_EXCHANGE { CHANGEDATE = fecha.ToString(), IDEMPRESA = ide });
        }

        [HttpGet, Route("{ide}/{ayo}/{mes}/{dia}")]
        public EMA_CURRENCY_EXCHANGE GetPorFecha(int ide, int ayo,int mes,int dia)
        {
            var fecha = new DateTime(ayo, mes, dia);
            return negocio.ListarxFecha(new EMA_CURRENCY_EXCHANGE { CHANGEDATE = fecha.ToString(), IDEMPRESA = ide });
        }

        [HttpPost, Route("")]
        public string Post([FromBody]EMA_CURRENCY_EXCHANGE value)
        {
            return negocio.Registrar(value);
        }

        [HttpPut, Route("")]
        public string Put([FromBody]EMA_CURRENCY_EXCHANGE value)
        {
            return negocio.Actualizar(value);
        }

        [HttpDelete, Route("{ide}/{mo}/{ayo}/{mes}/{dia}")]
        public string Delete(int ide, int ayo, int mes, int dia, string mo)
        {
            var fecha = new DateTime(ayo,mes,dia);
            return negocio.Eliminar(new EMA_CURRENCY_EXCHANGE { CHANGEDATE = fecha.ToString(), IDCURRENCY = mo, IDEMPRESA = ide });
        }
    }
}
