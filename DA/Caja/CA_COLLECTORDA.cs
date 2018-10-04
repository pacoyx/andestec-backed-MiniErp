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
    public static class CA_COLLECTORDA
    {
        public static void Insert(ECA_COLLECTOR e)
        {
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                string sql = "SP_I_CA_COLLECTOR";
                cnx.Execute(sql, new
                {
                    P_CO_IDCOLLECTOR = e.CO_IDCOLLECTOR,
                    P_CO_DESCRIPTION = e.CO_DESCRIPTION,
                    P_CO_DOCUMENT = e.CO_DOCUMENT,
                    P_CO_MAIL = e.CO_MAIL,
                    P_CO_MOVIL = e.CO_MOVIL,
                    P_CO_ISTATUS = e.CO_ISTATUS,
                    P_CO_IDCOMPANY = e.CO_IDCOMPANY
                },
                            commandType: CommandType.StoredProcedure);
            }
        }

        public static void Update(ECA_COLLECTOR e)
        {
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                string sql = "SP_U_CA_COLLECTOR";
                cnx.Execute(sql, new
                {
                    P_CO_IDCOLLECTOR = e.CO_IDCOLLECTOR,
                    P_CO_DESCRIPTION = e.CO_DESCRIPTION,
                    P_CO_DOCUMENT = e.CO_DOCUMENT,
                    P_CO_MAIL = e.CO_MAIL,
                    P_CO_MOVIL = e.CO_MOVIL,
                    P_CO_ISTATUS = e.CO_ISTATUS,
                    P_CO_IDCOMPANY = e.CO_IDCOMPANY
                },
                            commandType: CommandType.StoredProcedure);
            }
        }

        public static void Delete(ECA_COLLECTOR e)
        {
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                string sql = "SP_D_CA_COLLECTOR";
                cnx.Execute(sql, new
                {
                    P_CO_IDCOLLECTOR = e.CO_IDCOLLECTOR,                    
                    P_CO_IDCOMPANY = e.CO_IDCOMPANY
                },
                            commandType: CommandType.StoredProcedure);
            }
        }

        public static List<ECA_COLLECTOR> GetAll(ECA_COLLECTOR e)
        {
            var sql = "SP_S_CA_COLLECTOR";
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                return cnx.Query<ECA_COLLECTOR>(sql, new { P_CO_IDCOMPANY = e.CO_IDCOMPANY }, commandType: CommandType.StoredProcedure).ToList();
            }
        }

        public static ECA_COLLECTOR GetByid(ECA_COLLECTOR e)
        {
            var sql = "SP_S_CA_COLLECTOR_BYID";
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                return cnx.Query<ECA_COLLECTOR>(sql, new { P_CO_IDCOLLECTOR = e.CO_IDCOLLECTOR, P_CO_IDCOMPANY = e.CO_IDCOMPANY }, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
        }

    }
}
