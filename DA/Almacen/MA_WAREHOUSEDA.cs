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
    public static class MA_WAREHOUSEDA
    {
        public static string Insert(EMA_WAREHOUSE e)
        {
            string rpta = "ok";
            try
            {
                using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
                {
                    string sql = "SP_I_MA_WAREHOUSE";
                    cnx.Execute(sql, new
                    {
                        P_ID_WAREHOUSE = e.ID_WAREHOUSE,
                        P_DESCRIPCION = e.DESCRIPCION,
                        P_DIRECCION = e.DIRECCION,
                        P_ID_COMPANY = e.ID_COMPANY
                    },
                                commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex) { rpta = ex.Message; }
            return rpta;
        }

        public static string Update(EMA_WAREHOUSE e)
        {
            string rpta = "ok";
            try
            {
                using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
                {
                    string sql = "SP_U_MA_WAREHOUSE";
                    cnx.Execute(sql, new
                    {
                        P_ID_WAREHOUSE = e.ID_WAREHOUSE,
                        P_DESCRIPCION = e.DESCRIPCION,
                        P_DIRECCION = e.DIRECCION,
                        P_ID_COMPANY = e.ID_COMPANY
                    },
                                commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex) { rpta = ex.Message; }
            return rpta;
        }

        public static string Delete(EMA_WAREHOUSE e)
        {
            string rpta = "ok";
            try
            {
                using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
                {
                    string sql = "SP_D_MA_WAREHOUSE";
                    cnx.Execute(sql, new
                    {
                        P_ID_WAREHOUSE = e.ID_WAREHOUSE,
                        P_ID_COMPANY = e.ID_COMPANY
                    },
                                commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex) { rpta = ex.Message; }
            return rpta;
        }
        
        public static List<EMA_WAREHOUSE> GetAll(EMA_WAREHOUSE e)
        {
            List<EMA_WAREHOUSE> almacenes = new List<EMA_WAREHOUSE>();            
                var sql = "SP_S_MA_WAREHOUSE";
                using (SqlConnection cnx  = new SqlConnection(Utilidad.getCadenaCnx()))
                {
                    cnx.Open();
                    return cnx.Query<EMA_WAREHOUSE>(sql, new { P_ID_COMPANY = e.ID_COMPANY }, commandType: CommandType.StoredProcedure).ToList();
                }                        
        }

        public static EMA_WAREHOUSE GetByid(EMA_WAREHOUSE e)
        {
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                var sql = "SP_S_MA_WAREHOUSE_BYID";
                cnx.Open();
                return cnx.Query<EMA_WAREHOUSE>(sql, new { P_ID_WAREHOUSE = e.ID_WAREHOUSE, P_ID_COMPANY = e.ID_COMPANY }, commandType: CommandType.StoredProcedure).SingleOrDefault();                
            }            
        }

    }
}
