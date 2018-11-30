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
    public partial class uctSearchNhaCungCap : UserControl
    {
        public uctSearchNhaCungCap()
        {
            InitializeComponent();
        }
        public void loadcontrol()
        {
            cmbFind.Items.Clear();
            cmbFind.Items.Add("ID Nhà Cung Cấp");
            cmbFind.Items.Add("Tên Nhà Cung Cấp");
        }

        private void uctSearchNhaCungCap_Load(object sender, EventArgs e)
        {
            cmbFind.Text = "ID Nhà Cung Cấp";
            loadcontrol();
            label1.BackColor = Color.Transparent;
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            if (cmbFind.Text == "ID Nhà Cung Cấp")
            {
                string _idnhacungcap = txtFind.Text.ToString();
                DataTable dt = new DataTable();
                dt = Controllers.NhaCungCapCtrl.FillDataSet_SearchNhaCungCapbyID(_idnhacungcap).Tables[0];
                dgvDSNhaCungCap.DataSource = dt;
            }
            else
            {
                string _ten = txtFind.Text.ToString();
                DataTable dt = new DataTable();
                dt = Controllers.NhaCungCapCtrl.FillDataSet_SearchNhaCungCapbyTen(_ten).Tables[0];
                dgvDSNhaCungCap.DataSource = dt;
            }
        }
    }
}
