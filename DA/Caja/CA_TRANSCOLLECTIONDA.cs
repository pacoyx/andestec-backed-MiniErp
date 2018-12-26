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
    public static class CA_TRANSCOLLECTIONDA
    {
        public static string Insert(ECA_TRANSCOLLECTION e)
        {
            string rpta = "ok";
            try
            {
                using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
                {
                    string sql = "SP_I_CA_TRANSCOLLECTION";
                    cnx.Execute(sql, new
                    {
                        P_TC_IDTRANSCOLLECTION = e.TC_IDTRANSCOLLECTION,
                        P_TC_DESCRIPTION = e.TC_DESCRIPTION,
                        P_TC_IDCURRENCY = e.TC_IDCURRENCY,
                        P_TC_TYPECASH = e.TC_TYPECASH,
                        P_TC_TYPEDEPOSIT = e.TC_TYPEDEPOSIT,
                        P_TC_TYPEAPPDPOC = e.TC_TYPEAPPDPOC,
                        P_TC_TYPEPROVIDER = e.TC_TYPEPROVIDER,
                        P_TC_TYPECARD = e.TC_TYPECARD,
                        P_TC_ISTATUS = e.TC_ISTATUS,
                        P_TC_IDCOMPANY = e.TC_IDCOMPANY
                    },
                                commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex) { rpta = ex.Message; }
            return rpta;
        }

        public static string Update(ECA_TRANSCOLLECTION e)
        {
            string rpta = "ok";
            try
            {
                using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
                {
                    string sql = "SP_U_CA_TRANSCOLLECTION";
                    cnx.Execute(sql, new
                    {
                        P_TC_IDTRANSCOLLECTION = e.TC_IDTRANSCOLLECTION,
                        P_TC_DESCRIPTION = e.TC_DESCRIPTION,
                        P_TC_IDCURRENCY = e.TC_IDCURRENCY,
                        P_TC_TYPECASH = e.TC_TYPECASH,
                        P_TC_TYPEDEPOSIT = e.TC_TYPEDEPOSIT,
                        P_TC_TYPEAPPDPOC = e.TC_TYPEAPPDPOC,
                        P_TC_TYPEPROVIDER = e.TC_TYPEPROVIDER,
                        P_TC_TYPECARD = e.TC_TYPECARD,
                        P_TC_ISTATUS = e.TC_ISTATUS,
                        P_TC_IDCOMPANY = e.TC_IDCOMPANY
                    },
                                commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex) { rpta = ex.Message; }
            return rpta;
        }

        public static string Delete(ECA_TRANSCOLLECTION e)
        {
            string rpta = "ok";
            try
            {
                using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
                {
                    string sql = "SP_D_CA_TRANSCOLLECTION";
                    cnx.Execute(sql, new
                    {
                        P_TC_IDTRANSCOLLECTION = e.TC_IDTRANSCOLLECTION,
                        P_TC_IDCOMPANY = e.TC_IDCOMPANY
                    },
                                commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex) { rpta = ex.Message; }
            return rpta;
        }

        public static List<ECA_TRANSCOLLECTION> GetAll(ECA_TRANSCOLLECTION e)
        {
            var sql = "SP_S_CA_TRANSCOLLECTION";
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                return cnx.Query<ECA_TRANSCOLLECTION>(sql, new { P_TC_IDCOMPANY = e.TC_IDCOMPANY }, commandType: CommandType.StoredProcedure).ToList();
            }
        }

        public static ECA_TRANSCOLLECTION GetByid(ECA_TRANSCOLLECTION e)
        {
            var sql = "SP_S_CA_TRANSCOLLECTION_BYID";
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                return cnx.Query<ECA_TRANSCOLLECTION>(sql, new { P_TC_IDTRANSCOLLECTION = e.TC_IDTRANSCOLLECTION, P_TC_IDCOMPANY = e.TC_IDCOMPANY }, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
        }

    }
}
