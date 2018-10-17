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
    public static class MA_CREDITCARDDA
    {
        public static string Insert(EMA_CREDITCARD e)
        {
            string rpta = "";
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                string sql = "SP_I_MA_CREDITCARD";
                cnx.Execute(sql, new
                {
                    P_CC_ID = e.CC_ID,
                    P_CC_DES = e.CC_DES,
                    P_CC_ISTATUS = e.CC_ISTATUS,
                    P_CC_IDCOMPANY = e.CC_IDCOMPANY
                },
                            commandType: CommandType.StoredProcedure);
            }
            return rpta;
        }

        public static string Update(EMA_CREDITCARD e)
        {
            string rpta = "";
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                string sql = "SP_U_MA_CREDITCARD";
                cnx.Execute(sql, new
                {
                    P_CC_ID = e.CC_ID,
                    P_CC_DES = e.CC_DES,
                    P_CC_ISTATUS = e.CC_ISTATUS,
                    P_CC_IDCOMPANY = e.CC_IDCOMPANY
                },
                            commandType: CommandType.StoredProcedure);
            }
            return rpta;
        }

        public static string Delete(EMA_CREDITCARD e)
        {
            string rpta = "";
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                string sql = "SP_D_MA_CREDITCARD";
                cnx.Execute(sql, new
                {
                    P_CC_ID = e.CC_ID,
                    P_CC_DES = e.CC_DES,
                    P_CC_ISTATUS = e.CC_ISTATUS,
                    P_CC_IDCOMPANY = e.CC_IDCOMPANY
                },
                            commandType: CommandType.StoredProcedure);
            }
            return rpta;
        }

        public static List<EMA_CREDITCARD> GetAll(EMA_CREDITCARD e)
        {
            var sql = "SP_S_MA_CREDITCARD";
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                return cnx.Query<EMA_CREDITCARD>(sql, new { P_CC_IDCOMPANY = e.CC_IDCOMPANY }, commandType: CommandType.StoredProcedure).ToList();
            }
        }


        public static EMA_CREDITCARD GetByid(EMA_CREDITCARD e)
        {
            var sql = "SP_S_MA_CREDITCARD_BYID";
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                return cnx.Query<EMA_CREDITCARD>(sql, new { P_CC_ID = e.CC_ID, P_CC_IDCOMPANY = e.CC_IDCOMPANY }, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
        }


    }
}
