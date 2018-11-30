using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace QuanLyCuaHangPho.Controllers
{
    class BanCtrl
    {
        public static DataSet FillDataSet_getBanbyID(string _idBan)
        {
            try
            {
                Models.BanMod ban = new Models.BanMod(_idBan);
                return ban.FillDataSet_getBanbyID();
            }
            catch
            {
                return null;
            }
        }
        
        public static int InsertBan(string _MaBan, string _TenBan, string _DienGiai, string _TrangThai)
        {
            try
            {
                Models.BanMod _ban = new Models.BanMod(_MaBan, _TenBan, _DienGiai, _TrangThai);
                return _ban.InsertBan();
            }
            catch
            {
                return 0;
            }
        }

        public static int UpdateBan(string _MaBan ,string _TenBan, string _DienGiai, string _TrangThai)
        {
            try
            {
                Models.BanMod _ban = new Models.BanMod(_MaBan, _TenBan, _DienGiai, _TrangThai);
                return _ban.UpdateBan();
            }
            catch
            {
                return 0;
            }
        }
        public static int DeleteBan(string _MaBan)
        {
            try
            {
                Models.BanMod _ban = new Models.BanMod(_MaBan);
                return _ban.DeleteBan();
            }
            catch
            {
                return 0;
            }
        }
    }
}
