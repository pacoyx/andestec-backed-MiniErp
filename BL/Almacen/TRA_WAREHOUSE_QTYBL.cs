using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE.Almacen;
using DA.Almacen;

namespace BL.Almacen
{
    public class TRA_WAREHOUSE_QTYBL
    {
        public ETRA_WAREHOUSE_QTY StockxArti(ETRA_WAREHOUSE_QTY ee) => TRA_WAREHOUSE_QTYDA.GetStock(ee);
        public ERE_LISTA07 StockxLote(ETRA_WAREHOUSE_QTY_LOT ee) => TRA_WAREHOUSE_QTYDA.GetStockxLote(ee);
        public double StockTotalxLote(ETRA_WAREHOUSE_QTY ee) => TRA_WAREHOUSE_QTYDA.getStockTotalxLote(ee);
    }
}
