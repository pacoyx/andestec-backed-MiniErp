using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE.Ventas;
using Dapper;
using System.Data.SqlClient;
using System.Data;

namespace DA.Ventas
{
    public static class MA_SALESPOINTDA
    {
        public static void Insert(EMA_SALESPOINT e)
        {
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                string sql = "SP_I_MA_SALESPOINT";
                cnx.Execute(sql, new
                {
                    P_SP_ID = e.SP_ID,
                    P_SP_DES = e.SP_DES,
                    P_SP_ADD = e.SP_ADD,
                    P_SP_PHONE = e.SP_PHONE,
                    P_SP_COMMENT = e.SP_COMMENT,
                    P_SP_ISTATUS = e.SP_ISTATUS,
                    P_SP_IDCOMPANY = e.SP_IDCOMPANY
                },
                            commandType: CommandType.StoredProcedure);
            }
        }

        public static void Update(EMA_SALESPOINT e)
        {
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                string sql = "SP_U_MA_SALESPOINT";
                cnx.Execute(sql, new
                {
                    P_SP_ID = e.SP_ID,
                    P_SP_DES = e.SP_DES,
                    P_SP_ADD = e.SP_ADD,
                    P_SP_PHONE = e.SP_PHONE,
                    P_SP_COMMENT = e.SP_COMMENT,
                    P_SP_ISTATUS = e.SP_ISTATUS,
                    P_SP_IDCOMPANY = e.SP_IDCOMPANY
                },
                            commandType: CommandType.StoredProcedure);
            }
        }

        public static void Delete(EMA_SALESPOINT e)
        {
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                string sql = "SP_D_MA_SALESPOINT";
                cnx.Execute(sql, new
                {
                    P_SP_ID = e.SP_ID,                    
                    P_SP_IDCOMPANY = e.SP_IDCOMPANY
                },
                            commandType: CommandType.StoredProcedure);
            }
        }

        public static List<EMA_SALESPOINT> GetAll(EMA_SALESPOINT e)
        {
            var sql = "SP_S_MA_SALESPOINT";
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                cnx.Open();
                return cnx.Query<EMA_SALESPOINT>(sql, new { P_SP_IDCOMPANY = e.SP_IDCOMPANY }, commandType: CommandType.StoredProcedure).ToList();
            }
        }

        public static EMA_SALESPOINT GetByid(EMA_SALESPOINT e)
        {
            var sql = "SP_S_MA_SALESPOINT_BYID";
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                cnx.Open();
                return cnx.Query<EMA_SALESPOINT>(sql, new { P_SP_IDCOMPANY = e.SP_IDCOMPANY, P_SP_ID = e.SP_ID }, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
        }



    }
}
