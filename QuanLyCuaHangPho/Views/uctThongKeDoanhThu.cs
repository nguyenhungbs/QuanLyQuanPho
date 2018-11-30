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
    public partial class uctThongKeDoanhThu : UserControl
    {
        public uctThongKeDoanhThu()
        {
            InitializeComponent();
        }
        public static uctThongKeDoanhThu uctThongKe = new uctThongKeDoanhThu();
        

        public void Hienthi1()
        {
            try
            {                
                this.thongKeThangTableAdapter.Fill(this.quanliquanphoDataSet1.ThongKeThang);
                this.reportViewer1.RefreshReport();
            }
            catch { };
        }
        public void Hienthi2()
        {
            try
            {
                this.thongKeQuyTableAdapter.Fill(this.quanliquanphoDataSet100.ThongKeQuy);
                this.reportViewer2.RefreshReport();
            }
            catch { };
        }
        private void uctThongKeDoanhThu_Load(object sender, EventArgs e)
        {           
            Hienthi1();           
            Hienthi2();                                  
        }

        private void chart1_Click(object sender, EventArgs e)
        {
            
        }

        
        
            

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           

        }

        private void thongKeThangBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void quanliquanphoDataSetXBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Hienthi1();
            Hienthi2();
        }

        private void reportViewer2_Load(object sender, EventArgs e)
        {

        }
    }
}
