using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using BE.Ventas;
using Dapper;


namespace DA.Ventas
{
    public static class MA_SALESTYPEDA
    {
        public static void Insert(EMA_SALESTYPE e)
        {
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                string sql = "SP_I_MA_SALESTYPE";
                cnx.Execute(sql, new
                {
                    P_ST_ID = e.ST_ID,
                    P_ST_DES = e.ST_DES,
                    P_ST_IDCOMPANY = e.ST_IDCOMPANY
                },
                            commandType: CommandType.StoredProcedure);
            }
        }

        public static void Update(EMA_SALESTYPE e)
        {
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                string sql = "SP_U_MA_SALESTYPE";
                cnx.Execute(sql, new
                {
                    P_ST_ID = e.ST_ID,
                    P_ST_DES = e.ST_DES,
                    P_ST_IDCOMPANY = e.ST_IDCOMPANY
                },
                            commandType: CommandType.StoredProcedure);
            }
        }

        public static void Delete(EMA_SALESTYPE e)
        {
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                string sql = "SP_D_MA_SALESTYPE";
                cnx.Execute(sql, new
                {
                    P_ST_ID = e.ST_ID,                    
                    P_ST_IDCOMPANY = e.ST_IDCOMPANY
                },
                            commandType: CommandType.StoredProcedure);
            }
        }

        public static List<EMA_SALESTYPE> GetAll(EMA_SALESTYPE e)
        {
            var sql = "SP_S_MA_SALESTYPE";
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                cnx.Open();
                return cnx.Query<EMA_SALESTYPE>(sql, new { P_ST_IDCOMPANY = e.ST_IDCOMPANY }, commandType: CommandType.StoredProcedure).ToList();
            }
        }

        public static EMA_SALESTYPE GetByid(EMA_SALESTYPE e)
        {
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                var sql = "SP_S_MA_SALESTYPE_BYID";
                cnx.Open();
                return cnx.Query<EMA_SALESTYPE>(sql, new { P_ST_ID = e.ST_ID, P_ST_IDCOMPANY = e.ST_IDCOMPANY }, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
        }

    }
}
