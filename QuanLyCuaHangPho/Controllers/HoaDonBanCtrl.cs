using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace QuanLyCuaHangPho.Controllers
{
    class HoaDonBanCtrl
    {
        public static DataSet FillDataSet_getHoaDonBanbyID(string _MaHoaDon)
        {
            try
            {
                Models.HoaDonBanMod _hoadonB = new Models.HoaDonBanMod(_MaHoaDon);
                return _hoadonB.FillDataSet_getHoaDonBanbyID();
            }
            catch
            {
                return null;
            }
        }
        
        public static int InsertHoaDonBan(string _MaHoaDon, string _MaNV, string _MaBan, string _TenKhachHang, DateTime _NgayLap, string _DienGiai, decimal _SoTien)
        {
            try
            {
                Models.HoaDonBanMod _hoadonB = new Models.HoaDonBanMod( _MaHoaDon, _MaNV,  _MaBan, _TenKhachHang,  _NgayLap,  _DienGiai,  _SoTien);
                return _hoadonB.InsertHoaDonBan();
            }
            catch
            {
                return 0;
            }
        }

        public static int UpdateHoaDonBan(string _MaHoaDon, string _MaNV, string _MaBan, string _TenKhachHang, DateTime _NgayLap, string _DienGiai, decimal _SoTien)
        {
            try
            {
                Models.HoaDonBanMod _hoadonB = new Models.HoaDonBanMod(_MaHoaDon,  _MaNV, _MaBan, _TenKhachHang, _NgayLap, _DienGiai, _SoTien);
                return _hoadonB.UpdateHoaDonBan();
            }
            catch
            {
                return 0;
            }
        }
        public static int DeleteHoaDonBan(string _MaHoaDon)
        {
            try
            {
                Models.HoaDonBanMod _hoadonB = new Models.HoaDonBanMod(_MaHoaDon);
                return _hoadonB.DeleteHoaDonBan();
            }
            catch
            {
                return 0;
            }
        }
    }
}
