using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace QuanLyCuaHangPho.Controllers
{
    class ThucDonCtrl
    {
        public static DataSet FillDataSet_getThucDonbyID(string _MaThucDon)
        {
            try
            {
                Models.ThucDonMod _tdon = new Models.ThucDonMod(_MaThucDon);
                return _tdon.FillDataSet_getThucDonbyID();
            }
            catch
            {
                return null;
            }
        }
        public static DataSet FillDataSet_SearchThucDonbyID(string _MaNV)
        {
            try
            {
                Models.ThucDonMod _tdon = new Models.ThucDonMod(_MaNV);
                return _tdon.FillDataSet_SearchThucDonbyID();
            }
            catch
            {
                return null;
            }
        }
        public static DataSet FillDataSet_SearchThucDonbyTen(string _TenNV)
        {
            try
            {
                Models.ThucDonMod _tdon = new Models.ThucDonMod(_TenNV);
                return _tdon.FillDataSet_SearchThucDonbyTen();
            }
            catch
            {
                return null;
            }
        }
        public static int InsertThucDon(string _MaThucDon, string _MaLoaiThucDon, string _TenThucDon, string _DonViTinh, float _DonGia, string _TrangThai)
        {
            try
            {
                Models.ThucDonMod _tdon = new Models.ThucDonMod( _MaThucDon,  _MaLoaiThucDon,  _TenThucDon, _DonViTinh, _DonGia, _TrangThai);
                return _tdon.InsertThucDon();
            }
            catch
            {
                return 0;
            }
        }

        public static int UpdateThucDon(string _MaThucDon, string _MaLoaiThucDon, string _TenThucDon, string _DonViTinh, float _DonGia, string _TrangThai)
        {
            try
            {
                Models.ThucDonMod _tdon = new Models.ThucDonMod( _MaThucDon, _MaLoaiThucDon, _TenThucDon, _DonViTinh, _DonGia,_TrangThai);
                return _tdon.UpdateThucDon();
            }
            catch
            {
                return 0;
            }
        }
        public static int DeleteThucDon(string _MaNV)
        {
            try
            {
                Models.ThucDonMod _tdon = new Models.ThucDonMod(_MaNV);
                return _tdon.DeleteThucDon();
            }
            catch
            {
                return 0;
            }
        }
    }
}
