using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BE.Ventas;
using Dapper;
using System.Data.SqlClient;
using System.Data;

namespace DA.Ventas
{
    public static class MA_SALPOINTSERIEDA
    {
        public static void Insert(EMA_SALPOINTSERIE e)
        {
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                string sql = "SP_I_MA_SALPOINTSERIE";
                cnx.Execute(sql, new
                {
                    P_SS_IDPOINT = e.SS_IDPOINT,
                    P_SS_ID_DOCUMENT = e.SS_ID_DOCUMENT,
                    P_SS_SERIE = e.SS_SERIE,
                    P_SS_INITCORRE = e.SS_INITCORRE,
                    P_SS_PRINTING_FORMAT = e.SS_PRINTING_FORMAT,
                    P_SS_ISTATUS = e.SS_ISTATUS,
                    P_SS_IDCOMPANY = e.SS_IDCOMPANY
                },
                            commandType: CommandType.StoredProcedure);
            }
        }

        public static void Update(EMA_SALPOINTSERIE e)
        {
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                string sql = "SP_U_MA_SALPOINTSERIE";
                cnx.Execute(sql, new
                {
                    P_SS_IDPOINT = e.SS_IDPOINT,
                    P_SS_ID_DOCUMENT = e.SS_ID_DOCUMENT,
                    P_SS_SERIE = e.SS_SERIE,
                    P_SS_INITCORRE = e.SS_INITCORRE,
                    P_SS_PRINTING_FORMAT = e.SS_PRINTING_FORMAT,
                    P_SS_ISTATUS = e.SS_ISTATUS,
                    P_SS_IDCOMPANY = e.SS_IDCOMPANY
                },
                            commandType: CommandType.StoredProcedure);
            }
        }

        public static void Delete(EMA_SALPOINTSERIE e)
        {
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                string sql = "SP_D_MA_SALPOINTSERIE";
                cnx.Execute(sql, new
                {
                    P_SS_IDPOINT = e.SS_IDPOINT,
                    P_SS_ID_DOCUMENT = e.SS_ID_DOCUMENT,
                    P_SS_SERIE = e.SS_SERIE,                    
                    P_SS_IDCOMPANY = e.SS_IDCOMPANY
                },
                            commandType: CommandType.StoredProcedure);
            }
        }

        public static List<EMA_SALPOINTSERIE> GetAll(EMA_SALPOINTSERIE e)
        {
            var sql = "SP_S_MA_SALPOINTSERIE";
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {                
                return cnx.Query<EMA_SALPOINTSERIE>(sql, new { P_SS_IDPOINT = e.SS_IDPOINT, P_SS_IDCOMPANY = e.SS_IDCOMPANY }, commandType: CommandType.StoredProcedure).ToList();
            }
        }

        public static List<EMA_SALPOINTSERIE> GetSerieCorrelativo(EMA_SALPOINTSERIE e)
        {
            var sql = "SP_S_SALPOINTSERIE01";
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {                
                return cnx.Query<EMA_SALPOINTSERIE>(sql, new { P_SS_IDPOINT = e.SS_IDPOINT, P_SS_ID_DOCUMENT = e.SS_ID_DOCUMENT, P_SS_IDCOMPANY = e.SS_IDCOMPANY }, commandType: CommandType.StoredProcedure).ToList();
            }
        }

        public static List<EMA_SALPOINTSERIE> GetDocxPtoVta(EMA_SALPOINTSERIE e)
        {
            var sql = "SP_S_SALPOINTSERIE02";
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {                
                return cnx.Query<EMA_SALPOINTSERIE>(sql, new { P_SS_IDPOINT = e.SS_IDPOINT, P_SS_IDCOMPANY = e.SS_IDCOMPANY }, commandType: CommandType.StoredProcedure).ToList();
            }
        }





    }
}
