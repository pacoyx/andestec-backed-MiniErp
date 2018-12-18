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
    public static class MA_PROVIDERDA
    {
        public static string Insert(EMA_PROVIDER e)
        {
            string rpta = "ok";
            try
            {
                using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
                {
                    string sql = "SP_I_MA_PROVIDER";
                    cnx.Execute(sql, new
                    {
                        P_ID_COMPANY = e.ID_COMPANY,
                        P_DESCRIPTION_PROVIDER = e.DESCRIPTION_PROVIDER.Trim(),
                        P_DOCUMENT_TYPE_PROVIDER = e.DOCUMENT_TYPE_PROVIDER.Trim(),
                        P_NUMBER_DOCUMENT = e.NUMBER_DOCUMENT.Trim(),
                        P_COMMERCIAL_TYPE = e.COMMERCIAL_TYPE.Trim(),
                        P_PROVIDER_TYPE = e.PROVIDER_TYPE.Trim(),
                        P_CONTACT = e.CONTACT.Trim(),
                        P_MOVIL_CONTACT = e.MOVIL_CONTACT.Trim(),
                        P_EMAIL = e.EMAIL.Trim(),
                        P_ISTATUS = e.ISTATUS,
                        P_AUSUARIO = e.AUSUARIO.Trim(),
                        P_AFECREG = e.AFECREG.Trim(),
                        P_AMODIFICO = e.AMODIFICO.Trim(),
                        P_AFECMOD = e.AFECMOD.Trim()
                    },
                                commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex) { rpta = ex.Message; }
            return rpta;
        }

        public static string Update(EMA_PROVIDER e)
        {
            string rpta = "ok";
            try
            {
                using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
                {
                    string sql = "SP_U_MA_PROVIDER";
                    cnx.Execute(sql, new
                    {
                        P_ID_PROVIDER = e.ID_PROVIDER,
                        P_ID_COMPANY = e.ID_COMPANY,
                        P_DESCRIPTION_PROVIDER = e.DESCRIPTION_PROVIDER.Trim(),
                        P_DOCUMENT_TYPE_PROVIDER = e.DOCUMENT_TYPE_PROVIDER.Trim(),
                        P_NUMBER_DOCUMENT = e.NUMBER_DOCUMENT.Trim(),
                        P_COMMERCIAL_TYPE = e.COMMERCIAL_TYPE.Trim(),
                        P_PROVIDER_TYPE = e.PROVIDER_TYPE.Trim(),
                        P_CONTACT = e.CONTACT.Trim(),
                        P_MOVIL_CONTACT = e.MOVIL_CONTACT.Trim(),
                        P_EMAIL = e.EMAIL.Trim(),
                        P_ISTATUS = e.ISTATUS,
                        P_AUSUARIO = e.AUSUARIO.Trim(),
                        P_AFECREG = e.AFECREG.Trim(),
                        P_AMODIFICO = e.AMODIFICO.Trim(),
                        P_AFECMOD = e.AFECMOD.Trim()
                    },
                                commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex) { rpta = ex.Message; }
            return rpta;
        }

        public static string Delete(EMA_PROVIDER e)
        {
            string rpta = "ok";
            try
            {
                using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
                {
                    string sql = "SP_D_MA_PROVIDER";
                    cnx.Execute(sql, new
                    {
                        P_ID_PROVIDER = e.ID_PROVIDER,
                        P_ID_COMPANY = e.ID_COMPANY
                    },
                                commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex) { rpta = ex.Message; }
            return rpta;
        }

        public static List<EMA_PROVIDER> GetAll(EMA_PROVIDER e)
        {
            var sql = "SP_S_MA_PROVIDER";
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                cnx.Open();
                return cnx.Query<EMA_PROVIDER>(sql, new { P_ID_COMPANY = e.ID_COMPANY }, commandType: CommandType.StoredProcedure).ToList();
            }
        }

        public static EMA_PROVIDER GetByid(EMA_PROVIDER e)
        {
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                var sql = "SP_S_MA_PROVIDER_BYID";
                cnx.Open();
                return cnx.Query<EMA_PROVIDER>(sql, new { P_ID_PROVIDER = e.ID_PROVIDER, P_ID_COMPANY = e.ID_COMPANY }, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
        }
    }
}
