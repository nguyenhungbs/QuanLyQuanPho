using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangPho.Controllers
{
    public class LoginCtrl
    {
        public static Int32 Login(string userName, string password)
        {
            Models.AccountModel loginTest = new Models.AccountModel(userName, password);
            return loginTest.CheckLogin();

        }
    }
}
