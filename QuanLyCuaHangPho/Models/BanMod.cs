using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace QuanLyCuaHangPho.Models
{
    class BanMod
    {
        protected string MaBan { get; set; }
        protected string TenBan { get; set; }
        protected string DienGiai { get; set; }
        protected string TrangThai { get; set; }
        public BanMod(string _MaBan)
        {
            MaBan = _MaBan;
        }
        public BanMod() { }
        public BanMod(string _MaBan, string _TenBan, string _DienGiai, string _TrangThai)
        {
            MaBan = _MaBan;
            TenBan = _TenBan;
            DienGiai = _DienGiai;
            TrangThai = _TrangThai;          
        }
        public int InsertBan()
        {
            int i = 0;
            string[] paras = new string[4] { "@MaBan", "@TenBan", "@DienGiai", "@TrangThai" };
            object[] values = new object[4] { MaBan, TenBan, DienGiai, TrangThai };
            i = Models.connection.Excute_Sql("sp_themban", CommandType.StoredProcedure, paras, values);
            return i;
        }
        public int UpdateBan()
        {
            int i = 0;
            string[] paras = new string[4] { "@MaBan", "@TenBan", "@DienGiai", "@TrangThai" };
            object[] values = new object[4] { MaBan, TenBan, DienGiai, TrangThai };
            i = Models.connection.Excute_Sql("sp_suaban", CommandType.StoredProcedure, paras, values);
            return i;
        }
        public int DeleteBan()
        {
            int i = 0;
            string[] paras = new string[1] { "@MaBan" };
            object[] values = new object[1] { MaBan };
            i = Models.connection.Excute_Sql("sp_xoaban", CommandType.StoredProcedure, paras, values);
            return i;
        }
        public static DataSet FillDataSetBan()
        {
            return Models.connection.FillDataSet("sp_getBan", CommandType.StoredProcedure);
        }
        public static DataSet FillDataSetDanhSachBan_GoiMon()
        {
            return Models.connection.FillDataSet("", CommandType.StoredProcedure);
        }
        public static DataSet FillDataSetTenBan()
        {
            return Models.connection.FillDataSet("sp_getTenBan", CommandType.StoredProcedure);
        }
        public DataSet FillDataSet_getBanbyID()
        {
            DataSet ds = new DataSet();
            string[] paras = new string[1] { "@MaBan" };
            object[] values = new object[1] { MaBan };
            ds = Models.connection.FillDataSet("sp_getBanbyID", CommandType.StoredProcedure, paras, values);
            return ds;
        }
    }
}
