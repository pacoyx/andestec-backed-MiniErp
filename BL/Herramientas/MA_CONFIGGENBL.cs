using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE.Herramientas;
using DA.Herramientas;

namespace BL.Herramientas
{
    public class MA_CONFIGGENBL
    {
        public string Actualizar(EMA_CONFIGGEN ee) { return MA_CONFIGGENDA.Update(ee); }
        public EMA_CONFIGGEN ListarTodo(int emp) { return MA_CONFIGGENDA.GetTodos(emp); }
    }
}
