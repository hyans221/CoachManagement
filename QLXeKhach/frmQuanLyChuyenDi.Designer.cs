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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyChuyenDi));
            this.dtDepartureTime = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblMaMH = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cboBusID = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtDestination = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDeparture = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTripsID = new Guna.UI2.WinForms.Guna2TextBox();
            this.Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvChuyenDi = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.btnSua = new Guna.UI2.WinForms.Guna2Button();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChuyenDi)).BeginInit();
            this.Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtDepartureTime
            // 
            this.dtDepartureTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtDepartureTime.BorderColor = System.Drawing.Color.DodgerBlue;
            this.dtDepartureTime.BorderRadius = 10;
            this.dtDepartureTime.BorderThickness = 1;
            this.dtDepartureTime.CheckedState.Parent = this.dtDepartureTime;
            this.dtDepartureTime.FillColor = System.Drawing.Color.White;
            this.dtDepartureTime.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDepartureTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDepartureTime.HoverState.Parent = this.dtDepartureTime;
            this.dtDepartureTime.Location = new System.Drawing.Point(564, 43);
            this.dtDepartureTime.Margin = new System.Windows.Forms.Padding(4);
            this.dtDepartureTime.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtDepartureTime.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtDepartureTime.Name = "dtDepartureTime";
            this.dtDepartureTime.ShadowDecoration.Parent = this.dtDepartureTime;
            this.dtDepartureTime.Size = new System.Drawing.Size(163, 41);
            this.dtDepartureTime.TabIndex = 48;
            this.dtDepartureTime.Value = new System.DateTime(2021, 7, 5, 12, 52, 33, 197);
            // 
            // lblMaMH
            // 
            this.lblMaMH.BackColor = System.Drawing.Color.Transparent;
            this.lblMaMH.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaMH.Location = new System.Drawing.Point(29, 17);
            this.lblMaMH.Margin = new System.Windows.Forms.Padding(4);
            this.lblMaMH.Name = "lblMaMH";
            this.lblMaMH.Size = new System.Drawing.Size(3, 2);
            this.lblMaMH.TabIndex = 43;
            this.lblMaMH.Text = null;
            // 
            // cboBusID
            // 
            this.cboBusID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboBusID.BackColor = System.Drawing.Color.Transparent;
            this.cboBusID.BorderRadius = 20;
            this.cboBusID.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboBusID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBusID.FocusedColor = System.Drawing.Color.Empty;
            this.cboBusID.FocusedState.Parent = this.cboBusID;
            this.cboBusID.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBusID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboBusID.FormattingEnabled = true;
            this.cboBusID.HoverState.Parent = this.cboBusID;
            this.cboBusID.ItemHeight = 30;
            this.cboBusID.ItemsAppearance.Parent = this.cboBusID;
            this.cboBusID.Location = new System.Drawing.Point(564, 138);
            this.cboBusID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboBusID.Name = "cboBusID";
            this.cboBusID.ShadowDecoration.Parent = this.cboBusID;
            this.cboBusID.Size = new System.Drawing.Size(375, 36);
            this.cboBusID.TabIndex = 38;
            // 
            // txtDestination
            // 
            this.txtDestination.AutoRoundedCorners = true;
            this.txtDestination.BorderRadius = 26;
            this.txtDestination.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDestination.DefaultText = "";
            this.txtDestination.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDestination.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDestination.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDestination.DisabledState.Parent = this.txtDestination;
            this.txtDestination.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDestination.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDestination.FocusedState.Parent = this.txtDestination;
            this.txtDestination.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDestination.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDestination.HoverState.Parent = this.txtDestination;
            this.txtDestination.Location = new System.Drawing.Point(67, 233);
            this.txtDestination.Margin = new System.Windows.Forms.Padding(15, 11, 15, 11);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.PasswordChar = '\0';
            this.txtDestination.PlaceholderText = "";
            this.txtDestination.SelectedText = "";
            this.txtDestination.ShadowDecoration.Parent = this.txtDestination;
            this.txtDestination.Size = new System.Drawing.Size(340, 54);
            this.txtDestination.TabIndex = 34;
            this.txtDestination.TextOffset = new System.Drawing.Point(8, 0);
            // 
            // txtDeparture
            // 
            this.txtDeparture.AutoRoundedCorners = true;
            this.txtDeparture.BorderRadius = 26;
            this.txtDeparture.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDeparture.DefaultText = "";
            this.txtDeparture.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDeparture.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDeparture.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDeparture.DisabledState.Parent = this.txtDeparture;
            this.txtDeparture.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDeparture.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDeparture.FocusedState.Parent = this.txtDeparture;
            this.txtDeparture.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeparture.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDeparture.HoverState.Parent = this.txtDeparture;
            this.txtDeparture.Location = new System.Drawing.Point(67, 138);
            this.txtDeparture.Margin = new System.Windows.Forms.Padding(15, 11, 15, 11);
            this.txtDeparture.Name = "txtDeparture";
            this.txtDeparture.PasswordChar = '\0';
            this.txtDeparture.PlaceholderText = "";
            this.txtDeparture.SelectedText = "";
            this.txtDeparture.ShadowDecoration.Parent = this.txtDeparture;
            this.txtDeparture.Size = new System.Drawing.Size(340, 54);
            this.txtDeparture.TabIndex = 35;
            this.txtDeparture.TextOffset = new System.Drawing.Point(8, 0);
            // 
            // txtTripsID
            // 
            this.txtTripsID.AutoRoundedCorners = true;
            this.txtTripsID.BorderRadius = 26;
            this.txtTripsID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTripsID.DefaultText = "";
            this.txtTripsID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTripsID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTripsID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTripsID.DisabledState.Parent = this.txtTripsID;
            this.txtTripsID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTripsID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTripsID.FocusedState.Parent = this.txtTripsID;
            this.txtTripsID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTripsID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTripsID.HoverState.Parent = this.txtTripsID;
            this.txtTripsID.Location = new System.Drawing.Point(67, 43);
            this.txtTripsID.Margin = new System.Windows.Forms.Padding(15, 11, 15, 11);
            this.txtTripsID.Name = "txtTripsID";
            this.txtTripsID.PasswordChar = '\0';
            this.txtTripsID.PlaceholderText = "";
            this.txtTripsID.SelectedText = "";
            this.txtTripsID.ShadowDecoration.Parent = this.txtTripsID;
            this.txtTripsID.Size = new System.Drawing.Size(340, 54);
            this.txtTripsID.TabIndex = 33;
            this.txtTripsID.TextOffset = new System.Drawing.Point(8, 0);
            // 
            // Panel1
            // 
            this.Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel1.BorderColor = System.Drawing.Color.DodgerBlue;
            this.Panel1.BorderRadius = 10;
            this.Panel1.BorderThickness = 1;
            this.Panel1.Controls.Add(this.dgvChuyenDi);
            this.Panel1.Location = new System.Drawing.Point(51, 354);
            this.Panel1.Margin = new System.Windows.Forms.Padding(4);
            this.Panel1.Name = "Panel1";
            this.Panel1.ShadowDecoration.Parent = this.Panel1;
            this.Panel1.Size = new System.Drawing.Size(1063, 430);
            this.Panel1.TabIndex = 30;
            // 
            // dgvChuyenDi
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvChuyenDi.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvChuyenDi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvChuyenDi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChuyenDi.BackgroundColor = System.Drawing.Color.White;
            this.dgvChuyenDi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvChuyenDi.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvChuyenDi.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvChuyenDi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvChuyenDi.ColumnHeadersHeight = 25;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvChuyenDi.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvChuyenDi.EnableHeadersVisualStyles = false;
            this.dgvChuyenDi.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvChuyenDi.Location = new System.Drawing.Point(20, 18);
            this.dgvChuyenDi.Margin = new System.Windows.Forms.Padding(4);
            this.dgvChuyenDi.Name = "dgvChuyenDi";
            this.dgvChuyenDi.ReadOnly = true;
            this.dgvChuyenDi.RowHeadersVisible = false;
            this.dgvChuyenDi.RowHeadersWidth = 51;
            this.dgvChuyenDi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChuyenDi.Size = new System.Drawing.Size(1022, 367);
            this.dgvChuyenDi.TabIndex = 29;
            this.dgvChuyenDi.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvChuyenDi.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvChuyenDi.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvChuyenDi.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvChuyenDi.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvChuyenDi.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvChuyenDi.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvChuyenDi.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvChuyenDi.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvChuyenDi.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvChuyenDi.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvChuyenDi.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvChuyenDi.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvChuyenDi.ThemeStyle.HeaderStyle.Height = 25;
            this.dgvChuyenDi.ThemeStyle.ReadOnly = true;
            this.dgvChuyenDi.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvChuyenDi.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvChuyenDi.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvChuyenDi.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvChuyenDi.ThemeStyle.RowsStyle.Height = 22;
            this.dgvChuyenDi.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvChuyenDi.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvChuyenDi.SelectionChanged += new System.EventHandler(this.dgvMonHoc_SelectionChanged);
            // 
            // Panel2
            // 
            this.Panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel2.BorderColor = System.Drawing.Color.DodgerBlue;
            this.Panel2.BorderRadius = 10;
            this.Panel2.BorderThickness = 1;
            this.Panel2.Controls.Add(this.label5);
            this.Panel2.Controls.Add(this.label4);
            this.Panel2.Controls.Add(this.label3);
            this.Panel2.Controls.Add(this.label2);
            this.Panel2.Controls.Add(this.label1);
            this.Panel2.Controls.Add(this.dtDepartureTime);
            this.Panel2.Controls.Add(this.lblMaMH);
            this.Panel2.Controls.Add(this.btnXoa);
            this.Panel2.Controls.Add(this.btnSua);
            this.Panel2.Controls.Add(this.btnThem);
            this.Panel2.Controls.Add(this.cboBusID);
            this.Panel2.Controls.Add(this.txtDestination);
            this.Panel2.Controls.Add(this.txtDeparture);
            this.Panel2.Controls.Add(this.txtTripsID);
            this.Panel2.Location = new System.Drawing.Point(51, 23);
            this.Panel2.Margin = new System.Windows.Forms.Padding(4);
            this.Panel2.Name = "Panel2";
            this.Panel2.ShadowDecoration.Parent = this.Panel2;
            this.Panel2.Size = new System.Drawing.Size(1063, 308);
            this.Panel2.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(516, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 17);
            this.label5.TabIndex = 55;
            this.label5.Text = "Xe Khách Thực Hiện";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(516, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 17);
            this.label4.TabIndex = 54;
            this.label4.Text = "Thời Gian Khởi Hành";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 53;
            this.label3.Text = "Mã Chuyến Đi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 52;
            this.label2.Text = "Điểm Đến";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 51;
            this.label1.Text = "Điểm Xuất Phát";
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
            this.btnSua.Location = new System.Drawing.Point(689, 228);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.ShadowDecoration.Parent = this.btnSua;
            this.btnSua.Size = new System.Drawing.Size(136, 50);
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
            this.btnThem.Location = new System.Drawing.Point(496, 228);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.ShadowDecoration.Parent = this.btnThem;
            this.btnThem.Size = new System.Drawing.Size(136, 50);
            this.btnThem.TabIndex = 39;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // frmQuanLyChuyenDi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 797);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.Panel2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmQuanLyChuyenDi";
            this.Text = "frmQuanLyChuyenDi";
            this.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChuyenDi)).EndInit();
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Guna.UI2.WinForms.Guna2DateTimePicker dtDepartureTime;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblMaMH;
        internal Guna.UI2.WinForms.Guna2Button btnXoa;
        internal Guna.UI2.WinForms.Guna2Button btnSua;
        internal Guna.UI2.WinForms.Guna2Button btnThem;
        private Guna.UI2.WinForms.Guna2ComboBox cboBusID;
        private Guna.UI2.WinForms.Guna2TextBox txtDestination;
        private Guna.UI2.WinForms.Guna2TextBox txtDeparture;
        private Guna.UI2.WinForms.Guna2TextBox txtTripsID;
        internal Guna.UI2.WinForms.Guna2Panel Panel1;
        internal Guna.UI2.WinForms.Guna2Panel Panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvChuyenDi;
    }
}