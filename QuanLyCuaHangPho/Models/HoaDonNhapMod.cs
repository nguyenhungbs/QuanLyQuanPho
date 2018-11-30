using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace QuanLyCuaHangPho.Models
{
    class HoaDonNhapMod
    {
        protected string MaPN { get;set;}
        protected string MaNCC { get; set; }
        protected DateTime NgayNhap { get; set; }
        protected decimal TongTienNhap { get; set; }
        public HoaDonNhapMod(string _MaPN)
        {
            MaPN = _MaPN;
        }
        public HoaDonNhapMod() { }
        public HoaDonNhapMod(string _MaPN, string _MaNCC, DateTime _NgayNhap, decimal _TongTienNhap)
        {
            MaPN = _MaPN;
            MaNCC = _MaNCC;
            NgayNhap = _NgayNhap;
            TongTienNhap = _TongTienNhap;
        }
        public int InsertHoaDonNhap()
        {
            int i = 0;
            string[] paras = new string[4] { "@MaPN", "@MaNCC", "@NgayNhap", "@TongTienNhap" };
            object[] values = new object[4] { MaPN, MaNCC, NgayNhap, TongTienNhap };
            i = Models.connection.Excute_Sql("sp_themphieunhap", CommandType.StoredProcedure, paras, values);
            return i;
        }
        public int UpdateHoaDonNhap()
        {
            int i = 0;
            string[] paras = new string[4] { "@MaPN", "@MaNCC", "@NgayNhap", "@TongTienNhap" };
            object[] values = new object[4] { MaPN, MaNCC, NgayNhap, TongTienNhap };
            i = Models.connection.Excute_Sql("sp_suaphieunhap", CommandType.StoredProcedure, paras, values);
            return i;
        }
        public int DeleteHoaDonNhap()
        {
            int i = 0;
            string[] paras = new string[1] { "@MaPN" };
            object[] values = new object[1] { MaPN };
            i = Models.connection.Excute_Sql("sp_xoaphieunhap", CommandType.StoredProcedure, paras, values);
            return i;
        }
        public static DataSet FillDataSetHoaDonNhap()
        {
            return Models.connection.FillDataSet("sp_getPhieuNhap", CommandType.StoredProcedure);
        }
        public DataSet FillDataSet_getHoaDonNhapbyID()
        {
            DataSet ds = new DataSet();
            string[] paras = new string[1] { "@MaPN" };
            object[] values = new object[1] { MaPN };
            ds = Models.connection.FillDataSet("sp_getHoaDonNhapbyID", CommandType.StoredProcedure, paras, values);
            return ds;
        }
    }
}
