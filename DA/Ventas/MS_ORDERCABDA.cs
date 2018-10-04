using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using BE.Ventas;
using Dapper;


namespace DA.Ventas
{
    public static class MS_ORDERCABDA
    {
        public static string Insert(EMS_ORDER ePedido)
        {
            string res;
            EMS_ORDERCAB c = ePedido.Cabecera;
            List<EMS_ORDERDET> d = ePedido.Detalle;
            Int32 idorder = 0;

            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                cnx.Open();
                SqlTransaction tr = cnx.BeginTransaction(IsolationLevel.Serializable);
                try
                {
                    string sql = "SP_I_MS_ORDERCAB";
                    idorder = cnx.ExecuteScalar<Int32>(sql, new
                    {
                        P_OC_DATEORDER = DateTime.Parse(c.OC_DATEORDER),
                        P_OC_DELIVERDATE = DateTime.Parse(c.OC_DELIVERDATE),
                        P_OC_IDCURRENCY = c.OC_IDCURRENCY,
                        P_OC_IDCUSTOMER = c.OC_IDCUSTOMER,
                        P_OC_DELIVERYADD = c.OC_DELIVERYADD,
                        P_OC_IDPAYMENTTYPE = c.OC_IDPAYMENTTYPE,
                        P_OC_IDCENCOST = c.OC_IDCENCOST,
                        P_OC_IDPROJECT = c.OC_IDPROJECT,
                        P_OC_IDSALESTYPE = c.OC_IDSALESTYPE,
                        P_OC_IDWILCARD = c.OC_IDWILCARD,
                        P_OC_COMMENT = c.OC_COMMENT,
                        P_OC_ISTATUS = c.OC_ISTATUS,
                        P_OC_ACTIVE = c.OC_ACTIVE,
                        P_OC_AUSUARIO = c.OC_AUSUARIO,
                        P_OC_AFECREG = DateTime.Parse(c.OC_AFECREG),
                        P_OC_AMODIFICO = c.OC_AMODIFICO,
                        P_OC_AFECMOD = DateTime.Parse(c.OC_AFECMOD),
                        P_OC_IDCOMPANY = c.OC_IDCOMPANY,
                        P_OC_IDSELLER = c.OC_IDSELLER,
                        P_OC_SERIE = c.OC_SERIE,
                        P_OC_CORRE = c.OC_CORRE,
                        P_OC_WILCARDTEXT = c.OC_WILCARDTEXT
                    }, tr,
                                commandType: CommandType.StoredProcedure);


                    sql = "SP_I_MS_ORDERDET";
                    foreach (var item in d)
                    {
                        cnx.Execute(sql, new
                        {
                            P_OD_IDORDERCAB = idorder,
                            P_OD_ITEM = item.OD_ITEM,
                            P_OD_IDARTICULO = item.OD_IDARTICULO,
                            P_OD_DEARTICULO = item.OD_DEARTICULO,
                            P_OD_QTY = item.OD_QTY,
                            P_OD_UNITPRICE = item.OD_UNITPRICE,
                            P_OD_TOTALPRICE = item.OD_TOTALPRICE,
                            P_OD_ISTATUS = item.OD_ISTATUS,
                            P_OD_QTY_DISPA = item.OD_QTY_DISPA
                        }, tr,
                                   commandType: CommandType.StoredProcedure);
                    }


                    tr.Commit();
                    res = "ok";

                }
                catch (Exception e)
                {
                    tr.Rollback();
                    res = e.Message;
                }

            }

            return res;

        }


        public static List<ERE_LISTADOPEDIDO> GetListadoPedidos(int emp)
        {
            var sql = "SP_S_LISTADOPEDIDOS";
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                cnx.Open();
                return cnx.Query<ERE_LISTADOPEDIDO>(sql, new { P_OC_IDCOMPANY = emp }, commandType: CommandType.StoredProcedure).ToList();
            }
        }

        public static List<ERE_LISTADOPEDIDOAYU> GetListadoPedidosAyuda(int emp,int idcliente)
        {
            var sql = "SP_S_LISTADOPEDIDOS02";
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                cnx.Open();
                return cnx.Query<ERE_LISTADOPEDIDOAYU>(sql, new { P_OC_IDCOMPANY = emp, P_OC_IDCUSTOMER = idcliente }, commandType: CommandType.StoredProcedure).ToList();
            }
        }

        public static ERE_VISTAPEDIDOCAB GetRepVistaPedidoCab(int emp, int idorder)
        {
            var sql = "SP_S_REPVISTAPEDIDOCAB";
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                cnx.Open();
                return cnx.Query<ERE_VISTAPEDIDOCAB>(sql, new { P_IDORDER = idorder, P_IDCOMPANY = emp }, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
        }

        public static List<ERE_VISTAPEDIDODET> GetRepVistaPedidoDet(int idorder)
        {
            var sql = "SP_S_REPVISTAPEDIDODET";
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                cnx.Open();
                return cnx.Query<ERE_VISTAPEDIDODET>(sql, new { P_IDORDER = idorder }, commandType: CommandType.StoredProcedure).ToList();
            }
        }

        public static List<ERE_VISTAPEDIDODET> GetListaPedidoaFac(int idorder)
        {
            var sql = "SP_S_LISTAPEDIDOAFAC";
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                cnx.Open();
                return cnx.Query<ERE_VISTAPEDIDODET>(sql, new { P_IDORDER = idorder }, commandType: CommandType.StoredProcedure).ToList();
            }
        }

    }
}
