using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using QuanLyCuaHangPho.Controllers;

namespace QuanLyCuaHangPho.Views
{
    public partial class FormLogin : DevComponents.DotNetBar.RibbonForm
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private Int32 Kiemtra_ID(string u, string p)
        {
            Int32 i = LoginCtrl.Login(u, p);
            return i;
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Int32 r = Kiemtra_ID(txtUserName.Text, txtPassword.Text);
            if (r == -1)
            {
                lblInFo.Text = "Sai thông tin tài khoản !";
            }
            if (r == -2)
            {
                lblInFo.Text = "Sai thông tin mật khẩu !";
            }
            if (r == 1)
            {
                if (MessageBox.Show("Đăng nhập thành công", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.Hide();
                    frmMain frm = new frmMain();
                    frm.Show();
                }
                else
                {
                    this.Close();
                }
            }
        }
    }
}