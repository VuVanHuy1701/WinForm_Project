
namespace GUI
{
    partial class Form_QLy_TaiKhoan
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
            this.colBangCap = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAdr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colBirth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnXoa_TK = new System.Windows.Forms.Button();
            this.btnThem_TK = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnSua_TK = new System.Windows.Forms.Button();
            this.lblBangCap = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblBirth = new System.Windows.Forms.Label();
            this.lblAdr = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.grbxIn4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCC_CM = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.dtgv_TaiKhoan = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.grbxIn4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_TaiKhoan)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // colBangCap
            // 
            this.colBangCap.Text = "Bằng Cấp";
            this.colBangCap.Width = 191;
            // 
            // colPhone
            // 
            this.colPhone.Text = "Điện Thoại";
            this.colPhone.Width = 138;
            // 
            // colAdr
            // 
            this.colAdr.Text = "Địa Chỉ";
            this.colAdr.Width = 129;
            // 
            // colBirth
            // 
            this.colBirth.Text = "Ngày Sinh";
            this.colBirth.Width = 95;
            // 
            // colName
            // 
            this.colName.Text = "Họ Tên";
            this.colName.Width = 116;
            // 
            // btnXoa_TK
            // 
            this.btnXoa_TK.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa_TK.Location = new System.Drawing.Point(98, 60);
            this.btnXoa_TK.Margin = new System.Windows.Forms.Padding(0);
            this.btnXoa_TK.Name = "btnXoa_TK";
            this.btnXoa_TK.Size = new System.Drawing.Size(81, 30);
            this.btnXoa_TK.TabIndex = 1;
            this.btnXoa_TK.Text = "Xóa";
            this.btnXoa_TK.UseVisualStyleBackColor = true;
            this.btnXoa_TK.Click += new System.EventHandler(this.btnXoa_TK_Click);
            // 
            // btnThem_TK
            // 
            this.btnThem_TK.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem_TK.Location = new System.Drawing.Point(3, 11);
            this.btnThem_TK.Margin = new System.Windows.Forms.Padding(0);
            this.btnThem_TK.Name = "btnThem_TK";
            this.btnThem_TK.Size = new System.Drawing.Size(81, 30);
            this.btnThem_TK.TabIndex = 0;
            this.btnThem_TK.Text = "Thêm ";
            this.btnThem_TK.UseVisualStyleBackColor = true;
            this.btnThem_TK.Click += new System.EventHandler(this.btnThem_TK_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnLamMoi);
            this.groupBox2.Controls.Add(this.btnSua_TK);
            this.groupBox2.Controls.Add(this.btnXoa_TK);
            this.groupBox2.Controls.Add(this.btnThem_TK);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(699, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(184, 100);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.Location = new System.Drawing.Point(98, 11);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(0);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(81, 30);
            this.btnLamMoi.TabIndex = 3;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnSua_TK
            // 
            this.btnSua_TK.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua_TK.Location = new System.Drawing.Point(3, 60);
            this.btnSua_TK.Margin = new System.Windows.Forms.Padding(0);
            this.btnSua_TK.Name = "btnSua_TK";
            this.btnSua_TK.Size = new System.Drawing.Size(81, 30);
            this.btnSua_TK.TabIndex = 2;
            this.btnSua_TK.Text = "Sửa";
            this.btnSua_TK.UseVisualStyleBackColor = true;
            this.btnSua_TK.Click += new System.EventHandler(this.btnSua_TK_Click);
            // 
            // lblBangCap
            // 
            this.lblBangCap.AutoSize = true;
            this.lblBangCap.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBangCap.Location = new System.Drawing.Point(21, 133);
            this.lblBangCap.Margin = new System.Windows.Forms.Padding(0);
            this.lblBangCap.Name = "lblBangCap";
            this.lblBangCap.Size = new System.Drawing.Size(41, 16);
            this.lblBangCap.TabIndex = 9;
            this.lblBangCap.Text = "Email";
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(444, 79);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(0);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(214, 22);
            this.txtPhone.TabIndex = 7;
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(444, 33);
            this.txtPass.Margin = new System.Windows.Forms.Padding(0);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(214, 22);
            this.txtPass.TabIndex = 6;
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(100, 33);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(0);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(221, 22);
            this.txtUserName.TabIndex = 5;
            // 
            // lblBirth
            // 
            this.lblBirth.AutoSize = true;
            this.lblBirth.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirth.Location = new System.Drawing.Point(21, 85);
            this.lblBirth.Margin = new System.Windows.Forms.Padding(0);
            this.lblBirth.Name = "lblBirth";
            this.lblBirth.Size = new System.Drawing.Size(49, 16);
            this.lblBirth.TabIndex = 4;
            this.lblBirth.Text = "Họ Tên";
            // 
            // lblAdr
            // 
            this.lblAdr.AutoSize = true;
            this.lblAdr.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdr.Location = new System.Drawing.Point(349, 82);
            this.lblAdr.Margin = new System.Windows.Forms.Padding(0);
            this.lblAdr.Name = "lblAdr";
            this.lblAdr.Size = new System.Drawing.Size(69, 16);
            this.lblAdr.TabIndex = 2;
            this.lblAdr.Text = "Điện Thoại";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(349, 36);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(73, 16);
            this.lblPhone.TabIndex = 1;
            this.lblPhone.Text = "Pass Word";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(21, 36);
            this.lblName.Margin = new System.Windows.Forms.Padding(0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(73, 16);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "User Name";
            // 
            // grbxIn4
            // 
            this.grbxIn4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.grbxIn4.Controls.Add(this.txtId);
            this.grbxIn4.Controls.Add(this.lblID);
            this.grbxIn4.Controls.Add(this.groupBox2);
            this.grbxIn4.Controls.Add(this.label1);
            this.grbxIn4.Controls.Add(this.txtCC_CM);
            this.grbxIn4.Controls.Add(this.txtName);
            this.grbxIn4.Controls.Add(this.txtEmail);
            this.grbxIn4.Controls.Add(this.lblBangCap);
            this.grbxIn4.Controls.Add(this.txtPhone);
            this.grbxIn4.Controls.Add(this.txtPass);
            this.grbxIn4.Controls.Add(this.txtUserName);
            this.grbxIn4.Controls.Add(this.lblBirth);
            this.grbxIn4.Controls.Add(this.lblAdr);
            this.grbxIn4.Controls.Add(this.lblPhone);
            this.grbxIn4.Controls.Add(this.lblName);
            this.grbxIn4.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbxIn4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grbxIn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbxIn4.Location = new System.Drawing.Point(0, 0);
            this.grbxIn4.Name = "grbxIn4";
            this.grbxIn4.Size = new System.Drawing.Size(1054, 177);
            this.grbxIn4.TabIndex = 5;
            this.grbxIn4.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(349, 133);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "CCCD/CMND";
            // 
            // txtCC_CM
            // 
            this.txtCC_CM.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCC_CM.Location = new System.Drawing.Point(444, 130);
            this.txtCC_CM.Margin = new System.Windows.Forms.Padding(0);
            this.txtCC_CM.Name = "txtCC_CM";
            this.txtCC_CM.Size = new System.Drawing.Size(214, 22);
            this.txtCC_CM.TabIndex = 13;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(100, 82);
            this.txtName.Margin = new System.Windows.Forms.Padding(0);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(221, 22);
            this.txtName.TabIndex = 12;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(100, 130);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(0);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(221, 22);
            this.txtEmail.TabIndex = 11;
            // 
            // dtgv_TaiKhoan
            // 
            this.dtgv_TaiKhoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_TaiKhoan.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dtgv_TaiKhoan.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dtgv_TaiKhoan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgv_TaiKhoan.Location = new System.Drawing.Point(3, 18);
            this.dtgv_TaiKhoan.Margin = new System.Windows.Forms.Padding(0);
            this.dtgv_TaiKhoan.Name = "dtgv_TaiKhoan";
            this.dtgv_TaiKhoan.Size = new System.Drawing.Size(1048, 294);
            this.dtgv_TaiKhoan.TabIndex = 90;
            this.dtgv_TaiKhoan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_TaiKhoan_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.dtgv_TaiKhoan);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 246);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1054, 315);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Chung";
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(702, 33);
            this.txtId.Margin = new System.Windows.Forms.Padding(0);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(181, 22);
            this.txtId.TabIndex = 16;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(680, 36);
            this.lblID.Margin = new System.Windows.Forms.Padding(0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(20, 16);
            this.lblID.TabIndex = 15;
            this.lblID.Text = "ID";
            // 
            // Form_QLy_TaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 561);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbxIn4);
            this.MaximumSize = new System.Drawing.Size(1070, 600);
            this.MinimumSize = new System.Drawing.Size(1070, 600);
            this.Name = "Form_QLy_TaiKhoan";
            this.Text = "Form_QLy_TaiKhoan";
            this.Load += new System.EventHandler(this.Form_QLy_TaiKhoan_Load);
            this.groupBox2.ResumeLayout(false);
            this.grbxIn4.ResumeLayout(false);
            this.grbxIn4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_TaiKhoan)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColumnHeader colBangCap;
        private System.Windows.Forms.ColumnHeader colPhone;
        private System.Windows.Forms.ColumnHeader colAdr;
        private System.Windows.Forms.ColumnHeader colBirth;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.Button btnXoa_TK;
        private System.Windows.Forms.Button btnThem_TK;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblBangCap;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblBirth;
        private System.Windows.Forms.Label lblAdr;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox grbxIn4;
        private System.Windows.Forms.TextBox txtCC_CM;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSua_TK;
        private System.Windows.Forms.DataGridView dtgv_TaiKhoan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblID;
    }
}