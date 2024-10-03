namespace QLXeKhach
{
    partial class frmQuanLyChuyenDi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyChuyenDi));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtNgayBatDau = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblNgayBatDau = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblHocPhi = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblTenMH = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblMaMH = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblTenGiangVien = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.btnSua = new Guna.UI2.WinForms.Guna2Button();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            this.cboGiangVienID = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtHocPhi = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTenMonHoc = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMonHocID = new Guna.UI2.WinForms.Guna2TextBox();
            this.Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvMonHoc = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonHoc)).BeginInit();
            this.Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtNgayBatDau
            // 
            this.dtNgayBatDau.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtNgayBatDau.BorderColor = System.Drawing.Color.DodgerBlue;
            this.dtNgayBatDau.BorderRadius = 10;
            this.dtNgayBatDau.BorderThickness = 1;
            this.dtNgayBatDau.CheckedState.Parent = this.dtNgayBatDau;
            this.dtNgayBatDau.FillColor = System.Drawing.Color.White;
            this.dtNgayBatDau.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayBatDau.HoverState.Parent = this.dtNgayBatDau;
            this.dtNgayBatDau.Location = new System.Drawing.Point(564, 43);
            this.dtNgayBatDau.Margin = new System.Windows.Forms.Padding(4);
            this.dtNgayBatDau.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtNgayBatDau.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtNgayBatDau.Name = "dtNgayBatDau";
            this.dtNgayBatDau.ShadowDecoration.Parent = this.dtNgayBatDau;
            this.dtNgayBatDau.Size = new System.Drawing.Size(161, 41);
            this.dtNgayBatDau.TabIndex = 48;
            this.dtNgayBatDau.Value = new System.DateTime(2021, 7, 5, 12, 52, 33, 197);
            // 
            // lblNgayBatDau
            // 
            this.lblNgayBatDau.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNgayBatDau.BackColor = System.Drawing.Color.Transparent;
            this.lblNgayBatDau.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayBatDau.Location = new System.Drawing.Point(533, 17);
            this.lblNgayBatDau.Margin = new System.Windows.Forms.Padding(4);
            this.lblNgayBatDau.Name = "lblNgayBatDau";
            this.lblNgayBatDau.Size = new System.Drawing.Size(119, 19);
            this.lblNgayBatDau.TabIndex = 46;
            this.lblNgayBatDau.Text = "Thời gian khởi hành";
            // 
            // lblHocPhi
            // 
            this.lblHocPhi.BackColor = System.Drawing.Color.Transparent;
            this.lblHocPhi.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHocPhi.Location = new System.Drawing.Point(29, 207);
            this.lblHocPhi.Margin = new System.Windows.Forms.Padding(4);
            this.lblHocPhi.Name = "lblHocPhi";
            this.lblHocPhi.Size = new System.Drawing.Size(61, 19);
            this.lblHocPhi.TabIndex = 45;
            this.lblHocPhi.Text = "Điểm đến";
            // 
            // lblTenMH
            // 
            this.lblTenMH.BackColor = System.Drawing.Color.Transparent;
            this.lblTenMH.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenMH.Location = new System.Drawing.Point(27, 113);
            this.lblTenMH.Margin = new System.Windows.Forms.Padding(4);
            this.lblTenMH.Name = "lblTenMH";
            this.lblTenMH.Size = new System.Drawing.Size(93, 19);
            this.lblTenMH.TabIndex = 44;
            this.lblTenMH.Text = "Điểm xuất phát";
            // 
            // lblMaMH
            // 
            this.lblMaMH.BackColor = System.Drawing.Color.Transparent;
            this.lblMaMH.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaMH.Location = new System.Drawing.Point(29, 17);
            this.lblMaMH.Margin = new System.Windows.Forms.Padding(4);
            this.lblMaMH.Name = "lblMaMH";
            this.lblMaMH.Size = new System.Drawing.Size(84, 19);
            this.lblMaMH.TabIndex = 43;
            this.lblMaMH.Text = "Mã chuyến đi";
            // 
            // lblTenGiangVien
            // 
            this.lblTenGiangVien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTenGiangVien.BackColor = System.Drawing.Color.Transparent;
            this.lblTenGiangVien.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenGiangVien.Location = new System.Drawing.Point(533, 113);
            this.lblTenGiangVien.Margin = new System.Windows.Forms.Padding(4);
            this.lblTenGiangVien.Name = "lblTenGiangVien";
            this.lblTenGiangVien.Size = new System.Drawing.Size(199, 19);
            this.lblTenGiangVien.TabIndex = 42;
            this.lblTenGiangVien.Text = "Mã xe khách thực hiện chuyến đi";
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.BorderRadius = 20;
            this.btnXoa.CheckedState.Parent = this.btnXoa;
            this.btnXoa.CustomImages.Parent = this.btnXoa;
            this.btnXoa.FillColor = System.Drawing.Color.Firebrick;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.HoverState.Parent = this.btnXoa;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnXoa.ImageSize = new System.Drawing.Size(30, 30);
            this.btnXoa.Location = new System.Drawing.Point(883, 228);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ShadowDecoration.Parent = this.btnXoa;
            this.btnXoa.Size = new System.Drawing.Size(136, 50);
            this.btnXoa.TabIndex = 41;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnSua
            // 
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSua.BorderRadius = 20;
            this.btnSua.CheckedState.Parent = this.btnSua;
            this.btnSua.CustomImages.Parent = this.btnSua;
            this.btnSua.FillColor = System.Drawing.Color.DarkSeaGreen;
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.HoverState.Parent = this.btnSua;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSua.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSua.Location = new System.Drawing.Point(689, 228);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.ShadowDecoration.Parent = this.btnSua;
            this.btnSua.Size = new System.Drawing.Size(136, 50);
            this.btnSua.TabIndex = 40;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.BorderRadius = 20;
            this.btnThem.CheckedState.Parent = this.btnThem;
            this.btnThem.CustomImages.Parent = this.btnThem;
            this.btnThem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(94)))), ((int)(((byte)(121)))));
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.HoverState.Parent = this.btnThem;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnThem.ImageSize = new System.Drawing.Size(30, 30);
            this.btnThem.Location = new System.Drawing.Point(496, 228);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.ShadowDecoration.Parent = this.btnThem;
            this.btnThem.Size = new System.Drawing.Size(136, 50);
            this.btnThem.TabIndex = 39;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cboGiangVienID
            // 
            this.cboGiangVienID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboGiangVienID.BackColor = System.Drawing.Color.Transparent;
            this.cboGiangVienID.BorderRadius = 20;
            this.cboGiangVienID.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboGiangVienID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGiangVienID.FocusedColor = System.Drawing.Color.Empty;
            this.cboGiangVienID.FocusedState.Parent = this.cboGiangVienID;
            this.cboGiangVienID.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGiangVienID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboGiangVienID.FormattingEnabled = true;
            this.cboGiangVienID.HoverState.Parent = this.cboGiangVienID;
            this.cboGiangVienID.ItemHeight = 30;
            this.cboGiangVienID.ItemsAppearance.Parent = this.cboGiangVienID;
            this.cboGiangVienID.Location = new System.Drawing.Point(564, 138);
            this.cboGiangVienID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboGiangVienID.Name = "cboGiangVienID";
            this.cboGiangVienID.ShadowDecoration.Parent = this.cboGiangVienID;
            this.cboGiangVienID.Size = new System.Drawing.Size(375, 36);
            this.cboGiangVienID.TabIndex = 38;
            // 
            // txtHocPhi
            // 
            this.txtHocPhi.AutoRoundedCorners = true;
            this.txtHocPhi.BorderRadius = 26;
            this.txtHocPhi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHocPhi.DefaultText = "";
            this.txtHocPhi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtHocPhi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtHocPhi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHocPhi.DisabledState.Parent = this.txtHocPhi;
            this.txtHocPhi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHocPhi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHocPhi.FocusedState.Parent = this.txtHocPhi;
            this.txtHocPhi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHocPhi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHocPhi.HoverState.Parent = this.txtHocPhi;
            this.txtHocPhi.Location = new System.Drawing.Point(67, 233);
            this.txtHocPhi.Margin = new System.Windows.Forms.Padding(15, 11, 15, 11);
            this.txtHocPhi.Name = "txtHocPhi";
            this.txtHocPhi.PasswordChar = '\0';
            this.txtHocPhi.PlaceholderText = "";
            this.txtHocPhi.SelectedText = "";
            this.txtHocPhi.ShadowDecoration.Parent = this.txtHocPhi;
            this.txtHocPhi.Size = new System.Drawing.Size(340, 54);
            this.txtHocPhi.TabIndex = 34;
            this.txtHocPhi.TextOffset = new System.Drawing.Point(8, 0);
            // 
            // txtTenMonHoc
            // 
            this.txtTenMonHoc.AutoRoundedCorners = true;
            this.txtTenMonHoc.BorderRadius = 26;
            this.txtTenMonHoc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenMonHoc.DefaultText = "";
            this.txtTenMonHoc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenMonHoc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenMonHoc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenMonHoc.DisabledState.Parent = this.txtTenMonHoc;
            this.txtTenMonHoc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenMonHoc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenMonHoc.FocusedState.Parent = this.txtTenMonHoc;
            this.txtTenMonHoc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenMonHoc.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenMonHoc.HoverState.Parent = this.txtTenMonHoc;
            this.txtTenMonHoc.Location = new System.Drawing.Point(67, 138);
            this.txtTenMonHoc.Margin = new System.Windows.Forms.Padding(15, 11, 15, 11);
            this.txtTenMonHoc.Name = "txtTenMonHoc";
            this.txtTenMonHoc.PasswordChar = '\0';
            this.txtTenMonHoc.PlaceholderText = "";
            this.txtTenMonHoc.SelectedText = "";
            this.txtTenMonHoc.ShadowDecoration.Parent = this.txtTenMonHoc;
            this.txtTenMonHoc.Size = new System.Drawing.Size(340, 54);
            this.txtTenMonHoc.TabIndex = 35;
            this.txtTenMonHoc.TextOffset = new System.Drawing.Point(8, 0);
            // 
            // txtMonHocID
            // 
            this.txtMonHocID.AutoRoundedCorners = true;
            this.txtMonHocID.BorderRadius = 26;
            this.txtMonHocID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMonHocID.DefaultText = "";
            this.txtMonHocID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMonHocID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMonHocID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMonHocID.DisabledState.Parent = this.txtMonHocID;
            this.txtMonHocID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMonHocID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMonHocID.FocusedState.Parent = this.txtMonHocID;
            this.txtMonHocID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonHocID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMonHocID.HoverState.Parent = this.txtMonHocID;
            this.txtMonHocID.Location = new System.Drawing.Point(67, 43);
            this.txtMonHocID.Margin = new System.Windows.Forms.Padding(15, 11, 15, 11);
            this.txtMonHocID.Name = "txtMonHocID";
            this.txtMonHocID.PasswordChar = '\0';
            this.txtMonHocID.PlaceholderText = "";
            this.txtMonHocID.SelectedText = "";
            this.txtMonHocID.ShadowDecoration.Parent = this.txtMonHocID;
            this.txtMonHocID.Size = new System.Drawing.Size(340, 54);
            this.txtMonHocID.TabIndex = 33;
            this.txtMonHocID.TextOffset = new System.Drawing.Point(8, 0);
            // 
            // Panel1
            // 
            this.Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel1.BorderColor = System.Drawing.Color.DodgerBlue;
            this.Panel1.BorderRadius = 10;
            this.Panel1.BorderThickness = 1;
            this.Panel1.Controls.Add(this.dgvMonHoc);
            this.Panel1.Location = new System.Drawing.Point(50, 354);
            this.Panel1.Margin = new System.Windows.Forms.Padding(4);
            this.Panel1.Name = "Panel1";
            this.Panel1.ShadowDecoration.Parent = this.Panel1;
            this.Panel1.Size = new System.Drawing.Size(1063, 403);
            this.Panel1.TabIndex = 30;
            // 
            // dgvMonHoc
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvMonHoc.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvMonHoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMonHoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMonHoc.BackgroundColor = System.Drawing.Color.White;
            this.dgvMonHoc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMonHoc.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMonHoc.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMonHoc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvMonHoc.ColumnHeadersHeight = 4;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMonHoc.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvMonHoc.EnableHeadersVisualStyles = false;
            this.dgvMonHoc.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMonHoc.Location = new System.Drawing.Point(15, 20);
            this.dgvMonHoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvMonHoc.Name = "dgvMonHoc";
            this.dgvMonHoc.RowHeadersVisible = false;
            this.dgvMonHoc.RowHeadersWidth = 51;
            this.dgvMonHoc.RowTemplate.Height = 24;
            this.dgvMonHoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMonHoc.Size = new System.Drawing.Size(1004, 364);
            this.dgvMonHoc.TabIndex = 31;
            this.dgvMonHoc.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvMonHoc.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvMonHoc.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvMonHoc.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvMonHoc.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvMonHoc.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvMonHoc.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvMonHoc.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMonHoc.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvMonHoc.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvMonHoc.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvMonHoc.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvMonHoc.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvMonHoc.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvMonHoc.ThemeStyle.ReadOnly = false;
            this.dgvMonHoc.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvMonHoc.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMonHoc.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvMonHoc.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvMonHoc.ThemeStyle.RowsStyle.Height = 24;
            this.dgvMonHoc.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMonHoc.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Panel2
            // 
            this.Panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel2.BorderColor = System.Drawing.Color.DodgerBlue;
            this.Panel2.BorderRadius = 10;
            this.Panel2.BorderThickness = 1;
            this.Panel2.Controls.Add(this.dtNgayBatDau);
            this.Panel2.Controls.Add(this.lblNgayBatDau);
            this.Panel2.Controls.Add(this.lblHocPhi);
            this.Panel2.Controls.Add(this.lblTenMH);
            this.Panel2.Controls.Add(this.lblMaMH);
            this.Panel2.Controls.Add(this.lblTenGiangVien);
            this.Panel2.Controls.Add(this.btnXoa);
            this.Panel2.Controls.Add(this.btnSua);
            this.Panel2.Controls.Add(this.btnThem);
            this.Panel2.Controls.Add(this.cboGiangVienID);
            this.Panel2.Controls.Add(this.txtHocPhi);
            this.Panel2.Controls.Add(this.txtTenMonHoc);
            this.Panel2.Controls.Add(this.txtMonHocID);
            this.Panel2.Location = new System.Drawing.Point(50, 23);
            this.Panel2.Margin = new System.Windows.Forms.Padding(4);
            this.Panel2.Name = "Panel2";
            this.Panel2.ShadowDecoration.Parent = this.Panel2;
            this.Panel2.Size = new System.Drawing.Size(1063, 308);
            this.Panel2.TabIndex = 31;
            // 
            // frmQuanLyChuyenDi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 780);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.Panel2);
            this.Name = "frmQuanLyChuyenDi";
            this.Text = "frmQuanLyChuyenDi";
            this.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonHoc)).EndInit();
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Guna.UI2.WinForms.Guna2DateTimePicker dtNgayBatDau;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNgayBatDau;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblHocPhi;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTenMH;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblMaMH;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTenGiangVien;
        internal Guna.UI2.WinForms.Guna2Button btnXoa;
        internal Guna.UI2.WinForms.Guna2Button btnSua;
        internal Guna.UI2.WinForms.Guna2Button btnThem;
        private Guna.UI2.WinForms.Guna2ComboBox cboGiangVienID;
        private Guna.UI2.WinForms.Guna2TextBox txtHocPhi;
        private Guna.UI2.WinForms.Guna2TextBox txtTenMonHoc;
        private Guna.UI2.WinForms.Guna2TextBox txtMonHocID;
        internal Guna.UI2.WinForms.Guna2Panel Panel1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvMonHoc;
        internal Guna.UI2.WinForms.Guna2Panel Panel2;
    }
}