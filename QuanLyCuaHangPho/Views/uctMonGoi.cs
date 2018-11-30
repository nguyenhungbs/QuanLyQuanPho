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
    public partial class uctMonGoi : UserControl
    {
        public uctMonGoi()
        {
            InitializeComponent();
        }
        int flag = 0;
        public void HienThiDanhSachGM()
        {
            dgvDanhSachGM.DataSource = Models.GoiMonMod.FillDataSetGoiMon().Tables[0];
            dgvDanhSachGM.Dock = DockStyle.Fill;
            dgvDanhSachGM.RowHeadersVisible = false;
            dgvDanhSachGM.BorderStyle = BorderStyle.Fixed3D;
        }
        public void binding()
        {
            cmbIDBan.DataBindings.Clear();
            cmbIDBan.DataBindings.Add("Text", dgvDanhSachGM.DataSource, "MaBan");
            cmbTenThucDon.DataBindings.Clear();
            cmbTenThucDon.DataBindings.Add("Text", dgvDanhSachGM.DataSource, "TenThucDon");
            txtdongia.DataBindings.Clear();
            txtdongia.DataBindings.Add("Text", dgvDanhSachGM.DataSource, "DonGia");
            txtsoluong.DataBindings.Clear();
            txtsoluong.DataBindings.Add("Text", dgvDanhSachGM.DataSource, "SoLuong");
            dtpthoigian.DataBindings.Clear();
            dtpthoigian.DataBindings.Add("Text", dgvDanhSachGM.DataSource, "ThoiGian");
            txtghichu.DataBindings.Clear();
            txtghichu.DataBindings.Add("Text", dgvDanhSachGM.DataSource, "GhiChu");
            cmbtrangthai.DataBindings.Clear();
            cmbtrangthai.DataBindings.Add("Text", dgvDanhSachGM.DataSource, "TrangThai");
            txtdongia.Enabled = false;
        }
        //Hàm dis end các button khi load lên
        public void dis_end(bool e)
        {
            cmbIDBan.Enabled = e;
            cmbTenThucDon.Enabled = e;
            
            txtsoluong.Enabled = e;
            dtpthoigian.Enabled = e;
            txtghichu.Enabled = e;
            cmbtrangthai.Enabled = e;         
            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
            btnThem.Enabled = !e;
            btnSua.Enabled = !e;
            btnXoa.Enabled = !e;
        }
        public void loadcontrol()
        {
            cmbIDBan.DataSource = Models.GoiMonMod.FillDataSet_getIdBan().Tables[0];
            cmbIDBan.DisplayMember = "MaBan";
            cmbIDBan.ValueMember = "MaBan";
            cmbTenThucDon.DataSource = Models.GoiMonMod.FillDataSet_getDonGiaThucDon().Tables[0];
            cmbTenThucDon.DisplayMember = "TenThucDon";
            cmbTenThucDon.ValueMember = "DonGia";
            cmbtrangthai.Items.Add("Đang chờ");
            cmbtrangthai.Items.Add("Đã chuyển cho khách");
            cmbtrangthai.Items.Add("Chế biến lại");
        }
        public void clearData()
        {
            txtdongia.Text = cmbTenThucDon.SelectedValue.ToString();
            txtsoluong.Text = "";
            txtghichu.Text = "";          
            loadcontrol();
            
        }
        private void uctMonGoi_Load(object sender, EventArgs e)
        {
            HienThiDanhSachGM();
            dis_end(false);
            binding();
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        
        private void btnHuy_Click(object sender, EventArgs e)
        {
            uctMonGoi_Load(sender, e);
            dis_end(false);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txtdongia.Enabled = false;
            flag = 1;
            dis_end(true);//các nút thêm sửa xóa bị ẩn đi, chỉ còn nút hủy lưu
            loadcontrol();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            flag = 0;
            //clearData();
            loadcontrol();
            dis_end(true);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string _MaBan = "";
            try
            {
                _MaBan = cmbIDBan.Text;
            }
            catch { }
            string _TenThucDon = "";
            try
            {
                _TenThucDon = cmbTenThucDon.Text;
            }
            catch { }
            decimal _DonGia = 0;
            try
            {
                _DonGia = Convert.ToInt32(txtdongia.Text);
            }
            catch { }
            int _SoLuong = 0;
            try
            {
                _SoLuong = Convert.ToInt32(txtsoluong.Text) ;
            }
            catch { }
            decimal _ThanhTien = 0;
            try
            {
                _ThanhTien = Convert.ToInt32(txtdongia.Text);
            }
            catch { }
            DateTime _ThoiGian = DateTime.Now;
            try  { }
            catch { }
            string _GhiChu = "";
            try
            {
                _GhiChu = txtghichu.Text;
            }
            catch { }
            string _TrangThai = "";
            try
            {
                _TrangThai = cmbtrangthai.Text;
            }
            catch{}
            if (flag == 0)
            {
                //thêm mới
                if (_MaBan == "" )
                    MessageBox.Show("Hãy nhập đầy đủ thông tin");
                else
                {
                    int i = 0;
                    i = Controllers.GoiMonCtrl.InsertGoiMon(_MaBan, _TenThucDon, _DonGia, _SoLuong, _ThanhTien, _ThoiGian, _GhiChu, _TrangThai);
                    if (i > 0)
                    {
                        MessageBox.Show("Thêm mới thành công !");
                        HienThiDanhSachGM();
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
                i = Controllers.GoiMonCtrl.UpdateGoiMon(_MaBan, _TenThucDon, _DonGia, _SoLuong, _ThanhTien, _ThoiGian, _GhiChu, _TrangThai);
                if (i > 0)
                {
                    MessageBox.Show("Sửa thành công !");
                    HienThiDanhSachGM();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại !");
                }
            }

            uctMonGoi_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string _MaBan = "";
            try
            {
                _MaBan = cmbIDBan.Text;
            }
            catch
            { }
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int i = 0;
                i = Controllers.GoiMonCtrl.DeleteGoiMon(_MaBan);
                if (i > 0)
                {
                    MessageBox.Show("Xóa thành công !");
                    HienThiDanhSachGM();
                    uctMonGoi_Load(sender, e);
                }
                else

                    MessageBox.Show("Xóa thất bại !");
            }
            else
                return;
        }

        private void cmbTenThucDon_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtdongia.Text = cmbTenThucDon.SelectedValue.ToString();
        }
    }
}
