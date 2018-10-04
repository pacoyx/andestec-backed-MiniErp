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
    public static class CA_BANKACCOUNTDA
    {
        public static void Insert(ECA_BANKACCOUNT e)
        {
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                string sql = "SP_I_CA_BANKACCOUNT";
                cnx.Execute(sql, new
                {
                    P_AB_IDBANKACCOUNT = e.AB_IDBANKACCOUNT,
                    P_AB_IDBANK = e.AB_IDBANK,
                    P_AB_CURRENCY = e.AB_CURRENCY,
                    P_AB_DESCRIPTION = e.AB_DESCRIPTION,
                    P_AB_IDCOMPANY = e.AB_IDCOMPANY
                },
                            commandType: CommandType.StoredProcedure);
            }
        }

        public static void Update(ECA_BANKACCOUNT e)
        {
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                string sql = "SP_U_CA_BANKACCOUNT";
                cnx.Execute(sql, new
                {
                    P_AB_ID = e.AB_ID,
                    P_AB_IDBANKACCOUNT = e.AB_IDBANKACCOUNT,
                    P_AB_IDBANK = e.AB_IDBANK,
                    P_AB_CURRENCY = e.AB_CURRENCY,
                    P_AB_DESCRIPTION = e.AB_DESCRIPTION,
                    P_AB_IDCOMPANY = e.AB_IDCOMPANY
                },
                            commandType: CommandType.StoredProcedure);
            }
        }

        public static void Delete(ECA_BANKACCOUNT e)
        {
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                string sql = "SP_D_CA_BANKACCOUNT";
                cnx.Execute(sql, new
                {
                    P_AB_ID = e.AB_ID,                    
                    P_AB_IDCOMPANY = e.AB_IDCOMPANY
                },
                            commandType: CommandType.StoredProcedure);
            }
        }

        public static List<ECA_BANKACCOUNT> GetAll(ECA_BANKACCOUNT e)
        {
            var sql = "SP_S_CA_BANKACCOUNT";
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                return cnx.Query<ECA_BANKACCOUNT>(sql, new { P_AB_IDCOMPANY = e.AB_IDCOMPANY }, commandType: CommandType.StoredProcedure).ToList();
            }
        }

        public static ECA_BANKACCOUNT GetByid(ECA_BANKACCOUNT e)
        {
            var sql = "SP_D_CA_BANKACCOUNT_BYID";
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                return cnx.Query<ECA_BANKACCOUNT>(sql, new { P_AB_ID = e.AB_ID, P_AB_IDCOMPANY = e.AB_IDCOMPANY }, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
        }

        
    }
}
