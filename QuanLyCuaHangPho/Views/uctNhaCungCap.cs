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
    public partial class uctNhaCungCap : UserControl
    {
        public uctNhaCungCap()
        {
            InitializeComponent();
        }
        int flag = 0;
        public static uctNhaCungCap uctNCC = new uctNhaCungCap();
        public void HienThiNCC()
        {
            dgvDSNCC.DataSource = Models.NhaCungCapMod.FillDataSetNhaCungCap().Tables[0];
            dgvDSNCC.Dock = DockStyle.Fill;
            dgvDSNCC.BorderStyle = BorderStyle.Fixed3D;
        }
        public void nhung(Control ctr)
        {
            pnlIDSNCC.Controls.Clear();
            pnlIDSNCC.BorderStyle = BorderStyle.Fixed3D;
            ctr.Dock = DockStyle.Fill;
            pnlIDSNCC.Controls.Add(ctr);
            pnlIDSNCC.Show();
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            uctNhaCungCap_Load(sender, e);
            dis_end(false);
        }
        public void binding()
        {
            txtIDNCC.DataBindings.Clear();
            txtIDNCC.DataBindings.Add("Text", dgvDSNCC.DataSource, "MaNCC");
            txtHTenNCC.DataBindings.Clear();
            txtHTenNCC.DataBindings.Add("Text", dgvDSNCC.DataSource, "TenNCC");
            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", dgvDSNCC.DataSource, "DiaChi");
            txtSDT.DataBindings.Clear();
            txtSDT.DataBindings.Add("Text", dgvDSNCC.DataSource, "SDT");
            txtEmail.DataBindings.Clear();
            txtEmail.DataBindings.Add("Text", dgvDSNCC.DataSource, "Email");
        }
        //Hàm dis end các button khi load lên
        public void dis_end(bool e)
        {
            txtHTenNCC.Enabled = e;
            txtDiaChi.Enabled = e;
            txtSDT.Enabled = e;
            txtEmail.Enabled = e;
            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
            btnThem.Enabled = !e;
            btnSua.Enabled = !e;
            btnXoa.Enabled = !e;
        }
        public void label()
        {
         
            label3.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            label5.BackColor = Color.Transparent;
            label6.BackColor = Color.Transparent;
            label8.BackColor = Color.Transparent;
           
        }
        private void uctNhaCungCap_Load(object sender, EventArgs e)
        {
            HienThiNCC();
            dis_end(false);
            binding();
            label();
        }
        public void clearData()
        {
            txtIDNCC.Text = "";
            txtHTenNCC.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
            txtEmail.Text = "";
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
            string _MaNCC = "";
            try
            {
                _MaNCC = txtIDNCC.Text;
            }
            catch { }
            string _TenNCC = "";
            try
            {
                _TenNCC =txtHTenNCC.Text;
            }
            catch { }
            string _SDT = "";
            try
            {
                _SDT = txtSDT.Text;
            }
            catch { }
            string _DiaChi = "";
            try
            {
                _DiaChi = txtDiaChi.Text;
            }
            catch { }
            
            string _Email = "";
            try
            {
                _Email = txtEmail.Text;
            }
            catch { }
            if (flag == 0)
            {
                //thêm mới
                if (_MaNCC == "" || _TenNCC == "")
                    MessageBox.Show("Hãy nhập đầy đủ thông tin");
                else
                {
                    int i = 0;
                    i = Controllers.NhaCungCapCtrl.InsertNhaCungCap(_MaNCC, _TenNCC, _DiaChi, _SDT, _Email);
                    if (i > 0)
                    {
                        MessageBox.Show("Thêm mới thành công !");
                        HienThiNCC();
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
                i = Controllers.NhaCungCapCtrl.UpdateNhaCungCap(_MaNCC, _TenNCC, _DiaChi, _SDT, _Email);
                if (i > 0)
                {
                    MessageBox.Show("Sửa thành công !");
                    HienThiNCC();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại !");
                }
            }

            uctNhaCungCap_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string _MaNCC = "";
            try
            {
                _MaNCC = txtIDNCC.Text;
            }
            catch
            { }
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int i = 0;
                i = Controllers.NhaCungCapCtrl.DeleteNhaCungCap(_MaNCC);
                if (i > 0)
                {
                    MessageBox.Show("Xóa thành công !");
                    HienThiNCC();
                    uctNhaCungCap_Load(sender, e);
                }
                else

                    MessageBox.Show("Xóa thất bại !");
            }
            else
                return;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            uctSearchNhaCungCap uctNCC = new uctSearchNhaCungCap();
            nhung(uctNCC);
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            pnlIDSNCC.Controls.Clear();
            pnlIDSNCC.BorderStyle = BorderStyle.None;
        }

        private void dgvDSNCC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
