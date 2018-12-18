using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE.Ventas;
using Dapper;
using System.Data.SqlClient;
using System.Data;

namespace DA.Ventas
{
    public static class MA_DOCUMENTSDA
    {        
        public static string Insert(EMA_DOCUMENTS e)
        {
            string rpta = "ok";
            try
            {
                using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
                {
                    string sql = "SP_I_MA_DOCUMENTS";
                    cnx.Execute(sql, new
                    {
                        P_ID_DOCUMENT = e.ID_DOCUMENT,
                        P_DOCUMENT_DESCRIPTION = e.DOCUMENT_DESCRIPTION,
                        P_ABREVIATURE = e.ABREVIATURE,
                        P_CODE_NIF = e.CODE_NIF,
                        P_CODE_ELECTRONIC = e.CODE_ELECTRONIC,
                        P_ISTATUS = e.ISTATUS,
                        P_ID_COMPANY = e.ID_COMPANY
                    },
                                commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex) { rpta = ex.Message; }
            return rpta;
    }

        public static string Update(EMA_DOCUMENTS e)
        {
            string rpta = "ok";
            try
            {
                using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
                {
                    string sql = "SP_U_MA_DOCUMENTS";
                    cnx.Execute(sql, new
                    {
                        P_ID_DOCUMENT = e.ID_DOCUMENT,
                        P_DOCUMENT_DESCRIPTION = e.DOCUMENT_DESCRIPTION,
                        P_ABREVIATURE = e.ABREVIATURE,
                        P_CODE_NIF = e.CODE_NIF,
                        P_CODE_ELECTRONIC = e.CODE_ELECTRONIC,
                        P_ISTATUS = e.ISTATUS,
                        P_ID_COMPANY = e.ID_COMPANY
                    },
                                commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex) { rpta = ex.Message; }
            return rpta;
        }

        public static string Delete(EMA_DOCUMENTS e)
        {
            string rpta = "ok";
            try
            {
                using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
                {
                    string sql = "SP_D_MA_DOCUMENTS";
                    cnx.Execute(sql, new
                    {
                        P_ID_DOCUMENT = e.ID_COMPANY,
                        P_ID_COMPANY = e.ID_COMPANY
                    },
                                commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex) { rpta = ex.Message; }
            return rpta;
        }

        public static List<EMA_DOCUMENTS> GetAll(EMA_DOCUMENTS e)
        {
            var sql = "SP_S_MA_DOCUMENTS";
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                cnx.Open();
                return cnx.Query<EMA_DOCUMENTS>(sql, new { P_ID_COMPANY = e.ID_COMPANY }, commandType: CommandType.StoredProcedure).ToList();
            }
        }

        public static EMA_DOCUMENTS GetByid(EMA_DOCUMENTS e)
        {
            var sql = "SP_S_MA_DOCUMENTS_BYID";
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                cnx.Open();
                return cnx.Query<EMA_DOCUMENTS>(sql, new { P_ID_COMPANY = e.ID_COMPANY, P_ID_DOCUMENT = e.ID_DOCUMENT }, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
        }






    }
}
