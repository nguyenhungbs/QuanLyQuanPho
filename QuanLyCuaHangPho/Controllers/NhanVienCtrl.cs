using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace QuanLyCuaHangPho.Controllers
{
    class NhanVienCtrl
    {
        public static DataSet FillDataSet_getNhanVienbyID(string _MaNV)
        {
            try
            {
                Models.NhanVienMod nvien = new Models.NhanVienMod(_MaNV);
                return nvien.FillDataSet_getNhanVienbyID();
            }
            catch
            {
                return null;
            }
        }       
        public static DataSet FillDataSet_SearchNhanVienbyID(string _MaNV)
        {
            try
            {
                Models.NhanVienMod nvien = new Models.NhanVienMod(_MaNV);
                return nvien.FillDataSet_SearchNhanVienbyID();
            }
            catch
            {
                return null;
            }
        }
        public static DataSet FillDataSet_SearchNhanVienbyTen(string _TenNV)
        {
            try
            {
                Models.NhanVienMod nvien = new Models.NhanVienMod(_TenNV);
                return nvien.FillDataSet_SearchNhanVienbyTen();
            }
            catch
            {
                return null;
            }
        }
        public static int InsertNhanVien(string _MaNV,string _Hoten, DateTime _Ngaysinh, string _Gioitinh, string _SDT, string _Diachi)
        {
            try
            {
                Models.NhanVienMod _nhanvien = new Models.NhanVienMod(_MaNV, _Hoten, _Ngaysinh, _Gioitinh, _SDT, _Diachi);
                return _nhanvien.InsertNhanVien();
            }
            catch
            {
                return 0;
            }
        }

        public static int UpdateNhanVien(string _MaNV, string _Hoten, DateTime _Ngaysinh, string _Gioitinh, string _SDT, string _Diachi)
        {
            try
            {
                Models.NhanVienMod _nhanvien = new Models.NhanVienMod(_MaNV, _Hoten, _Ngaysinh, _Gioitinh, _SDT, _Diachi);
                return _nhanvien.UpdateNhanVien();
            }
            catch
            {
                return 0;
            }
        }
        public static int DeleteNhanVien(string _MaNV)
        {
            try
            {
                Models.NhanVienMod _nhanVien = new Models.NhanVienMod(_MaNV);
                return _nhanVien.DeleteNhanVien();
            }
            catch
            {
                return 0;
            }
        }
    }
}
