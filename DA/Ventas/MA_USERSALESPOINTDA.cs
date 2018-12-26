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
    public static class MA_USERSALESPOINTDA
    {
        public static string Insert(EMA_USERSALESPOINT e)
        {
            string rpta = "ok";
            try
            {
                using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
                {
                    string sql = "SP_I_USERSALESPOINT";
                    cnx.Execute(sql, new
                    {
                        P_US_IDUSER = e.US_IDUSER,
                        P_US_IDSALESPOINT = e.US_IDSALESPOINT,
                        P_US_IDCOMPANY = e.US_IDCOMPANY
                    },
                                commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex) { rpta = ex.Message; }
            return rpta;
        }

        public static string Delete(EMA_USERSALESPOINT e)
        {
            string rpta = "ok";
            try
            {
                using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
                {
                    string sql = "SP_D_USERSALESPOINT";
                    cnx.Execute(sql, new
                    {
                        P_US_IDUSER = e.US_IDUSER,
                        P_US_IDSALESPOINT = e.US_IDSALESPOINT,
                        P_US_IDCOMPANY = e.US_IDCOMPANY
                    },
                                commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex) { rpta = ex.Message; }
            return rpta;
        }

        public static List<EMA_USERSALESPOINT> GetAll(EMA_USERSALESPOINT e)
        {
            var sql = "SP_S_USERSALESPOINT";
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                return cnx.Query<EMA_USERSALESPOINT>(sql, new
                {                    
                    P_US_IDCOMPANY = e.US_IDCOMPANY
                },
                commandType: CommandType.StoredProcedure).ToList();
            }
        }

    }
}
