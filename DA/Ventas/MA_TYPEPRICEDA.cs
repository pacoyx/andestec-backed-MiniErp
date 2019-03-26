using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE.Ventas;
using Dapper;
using System.Data.SqlClient;
using System.Data;

namespace DA.Ventas
{
    public static class MA_TYPEPRICEDA
    {
        public static string Insert(EMA_TYPEPRICE e)
        {
            string rpta = "ok";
            try
            {
                using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
                {
                    string sql = "SP_I_MA_TYPEPRICE";
                    cnx.Execute(sql, new
                    {
                        PTP_ID = e.TP_ID,
                        PTP_DES = e.TP_DES,
                        PTP_IDCOMPANY = e.TP_IDCOMPANY
                    },
                                commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex) { rpta = ex.Message; }
            return rpta;
        }

        public static string InsertArticuloTP(EMA_TIPPREDETALLE e)
        {
            string rpta = "ok";
            try
            {
                using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
                {
                    string sql = "SP_I_ARTICULOTP";
                    cnx.Execute(sql, new
                    {
                        P_IDTP = e.TPD_TPID,
                        P_IDARTI = e.TPD_ARID,
                        P_SOL = e.TPD_SOL,
                        P_DOL = e.TPD_DOLAR,
                        P_IDEMPRESA = e.TPD_IDCOMPANY
                    },
                                commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex) { rpta = ex.Message; }
            return rpta;
        }

        public static string Update(EMA_TYPEPRICE e)
        {
            string rpta = "ok";
            try
            {
                using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
                {
                    string sql = "SP_U_MA_TYPEPRICE";
                    cnx.Execute(sql, new
                    {
                        PTP_ID = e.TP_ID,
                        PTP_DES = e.TP_DES,
                        PTP_IDCOMPANY = e.TP_IDCOMPANY
                    },
                                commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex) { rpta = ex.Message; }
            return rpta;
        }

        public static string Delete(EMA_TYPEPRICE e)
        {
            string rpta = "ok";
            try
            {
                using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
                {
                    string sql = "SP_D_MA_TYPEPRICE";
                    cnx.Execute(sql, new
                    {
                        PTP_ID = e.TP_ID,
                        PTP_IDCOMPANY = e.TP_IDCOMPANY
                    },
                                commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex) { rpta = ex.Message; }
            return rpta;
        }

        public static List<EMA_TYPEPRICE> GetAll(EMA_TYPEPRICE e)
        {
            var sql = "SP_S_MA_TYPEPRICE";
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                cnx.Open();
                return cnx.Query<EMA_TYPEPRICE>(sql, new { PTP_IDCOMPANY = e.TP_IDCOMPANY }, commandType: CommandType.StoredProcedure).ToList();
            }
        }

        public static List<EMA_ARTICULOTP> GetArticulosxTP(EMA_TYPEPRICE e)
        {
            var sql = "SP_S_ARTIXTIPPRE";
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                cnx.Open();
                return cnx.Query<EMA_ARTICULOTP>(sql, new { P_TP = e.TP_ID, P_IDEMPRESA = e.TP_IDCOMPANY }, commandType: CommandType.StoredProcedure).ToList();
            }
        }

        public static EMA_ARTICULOTP GetTipoPrecioByid(EMA_TYPEPRICE e)
        {
            var sql = "SP_S_ARTIXTIPPRE_BYIDARTI";
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                //la propiedad e.TP_DES guardara elcodigo del articulo (int ID_ARTICLE) temporalmente
                cnx.Open();
                return cnx.Query<EMA_ARTICULOTP>(sql, new { P_TP = e.TP_ID, P_IDARTICLE = int.Parse( e.TP_DES),P_IDEMPRESA = e.TP_IDCOMPANY }, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
        }

        public static EMA_TYPEPRICE GetByid(EMA_TYPEPRICE e)
        {
            var sql = "SP_S_MA_TYPEPRICE_BYID";
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                cnx.Open();
                return cnx.Query<EMA_TYPEPRICE>(sql, new { PTP_ID = e.TP_ID, PTP_IDCOMPANY = e.TP_IDCOMPANY }, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
        }

    }


}
