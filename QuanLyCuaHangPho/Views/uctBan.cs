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
    public partial class uctBan : UserControl
    {
        public uctBan()
        {
            InitializeComponent();
        }
        int flag = 0;
        public static uctBan uctB = new uctBan();
        public void HienThiBan()
        {
            dgvDanhSachBan.DataSource = Models.BanMod.FillDataSetBan().Tables[0];
            dgvDanhSachBan.Dock = DockStyle.Fill;
            dgvDanhSachBan.BorderStyle = BorderStyle.Fixed3D;
        }

        void loadcontrol()
        {
            cmbTrangThai.Items.Clear();
            cmbTrangThai.Items.Add("Hoạt động");
            cmbTrangThai.Items.Add("Ngừng hoạt động");
           
        }
        void binding()
        {
            txtIDBan.DataBindings.Clear();
            txtIDBan.DataBindings.Add("Text", dgvDanhSachBan.DataSource, "MaBan");          
            txtTenBan.DataBindings.Clear();
            txtTenBan.DataBindings.Add("Text", dgvDanhSachBan.DataSource, "TenBan");
            txtDienGiai.DataBindings.Clear();
            txtDienGiai.DataBindings.Add("Text", dgvDanhSachBan.DataSource, "DienGiai");
            cmbTrangThai.DataBindings.Clear();
            cmbTrangThai.DataBindings.Add("Text", dgvDanhSachBan.DataSource, "TrangThai");
        }
        //Hàm dis end các button khi load lên
        void dis_end(bool e)
        {
            txtIDBan.Enabled = e;
            txtTenBan.Enabled = e;
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
            label3.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            label5.BackColor = Color.Transparent;
           
        }
        private void uctBan_Load(object sender, EventArgs e)
        {
            HienThiBan();
            dis_end(false);
            binding();
            label();
        }
        public void clearData()
        {
            txtTenBan.Text = "";
            txtDienGiai.Text = "";
            loadcontrol();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            uctBan_Load(sender, e);
            dis_end(false);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            flag = 1;
            dis_end(true);//các nút thêm sửa xóa bị ẩn đi, chỉ còn nút hủy lưu
            

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            flag = 0;
            clearData();
            dis_end(true);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string _MaBan = "";
            try
            {
                _MaBan = txtIDBan.Text;
            }
            catch { }
           
            string _TenBan = "";
            try
            {
                _TenBan = txtTenBan.Text;
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
                if (_MaBan == "")
                    MessageBox.Show("Hãy nhập đầy đủ thông tin");
                else
                {
                    int i = 0;
                    i = Controllers.BanCtrl.InsertBan(_MaBan, _TenBan, _DienGiai, _TrangThai);
                    if (i > 0)
                    {
                        MessageBox.Show("Thêm mới thành công !");
                        HienThiBan();
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
                i = Controllers.BanCtrl.UpdateBan(_MaBan, _TenBan, _DienGiai, _TrangThai);
                if (i > 0)
                {
                    MessageBox.Show("Sửa thành công !");
                    HienThiBan();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại !");
                }
            }
            uctBan_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string _MaBan = "";
            try
            {
                _MaBan = txtIDBan.Text;
            }
            catch
            { }
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int i = 0;
                i = Controllers.BanCtrl.DeleteBan(_MaBan);
                if (i > 0)
                {
                    MessageBox.Show("Xóa thành công !");
                    HienThiBan();
                    uctBan_Load(sender, e);
                }
                else
                    MessageBox.Show("Xóa thất bại !");
            }
            else
                return;
        }

        private void dgvDanhSachBan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
