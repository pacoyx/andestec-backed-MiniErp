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
    public static class MA_TRANSACTION_TYPEDA
    {
        public static string Insert(EMA_TRANSACTION_TYPE e)
        {
            string rpta = "ok";
            try
            {
                using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
                {
                    string sql = "SP_I_TRANSACTION_TYPE";
                    cnx.Execute(sql, new
                    {
                        P_CODIGO = e.TT_CODIGO,
                        P_DESCRIPCION = e.TT_DESCRIPCION,
                        P_INGSAL = e.TT_INGSAL,
                        P_ID_COMPANY = e.TT_ID_COMPANY,
                        P_COST = e.TT_COST,
                        P_TYPE = e.TT_TYPE
                    },
                                commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex) { rpta = ex.Message; }
            return rpta;
        }

        public static string Update(EMA_TRANSACTION_TYPE e)
        {
            string rpta = "ok";
            try
            {
                using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
                {
                    string sql = "SP_U_TRANSACTION_TYPE";
                    cnx.Execute(sql, new
                    {
                        P_CODIGO = e.TT_CODIGO,
                        P_DESCRIPCION = e.TT_DESCRIPCION,
                        P_INGSAL = e.TT_INGSAL,
                        P_ID_COMPANY = e.TT_ID_COMPANY,
                        P_COST = e.TT_COST,
                        P_TYPE = e.TT_TYPE
                    },
                                commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex) { rpta = ex.Message; }
            return rpta;
        }

        public static string Delete(EMA_TRANSACTION_TYPE e)
        {
            string rpta = "ok";
            try
            {
                using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
                {
                    string sql = "SP_D_TRANSACTION_TYPE";
                    cnx.Execute(sql, new
                    {
                        P_CODIGO = e.TT_CODIGO,
                        P_ID_COMPANY = e.TT_ID_COMPANY
                    },
                                commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex) { rpta = ex.Message; }
            return rpta;
        }

        public static List<EMA_TRANSACTION_TYPE> GetAll(EMA_TRANSACTION_TYPE e)
        {
            var sql = "SP_S_TRANSACTION_TYPE";
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                cnx.Open();
                return cnx.Query<EMA_TRANSACTION_TYPE>(sql, new { P_ID_COMPANY = e.TT_ID_COMPANY }, commandType: CommandType.StoredProcedure).ToList();
            }
        }

        public static EMA_TRANSACTION_TYPE GetByid(EMA_TRANSACTION_TYPE e)
        {
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                var sql = "SP_S_TRANSACTION_TYPE_BYID";
                cnx.Open();
                return cnx.Query<EMA_TRANSACTION_TYPE>(sql, new { P_CODIGO = e.TT_CODIGO, P_ID_COMPANY = e.TT_ID_COMPANY }, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
        }
    }
}
