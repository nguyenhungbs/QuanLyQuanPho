namespace QuanLyCuaHangPho.Views
{
    partial class uctSearchThucDon
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uctSearchThucDon));
            this.dgvDSThucDon1 = new System.Windows.Forms.DataGridView();
            this.MaThucDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLoaiThucDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenThucDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.cmbFind = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSThucDon1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDSThucDon1
            // 
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.dgvDSThucDon1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDSThucDon1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvDSThucDon1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSThucDon1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaThucDon,
            this.MaLoaiThucDon,
            this.TenThucDon,
            this.DonViTinh,
            this.DonGia,
            this.TrangThai});
            this.dgvDSThucDon1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvDSThucDon1.Location = new System.Drawing.Point(3, 44);
            this.dgvDSThucDon1.Name = "dgvDSThucDon1";
            this.dgvDSThucDon1.Size = new System.Drawing.Size(602, 194);
            this.dgvDSThucDon1.TabIndex = 9;
            // 
            // MaThucDon
            // 
            this.MaThucDon.DataPropertyName = "MaThucDon";
            this.MaThucDon.HeaderText = "Mã thực đơn";
            this.MaThucDon.Name = "MaThucDon";
            // 
            // MaLoaiThucDon
            // 
            this.MaLoaiThucDon.DataPropertyName = "MaLoaiThucDon";
            this.MaLoaiThucDon.HeaderText = "Mã loại thực đơn";
            this.MaLoaiThucDon.Name = "MaLoaiThucDon";
            // 
            // TenThucDon
            // 
            this.TenThucDon.DataPropertyName = "TenThucDon";
            this.TenThucDon.HeaderText = "Tên thực đơn";
            this.TenThucDon.Name = "TenThucDon";
            // 
            // DonViTinh
            // 
            this.DonViTinh.DataPropertyName = "DonViTinh";
            this.DonViTinh.HeaderText = "Đơn vị tính";
            this.DonViTinh.Name = "DonViTinh";
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "DonGia";
            this.DonGia.HeaderText = "Đơn giá";
            this.DonGia.Name = "DonGia";
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "Trạng thái";
            this.TrangThai.Name = "TrangThai";
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(256, 9);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(310, 20);
            this.txtFind.TabIndex = 7;
            this.txtFind.TextChanged += new System.EventHandler(this.txtFind_TextChanged);
            // 
            // cmbFind
            // 
            this.cmbFind.FormattingEnabled = true;
            this.cmbFind.Location = new System.Drawing.Point(129, 8);
            this.cmbFind.Name = "cmbFind";
            this.cmbFind.Size = new System.Drawing.Size(121, 21);
            this.cmbFind.TabIndex = 6;
            this.cmbFind.SelectedIndexChanged += new System.EventHandler(this.cmbFind_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(14, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tìm kiếm theo";
            // 
            // uctSearchThucDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.dgvDSThucDon1);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.cmbFind);
            this.Controls.Add(this.label1);
            this.Name = "uctSearchThucDon";
            this.Size = new System.Drawing.Size(608, 242);
            this.Load += new System.EventHandler(this.uctSearchThucDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSThucDon1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDSThucDon1;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.ComboBox cmbFind;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaThucDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLoaiThucDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenThucDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonViTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
    }
}
