using System;
using System.Collections.Generic;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyCuaHangPho.Views
{
    public partial class uctGoiMon : UserControl
    {
        public uctGoiMon()
        {
            InitializeComponent();
        }
        public static uctGoiMon uctGM = new uctGoiMon();
        
        
        public DataTable getBan()
        {
            DataTable dt = new DataTable();
            dt = Models.BanMod.FillDataSetDanhSachBan_GoiMon().Tables[0];
            return dt;
        }
        public DataTable getBanDaGoi()
        {
            DataTable dt = new DataTable();
            dt = Models.GoiMonMod.FillDataSetDanhSachBan_GoiMon().Tables[0];
            dgvGoiMon.DataSource = dt;
            return dt;
        }
        public DataTable getBanChuaGoi()
        {
            DataTable dt = new DataTable();
            dt = Models.GoiMonMod.FillDataSetDanhSachBanChua_GoiMon().Tables[0];
            return dt;
        }
        

        public void showListView()
        {
            lvDanhSachBan.Items.Clear();
            DataTable dt = new DataTable();
            dt = getBanDaGoi();
            for(int i=0; i<dt.Rows.Count; i++)
            {
                ListViewItem item = new ListViewItem(dt.Rows[i]["Tên Bàn"].ToString());
                ListViewItem.ListViewSubItem subItem = new ListViewItem.ListViewSubItem(item, dt.Rows[i][0].ToString());
                ListViewItem Status = new ListViewItem(dt.Rows[i]["Mã Bàn"].ToString());
                item.ImageIndex = 2;
                item.SubItems.Add(subItem);
                lvDanhSachBan.Items.Add(item);
            }
            DataTable dt2 = new DataTable();
            dt2 = getBanChuaGoi();
            for (int i = 0; i < dt2.Rows.Count; i++)
            {
                ListViewItem item = new ListViewItem(dt2.Rows[i]["Tên Bàn"].ToString());
                ListViewItem.ListViewSubItem subItem = new ListViewItem.ListViewSubItem(item, dt2.Rows[i][0].ToString());
                ListViewItem Status = new ListViewItem(dt2.Rows[i]["Mã Bàn"].ToString());
                item.ImageIndex = 3;
                item.SubItems.Add(subItem);
                lvDanhSachBan.Items.Add(item);
            }
        }
        public void BanCoNguoi()// đổ dữ liệu và hiện cái listItem vào listView
        {
            DataTable dt = new DataTable();
            dt = getBanDaGoi();
            dgvGoiMon.DataSource = dt;
            lvDanhSachBan.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem item = new ListViewItem(dt.Rows[i]["Tên Bàn"].ToString());
                ListViewItem.ListViewSubItem subItem = new ListViewItem.ListViewSubItem(item, dt.Rows[i][0].ToString());
                ListViewItem Status = new ListViewItem(dt.Rows[i]["Mã Bàn"].ToString());
                item.ImageIndex = 2;
                item.SubItems.Add(subItem);
                lvDanhSachBan.Items.Add(item);
            }
        }
        public void BanChuaCoNguoi()
        {
            DataTable dt = new DataTable();
            dt = getBanChuaGoi();
            dgvGoiMon.DataSource = dt;
            lvDanhSachBan.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem item = new ListViewItem(dt.Rows[i]["Tên Bàn"].ToString());              
                ListViewItem Status = new ListViewItem(dt.Rows[i]["Mã Bàn"].ToString());
                item.SubItems.Add(dt.Rows[i]["Mã Bàn"].ToString());
                lvDanhSachBan.Items.Add(item);
                item.ImageIndex = 3;
            }
        }
        public void nhung(Control ctr)
        {
            pnlGoiMon.Controls.Clear();
            pnlGoiMon.BorderStyle = BorderStyle.Fixed3D;
            ctr.Dock = DockStyle.Fill;
            pnlGoiMon.Controls.Add(ctr);
            pnlGoiMon.Show();
        }

        public void HienthiMG()
        {
            
            dgvGoiMon.Dock = DockStyle.Fill;
            dgvGoiMon.RowHeadersVisible = false;
            dgvGoiMon.BorderStyle = BorderStyle.Fixed3D;

        }
        private void uctGoiMon_Load(object sender, EventArgs e)
        {
            uctDanhSachTD uctDstd = new uctDanhSachTD();
            nhung(uctDstd);
            showListView();
            dgvGoiMon.Dock = DockStyle.Fill;
            dgvGoiMon.RowHeadersVisible = false;
            dgvGoiMon.BorderStyle = BorderStyle.Fixed3D;
            lbtongtien.Text = "";
            loadcontrol();      
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        

        private void btnMenu_Click(object sender, EventArgs e)
        {
            uctDanhSachTD uctds = new uctDanhSachTD();
            nhung(uctds);
        }

        private void lvDanhSachBan_Click(object sender, EventArgs e)
        {
            string _MaBan = lvDanhSachBan.SelectedItems[0].SubItems[1].Text;
            dgvGoiMon.DataSource = Controllers.GoiMonCtrl.FillDataSet_getGoiMonbyID(_MaBan).Tables[0];
            string _tenBan = lvDanhSachBan.SelectedItems[0].SubItems[0].Text;
            label3.Text = _tenBan.ToString();
            //label3.Hide();
            tinhtien();
            txtmaban.Text = _MaBan;
        }
        
        private void bntGoiMon_Click(object sender, EventArgs e)
        {
            uctMonGoi uctMG = new uctMonGoi();
            nhung(uctMG);           
        }

        private void hiểnHịBànChưaCóNgườiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BanChuaCoNguoi();
        }
        public void tinhtien()
        {
            try
            {
                int tien = dgvGoiMon.Rows.Count;
                decimal thanhtien = 0;
                for(int i=0; i<tien; i++)
                {
                    thanhtien += decimal.Parse(dgvGoiMon.Rows[i].Cells[4].Value.ToString());
                    lbtongtien.Text = thanhtien.ToString("#,###");
                    lbtongtien.ForeColor = SystemColors.HotTrack;
                    
                }
            }
            catch
            {
            }
        }
        
       
        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult ok = new DialogResult();
                ok = MessageBox.Show("Bạn có muốn tính tiền " + label3.Text + " không ", " Thông báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ok == DialogResult.Yes)
                {
                    MessageBox.Show("Tổng số tiền thanh toán của " + "" + label3.Text + "" + " là " +lbtongtien.Text ,"Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    uctMonGoi uctmg = new uctMonGoi();
                    nhung(uctmg);
                    string _IdBan = lvDanhSachBan.SelectedItems[0].SubItems[1].Text;
                    dgvGoiMon.DataSource = Controllers.GoiMonCtrl.DeleteGoiMon(_IdBan);
                    tinhtien();
                }
            }
            catch { }
            
        }

        private void hiểnThịBànCóNgườiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BanCoNguoi();
        }

        private void cậpNhậtDanhSáchBànToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uctGoiMon_Load(sender,e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showListView();
            uctMonGoi uctMG2 = new uctMonGoi();
            nhung(uctMG2);
            
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            //lbtongtien.Controls.Clear();
        }
        public String Namefa
        {
           
            get { return lbtongtien.Text; }
            set { lbtongtien.Text = value; }
        }

        private void lbtongtien_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void txtsotien_ReadOnlyChanged(object sender, EventArgs e)
        {
            
        }

        private void lbtongtien_TextChanged(object sender, EventArgs e)
        {
            txtsotien.Text = lbtongtien.Text;
        }
        public void loadcontrol()
        {           
            cmbmanv.DataSource = Models.NhanVienMod.FillDataSetNhanVien().Tables[0];
            cmbmanv.DisplayMember = "MaNV";
            cmbmanv.ValueMember = "MaNV";
        }
        private void btnthemhoadon_Click(object sender, EventArgs e)
        {

            
            
            try {
                decimal i = decimal.Parse(txtsotien.Text.ToString());
                SqlConnection conn = new SqlConnection("Data Source = .\\SQLEXPRESS; Initial Catalog = quanliquanpho; Integrated Security = true");
            conn.Open();
            SqlCommand cmd = new SqlCommand("Insert into HoaDonBan(MaHoaDon,MaNV,MaBan, TenKhachHang, NgayLap,DienGiai, SoTien) values(@MaHoaDon,@MaNV,@MaBan,@TenKhachHang,@Ngaylap,@DienGiai,@SoTien)", conn );

            cmd.Parameters.AddWithValue("@MaHoaDon", txtmahoadon.Text);
            cmd.Parameters.AddWithValue("@TenKhachHang", txtTenKH.Text);
            cmd.Parameters.AddWithValue("@MaNV", cmbmanv.Text);
            cmd.Parameters.AddWithValue("@MaBan", txtmaban.Text);
            cmd.Parameters.AddWithValue("@NgayLap", dtpngaylap.Value);
            cmd.Parameters.AddWithValue("@DienGiai", txtdiengiai.Text);
            cmd.Parameters.AddWithValue("@SoTien", i);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            conn.Close();
                MessageBox.Show("Tạo mới hóa đơn thành công !!!","Xác nhận",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Không thêm mới được hóa đơn bán !!!" + ex.Message.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtmahoadon.Text = "";
            txtdiengiai.Text = "";
            txtsotien.Text = "";
            txtmaban.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void dtpngaylap_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtsotien_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbmanv_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtmahoadon_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
