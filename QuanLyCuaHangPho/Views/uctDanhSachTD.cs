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
    public partial class uctDanhSachTD : UserControl
    {
        public uctDanhSachTD()
        {
            InitializeComponent();
        }

        private void uctDanhSachTD_Load(object sender, EventArgs e)
        {

            dgvDanhSachTD.DataSource = Models.ThucDonMod.FillDataSetThucDon().Tables[0];
            
        }

        
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
