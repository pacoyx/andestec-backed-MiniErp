using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE.Test;
using Dapper;
using System.Data.SqlClient;
using System.Data;

namespace DA.Test
{
    public static class TradingDA
    {
        public static string Insert(TRADING e)
        {
            string res="ok";

            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                string sql = "I_TRADING";
                try {
                    cnx.Execute(sql, new
                    {
                        P_NUMALUM = e.NUMALUM,
                        P_LUGAR = e.LUGAR,
                        P_CAPACITADOR = e.CAPACITADOR,
                        P_TEMAS = e.TEMAS,
                        P_OFICINA = e.OFICINA,
                        P_OBS = e.OBS
                    },
                            commandType: CommandType.StoredProcedure);
                }
                catch (Exception ex) {
                    res = ex.Message;
                }
                
            }

            return res;
        }

        public static string Update(TRADING e)
        {
            string res = "ok";

            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                string sql = "U_TRADING";
                try
                {
                    cnx.Execute(sql, new
                    {
                        P_ID = e.ID,
                        P_NUMALUM = e.NUMALUM,
                        P_LUGAR = e.LUGAR,
                        P_CAPACITADOR = e.CAPACITADOR,
                        P_TEMAS = e.TEMAS,
                        P_OFICINA = e.OFICINA,
                        P_OBS = e.OBS
                    },
                            commandType: CommandType.StoredProcedure);
                }
                catch (Exception ex)
                {
                    res = ex.Message;
                }

            }

            return res;
        }

        public static string Delete(TRADING e)
        {
            string res = "ok";
            try {
                using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
                {
                    string sql = "D_TRADING";
                    cnx.Execute(sql, new
                    {
                        P_ID = e.ID
                    },
                                commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex) {
                res = ex.Message;
            }
            return res;
        }

        public static List<TRADING> GetAll()
        {
            var sql = "S_TRADING";
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                return cnx.Query<TRADING>(sql, commandType: CommandType.StoredProcedure).ToList();
            }
        }

        public static TRADING GetByid(TRADING e)
        {
            var sql = "S_TRADING_BYID";
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                return cnx.Query<TRADING>(sql, new { P_ID = e.ID }, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
        }



    }
}
