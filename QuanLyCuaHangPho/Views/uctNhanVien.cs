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
    public partial class uctNhanVien : UserControl
    {
        public uctNhanVien()
        {
            InitializeComponent();
        }
        int flag = 0;
        public static uctNhanVien uctNV = new uctNhanVien();
        public void HienThiNV()
        {
            dgvDSNhanVien.DataSource = Models.NhanVienMod.FillDataSetNhanVien().Tables[0];
            dgvDSNhanVien.Dock = DockStyle.Fill;
            dgvDSNhanVien.BorderStyle = BorderStyle.Fixed3D;
        }
        public void nhung(Control ctr)
        {
            pnlIDSNhanVien.Controls.Clear();
            pnlIDSNhanVien.BorderStyle = BorderStyle.Fixed3D;
            ctr.Dock = DockStyle.Fill;
            pnlIDSNhanVien.Controls.Add(ctr);
            pnlIDSNhanVien.Show();
        }
        private void grQLNhanVien_Enter(object sender, EventArgs e)
        {

        }
        public void label()
        {
           
            label3.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            label5.BackColor = Color.Transparent;
            label8.BackColor = Color.Transparent;
            label9.BackColor = Color.Transparent;
            label10.BackColor = Color.Transparent;
        }
        private void uctNhanVien_Load(object sender, EventArgs e)
        {
            HienThiNV();
            dis_end(false);
            binding();
            label();
        }
        // Hàm trỏ dữ liệu đến datagridview
        public void binding()
        {
            txtIDNV.DataBindings.Clear();
            txtIDNV.DataBindings.Add("Text", dgvDSNhanVien.DataSource, "MaNV");
            txtHoten.DataBindings.Clear();
            txtHoten.DataBindings.Add("Text", dgvDSNhanVien.DataSource, "Hoten");
            dtpNgaySinh.DataBindings.Clear();
            dtpNgaySinh.DataBindings.Add("Text", dgvDSNhanVien.DataSource, "Ngaysinh");
            cmbGioiTinh.DataBindings.Clear();
            cmbGioiTinh.DataBindings.Add("Text", dgvDSNhanVien.DataSource, "Gioitinh");
            txtSDT.DataBindings.Clear();
            txtSDT.DataBindings.Add("Text", dgvDSNhanVien.DataSource, "SDT");
            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", dgvDSNhanVien.DataSource, "Diachi");
        }
        //Hàm dis end các button khi load lên
        public void dis_end(bool e)
        {
            txtHoten.Enabled = e;
            cmbGioiTinh.Enabled = e;
            dtpNgaySinh.Enabled = e;
            txtDiaChi.Enabled = e;
            txtSDT.Enabled = e;
            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
            btnThem.Enabled = !e;
            btnSua.Enabled = !e;
            btnXoa.Enabled = !e;
        }
        public void loadcontrol()
        {
            cmbGioiTinh.Items.Clear();
            cmbGioiTinh.Items.Add("Nam");
            cmbGioiTinh.Items.Add("Nữ");
            cmbGioiTinh.Items.Add("Khác");
        }
        //xóa dữ liệu ở textbox khi bấm vao btn
        public void clearData()
        {
            txtHoten.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
            loadcontrol();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            uctNhanVien_Load(sender, e);
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
            string _MaNV = "";
            try
            {
                _MaNV = txtIDNV.Text;
            }
            catch { }
            string _Hoten = "";
            try
            {
                _Hoten = txtHoten.Text;
            }
            catch { }
            string _SDT = "";
            try
            {
                _SDT = txtSDT.Text;
            }
            catch { }
            string _Diachi = "";
            try
            {
                _Diachi = txtDiaChi.Text;
            }
            catch { }
            DateTime _Ngaysinh = dtpNgaySinh.Value;
            try
            {
                
            }
            catch { }
            string _Gioitinh = "";
            try
            {
                _Gioitinh = cmbGioiTinh.Text;
            }
            catch { }
            if (flag == 0)
            {
                //thêm mới
                if (_MaNV == "" || _Hoten == "")
                    MessageBox.Show("Hãy nhập đầy đủ thông tin");
                else
                {
                    int i = 0;
                    i = Controllers.NhanVienCtrl.InsertNhanVien(_MaNV, _Hoten, _Ngaysinh, _Gioitinh, _SDT, _Diachi);
                    if (i > 0)
                    {
                        MessageBox.Show("Thêm mới thành công !");
                        HienThiNV();
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
                i = Controllers.NhanVienCtrl.UpdateNhanVien(_MaNV, _Hoten, _Ngaysinh, _Gioitinh, _SDT, _Diachi);
                if (i > 0)
                {
                    MessageBox.Show("Sửa thành công !");
                    HienThiNV();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại !");
                }
            }

            uctNhanVien_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string _MaNV = "";
            try
            {
                _MaNV = txtIDNV.Text;
            }
            catch
            { }
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int i = 0;
                i = Controllers.NhanVienCtrl.DeleteNhanVien(_MaNV);
                if (i > 0)
                {
                    MessageBox.Show("Xóa thành công !");
                    HienThiNV();
                    uctNhanVien_Load(sender, e);
                }
                else

                    MessageBox.Show("Xóa thất bại !");
            }
            else
                return;
        }

        private void pnlIDSNhanVien_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            uctSearchNhanVien uctS = new uctSearchNhanVien();
            nhung(uctS);
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            pnlIDSNhanVien.Controls.Clear();
            pnlIDSNhanVien.BorderStyle = BorderStyle.None;
        }

        private void ctxtmenuTabHienThi_Opening(object sender, CancelEventArgs e)
        {

        }
    }

}

