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
    public partial class uctLoaiThucDon : UserControl
    {
        public uctLoaiThucDon()
        {
            InitializeComponent();
        }
        int flag = 0;
        public static uctLoaiThucDon uctloaitd = new uctLoaiThucDon();
        public void HienThiLoaiTD()
        {
            dgvDanhSachLoaiTD.DataSource = Models.LoaiThucDonMod.FillDataSetLoaiThucDon().Tables[0];
            dgvDanhSachLoaiTD.Dock = DockStyle.Fill;
            dgvDanhSachLoaiTD.BorderStyle = BorderStyle.Fixed3D;
        }
        public void loadcontrol()
        {
            cmbTrangThai.Items.Clear();
            cmbTrangThai.Items.Add("Hoạt động");
            cmbTrangThai.Items.Add("Ngừng hoạt động");
        }
        void binding()
        {
            txtIDLoaiThucDon.DataBindings.Clear();
            txtIDLoaiThucDon.DataBindings.Add("Text", dgvDanhSachLoaiTD.DataSource, "MaLoaiThucDon");
            txtTenLoaiThucDon.DataBindings.Clear();
            txtTenLoaiThucDon.DataBindings.Add("Text", dgvDanhSachLoaiTD.DataSource, "TenLoaiThucDon");
            txtDienGiai.DataBindings.Clear();
            txtDienGiai.DataBindings.Add("Text", dgvDanhSachLoaiTD.DataSource, "DienGiai");
            cmbTrangThai.DataBindings.Clear();
            cmbTrangThai.DataBindings.Add("Text", dgvDanhSachLoaiTD.DataSource, "TrangThai");
        }
        //Hàm dis end các button khi load lên
        void dis_end(bool e)
        {
            txtTenLoaiThucDon.Enabled = e;
            txtDienGiai.Enabled = e;
            cmbTrangThai.Enabled = e;
            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
            btnThem.Enabled = !e;
            btnSua.Enabled = !e;
            btnXoa.Enabled = !e;
        }
        public void label()
        {
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
        }
        private void uctLoaiThucDon_Load(object sender, EventArgs e)
        {
            HienThiLoaiTD();
            dis_end(false);
            binding();
            label();
        }
        public void clearData()
        {
            txtTenLoaiThucDon.Text = "";
            txtDienGiai.Text = "";
            loadcontrol();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            uctLoaiThucDon_Load(sender, e);
            dis_end(false);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            flag = 0;
            clearData();
            dis_end(true);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string _MaLoaiThucDon = "";
            try
            {
                _MaLoaiThucDon = txtIDLoaiThucDon.Text;
            }
            catch { }
            string _TenLoaiThucDon = "";
            try
            {
                _TenLoaiThucDon = txtTenLoaiThucDon.Text;
            }
            catch { }
            string _DienGiai = "";
            try
            {
                _DienGiai = txtDienGiai.Text;
            }
            catch { }
            string _TrangThai = "";
            try
            {
                _TrangThai = cmbTrangThai.Text;
            }
            catch { }

            if (flag == 0)
            {
                //thêm mới
                if (_MaLoaiThucDon == "" || _TenLoaiThucDon == "")
                    MessageBox.Show("Hãy nhập đầy đủ thông tin");
                else
                {
                    int i = 0;
                    i = Controllers.LoaiThucDonCtrl.InsertLoaiThucDon(_MaLoaiThucDon, _TenLoaiThucDon, _DienGiai, _TrangThai);
                    if (i > 0)
                    {
                        MessageBox.Show("Thêm mới thành công !");
                        HienThiLoaiTD();
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
                i = Controllers.LoaiThucDonCtrl.UpdateLoaiThucDon(_MaLoaiThucDon, _TenLoaiThucDon, _DienGiai, _TrangThai);
                if (i > 0)
                {
                    MessageBox.Show("Sửa thành công !");
                    HienThiLoaiTD();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại !");
                }
            }
            uctLoaiThucDon_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string _MaLoaiThucDon = "";
            try
            {
                _MaLoaiThucDon = txtIDLoaiThucDon.Text;
            }
            catch
            { }
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int i = 0;
                i = Controllers.LoaiThucDonCtrl.DeleteLoaiThucDon(_MaLoaiThucDon);
                if (i > 0)
                {
                    MessageBox.Show("Xóa thành công !");
                    HienThiLoaiTD();
                    uctLoaiThucDon_Load(sender, e);
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

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
