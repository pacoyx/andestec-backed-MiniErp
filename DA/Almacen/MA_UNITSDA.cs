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
    public static class MA_UNITSDA
    {
        public static string Insert(EMA_UNITS e)
        {
            string rpta = "ok";
            try
            {
                using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
                {
                    string sql = "SP_I_MA_UNITS";
                    cnx.Execute(sql, new
                    {
                        P_ID_COMPANY = e.ID_COMPANY,
                        P_ID_UNIT = e.ID_UNIT,
                        P_DESCRIPTION_UNIT = e.DESCRIPTION_UNIT,
                        P_COD_SUNAT = e.COD_SUNAT
                    },
                                commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex) { rpta = ex.Message; }
            return rpta;
        }

        public static string Update(EMA_UNITS e)
        {
            string rpta = "ok";
            try
            {
                using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
                {
                    string sql = "SP_U_MA_UNITS";
                    cnx.Execute(sql, new
                    {
                        P_ID_COMPANY = e.ID_COMPANY,
                        P_ID_UNIT = e.ID_UNIT,
                        P_DESCRIPTION_UNIT = e.DESCRIPTION_UNIT,
                        P_COD_SUNAT = e.COD_SUNAT
                    },
                                commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex) { rpta = ex.Message; }
            return rpta;
        }

        public static string Delete(EMA_UNITS e)
        {
            string rpta = "ok";
            try
            {
                using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
                {
                    string sql = "SP_D_MA_UNITS";
                    cnx.Execute(sql, new
                    {
                        P_ID_COMPANY = e.ID_COMPANY,
                        P_ID_UNIT = e.ID_UNIT
                    },
                                commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex) { rpta = ex.Message; }
            return rpta;
        }

        public static List<EMA_UNITS> GetAll(EMA_UNITS e)
        {
            var sql = "SP_S_MA_UNITS";
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                cnx.Open();
                return cnx.Query<EMA_UNITS>(sql, new { P_ID_COMPANY = e.ID_COMPANY }, commandType: CommandType.StoredProcedure).ToList();
            }           
        }

        public static EMA_UNITS GetByid(EMA_UNITS e)
        {
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                var sql = "SP_S_MA_UNITS_BYID";
                cnx.Open();
                return cnx.Query<EMA_UNITS>(sql, new { P_ID_COMPANY = e.ID_COMPANY, P_ID_UNIT = e.ID_UNIT }, commandType: CommandType.StoredProcedure).SingleOrDefault();                
            }            
        }
    }
}
