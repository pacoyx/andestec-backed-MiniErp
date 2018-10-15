using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE.Caja;
using Dapper;
using System.Data.SqlClient;
using System.Data;

namespace DA.Caja
{
    public static class CA_CUSTOM_BALANCEDA
    {
        //listado de documentos pendinetes por cobrar por cliente
        public static List<ECA_CUSTOM_BALANCE> GetCarteraPorCliente(ECA_CUSTOM_BALANCE e)
        {
            var sql = "SP_S_CUSTOM_BALANCE_BYCLI";
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                return cnx.Query<ECA_CUSTOM_BALANCE>(sql, new
                {
                    P_CM_CUSTOMER_ID = e.CM_CUSTOMER_ID,
                    P_CM_IDCOMPANY = e.CM_IDCOMPANY
                },
                    commandType: CommandType.StoredProcedure).ToList();
            }
        }
    }
}
