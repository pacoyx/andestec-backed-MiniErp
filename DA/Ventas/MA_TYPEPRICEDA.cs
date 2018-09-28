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
    public static class MA_TYPEPRICEDA
    {
        public static void Insert(EMA_TYPEPRICE e)
        {
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                string sql = "SP_I_MA_TYPEPRICE";
                cnx.Execute(sql, new
                {
                    PTP_ID = e.TP_ID,
                    PTP_DES = e.TP_DES,
                    PTP_IDCOMPANY = e.TP_IDCOMPANY
                },
                            commandType: CommandType.StoredProcedure);
            }
        }

        public static void Update(EMA_TYPEPRICE e)
        {
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                string sql = "SP_U_MA_TYPEPRICE";
                cnx.Execute(sql, new
                {
                    PTP_ID = e.TP_ID,
                    PTP_DES = e.TP_DES,
                    PTP_IDCOMPANY = e.TP_IDCOMPANY
                },
                            commandType: CommandType.StoredProcedure);
            }
        }

        public static void Delete(EMA_TYPEPRICE e)
        {
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                string sql = "SP_D_MA_TYPEPRICE";
                cnx.Execute(sql, new
                {
                    PTP_ID = e.TP_ID,                    
                    PTP_IDCOMPANY = e.TP_IDCOMPANY
                },
                            commandType: CommandType.StoredProcedure);
            }
        }

        public static List<EMA_TYPEPRICE> GetAll(EMA_TYPEPRICE e)
        {
            var sql = "SP_D_MA_TYPEPRICE";
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                cnx.Open();
                return cnx.Query<EMA_TYPEPRICE>(sql, new { PTP_IDCOMPANY = e.TP_IDCOMPANY }, commandType: CommandType.StoredProcedure).ToList();
            }
        }

        public static EMA_TYPEPRICE GetByid(EMA_TYPEPRICE e)
        {
            var sql = "SP_D_MA_TYPEPRICE_BYID";
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                cnx.Open();
                return cnx.Query<EMA_TYPEPRICE>(sql, new { PTP_ID = e.TP_ID, PTP_IDCOMPANY = e.TP_IDCOMPANY }, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
        }

    }


}
