using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangPho.Views
{
    public partial class uctHoaDonBan : UserControl
    {
        public uctHoaDonBan()
        {
            InitializeComponent();
        }
        int flag = 0;
        public static uctHoaDonBan uctHDB = new uctHoaDonBan();
        public void HienThiHDB()
        {
            dgvDanhSachHDB.DataSource = Models.HoaDonBanMod.FillDataSetHoaDonBan().Tables[0];
            dgvDanhSachHDB.Dock = DockStyle.Fill;
            dgvDanhSachHDB.BorderStyle = BorderStyle.Fixed3D;
        }
        public void binding()
        {
            txthoadonban.DataBindings.Clear();
            txthoadonban.DataBindings.Add("Text", dgvDanhSachHDB.DataSource, "MaHoaDon");
            txtTenKH.DataBindings.Clear();
            txtTenKH.DataBindings.Add("Text", dgvDanhSachHDB.DataSource, "TenKhachHang");
            cmbmanv.DataBindings.Clear();
            cmbmanv.DataBindings.Add("Text", dgvDanhSachHDB.DataSource, "MaNV");
            cmbmaban.DataBindings.Clear();
            cmbmaban.DataBindings.Add("Text", dgvDanhSachHDB.DataSource, "MaBan");
            dtpngaylap.DataBindings.Clear();
            dtpngaylap.DataBindings.Add("Text", dgvDanhSachHDB.DataSource, "NgayLap");
            txtdiengiai.DataBindings.Clear();
            txtdiengiai.DataBindings.Add("Text", dgvDanhSachHDB.DataSource, "DienGiai");
            txtsotien.DataBindings.Clear();
            txtsotien.DataBindings.Add("Text", dgvDanhSachHDB.DataSource, "SoTien");
        }
        //Hàm dis end các button khi load lên
        public void dis_end(bool e)
        {
            cmbmaban.Enabled = e;
            txtTenKH.Enabled = e;
            cmbmanv.Enabled = e;
            dtpngaylap.Enabled = e;
            txtsotien.Enabled = e;
            txtdiengiai.Enabled = e;
            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
            btnThem.Enabled = !e;
            btnSua.Enabled = !e;
            btnXoa.Enabled = !e;
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        public void loadcontrol()
        {
            cmbmaban.DataSource = Models.BanMod.FillDataSetBan().Tables[0];
            cmbmaban.DisplayMember = "MaBan";          
            cmbmanv.DataSource = Models.NhanVienMod.FillDataSetNhanVien().Tables[0];
            cmbmanv.DisplayMember = "MaNV";
        }
        public void clearData()
        {
            txthoadonban.Text = "";
            txtdiengiai.Text = "";
            txtsotien.Text = "";
            cmbmaban.Text = "";
            cmbmanv.Text = "";
            txtTenKH.Text = "";
            loadcontrol();
        }
        public void label()
        {
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            label5.BackColor = Color.Transparent;
            label6.BackColor = Color.Transparent;
            label7.BackColor = Color.Transparent;
            
        }
        private void uctHoaDonBan_Load(object sender, EventArgs e)
        {
            HienThiHDB();
            dis_end(false);
            binding();
            label();
        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            flag = 0;
            clearData();
            dis_end(true);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string _MaHoaDon = "";
            try
            {
                _MaHoaDon = txthoadonban.Text;
            }
            catch { }
            string _TenKhachHang = "";
            try
            {
                _TenKhachHang = txtTenKH.Text;
            }
            catch { }
            string _MaNV = "";
            try
            {
                _MaNV =cmbmanv.Text;
            }
            catch { }
            string _MaBan = "";
            try
            {
                _MaBan = cmbmaban.Text;
            }
            catch { }
            DateTime _NgayLap = DateTime.Now;
            try { }
            catch { }
            string _DienGiai = "";
            try
            {
                _DienGiai = txtdiengiai.Text;
            }
            catch { }
            decimal _SoTien = 0;
            try
            {
                _SoTien = Convert.ToInt32(txtsotien.Text);
            }
            catch { }
            if (flag == 0)
            {
                //thêm mới
                if (_MaHoaDon == "" || _MaBan=="")
                    MessageBox.Show("Hãy nhập đầy đủ thông tin");
                else
                {
                    int i = 0;
                    i = Controllers.HoaDonBanCtrl.InsertHoaDonBan(_MaHoaDon,_MaNV,_MaBan, _TenKhachHang,_NgayLap,_DienGiai,_SoTien);
                    if (i > 0)
                    {
                        MessageBox.Show("Thêm mới thành công !");
                        HienThiHDB();
                    }
                    else
                    {
                        MessageBox.Show("Thêm mới thất bại !");
                    }

                }

            }
            else
            {
                //sửa
                int i = 0;
                i = Controllers.HoaDonBanCtrl.UpdateHoaDonBan(_MaHoaDon, _MaNV, _MaBan, _TenKhachHang, _NgayLap, _DienGiai, _SoTien);
                if (i > 0)
                {
                    MessageBox.Show("Sửa thành công !");
                    HienThiHDB();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại !");
                }
            }

            uctHoaDonBan_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string _MaHoaDon = "";
            try
            {
                _MaHoaDon = txthoadonban.Text;
            }
            catch
            { }
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int i = 0;
                i = Controllers.HoaDonBanCtrl.DeleteHoaDonBan(_MaHoaDon);
                if (i > 0)
                {
                    MessageBox.Show("Xóa thành công !");
                    HienThiHDB();
                    uctHoaDonBan_Load(sender, e);
                }
                else

                    MessageBox.Show("Xóa thất bại !");
            }
            else
                return;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            flag = 1;
            dis_end(true);//các nút thêm sửa xóa bị ẩn đi, chỉ còn nút hủy lưu
            loadcontrol();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            uctHoaDonBan_Load(sender,e);
        }
    }
}
