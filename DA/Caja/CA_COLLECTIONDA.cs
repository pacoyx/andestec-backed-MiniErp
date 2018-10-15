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
    public static class CA_COLLECTIONDA
    {
        public static Int32 Insert(ECA_COLLECTION e)
        {
            Int32 idPlanilla = 0;

            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                string sql = "SP_I_CA_COLLECTION";
                idPlanilla = cnx.ExecuteScalar<Int32>(sql, new
                {
                    P_CO_PLACE_SALES = e.CO_PLACE_SALES,
                    P_CO_DATE = DateTime.Parse(e.CO_DATE),
                    P_CO_ISTATUS = e.CO_ISTATUS,
                    P_CO_IDCOMPANY = e.CO_IDCOMPANY
                },
                              commandType: CommandType.StoredProcedure);
                return idPlanilla;
            }
            
        }

        public static List<ECA_COLLECTION> GetAll(ECA_COLLECTION e)
        {
            var sql = "SP_S_CA_COLLECTION";
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                return cnx.Query<ECA_COLLECTION>(sql, new
                {
                    P_FECHA1 = DateTime.Parse(e.FECHAINI),
                    P_FECHA2 = DateTime.Parse(e.FECHAFIN),
                    P_CO_IDCOMPANY = e.CO_IDCOMPANY
                },
                    commandType: CommandType.StoredProcedure).ToList();
            }
        }
    }


}
