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
    public static class MA_CENTER_COSTDA
    {
        public static void Insert(EMA_CENTER_COST e)
        {
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                string sql = "SP_I_MA_CENTER_COST";
                cnx.Execute(sql, new
                {
                    P_ID_COMPANY = e.ID_COMPANY,
                    P_ID_CENTER_COST = e.ID_CENTER_COST,
                    P_DESCRIPTION_CENTER_COST = e.DESCRIPTION_CENTER_COST
                },
                            commandType: CommandType.StoredProcedure);               
            }
        }

        public static void Update(EMA_CENTER_COST e)
        {
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                string sql = "SP_U_MA_CENTER_COST";
                cnx.Execute(sql, new
                {
                    P_ID_COMPANY = e.ID_COMPANY,
                    P_ID_CENTER_COST = e.ID_CENTER_COST,
                    P_DESCRIPTION_CENTER_COST = e.DESCRIPTION_CENTER_COST
                },
                            commandType: CommandType.StoredProcedure);
            }
        }

        public static void Delete(EMA_CENTER_COST e)
        {
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                string sql = "SP_D_MA_CENTER_COST";
                cnx.Execute(sql, new
                {
                    P_ID_COMPANY = e.ID_COMPANY,
                    P_ID_CENTER_COST = e.ID_CENTER_COST                    
                },
                            commandType: CommandType.StoredProcedure);
            }
        }

        public static List<EMA_CENTER_COST> GetAll(EMA_CENTER_COST e)
        {
            var sql = "SP_S_MA_CENTER_COST";
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                cnx.Open();
                return cnx.Query<EMA_CENTER_COST>(sql, new { P_ID_COMPANY = e.ID_COMPANY }, commandType: CommandType.StoredProcedure).ToList();
            }           
        }

        public static EMA_CENTER_COST GetByid(EMA_CENTER_COST e)
        {
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                var sql = "SP_S_MA_CENTER_COST_BYID";
                cnx.Open();
                return cnx.Query<EMA_CENTER_COST>(sql, new { P_ID_COMPANY = e.ID_COMPANY, P_ID_CENTER_COST = e.ID_CENTER_COST }, commandType: CommandType.StoredProcedure).SingleOrDefault();                
            }            
        }
    }
}
