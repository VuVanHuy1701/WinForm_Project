
namespace GUI
{
    partial class Form_TongTien
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbbChietKhau = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbPhuongThuc = new System.Windows.Forms.ComboBox();
            this.thanhToanBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetThanhToanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_ThanhToan = new GUI.DataSet_ThanhToan();
            this.thanhToanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtMaGiamGia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTongCong = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox_VAT = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbDichVu = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTienThua = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.thanhToanTableAdapter = new GUI.DataSet_ThanhToanTableAdapters.ThanhToanTableAdapter();
            this.btn500K = new GUI.CT_Button();
            this.btn200K = new GUI.CT_Button();
            this.btn100K = new GUI.CT_Button();
            this.btn50K = new GUI.CT_Button();
            this.btnBackToOrder = new GUI.CT_Button();
            ((System.ComponentModel.ISupportInitialize)(this.thanhToanBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetThanhToanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_ThanhToan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thanhToanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(168, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tổng Tiền Sản Phẩm";
            // 
            // cbbChietKhau
            // 
            this.cbbChietKhau.BackColor = System.Drawing.Color.White;
            this.cbbChietKhau.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbChietKhau.FormattingEnabled = true;
            this.cbbChietKhau.Items.AddRange(new object[] {
            "0",
            "10%",
            "20%",
            "50%",
            "70%",
            "90%",
            "100%"});
            this.cbbChietKhau.Location = new System.Drawing.Point(190, 110);
            this.cbbChietKhau.Name = "cbbChietKhau";
            this.cbbChietKhau.Size = new System.Drawing.Size(278, 24);
            this.cbbChietKhau.TabIndex = 1;
            this.cbbChietKhau.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Chiết Khấu";
            // 
            // cbbPhuongThuc
            // 
            this.cbbPhuongThuc.BackColor = System.Drawing.Color.White;
            this.cbbPhuongThuc.DataSource = this.thanhToanBindingSource1;
            this.cbbPhuongThuc.DisplayMember = "PhuongThuc";
            this.cbbPhuongThuc.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbPhuongThuc.FormattingEnabled = true;
            this.cbbPhuongThuc.Location = new System.Drawing.Point(190, 254);
            this.cbbPhuongThuc.Name = "cbbPhuongThuc";
            this.cbbPhuongThuc.Size = new System.Drawing.Size(278, 24);
            this.cbbPhuongThuc.TabIndex = 5;
            // 
            // thanhToanBindingSource1
            // 
            this.thanhToanBindingSource1.DataMember = "ThanhToan";
            this.thanhToanBindingSource1.DataSource = this.dataSetThanhToanBindingSource;
            // 
            // dataSetThanhToanBindingSource
            // 
            this.dataSetThanhToanBindingSource.DataSource = this.dataSet_ThanhToan;
            this.dataSetThanhToanBindingSource.Position = 0;
            // 
            // dataSet_ThanhToan
            // 
            this.dataSet_ThanhToan.DataSetName = "DataSet_ThanhToan";
            this.dataSet_ThanhToan.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // thanhToanBindingSource
            // 
            this.thanhToanBindingSource.DataMember = "ThanhToan";
            this.thanhToanBindingSource.DataSource = this.dataSetThanhToanBindingSource;
            // 
            // txtMaGiamGia
            // 
            this.txtMaGiamGia.BackColor = System.Drawing.Color.White;
            this.txtMaGiamGia.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaGiamGia.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtMaGiamGia.Location = new System.Drawing.Point(190, 65);
            this.txtMaGiamGia.Multiline = true;
            this.txtMaGiamGia.Name = "txtMaGiamGia";
            this.txtMaGiamGia.Size = new System.Drawing.Size(278, 20);
            this.txtMaGiamGia.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mã Giảm Giá";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tổng Cộng:";
            // 
            // txtTongCong
            // 
            this.txtTongCong.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtTongCong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTongCong.Enabled = false;
            this.txtTongCong.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongCong.Location = new System.Drawing.Point(190, 301);
            this.txtTongCong.Name = "txtTongCong";
            this.txtTongCong.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTongCong.Size = new System.Drawing.Size(278, 15);
            this.txtTongCong.TabIndex = 9;
            this.txtTongCong.Text = "0";
            this.txtTongCong.TextChanged += new System.EventHandler(this.txtTongCong_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Dịch Vụ";
            // 
            // checkBox_VAT
            // 
            this.checkBox_VAT.AutoSize = true;
            this.checkBox_VAT.Location = new System.Drawing.Point(208, 217);
            this.checkBox_VAT.Name = "checkBox_VAT";
            this.checkBox_VAT.Size = new System.Drawing.Size(15, 14);
            this.checkBox_VAT.TabIndex = 12;
            this.checkBox_VAT.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "VAT";
            // 
            // cbbDichVu
            // 
            this.cbbDichVu.BackColor = System.Drawing.Color.White;
            this.cbbDichVu.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbDichVu.FormattingEnabled = true;
            this.cbbDichVu.Items.AddRange(new object[] {
            "Thuê bàn: 100k",
            "Tổ chức tiệc: 200k",
            "Phòng họp: 300k"});
            this.cbbDichVu.Location = new System.Drawing.Point(190, 168);
            this.cbbDichVu.Name = "cbbDichVu";
            this.cbbDichVu.Size = new System.Drawing.Size(278, 24);
            this.cbbDichVu.TabIndex = 14;
            this.cbbDichVu.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Phương Thức";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(30, 347);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "Tiền Khách Trả";
            // 
            // txtTienThua
            // 
            this.txtTienThua.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtTienThua.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTienThua.Enabled = false;
            this.txtTienThua.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTienThua.Location = new System.Drawing.Point(190, 449);
            this.txtTienThua.Multiline = true;
            this.txtTienThua.Name = "txtTienThua";
            this.txtTienThua.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTienThua.Size = new System.Drawing.Size(278, 20);
            this.txtTienThua.TabIndex = 21;
            this.txtTienThua.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(30, 451);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 17);
            this.label9.TabIndex = 22;
            this.label9.Text = "Tiền Thừa:";
            // 
            // thanhToanTableAdapter
            // 
            this.thanhToanTableAdapter.ClearBeforeFill = true;
            // 
            // btn500K
            // 
            this.btn500K.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn500K.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.btn500K.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn500K.BorderRadius = 7;
            this.btn500K.BorderSize = 0;
            this.btn500K.FlatAppearance.BorderSize = 0;
            this.btn500K.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn500K.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn500K.ForeColor = System.Drawing.SystemColors.Control;
            this.btn500K.Location = new System.Drawing.Point(403, 383);
            this.btn500K.Name = "btn500K";
            this.btn500K.Size = new System.Drawing.Size(65, 40);
            this.btn500K.TabIndex = 19;
            this.btn500K.Text = "500.000";
            this.btn500K.TextColor = System.Drawing.SystemColors.Control;
            this.btn500K.UseVisualStyleBackColor = false;
            this.btn500K.Click += new System.EventHandler(this.btn500K_Click);
            // 
            // btn200K
            // 
            this.btn200K.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn200K.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.btn200K.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn200K.BorderRadius = 7;
            this.btn200K.BorderSize = 0;
            this.btn200K.FlatAppearance.BorderSize = 0;
            this.btn200K.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn200K.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn200K.ForeColor = System.Drawing.SystemColors.Control;
            this.btn200K.Location = new System.Drawing.Point(281, 383);
            this.btn200K.Name = "btn200K";
            this.btn200K.Size = new System.Drawing.Size(65, 40);
            this.btn200K.TabIndex = 18;
            this.btn200K.Text = "200.000";
            this.btn200K.TextColor = System.Drawing.SystemColors.Control;
            this.btn200K.UseVisualStyleBackColor = false;
            this.btn200K.Click += new System.EventHandler(this.btn200K_Click);
            // 
            // btn100K
            // 
            this.btn100K.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn100K.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.btn100K.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn100K.BorderRadius = 7;
            this.btn100K.BorderSize = 0;
            this.btn100K.FlatAppearance.BorderSize = 0;
            this.btn100K.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn100K.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn100K.ForeColor = System.Drawing.SystemColors.Control;
            this.btn100K.Location = new System.Drawing.Point(155, 383);
            this.btn100K.Name = "btn100K";
            this.btn100K.Size = new System.Drawing.Size(65, 40);
            this.btn100K.TabIndex = 17;
            this.btn100K.Text = "100.000";
            this.btn100K.TextColor = System.Drawing.SystemColors.Control;
            this.btn100K.UseVisualStyleBackColor = false;
            this.btn100K.Click += new System.EventHandler(this.btn100K_Click);
            // 
            // btn50K
            // 
            this.btn50K.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn50K.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.btn50K.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn50K.BorderRadius = 7;
            this.btn50K.BorderSize = 0;
            this.btn50K.FlatAppearance.BorderSize = 0;
            this.btn50K.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn50K.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn50K.ForeColor = System.Drawing.SystemColors.Control;
            this.btn50K.Location = new System.Drawing.Point(33, 383);
            this.btn50K.Name = "btn50K";
            this.btn50K.Size = new System.Drawing.Size(65, 40);
            this.btn50K.TabIndex = 16;
            this.btn50K.Text = "50.000";
            this.btn50K.TextColor = System.Drawing.SystemColors.Control;
            this.btn50K.UseVisualStyleBackColor = false;
            this.btn50K.Click += new System.EventHandler(this.btn50K_Click);
            // 
            // btnBackToOrder
            // 
            this.btnBackToOrder.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBackToOrder.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnBackToOrder.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.btnBackToOrder.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnBackToOrder.BorderRadius = 7;
            this.btnBackToOrder.BorderSize = 0;
            this.btnBackToOrder.FlatAppearance.BorderSize = 0;
            this.btnBackToOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackToOrder.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToOrder.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBackToOrder.Location = new System.Drawing.Point(155, 483);
            this.btnBackToOrder.Name = "btnBackToOrder";
            this.btnBackToOrder.Size = new System.Drawing.Size(191, 61);
            this.btnBackToOrder.TabIndex = 24;
            this.btnBackToOrder.Text = "Quay lại trang sản phẩm";
            this.btnBackToOrder.TextColor = System.Drawing.SystemColors.Control;
            this.btnBackToOrder.UseVisualStyleBackColor = false;
            this.btnBackToOrder.Click += new System.EventHandler(this.btnBackToOrder_Click);
            // 
            // Form_TongTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(489, 556);
            this.Controls.Add(this.btnBackToOrder);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTienThua);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn500K);
            this.Controls.Add(this.btn200K);
            this.Controls.Add(this.btn100K);
            this.Controls.Add(this.btn50K);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbbDichVu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.checkBox_VAT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTongCong);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMaGiamGia);
            this.Controls.Add(this.cbbPhuongThuc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbbChietKhau);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(505, 595);
            this.Name = "Form_TongTien";
            this.Text = "Form_TongTien";
            this.Load += new System.EventHandler(this.Form_TongTien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.thanhToanBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetThanhToanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_ThanhToan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thanhToanBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbChietKhau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbPhuongThuc;
        private System.Windows.Forms.TextBox txtMaGiamGia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTongCong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox_VAT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbDichVu;
        private System.Windows.Forms.Label label7;
        private CT_Button btn50K;
        private CT_Button btn100K;
        private CT_Button btn200K;
        private CT_Button btn500K;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTienThua;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.BindingSource dataSetThanhToanBindingSource;
        private DataSet_ThanhToan dataSet_ThanhToan;
        private System.Windows.Forms.BindingSource thanhToanBindingSource;
        private DataSet_ThanhToanTableAdapters.ThanhToanTableAdapter thanhToanTableAdapter;
        private System.Windows.Forms.BindingSource thanhToanBindingSource1;
        private CT_Button btnBackToOrder;
    }
}