using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace QuanLyCuaHangPho.Models
{
    class ChiTietPhieuNhapMod
    {
        protected string MaPN { get; set; }
        protected string MaNguyenLieu { get; set; }
        protected string TenNguyenLieu { get; set; }
        protected int SoLuong { get; set; }
        protected decimal DonGia { get; set; }
        protected decimal ThanhTien { get; set; }
        public ChiTietPhieuNhapMod(string _MaPN,string _MaNguyenLieu, string _TenNguyenLieu, int _SoLuong, decimal _DonGia)
        {
            MaPN = _MaPN;
            MaNguyenLieu = _MaNguyenLieu;
            TenNguyenLieu = _TenNguyenLieu;
            SoLuong = _SoLuong;
            DonGia = _DonGia;
        }
        public ChiTietPhieuNhapMod(string _MaPN, string _MaNguyenLieu)
        {
            MaPN = _MaPN;
            MaNguyenLieu = _MaNguyenLieu;
            
        }
        public ChiTietPhieuNhapMod() { }
        public ChiTietPhieuNhapMod(string _MaPN, string _MaNguyenLieu, string _TenNguyenLieu, int _SoLuong, decimal _DonGia, decimal _ThanhTien)
        {
            MaPN = _MaPN;
            MaNguyenLieu = _MaNguyenLieu;
            TenNguyenLieu = _TenNguyenLieu;
            SoLuong = _SoLuong;
            DonGia = _DonGia;
            ThanhTien = _ThanhTien;
            
        }
        public int InsertChiTietPhieuNhap()
        {
            int i = 0;
            string[] paras = new string[6] { "@MaPN", "@MaNguyenLieu", "@TenNguyenLieu", "@SoLuong","@DonGia", "@ThanhTien" };
            object[] values = new object[6] { MaPN, MaNguyenLieu, TenNguyenLieu, SoLuong, DonGia, ThanhTien };
            i = Models.connection.Excute_Sql("sp_themchitietphieunhap", CommandType.StoredProcedure, paras, values);
            return i;
        }
        public int UpdateChiTietPhieuNhap()
        {
            int i = 0;
            string[] paras = new string[6] { "@MaPN", "@MaNguyenLieu", "@TenNguyenLieu", "@SoLuong","@DonGia" ,"ThanhTien" };
            object[] values = new object[6] { MaPN, MaNguyenLieu, TenNguyenLieu, SoLuong, DonGia, ThanhTien };
            i = Models.connection.Excute_Sql("sp_suachitietphieunhap", CommandType.StoredProcedure, paras, values);
            return i;
        }
        public int DeleteChiTietPhieuNhap()
        {
            int i = 0;
            string[] paras = new string[5] { "@MaPN","@MaNguyenLieu","@TenNguyenLieu","@SoLuong","@DonGia" };
            object[] values = new object[5] { MaPN,MaNguyenLieu,TenNguyenLieu,SoLuong,DonGia };
            i = Models.connection.Excute_Sql("sp_xoachitietphieunhap", CommandType.StoredProcedure, paras, values);
            return i;
        }
        public static DataSet FillDataSetChiTietPhieuNhap()
        {
            return Models.connection.FillDataSet("sp_getChiTietPhieuNhap", CommandType.StoredProcedure);
        }
        public DataSet FillDataSet_getChiTietPhieuNhapbyID()
        {
            DataSet ds = new DataSet();
            string[] paras = new string[2] { "@MaPN","@MaNguyenLieu" };
            object[] values = new object[2] { MaPN ,MaNguyenLieu};
            ds = Models.connection.FillDataSet("sp_getChiTietPhieuNhapByID", CommandType.StoredProcedure, paras, values);
            return ds;
        }
    }
}
