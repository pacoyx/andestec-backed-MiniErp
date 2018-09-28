﻿using System;
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
    [RoutePrefix("MA_CUSTOMER")]
    public class MA_CUSTOMERController : ApiController
    {
        MA_CUSTOMERBL negocio = new MA_CUSTOMERBL();

        [HttpGet, Route("{ide}")]
        public IEnumerable<EMA_CUSTOMER> Get(int ide)
        {
            return negocio.Listar(new EMA_CUSTOMER { ID_COMPANY = ide });
        }

        [HttpGet, Route("{ide}/{id}")]
        public EMA_CUSTOMER Get(int ide, int id)
        {
            return negocio.ListarxId(new EMA_CUSTOMER { ID_CUSTOMER = id, ID_COMPANY = ide });
        }

        [HttpGet, Route("{ide}/buscar/{dato}")]
        public IEnumerable<EMA_CUSTOMER> GetBuscarxNombre(int ide,string dato)
        {
            return negocio.ListarPorNombre(new EMA_CUSTOMER { ID_COMPANY = ide, DESCRIPTION_CUSTOMER = dato });
        }

        [HttpPost, Route("")]
        public void Post([FromBody]EMA_CUSTOMER value)
        {
            negocio.Registrar(value);
        }

        [HttpPut, Route("")]
        public void Put([FromBody]EMA_CUSTOMER value)
        {
            negocio.Registrar(value);
        }

        [HttpDelete, Route("{ide}/{id}")]
        public void Delete(int ide, int id)
        {
            negocio.Eliminar(new EMA_CUSTOMER { ID_COMPANY = ide, ID_CUSTOMER = id });
        }
    }
}
