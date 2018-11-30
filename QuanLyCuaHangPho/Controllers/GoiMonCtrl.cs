using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace QuanLyCuaHangPho.Controllers
{
    class GoiMonCtrl
    {
        public static DataSet FillDataSet_getGoiMonbyID(string _MaBan)
        {
            try
            {
                Models.GoiMonMod _goimon = new Models.GoiMonMod(_MaBan);
                return _goimon.FillDataSet_getGoiMonbyID();
            }
            catch
            {
                return null;
            }
        }
        public static int InsertGoiMon(string _MaBan, string _TenThucDon, decimal _DonGia, int _SoLuong, decimal _ThanhTien, DateTime _ThoiGian, string _GhiChu, string _TrangThai)
        {
            try
            {
                Models.GoiMonMod _goimon = new Models.GoiMonMod(_MaBan, _TenThucDon, _DonGia, _SoLuong, _ThanhTien, _ThoiGian, _GhiChu, _TrangThai);
                return _goimon.InsertGoiMon();
            }
            catch
            {
                return 0;
            }
        }

        public static int UpdateGoiMon(string _MaBan, string _TenThucDon, decimal _DonGia, int _SoLuong, decimal _ThanhTien, DateTime _ThoiGian, string _GhiChu, string _TrangThai)
        {
            try
            {
                Models.GoiMonMod _goimon = new Models.GoiMonMod(_MaBan, _TenThucDon, _DonGia, _SoLuong, _ThanhTien, _ThoiGian, _GhiChu, _TrangThai);
                return _goimon.UpdateGoiMon();
            }
            catch
            {
                return 0;
            }
        }
        public static int DeleteGoiMon(string _MaBan)
        {
            try
            {
                Models.GoiMonMod _goimon = new Models.GoiMonMod(_MaBan);
                return _goimon.DeleteGoiMon();
            }
            catch
            {
                return 0;
            }
        }
    }
}
