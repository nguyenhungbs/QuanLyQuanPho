using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangPho
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        internal static List<byte> typePages = new List <byte>();
        public void ThemTabPage(UserControl uct/*byte typeControl*/, string tenTab)
        {
            //Kiem tra ton tai trang nay chua
            for (int i = 0; i < TabHienThi.TabPages.Count; i++)
            {
                if(TabHienThi.TabPages[i].Contains(uct) == true)
                {
                    TabHienThi.SelectedTab = TabHienThi.TabPages[i];
                    return;
                }
            }   
            TabPage tab = new TabPage();
            //typePages.Add(typeControl);
            tab.Name = uct.Name;
            tab.Size = TabHienThi.Size;
            tab.Text = tenTab;
            TabHienThi.TabPages.Add(tab);
            TabHienThi.SelectedTab = tab;
            uct.Dock = DockStyle.Fill;
            tab.Controls.Add(uct);
            uct.Focus();
            

        }
        public void DongTabHienTai()
        {
            TabHienThi.TabPages.Remove(TabHienThi.SelectedTab);
        }
        public void DongAllTab()
        {
            while (TabHienThi.TabPages.Count > 0)
            {
                DongTabHienTai();
            }
        }
        private void hệThoognsKhuVựcToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
            else
                return;
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemTabPage(Views.uctNhanVien.uctNV, "Quản lý nhân viên");
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void đóngTrangHiệnTạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DongTabHienTai();
        }

        private void đóngTấtCảTrangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DongAllTab();
        }

        private void TabHienThi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ctxtmenuTabHienThi_Opening(object sender, CancelEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void bànToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemTabPage(Views.uctBan.uctB, "Danh sách bàn");
        }

        private void loạiThựcĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemTabPage(Views.uctLoaiThucDon.uctloaitd,"Danh sách loại thực đơn");
        }

        private void thựcĐơnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ThemTabPage(Views.uctThucDon.uctTD ,"Danh sách thực đơn");
        }

        private void gọiMónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemTabPage(Views.uctGoiMon.uctGM, "Gọi món");
        }

        private void quảnLýNhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemTabPage(Views.uctNhaCungCap.uctNCC, "Thông tin nhà cung cấp");
        }

        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void hóaĐơnNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemTabPage(Views.uctHoaDonNhap.uctHDN, "Hóa đơn nhập");
        }

        private void thốngKêDoanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemTabPage(Views.uctThongKeDoanhThu.uctThongKe, "Thống kê");
        }

        private void hóaĐơnBánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemTabPage(Views.uctHoaDonBan.uctHDB, "Hóa đơn bán");
        }

        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemTabPage(Views.uctThongTin.uctTT, "Thông tin");
        }

        private void hướngĐẫnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemTabPage(Views.uctHuongDan.uctHDan, "Hướng dẫn");
        }
    }
}
