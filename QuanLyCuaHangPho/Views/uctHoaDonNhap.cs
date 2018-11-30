using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace QuanLyCuaHangPho.Views
{
    public partial class uctHoaDonNhap : UserControl
    {
        public uctHoaDonNhap()
        {
            InitializeComponent();
        }
        public static uctHoaDonNhap uctHDN = new uctHoaDonNhap();
        int flag = 0;
        public void HienThiHDN()
        {
            dgvDanhSachHDN.DataSource = Models.HoaDonNhapMod.FillDataSetHoaDonNhap().Tables[0];
            dgvDanhSachHDN.Dock = DockStyle.Fill;
            dgvDanhSachHDN.BorderStyle = BorderStyle.Fixed3D;
        }
        public void HienThiChiTietHDN()
        {
            dgvDSCTietHDN.DataSource = Models.ChiTietPhieuNhapMod.FillDataSetChiTietPhieuNhap().Tables[0];
            //dgvDSCTietHDN.Dock = DockStyle.Fill;
            dgvDSCTietHDN.BorderStyle = BorderStyle.Fixed3D;
        }
        public void binding()
        {
            txthoadonnhap.DataBindings.Clear();
            txthoadonnhap.DataBindings.Add("Text", dgvDanhSachHDN.DataSource, "MaPN");
            cmbmancc.DataBindings.Clear();
            cmbmancc.DataBindings.Add("Text", dgvDanhSachHDN.DataSource, "MaNCC");
            dtpngaylap.DataBindings.Clear();
            dtpngaylap.DataBindings.Add("Text", dgvDanhSachHDN.DataSource, "NgayNhap");
            txtsotien.DataBindings.Clear();
            txtsotien.DataBindings.Add("Text", dgvDanhSachHDN.DataSource, "TongTienNhap");
        }
        void loadcontrol()
        {            
            cmbmancc.DataSource = Models.NhaCungCapMod.FillDataSetNhaCungCap().Tables[0];
            cmbmancc.DisplayMember = "MaNCC";
        }
        public void dis_end(bool e)
        {
            cmbmancc.Enabled = e;
            dtpngaylap.Enabled = e;
            txtsotien.Enabled = e;
            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
            btnThem.Enabled = !e;
            btnSua.Enabled = !e;
            btnXoa.Enabled = !e;
        }
        public void dis_end1(bool e)
        {
            cmbmanguyenlieu.Enabled = e;
            txttennguyenlieu.Enabled = e;
            txtsoluong.Enabled = e;
            txtdongia.Enabled = e;
            btnluu1.Enabled = e;
            btnhuy1.Enabled = e;
            btnthem1.Enabled = !e;
            btnsua1.Enabled = !e;
            btnxoa1.Enabled = !e;
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
            label10.BackColor = Color.Transparent;
            label11.BackColor = Color.Transparent;            
            label13.BackColor = Color.Transparent;
        }
        private void uctHoaDonNhap_Load(object sender, EventArgs e)
        {
            HienThiHDN();
            //HienThiChiTietHDN();
            dis_end(false);
            binding();
            dis_end1(false);
            label();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            flag = 1;
            dis_end(true);
        }
        public void clearData()
        {
            txthoadonnhap.Text = "";
            dtpngaylap.Text = "";
            txtsotien.Text = "";
            loadcontrol();
        }
        public void clearData1()
        {
            txtsoluong.Text = "";
            txtdongia.Text = "";
            txtsotien.Text = "";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            flag = 0;
            clearData1();
            dis_end(true);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string _MaPN = "";
            try
            {
                _MaPN = txthoadonnhap.Text;
            }
            catch { }
            string _MaNCC = "";
            try
            {
                _MaNCC = cmbmancc.Text;
            }
            catch { }
            DateTime _NgayNhap = DateTime.Now;
            try{}
            catch { }
            decimal _TongTienNhap = 0;
            try
            {
                _TongTienNhap = Convert.ToInt32(txtsotien.Text);
            }
            catch { }
            try
            {
                if (flag == 0)
                {
                    //thêm mới
                    if (_MaPN == "" || _MaNCC == "")
                        MessageBox.Show("Hãy nhập đầy đủ thông tin");
                    else
                    {
                        int i = 0;
                        i = Controllers.HoaDonNhapCtrl.InsertHoaDonNhap(_MaPN, _MaNCC, _NgayNhap, _TongTienNhap);
                        if (i > 0)
                        {
                            MessageBox.Show("Thêm mới thành công !");
                            HienThiHDN();
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
                    i = Controllers.HoaDonNhapCtrl.UpdateHoaDonNhap(_MaPN, _MaNCC, _NgayNhap, _TongTienNhap);
                    if (i > 0)
                    {
                        MessageBox.Show("Sửa thành công !");
                        HienThiHDN();
                    }
                    else
                    {
                        MessageBox.Show("Sửa thất bại !");
                    }
                }
            }catch{ };

            uctHoaDonNhap_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string _MaPN = "";
            try
            {
                _MaPN = txthoadonnhap.Text;
            }
            catch
            { }
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int i = 0;
                i = Controllers.HoaDonNhapCtrl.DeleteHoaDonNhap(_MaPN);
                if (i > 0)
                {
                    MessageBox.Show("Xóa thành công !");
                    HienThiHDN();
                    uctHoaDonNhap_Load(sender, e);
                }
                else

                    MessageBox.Show("Xóa thất bại !");
            }
            else
                return;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            uctHoaDonNhap_Load(sender, e);
            dis_end(false);
        }

        private void dgvDanhSachHDN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string _maphieunhap = txthoadonnhap.Text.ToString();
            string _manguyenlieu = cmbmanguyenlieu.Text.ToString();
            DataTable dt = new DataTable();
            dt = Controllers.ChiTietPhieuNhapCtrl.FillDataSet_getChiTietPhieuNhapbyID(_maphieunhap,_manguyenlieu).Tables[0];
            dgvDSCTietHDN.DataSource = dt;
            //txthoadonnhap.DataBindings.Clear();
            //txthoadonnhap.DataBindings.Add("Text", dgvDSCTietHDN.DataSource, "MaPN");
            cmbmanguyenlieu.DataBindings.Clear();
            cmbmanguyenlieu.DataBindings.Add("Text", dgvDSCTietHDN.DataSource, "MaNguyenLieu");
            txttennguyenlieu.DataBindings.Clear();
            txttennguyenlieu.DataBindings.Add("Text", dgvDSCTietHDN.DataSource, "TenNguyenLieu");
            txtsoluong.DataBindings.Clear();
            txtsoluong.DataBindings.Add("Text", dgvDSCTietHDN.DataSource, "SoLuong");
            txtdongia.DataBindings.Clear();
            txtdongia.DataBindings.Add("Text", dgvDSCTietHDN.DataSource, "DonGia");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            flag = 0;
            clearData1();
            dis_end1(true);
        }
        public void tinhtien()
        {
            try
            {
                int tien = dgvDSCTietHDN.Rows.Count;
                decimal thanhtien = 0;
                for (int i = 0; i < tien; i++)
                {
                    thanhtien += decimal.Parse(dgvDSCTietHDN.Rows[i].Cells[5].Value.ToString());
                    txtsotien.Text = thanhtien.ToString();
                    lbltongtiennhap.Text = thanhtien.ToString("#,###");
                }
            }
            catch
            {
            }
        }
        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btntinhtiennhap_Click(object sender, EventArgs e)
        {         
            tinhtien();
            MessageBox.Show("Tổng số tiền thanh toán của hóa đơn " + "" + txthoadonnhap.Text + "" + " là " + lbltongtiennhap.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void btnhuy1_Click(object sender, EventArgs e)
        {
            dis_end1(false);
        }

        private void btnsua1_Click(object sender, EventArgs e)
        {
            flag = 1;
            dis_end1(true);
        }

        private void btnxoa1_Click(object sender, EventArgs e)
        {
            string _MaPN = "";
            try
            {
                _MaPN = txthoadonnhap.Text;
            }
            catch{ }
            string _MaNguyenLieu = "";
            try
            {
                _MaNguyenLieu = cmbmanguyenlieu.Text;
            }
            catch { }
            string _TenNguyenLieu = "";
            try
            {
                _TenNguyenLieu = txttennguyenlieu.Text;
            }
            catch { }
            int _SoLuong = 0;
            try
            {
                _SoLuong = Convert.ToInt32(txtsoluong.Text);
            }
            catch { }
            decimal _DonGia = 0;
            try
            {
                _DonGia = Convert.ToInt32(txtdongia.Text);
            }
            catch { }
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int i = 0;
                i = Controllers.ChiTietPhieuNhapCtrl.DeleteChiTietPhieuNhap(_MaPN,_MaNguyenLieu,_TenNguyenLieu,_SoLuong,_DonGia);
                if (i > 0)
                {
                    MessageBox.Show("Xóa thành công !");
                    HienThiChiTietHDN();
                    uctHoaDonNhap_Load(sender, e);
                }
                else

                    MessageBox.Show("Xóa thất bại !");
            }
            else
                return;
        }

        private void btnluu1_Click(object sender, EventArgs e)
        {
            string _MaPhieuNhap = "";
            try
            {
                _MaPhieuNhap = txthoadonnhap.Text;
            }
            catch
            {}
            string _MaNguyenLieu = "";
            try
            {
                _MaNguyenLieu = cmbmanguyenlieu.Text;
            }
            catch { }
            string _TenNguyenLieu = "";
            try
            {
                _TenNguyenLieu = txttennguyenlieu.Text;
            }
            catch { }
            int _SoLuong = 0;
            try
            {
                _SoLuong = Convert.ToInt32(txtsoluong.Text);
            }
            catch { }
            decimal _DonGia = 0;
            try
            {
                _DonGia=Convert.ToInt32(txtdongia.Text);
            }
            catch { }

            if (flag == 0)
            {
                //thêm mới
                if (_MaPhieuNhap == "" || _MaNguyenLieu == "")
                    MessageBox.Show("Hãy nhập đầy đủ thông tin");
                else
                {
                    int i = 0;
                    i = Controllers.ChiTietPhieuNhapCtrl.InsertChiTietPhieuNhap(_MaPhieuNhap, _MaNguyenLieu, _TenNguyenLieu, _SoLuong,_DonGia,'0');
                    if (i > 0)
                    {
                        MessageBox.Show("Thêm mới thành công !");
                        HienThiChiTietHDN();
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
                i = Controllers.ChiTietPhieuNhapCtrl.UpdateChiTietPhieuNhap(_MaPhieuNhap, _MaNguyenLieu, _TenNguyenLieu, _SoLuong, _DonGia, '0');
                if (i > 0)
                {
                    MessageBox.Show("Sửa thành công !");
                    HienThiChiTietHDN();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại !");
                }
            }
            dis_end1(false);
        }
    }
}
