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
    public static class MA_FAMILY_SUBDA
    {
        public static string Insert(EMA_FAMILY_SUB e)
        {
            string rpta = "ok";
            try
            {
                using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
                {
                    string sql = "SP_I_MA_FAMILY_SUB";
                    cnx.Execute(sql, new
                    {
                        P_ID_COMPANY = e.ID_COMPANY,
                        P_ID_FAMILY = e.ID_FAMILY,
                        P_ID_FAMILY_SUB = e.ID_FAMILY_SUB,
                        P_DESCRIPTION_FAMILY_SUB = e.DESCRIPTION_FAMILY_SUB
                    },
                                commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex) { rpta = ex.Message; }
            return rpta;
        }

        public static string Update(EMA_FAMILY_SUB e)
        {
            string rpta = "ok";
            try
            {
                using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
                {
                    string sql = "SP_U_MA_FAMILY_SUB";
                    cnx.Execute(sql, new
                    {
                        P_ID_COMPANY = e.ID_COMPANY,
                        P_ID_FAMILY = e.ID_FAMILY,
                        P_ID_FAMILY_SUB = e.ID_FAMILY_SUB,
                        P_DESCRIPTION_FAMILY_SUB = e.DESCRIPTION_FAMILY_SUB
                    },
                                commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex) { rpta = ex.Message; }
            return rpta;
        }

        public static string Delete(EMA_FAMILY_SUB e)
        {
            string rpta = "ok";
            try
            {
                using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                string sql = "SP_D_MA_FAMILY_SUB";
                cnx.Execute(sql, new
                {
                    P_ID_COMPANY = e.ID_COMPANY,                    
                    P_ID_FAMILY_SUB = e.ID_FAMILY_SUB                    
                },
                            commandType: CommandType.StoredProcedure);
            }
        }
            catch (Exception ex) { rpta = ex.Message; }
            return rpta;
        }

        public static List<EMA_FAMILY_SUB> GetAll(EMA_FAMILY_SUB e)
        {            
            var sql = "SP_S_MA_FAMILY_SUB";
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                cnx.Open();
                return cnx.Query<EMA_FAMILY_SUB>(sql, new { P_ID_COMPANY = e.ID_COMPANY }, commandType: CommandType.StoredProcedure).ToList();
            }
        }

        public static EMA_FAMILY_SUB GetByid(EMA_FAMILY_SUB e)
        {
            var sql = "SP_S_MA_FAMILY_SUB_BYID";
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {                
                cnx.Open();
                return cnx.Query<EMA_FAMILY_SUB>(sql, new { P_ID_COMPANY = e.ID_COMPANY, P_ID_FAMILY_SUB = e.ID_FAMILY_SUB }, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
        }
        
    }
}
