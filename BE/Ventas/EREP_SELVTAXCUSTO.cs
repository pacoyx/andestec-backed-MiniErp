﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Ventas
{
    public class EREP_SELVTAXCUSTO
    {
        public string CLIENTE { get; set; }
        public string FECHA { get; set; }
        public string TIPDOC { get; set; }
        public string SERDOC { get; set; }
        public string NUMDOC { get; set; }
        public string MONEDA { get; set; }
        public double VALORVTA { get; set; }
        public double IMPUESTO { get; set; }
        public double TOTAL { get; set; }
        public double TC { get; set; }
        public int ITEM { get; set; }
        public int IDARTICULO { get; set; }
        public string DESARTICULO { get; set; }
        public double CANT { get; set; }
    }
}
