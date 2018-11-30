using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyCuaHangPho.Models
{
    class NhanVienMod
    {
        protected string MaNV {get;set;}
        protected string Hoten {get;set;}
        protected DateTime Ngaysinh{get;set;}
        protected string Gioitinh {get;set;}
        protected string SDT {get;set;}
        protected string Diachi {get;set;}
           
        public NhanVienMod(string _MaNV)
        {
            MaNV = _MaNV;
        }
        public NhanVienMod(){}
        public NhanVienMod(string _MaNV,string _Hoten, DateTime _Ngaysinh, string _Gioitinh, string _SDT, string _Diachi)
        {
            MaNV = _MaNV;
            Hoten = _Hoten;
            Ngaysinh = _Ngaysinh;
            Gioitinh = _Gioitinh;
            SDT = _SDT;
            Diachi = _Diachi;
        }
        public int InsertNhanVien()
        {
            int i = 0;
            string[] paras = new string[6] { "@MaNV", "@Hoten", "@Ngaysinh", "@Gioitinh", "@SDT", "@Diachi" };
            object[] values = new object[6] { MaNV, Hoten, Ngaysinh, Gioitinh, SDT, Diachi };
            i = Models.connection.Excute_Sql("sp_themnhanvien", CommandType.StoredProcedure, paras, values);
            return i;
        }
        public int UpdateNhanVien()
        {
            int i = 0;
            string[] paras = new string[6] { "@MaNV", "@Hoten", "@Ngaysinh", "@Gioitinh", "@SDT", "@Diachi" };
            object[] values = new object[6] { MaNV, Hoten, Ngaysinh, Gioitinh, SDT, Diachi };
            i = Models.connection.Excute_Sql("sp_suanhanvien", CommandType.StoredProcedure, paras, values);
            return i;
        }
        public int DeleteNhanVien()
        {
            int i = 0;
            string[] paras = new string[1] { "@MaNV" };
            object[] values = new object[1] { MaNV };
            i = Models.connection.Excute_Sql("sp_xoanhanvien", CommandType.StoredProcedure, paras, values);
            return i;
        }
        public static DataSet FillDataSetNhanVien()
        {
            return Models.connection.FillDataSet("sp_getNhanVien", CommandType.StoredProcedure);
        }
        public DataSet FillDataSet_getNhanVienbyID()
        {
            DataSet ds = new DataSet();
            string[] paras = new string[1] { "@MaNV" };
            object[] values = new object[1] { MaNV };
            ds = Models.connection.FillDataSet("sp_getNhanVienbyID", CommandType.StoredProcedure, paras, values);
            return ds;          
        }
        public DataSet FillDataSet_SearchNhanVienbyID()
        {
            DataSet ds = new DataSet();
            string[] paras = new string[1] { "@MaNV" }; 
            object[] values = new object[1] { MaNV };
            ds = Models.connection.FillDataSet("sp_SearchNhanVienByID", CommandType.StoredProcedure, paras, values);
            return ds;
        }
        public DataSet FillDataSet_SearchNhanVienbyTen()
        {
            DataSet ds = new DataSet();
            string[] paras = new string[1] { "@Hoten" };
            object[] values = new object[1] { MaNV };
            ds = Models.connection.FillDataSet("sp_SearchNhanVienByTen", CommandType.StoredProcedure, paras, values);
            return ds;
        }
    }
    
}
