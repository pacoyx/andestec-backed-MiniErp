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
    public class TRA_WAREHOUSE_QTYDA
    {
        public static ETRA_WAREHOUSE_QTY GetStock(ETRA_WAREHOUSE_QTY e)
        {
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                var sql = "SP_S_WAREHOUSE_QTY";
                cnx.Open();
                return cnx.Query<ETRA_WAREHOUSE_QTY>(sql, new {
                    P_IDCOMPANY = e.IDCOMPANY,
                    P_IDARTICLE = e.IDARTICLE,
                    P_IDWAREHOUSE = e.IDWAREHOUSE
                }, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
        }

        public static double getStockTotalxLote(ETRA_WAREHOUSE_QTY e)
        {
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                var sql = "SP_S_STOCKTOTALLOTE";
                cnx.Open();
                return cnx.Query<double>(sql, new
                {
                    P_IDCOMPANY = e.IDCOMPANY,
                    P_IDARTICLE = e.IDARTICLE,
                    P_IDWAREHOUSE = e.IDWAREHOUSE
                }, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
        }

        public static ERE_LISTA07 GetStockxLote(ETRA_WAREHOUSE_QTY_LOT e)
        {
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                var sql = "SP_S_WAREHOUSE_QTY_LOT";
                cnx.Open();
                return cnx.Query<ERE_LISTA07>(sql, new
                {
                    P_IDCOMPANY = e.IDCOMPANY,
                    P_IDARTICLE = e.IDARTICLE,
                    P_IDWAREHOUSE = e.IDWAREHOUSE,
                    P_IDLOT = e.IDLOT
                }, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
        }

    }
}
