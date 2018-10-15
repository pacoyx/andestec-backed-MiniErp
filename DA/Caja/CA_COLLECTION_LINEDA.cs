using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE.Caja;
using Dapper;
using System.Data.SqlClient;
using System.Data;

namespace DA.Caja
{
    public static class CA_COLLECTION_LINEDA
    {


        public static List<EPLANILLADET> GetPlanillaDetalle(int emp,int idpla)
        {
            var sql = "SP_S_PLANILLADET";
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                return cnx.Query<EPLANILLADET>(sql, new
                {
                    P_CL_ID = idpla,
                    P_IDCOMPANY = emp
                },
                    commandType: CommandType.StoredProcedure).ToList();
            }
        }


        public static string Insert(List<ECA_COLLECTION_LINE> lsdet)
        {            
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                string sql = "SP_I_CA_COLLECTION_LINE";

                foreach (var e in lsdet)
                {
                    cnx.Execute(sql, new
                    {
                        P_CL_ID = e.CL_ID,
                        P_CL_ITEM = e.CL_ITEM,
                        P_CL_TYPE_DOC = e.CL_TYPE_DOC,
                        P_CL_SERIE_DOC = e.CL_SERIE_DOC,
                        P_CL_NUMBER_DOC = e.CL_NUMBER_DOC,
                        P_CL_TYPE_OPERATION = e.CL_TYPE_OPERATION,
                        P_CL_DATE = e.CL_DATE,
                        P_CL_AMOUNT = e.CL_AMOUNT,
                        P_CL_CURRENCY_ID = e.CL_CURRENCY_ID,
                        P_CL_SELL_RATE = e.CL_SELL_RATE,
                        P_CL_COMMENT = e.CL_COMMENT,
                        P_CL_SALES_ID = e.CL_SALES_ID,
                        P_CL_BANK_ID = e.CL_BANK_ID,
                        P_CL_DOC_REF = e.CL_DOC_REF,
                        P_CL_SERIE_REF = e.CL_SERIE_REF,
                        P_CL_NUM_REF = e.CL_NUM_REF,
                        P_CL_BANK_BUSSINESS = e.CL_BANK_BUSSINESS,
                        P_CL_ACCOUNT_BANK_CHECK = e.CL_ACCOUNT_BANK_CHECK,
                        P_CL_PAYMENT_METHOD = e.CL_PAYMENT_METHOD,
                        P_CL_OPT_AN = e.CL_OPT_AN,
                        P_CL_DATE_REF = e.CL_DATE_REF
                    },
                            commandType: CommandType.StoredProcedure);
                }                
            }
            return "ok";
        }
    }
}
