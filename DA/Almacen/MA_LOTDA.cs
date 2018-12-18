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
    public static class MA_LOTDA
    {
        public static string Insert(EMA_LOT e) {
            string rpta = "ok";
            try
            {
                using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
                {
                    string sql = "SP_I_MA_LOT";
                    cnx.Execute(sql, new
                    {
                        P_IDCOMPANY = e.IDCOMPANY,
                        P_IDARTICLE = e.IDARTICLE,
                        P_IDLOT = e.IDLOT,
                        P_DESCRIPTION = e.DESCRIPTION,
                        P_EXPEDITION_DATE = e.EXPEDITION_DATE,
                        P_CADUCATE_DATE = e.CADUCATE_DATE,
                        P_COMMENT = e.COMMENT,
                        P_ISTATUS = e.ISTATUS
                    },
                                commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex) { rpta = "error: " + ex.Message; }
            return rpta;
        }

        public static string Update(EMA_LOT e)
        {
            string rpta = "ok";
            try
            {
                using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
                {
                    string sql = "SP_U_MA_LOT";
                    cnx.Execute(sql, new
                    {
                        P_IDCOMPANY = e.IDCOMPANY,
                        P_IDARTICLE = e.IDARTICLE,
                        P_IDLOT = e.IDLOT,
                        P_DESCRIPTION = e.DESCRIPTION,
                        P_EXPEDITION_DATE = e.EXPEDITION_DATE,
                        P_CADUCATE_DATE = e.CADUCATE_DATE,
                        P_COMMENT = e.COMMENT,
                        P_ISTATUS = e.ISTATUS
                    },
                                commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex) { rpta = "error: " + ex.Message; }
            return rpta;
        }

        public static string Delete(EMA_LOT e)
        {
            string rpta = "ok";
            try
            {
                using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
                {
                    string sql = "SP_D_MA_LOT";
                    cnx.Execute(sql, new
                    {
                        P_IDCOMPANY = e.IDCOMPANY,
                        P_IDLOT = e.IDLOT
                    },
                                commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex) { rpta = "error: " + ex.Message; }
            return rpta;
        }

        public static List<EMA_LOT> GetAll(EMA_LOT e)
        {
            var sql = "SP_S_MA_LOT";
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                cnx.Open();
                return cnx.Query<EMA_LOT>(sql, new { P_IDCOMPANY = e.IDCOMPANY }, commandType: CommandType.StoredProcedure).ToList();
            }
        }

        public static EMA_LOT GetByid(EMA_LOT e)
        {
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                var sql = "SP_S_MA_LOT_BYID";
                cnx.Open();
                return cnx.Query<EMA_LOT>(sql, new { P_IDCOMPANY = e.IDCOMPANY, P_IDLOT  = e.IDLOT}, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
        }

        public static List<EMA_LOT> GetByidArticulo(EMA_LOT e)
        {
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                var sql = "SP_S_MA_LOT_BYIDARTI";
                cnx.Open();
                return cnx.Query<EMA_LOT>(sql, new { P_IDCOMPANY = e.IDCOMPANY, P_IDARTICLE = e.IDARTICLE }, commandType: CommandType.StoredProcedure).ToList();
            }
        }



    }
}
