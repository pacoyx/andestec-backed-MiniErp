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
    public static class MA_CUSTOMERDA
    {
        public static void Insert(EMA_CUSTOMER e)
        {
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                string sql = "SP_I_MA_CUSTOMER";
                cnx.Execute(sql, new
                {
                    P_ID_COMPANY = e.ID_COMPANY,
                    P_DESCRIPTION_CUSTOMER = e.DESCRIPTION_CUSTOMER.Trim(),
                    P_DOCUMENT_TYPE_CUSTOMER = e.DOCUMENT_TYPE_CUSTOMER.Trim(),
                    P_NUMBER_DOCUMENT = e.NUMBER_DOCUMENT.Trim(),
                    P_NIF_ADDRESS = e.NIF_ADDRESS.Trim(),
                    P_DELIVERY_ADDRESS = e.DELIVERY_ADDRESS.Trim(),
                    P_COMMERCIAL_TYPE = e.COMMERCIAL_TYPE.Trim(),
                    P_CUSTOMER_TYPE = e.CUSTOMER_TYPE.Trim(),
                    P_PRICE_TYPE = e.PRICE_TYPE,
                    P_IDPAYMENTYPE = e.IDPAYMENTYPE,
                    P_CREDIT_LIMIT_LOCAL = e.CREDIT_LIMIT_LOCAL,
                    P_CREDIT_LIMIT_USD = e.CREDIT_LIMIT_USD,
                    P_CONTACT = e.CONTACT.Trim(),
                    P_MOVIL_CONTACT = e.MOVIL_CONTACT.Trim(),
                    P_EMAIL = e.EMAIL.Trim(),
                    P_ISTATUS = e.ISTATUS,
                    P_SALES_CODE = e.SALES_CODE,
                    P_AUSUARIO = e.AUSUARIO.Trim(),
                    P_AFECREG = e.AFECREG.Trim(),
                    P_AMODIFICO = e.AMODIFICO.Trim(),
                    P_AFECMOD = e.AFECMOD.Trim()
                },
                            commandType: CommandType.StoredProcedure);
            }
        }

        public static void Update(EMA_CUSTOMER e)
        {
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                string sql = "SP_U_MA_CUSTOMER";
                cnx.Execute(sql, new
                {
                    P_ID_CUSTOMER = e.ID_CUSTOMER,
                    P_ID_COMPANY = e.ID_COMPANY,
                    P_DESCRIPTION_CUSTOMER = e.DESCRIPTION_CUSTOMER.Trim(),
                    P_DOCUMENT_TYPE_CUSTOMER = e.DOCUMENT_TYPE_CUSTOMER.Trim(),
                    P_NUMBER_DOCUMENT = e.NUMBER_DOCUMENT.Trim(),
                    P_NIF_ADDRESS = e.NIF_ADDRESS.Trim(),
                    P_DELIVERY_ADDRESS = e.DELIVERY_ADDRESS.Trim(),
                    P_COMMERCIAL_TYPE = e.COMMERCIAL_TYPE.Trim(),
                    P_CUSTOMER_TYPE = e.CUSTOMER_TYPE.Trim(),
                    P_PRICE_TYPE = e.PRICE_TYPE,
                    P_IDPAYMENTYPE = e.IDPAYMENTYPE,
                    P_CREDIT_LIMIT_LOCAL = e.CREDIT_LIMIT_LOCAL,
                    P_CREDIT_LIMIT_USD = e.CREDIT_LIMIT_USD,
                    P_CONTACT = e.CONTACT.Trim(),
                    P_MOVIL_CONTACT = e.MOVIL_CONTACT.Trim(),
                    P_EMAIL = e.EMAIL.Trim(),
                    P_ISTATUS = e.ISTATUS,
                    P_SALES_CODE = e.SALES_CODE,
                    P_AUSUARIO = e.AUSUARIO.Trim(),
                    P_AFECREG = e.AFECREG.Trim(),
                    P_AMODIFICO = e.AMODIFICO.Trim(),
                    P_AFECMOD = e.AFECMOD.Trim()
                },
                            commandType: CommandType.StoredProcedure);
            }
        }

        public static void Delete(EMA_CUSTOMER e)
        {
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                string sql = "SP_D_MA_CUSTOMER";
                cnx.Execute(sql, new
                {
                    P_ID_CUSTOMER = e.ID_CUSTOMER,
                    P_ID_COMPANY = e.ID_COMPANY                    
                },
                            commandType: CommandType.StoredProcedure);
            }
        }

        public static List<EMA_CUSTOMER> GetAll(EMA_CUSTOMER e)
        {
            var sql = "SP_S_MA_CUSTOMER";
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                cnx.Open();
                return cnx.Query<EMA_CUSTOMER>(sql, new { P_ID_COMPANY = e.ID_COMPANY }, commandType: CommandType.StoredProcedure).ToList();
            }
        }

        public static EMA_CUSTOMER GetByid(EMA_CUSTOMER e)
        {
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                var sql = "SP_S_MA_CUSTOMER_BYID";
                cnx.Open();
                return cnx.Query<EMA_CUSTOMER>(sql, new { P_ID_COMPANY = e.ID_COMPANY, P_ID_CUSTOMER = e.ID_CUSTOMER }, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
        }

    }
}
