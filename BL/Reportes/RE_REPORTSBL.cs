using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE.Almacen;
using BE.Ventas;
using BE.Caja;
using DA.Reportes;


namespace BL.Reportes
{
    public class RE_REPORTSBL
    {
        public List<EREP_INVKARDEX> GetRepAlmacenKardex(ETRA_WAREHOUSE ee) { return RE_REPORTSDA.GetRepAlmacenKardex(ee); }
        public List<EREP_INVTRANSAC> GetRepAlmacenTransacciones(ETRA_WAREHOUSE ee) { return RE_REPORTSDA.GetRepAlmacenTransacciones(ee); }
        public List<EREP_INVSTOCK> GetRepAlmacenStock(ETRA_WAREHOUSE ee) { return RE_REPORTSDA.GetRepAlmacenStock(ee); }

        public List<EREP_SELVTAXSEL> GetRepVentasxVendedor(EMS_VOUCHERHE ee) { return RE_REPORTSDA.GetRepVentasxVendedor(ee); }
        public List<EREP_SELVTAXARTI> GetRepVentasxArticulo(EMS_VOUCHERHE ee) { return RE_REPORTSDA.GetRepVentasxArticulo(ee); }
        public List<EREP_SELVTAXCUSTO> GetRepVentasxCliente(EMS_VOUCHERHE ee) { return RE_REPORTSDA.GetRepVentasxCliente(ee); }
        public List<EREP_REGVENTAS> GetRepRegVentas(EMS_VOUCHERHE ee) { return RE_REPORTSDA.GetRepRegVentas(ee); }
        public List<ERE_DOCPENDICOB> GetRepDocPendicob(EMS_VOUCHERHE ee) { return RE_REPORTSDA.GetRepDocPendicob(ee); }

    }
}
