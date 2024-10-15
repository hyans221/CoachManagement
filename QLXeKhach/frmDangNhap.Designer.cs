namespace QLXeKhach
{
    partial class frmDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangNhap));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.chkShowPassword = new Guna.UI2.WinForms.Guna2CheckBox();
            this.btnThoat = new Guna.UI2.WinForms.Guna2Button();
            this.btnDangNhap = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtUserName = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // chkShowPassword
            // 
            this.chkShowPassword.AutoSize = true;
            this.chkShowPassword.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkShowPassword.CheckedState.BorderRadius = 0;
            this.chkShowPassword.CheckedState.BorderThickness = 0;
            this.chkShowPassword.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkShowPassword.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkShowPassword.Location = new System.Drawing.Point(673, 280);
            this.chkShowPassword.Name = "chkShowPassword";
            this.chkShowPassword.Size = new System.Drawing.Size(119, 19);
            this.chkShowPassword.TabIndex = 5;
            this.chkShowPassword.Text = "Hiển thị mật khẩu";
            this.chkShowPassword.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkShowPassword.UncheckedState.BorderRadius = 0;
            this.chkShowPassword.UncheckedState.BorderThickness = 0;
            this.chkShowPassword.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkShowPassword.CheckedChanged += new System.EventHandler(this.chkShowPassword_CheckedChanged);
            // 
            // btnThoat
            // 
            this.btnThoat.BorderRadius = 20;
            this.btnThoat.CheckedState.Parent = this.btnThoat;
            this.btnThoat.CustomImages.Parent = this.btnThoat;
            this.btnThoat.FillColor = System.Drawing.Color.Firebrick;
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.HoverState.Parent = this.btnThoat;
            this.btnThoat.Location = new System.Drawing.Point(656, 306);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ShadowDecoration.Parent = this.btnThoat;
            this.btnThoat.Size = new System.Drawing.Size(122, 38);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.BorderRadius = 20;
            this.btnDangNhap.CheckedState.Parent = this.btnDangNhap;
            this.btnDangNhap.CustomImages.Parent = this.btnDangNhap;
            this.btnDangNhap.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(94)))), ((int)(((byte)(121)))));
            this.btnDangNhap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.ForeColor = System.Drawing.Color.White;
            this.btnDangNhap.HoverState.Parent = this.btnDangNhap;
            this.btnDangNhap.Location = new System.Drawing.Point(520, 306);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.ShadowDecoration.Parent = this.btnDangNhap;
            this.btnDangNhap.Size = new System.Drawing.Size(124, 38);
            this.btnDangNhap.TabIndex = 9;
            this.btnDangNhap.Text = "Đăng Nhập";
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLXeKhach.Properties.Resources.icons8_admin_100;
            this.pictureBox1.Location = new System.Drawing.Point(604, 52);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // txtPassword
            // 
            this.txtPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(94)))), ((int)(((byte)(121)))));
            this.txtPassword.BorderRadius = 15;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.DisabledState.Parent = this.txtPassword;
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.FocusedState.Parent = this.txtPassword;
            this.txtPassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.HoverState.Parent = this.txtPassword;
            this.txtPassword.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtPassword.IconLeft")));
            this.txtPassword.Location = new System.Drawing.Point(501, 223);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtPassword.PlaceholderText = "********";
            this.txtPassword.SelectedText = "";
            this.txtPassword.ShadowDecoration.Parent = this.txtPassword;
            this.txtPassword.Size = new System.Drawing.Size(284, 41);
            this.txtPassword.TabIndex = 7;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUserName
            // 
            this.txtUserName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(94)))), ((int)(((byte)(121)))));
            this.txtUserName.BorderRadius = 15;
            this.txtUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserName.DefaultText = "";
            this.txtUserName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUserName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUserName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserName.DisabledState.Parent = this.txtUserName;
            this.txtUserName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserName.FocusedState.Parent = this.txtUserName;
            this.txtUserName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.ForeColor = System.Drawing.Color.Black;
            this.txtUserName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserName.HoverState.Parent = this.txtUserName;
            this.txtUserName.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtUserName.IconLeft")));
            this.txtUserName.Location = new System.Drawing.Point(501, 163);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.PasswordChar = '\0';
            this.txtUserName.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtUserName.PlaceholderText = "Username";
            this.txtUserName.SelectedText = "";
            this.txtUserName.ShadowDecoration.Parent = this.txtUserName;
            this.txtUserName.Size = new System.Drawing.Size(284, 41);
            this.txtUserName.TabIndex = 6;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::QLXeKhach.Properties.Resources.loginn;
            this.guna2PictureBox1.Location = new System.Drawing.Point(-4, 1);
            this.guna2PictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(486, 428);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.guna2PictureBox1;
            // 
            // guna2DragControl2
            // 
            this.guna2DragControl2.TargetControl = this;
            // 
            // ControlBox3
            // 
            this.ControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.ControlBox3.FillColor = System.Drawing.Color.Transparent;
            this.ControlBox3.HoverState.Parent = this.ControlBox3;
            this.ControlBox3.IconColor = System.Drawing.Color.Gray;
            this.ControlBox3.Location = new System.Drawing.Point(696, 1);
            this.ControlBox3.Name = "ControlBox3";
            this.ControlBox3.ShadowDecoration.Parent = this.ControlBox3;
            this.ControlBox3.Size = new System.Drawing.Size(45, 29);
            this.ControlBox3.TabIndex = 13;
            // 
            // ControlBox2
            // 
            this.ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.ControlBox2.FillColor = System.Drawing.Color.Transparent;
            this.ControlBox2.HoverState.Parent = this.ControlBox2;
            this.ControlBox2.IconColor = System.Drawing.Color.Gray;
            this.ControlBox2.Location = new System.Drawing.Point(747, 1);
            this.ControlBox2.Name = "ControlBox2";
            this.ControlBox2.ShadowDecoration.Parent = this.ControlBox2;
            this.ControlBox2.Size = new System.Drawing.Size(45, 29);
            this.ControlBox2.TabIndex = 12;
            // 
            // ControlBox1
            // 
            this.ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.ControlBox1.HoverState.Parent = this.ControlBox1;
            this.ControlBox1.IconColor = System.Drawing.Color.Gray;
            this.ControlBox1.Location = new System.Drawing.Point(798, 1);
            this.ControlBox1.Name = "ControlBox1";
            this.ControlBox1.ShadowDecoration.Parent = this.ControlBox1;
            this.ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.ControlBox1.TabIndex = 11;
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(843, 425);
            this.Controls.Add(this.ControlBox3);
            this.Controls.Add(this.ControlBox2);
            this.Controls.Add(this.ControlBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.chkShowPassword);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.guna2PictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDangNhap";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        internal Guna.UI2.WinForms.Guna2CheckBox chkShowPassword;
        internal Guna.UI2.WinForms.Guna2Button btnThoat;
        internal Guna.UI2.WinForms.Guna2TextBox txtPassword;
        internal Guna.UI2.WinForms.Guna2TextBox txtUserName;
        internal Guna.UI2.WinForms.Guna2Button btnDangNhap;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl2;
        private Guna.UI2.WinForms.Guna2ControlBox ControlBox3;
        private Guna.UI2.WinForms.Guna2ControlBox ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox ControlBox1;
    }
}