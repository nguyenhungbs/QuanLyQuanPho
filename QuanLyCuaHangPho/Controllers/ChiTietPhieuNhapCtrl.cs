using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace QuanLyCuaHangPho.Controllers
{
    class ChiTietPhieuNhapCtrl
    {
        public static DataSet FillDataSet_getChiTietPhieuNhapbyID(string _MaPN, string _MaNguyenLieu)
        {
            try
            {
                Models.ChiTietPhieuNhapMod _chitietphieunhap = new Models.ChiTietPhieuNhapMod(_MaPN,_MaNguyenLieu);
                return _chitietphieunhap.FillDataSet_getChiTietPhieuNhapbyID();
            }
            catch
            {
                return null;
            }
        }
        public static int InsertChiTietPhieuNhap(string _MaPN, string _MaNguyenLieu, string _TenNguyenLieu, int _SoLuong, decimal _DonGia, decimal _ThanhTien)
        {
            try
            {
                Models.ChiTietPhieuNhapMod _chitietphieunhap = new Models.ChiTietPhieuNhapMod( _MaPN, _MaNguyenLieu, _TenNguyenLieu, _SoLuong,  _DonGia, _ThanhTien);
                return _chitietphieunhap.InsertChiTietPhieuNhap();
            }
            catch
            {
                return 0;
            }
        }

        public static int UpdateChiTietPhieuNhap(string _MaPN, string _MaNguyenLieu, string _TenNguyenLieu, int _SoLuong, decimal _DonGia, decimal _ThanhTien)
        {
            try
            {
                Models.ChiTietPhieuNhapMod _chitietphieunhap = new Models.ChiTietPhieuNhapMod(_MaPN, _MaNguyenLieu, _TenNguyenLieu, _SoLuong, _DonGia, _ThanhTien);
                return _chitietphieunhap.UpdateChiTietPhieuNhap();
            }
            catch
            {
                return 0;
            }
        }
        public static int DeleteChiTietPhieuNhap(string _MaPN,string _MaNguyenLieu,string _TenNguyenLieu, int _SoLuong ,decimal _DonGia)
        {
            try
            {
                Models.ChiTietPhieuNhapMod _chitietphieunhap = new Models.ChiTietPhieuNhapMod(_MaPN, _MaNguyenLieu, _TenNguyenLieu, _SoLuong, _DonGia);
                return _chitietphieunhap.DeleteChiTietPhieuNhap();
            }
            catch
            {
                return 0;
            }
        }
    }
}
