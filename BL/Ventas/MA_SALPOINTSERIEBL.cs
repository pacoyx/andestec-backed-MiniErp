using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE.Ventas;
using DA.Ventas;

namespace BL.Ventas
{
    public class MA_SALPOINTSERIEBL
    {
        public void Registrar(EMA_SALPOINTSERIE ee) {  MA_SALPOINTSERIEDA.Insert(ee);}
        public void Eliminar(EMA_SALPOINTSERIE ee) { MA_SALPOINTSERIEDA.Delete(ee); }
        public List<EMA_SALPOINTSERIE> Listar(EMA_SALPOINTSERIE ee) { return MA_SALPOINTSERIEDA.GetAll(ee); }     
        public List<EMA_SALPOINTSERIE> ListarSerieCorrelativo(EMA_SALPOINTSERIE ee) { return MA_SALPOINTSERIEDA.GetSerieCorrelativo(ee); }     
        public List<EMA_SALPOINTSERIE> ListarDocxPtoVta(EMA_SALPOINTSERIE ee) { return MA_SALPOINTSERIEDA.GetDocxPtoVta(ee); }     
    }
}
