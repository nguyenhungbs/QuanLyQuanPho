using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace QuanLyCuaHangPho.Models
{
    class ThucDonMod
    {
        protected string MaThucDon { get; set; }
        protected string MaLoaiThucDon { get; set; }
        protected string TenThucDon { get; set; }
        protected string DonViTinh { get; set; }
        protected float DonGia { get; set; }
        protected string TrangThai { get; set; }
        public ThucDonMod(string _MaThucDon)
        {
            MaThucDon = _MaThucDon;
        }
        public ThucDonMod() { }
        public ThucDonMod(string _MaThucDon, string _MaLoaiThucDon, string _TenThucDon, string _DonViTinh, float _DonGia, string _TrangThai)
        {
            MaThucDon = _MaThucDon;
            MaLoaiThucDon = _MaLoaiThucDon;
            TenThucDon = _TenThucDon;
            DonViTinh = _DonViTinh;
            DonGia = _DonGia;
            TrangThai = _TrangThai;
        }
        public int InsertThucDon()
        {
            int i = 0;
            string[] paras = new string[6] { "@MaThucDon", "@MaLoaiThucDon", "@TenThucDon", "@DonViTinh", "@DonGia", "@TrangThai" };
            object[] values = new object[6] { MaThucDon, MaLoaiThucDon, TenThucDon, DonViTinh, DonGia, TrangThai };
            i = Models.connection.Excute_Sql("sp_themthucdon", CommandType.StoredProcedure, paras, values);
            return i;
        }
        public int UpdateThucDon()
        {
            int i = 0;
            string[] paras = new string[6] { "@MaThucDon", "@MaLoaiThucDon", "@TenThucDon", "@DonViTinh", "@DonGia", "@TrangThai" };
            object[] values = new object[6] { MaThucDon, MaLoaiThucDon, TenThucDon, DonViTinh, DonGia, TrangThai };
            i = Models.connection.Excute_Sql("sp_suathucdon", CommandType.StoredProcedure, paras, values);
            return i;
        }
        public int DeleteThucDon()
        {
            int i = 0;
            string[] paras = new string[1] { "@MaThucDon" };
            object[] values = new object[1] { MaThucDon };
            i = Models.connection.Excute_Sql("sp_xoathucdon", CommandType.StoredProcedure, paras, values);
            return i;
        }
        public static DataSet FillDataSetThucDon()
        {
            return Models.connection.FillDataSet("sp_getThucDon", CommandType.StoredProcedure);
        }
        public DataSet FillDataSet_getThucDonbyID()
        {
            DataSet ds = new DataSet();
            string[] paras = new string[1] { "@MaThucDon" };
            object[] values = new object[1] { MaThucDon };
            ds = Models.connection.FillDataSet("sp_getThucDonbyID", CommandType.StoredProcedure, paras, values);
            return ds;
        }
        public DataSet FillDataSet_SearchThucDonbyID()
        {
            DataSet ds = new DataSet();
            string[] paras = new string[1] { "@MaThucDon" };
            object[] values = new object[1] { MaThucDon };
            ds = Models.connection.FillDataSet("sp_SearchThucDonByID", CommandType.StoredProcedure, paras, values);
            return ds;
        }
        public DataSet FillDataSet_SearchThucDonbyTen()
        {
            DataSet ds = new DataSet();
            string[] paras = new string[1] { "@TenThucDon" };
            object[] values = new object[1] { MaThucDon };
            ds = Models.connection.FillDataSet("sp_SearchThucDonByTen", CommandType.StoredProcedure, paras, values);
            return ds;
        }
    }
}
