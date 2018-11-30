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
    public partial class uctThucDon : UserControl
    {
        public uctThucDon()
        {
            InitializeComponent();
        }
        int flag = 0;
        public static uctThucDon uctTD = new uctThucDon();
        public void HienThiTD()
        {
            dgvDanhSachTD.DataSource = Models.ThucDonMod.FillDataSetThucDon().Tables[0];
            dgvDanhSachTD.Dock = DockStyle.Fill;
            dgvDanhSachTD.BorderStyle = BorderStyle.Fixed3D;
        }
        public void nhung(Control ctr)
        {
            pnlIDSThucDon.Controls.Clear();
            pnlIDSThucDon.BorderStyle = BorderStyle.Fixed3D;
            ctr.Dock = DockStyle.Fill;
            pnlIDSThucDon.Controls.Add(ctr);
            pnlIDSThucDon.Show();
        }
        public void binding()
        {
            txtIDthucdon.DataBindings.Clear();
            txtIDthucdon.DataBindings.Add("Text", dgvDanhSachTD.DataSource, "MaThucDon");
            cmbIDloaiTD.DataBindings.Clear();
            cmbIDloaiTD.DataBindings.Add("Text", dgvDanhSachTD.DataSource, "MaLoaiThucDon");
            txtTenthucdon.DataBindings.Clear();
            txtTenthucdon.DataBindings.Add("Text", dgvDanhSachTD.DataSource, "TenThucDon");
            cmbdonvitinh.DataBindings.Clear();
            cmbdonvitinh.DataBindings.Add("Text", dgvDanhSachTD.DataSource, "DonViTinh");
            txtdongia.DataBindings.Clear();
            txtdongia.DataBindings.Add("Text", dgvDanhSachTD.DataSource, "DonGia");
            cmbtrangthai.DataBindings.Clear();
            cmbtrangthai.DataBindings.Add("Text", dgvDanhSachTD.DataSource, "TrangThai");
        }
        //Hàm dis end các button khi load lên
        public void dis_end(bool e)
        {
            cmbIDloaiTD.Enabled = e;
            txtTenthucdon.Enabled = e;
            cmbdonvitinh.Enabled = e;
            txtdongia.Enabled = e;
            cmbtrangthai.Enabled = e;
            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
            btnThem.Enabled = !e;
            btnSua.Enabled = !e;
            btnXoa.Enabled = !e;
        }
        public void loadcontrol()
        {
            cmbtrangthai.Items.Clear();
            cmbtrangthai.Items.Add("Sẵn sàng phục vụ");
            cmbtrangthai.Items.Add("Dừng phục vụ");
            cmbIDloaiTD.DataSource = Models.LoaiThucDonMod.FillDataSetLoaiThucDon().Tables[0];
            cmbIDloaiTD.DisplayMember = "MaLoaiThucDon";
            cmbdonvitinh.Items.Clear();
            cmbdonvitinh.Items.Add("Đĩa");
            cmbdonvitinh.Items.Add("Cốc");
            cmbdonvitinh.Items.Add("Xuất");
            cmbdonvitinh.Items.Add("Bát");
        }
        //xóa dữ liệu ở textbox khi bấm vao btn
        public void clearData()
        {
            cmbIDloaiTD.Text = "";
            txtTenthucdon.Text = "";
            cmbdonvitinh.Text = "";
            txtdongia.Text = "";
            cmbtrangthai.Text = "";            
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
      
        }
        private void uctThucDon_Load(object sender, EventArgs e)
        {
            HienThiTD();
            dis_end(false);
            binding();
            label();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            uctSearchThucDon uctS = new uctSearchThucDon();
            nhung(uctS);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            uctThucDon_Load(sender, e);
            dis_end(false);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            flag = 1;
            dis_end(true);//các nút thêm sửa xóa bị ẩn đi, chỉ còn nút hủy lưu
            loadcontrol();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            flag = 0;
            clearData();
            dis_end(true);
        }
        
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string _MaThucDon = "";
            try
            {
                _MaThucDon = txtIDthucdon.Text;
            }
            catch { }
            string _MaLoaiThucDon = "";
            try
            {
                _MaLoaiThucDon = cmbIDloaiTD.Text;
            }
            catch { }
            string _TenThucDon = "";
            try
            {
                _TenThucDon = txtTenthucdon.Text;
            }
            catch { }
            string _DonViTinh= "";
            try
            {
                _DonViTinh = cmbdonvitinh.Text;
            }
            catch { }
            float _DonGia = 0;
            try
            {
                _DonGia = Convert.ToInt32(txtdongia.Text);
            }
            catch { }
            string _TrangThai = "";
            try
            {
                _TrangThai = cmbtrangthai.Text;
            }
            catch { }
            if (flag == 0)
            {
                //thêm mới
                if (_MaThucDon == "" || _MaLoaiThucDon == "" || _TenThucDon=="")
                    MessageBox.Show("Hãy nhập đầy đủ thông tin");
                else
                {
                    int i = 0;
                    i = Controllers.ThucDonCtrl.InsertThucDon( _MaThucDon, _MaLoaiThucDon, _TenThucDon, _DonViTinh, _DonGia, _TrangThai);
                    if (i > 0)
                    {
                        MessageBox.Show("Thêm mới thành công !");
                        HienThiTD();
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
                i = Controllers.ThucDonCtrl.UpdateThucDon(_MaThucDon, _MaLoaiThucDon, _TenThucDon, _DonViTinh, _DonGia, _TrangThai);
                if (i > 0)
                {
                    MessageBox.Show("Sửa thành công !");
                    HienThiTD();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại !");
                }
            }

            uctThucDon_Load(sender, e);
        }


        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            string _MaThucDon = "";
            try
            {
                _MaThucDon = txtIDthucdon.Text;
            }
            catch
            { }
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int i = 0;
                i = Controllers.ThucDonCtrl.DeleteThucDon(_MaThucDon);
                if (i > 0)
                {
                    MessageBox.Show("Xóa thành công !");
                    HienThiTD();
                    uctThucDon_Load(sender, e);
                }
                else

                    MessageBox.Show("Xóa thất bại !");
            }
            else
                return;
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            pnlIDSThucDon.Controls.Clear();
            pnlIDSThucDon.BorderStyle = BorderStyle.None;
        }
    }
}
