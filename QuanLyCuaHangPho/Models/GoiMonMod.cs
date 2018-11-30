using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace QuanLyCuaHangPho.Models
{
    class GoiMonMod
    {
        protected string MaBan { get; set; }
        protected string TenThucDon { get; set; }
        protected decimal DonGia { get; set; }
        protected int SoLuong { get; set; }
        protected decimal ThanhTien { get; set; }
        protected DateTime ThoiGian { get; set; }
        protected string GhiChu { get; set; }
        protected string TrangThai { get; set; }
        public GoiMonMod(string _MaBan)
        {
            MaBan = _MaBan;
        }
        public GoiMonMod() { }
        public GoiMonMod(string _MaBan , string _TenThucDon, decimal _DonGia, int _SoLuong, decimal _ThanhTien, DateTime _ThoiGian, string _GhiChu, string _TrangThai)
        {
            MaBan = _MaBan;
            TenThucDon = _TenThucDon;
            DonGia = _DonGia;
            SoLuong = _SoLuong;
            ThanhTien = _ThanhTien;
            ThoiGian = _ThoiGian;
            GhiChu = _GhiChu;
            TrangThai = _TrangThai;
        }
        public int InsertGoiMon()
        {
            int i = 0;
            string[] paras = new string[8] { "@MaBan", "@TenThucDon", "@DonGia", "@SoLuong", "ThanhTien", "ThoiGian", "GhiChu", "TrangThai" };
            object[] values = new object[8] { MaBan, TenThucDon, DonGia, SoLuong, ThanhTien, ThoiGian, GhiChu, TrangThai };
            i = Models.connection.Excute_Sql("sp_themGoiMon", CommandType.StoredProcedure, paras, values);
            return i;
        }
        public int UpdateGoiMon()
        {
            int i = 0;
            string[] paras = new string[8] { "@MaBan", "@TenThucDon", "@DonGia", "@SoLuong", "ThanhTien", "ThoiGian", "GhiChu", "TrangThai" };
            object[] values = new object[8] { MaBan, TenThucDon, DonGia, SoLuong, ThanhTien, ThoiGian, GhiChu, TrangThai };
            i = Models.connection.Excute_Sql("sp_suaGoiMon", CommandType.StoredProcedure, paras, values);
            return i;
        }
        public int DeleteGoiMon()
        {
            int i = 0;
            string[] paras = new string[1] { "@MaBan" };
            object[] values = new object[1] { MaBan };
            i = Models.connection.Excute_Sql("sp_xoaGoiMon", CommandType.StoredProcedure, paras, values);
            return i;
        }
        public static DataSet FillDataSetGoiMon()
        {
            return Models.connection.FillDataSet("sp_getGoiMon", CommandType.StoredProcedure);
        }
        public static DataSet FillDataSetDanhSachBan_GoiMon()
        {
            return Models.connection.FillDataSet("sp_getDanhSachBan_GoiMon", CommandType.StoredProcedure);
        }
        public static DataSet FillDataSetDanhSachBanChua_GoiMon()
        {
            return Models.connection.FillDataSet("sp_getDanhSachBan_ChuaGoiMon", CommandType.StoredProcedure);
        }
        public DataSet FillDataSet_getGoiMonbyID()
        {
            DataSet ds = new DataSet();
            string[] paras = new string[1] { "@MaBan" };
            object[] values = new object[1] { MaBan };
            ds = Models.connection.FillDataSet("sp_getGoiMonbyID", CommandType.StoredProcedure, paras, values);
            return ds;
        }
        //public static DataSet FillDataSet_SumThanhTien()
        //{
        //    return Models.connection.FillDataSet("sp_getDanhSachBan_ChuaGoiMon", CommandType.StoredProcedure);
        //}
        public static DataSet FillDataSet_getTenThucDon()
        {
            return Models.connection.FillDataSet("sp_getTenThucDon", CommandType.StoredProcedure);
        }
        public static DataSet FillDataSet_getIdBan()
        {
            return Models.connection.FillDataSet("sp_getBan", CommandType.StoredProcedure);
        }
        public static DataSet FillDataSet_getDonGiaThucDon()
        {
            DataSet ds = new DataSet();
            try
            {
                ds= Models.connection.FillDataSet("sp_getThucDon", CommandType.StoredProcedure);
            }
            catch
            {}
            return ds;
        }

    }
}
