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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyVe));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtNgayBatDau = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.btnSua = new Guna.UI2.WinForms.Guna2Button();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            this.txtSeatNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTicketID = new Guna.UI2.WinForms.Guna2TextBox();
            this.Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvVe = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVe)).BeginInit();
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
            this.dtNgayBatDau.Location = new System.Drawing.Point(591, 43);
            this.dtNgayBatDau.Margin = new System.Windows.Forms.Padding(4);
            this.dtNgayBatDau.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtNgayBatDau.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtNgayBatDau.Name = "dtNgayBatDau";
            this.dtNgayBatDau.ShadowDecoration.Parent = this.dtNgayBatDau;
            this.dtNgayBatDau.Size = new System.Drawing.Size(161, 41);
            this.dtNgayBatDau.TabIndex = 48;
            this.dtNgayBatDau.Value = new System.DateTime(2021, 7, 5, 12, 52, 33, 197);
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
            this.btnXoa.Location = new System.Drawing.Point(978, 228);
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
            this.btnSua.Location = new System.Drawing.Point(784, 228);
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
            this.btnThem.Location = new System.Drawing.Point(591, 228);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.ShadowDecoration.Parent = this.btnThem;
            this.btnThem.Size = new System.Drawing.Size(136, 50);
            this.btnThem.TabIndex = 39;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtSeatNumber
            // 
            this.txtSeatNumber.AutoRoundedCorners = true;
            this.txtSeatNumber.BorderRadius = 26;
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
            this.txtSeatNumber.Location = new System.Drawing.Point(67, 138);
            this.txtSeatNumber.Margin = new System.Windows.Forms.Padding(15, 11, 15, 11);
            this.txtSeatNumber.Name = "txtSeatNumber";
            this.txtSeatNumber.PasswordChar = '\0';
            this.txtSeatNumber.PlaceholderText = "";
            this.txtSeatNumber.SelectedText = "";
            this.txtSeatNumber.ShadowDecoration.Parent = this.txtSeatNumber;
            this.txtSeatNumber.Size = new System.Drawing.Size(340, 54);
            this.txtSeatNumber.TabIndex = 35;
            this.txtSeatNumber.TextOffset = new System.Drawing.Point(8, 0);
            // 
            // txtTicketID
            // 
            this.txtTicketID.AutoRoundedCorners = true;
            this.txtTicketID.BorderRadius = 26;
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
            this.txtTicketID.Location = new System.Drawing.Point(67, 43);
            this.txtTicketID.Margin = new System.Windows.Forms.Padding(15, 11, 15, 11);
            this.txtTicketID.Name = "txtTicketID";
            this.txtTicketID.PasswordChar = '\0';
            this.txtTicketID.PlaceholderText = "";
            this.txtTicketID.SelectedText = "";
            this.txtTicketID.ShadowDecoration.Parent = this.txtTicketID;
            this.txtTicketID.Size = new System.Drawing.Size(340, 54);
            this.txtTicketID.TabIndex = 33;
            this.txtTicketID.TextOffset = new System.Drawing.Point(8, 0);
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
            this.Panel1.Location = new System.Drawing.Point(16, 364);
            this.Panel1.Margin = new System.Windows.Forms.Padding(4);
            this.Panel1.Name = "Panel1";
            this.Panel1.ShadowDecoration.Parent = this.Panel1;
            this.Panel1.Size = new System.Drawing.Size(1158, 381);
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
            this.dgvVe.Location = new System.Drawing.Point(17, 17);
            this.dgvVe.Margin = new System.Windows.Forms.Padding(4);
            this.dgvVe.Name = "dgvVe";
            this.dgvVe.ReadOnly = true;
            this.dgvVe.RowHeadersVisible = false;
            this.dgvVe.RowHeadersWidth = 51;
            this.dgvVe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVe.Size = new System.Drawing.Size(1117, 360);
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
            // Panel2
            // 
            this.Panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel2.BorderColor = System.Drawing.Color.DodgerBlue;
            this.Panel2.BorderRadius = 10;
            this.Panel2.BorderThickness = 1;
            this.Panel2.Controls.Add(this.label3);
            this.Panel2.Controls.Add(this.label2);
            this.Panel2.Controls.Add(this.label1);
            this.Panel2.Controls.Add(this.dtNgayBatDau);
            this.Panel2.Controls.Add(this.btnXoa);
            this.Panel2.Controls.Add(this.btnSua);
            this.Panel2.Controls.Add(this.btnThem);
            this.Panel2.Controls.Add(this.txtSeatNumber);
            this.Panel2.Controls.Add(this.txtTicketID);
            this.Panel2.Location = new System.Drawing.Point(16, 33);
            this.Panel2.Margin = new System.Windows.Forms.Padding(4);
            this.Panel2.Name = "Panel2";
            this.Panel2.ShadowDecoration.Parent = this.Panel2;
            this.Panel2.Size = new System.Drawing.Size(1158, 308);
            this.Panel2.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(564, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 52;
            this.label3.Text = "Ngày bắt đầu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 51;
            this.label2.Text = "Số ghế";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 50;
            this.label1.Text = "Mã vé";
            // 
            // frmQuanLyVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 774);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.Panel2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmQuanLyVe";
            this.Text = "frmQuanLyVe";
            this.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVe)).EndInit();
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        internal Guna.UI2.WinForms.Guna2DateTimePicker dtNgayBatDau;
        internal Guna.UI2.WinForms.Guna2Button btnXoa;
        internal Guna.UI2.WinForms.Guna2Button btnSua;
        internal Guna.UI2.WinForms.Guna2Button btnThem;
        private Guna.UI2.WinForms.Guna2TextBox txtSeatNumber;
        private Guna.UI2.WinForms.Guna2TextBox txtTicketID;
        internal Guna.UI2.WinForms.Guna2Panel Panel1;
        internal Guna.UI2.WinForms.Guna2Panel Panel2;
        private Guna.UI2.WinForms.Guna2DataGridView dgvVe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}