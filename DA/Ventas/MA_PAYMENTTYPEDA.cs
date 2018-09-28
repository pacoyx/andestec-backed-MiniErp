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
    public static class MA_PAYMENTTYPEDA
    {
        public static void Insert(EMA_PAYMENTTYPE e)
        {
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                string sql = "SP_I_MA_PAYMENTTYPE";
                cnx.Execute(sql, new
                {
                    P_PT_ID = e.PT_ID,
                    P_PT_DES = e.PT_DES,
                    P_PT_IDCOMPANY = e.PT_IDCOMPANY
                },
                            commandType: CommandType.StoredProcedure);
            }
        }

        public static void Update(EMA_PAYMENTTYPE e)
        {
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                string sql = "SP_U_MA_PAYMENTTYPE";
                cnx.Execute(sql, new
                {
                    P_PT_ID = e.PT_ID,
                    P_PT_DES = e.PT_DES,
                    P_PT_IDCOMPANY = e.PT_IDCOMPANY
                },
                            commandType: CommandType.StoredProcedure);
            }
        }

        public static void Delete(EMA_PAYMENTTYPE e)
        {
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                string sql = "SP_D_MA_PAYMENTTYPE";
                cnx.Execute(sql, new
                {
                    P_PT_ID = e.PT_ID,                    
                    P_PT_IDCOMPANY = e.PT_IDCOMPANY
                },
                            commandType: CommandType.StoredProcedure);
            }
        }

        public static List<EMA_PAYMENTTYPE> GetAll(EMA_PAYMENTTYPE e)
        {
            var sql = "SP_S_MA_PAYMENTTYPE";
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                cnx.Open();
                return cnx.Query<EMA_PAYMENTTYPE>(sql, new { P_PT_IDCOMPANY = e.PT_IDCOMPANY }, commandType: CommandType.StoredProcedure).ToList();
            }
        }

        public static EMA_PAYMENTTYPE GetByid(EMA_PAYMENTTYPE e)
        {
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                var sql = "SP_S_MA_PAYMENTTYPE_BYID";
                cnx.Open();
                return cnx.Query<EMA_PAYMENTTYPE>(sql, new { P_PT_ID = e.PT_ID, P_PT_IDCOMPANY = e.PT_IDCOMPANY }, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
        }

    }
}
