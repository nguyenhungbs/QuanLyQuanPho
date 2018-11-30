namespace QuanLyCuaHangPho.Views
{
    partial class uctHoaDonNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uctHoaDonNhap));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDanhSachHDN = new System.Windows.Forms.DataGridView();
            this.MaPN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTienNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbmancc = new System.Windows.Forms.ComboBox();
            this.dtpngaylap = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txthoadonnhap = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtsotien = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnhuy1 = new System.Windows.Forms.Button();
            this.btnluu1 = new System.Windows.Forms.Button();
            this.btnxoa1 = new System.Windows.Forms.Button();
            this.btnsua1 = new System.Windows.Forms.Button();
            this.btnthem1 = new System.Windows.Forms.Button();
            this.dgvDSCTietHDN = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNguyenLieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNguyenLieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lbltongtiennhap = new System.Windows.Forms.Label();
            this.btntinhtiennhap = new System.Windows.Forms.Button();
            this.cmbmanguyenlieu = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdongia = new System.Windows.Forms.TextBox();
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.txttennguyenlieu = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachHDN)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSCTietHDN)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvDanhSachHDN);
            this.groupBox2.Location = new System.Drawing.Point(625, 46);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(674, 242);
            this.groupBox2.TabIndex = 43;
            this.groupBox2.TabStop = false;
            // 
            // dgvDanhSachHDN
            // 
            this.dgvDanhSachHDN.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvDanhSachHDN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachHDN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPN,
            this.MaNCC,
            this.NgayNhap,
            this.TongTienNhap});
            this.dgvDanhSachHDN.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvDanhSachHDN.Location = new System.Drawing.Point(6, 7);
            this.dgvDanhSachHDN.Name = "dgvDanhSachHDN";
            this.dgvDanhSachHDN.Size = new System.Drawing.Size(662, 229);
            this.dgvDanhSachHDN.TabIndex = 18;
            this.dgvDanhSachHDN.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachHDN_CellClick);
            // 
            // MaPN
            // 
            this.MaPN.DataPropertyName = "MaPN";
            this.MaPN.HeaderText = "Mã phiếu nhập";
            this.MaPN.Name = "MaPN";
            this.MaPN.Width = 120;
            // 
            // MaNCC
            // 
            this.MaNCC.DataPropertyName = "MaNCC";
            this.MaNCC.HeaderText = "Mã nhà cung cấp";
            this.MaNCC.Name = "MaNCC";
            this.MaNCC.Width = 120;
            // 
            // NgayNhap
            // 
            this.NgayNhap.DataPropertyName = "NgayNhap";
            this.NgayNhap.HeaderText = "Ngày lập";
            this.NgayNhap.Name = "NgayNhap";
            this.NgayNhap.Width = 150;
            // 
            // TongTienNhap
            // 
            this.TongTienNhap.DataPropertyName = "TongTienNhap";
            this.TongTienNhap.HeaderText = "Tổng tiền";
            this.TongTienNhap.Name = "TongTienNhap";
            this.TongTienNhap.Width = 130;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Yellow;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(841, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(230, 24);
            this.label9.TabIndex = 41;
            this.label9.Text = "Danh sách hóa đơn nhập";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Yellow;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(162, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(206, 24);
            this.label8.TabIndex = 42;
            this.label8.Text = "Quản lý hóa đơn nhập";
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(this.cmbmancc);
            this.groupBox1.Controls.Add(this.dtpngaylap);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txthoadonnhap);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtsotien);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(59, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(442, 196);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            // 
            // cmbmancc
            // 
            this.cmbmancc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbmancc.FormattingEnabled = true;
            this.cmbmancc.Location = new System.Drawing.Point(188, 53);
            this.cmbmancc.Name = "cmbmancc";
            this.cmbmancc.Size = new System.Drawing.Size(198, 24);
            this.cmbmancc.TabIndex = 3;
            // 
            // dtpngaylap
            // 
            this.dtpngaylap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpngaylap.Location = new System.Drawing.Point(188, 97);
            this.dtpngaylap.Name = "dtpngaylap";
            this.dtpngaylap.Size = new System.Drawing.Size(198, 22);
            this.dtpngaylap.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã phiếu nhập";
            // 
            // txthoadonnhap
            // 
            this.txthoadonnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthoadonnhap.Location = new System.Drawing.Point(188, 10);
            this.txthoadonnhap.Name = "txthoadonnhap";
            this.txthoadonnhap.Size = new System.Drawing.Size(198, 22);
            this.txthoadonnhap.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã nhà cung cấp";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(35, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Số tiền";
            // 
            // txtsotien
            // 
            this.txtsotien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsotien.Location = new System.Drawing.Point(188, 139);
            this.txtsotien.Name = "txtsotien";
            this.txtsotien.Size = new System.Drawing.Size(198, 22);
            this.txtsotien.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(35, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ngày lập";
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.Aquamarine;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.Location = new System.Drawing.Point(481, 258);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(97, 41);
            this.btnHuy.TabIndex = 35;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.Aquamarine;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(363, 258);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(97, 41);
            this.btnLuu.TabIndex = 36;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Aquamarine;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(247, 258);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(97, 41);
            this.btnXoa.TabIndex = 37;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Aquamarine;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(132, 258);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(97, 41);
            this.btnSua.TabIndex = 38;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Aquamarine;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(12, 258);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(97, 41);
            this.btnThem.TabIndex = 39;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(18, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 24);
            this.label2.TabIndex = 47;
            this.label2.Text = "Chi tiết hóa đơn nhập";
            // 
            // btnhuy1
            // 
            this.btnhuy1.BackColor = System.Drawing.Color.Aquamarine;
            this.btnhuy1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnhuy1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhuy1.Image = ((System.Drawing.Image)(resources.GetObject("btnhuy1.Image")));
            this.btnhuy1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnhuy1.Location = new System.Drawing.Point(1135, 251);
            this.btnhuy1.Name = "btnhuy1";
            this.btnhuy1.Size = new System.Drawing.Size(98, 41);
            this.btnhuy1.TabIndex = 49;
            this.btnhuy1.Text = "Hủy";
            this.btnhuy1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnhuy1.UseVisualStyleBackColor = false;
            this.btnhuy1.Click += new System.EventHandler(this.btnhuy1_Click);
            // 
            // btnluu1
            // 
            this.btnluu1.BackColor = System.Drawing.Color.Aquamarine;
            this.btnluu1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnluu1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnluu1.Image = ((System.Drawing.Image)(resources.GetObject("btnluu1.Image")));
            this.btnluu1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnluu1.Location = new System.Drawing.Point(1011, 251);
            this.btnluu1.Name = "btnluu1";
            this.btnluu1.Size = new System.Drawing.Size(98, 41);
            this.btnluu1.TabIndex = 50;
            this.btnluu1.Text = "Lưu";
            this.btnluu1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnluu1.UseVisualStyleBackColor = false;
            this.btnluu1.Click += new System.EventHandler(this.btnluu1_Click);
            // 
            // btnxoa1
            // 
            this.btnxoa1.BackColor = System.Drawing.Color.Aquamarine;
            this.btnxoa1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnxoa1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa1.Image = ((System.Drawing.Image)(resources.GetObject("btnxoa1.Image")));
            this.btnxoa1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnxoa1.Location = new System.Drawing.Point(885, 251);
            this.btnxoa1.Name = "btnxoa1";
            this.btnxoa1.Size = new System.Drawing.Size(98, 41);
            this.btnxoa1.TabIndex = 51;
            this.btnxoa1.Text = "Xóa";
            this.btnxoa1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnxoa1.UseVisualStyleBackColor = false;
            this.btnxoa1.Click += new System.EventHandler(this.btnxoa1_Click);
            // 
            // btnsua1
            // 
            this.btnsua1.BackColor = System.Drawing.Color.Aquamarine;
            this.btnsua1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsua1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsua1.Image = ((System.Drawing.Image)(resources.GetObject("btnsua1.Image")));
            this.btnsua1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsua1.Location = new System.Drawing.Point(759, 251);
            this.btnsua1.Name = "btnsua1";
            this.btnsua1.Size = new System.Drawing.Size(98, 41);
            this.btnsua1.TabIndex = 52;
            this.btnsua1.Text = "Sửa";
            this.btnsua1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsua1.UseVisualStyleBackColor = false;
            this.btnsua1.Click += new System.EventHandler(this.btnsua1_Click);
            // 
            // btnthem1
            // 
            this.btnthem1.BackColor = System.Drawing.Color.Aquamarine;
            this.btnthem1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnthem1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem1.Image = ((System.Drawing.Image)(resources.GetObject("btnthem1.Image")));
            this.btnthem1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthem1.Location = new System.Drawing.Point(636, 251);
            this.btnthem1.Name = "btnthem1";
            this.btnthem1.Size = new System.Drawing.Size(98, 41);
            this.btnthem1.TabIndex = 53;
            this.btnthem1.Text = "Thêm";
            this.btnthem1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnthem1.UseVisualStyleBackColor = false;
            this.btnthem1.Click += new System.EventHandler(this.button5_Click);
            // 
            // dgvDSCTietHDN
            // 
            this.dgvDSCTietHDN.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvDSCTietHDN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSCTietHDN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.MaNguyenLieu,
            this.TenNguyenLieu,
            this.SoLuong,
            this.DonGia,
            this.ThanhTien});
            this.dgvDSCTietHDN.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvDSCTietHDN.Location = new System.Drawing.Point(604, 29);
            this.dgvDSCTietHDN.Name = "dgvDSCTietHDN";
            this.dgvDSCTietHDN.ReadOnly = true;
            this.dgvDSCTietHDN.Size = new System.Drawing.Size(674, 194);
            this.dgvDSCTietHDN.TabIndex = 48;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaPN";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã phiếu nhập";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 105;
            // 
            // MaNguyenLieu
            // 
            this.MaNguyenLieu.DataPropertyName = "MaNguyenLieu";
            this.MaNguyenLieu.HeaderText = "Mã nguyên liệu";
            this.MaNguyenLieu.Name = "MaNguyenLieu";
            this.MaNguyenLieu.ReadOnly = true;
            this.MaNguyenLieu.Width = 105;
            // 
            // TenNguyenLieu
            // 
            this.TenNguyenLieu.DataPropertyName = "TenNguyenLieu";
            this.TenNguyenLieu.HeaderText = "Tên nguyên liệu";
            this.TenNguyenLieu.Name = "TenNguyenLieu";
            this.TenNguyenLieu.ReadOnly = true;
            this.TenNguyenLieu.Width = 120;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "DonGia";
            this.DonGia.HeaderText = "Đơn giá";
            this.DonGia.Name = "DonGia";
            this.DonGia.ReadOnly = true;
            // 
            // ThanhTien
            // 
            this.ThanhTien.DataPropertyName = "ThanhTien";
            this.ThanhTien.HeaderText = "Thành tiền";
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.ReadOnly = true;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.LightSalmon;
            this.groupBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox3.BackgroundImage")));
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.lbltongtiennhap);
            this.groupBox3.Controls.Add(this.btntinhtiennhap);
            this.groupBox3.Controls.Add(this.cmbmanguyenlieu);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.btnhuy1);
            this.groupBox3.Controls.Add(this.dgvDSCTietHDN);
            this.groupBox3.Controls.Add(this.txtdongia);
            this.groupBox3.Controls.Add(this.txtsoluong);
            this.groupBox3.Controls.Add(this.txttennguyenlieu);
            this.groupBox3.Controls.Add(this.btnluu1);
            this.groupBox3.Controls.Add(this.btnthem1);
            this.groupBox3.Controls.Add(this.btnxoa1);
            this.groupBox3.Controls.Add(this.btnsua1);
            this.groupBox3.Location = new System.Drawing.Point(21, 320);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1278, 356);
            this.groupBox3.TabIndex = 54;
            this.groupBox3.TabStop = false;
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Blue;
            this.label13.Location = new System.Drawing.Point(385, 206);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 16);
            this.label13.TabIndex = 57;
            this.label13.Text = "VNĐ";
            // 
            // lbltongtiennhap
            // 
            this.lbltongtiennhap.AutoSize = true;
            this.lbltongtiennhap.BackColor = System.Drawing.Color.White;
            this.lbltongtiennhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltongtiennhap.ForeColor = System.Drawing.Color.Red;
            this.lbltongtiennhap.Location = new System.Drawing.Point(280, 203);
            this.lbltongtiennhap.Name = "lbltongtiennhap";
            this.lbltongtiennhap.Size = new System.Drawing.Size(99, 20);
            this.lbltongtiennhap.TabIndex = 57;
            this.lbltongtiennhap.Text = "---------------";
            // 
            // btntinhtiennhap
            // 
            this.btntinhtiennhap.BackColor = System.Drawing.Color.Aquamarine;
            this.btntinhtiennhap.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btntinhtiennhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntinhtiennhap.Image = ((System.Drawing.Image)(resources.GetObject("btntinhtiennhap.Image")));
            this.btntinhtiennhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btntinhtiennhap.Location = new System.Drawing.Point(270, 251);
            this.btntinhtiennhap.Name = "btntinhtiennhap";
            this.btntinhtiennhap.Size = new System.Drawing.Size(119, 41);
            this.btntinhtiennhap.TabIndex = 56;
            this.btntinhtiennhap.Text = "Tính tiền";
            this.btntinhtiennhap.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btntinhtiennhap.UseVisualStyleBackColor = false;
            this.btntinhtiennhap.Click += new System.EventHandler(this.btntinhtiennhap_Click);
            // 
            // cmbmanguyenlieu
            // 
            this.cmbmanguyenlieu.FormattingEnabled = true;
            this.cmbmanguyenlieu.Location = new System.Drawing.Point(247, 58);
            this.cmbmanguyenlieu.Name = "cmbmanguyenlieu";
            this.cmbmanguyenlieu.Size = new System.Drawing.Size(198, 21);
            this.cmbmanguyenlieu.TabIndex = 55;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(96, 169);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 16);
            this.label11.TabIndex = 54;
            this.label11.Text = "Đơn giá";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(96, 132);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 16);
            this.label10.TabIndex = 54;
            this.label10.Text = "Số lượng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(94, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 16);
            this.label5.TabIndex = 54;
            this.label5.Text = "Tên nguyên liệu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(96, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 16);
            this.label4.TabIndex = 54;
            this.label4.Text = "Mã nguyên liệu";
            // 
            // txtdongia
            // 
            this.txtdongia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdongia.Location = new System.Drawing.Point(247, 169);
            this.txtdongia.Name = "txtdongia";
            this.txtdongia.Size = new System.Drawing.Size(198, 22);
            this.txtdongia.TabIndex = 1;
            // 
            // txtsoluong
            // 
            this.txtsoluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsoluong.Location = new System.Drawing.Point(247, 126);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(198, 22);
            this.txtsoluong.TabIndex = 1;
            // 
            // txttennguyenlieu
            // 
            this.txttennguyenlieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttennguyenlieu.Location = new System.Drawing.Point(247, 91);
            this.txttennguyenlieu.Name = "txttennguyenlieu";
            this.txttennguyenlieu.Size = new System.Drawing.Size(198, 22);
            this.txttennguyenlieu.TabIndex = 1;
            // 
            // uctHoaDonNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Name = "uctHoaDonNhap";
            this.Size = new System.Drawing.Size(1352, 740);
            this.Load += new System.EventHandler(this.uctHoaDonNhap_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachHDN)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSCTietHDN)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvDanhSachHDN;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbmancc;
        private System.Windows.Forms.DateTimePicker dtpngaylap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txthoadonnhap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtsotien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnhuy1;
        private System.Windows.Forms.Button btnluu1;
        private System.Windows.Forms.Button btnxoa1;
        private System.Windows.Forms.Button btnsua1;
        private System.Windows.Forms.Button btnthem1;
        private System.Windows.Forms.DataGridView dgvDSCTietHDN;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtsoluong;
        private System.Windows.Forms.TextBox txttennguyenlieu;
        private System.Windows.Forms.TextBox txtdongia;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNguyenLieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNguyenLieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.ComboBox cmbmanguyenlieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPN;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTienNhap;
        private System.Windows.Forms.Button btntinhtiennhap;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbltongtiennhap;
    }
}
