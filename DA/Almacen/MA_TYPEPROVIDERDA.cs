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
    public static class MA_TYPEPROVIDERDA
    {
        public static void Insert(EMA_TYPEPROVIDER e)
        {
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                string sql = "SP_I_MA_TYPEPROVIDER";
                cnx.Execute(sql, new
                {
                    P_TP_ID = e.TP_ID,
                    P_TP_DES = e.TP_DES,
                    P_TP_ISTATUS = e.TP_ISTATUS,
                    P_TP_IDCOMPANY = e.TP_IDCOMPANY
                },
                            commandType: CommandType.StoredProcedure);
            }
        }

        public static void Update(EMA_TYPEPROVIDER e)
        {
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                string sql = "SP_U_MA_TYPEPROVIDER";
                cnx.Execute(sql, new
                {
                    P_TP_ID = e.TP_ID,
                    P_TP_DES = e.TP_DES,
                    P_TP_ISTATUS = e.TP_ISTATUS,
                    P_TP_IDCOMPANY = e.TP_IDCOMPANY
                },
                            commandType: CommandType.StoredProcedure);
            }
        }

        public static void Delete(EMA_TYPEPROVIDER e)
        {
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                string sql = "SP_D_MA_TYPEPROVIDER";
                cnx.Execute(sql, new
                {
                    P_TP_ID = e.TP_ID,                    
                    P_TP_IDCOMPANY = e.TP_IDCOMPANY
                },
                            commandType: CommandType.StoredProcedure);
            }
        }


        public static List<EMA_TYPEPROVIDER> GetAll(EMA_TYPEPROVIDER e)
        {
            var sql = "SP_S_MA_TYPEPROVIDER";
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {                
                return cnx.Query<EMA_TYPEPROVIDER>(sql, new { P_TP_IDCOMPANY = e.TP_IDCOMPANY }, commandType: CommandType.StoredProcedure).ToList();
            }
        }

        public static EMA_TYPEPROVIDER GetByid(EMA_TYPEPROVIDER e)
        {
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                var sql = "SP_S_MA_TYPEPROVIDER_BYID";             
                return cnx.Query<EMA_TYPEPROVIDER>(sql, new { P_TP_IDCOMPANY = e.TP_IDCOMPANY, P_TP_ID = e.TP_ID }, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
        }

    }
}
