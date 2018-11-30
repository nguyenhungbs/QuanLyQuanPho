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
    public partial class uctSearchThucDon : UserControl
    {
        public uctSearchThucDon()
        {
            InitializeComponent();
        }
        public void loadcontrol()
        {
            cmbFind.Items.Clear();
            cmbFind.Items.Add("Mã Thực Đơn");
            cmbFind.Items.Add("Tên Thực Đơn");
        }
        private void uctSearchThucDon_Load(object sender, EventArgs e)
        {
            cmbFind.Text = "Mã Thực Đơn";
            loadcontrol();
            label1.BackColor = Color.Transparent;
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            if (cmbFind.Text == "Mã Thực Đơn")
            {
                string _idThucDon = txtFind.Text.ToString();
                DataTable dt = new DataTable();
                dt = Controllers.ThucDonCtrl.FillDataSet_SearchThucDonbyID(_idThucDon).Tables[0];
                dgvDSThucDon1.DataSource = dt;
            }
            else
            {
                string _ten = txtFind.Text.ToString();
                DataTable dt = new DataTable();
                dt = Controllers.ThucDonCtrl.FillDataSet_SearchThucDonbyTen(_ten).Tables[0];
                dgvDSThucDon1.DataSource = dt;
            }
        }

        private void cmbFind_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
