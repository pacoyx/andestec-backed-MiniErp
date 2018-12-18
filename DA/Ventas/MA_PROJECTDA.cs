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
    public static class MA_PROJECTDA
    {
        public static string Insert(EMA_PROJECT e)
        {
            string rpta = "ok";
            try
            {
                using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
                {
                    string sql = "SP_I_MA_PROJECT";
                    cnx.Execute(sql, new
                    {
                        P_PJ_ID = e.PJ_ID,
                        P_PJ_DES = e.PJ_DES,
                        P_PJ_IDCOMPANY = e.PJ_IDCOMPANY
                    },
                                commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex) { rpta = ex.Message; }
            return rpta;
        }

        public static string Update(EMA_PROJECT e)
        {
            string rpta = "ok";
            try
            {
                using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
                {
                    string sql = "SP_U_MA_PROJECT";
                    cnx.Execute(sql, new
                    {
                        P_PJ_ID = e.PJ_ID,
                        P_PJ_DES = e.PJ_DES,
                        P_PJ_IDCOMPANY = e.PJ_IDCOMPANY
                    },
                                commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex) { rpta = ex.Message; }
            return rpta;
        }

        public static string Delete(EMA_PROJECT e)
        {
            string rpta = "ok";
            try
            {
                using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
                {
                    string sql = "SP_D_MA_PROJECT";
                    cnx.Execute(sql, new
                    {
                        P_PJ_ID = e.PJ_ID,
                        P_PJ_IDCOMPANY = e.PJ_IDCOMPANY
                    },
                                commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex) { rpta = ex.Message; }
            return rpta;
        }

        public static List<EMA_PROJECT> GetAll(EMA_PROJECT e)
        {
            var sql = "SP_S_MA_PROJECT";
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {                
                return cnx.Query<EMA_PROJECT>(sql, new { P_PJ_IDCOMPANY = e.PJ_IDCOMPANY }, commandType: CommandType.StoredProcedure).ToList();
            }
        }

        public static EMA_PROJECT GetByid(EMA_PROJECT e)
        {
            var sql = "SP_S_MA_PROJECT_BYID";
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                return cnx.Query<EMA_PROJECT>(sql, new { P_PJ_ID = e.PJ_ID, P_PJ_IDCOMPANY = e.PJ_IDCOMPANY }, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
        }

    }

}
