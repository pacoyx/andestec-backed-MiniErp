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
    public static class MA_SELLERDA
    {
        public static void Insert(EMA_SELLER e)
        {
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                string sql = "SP_I_MA_SELLER";
                cnx.Execute(sql, new
                {
                    P_SE_ID = e.SE_ID,
                    P_SE_DESCRIPCION = e.SE_DESCRIPCION,
                    P_SE_IDCOMPANY = e.SE_IDCOMPANY,
                    P_SE_DNI = e.SE_DNI,
                    P_SE_ADD = e.SE_ADD,
                    P_SE_PHONE = e.SE_PHONE,
                    P_SE_EMAIL = e.SE_EMAIL,
                    P_SE_ISTATUS = e.SE_ISTATUS
                },
                            commandType: CommandType.StoredProcedure);
            }
        }

        public static void Update(EMA_SELLER e)
        {
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                string sql = "SP_U_MA_SELLER";
                cnx.Execute(sql, new
                {
                    P_SE_ID = e.SE_ID,
                    P_SE_DESCRIPCION = e.SE_DESCRIPCION,
                    P_SE_IDCOMPANY = e.SE_IDCOMPANY,
                    P_SE_DNI = e.SE_DNI,
                    P_SE_ADD = e.SE_ADD,
                    P_SE_PHONE = e.SE_PHONE,
                    P_SE_EMAIL = e.SE_EMAIL,
                    P_SE_ISTATUS = e.SE_ISTATUS
                },
                            commandType: CommandType.StoredProcedure);
            }
        }

        public static void Delete(EMA_SELLER e)
        {
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                string sql = "SP_D_MA_SELLER";
                cnx.Execute(sql, new
                {
                    P_SE_ID = e.SE_ID,                    
                    P_SE_IDCOMPANY = e.SE_IDCOMPANY
                },
                            commandType: CommandType.StoredProcedure);
            }
        }

        public static List<EMA_SELLER> GetAll(EMA_SELLER e)
        {
            var sql = "SP_S_MA_SELLER";
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                cnx.Open();
                return cnx.Query<EMA_SELLER>(sql, new { P_SE_IDCOMPANY = e.SE_IDCOMPANY }, commandType: CommandType.StoredProcedure).ToList();
            }
        }

        public static EMA_SELLER GetByid(EMA_SELLER e)
        {
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                var sql = "SP_S_MA_SELLER_BYID";
                cnx.Open();
                return cnx.Query<EMA_SELLER>(sql, new { P_SE_ID = e.SE_ID, P_SE_IDCOMPANY = e.SE_IDCOMPANY }, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
        }
        
    }
}
