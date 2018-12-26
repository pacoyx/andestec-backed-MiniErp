using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE.Ventas;
using DA.Ventas;

namespace BL.Ventas
{
    public class MA_USERSALESPOINTBL
    {
        public string Registrar(EMA_USERSALESPOINT ee) { return MA_USERSALESPOINTDA.Insert(ee); }
        public string Eliminar(EMA_USERSALESPOINT ee) { return MA_USERSALESPOINTDA.Delete(ee); }
        public List<EMA_USERSALESPOINT> Listar(EMA_USERSALESPOINT ee) { return MA_USERSALESPOINTDA.GetAll(ee); }
    }
}
