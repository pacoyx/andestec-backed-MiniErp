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
    public static class TRA_WAREHOUSEDA
    {

        public static string Insert(ETRA_GUIAING guia)
        {
            string rpta = "";
            ETRA_WAREHOUSE e = guia.Cabecera;
            List<ETRA_WAREHOUSE_LINE> dets = guia.Detalle;

            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                cnx.Open();
                SqlTransaction tr = cnx.BeginTransaction(IsolationLevel.Serializable);
                try
                {
                    using (SqlCommand cmd = new SqlCommand("SP_I_TRA_WAREHOUSE", cnx, tr))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@P_ID_COMPANY", e.ID_COMPANY);
                        cmd.Parameters.AddWithValue("@P_ID_WAREHOUSE", e.ID_WAREHOUSE);
                        cmd.Parameters.AddWithValue("@P_ITRANSACTION", e.ITRANSACTION);
                        cmd.Parameters.AddWithValue("@P_TRANSACTION_TYPE", e.TRANSACTION_TYPE);
                        cmd.Parameters.AddWithValue("@P_DOCUMENT_TYPE", e.DOCUMENT_TYPE);
                        cmd.Parameters.AddWithValue("@P_ID_SERIE", e.ID_SERIE);
                        cmd.Parameters.AddWithValue("@P_ID_CORRELATIVE", e.ID_CORRELATIVE);
                        cmd.Parameters.AddWithValue("@P_TRANSACTION_DATE", e.TRANSACTION_DATE);
                        cmd.Parameters.AddWithValue("@P_TRANSACCION_CURRENCY", e.TRANSACCION_CURRENCY);
                        cmd.Parameters.AddWithValue("@P_ISTATUS", e.ISTATUS);
                        cmd.Parameters.AddWithValue("@P_AUSUARIO", e.AUSUARIO);
                        cmd.Parameters.AddWithValue("@P_AFECREG", e.AFECREG);
                        cmd.Parameters.AddWithValue("@P_AMODIFICO", e.AMODIFICO);
                        cmd.Parameters.AddWithValue("@P_AFECMOD", e.AFECMOD);
                        cmd.Parameters.AddWithValue("@P_TIPOPER", e.TIPOPER);
                        cmd.Parameters.AddWithValue("@P_PERSONA", e.PERSONA);
                        cmd.Parameters.AddWithValue("@P_IDCC", e.IDCC);
                        cmd.Parameters.AddWithValue("@P_COMMENT", e.COMMENT);
                        cmd.Parameters.AddWithValue("@P_NUMCORRE", string.Empty);   

                        Int32 idReg = int.Parse(cmd.ExecuteScalar().ToString());

                        foreach (var item in dets)
                        {
                            using (SqlCommand cmddet = new SqlCommand("SP_I_TRA_WAREHOUSE_LINE", cnx, tr))
                            {
                                cmddet.CommandType = CommandType.StoredProcedure;
                                cmddet.Parameters.AddWithValue("@P_ID_COMPANY", item.ID_COMPANY);
                                cmddet.Parameters.AddWithValue("@P_ID_TRANSACTION_WAREHOUSE_LINE", idReg);
                                cmddet.Parameters.AddWithValue("@P_ID_WAREHOUSE", item.ID_WAREHOUSE);
                                cmddet.Parameters.AddWithValue("@P_ITEM", item.ITEM);
                                cmddet.Parameters.AddWithValue("@P_ID_ARTICLE", item.ID_ARTICLE);
                                cmddet.Parameters.AddWithValue("@P_DESCRIPTION_ARTICLE", item.DESCRIPTION_ARTICLE);
                                cmddet.Parameters.AddWithValue("@P_LOT", item.LOT);
                                cmddet.Parameters.AddWithValue("@P_SERIE", item.SERIE);
                                cmddet.Parameters.AddWithValue("@P_QTY", item.QTY);
                                cmddet.Parameters.AddWithValue("@P_COST", item.COST);
                                cmddet.Parameters.AddWithValue("@P_COMMENT", item.COMMENT);
                                cmddet.Parameters.AddWithValue("@P_ISTATUS", item.ISTATUS);
                                cmddet.Parameters.AddWithValue("@P_AUSUARIO", item.AUSUARIO);
                                cmddet.Parameters.AddWithValue("@P_AFECREG", item.AFECREG);
                                cmddet.Parameters.AddWithValue("@P_AMODIFICO", item.AMODIFICO);
                                cmddet.Parameters.AddWithValue("@P_AFECMOD", item.AFECMOD);
                                cmddet.ExecuteNonQuery();
                            }
                        }

                    }
                    tr.Commit();
                    rpta = "ok";

                }
                catch (Exception ex) {
                    rpta = ex.Message.ToString();
                    tr.Rollback();
                }

            }
            return rpta;
        }

        public static List<ERE_LISTA01> GetAll(int emp,string alm,int ayo,int mes)
        {
            var sql = "SP_S_TRA_WAREHOUSE";
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                cnx.Open();
                return cnx.Query<ERE_LISTA01>(sql, new
                {
                    P_ID_COMPANY = emp,
                    P_ID_WAREHOUSE = alm,
                    P_AYO = ayo,
                    P_MES = mes
                }, commandType: CommandType.StoredProcedure).ToList();
            }
        }

        public static List<ERE_LISTA02> GetRepStockxAlmacen(int emp,string alm)
        {
            var sql = "SP_S_REPSTOCKXALMACEN";
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                cnx.Open();
                return cnx.Query<ERE_LISTA02>(sql, new { P_ID_COMPANY = emp, P_IDWAREHOUSE = alm }, commandType: CommandType.StoredProcedure).ToList();
            }
        }

        public static List<ERE_LISTA03> GetRepDetalleStockxAlmacen(int emp, int idarti)
        {
            var sql = "SP_S_DETALLESTOCKXALMACEN";
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                cnx.Open();
                return cnx.Query<ERE_LISTA03>(sql, new { P_ID_COMPANY = emp, P_IDARTICLE = idarti }, commandType: CommandType.StoredProcedure).ToList();
            }
        }

        public static ERE_LISTA04 GetRepVistaDocCab(int emp, int idtrans)
        {
            var sql = "SP_S_REPVISTADOCCAB";
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                cnx.Open();
                return cnx.Query<ERE_LISTA04>(sql, new { P_ID_COMPANY = emp, P_ID_TRANSACTION_WAREHOUSE = idtrans }, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
        }

        public static List<ERE_LISTA05> GetRepVistaDocDet(int idtrans)
        {
            var sql = "SP_S_REPVISTADOCDET";
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                cnx.Open();
                return cnx.Query<ERE_LISTA05>(sql, new { P_ID_CABTRANS = idtrans }, commandType: CommandType.StoredProcedure).ToList();
            }
        }

    }
}
