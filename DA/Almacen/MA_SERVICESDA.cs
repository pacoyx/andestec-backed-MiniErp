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
    public static class MA_SERVICESDA
    {
        public static void Insert(EMA_SERVICES e)
        {
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                string sql = "SP_I_MA_SERVICES";
                cnx.Execute(sql, new
                {
                    P_ID_COMPANY = e.ID_COMPANY,
                    P_ID_SERVICES = e.ID_SERVICES,
                    P_DESCRIPTION_SERVICES = e.DESCRIPTION_SERVICES
                },
                            commandType: CommandType.StoredProcedure);                
            }
        }

        public static void Update(EMA_SERVICES e)
        {
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                string sql = "SP_U_MA_SERVICES";
                cnx.Execute(sql, new
                {
                    P_ID_COMPANY = e.ID_COMPANY,
                    P_ID_SERVICES = e.ID_SERVICES,
                    P_DESCRIPTION_SERVICES = e.DESCRIPTION_SERVICES
                },
                            commandType: CommandType.StoredProcedure);
            }
        }

        public static void Delete(EMA_SERVICES e)
        {
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                string sql = "SP_D_MA_SERVICES";
                cnx.Execute(sql, new
                {
                    P_ID_COMPANY = e.ID_COMPANY,
                    P_ID_SERVICES = e.ID_SERVICES                    
                },
                            commandType: CommandType.StoredProcedure);
            }
        }

        public static List<EMA_SERVICES> GetAll(EMA_SERVICES e)
        {
            var sql = "SP_S_MA_SERVICES";
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                cnx.Open();
                return cnx.Query<EMA_SERVICES>(sql, new { P_ID_COMPANY = e.ID_COMPANY }, commandType: CommandType.StoredProcedure).ToList();
            }           
        }

        public static EMA_SERVICES GetByid(EMA_SERVICES e)
        {
            var sql = "SP_S_MA_SERVICES_BYID";
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                cnx.Open();
                return cnx.Query<EMA_SERVICES>(sql, new { P_ID_COMPANY = e.ID_COMPANY, P_ID_SERVICES = e.ID_SERVICES }, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }            
        }
    }
}
