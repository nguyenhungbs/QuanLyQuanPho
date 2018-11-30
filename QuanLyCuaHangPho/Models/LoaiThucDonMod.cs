using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace QuanLyCuaHangPho.Models
{
    class LoaiThucDonMod
    {
        protected string MaLoaiThucDon { get; set; }
        protected string TenLoaiThucDon { get; set; }
        protected string DienGiai { get; set; }
        protected string TrangThai { get; set; }
        public LoaiThucDonMod(string _MaLoaiThucDon)
        {
            MaLoaiThucDon = _MaLoaiThucDon;
        }
        public LoaiThucDonMod() { }
        public LoaiThucDonMod(string _MaLoaiThucDon, string _TenLoaiThucDon, string _DienGiai, string _TrangThai)
        {
            MaLoaiThucDon = _MaLoaiThucDon;
            TenLoaiThucDon = _TenLoaiThucDon;
            DienGiai = _DienGiai;
            TrangThai = _TrangThai;
        }
        public int InsertLoaiThucDon()
        {
            int i = 0;
            string[] paras = new string[4] { "@MaLoaiThucDon", "@TenLoaiThucDon", "@DienGiai", "@TrangThai" };
            object[] values = new object[4] { MaLoaiThucDon, TenLoaiThucDon, DienGiai, TrangThai };
            i = Models.connection.Excute_Sql("sp_themloaithucdon", CommandType.StoredProcedure, paras, values);
            return i;
        }
        public int UpdateLoaiThucDon()
        {
            int i = 0;
            string[] paras = new string[4] { "@MaLoaiThucDon", "@TenLoaiThucDon", "@DienGiai", "@TrangThai" };
            object[] values = new object[4] { MaLoaiThucDon, TenLoaiThucDon, DienGiai, TrangThai };
            i = Models.connection.Excute_Sql("sp_sualoaithucdon", CommandType.StoredProcedure, paras, values);
            return i;
        }
        public int DeleteLoaiThucDon()
        {
            int i = 0;
            string[] paras = new string[1] { "@MaLoaiThucDon" };
            object[] values = new object[1] { MaLoaiThucDon };
            i = Models.connection.Excute_Sql("sp_xoaloaithucdon", CommandType.StoredProcedure, paras, values);
            return i;
        }
        public static DataSet FillDataSetLoaiThucDon()
        {
            return Models.connection.FillDataSet("sp_getLoaiThucDon", CommandType.StoredProcedure);
        }
        public DataSet FillDataSet_getLoaiThucDonbyID()
        {
            DataSet ds = new DataSet();
            string[] paras = new string[1] { "@MaLoaiThucDon" };
            object[] values = new object[1] { MaLoaiThucDon };
            ds = Models.connection.FillDataSet("sp_getLoaiThucDonbyID", CommandType.StoredProcedure, paras, values);
            return ds;
        }
        
    }
}
