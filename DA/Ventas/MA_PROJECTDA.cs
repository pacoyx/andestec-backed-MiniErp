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
        public static void Insert(EMA_PROJECT e)
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

        public static void Update(EMA_PROJECT e)
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

        public static void Delete(EMA_PROJECT e)
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

        public static List<EMA_PROJECT> GetAll(EMA_PROJECT e)
        {
            var sql = "SP_S_MA_PROJECT";
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                cnx.Open();
                return cnx.Query<EMA_PROJECT>(sql, new { P_PJ_IDCOMPANY = e.PJ_IDCOMPANY }, commandType: CommandType.StoredProcedure).ToList();
            }
        }

        public static EMA_PROJECT GetByid(EMA_PROJECT e)
        {
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                var sql = "SP_S_MA_PROJECT_BYID";
                cnx.Open();
                return cnx.Query<EMA_PROJECT>(sql, new { P_PJ_ID = e.PJ_ID, P_PJ_IDCOMPANY = e.PJ_IDCOMPANY }, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
        }

    }

}
