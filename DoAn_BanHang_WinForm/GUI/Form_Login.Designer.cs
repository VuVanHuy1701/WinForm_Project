
namespace GUI
{
    partial class Form_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Login));
            this.panel_Login = new System.Windows.Forms.Panel();
            this.picUser = new System.Windows.Forms.PictureBox();
            this.link_lblQuenPass = new System.Windows.Forms.LinkLabel();
            this.ct_btnDangNhap = new GUI.CT_Button();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.picPass = new System.Windows.Forms.PictureBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.panel_QuenPass = new System.Windows.Forms.Panel();
            this.lblKetqua = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUser_QuenPas = new System.Windows.Forms.TextBox();
            this.ct_btnLayLaiPass = new GUI.CT_Button();
            this.picUserQuenPass = new System.Windows.Forms.PictureBox();
            this.timer_Form_Login = new System.Windows.Forms.Timer(this.components);
            this.panel_Login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPass)).BeginInit();
            this.panel_QuenPass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUserQuenPass)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Login
            // 
            this.panel_Login.BackColor = System.Drawing.Color.Transparent;
            this.panel_Login.BackgroundImage = global::GUI.Properties.Resources.BG_Login_Form_removebg_preview;
            this.panel_Login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_Login.Controls.Add(this.picUser);
            this.panel_Login.Controls.Add(this.link_lblQuenPass);
            this.panel_Login.Controls.Add(this.ct_btnDangNhap);
            this.panel_Login.Controls.Add(this.txtPass);
            this.panel_Login.Controls.Add(this.picPass);
            this.panel_Login.Controls.Add(this.txtUsername);
            this.panel_Login.Location = new System.Drawing.Point(334, 134);
            this.panel_Login.Name = "panel_Login";
            this.panel_Login.Size = new System.Drawing.Size(480, 360);
            this.panel_Login.TabIndex = 2;
            this.panel_Login.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Login_Paint);
            // 
            // picUser
            // 
            this.picUser.BackColor = System.Drawing.Color.Transparent;
            this.picUser.Image = global::GUI.Properties.Resources.User_icon;
            this.picUser.Location = new System.Drawing.Point(20, 30);
            this.picUser.Name = "picUser";
            this.picUser.Size = new System.Drawing.Size(39, 33);
            this.picUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picUser.TabIndex = 5;
            this.picUser.TabStop = false;
            // 
            // link_lblQuenPass
            // 
            this.link_lblQuenPass.AutoSize = true;
            this.link_lblQuenPass.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_lblQuenPass.LinkColor = System.Drawing.Color.Black;
            this.link_lblQuenPass.Location = new System.Drawing.Point(142, 165);
            this.link_lblQuenPass.Name = "link_lblQuenPass";
            this.link_lblQuenPass.Size = new System.Drawing.Size(99, 16);
            this.link_lblQuenPass.TabIndex = 3;
            this.link_lblQuenPass.TabStop = true;
            this.link_lblQuenPass.Text = "Quên Mật Khẩu";
            this.link_lblQuenPass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_lblQuenPass_LinkClicked);
            // 
            // ct_btnDangNhap
            // 
            this.ct_btnDangNhap.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ct_btnDangNhap.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.ct_btnDangNhap.BorderColor = System.Drawing.Color.SlateGray;
            this.ct_btnDangNhap.BorderRadius = 20;
            this.ct_btnDangNhap.BorderSize = 2;
            this.ct_btnDangNhap.FlatAppearance.BorderSize = 0;
            this.ct_btnDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ct_btnDangNhap.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ct_btnDangNhap.ForeColor = System.Drawing.Color.Black;
            this.ct_btnDangNhap.Location = new System.Drawing.Point(173, 305);
            this.ct_btnDangNhap.Name = "ct_btnDangNhap";
            this.ct_btnDangNhap.Size = new System.Drawing.Size(150, 40);
            this.ct_btnDangNhap.TabIndex = 2;
            this.ct_btnDangNhap.Text = "Đăng Nhập";
            this.ct_btnDangNhap.TextColor = System.Drawing.Color.Black;
            this.ct_btnDangNhap.UseVisualStyleBackColor = false;
            this.ct_btnDangNhap.Click += new System.EventHandler(this.ct_btnDangNhap_Click);
            this.ct_btnDangNhap.Enter += new System.EventHandler(this.ct_btnDangNhap_Click);
            // 
            // txtPass
            // 
            this.txtPass.AllowDrop = true;
            this.txtPass.BackColor = System.Drawing.Color.LightCyan;
            this.txtPass.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(69, 106);
            this.txtPass.Multiline = true;
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(182, 30);
            this.txtPass.TabIndex = 0;
            this.txtPass.TextChanged += new System.EventHandler(this.txtPass_TextChanged);
            // 
            // picPass
            // 
            this.picPass.BackColor = System.Drawing.Color.Transparent;
            this.picPass.Image = global::GUI.Properties.Resources.PassWord_icon;
            this.picPass.Location = new System.Drawing.Point(5, 87);
            this.picPass.Name = "picPass";
            this.picPass.Size = new System.Drawing.Size(70, 70);
            this.picPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPass.TabIndex = 4;
            this.picPass.TabStop = false;
            // 
            // txtUsername
            // 
            this.txtUsername.AllowDrop = true;
            this.txtUsername.BackColor = System.Drawing.Color.LightCyan;
            this.txtUsername.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(69, 31);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(182, 30);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // panel_QuenPass
            // 
            this.panel_QuenPass.BackColor = System.Drawing.Color.Transparent;
            this.panel_QuenPass.BackgroundImage = global::GUI.Properties.Resources.BG_SigUp;
            this.panel_QuenPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_QuenPass.Controls.Add(this.lblKetqua);
            this.panel_QuenPass.Controls.Add(this.label1);
            this.panel_QuenPass.Controls.Add(this.txtUser_QuenPas);
            this.panel_QuenPass.Controls.Add(this.ct_btnLayLaiPass);
            this.panel_QuenPass.Controls.Add(this.picUserQuenPass);
            this.panel_QuenPass.Location = new System.Drawing.Point(168, 134);
            this.panel_QuenPass.Name = "panel_QuenPass";
            this.panel_QuenPass.Size = new System.Drawing.Size(291, 360);
            this.panel_QuenPass.TabIndex = 3;
            this.panel_QuenPass.Visible = false;
            // 
            // lblKetqua
            // 
            this.lblKetqua.AutoSize = true;
            this.lblKetqua.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKetqua.Location = new System.Drawing.Point(56, 293);
            this.lblKetqua.Name = "lblKetqua";
            this.lblKetqua.Size = new System.Drawing.Size(62, 17);
            this.lblKetqua.TabIndex = 8;
            this.lblKetqua.Text = "Kết quả:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nhập User Name";
            // 
            // txtUser_QuenPas
            // 
            this.txtUser_QuenPas.AllowDrop = true;
            this.txtUser_QuenPas.BackColor = System.Drawing.Color.LightCyan;
            this.txtUser_QuenPas.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser_QuenPas.Location = new System.Drawing.Point(59, 160);
            this.txtUser_QuenPas.Multiline = true;
            this.txtUser_QuenPas.Name = "txtUser_QuenPas";
            this.txtUser_QuenPas.Size = new System.Drawing.Size(182, 30);
            this.txtUser_QuenPas.TabIndex = 6;
            // 
            // ct_btnLayLaiPass
            // 
            this.ct_btnLayLaiPass.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ct_btnLayLaiPass.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.ct_btnLayLaiPass.BorderColor = System.Drawing.Color.SlateGray;
            this.ct_btnLayLaiPass.BorderRadius = 20;
            this.ct_btnLayLaiPass.BorderSize = 2;
            this.ct_btnLayLaiPass.FlatAppearance.BorderSize = 0;
            this.ct_btnLayLaiPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ct_btnLayLaiPass.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ct_btnLayLaiPass.ForeColor = System.Drawing.Color.Black;
            this.ct_btnLayLaiPass.Location = new System.Drawing.Point(75, 219);
            this.ct_btnLayLaiPass.Name = "ct_btnLayLaiPass";
            this.ct_btnLayLaiPass.Size = new System.Drawing.Size(150, 40);
            this.ct_btnLayLaiPass.TabIndex = 6;
            this.ct_btnLayLaiPass.Text = "Lấy Lại Mật Khẩu";
            this.ct_btnLayLaiPass.TextColor = System.Drawing.Color.Black;
            this.ct_btnLayLaiPass.UseVisualStyleBackColor = false;
            this.ct_btnLayLaiPass.Click += new System.EventHandler(this.ct_btnLayLaiPass_Click);
            // 
            // picUserQuenPass
            // 
            this.picUserQuenPass.BackColor = System.Drawing.Color.Transparent;
            this.picUserQuenPass.Image = global::GUI.Properties.Resources.User_icon;
            this.picUserQuenPass.Location = new System.Drawing.Point(102, 51);
            this.picUserQuenPass.Name = "picUserQuenPass";
            this.picUserQuenPass.Size = new System.Drawing.Size(93, 68);
            this.picUserQuenPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picUserQuenPass.TabIndex = 6;
            this.picUserQuenPass.TabStop = false;
            // 
            // timer_Form_Login
            // 
            this.timer_Form_Login.Interval = 10;
            this.timer_Form_Login.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI.Properties.Resources.BG_Login;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1074, 661);
            this.Controls.Add(this.panel_Login);
            this.Controls.Add(this.panel_QuenPass);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1090, 700);
            this.Name = "Form_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.Load += new System.EventHandler(this.Form_Login_Load);
            this.panel_Login.ResumeLayout(false);
            this.panel_Login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPass)).EndInit();
            this.panel_QuenPass.ResumeLayout(false);
            this.panel_QuenPass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUserQuenPass)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_Login;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Panel panel_QuenPass;
        private CT_Button ct_btnDangNhap;
        private System.Windows.Forms.LinkLabel link_lblQuenPass;
        private System.Windows.Forms.PictureBox picPass;
        private System.Windows.Forms.PictureBox picUser;
        private System.Windows.Forms.TextBox txtUser_QuenPas;
        private CT_Button ct_btnLayLaiPass;
        private System.Windows.Forms.PictureBox picUserQuenPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblKetqua;
        private System.Windows.Forms.Timer timer_Form_Login;
    }
}