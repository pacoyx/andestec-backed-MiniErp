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
    public static class MA_ARTICLEDA
    {
        public static void Insert(EMA_ARTICLE e)
        {
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                string sql = "SP_I_MA_ARTICLE";
                cnx.Execute(sql, new
                {
                    P_ID_COMPANY = e.ID_COMPANY,
                    P_ID_COMMODITY_TYPE = e.ID_COMMODITY_TYPE,
                    P_ID_UNIT = e.ID_UNIT,
                    P_ID_FAMILY = e.ID_FAMILY,
                    P_ID_FAMILY_SUB = e.ID_FAMILY_SUB,
                    P_SKU_ARTICLE = e.SKU_ARTICLE,
                    P_DESCRIPTION_ARTICLE = e.DESCRIPTION_ARTICLE,
                    P_COMMERCIAL_NAME = e.COMMERCIAL_NAME,
                    P_TECHNICAL_NAME = e.TECHNICAL_NAME,
                    P_SIZE = e.SIZE,
                    P_COLORS = e.COLORS,
                    P_BRAND = e.BRAND,
                    P_MODEL = e.MODEL,
                    P_AIMAGE = e.AIMAGE,
                    P_DATA_SHEET = e.DATA_SHEET,
                    P_AUSUARIO = e.AUSUARIO,
                    P_AFECREG = e.AFECREG,
                    P_AMODIFICO = e.AMODIFICO,
                    P_AFECMOD = e.AFECMOD,
                    P_AISSERVICE = e.AISSERVICE
                },
                            commandType: CommandType.StoredProcedure);
            }
        }

        public static void Update(EMA_ARTICLE e)
        {
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                string sql = "SP_U_MA_ARTICLE";
                cnx.Execute(sql, new
                {
                    P_ID_ARTICLE = e.ID_ARTICLE,
                    P_ID_COMPANY = e.ID_COMPANY,
                    P_ID_COMMODITY_TYPE = e.ID_COMMODITY_TYPE,
                    P_ID_UNIT = e.ID_UNIT,
                    P_ID_FAMILY = e.ID_FAMILY,
                    P_ID_FAMILY_SUB = e.ID_FAMILY_SUB,
                    P_SKU_ARTICLE = e.SKU_ARTICLE,
                    P_DESCRIPTION_ARTICLE = e.DESCRIPTION_ARTICLE,
                    P_COMMERCIAL_NAME = e.COMMERCIAL_NAME,
                    P_TECHNICAL_NAME = e.TECHNICAL_NAME,
                    P_SIZE = e.SIZE,
                    P_COLORS = e.COLORS,
                    P_BRAND = e.BRAND,
                    P_MODEL = e.MODEL,
                    P_AIMAGE = e.AIMAGE,
                    P_DATA_SHEET = e.DATA_SHEET,
                    P_AUSUARIO = e.AUSUARIO,
                    P_AFECREG = e.AFECREG,
                    P_AMODIFICO = e.AMODIFICO,
                    P_AFECMOD = e.AFECMOD,
                    P_AISSERVICE = e.AISSERVICE
                },
                            commandType: CommandType.StoredProcedure);
            }
        }

        public static void Delete(EMA_ARTICLE e)
        {
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                string sql = "SP_D_MA_ARTICLE";
                cnx.Execute(sql, new
                {
                    P_ID_ARTICLE = e.ID_ARTICLE,
                    P_ID_COMPANY = e.ID_COMPANY
                },
                            commandType: CommandType.StoredProcedure);
            }
        }

        public static List<EMA_ARTICLE> GetAll(EMA_ARTICLE e)
        {
            var sql = "SP_S_MA_ARTICLE";
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                cnx.Open();
                return cnx.Query<EMA_ARTICLE>(sql, new { P_ID_COMPANY = e.ID_COMPANY }, commandType: CommandType.StoredProcedure).ToList();
            }
        }

        public static EMA_ARTICLE GetByid(EMA_ARTICLE e)
        {
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                var sql = "SP_S_MA_ARTICLE_BYID";
                cnx.Open();
                return cnx.Query<EMA_ARTICLE>(sql, new { P_ID_ARTICLE = e.ID_ARTICLE, P_ID_COMPANY = e.ID_COMPANY }, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
        }
    }
}
