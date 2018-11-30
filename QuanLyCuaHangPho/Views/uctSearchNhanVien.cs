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
    public partial class uctSearchNhanVien : UserControl
    {
        public uctSearchNhanVien()
        {
            InitializeComponent();
        }
        public void loadcontrol()
        {
            cmbFind.Items.Clear();
            cmbFind.Items.Add("ID Nhân Viên");
            cmbFind.Items.Add("Tên Nhân Viên");
        }

        private void uctSearchNhanVien_Load(object sender, EventArgs e)
        {
            cmbFind.Text="ID Nhân Viên";
            loadcontrol();
            label1.BackColor = Color.Transparent;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            
        }

        private void btnFind_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            if (cmbFind.Text == "ID Nhân Viên")
            {
                string _idNhanVien = txtFind.Text.ToString();
                DataTable dt = new DataTable();
                dt = Controllers.NhanVienCtrl.FillDataSet_SearchNhanVienbyID(_idNhanVien).Tables[0];
                dgvDSNhanVien.DataSource = dt;
            }
            else
            {
                string _ten = txtFind.Text.ToString();
                DataTable dt = new DataTable();
                dt = Controllers.NhanVienCtrl.FillDataSet_SearchNhanVienbyTen(_ten).Tables[0];
                dgvDSNhanVien.DataSource = dt;
            }
        }
    }
}
