using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace QuanLyCuaHangPho.Models
{
    class NhaCungCapMod
    {
        protected string MaNCC { get; set; }
        protected string TenNCC { get; set; }
        protected string DiaChi { get; set; }
        protected string SDT { get; set; }      
        protected string Email { get; set; }
        public NhaCungCapMod(String _MaNCC) {
            MaNCC = _MaNCC;
        }
        public NhaCungCapMod(string _MaNCC, string _TenNCC, string _DiaChi, string _SDT, string _Email)
        {
            MaNCC = _MaNCC;
            TenNCC = _TenNCC;
            DiaChi = _DiaChi;
            SDT = _SDT;
            Email = _Email;
        }
        public int InsertNhaCungCap()
        {
            int i = 0;
            string[] paras = new string[5] { "@MaNCC", "@TenNCC", "@DiaChi", "@SDT", "@Email" };
            object[] values = new object[5] { MaNCC, TenNCC, DiaChi, SDT, Email };
            i = Models.connection.Excute_Sql("sp_themnhacc", CommandType.StoredProcedure, paras, values);
            return i;
        }
        public int UpdateNhaCungCap()
        {
            int i = 0;
            string[] paras = new string[5] { "@MaNCC", "@TenNCC", "@DiaChi", "@SDT", "@Email" };
            object[] values = new object[5] { MaNCC, TenNCC, DiaChi, SDT, Email };
            i = Models.connection.Excute_Sql("sp_suanhacc", CommandType.StoredProcedure, paras, values);
            return i;
        }
        public int DeleteNhaCungCap()
        {
            int i = 0;
            string[] paras = new string[1] { "@MaNCC" };
            object[] values = new object[1] { MaNCC };
            i = Models.connection.Excute_Sql("sp_xoanhacc", CommandType.StoredProcedure, paras, values);
            return i;
        }
        public static DataSet FillDataSetNhaCungCap()
        {
            return Models.connection.FillDataSet("sp_getNhaCC", CommandType.StoredProcedure);
        }
        public DataSet FillDataSet_getNhaCungCapbyID()
        {
            DataSet ds = new DataSet();
            string[] paras = new string[1] { "@MaNCC" };
            object[] values = new object[1] { MaNCC };
            ds = Models.connection.FillDataSet("sp_getNhaCCbyID", CommandType.StoredProcedure, paras, values);
            return ds;
        }
        public DataSet FillDataSet_SearchNhaCungCapbyID()
        {
            DataSet ds = new DataSet();
            string[] paras = new string[1] { "@MaNCC" };
            object[] values = new object[1] { MaNCC };
            ds = Models.connection.FillDataSet("sp_SearchNhaCCByID", CommandType.StoredProcedure, paras, values);
            return ds;
        }
        public DataSet FillDataSet_SearchNhaCungCapbyTen()
        {
            DataSet ds = new DataSet();
            string[] paras = new string[1] { "@TenNCC" };
            object[] values = new object[1] { MaNCC };
            ds = Models.connection.FillDataSet("sp_SearchNhaCCByTen", CommandType.StoredProcedure, paras, values);
            return ds;
        }
    }
}
