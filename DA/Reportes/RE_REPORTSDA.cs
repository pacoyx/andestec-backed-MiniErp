using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Dapper;
using BE.Almacen;
using BE.Ventas;

namespace DA.Reportes
{
    public static class RE_REPORTSDA
    {
        public static List<EREP_INVKARDEX> GetRepAlmacenKardex(ETRA_WAREHOUSE ent)
        {
            var sql = "SP_S_REP_INVKARDEX";
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                cnx.Open();
                return cnx.Query<EREP_INVKARDEX>(sql, new
                {
                    PID_WAREHOUSE = ent.ID_WAREHOUSE,
                    PFECINI = DateTime.Parse(ent.TRANSACTION_DATE),
                    PFECFIN = DateTime.Parse(ent.AFECREG),//aqui guardo la fecha fin para el reporte
                    PID_COMPANY = ent.ID_COMPANY
                }, commandType: CommandType.StoredProcedure).ToList();
            }
        }

        public static List<EREP_INVTRANSAC> GetRepAlmacenTransacciones(ETRA_WAREHOUSE ent)
        {
            var sql = "SP_S_REP_INVTRANSAC";
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                cnx.Open();
                return cnx.Query<EREP_INVTRANSAC>(sql, new
                {
                    PTRANSACTION_TYPE = ent.TRANSACTION_TYPE,
                    PID_COMPANY = ent.ID_COMPANY                    
                }, commandType: CommandType.StoredProcedure).ToList();
            }
        }

        public static List<EREP_INVSTOCK> GetRepAlmacenStock(ETRA_WAREHOUSE ent)
        {
            var sql = "SP_S_REP_INVSTOCK";
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                cnx.Open();
                return cnx.Query<EREP_INVSTOCK>(sql, new
                {
                    PID_WAREHOUSE = ent.ID_WAREHOUSE,
                    PID_COMPANY = ent.ID_COMPANY                    
                }, commandType: CommandType.StoredProcedure).ToList();
            }
        }

        public static List<EREP_SELVTAXSEL> GetRepVentasxVendedor(EMS_VOUCHERHE ent)
        {
            var sql = "SP_S_REP_SELVTAXSEL";
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                cnx.Open();
                return cnx.Query<EREP_SELVTAXSEL>(sql, new
                {
                    PVH_IDSELLER = ent.VH_IDSELLER,
                    PVH_VOUCHERDATE1 = DateTime.Parse(ent.VH_VOUCHERDATE),
                    PVH_VOUCHERDATE2 = DateTime.Parse(ent.VH_DELIVERDATE),
                    PVH_IDCOMPANY = ent.VH_IDCOMPANY
                }, commandType: CommandType.StoredProcedure).ToList();
            }
        }

        public static List<EREP_SELVTAXARTI> GetRepVentasxArticulo(EMS_VOUCHERHE ent)
        {
            var sql = "SP_S_REP_SELVTAXARTI";
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                cnx.Open();
                return cnx.Query<EREP_SELVTAXARTI>(sql, new
                {
                    PVD_IDARTICULO = ent.VH_IDORDER,//aqui guardo el codigo de articulo
                    PVH_VOUCHERDATE1 = DateTime.Parse(ent.VH_VOUCHERDATE),
                    PVH_VOUCHERDATE2 = DateTime.Parse(ent.VH_DELIVERDATE),
                    PVH_IDCOMPANY = ent.VH_IDCOMPANY
                }, commandType: CommandType.StoredProcedure).ToList();
            }
        }

        public static List<EREP_SELVTAXCUSTO> GetRepVentasxCliente(EMS_VOUCHERHE ent)
        {
            var sql = "SP_S_REP_SELVTAXCUSTO";
            using (SqlConnection cnx = new SqlConnection(Utilidad.getCadenaCnx()))
            {
                cnx.Open();
                return cnx.Query<EREP_SELVTAXCUSTO>(sql, new
                {
                    PVH_IDCUSTOMER = ent.VH_IDCUSTOMER,
                    PVH_VOUCHERDATE1 = DateTime.Parse( ent.VH_VOUCHERDATE),
                    PVH_VOUCHERDATE2 = DateTime.Parse(ent.VH_DELIVERDATE),
                    PVH_IDCOMPANY = ent.VH_IDCOMPANY
                }, commandType: CommandType.StoredProcedure).ToList();
            }
        }


    }
}
