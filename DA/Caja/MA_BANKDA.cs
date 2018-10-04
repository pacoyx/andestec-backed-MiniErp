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
    public static class MA_BANKDA
    {
        public static void Insert(EMA_BANK e)
        {
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                string sql = "SP_I_MA_BANK";
                cnx.Execute(sql, new
                {
                    P_BA_IDBANK = e.BA_IDBANK,
                    P_BA_DESCRIPTIONS = e.BA_DESCRIPTIONS,
                    P_BA_ISTATUS = e.BA_ISTATUS,
                    P_BA_IDCOMPANY = e.BA_IDCOMPANY
                },
                            commandType: CommandType.StoredProcedure);
            }
        }

        public static void Update(EMA_BANK e)
        {
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                string sql = "SP_U_MA_BANK";
                cnx.Execute(sql, new
                {
                    P_BA_IDBANK = e.BA_IDBANK,
                    P_BA_DESCRIPTIONS = e.BA_DESCRIPTIONS,
                    P_BA_ISTATUS = e.BA_ISTATUS,
                    P_BA_IDCOMPANY = e.BA_IDCOMPANY
                },
                            commandType: CommandType.StoredProcedure);
            }
        }

        public static void Delete(EMA_BANK e)
        {
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                string sql = "SP_D_MA_BANK";
                cnx.Execute(sql, new
                {
                    P_BA_IDBANK = e.BA_IDBANK,                    
                    P_BA_IDCOMPANY = e.BA_IDCOMPANY
                },
                            commandType: CommandType.StoredProcedure);
            }
        }

        public static List<EMA_BANK> GetAll(EMA_BANK e)
        {
            var sql = "SP_S_MA_BANK";
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {                
                return cnx.Query<EMA_BANK>(sql, new { P_BA_IDCOMPANY = e.BA_IDCOMPANY }, commandType: CommandType.StoredProcedure).ToList();
            }
        }

        public static EMA_BANK GetByid(EMA_BANK e)
        {
            var sql = "SP_S_MA_BANK_BYID";
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {                                
                return cnx.Query<EMA_BANK>(sql, new { P_BA_IDBANK = e.BA_IDBANK, P_BA_IDCOMPANY = e.BA_IDCOMPANY }, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
        }

    }
}
