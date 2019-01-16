using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE.Herramientas;
using Dapper;
using System.Data.SqlClient;
using System.Data;

namespace DA.Herramientas
{
    public static class MA_CURRENCY_EXCHANGEDA
    {
        public static string Insert(EMA_CURRENCY_EXCHANGE e)
        {
            string rpta = "ok";
            try
            {
                using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
                {
                    string sql = "SP_I_MA_CURRENCY_EXCHANGE";
                    cnx.Execute(sql, new
                    {
                        P_CHANGEDATE = e.CHANGEDATE,
                        P_IDCURRENCY = e.IDCURRENCY,
                        P_BUY = e.BUY,
                        P_SELL = e.SELL,
                        P_IDEMPRESA = e.IDEMPRESA
                    },
                                commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex) { rpta = ex.Message; }
            return rpta;
        }

        public static string Update(EMA_CURRENCY_EXCHANGE e)
        {
            string rpta = "ok";
            try
            {
                using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
                {
                    string sql = "SP_U_MA_CURRENCY_EXCHANGE";
                    cnx.Execute(sql, new
                    {
                        P_CHANGEDATE = e.CHANGEDATE,
                        P_IDCURRENCY = e.IDCURRENCY,
                        P_BUY = e.BUY,
                        P_SELL = e.SELL,
                        P_IDEMPRESA = e.IDEMPRESA
                    },
                                commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex) { rpta = ex.Message; }
            return rpta;
        }

        public static string Delete(EMA_CURRENCY_EXCHANGE e)
        {
            string rpta = "ok";
            try
            {
                using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
                {
                    string sql = "SP_D_MA_CURRENCY_EXCHANGE";
                    cnx.Execute(sql, new    
                    {
                        P_AYO = DateTime.Parse( e.CHANGEDATE).Year,
                        P_MES = DateTime.Parse(e.CHANGEDATE).Month,
                        P_DIA = DateTime.Parse(e.CHANGEDATE).Day,
                        P_IDCURRENCY = e.IDCURRENCY,                        
                        P_IDEMPRESA = e.IDEMPRESA
                    },
                                commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex) { rpta = ex.Message; }
            return rpta;
        }

        public static List<EMA_CURRENCY_EXCHANGE> GetxYearMonth(EMA_CURRENCY_EXCHANGE e)
        {
            var sql = "SP_S_MA_CURRENCY_EXCHANGE_BYMONTH";
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                return cnx.Query<EMA_CURRENCY_EXCHANGE>(sql, new
                {
                    P_YEAR = DateTime.Parse(e.CHANGEDATE).Year,
                    P_MONTH = DateTime.Parse(e.CHANGEDATE).Month,
                    P_IDEMPRESA = e.IDEMPRESA,

                }, commandType: CommandType.StoredProcedure).ToList();
            }
        }

        public static EMA_CURRENCY_EXCHANGE GetByDate(EMA_CURRENCY_EXCHANGE e)
        {
            var sql = "SP_S_MA_CURRENCY_EXCHANGE_BYID";
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                return cnx.Query<EMA_CURRENCY_EXCHANGE>(sql, new
                {
                    P_CHANGEDATE = e.CHANGEDATE,
                    //P_IDCURRENCY = e.IDCURRENCY,
                    P_IDEMPRESA = e.IDEMPRESA
                }, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
        }

    }
}
