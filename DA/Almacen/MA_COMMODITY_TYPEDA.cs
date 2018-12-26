using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using BE.Almacen;
using Dapper;

namespace DA.Almacen
{
    public static class MA_COMMODITY_TYPEDA
    {
        public static string Insert(EMA_COMMODITY_TYPE e)
        {
            string rpta = "ok";
            try
            {
                using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
                {
                    string sql = "SP_I_MA_COMMODITY_TYPE";
                    cnx.Execute(sql, new
                    {
                        P_ID_COMPANY = e.ID_COMPANY,
                        P_ID_COMMODITY_TYPE = e.ID_COMMODITY_TYPE,
                        P_DESCRIPTION_COMMODITY = e.DESCRIPTION_COMMODITY
                    },
                                commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex) { rpta = ex.Message; }
            return rpta;
        }

        public static string Update(EMA_COMMODITY_TYPE e)
        {
            string rpta = "ok";
            try
            {
                using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
                {
                    string sql = "SP_U_MA_COMMODITY_TYPE";
                    cnx.Execute(sql, new
                    {
                        P_ID_COMPANY = e.ID_COMPANY,
                        P_ID_COMMODITY_TYPE = e.ID_COMMODITY_TYPE,
                        P_DESCRIPTION_COMMODITY = e.DESCRIPTION_COMMODITY
                    },
                                commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex) { rpta = ex.Message; }
            return rpta;
        }

        public static string Delete(EMA_COMMODITY_TYPE e)
        {
            string rpta = "ok";
            try
            {
                using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
                {
                    string sql = "SP_D_MA_COMMODITY_TYPE";
                    cnx.Execute(sql, new
                    {
                        P_ID_COMPANY = e.ID_COMPANY,
                        P_ID_COMMODITY_TYPE = e.ID_COMMODITY_TYPE
                    },
                                commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex) { rpta = ex.Message; }
            return rpta;
        }

        public static List<EMA_COMMODITY_TYPE> GetAll(EMA_COMMODITY_TYPE e)
        {
            var sql = "SP_S_MA_COMMODITY_TYPE";
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {                
                return cnx.Query<EMA_COMMODITY_TYPE>(sql, new { P_ID_COMPANY = e.ID_COMPANY }, commandType: CommandType.StoredProcedure).ToList();
            }
        }

        public static EMA_COMMODITY_TYPE GetByid(EMA_COMMODITY_TYPE e)
        {
            var sql = "SP_S_MA_COMMODITY_TYPE_BYID";
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {                
                return cnx.Query<EMA_COMMODITY_TYPE>(sql, new { P_ID_COMPANY = e.ID_COMPANY, P_ID_COMMODITY_TYPE = e.ID_COMMODITY_TYPE }, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }           
        }


    }
}
