namespace QuanLyCuaHangPho.Views
{
    partial class uctThongKeDoanhThu
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uctThongKeDoanhThu));
            this.thongKeThangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanliquanphoDataSet1 = new QuanLyCuaHangPho.QuanliquanphoDataSet1();
            this.thongKeQuyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanliquanphoDataSet100 = new QuanLyCuaHangPho.QuanliquanphoDataSet100();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.thongKeThangTableAdapter = new QuanLyCuaHangPho.QuanliquanphoDataSet1TableAdapters.ThongKeThangTableAdapter();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.thongKeQuyTableAdapter = new QuanLyCuaHangPho.QuanliquanphoDataSet100TableAdapters.ThongKeQuyTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.thongKeThangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanliquanphoDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongKeQuyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanliquanphoDataSet100)).BeginInit();
            this.SuspendLayout();
            // 
            // thongKeThangBindingSource
            // 
            this.thongKeThangBindingSource.DataMember = "ThongKeThang";
            this.thongKeThangBindingSource.DataSource = this.quanliquanphoDataSet1;
            // 
            // quanliquanphoDataSet1
            // 
            this.quanliquanphoDataSet1.DataSetName = "QuanliquanphoDataSet1";
            this.quanliquanphoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // thongKeQuyBindingSource
            // 
            this.thongKeQuyBindingSource.DataMember = "ThongKeQuy";
            this.thongKeQuyBindingSource.DataSource = this.quanliquanphoDataSet100;
            // 
            // quanliquanphoDataSet100
            // 
            this.quanliquanphoDataSet100.DataSetName = "QuanliquanphoDataSet100";
            this.quanliquanphoDataSet100.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSetKKK";
            reportDataSource1.Value = this.thongKeThangBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyCuaHangPho.Views.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 16);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(663, 548);
            this.reportViewer1.TabIndex = 8;
            // 
            // thongKeThangTableAdapter
            // 
            this.thongKeThangTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer2
            // 
            reportDataSource2.Name = "DataSetquy";
            reportDataSource2.Value = this.thongKeQuyBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "QuanLyCuaHangPho.Views.Report1.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(672, 16);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(672, 548);
            this.reportViewer2.TabIndex = 9;
            this.reportViewer2.Load += new System.EventHandler(this.reportViewer2_Load);
            // 
            // thongKeQuyTableAdapter
            // 
            this.thongKeQuyTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Aqua;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(599, 580);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 43);
            this.button1.TabIndex = 10;
            this.button1.Text = "Refresh";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // uctThongKeDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reportViewer2);
            this.Controls.Add(this.reportViewer1);
            this.Name = "uctThongKeDoanhThu";
            this.Size = new System.Drawing.Size(1357, 710);
            this.Load += new System.EventHandler(this.uctThongKeDoanhThu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.thongKeThangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanliquanphoDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongKeQuyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanliquanphoDataSet100)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private QuanliquanphoDataSet1 quanliquanphoDataSet1;
        private System.Windows.Forms.BindingSource thongKeThangBindingSource;
        private QuanliquanphoDataSet1TableAdapters.ThongKeThangTableAdapter thongKeThangTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.BindingSource thongKeQuyBindingSource;
        private QuanliquanphoDataSet100 quanliquanphoDataSet100;
        private QuanliquanphoDataSet100TableAdapters.ThongKeQuyTableAdapter thongKeQuyTableAdapter;
        private System.Windows.Forms.Button button1;
    }
}
