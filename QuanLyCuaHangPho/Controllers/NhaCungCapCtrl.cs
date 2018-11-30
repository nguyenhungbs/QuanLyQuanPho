using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyCuaHangPho.Controllers
{
    class NhaCungCapCtrl
    {
        public static DataSet FillDataSet_getNhaCungCapbyID(string _MaNCC)
        {
            try
            {
                Models.NhaCungCapMod _nhacc = new Models.NhaCungCapMod(_MaNCC);
                return _nhacc.FillDataSet_getNhaCungCapbyID();
            }
            catch
            {
                return null;
            }
        }
        public static DataSet FillDataSet_SearchNhaCungCapbyID(string _MaNCC)
        {
            try
            {
                Models.NhaCungCapMod _nhacc = new Models.NhaCungCapMod(_MaNCC);
                return _nhacc.FillDataSet_SearchNhaCungCapbyID();
            }
            catch
            {
                return null;
            }
        }
        public static DataSet FillDataSet_SearchNhaCungCapbyTen(string _TenNCC)
        {
            try
            {
                Models.NhaCungCapMod _nhacc = new Models.NhaCungCapMod(_TenNCC);
                return _nhacc.FillDataSet_SearchNhaCungCapbyTen();
            }
            catch
            {
                return null;
            }
        }
        public static int InsertNhaCungCap(string _MaNCC, string _TenNCC, string _DiaChi, string _SDT, string _Email)
        {
            try
            {
                Models.NhaCungCapMod _nhacc = new Models.NhaCungCapMod( _MaNCC, _TenNCC, _DiaChi, _SDT, _Email);
                return _nhacc.InsertNhaCungCap();
            }
            catch
            {
                return 0;
            }
        }

        public static int UpdateNhaCungCap(string _MaNCC, string _TenNCC, string _DiaChi, string _SDT, string _Email)
        {
            try
            {
                Models.NhaCungCapMod _nhacc = new Models.NhaCungCapMod( _MaNCC, _TenNCC, _DiaChi, _SDT, _Email);
                return _nhacc.UpdateNhaCungCap();
            }
            catch
            {
                return 0;
            }
        }
        public static int DeleteNhaCungCap(string _MaNCC)
        {
            try
            {
                Models.NhaCungCapMod _nhacc = new Models.NhaCungCapMod(_MaNCC);
                return _nhacc.DeleteNhaCungCap();
            }
            catch
            {
                return 0;
            }
        }
    }
}
