
namespace GUI
{
    partial class Form_Main
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.grbChucNang = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSum_SoLuong = new System.Windows.Forms.TextBox();
            this.txtSum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grbSanPham = new System.Windows.Forms.GroupBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.dtgv_SanPham = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGia_Order = new System.Windows.Forms.TextBox();
            this.txtTenMon_Order = new System.Windows.Forms.TextBox();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.cbbTheLoai = new System.Windows.Forms.ComboBox();
            this.picTimKiem = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grbKhachHang = new System.Windows.Forms.GroupBox();
            this.dtgv_Order = new System.Windows.Forms.DataGridView();
            this.theLoaiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_HangHoa = new GUI.DataSet_HangHoa();
            this.pic_Logo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPos = new System.Windows.Forms.Label();
            this.menuStrip_FMain = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem_FMain = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsDoiMau = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsMauXanh = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsMauDo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsMauVang = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsDaTroi = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsMauCam = new System.Windows.Forms.ToolStripMenuItem();
            this.dangnhapStrip = new System.Windows.Forms.MenuStrip();
            this.dangXuaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsDangXuat_FMain = new System.Windows.Forms.ToolStripMenuItem();
            this.trangQuanLyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.theLoaiTableAdapter = new GUI.DataSet_HangHoaTableAdapters.TheLoaiTableAdapter();
            this.btnThanhToan = new GUI.CT_Button();
            this.btnXoaHet = new GUI.CT_Button();
            this.btnTamTinh = new GUI.CT_Button();
            this.btnCheBien = new GUI.CT_Button();
            this.btnTongTien = new GUI.CT_Button();
            this.btnHienThi = new GUI.CT_Button();
            this.btn_Banh = new GUI.CT_Button();
            this.btn_NuocUong = new GUI.CT_Button();
            this.btn_Order = new GUI.CT_Button();
            this.grbChucNang.SuspendLayout();
            this.grbSanPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_SanPham)).BeginInit();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTimKiem)).BeginInit();
            this.grbKhachHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Order)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.theLoaiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_HangHoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Logo)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip_FMain.SuspendLayout();
            this.dangnhapStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbChucNang
            // 
            this.grbChucNang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbChucNang.BackColor = System.Drawing.SystemColors.Control;
            this.grbChucNang.Controls.Add(this.label6);
            this.grbChucNang.Controls.Add(this.label1);
            this.grbChucNang.Controls.Add(this.txtSum_SoLuong);
            this.grbChucNang.Controls.Add(this.txtSum);
            this.grbChucNang.Controls.Add(this.btnThanhToan);
            this.grbChucNang.Controls.Add(this.label2);
            this.grbChucNang.Controls.Add(this.btnXoaHet);
            this.grbChucNang.Controls.Add(this.btnTamTinh);
            this.grbChucNang.Controls.Add(this.btnCheBien);
            this.grbChucNang.Controls.Add(this.btnTongTien);
            this.grbChucNang.Location = new System.Drawing.Point(-1, 479);
            this.grbChucNang.Name = "grbChucNang";
            this.grbChucNang.Size = new System.Drawing.Size(562, 184);
            this.grbChucNang.TabIndex = 7;
            this.grbChucNang.TabStop = false;
            this.grbChucNang.Text = "Chức Năng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(319, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 28;
            this.label6.Text = "Tổng Tiền";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(125, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 27;
            this.label1.Text = "Số Lượng";
            // 
            // txtSum_SoLuong
            // 
            this.txtSum_SoLuong.BackColor = System.Drawing.SystemColors.Control;
            this.txtSum_SoLuong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSum_SoLuong.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSum_SoLuong.Location = new System.Drawing.Point(198, 24);
            this.txtSum_SoLuong.Name = "txtSum_SoLuong";
            this.txtSum_SoLuong.Size = new System.Drawing.Size(100, 15);
            this.txtSum_SoLuong.TabIndex = 26;
            this.txtSum_SoLuong.Text = "0";
            // 
            // txtSum
            // 
            this.txtSum.BackColor = System.Drawing.SystemColors.Control;
            this.txtSum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSum.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSum.Location = new System.Drawing.Point(392, 23);
            this.txtSum.Name = "txtSum";
            this.txtSum.Size = new System.Drawing.Size(100, 15);
            this.txtSum.TabIndex = 25;
            this.txtSum.Text = "0";
            this.txtSum.TextChanged += new System.EventHandler(this.txtSum_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(201, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 9;
            // 
            // grbSanPham
            // 
            this.grbSanPham.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbSanPham.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.grbSanPham.Controls.Add(this.txtSoLuong);
            this.grbSanPham.Controls.Add(this.dtgv_SanPham);
            this.grbSanPham.Controls.Add(this.label5);
            this.grbSanPham.Controls.Add(this.label4);
            this.grbSanPham.Controls.Add(this.txtGia_Order);
            this.grbSanPham.Controls.Add(this.txtTenMon_Order);
            this.grbSanPham.Controls.Add(this.groupBox);
            this.grbSanPham.Controls.Add(this.btn_Order);
            this.grbSanPham.Controls.Add(this.label3);
            this.grbSanPham.Location = new System.Drawing.Point(569, 68);
            this.grbSanPham.Name = "grbSanPham";
            this.grbSanPham.Size = new System.Drawing.Size(505, 595);
            this.grbSanPham.TabIndex = 6;
            this.grbSanPham.TabStop = false;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Location = new System.Drawing.Point(90, 548);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(156, 22);
            this.txtSoLuong.TabIndex = 19;
            // 
            // dtgv_SanPham
            // 
            this.dtgv_SanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_SanPham.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dtgv_SanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_SanPham.Location = new System.Drawing.Point(6, 123);
            this.dtgv_SanPham.Name = "dtgv_SanPham";
            this.dtgv_SanPham.Size = new System.Drawing.Size(493, 380);
            this.dtgv_SanPham.TabIndex = 0;
            this.dtgv_SanPham.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_SanPham_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(283, 520);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Giá";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 520);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Tên SP";
            // 
            // txtGia_Order
            // 
            this.txtGia_Order.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGia_Order.Location = new System.Drawing.Point(317, 517);
            this.txtGia_Order.Name = "txtGia_Order";
            this.txtGia_Order.Size = new System.Drawing.Size(182, 22);
            this.txtGia_Order.TabIndex = 16;
            // 
            // txtTenMon_Order
            // 
            this.txtTenMon_Order.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenMon_Order.Location = new System.Drawing.Point(77, 517);
            this.txtTenMon_Order.Name = "txtTenMon_Order";
            this.txtTenMon_Order.Size = new System.Drawing.Size(169, 22);
            this.txtTenMon_Order.TabIndex = 15;
            // 
            // groupBox
            // 
            this.groupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox.Controls.Add(this.btnHienThi);
            this.groupBox.Controls.Add(this.txtTimKiem);
            this.groupBox.Controls.Add(this.btn_Banh);
            this.groupBox.Controls.Add(this.btn_NuocUong);
            this.groupBox.Controls.Add(this.cbbTheLoai);
            this.groupBox.Controls.Add(this.picTimKiem);
            this.groupBox.Location = new System.Drawing.Point(6, 19);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(499, 98);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            this.groupBox.Enter += new System.EventHandler(this.groupBox_Enter);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTimKiem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(58, 65);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(182, 22);
            this.txtTimKiem.TabIndex = 12;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // cbbTheLoai
            // 
            this.cbbTheLoai.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTheLoai.FormattingEnabled = true;
            this.cbbTheLoai.Location = new System.Drawing.Point(283, 65);
            this.cbbTheLoai.Name = "cbbTheLoai";
            this.cbbTheLoai.Size = new System.Drawing.Size(204, 24);
            this.cbbTheLoai.TabIndex = 0;
            this.cbbTheLoai.SelectedIndexChanged += new System.EventHandler(this.cbbTheLoai_SelectedIndexChanged);
            // 
            // picTimKiem
            // 
            this.picTimKiem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.picTimKiem.Image = global::GUI.Properties.Resources.TimKiem;
            this.picTimKiem.Location = new System.Drawing.Point(17, 65);
            this.picTimKiem.Name = "picTimKiem";
            this.picTimKiem.Size = new System.Drawing.Size(35, 24);
            this.picTimKiem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTimKiem.TabIndex = 1;
            this.picTimKiem.TabStop = false;
            this.picTimKiem.Click += new System.EventHandler(this.picTimKiem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 551);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Số Lượng";
            // 
            // grbKhachHang
            // 
            this.grbKhachHang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbKhachHang.BackColor = System.Drawing.SystemColors.ControlLight;
            this.grbKhachHang.Controls.Add(this.dtgv_Order);
            this.grbKhachHang.Location = new System.Drawing.Point(-1, 68);
            this.grbKhachHang.Name = "grbKhachHang";
            this.grbKhachHang.Size = new System.Drawing.Size(564, 405);
            this.grbKhachHang.TabIndex = 8;
            this.grbKhachHang.TabStop = false;
            this.grbKhachHang.Text = "khách hàng";
            // 
            // dtgv_Order
            // 
            this.dtgv_Order.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_Order.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dtgv_Order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_Order.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgv_Order.Location = new System.Drawing.Point(3, 16);
            this.dtgv_Order.Name = "dtgv_Order";
            this.dtgv_Order.Size = new System.Drawing.Size(558, 386);
            this.dtgv_Order.TabIndex = 0;
            this.dtgv_Order.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_Order_CellContentClick);
            // 
            // theLoaiBindingSource
            // 
            this.theLoaiBindingSource.DataMember = "TheLoai";
            this.theLoaiBindingSource.DataSource = this.dataSet_HangHoa;
            // 
            // dataSet_HangHoa
            // 
            this.dataSet_HangHoa.DataSetName = "DataSet_HangHoa";
            this.dataSet_HangHoa.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pic_Logo
            // 
            this.pic_Logo.Image = global::GUI.Properties.Resources.Pos;
            this.pic_Logo.Location = new System.Drawing.Point(0, 7);
            this.pic_Logo.Name = "pic_Logo";
            this.pic_Logo.Size = new System.Drawing.Size(91, 46);
            this.pic_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Logo.TabIndex = 0;
            this.pic_Logo.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGreen;
            this.panel1.Controls.Add(this.pic_Logo);
            this.panel1.Controls.Add(this.lblPos);
            this.panel1.Controls.Add(this.menuStrip_FMain);
            this.panel1.Controls.Add(this.dangnhapStrip);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1074, 66);
            this.panel1.TabIndex = 5;
            // 
            // lblPos
            // 
            this.lblPos.AutoSize = true;
            this.lblPos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPos.Location = new System.Drawing.Point(97, 24);
            this.lblPos.Name = "lblPos";
            this.lblPos.Size = new System.Drawing.Size(36, 18);
            this.lblPos.TabIndex = 0;
            this.lblPos.Text = "Pos";
            // 
            // menuStrip_FMain
            // 
            this.menuStrip_FMain.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.menuStrip_FMain.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip_FMain.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip_FMain.ImageScalingSize = new System.Drawing.Size(29, 38);
            this.menuStrip_FMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_FMain});
            this.menuStrip_FMain.Location = new System.Drawing.Point(602, 7);
            this.menuStrip_FMain.Name = "menuStrip_FMain";
            this.menuStrip_FMain.Size = new System.Drawing.Size(68, 46);
            this.menuStrip_FMain.TabIndex = 3;
            this.menuStrip_FMain.Text = "menuStrip1";
            this.menuStrip_FMain.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // toolStripMenuItem_FMain
            // 
            this.toolStripMenuItem_FMain.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolsDoiMau});
            this.toolStripMenuItem_FMain.Image = global::GUI.Properties.Resources.Menu;
            this.toolStripMenuItem_FMain.Name = "toolStripMenuItem_FMain";
            this.toolStripMenuItem_FMain.Size = new System.Drawing.Size(60, 42);
            this.toolStripMenuItem_FMain.Text = "    ";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(149, 22);
            this.toolStripMenuItem2.Text = "Đăng Xuất";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(149, 22);
            this.toolStripMenuItem3.Text = "Trang Quản Lý";
            // 
            // toolsDoiMau
            // 
            this.toolsDoiMau.AutoSize = false;
            this.toolsDoiMau.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsMauXanh,
            this.toolsMauDo,
            this.toolsMauVang,
            this.toolsDaTroi,
            this.toolsMauCam});
            this.toolsDoiMau.Name = "toolsDoiMau";
            this.toolsDoiMau.Size = new System.Drawing.Size(180, 22);
            this.toolsDoiMau.Text = "Đổi Màu";
            this.toolsDoiMau.Click += new System.EventHandler(this.toolsDoiMau_Click);
            // 
            // toolsMauXanh
            // 
            this.toolsMauXanh.AutoSize = false;
            this.toolsMauXanh.Image = global::GUI.Properties.Resources.MauXanh;
            this.toolsMauXanh.Name = "toolsMauXanh";
            this.toolsMauXanh.Size = new System.Drawing.Size(193, 44);
            this.toolsMauXanh.Text = "  ";
            this.toolsMauXanh.ToolTipText = "Light Green";
            this.toolsMauXanh.Click += new System.EventHandler(this.toolsMauXanh_Click);
            // 
            // toolsMauDo
            // 
            this.toolsMauDo.AutoSize = false;
            this.toolsMauDo.AutoToolTip = true;
            this.toolsMauDo.Image = global::GUI.Properties.Resources.MauDo;
            this.toolsMauDo.Name = "toolsMauDo";
            this.toolsMauDo.Size = new System.Drawing.Size(284, 58);
            this.toolsMauDo.Text = "  ";
            this.toolsMauDo.ToolTipText = "  Red";
            this.toolsMauDo.Click += new System.EventHandler(this.toolsMauDo_Click);
            // 
            // toolsMauVang
            // 
            this.toolsMauVang.AutoToolTip = true;
            this.toolsMauVang.Image = global::GUI.Properties.Resources.MauVang;
            this.toolsMauVang.Name = "toolsMauVang";
            this.toolsMauVang.Size = new System.Drawing.Size(80, 22);
            this.toolsMauVang.ToolTipText = "Light Yellow";
            this.toolsMauVang.Click += new System.EventHandler(this.toolsMauVang_Click);
            // 
            // toolsDaTroi
            // 
            this.toolsDaTroi.AutoSize = false;
            this.toolsDaTroi.AutoToolTip = true;
            this.toolsDaTroi.Image = global::GUI.Properties.Resources.MauXanhDaTroi;
            this.toolsDaTroi.Name = "toolsDaTroi";
            this.toolsDaTroi.Size = new System.Drawing.Size(225, 48);
            this.toolsDaTroi.ToolTipText = "Blue Sky";
            this.toolsDaTroi.Click += new System.EventHandler(this.toolsDaTroi_Click);
            // 
            // toolsMauCam
            // 
            this.toolsMauCam.AutoToolTip = true;
            this.toolsMauCam.Image = global::GUI.Properties.Resources.mau;
            this.toolsMauCam.Name = "toolsMauCam";
            this.toolsMauCam.Size = new System.Drawing.Size(80, 22);
            this.toolsMauCam.ToolTipText = "Orange";
            this.toolsMauCam.Click += new System.EventHandler(this.toolsMauCam_Click);
            // 
            // dangnhapStrip
            // 
            this.dangnhapStrip.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dangnhapStrip.BackColor = System.Drawing.Color.Transparent;
            this.dangnhapStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.dangnhapStrip.ImageScalingSize = new System.Drawing.Size(23, 32);
            this.dangnhapStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dangXuaToolStripMenuItem});
            this.dangnhapStrip.Location = new System.Drawing.Point(779, 13);
            this.dangnhapStrip.Name = "dangnhapStrip";
            this.dangnhapStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dangnhapStrip.Size = new System.Drawing.Size(62, 40);
            this.dangnhapStrip.TabIndex = 2;
            this.dangnhapStrip.Text = "menuStrip2";
            // 
            // dangXuaToolStripMenuItem
            // 
            this.dangXuaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsDangXuat_FMain,
            this.trangQuanLyToolStripMenuItem});
            this.dangXuaToolStripMenuItem.Image = global::GUI.Properties.Resources.logo_login;
            this.dangXuaToolStripMenuItem.Name = "dangXuaToolStripMenuItem";
            this.dangXuaToolStripMenuItem.Size = new System.Drawing.Size(54, 36);
            this.dangXuaToolStripMenuItem.Text = "    ";
            // 
            // toolsDangXuat_FMain
            // 
            this.toolsDangXuat_FMain.Name = "toolsDangXuat_FMain";
            this.toolsDangXuat_FMain.Size = new System.Drawing.Size(149, 22);
            this.toolsDangXuat_FMain.Text = "Đăng Xuất";
            this.toolsDangXuat_FMain.Click += new System.EventHandler(this.toolsDangXuat_FMain_Click);
            // 
            // trangQuanLyToolStripMenuItem
            // 
            this.trangQuanLyToolStripMenuItem.Name = "trangQuanLyToolStripMenuItem";
            this.trangQuanLyToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.trangQuanLyToolStripMenuItem.Text = "Trang Quản Lý";
            this.trangQuanLyToolStripMenuItem.Click += new System.EventHandler(this.trangQuanLyToolStripMenuItem_Click);
            // 
            // theLoaiTableAdapter
            // 
            this.theLoaiTableAdapter.ClearBeforeFill = true;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThanhToan.BackColor = System.Drawing.Color.LightGreen;
            this.btnThanhToan.BackgroundColor = System.Drawing.Color.LightGreen;
            this.btnThanhToan.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnThanhToan.BorderRadius = 7;
            this.btnThanhToan.BorderSize = 0;
            this.btnThanhToan.FlatAppearance.BorderSize = 0;
            this.btnThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThanhToan.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.ForeColor = System.Drawing.SystemColors.Control;
            this.btnThanhToan.Location = new System.Drawing.Point(386, 58);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(159, 103);
            this.btnThanhToan.TabIndex = 24;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.TextColor = System.Drawing.SystemColors.Control;
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnXoaHet
            // 
            this.btnXoaHet.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnXoaHet.BackColor = System.Drawing.Color.LightGreen;
            this.btnXoaHet.BackgroundColor = System.Drawing.Color.LightGreen;
            this.btnXoaHet.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnXoaHet.BorderRadius = 7;
            this.btnXoaHet.BorderSize = 0;
            this.btnXoaHet.FlatAppearance.BorderSize = 0;
            this.btnXoaHet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaHet.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaHet.ForeColor = System.Drawing.Color.White;
            this.btnXoaHet.Location = new System.Drawing.Point(11, 117);
            this.btnXoaHet.Name = "btnXoaHet";
            this.btnXoaHet.Size = new System.Drawing.Size(167, 44);
            this.btnXoaHet.TabIndex = 7;
            this.btnXoaHet.Text = "Xóa Hết";
            this.btnXoaHet.TextColor = System.Drawing.Color.White;
            this.btnXoaHet.UseVisualStyleBackColor = false;
            this.btnXoaHet.Click += new System.EventHandler(this.btnXoaHet_Click);
            // 
            // btnTamTinh
            // 
            this.btnTamTinh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTamTinh.BackColor = System.Drawing.Color.LightGreen;
            this.btnTamTinh.BackgroundColor = System.Drawing.Color.LightGreen;
            this.btnTamTinh.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnTamTinh.BorderRadius = 7;
            this.btnTamTinh.BorderSize = 0;
            this.btnTamTinh.FlatAppearance.BorderSize = 0;
            this.btnTamTinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTamTinh.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTamTinh.ForeColor = System.Drawing.Color.White;
            this.btnTamTinh.Location = new System.Drawing.Point(198, 117);
            this.btnTamTinh.Name = "btnTamTinh";
            this.btnTamTinh.Size = new System.Drawing.Size(167, 44);
            this.btnTamTinh.TabIndex = 3;
            this.btnTamTinh.Text = "Tạm Tính";
            this.btnTamTinh.TextColor = System.Drawing.Color.White;
            this.btnTamTinh.UseVisualStyleBackColor = false;
            // 
            // btnCheBien
            // 
            this.btnCheBien.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCheBien.BackColor = System.Drawing.Color.LightGreen;
            this.btnCheBien.BackgroundColor = System.Drawing.Color.LightGreen;
            this.btnCheBien.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCheBien.BorderRadius = 7;
            this.btnCheBien.BorderSize = 0;
            this.btnCheBien.FlatAppearance.BorderSize = 0;
            this.btnCheBien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheBien.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheBien.ForeColor = System.Drawing.Color.White;
            this.btnCheBien.Location = new System.Drawing.Point(11, 60);
            this.btnCheBien.Name = "btnCheBien";
            this.btnCheBien.Size = new System.Drawing.Size(167, 44);
            this.btnCheBien.TabIndex = 1;
            this.btnCheBien.Text = "Báo Chế Biến";
            this.btnCheBien.TextColor = System.Drawing.Color.White;
            this.btnCheBien.UseVisualStyleBackColor = false;
            this.btnCheBien.Click += new System.EventHandler(this.btnCheBien_Click);
            // 
            // btnTongTien
            // 
            this.btnTongTien.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTongTien.BackColor = System.Drawing.Color.LightGreen;
            this.btnTongTien.BackgroundColor = System.Drawing.Color.LightGreen;
            this.btnTongTien.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnTongTien.BorderRadius = 7;
            this.btnTongTien.BorderSize = 0;
            this.btnTongTien.FlatAppearance.BorderSize = 0;
            this.btnTongTien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTongTien.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTongTien.ForeColor = System.Drawing.Color.White;
            this.btnTongTien.Location = new System.Drawing.Point(198, 60);
            this.btnTongTien.Name = "btnTongTien";
            this.btnTongTien.Size = new System.Drawing.Size(167, 44);
            this.btnTongTien.TabIndex = 0;
            this.btnTongTien.Text = "Tổng Tiền";
            this.btnTongTien.TextColor = System.Drawing.Color.White;
            this.btnTongTien.UseVisualStyleBackColor = false;
            this.btnTongTien.Click += new System.EventHandler(this.btnTongTien_Click);
            // 
            // btnHienThi
            // 
            this.btnHienThi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnHienThi.BackColor = System.Drawing.Color.LightGreen;
            this.btnHienThi.BackgroundColor = System.Drawing.Color.LightGreen;
            this.btnHienThi.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnHienThi.BorderRadius = 7;
            this.btnHienThi.BorderSize = 0;
            this.btnHienThi.FlatAppearance.BorderSize = 0;
            this.btnHienThi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHienThi.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHienThi.ForeColor = System.Drawing.Color.White;
            this.btnHienThi.Location = new System.Drawing.Point(343, 15);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(144, 40);
            this.btnHienThi.TabIndex = 9;
            this.btnHienThi.Text = "Tất cả sản phẩm";
            this.btnHienThi.TextColor = System.Drawing.Color.White;
            this.btnHienThi.UseVisualStyleBackColor = false;
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
            // 
            // btn_Banh
            // 
            this.btn_Banh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Banh.BackColor = System.Drawing.Color.LightGreen;
            this.btn_Banh.BackgroundColor = System.Drawing.Color.LightGreen;
            this.btn_Banh.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Banh.BorderRadius = 7;
            this.btn_Banh.BorderSize = 0;
            this.btn_Banh.FlatAppearance.BorderSize = 0;
            this.btn_Banh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Banh.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Banh.ForeColor = System.Drawing.Color.White;
            this.btn_Banh.Location = new System.Drawing.Point(184, 15);
            this.btn_Banh.Name = "btn_Banh";
            this.btn_Banh.Size = new System.Drawing.Size(144, 40);
            this.btn_Banh.TabIndex = 11;
            this.btn_Banh.Text = "Bánh";
            this.btn_Banh.TextColor = System.Drawing.Color.White;
            this.btn_Banh.UseVisualStyleBackColor = false;
            this.btn_Banh.Click += new System.EventHandler(this.btn_Banh_Click);
            // 
            // btn_NuocUong
            // 
            this.btn_NuocUong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_NuocUong.BackColor = System.Drawing.Color.LightGreen;
            this.btn_NuocUong.BackgroundColor = System.Drawing.Color.LightGreen;
            this.btn_NuocUong.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_NuocUong.BorderRadius = 7;
            this.btn_NuocUong.BorderSize = 0;
            this.btn_NuocUong.FlatAppearance.BorderSize = 0;
            this.btn_NuocUong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NuocUong.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NuocUong.ForeColor = System.Drawing.Color.White;
            this.btn_NuocUong.Location = new System.Drawing.Point(17, 15);
            this.btn_NuocUong.Name = "btn_NuocUong";
            this.btn_NuocUong.Size = new System.Drawing.Size(144, 40);
            this.btn_NuocUong.TabIndex = 10;
            this.btn_NuocUong.Text = "Nước Uống";
            this.btn_NuocUong.TextColor = System.Drawing.Color.White;
            this.btn_NuocUong.UseVisualStyleBackColor = false;
            this.btn_NuocUong.Click += new System.EventHandler(this.btn_NuocUong_Click);
            // 
            // btn_Order
            // 
            this.btn_Order.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Order.BackColor = System.Drawing.Color.LightGreen;
            this.btn_Order.BackgroundColor = System.Drawing.Color.LightGreen;
            this.btn_Order.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Order.BorderRadius = 7;
            this.btn_Order.BorderSize = 0;
            this.btn_Order.FlatAppearance.BorderSize = 0;
            this.btn_Order.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Order.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Order.ForeColor = System.Drawing.Color.White;
            this.btn_Order.Location = new System.Drawing.Point(343, 545);
            this.btn_Order.Name = "btn_Order";
            this.btn_Order.Size = new System.Drawing.Size(144, 36);
            this.btn_Order.TabIndex = 8;
            this.btn_Order.Text = "Thêm";
            this.btn_Order.TextColor = System.Drawing.Color.White;
            this.btn_Order.UseVisualStyleBackColor = false;
            this.btn_Order.Click += new System.EventHandler(this.btn_Order_Click_1);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 661);
            this.Controls.Add(this.grbChucNang);
            this.Controls.Add(this.grbSanPham);
            this.Controls.Add(this.grbKhachHang);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1090, 700);
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pos";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.grbChucNang.ResumeLayout(false);
            this.grbChucNang.PerformLayout();
            this.grbSanPham.ResumeLayout(false);
            this.grbSanPham.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_SanPham)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTimKiem)).EndInit();
            this.grbKhachHang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Order)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.theLoaiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_HangHoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Logo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip_FMain.ResumeLayout(false);
            this.menuStrip_FMain.PerformLayout();
            this.dangnhapStrip.ResumeLayout(false);
            this.dangnhapStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbChucNang;
        private System.Windows.Forms.ToolStripMenuItem trangQuanLyToolStripMenuItem;
        private System.Windows.Forms.GroupBox grbSanPham;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.ToolStripMenuItem toolsDangXuat_FMain;
        private System.Windows.Forms.GroupBox grbKhachHang;
        private System.Windows.Forms.ToolStripMenuItem dangXuaToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip_FMain;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_FMain;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolsDoiMau;
        private System.Windows.Forms.ToolStripMenuItem toolsMauXanh;
        private System.Windows.Forms.ToolStripMenuItem toolsMauDo;
        private System.Windows.Forms.ToolStripMenuItem toolsMauVang;
        private System.Windows.Forms.ToolStripMenuItem toolsDaTroi;
        private System.Windows.Forms.ToolStripMenuItem toolsMauCam;
        private System.Windows.Forms.PictureBox picTimKiem;
        private System.Windows.Forms.MenuStrip dangnhapStrip;
        private CT_Button btnTamTinh;
        private CT_Button btnCheBien;
        private CT_Button btnTongTien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPos;
        private System.Windows.Forms.PictureBox pic_Logo;
        private System.Windows.Forms.ComboBox cbbTheLoai;
        private DataSet_HangHoa dataSet_HangHoa;
        private System.Windows.Forms.BindingSource theLoaiBindingSource;
        private DataSet_HangHoaTableAdapters.TheLoaiTableAdapter theLoaiTableAdapter;
        private CT_Button btnXoaHet;
        private CT_Button btn_Order;
        private CT_Button btnHienThi;
        private CT_Button btn_Banh;
        private CT_Button btn_NuocUong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGia_Order;
        private System.Windows.Forms.TextBox txtTenMon_Order;
        private System.Windows.Forms.DataGridView dtgv_SanPham;
        private System.Windows.Forms.DataGridView dtgv_Order;
        private System.Windows.Forms.TextBox txtSoLuong;
        private CT_Button btnThanhToan;
        private System.Windows.Forms.TextBox txtSum;
        private System.Windows.Forms.TextBox txtSum_SoLuong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
    }
}

