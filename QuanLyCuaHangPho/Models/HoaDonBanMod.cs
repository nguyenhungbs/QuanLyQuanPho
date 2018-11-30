using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace QuanLyCuaHangPho.Models
{
    class HoaDonBanMod
    {
        protected string MaHoaDon { get;set;}
        protected string TenKhachHang { get;set;}
        protected string MaNV { get;set;}
        protected string MaBan { get;set;}
        protected DateTime NgayLap { get;set;}
        protected string DienGiai { get;set;}
        protected decimal SoTien { get;set;}
        public HoaDonBanMod(string _MaHoaDon)
        {
            MaHoaDon = _MaHoaDon;
        }
        public HoaDonBanMod() { }
        public HoaDonBanMod(string _MaHoaDon, string _MaNV,string _MaBan, string _TenKhachHang, DateTime _NgayLap, string _DienGiai, decimal _SoTien)
        {
            MaHoaDon = _MaHoaDon;
            MaNV = _MaNV;
            MaBan = _MaBan;
            TenKhachHang = _TenKhachHang;
            NgayLap = _NgayLap;
            SoTien = _SoTien;
            DienGiai = _DienGiai;
        }
        public int InsertHoaDonBan()
        {
            int i = 0;
            string[] paras = new string[7] { "@MaHoaDon", "@MaNV", "@MaBan", "@TenKhachHang", "@NgayLap", "@DienGiai", "@SoTien" };
            object[] values = new object[7] { MaHoaDon, MaNV, MaBan,TenKhachHang, NgayLap, DienGiai, SoTien };
            i = Models.connection.Excute_Sql("sp_themhoadonban", CommandType.StoredProcedure, paras, values);
            return i;
        }
        public int UpdateHoaDonBan()
        {
            int i = 0;
            string[] paras = new string[7] { "@MaHoaDon", "@MaNV", "@MaBan", "@TenKhachHang", "@NgayLap", "@DienGiai", "@SoTien" };
            object[] values = new object[7] { MaHoaDon, MaNV, MaBan, TenKhachHang, NgayLap, DienGiai, SoTien };
            i = Models.connection.Excute_Sql("sp_suahoadonban", CommandType.StoredProcedure, paras, values);
            return i;
        }
        public int DeleteHoaDonBan()
        {
            int i = 0;
            string[] paras = new string[1] { "@MaHoaDon" };
            object[] values = new object[1] { MaHoaDon };
            i = Models.connection.Excute_Sql("sp_xoahoadonban", CommandType.StoredProcedure, paras, values);
            return i;
        }
        public static DataSet FillDataSetHoaDonBan()
        {
            return Models.connection.FillDataSet("sp_getHoaDonBan", CommandType.StoredProcedure);
        }
        public DataSet FillDataSet_getHoaDonBanbyID()
        {
            DataSet ds = new DataSet();
            string[] paras = new string[1] { "@MaHoaDon" };
            object[] values = new object[1] { MaHoaDon };
            ds = Models.connection.FillDataSet("sp_getHoaDonBanbyID", CommandType.StoredProcedure, paras, values);
            return ds;
        }
    }
}
