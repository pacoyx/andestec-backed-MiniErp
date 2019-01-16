using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            BE.Almacen.EMA_FAMILY eFa = new BE.Almacen.EMA_FAMILY
            {
                ID_COMPANY = 1,
                ID_FAMILY = 3,
                DESCRIPTION_FAMILY = "prueba de botones"
            };
            //DA.Almacen.MA_FAMILYDA eje = new DA.Almacen.MA_FAMILYDA();
            //eje.Insert(eFa);

        }
    }
}
