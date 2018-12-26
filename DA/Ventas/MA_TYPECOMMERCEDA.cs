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
    public static class MA_TYPECOMMERCEDA
    {
        public static string Insert(EMA_TYPECOMMERCE e)
        {
            string rpta = "ok";
            try
            {
                using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
                {
                    string sql = "SP_I_MA_TYPECOMMERCE";
                    cnx.Execute(sql, new
                    {
                        PTC_ID = e.TC_ID,
                        PTC_DES = e.TC_DES,
                        PTC_IDCOMPANY = e.TC_IDCOMPANY
                    },
                                commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex) { rpta = ex.Message; }
            return rpta;
        }

        public static string Update(EMA_TYPECOMMERCE e)
        {
            string rpta = "ok";
            try
            {
                using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
                {
                    string sql = "SP_U_MA_TYPECOMMERCE";
                    cnx.Execute(sql, new
                    {
                        PTC_ID = e.TC_ID,
                        PTC_DES = e.TC_DES,
                        PTC_IDCOMPANY = e.TC_IDCOMPANY
                    },
                                commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex) { rpta = ex.Message; }
            return rpta;
        }

        public static string Delete(EMA_TYPECOMMERCE e)
        {
            string rpta = "ok";
            try
            {
                using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                string sql = "SP_D_MA_TYPECOMMERCE";
                cnx.Execute(sql, new
                {
                    PTC_ID = e.TC_ID,                    
                    PTC_IDCOMPANY = e.TC_IDCOMPANY
                },
                            commandType: CommandType.StoredProcedure);
            }
            }
            catch (Exception ex) { rpta = ex.Message; }
            return rpta;
        }

        public static List<EMA_TYPECOMMERCE> GetAll(EMA_TYPECOMMERCE e)
        {
            var sql = "SP_S_MA_TYPECOMMERCE";
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                cnx.Open();
                return cnx.Query<EMA_TYPECOMMERCE>(sql, new { PTC_IDCOMPANY = e.TC_IDCOMPANY }, commandType: CommandType.StoredProcedure).ToList();
            }
        }

        public static EMA_TYPECOMMERCE GetByid(EMA_TYPECOMMERCE e)
        {
            var sql = "SP_S_MA_TYPECOMMERCE_BYID";
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                cnx.Open();
                return cnx.Query<EMA_TYPECOMMERCE>(sql, new { PTC_ID = e.TC_ID, PTC_IDCOMPANY = e.TC_IDCOMPANY }, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
        }

    }
}
