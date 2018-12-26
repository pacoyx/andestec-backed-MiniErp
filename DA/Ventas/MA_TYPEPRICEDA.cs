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
        public static string Insert(EMA_TYPEPRICE e)
        {
            string rpta = "ok";
            try
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
            catch (Exception ex) { rpta = ex.Message; }
            return rpta;
        }

        public static string Update(EMA_TYPEPRICE e)
        {
            string rpta = "ok";
            try
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
            catch (Exception ex) { rpta = ex.Message; }
            return rpta;
        }

        public static string Delete(EMA_TYPEPRICE e)
        {
            string rpta = "ok";
            try
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
            catch (Exception ex) { rpta = ex.Message; }
            return rpta;
        }

        public static List<EMA_TYPEPRICE> GetAll(EMA_TYPEPRICE e)
        {
            var sql = "SP_S_MA_TYPEPRICE";
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                cnx.Open();
                return cnx.Query<EMA_TYPEPRICE>(sql, new { PTP_IDCOMPANY = e.TP_IDCOMPANY }, commandType: CommandType.StoredProcedure).ToList();
            }
        }

        public static EMA_TYPEPRICE GetByid(EMA_TYPEPRICE e)
        {
            var sql = "SP_S_MA_TYPEPRICE_BYID";
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                cnx.Open();
                return cnx.Query<EMA_TYPEPRICE>(sql, new { PTP_ID = e.TP_ID, PTP_IDCOMPANY = e.TP_IDCOMPANY }, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
        }

    }


}
