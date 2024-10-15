namespace QLXeKhach
{
    partial class frmQuanLyVe
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyVe));
            this.Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvVe = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txtTicketID = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSeatNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSoGhe = new System.Windows.Forms.Label();
            this.Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblNgayKhoiHanh = new System.Windows.Forms.Label();
            this.txtGia = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTenHanhKhach = new System.Windows.Forms.Label();
            this.txtTenHanhKhach = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblDiemDen = new System.Windows.Forms.Label();
            this.lblDiemDi = new System.Windows.Forms.Label();
            this.lblGia = new System.Windows.Forms.Label();
            this.cboNhaXe = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblTenNhaXe = new System.Windows.Forms.Label();
            this.dtpNgayKhoiHanh = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnInVe = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.btnSua = new Guna.UI2.WinForms.Guna2Button();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            this.txtDiemDi = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDiemDen = new Guna.UI2.WinForms.Guna2TextBox();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVe)).BeginInit();
            this.Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel1.BorderColor = System.Drawing.Color.DodgerBlue;
            this.Panel1.BorderRadius = 10;
            this.Panel1.BorderThickness = 1;
            this.Panel1.Controls.Add(this.dgvVe);
            this.Panel1.Location = new System.Drawing.Point(12, 296);
            this.Panel1.Name = "Panel1";
            this.Panel1.ShadowDecoration.Parent = this.Panel1;
            this.Panel1.Size = new System.Drawing.Size(868, 310);
            this.Panel1.TabIndex = 30;
            // 
            // dgvVe
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvVe.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVe.BackgroundColor = System.Drawing.Color.White;
            this.dgvVe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVe.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvVe.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvVe.ColumnHeadersHeight = 25;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVe.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvVe.EnableHeadersVisualStyles = false;
            this.dgvVe.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvVe.Location = new System.Drawing.Point(13, 14);
            this.dgvVe.Name = "dgvVe";
            this.dgvVe.ReadOnly = true;
            this.dgvVe.RowHeadersVisible = false;
            this.dgvVe.RowHeadersWidth = 51;
            this.dgvVe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVe.Size = new System.Drawing.Size(838, 292);
            this.dgvVe.TabIndex = 30;
            this.dgvVe.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvVe.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvVe.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvVe.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvVe.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvVe.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvVe.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvVe.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvVe.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvVe.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvVe.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvVe.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvVe.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvVe.ThemeStyle.HeaderStyle.Height = 25;
            this.dgvVe.ThemeStyle.ReadOnly = true;
            this.dgvVe.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvVe.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvVe.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvVe.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvVe.ThemeStyle.RowsStyle.Height = 22;
            this.dgvVe.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvVe.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvVe.SelectionChanged += new System.EventHandler(this.dgvMonHoc_SelectionChanged);
            // 
            // txtTicketID
            // 
            this.txtTicketID.AutoRoundedCorners = true;
            this.txtTicketID.BorderRadius = 18;
            this.txtTicketID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTicketID.DefaultText = "";
            this.txtTicketID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTicketID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTicketID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTicketID.DisabledState.Parent = this.txtTicketID;
            this.txtTicketID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTicketID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTicketID.FocusedState.Parent = this.txtTicketID;
            this.txtTicketID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTicketID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTicketID.HoverState.Parent = this.txtTicketID;
            this.txtTicketID.Location = new System.Drawing.Point(35, 28);
            this.txtTicketID.Margin = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.txtTicketID.Name = "txtTicketID";
            this.txtTicketID.PasswordChar = '\0';
            this.txtTicketID.PlaceholderText = "";
            this.txtTicketID.SelectedText = "";
            this.txtTicketID.ShadowDecoration.Parent = this.txtTicketID;
            this.txtTicketID.Size = new System.Drawing.Size(255, 38);
            this.txtTicketID.TabIndex = 33;
            this.txtTicketID.TextOffset = new System.Drawing.Point(8, 0);
            // 
            // txtSeatNumber
            // 
            this.txtSeatNumber.AutoRoundedCorners = true;
            this.txtSeatNumber.BorderRadius = 18;
            this.txtSeatNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSeatNumber.DefaultText = "";
            this.txtSeatNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSeatNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSeatNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSeatNumber.DisabledState.Parent = this.txtSeatNumber;
            this.txtSeatNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSeatNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSeatNumber.FocusedState.Parent = this.txtSeatNumber;
            this.txtSeatNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSeatNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSeatNumber.HoverState.Parent = this.txtSeatNumber;
            this.txtSeatNumber.Location = new System.Drawing.Point(35, 153);
            this.txtSeatNumber.Margin = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.txtSeatNumber.Name = "txtSeatNumber";
            this.txtSeatNumber.PasswordChar = '\0';
            this.txtSeatNumber.PlaceholderText = "";
            this.txtSeatNumber.SelectedText = "";
            this.txtSeatNumber.ShadowDecoration.Parent = this.txtSeatNumber;
            this.txtSeatNumber.Size = new System.Drawing.Size(255, 38);
            this.txtSeatNumber.TabIndex = 35;
            this.txtSeatNumber.TextOffset = new System.Drawing.Point(8, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 50;
            this.label1.Text = "Mã vé";
            // 
            // lblSoGhe
            // 
            this.lblSoGhe.AutoSize = true;
            this.lblSoGhe.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoGhe.Location = new System.Drawing.Point(17, 138);
            this.lblSoGhe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSoGhe.Name = "lblSoGhe";
            this.lblSoGhe.Size = new System.Drawing.Size(38, 15);
            this.lblSoGhe.TabIndex = 51;
            this.lblSoGhe.Text = "Số ghế";
            // 
            // Panel2
            // 
            this.Panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel2.BorderColor = System.Drawing.Color.DodgerBlue;
            this.Panel2.BorderRadius = 10;
            this.Panel2.BorderThickness = 1;
            this.Panel2.Controls.Add(this.txtDiemDen);
            this.Panel2.Controls.Add(this.txtDiemDi);
            this.Panel2.Controls.Add(this.lblNgayKhoiHanh);
            this.Panel2.Controls.Add(this.txtGia);
            this.Panel2.Controls.Add(this.lblTenHanhKhach);
            this.Panel2.Controls.Add(this.txtTenHanhKhach);
            this.Panel2.Controls.Add(this.lblDiemDen);
            this.Panel2.Controls.Add(this.lblDiemDi);
            this.Panel2.Controls.Add(this.lblGia);
            this.Panel2.Controls.Add(this.cboNhaXe);
            this.Panel2.Controls.Add(this.lblTenNhaXe);
            this.Panel2.Controls.Add(this.dtpNgayKhoiHanh);
            this.Panel2.Controls.Add(this.btnInVe);
            this.Panel2.Controls.Add(this.lblSoGhe);
            this.Panel2.Controls.Add(this.label1);
            this.Panel2.Controls.Add(this.btnXoa);
            this.Panel2.Controls.Add(this.btnSua);
            this.Panel2.Controls.Add(this.btnThem);
            this.Panel2.Controls.Add(this.txtSeatNumber);
            this.Panel2.Controls.Add(this.txtTicketID);
            this.Panel2.Location = new System.Drawing.Point(12, 27);
            this.Panel2.Name = "Panel2";
            this.Panel2.ShadowDecoration.Parent = this.Panel2;
            this.Panel2.Size = new System.Drawing.Size(868, 250);
            this.Panel2.TabIndex = 31;
            // 
            // lblNgayKhoiHanh
            // 
            this.lblNgayKhoiHanh.AutoSize = true;
            this.lblNgayKhoiHanh.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayKhoiHanh.Location = new System.Drawing.Point(329, 74);
            this.lblNgayKhoiHanh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNgayKhoiHanh.Name = "lblNgayKhoiHanh";
            this.lblNgayKhoiHanh.Size = new System.Drawing.Size(83, 15);
            this.lblNgayKhoiHanh.TabIndex = 71;
            this.lblNgayKhoiHanh.Text = "Ngày khởi hành";
            // 
            // txtGia
            // 
            this.txtGia.AutoRoundedCorners = true;
            this.txtGia.BorderRadius = 18;
            this.txtGia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGia.DefaultText = "";
            this.txtGia.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGia.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGia.DisabledState.Parent = this.txtGia;
            this.txtGia.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGia.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGia.FocusedState.Parent = this.txtGia;
            this.txtGia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGia.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGia.HoverState.Parent = this.txtGia;
            this.txtGia.Location = new System.Drawing.Point(346, 28);
            this.txtGia.Margin = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.txtGia.Name = "txtGia";
            this.txtGia.PasswordChar = '\0';
            this.txtGia.PlaceholderText = "";
            this.txtGia.SelectedText = "";
            this.txtGia.ShadowDecoration.Parent = this.txtGia;
            this.txtGia.Size = new System.Drawing.Size(255, 38);
            this.txtGia.TabIndex = 70;
            this.txtGia.TextOffset = new System.Drawing.Point(8, 0);
            // 
            // lblTenHanhKhach
            // 
            this.lblTenHanhKhach.AutoSize = true;
            this.lblTenHanhKhach.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenHanhKhach.Location = new System.Drawing.Point(328, 138);
            this.lblTenHanhKhach.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTenHanhKhach.Name = "lblTenHanhKhach";
            this.lblTenHanhKhach.Size = new System.Drawing.Size(83, 15);
            this.lblTenHanhKhach.TabIndex = 69;
            this.lblTenHanhKhach.Text = "Tên hành khách";
            // 
            // txtTenHanhKhach
            // 
            this.txtTenHanhKhach.AutoRoundedCorners = true;
            this.txtTenHanhKhach.BorderRadius = 18;
            this.txtTenHanhKhach.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenHanhKhach.DefaultText = "";
            this.txtTenHanhKhach.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenHanhKhach.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenHanhKhach.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenHanhKhach.DisabledState.Parent = this.txtTenHanhKhach;
            this.txtTenHanhKhach.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenHanhKhach.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenHanhKhach.FocusedState.Parent = this.txtTenHanhKhach;
            this.txtTenHanhKhach.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenHanhKhach.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenHanhKhach.HoverState.Parent = this.txtTenHanhKhach;
            this.txtTenHanhKhach.Location = new System.Drawing.Point(346, 153);
            this.txtTenHanhKhach.Margin = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.txtTenHanhKhach.Name = "txtTenHanhKhach";
            this.txtTenHanhKhach.PasswordChar = '\0';
            this.txtTenHanhKhach.PlaceholderText = "";
            this.txtTenHanhKhach.SelectedText = "";
            this.txtTenHanhKhach.ShadowDecoration.Parent = this.txtTenHanhKhach;
            this.txtTenHanhKhach.Size = new System.Drawing.Size(255, 38);
            this.txtTenHanhKhach.TabIndex = 68;
            this.txtTenHanhKhach.TextOffset = new System.Drawing.Point(8, 0);
            // 
            // lblDiemDen
            // 
            this.lblDiemDen.AutoSize = true;
            this.lblDiemDen.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiemDen.Location = new System.Drawing.Point(642, 75);
            this.lblDiemDen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDiemDen.Name = "lblDiemDen";
            this.lblDiemDen.Size = new System.Drawing.Size(53, 15);
            this.lblDiemDen.TabIndex = 65;
            this.lblDiemDen.Text = "Điểm đến";
            // 
            // lblDiemDi
            // 
            this.lblDiemDi.AutoSize = true;
            this.lblDiemDi.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiemDi.Location = new System.Drawing.Point(642, 11);
            this.lblDiemDi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDiemDi.Name = "lblDiemDi";
            this.lblDiemDi.Size = new System.Drawing.Size(45, 15);
            this.lblDiemDi.TabIndex = 64;
            this.lblDiemDi.Text = "Điểm đi";
            // 
            // lblGia
            // 
            this.lblGia.AutoSize = true;
            this.lblGia.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGia.Location = new System.Drawing.Point(329, 12);
            this.lblGia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(24, 15);
            this.lblGia.TabIndex = 60;
            this.lblGia.Text = "Giá";
            // 
            // cboNhaXe
            // 
            this.cboNhaXe.BackColor = System.Drawing.Color.Transparent;
            this.cboNhaXe.BorderRadius = 20;
            this.cboNhaXe.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboNhaXe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNhaXe.FocusedColor = System.Drawing.Color.Empty;
            this.cboNhaXe.FocusedState.Parent = this.cboNhaXe;
            this.cboNhaXe.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboNhaXe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboNhaXe.FormattingEnabled = true;
            this.cboNhaXe.HoverState.Parent = this.cboNhaXe;
            this.cboNhaXe.ItemHeight = 30;
            this.cboNhaXe.ItemsAppearance.Parent = this.cboNhaXe;
            this.cboNhaXe.Location = new System.Drawing.Point(35, 92);
            this.cboNhaXe.Name = "cboNhaXe";
            this.cboNhaXe.ShadowDecoration.Parent = this.cboNhaXe;
            this.cboNhaXe.Size = new System.Drawing.Size(255, 36);
            this.cboNhaXe.TabIndex = 59;
            // 
            // lblTenNhaXe
            // 
            this.lblTenNhaXe.AutoSize = true;
            this.lblTenNhaXe.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenNhaXe.Location = new System.Drawing.Point(17, 74);
            this.lblTenNhaXe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTenNhaXe.Name = "lblTenNhaXe";
            this.lblTenNhaXe.Size = new System.Drawing.Size(40, 15);
            this.lblTenNhaXe.TabIndex = 58;
            this.lblTenNhaXe.Text = "Nhà xe";
            // 
            // dtpNgayKhoiHanh
            // 
            this.dtpNgayKhoiHanh.BorderRadius = 15;
            this.dtpNgayKhoiHanh.CheckedState.Parent = this.dtpNgayKhoiHanh;
            this.dtpNgayKhoiHanh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtpNgayKhoiHanh.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpNgayKhoiHanh.HoverState.Parent = this.dtpNgayKhoiHanh;
            this.dtpNgayKhoiHanh.Location = new System.Drawing.Point(346, 92);
            this.dtpNgayKhoiHanh.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgayKhoiHanh.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgayKhoiHanh.Name = "dtpNgayKhoiHanh";
            this.dtpNgayKhoiHanh.ShadowDecoration.Parent = this.dtpNgayKhoiHanh;
            this.dtpNgayKhoiHanh.Size = new System.Drawing.Size(255, 36);
            this.dtpNgayKhoiHanh.TabIndex = 56;
            this.dtpNgayKhoiHanh.Value = new System.DateTime(2024, 10, 15, 14, 27, 22, 95);
            // 
            // btnInVe
            // 
            this.btnInVe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInVe.BorderRadius = 20;
            this.btnInVe.CheckedState.Parent = this.btnInVe;
            this.btnInVe.CustomImages.Parent = this.btnInVe;
            this.btnInVe.FillColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnInVe.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInVe.ForeColor = System.Drawing.Color.White;
            this.btnInVe.HoverState.Parent = this.btnInVe;
            this.btnInVe.Image = global::QLXeKhach.Properties.Resources.iconPrint;
            this.btnInVe.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnInVe.ImageSize = new System.Drawing.Size(30, 30);
            this.btnInVe.Location = new System.Drawing.Point(690, 199);
            this.btnInVe.Name = "btnInVe";
            this.btnInVe.ShadowDecoration.Parent = this.btnInVe;
            this.btnInVe.Size = new System.Drawing.Size(102, 41);
            this.btnInVe.TabIndex = 53;
            this.btnInVe.Text = "In vé";
            this.btnInVe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnInVe.Click += new System.EventHandler(this.btnInVe_Click);
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
            this.btnXoa.Location = new System.Drawing.Point(499, 199);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ShadowDecoration.Parent = this.btnXoa;
            this.btnXoa.Size = new System.Drawing.Size(102, 41);
            this.btnXoa.TabIndex = 41;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
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
            this.btnSua.Location = new System.Drawing.Point(308, 199);
            this.btnSua.Name = "btnSua";
            this.btnSua.ShadowDecoration.Parent = this.btnSua;
            this.btnSua.Size = new System.Drawing.Size(102, 41);
            this.btnSua.TabIndex = 40;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
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
            this.btnThem.Location = new System.Drawing.Point(117, 199);
            this.btnThem.Name = "btnThem";
            this.btnThem.ShadowDecoration.Parent = this.btnThem;
            this.btnThem.Size = new System.Drawing.Size(102, 41);
            this.btnThem.TabIndex = 39;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtDiemDi
            // 
            this.txtDiemDi.AutoRoundedCorners = true;
            this.txtDiemDi.BorderRadius = 18;
            this.txtDiemDi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiemDi.DefaultText = "";
            this.txtDiemDi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDiemDi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDiemDi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiemDi.DisabledState.Parent = this.txtDiemDi;
            this.txtDiemDi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiemDi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiemDi.FocusedState.Parent = this.txtDiemDi;
            this.txtDiemDi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiemDi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiemDi.HoverState.Parent = this.txtDiemDi;
            this.txtDiemDi.Location = new System.Drawing.Point(660, 28);
            this.txtDiemDi.Margin = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.txtDiemDi.Name = "txtDiemDi";
            this.txtDiemDi.PasswordChar = '\0';
            this.txtDiemDi.PlaceholderText = "";
            this.txtDiemDi.SelectedText = "";
            this.txtDiemDi.ShadowDecoration.Parent = this.txtDiemDi;
            this.txtDiemDi.Size = new System.Drawing.Size(157, 38);
            this.txtDiemDi.TabIndex = 72;
            this.txtDiemDi.TextOffset = new System.Drawing.Point(8, 0);
            // 
            // txtDiemDen
            // 
            this.txtDiemDen.AutoRoundedCorners = true;
            this.txtDiemDen.BorderRadius = 18;
            this.txtDiemDen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiemDen.DefaultText = "";
            this.txtDiemDen.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDiemDen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDiemDen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiemDen.DisabledState.Parent = this.txtDiemDen;
            this.txtDiemDen.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiemDen.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiemDen.FocusedState.Parent = this.txtDiemDen;
            this.txtDiemDen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiemDen.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiemDen.HoverState.Parent = this.txtDiemDen;
            this.txtDiemDen.Location = new System.Drawing.Point(660, 90);
            this.txtDiemDen.Margin = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.txtDiemDen.Name = "txtDiemDen";
            this.txtDiemDen.PasswordChar = '\0';
            this.txtDiemDen.PlaceholderText = "";
            this.txtDiemDen.SelectedText = "";
            this.txtDiemDen.ShadowDecoration.Parent = this.txtDiemDen;
            this.txtDiemDen.Size = new System.Drawing.Size(157, 38);
            this.txtDiemDen.TabIndex = 73;
            this.txtDiemDen.TextOffset = new System.Drawing.Point(8, 0);
            // 
            // frmQuanLyVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 609);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.Panel2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmQuanLyVe";
            this.Text = "frmQuanLyVe";
            this.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVe)).EndInit();
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        internal Guna.UI2.WinForms.Guna2Panel Panel1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvVe;
        private Guna.UI2.WinForms.Guna2TextBox txtTicketID;
        private Guna.UI2.WinForms.Guna2TextBox txtSeatNumber;
        internal Guna.UI2.WinForms.Guna2Button btnThem;
        internal Guna.UI2.WinForms.Guna2Button btnSua;
        internal Guna.UI2.WinForms.Guna2Button btnXoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSoGhe;
        internal Guna.UI2.WinForms.Guna2Button btnInVe;
        internal Guna.UI2.WinForms.Guna2Panel Panel2;
        private System.Windows.Forms.Label lblTenNhaXe;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgayKhoiHanh;
        private System.Windows.Forms.Label lblDiemDen;
        private System.Windows.Forms.Label lblDiemDi;
        private System.Windows.Forms.Label lblGia;
        private Guna.UI2.WinForms.Guna2ComboBox cboNhaXe;
        private System.Windows.Forms.Label lblTenHanhKhach;
        private Guna.UI2.WinForms.Guna2TextBox txtTenHanhKhach;
        private Guna.UI2.WinForms.Guna2TextBox txtGia;
        private System.Windows.Forms.Label lblNgayKhoiHanh;
        private Guna.UI2.WinForms.Guna2TextBox txtDiemDen;
        private Guna.UI2.WinForms.Guna2TextBox txtDiemDi;
    }
}