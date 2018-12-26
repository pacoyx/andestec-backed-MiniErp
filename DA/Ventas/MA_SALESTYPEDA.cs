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

        public static string Insert(EMA_SALESTYPE e)
        {
            string rpta = "ok";
            try
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
            catch (Exception ex) { rpta = ex.Message; }
            return rpta;
        }

        public static string Update(EMA_SALESTYPE e)
        {
            string rpta = "ok";
            try
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
            catch (Exception ex) { rpta = ex.Message; }
            return rpta;
        }

        public static string Delete(EMA_SALESTYPE e)
        {
            string rpta = "ok";
            try
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
            catch (Exception ex) { rpta = ex.Message; }
            return rpta;
        }

        public static List<EMA_SALESTYPE> GetAll(EMA_SALESTYPE e)
        {
            var sql = "SP_S_MA_SALESTYPE";
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {                
                return cnx.Query<EMA_SALESTYPE>(sql, new { P_ST_IDCOMPANY = e.ST_IDCOMPANY }, commandType: CommandType.StoredProcedure).ToList();
            }
        }

        public static EMA_SALESTYPE GetByid(EMA_SALESTYPE e)
        {
            var sql = "SP_S_MA_SALESTYPE_BYID";
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {                 
                return cnx.Query<EMA_SALESTYPE>(sql, new { P_ST_ID = e.ST_ID, P_ST_IDCOMPANY = e.ST_IDCOMPANY }, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
        }

    }
}
