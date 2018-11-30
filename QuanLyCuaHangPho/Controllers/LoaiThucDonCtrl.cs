using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace QuanLyCuaHangPho.Controllers
{
    class LoaiThucDonCtrl
    {
        public static DataSet FillDataSet_getLoaiThucDonbyID(string _MaNV)
        {
            try
            {
                Models.LoaiThucDonMod _loaitd = new Models.LoaiThucDonMod(_MaNV);
                return _loaitd.FillDataSet_getLoaiThucDonbyID();
            }
            catch
            {
                return null;
            }
        }
        
        public static int InsertLoaiThucDon(string _MaLoaiThucDon, string _TenLoaiThucDon, string _DienGiai, string _TrangThai)
        {
            try
            {
                Models.LoaiThucDonMod _loaitd = new Models.LoaiThucDonMod(_MaLoaiThucDon,_TenLoaiThucDon,_DienGiai,_TrangThai);
                return _loaitd.InsertLoaiThucDon();
            }
            catch
            {
                return 0;
            }
        }

        public static int UpdateLoaiThucDon(string _MaLoaiThucDon, string _TenLoaiThucDon, string _DienGiai, string _TrangThai)
        {
            try
            {
                Models.LoaiThucDonMod _loaitd = new Models.LoaiThucDonMod(_MaLoaiThucDon,_TenLoaiThucDon,_DienGiai,_TrangThai);
                return _loaitd.UpdateLoaiThucDon();
            }
            catch
            {
                return 0;
            }
        }
        public static int DeleteLoaiThucDon(string _MaNV)
        {
            try
            {
                Models.LoaiThucDonMod _loaitd = new Models.LoaiThucDonMod(_MaNV);
                return _loaitd.DeleteLoaiThucDon();
            }
            catch
            {
                return 0;
            }
        }
    }
}
