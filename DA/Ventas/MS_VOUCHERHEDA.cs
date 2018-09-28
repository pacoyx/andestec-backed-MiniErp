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
    public class MS_VOUCHERHEDA
    {
        public static string Insert(EMS_VOUCHER eCompro)
        {
            string res;
            EMS_VOUCHERHE c = eCompro.Cabecera;
            List<EMS_VOUCHERDE> d = eCompro.Detalle;
            Int32 idorder = 0;

            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                cnx.Open();
                SqlTransaction tr = cnx.BeginTransaction(IsolationLevel.Serializable);
                try
                {
                    string sql = "SP_I_MS_VOUCHERHE";
                    idorder = cnx.ExecuteScalar<Int32>(sql, new
                    {
                        P_VH_TDOC = c.VH_TDOC,
                        P_VH_SDOC = c.VH_SDOC,
                        P_VH_NDOC = c.VH_NDOC,
                        P_VH_IDORDER = c.VH_IDORDER,
                        P_VH_IDGUIDE = c.VH_IDGUIDE,
                        P_VH_GSSER = c.VH_GSSER,
                        P_VH_GSNUM = c.VH_GSNUM,
                        P_VH_VOUCHERDATE = DateTime.Parse(c.VH_VOUCHERDATE),
                        P_VH_DELIVERDATE = DateTime.Parse(c.VH_DELIVERDATE),
                        P_VH_IDSELLER = c.VH_IDSELLER,
                        P_VH_IDCURRENCY = c.VH_IDCURRENCY,
                        P_VH_IDCUSTOMER = c.VH_IDCUSTOMER,
                        P_VH_DELIVERYADD = c.VH_DELIVERYADD,
                        P_VH_IDPAYMENTTYPE = c.VH_IDPAYMENTTYPE,
                        P_VH_IDCENCOST = c.VH_IDCENCOST,
                        P_VH_IDPROJECT = c.VH_IDPROJECT,
                        P_VH_IDSALESTYPE = c.VH_IDSALESTYPE,
                        P_VH_IDWILCARD = c.VH_IDWILCARD,
                        P_VH_COMMENT = c.VH_COMMENT,
                        P_VH_ISTATUS = c.VH_ISTATUS,
                        P_VH_ACTIVE = c.VH_ACTIVE,
                        P_VH_AUSUARIO = c.VH_AUSUARIO,
                        P_VH_AFECREG = DateTime.Parse(c.VH_AFECREG),
                        P_VH_AMODIFICO = c.VH_AMODIFICO,
                        P_VH_AFECMOD = DateTime.Parse(c.VH_AFECMOD),
                        P_VH_IDCOMPANY = c.VH_IDCOMPANY
                    }, tr,
                                commandType: CommandType.StoredProcedure);


                    sql = "SP_I_MS_VOUCHERDE";
                    foreach (var item in d)
                    {
                        cnx.Execute(sql, new
                        {
                            P_VD_IDVOUCHERHE = idorder,
                            P_VD_ITEM = item.VD_ITEM,
                            P_VD_IDARTICULO = item.VD_IDARTICULO,
                            P_VD_DEARTICULO = item.VD_DEARTICULO,
                            P_VD_QTY = item.VD_QTY,
                            P_VD_UNITPRICE = item.VD_UNITPRICE,
                            P_VD_TOTALPRICE = item.VD_TOTALPRICE,
                            P_VD_COMMENT = item.VD_COMMENT,
                            P_VD_ISTATUS = item.VD_ISTATUS,
                            P_VD_IDORDER = item.VD_IDORDER
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

        public static List<ERE_LISTADOCOMPROBANTE> GetListadoComprobantes(int emp)
        {
            var sql = "SP_S_LISTADOCOMPROBANTES";
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                cnx.Open();
                return cnx.Query<ERE_LISTADOCOMPROBANTE>(sql, new { P_VH_IDCOMPANY = emp }, commandType: CommandType.StoredProcedure).ToList();
            }
        }

        public static ERE_VISTACOMPROBANTECAB GetRepVistaComprobanteCab(int emp, int idorder)
        {
            var sql = "SP_S_REPVISTACOMPROCAB";
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                cnx.Open();
                return cnx.Query<ERE_VISTACOMPROBANTECAB>(sql, new { P_IDCOMPRO = idorder, P_IDCOMPANY = emp }, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
        }
        public static List<ERE_VISTACOMPROBANTEDET> GetRepVistaComprobanteDet(int idorder)
        {
            var sql = "SP_S_REPVISTACOMPRODET";
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                cnx.Open();
                return cnx.Query<ERE_VISTACOMPROBANTEDET>(sql, new { P_IDCOMPRO = idorder }, commandType: CommandType.StoredProcedure).ToList();
            }
        }


    }
}
