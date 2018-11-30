using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangPho.Models
{
    public class AccountModel
    {
        protected string _userName { set; get; }
        protected string _password { set; get; }

        public AccountModel() { }

        public AccountModel(string useName, string password)
        {
            this._userName = useName;
            this._password = password;
        }

        public static string Encode(string original)
        {
            var md5 = new MD5CryptoServiceProvider();
            var originalBytes = Encoding.Default.GetBytes(original);
            var encodedBytes = md5.ComputeHash(originalBytes);

            return BitConverter.ToString(encodedBytes);
        }
        public Int32 CheckLogin()
        {
            Int32 i;
            string[] paras = new string[2] { "@u", "@p" };
            object[] values = new object[2] { _userName, Encode(_password) };
            i = Models.connection.Excute_SqlReturn("sp_User_Login", CommandType.StoredProcedure, paras, values);
            return i;
        }
    }
}
