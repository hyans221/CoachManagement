using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLXeKhach
{
    public partial class frmTrangChu : Form
    {
        private readonly string _userRole;
        public frmTrangChu(string userRole)
        {
            InitializeComponent();
            _userRole = userRole;
            ConfigureUIBasedOnRole();
            this.FormClosing += FrmTrangChu_FormClosing;
        }

        private void container(object _form)
        {

            if (Panel_container.Controls.Count > 0) Panel_container.Controls.Clear();

            Form frm = _form as Form;
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            Panel_container.Controls.Add(frm);
            Panel_container.Tag = frm;
            frm.Show();

        }

        private void btnQL_Xe_Click(object sender, EventArgs e)
        {
            labelTitleFrm.Text = "QUẢN LÝ XE KHÁCH";
            container(new frmQuanLyXe());

        }

        private void btnQL_ChuyenDi_Click(object sender, EventArgs e)
        {
            labelTitleFrm.Text = "QUẢN LÝ CHUYẾN ĐI";
            container(new frmQuanLyChuyenDi());
        }

        private void btnQL_Ve_Click(object sender, EventArgs e)
        {
            labelTitleFrm.Text = "QUẢN LÝ VÉ";
            container(new frmQuanLyVe());
        }


        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            labelTitleFrm.Text = "TRANG CHỦ";
            container(new frmDecorPage());
            
        }

        private void btnQL_TaiKhoan_Click(object sender, EventArgs e)
        {

            labelTitleFrm.Text = "QUẢN LÝ TÀI KHOẢN";
            container(new frmQuanLyTK());

        }

        private void ConfigureUIBasedOnRole()
        {
            if (_userRole == "customer")
            {
                btnQL_TaiKhoan.Enabled = false; 
            }
        }

        private void FrmTrangChu_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmDangNhap dangNhap = new frmDangNhap();
            dangNhap.Show();
        }

        private void btnLocTheoNhaXe_Click(object sender, EventArgs e)
        {
            labelTitleFrm.Text = "LỌC THEO NHÀ XE";
            container(new frmBaoCaoTheoCTy());
        }

        private void btnLocTheoSoLuong_Click(object sender, EventArgs e)
        {
            labelTitleFrm.Text = "LỌC THEO SỐ LƯỢNG KHÁCH HÀNG";
            container(new frmBaoCaoTheoKhachHang());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
