using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE.Almacen;
using Dapper;

namespace DA.Almacen
{
    public static class MA_FAMILYDA
    {        
        public static string Insert(EMA_FAMILY e) {
            string rpta = "ok";
            try
            {
                using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
                {
                    string sql = "SP_I_MA_FAMILY";
                    cnx.Execute(sql, new
                    {
                        P_COMPANY = e.ID_COMPANY,
                        P_FAMILY = e.ID_FAMILY,
                        PDESCRIPTION_FAMILY = e.DESCRIPTION_FAMILY
                    },
                                commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex) { rpta = ex.Message; }
            return rpta;
        }

        public static string Update(EMA_FAMILY e)
        {
            string rpta = "ok";
            try
            {
                using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
                {
                    string sql = "SP_U_MA_FAMILY";
                    cnx.Execute(sql, new
                    {
                        P_COMPANY = e.ID_COMPANY,
                        P_FAMILY = e.ID_FAMILY,
                        PDESCRIPTION_FAMILY = e.DESCRIPTION_FAMILY
                    },
                                commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex) { rpta = ex.Message; }
            return rpta;
        }

        public static string Delete(EMA_FAMILY e)
        {
            string rpta = "ok";
            try
            {
                using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
                {
                    string sql = "SP_D_MA_FAMILY";
                    cnx.Execute(sql, new
                    {
                        P_COMPANY = e.ID_COMPANY,
                        P_FAMILY = e.ID_FAMILY
                    },
                                commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex) { rpta = ex.Message; }
            return rpta;
        }

        public static List<EMA_FAMILY> GetAll(EMA_FAMILY e) {
            var sql = "SP_S_MA_FAMILY";
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                cnx.Open();
                return cnx.Query<EMA_FAMILY>(sql, new { P_COMPANY = e.ID_COMPANY }, commandType: CommandType.StoredProcedure).ToList();                       
            }            
        }

        public static EMA_FAMILY GetByid(EMA_FAMILY e)
        {
            var sql = "SP_S_MA_FAMILY_BYID";
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {                
                cnx.Open();
                return cnx.Query<EMA_FAMILY>(sql, new { P_COMPANY = e.ID_COMPANY, P_FAMILY = e.ID_FAMILY }, commandType: CommandType.StoredProcedure).SingleOrDefault();                
            }            
        }
    }
}
