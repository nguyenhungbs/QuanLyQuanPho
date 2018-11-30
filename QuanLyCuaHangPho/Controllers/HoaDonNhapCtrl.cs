using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace QuanLyCuaHangPho.Controllers
{
    class HoaDonNhapCtrl
    {
        public static DataSet FillDataSet_getHoaDonNhapbyID(string _idHoaDonNhap)
        {
            try
            {
                Models.HoaDonNhapMod _hoadonnhap = new Models.HoaDonNhapMod(_idHoaDonNhap);
                return _hoadonnhap.FillDataSet_getHoaDonNhapbyID();
            }
            catch
            {
                return null;
            }
        }

        public static int InsertHoaDonNhap(string _MaPN, string _MaNCC, DateTime _NgayNhap, decimal _TongTienNhap)
        {
            try
            {
                Models.HoaDonNhapMod _hoadonnhap = new Models.HoaDonNhapMod( _MaPN, _MaNCC, _NgayNhap, _TongTienNhap);
                return _hoadonnhap.InsertHoaDonNhap();
            }
            catch
            {
                return 0;
            }
        }

        public static int UpdateHoaDonNhap(string _MaPN, string _MaNCC, DateTime _NgayNhap, decimal _TongTienNhap)
        {
            try
            {
                Models.HoaDonNhapMod _hoadonnhap = new Models.HoaDonNhapMod(_MaPN, _MaNCC, _NgayNhap, _TongTienNhap);
                return _hoadonnhap.UpdateHoaDonNhap();
            }
            catch
            {
                return 0;
            }
        }
        public static int DeleteHoaDonNhap(string _MaPN)
        {
            try
            {
                Models.HoaDonNhapMod _hoadonnhap = new Models.HoaDonNhapMod(_MaPN);
                return _hoadonnhap.DeleteHoaDonNhap();
            }
            catch
            {
                return 0;
            }
        }
    }
}
