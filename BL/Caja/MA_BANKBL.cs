﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE.Caja;
using DA.Caja;

namespace BL.Caja
{
    public class MA_BANKBL
    {
        public string Registrar(EMA_BANK ee) { if (MA_BANKDA.GetByid(ee) == null) { return MA_BANKDA.Insert(ee); } else {return MA_BANKDA.Update(ee); } }
        public string Eliminar(EMA_BANK ee) { return MA_BANKDA.Delete(ee); }
        public List<EMA_BANK> Listar(EMA_BANK ee) { return MA_BANKDA.GetAll(ee); }
        public EMA_BANK ListarxId(EMA_BANK ee) => MA_BANKDA.GetByid(ee);
    }
}
