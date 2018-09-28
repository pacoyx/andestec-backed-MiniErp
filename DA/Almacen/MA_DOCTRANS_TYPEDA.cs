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
    public static class MA_DOCTRANS_TYPEDA
    {
        public static void Insert(EMA_DOCTRANS_TYPE e)
        {
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                string sql = "SP_I_MA_DOCTRANS_TYPE";
                cnx.Execute(sql, new
                {
                    P_ID = e.DT_ID,
                    P_DES = e.DT_DES,
                    P_ESTADO = e.DT_ESTADO,
                    P_ID_COMPANY = e.DT_ID_COMPANY                    
                },
                            commandType: CommandType.StoredProcedure);
            }
        }

        public static void Update(EMA_DOCTRANS_TYPE e)
        {
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                string sql = "SP_U_MA_DOCTRANS_TYPE";
                cnx.Execute(sql, new
                {
                    P_ID = e.DT_ID,
                    P_DES = e.DT_DES,
                    P_ESTADO = e.DT_ESTADO,
                    P_ID_COMPANY = e.DT_ID_COMPANY
                },
                            commandType: CommandType.StoredProcedure);
            }
        }

        public static void Delete(EMA_DOCTRANS_TYPE e)
        {
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                string sql = "SP_D_MA_DOCTRANS_TYPE";
                cnx.Execute(sql, new
                {
                    P_ID = e.DT_ID,                    
                    P_ID_COMPANY = e.DT_ID_COMPANY
                },
                            commandType: CommandType.StoredProcedure);
            }
        }

        public static List<EMA_DOCTRANS_TYPE> GetAll(EMA_DOCTRANS_TYPE e)
        {
            var sql = "SP_S_MA_DOCTRANS_TYPE";
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                cnx.Open();
                return cnx.Query<EMA_DOCTRANS_TYPE>(sql, new { P_ID_COMPANY = e.DT_ID_COMPANY }, commandType: CommandType.StoredProcedure).ToList();
            }
        }

        public static EMA_DOCTRANS_TYPE GetByid(EMA_DOCTRANS_TYPE e)
        {
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                var sql = "SP_S_MA_DOCTRANS_TYPE_BYID";
                cnx.Open();
                return cnx.Query<EMA_DOCTRANS_TYPE>(sql, new { P_ID = e.DT_ID, P_ID_COMPANY = e.DT_ID_COMPANY }, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
        }

    }
}
