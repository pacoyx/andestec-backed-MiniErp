using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE.Herramientas;
using Dapper;
using System.Data.SqlClient;
using System.Data;

namespace DA.Herramientas
{
    public static class MA_CONFIGGENDA
    {

        public static string Update(EMA_CONFIGGEN e)
        {
            string rpta = "ok";
            try
            {
                using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
                {
                    string sql = "SP_U_MA_CONFIGGEN";
                    cnx.Execute(sql, new
                    {
                        P_PRE_IVA = e.PRE_IVA,
                        P_IDCOMPANY = e.IDCOMPANY
                    },
                                commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex) { rpta = ex.Message; }
            return rpta;
        }

        public static EMA_CONFIGGEN GetTodos(int emp)
        {
            var sql = "SP_S_MA_CONFIGGEN";
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                return cnx.Query<EMA_CONFIGGEN>(sql, new
                {
                    P_IDCOMPANY = emp
                }, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
        }

    }
}
