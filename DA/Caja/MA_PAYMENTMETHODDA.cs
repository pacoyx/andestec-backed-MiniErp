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
    public static class MA_PAYMENTMETHODDA
    {
        public static string Insert(EMA_PAYMENTMETHOD e)
        {
            string rpta = "";
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                string sql = "SP_I_MA_PAYMENTMETHOD";
                cnx.Execute(sql, new
                {
                    P_PM_ID = e.PM_ID,
                    P_PM_DES = e.PM_DES,
                    P_PM_ISTATUS = e.PM_ISTATUS,
                    P_PM_IDCOMPANY = e.PM_IDCOMPANY
                },
                            commandType: CommandType.StoredProcedure);
            }
            return rpta;
        }

        public static string Update(EMA_PAYMENTMETHOD e)
        {
            string rpta = "";
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                string sql = "SP_U_MA_PAYMENTMETHOD";
                cnx.Execute(sql, new
                {
                    P_PM_ID = e.PM_ID,
                    P_PM_DES = e.PM_DES,
                    P_PM_ISTATUS = e.PM_ISTATUS,
                    P_PM_IDCOMPANY = e.PM_IDCOMPANY
                },
                            commandType: CommandType.StoredProcedure);
            }
            return rpta;
        }

        public static string Delete(EMA_PAYMENTMETHOD e)
        {
            string rpta = "";
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                string sql = "SP_D_MA_PAYMENTMETHOD";
                cnx.Execute(sql, new
                {
                    P_PM_ID = e.PM_ID,
                    P_PM_IDCOMPANY = e.PM_IDCOMPANY
                },
                            commandType: CommandType.StoredProcedure);
            }
            return rpta;
        }

        public static List<EMA_PAYMENTMETHOD> GetAll(EMA_PAYMENTMETHOD e)
        {
            var sql = "SP_S_MA_PAYMENTMETHOD";
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                return cnx.Query<EMA_PAYMENTMETHOD>(sql, new { P_PM_IDCOMPANY = e.PM_IDCOMPANY }, commandType: CommandType.StoredProcedure).ToList();
            }
        }
        
        public static EMA_PAYMENTMETHOD GetByid(EMA_PAYMENTMETHOD e)
        {
            var sql = "SP_S_MA_PAYMENTMETHOD_BYID";
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                return cnx.Query<EMA_PAYMENTMETHOD>(sql, new { P_PM_ID = e.PM_ID, P_PM_IDCOMPANY = e.PM_IDCOMPANY }, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
        }

    }
}
