using MongoDB.Bson;
using MongoDB.Driver;
using Org.BouncyCastle.Crypto.Generators;
using System;
using System.Linq;
using BCrypt.Net;
using System.Windows.Forms;
using System.Data;

namespace QLXeKhach
{
    public partial class frmQuanLyTK : Form
    {
        private IMongoCollection<BsonDocument> _userCollection;
        private string originalPassword;

        public frmQuanLyTK()
        {
            InitializeComponent();
            _userCollection = MongodbConnect.GetCollection<BsonDocument>("user");
            LoadUserAccounts();
            InitializeComboBox();
        }

        private void InitializeComboBox()
        {
            cboQuyen.Items.Add("customer");
            cboQuyen.Items.Add("admin");
            cboQuyen.SelectedIndex = 0;
        }

        private void LoadUserAccounts()
        {
            var users = _userCollection.Find(new BsonDocument()).ToList();
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("username");
            dataTable.Columns.Add("role");
            dataTable.Columns.Add("_id");

            foreach (var user in users)
            {
                DataRow row = dataTable.NewRow();
                row["username"] = user["username"].AsString;
                row["role"] = user["role"].AsString;
                row["_id"] = user["_id"].ToString();
                dataTable.Rows.Add(row);
            }

            dgvTaiKhoan.DataSource = dataTable;
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenTK.Text) || string.IsNullOrWhiteSpace(txtMatKhau.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin tài khoản.");
                return;
            }

            originalPassword = txtMatKhau.Text;

            var newUser = new BsonDocument
            {
                { "username", txtTenTK.Text },
                { "password", BCrypt.Net.BCrypt.HashPassword(txtMatKhau.Text) },
                { "role", cboQuyen.SelectedItem.ToString() },
                { "customerId", BsonNull.Value }
            };

            _userCollection.InsertOne(newUser);
            MessageBox.Show("Tài khoản đã được thêm thành công.");
            LoadUserAccounts();
            ClearInputs();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvTaiKhoan.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn tài khoản cần sửa.");
                return;
            }

            var selectedUser = dgvTaiKhoan.SelectedRows[0];
            var userId = ObjectId.Parse(selectedUser.Cells["_id"].Value.ToString());

            var filter = Builders<BsonDocument>.Filter.Eq("_id", userId);
            var update = Builders<BsonDocument>.Update
                .Set("username", txtTenTK.Text)
                .Set("role", cboQuyen.SelectedItem.ToString());

            if (!string.IsNullOrWhiteSpace(txtMatKhau.Text))
            {
                originalPassword = txtMatKhau.Text;
                update = update.Set("password", BCrypt.Net.BCrypt.HashPassword(txtMatKhau.Text));
            }

            _userCollection.UpdateOne(filter, update);
            MessageBox.Show("Tài khoản đã được cập nhật thành công.");
            LoadUserAccounts();
            ClearInputs();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvTaiKhoan.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn tài khoản cần xóa.");
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa tài khoản này?", "Xác nhận xóa", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var selectedUser = dgvTaiKhoan.SelectedRows[0];
                var userId = ObjectId.Parse(selectedUser.Cells["_id"].Value.ToString());

                var filter = Builders<BsonDocument>.Filter.Eq("_id", userId);
                _userCollection.DeleteOne(filter);

                MessageBox.Show("Tài khoản đã được xóa thành công.");
                LoadUserAccounts();
                ClearInputs();
            }
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
            {
                txtMatKhau.UseSystemPasswordChar = false;
                txtMatKhau.Text = originalPassword; // Hiển thị mật khẩu gốc
            }
            else
            {
                txtMatKhau.UseSystemPasswordChar = true;
                txtMatKhau.Text = new string('*', originalPassword.Length); // Hiển thị mật khẩu đã hash
            }
        }

        private void dgvTaiKhoan_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTaiKhoan.SelectedRows.Count > 0)
            {
                var selectedUser = dgvTaiKhoan.SelectedRows[0];
                txtTenTK.Text = selectedUser.Cells["username"].Value.ToString();
                cboQuyen.SelectedItem = selectedUser.Cells["role"].Value.ToString();
                txtMatKhau.Text = string.Empty; // For security reasons, we don't show the password
                originalPassword = string.Empty;
            }
        }

        private void ClearInputs()
        {
            txtTenTK.Text = string.Empty;
            txtMatKhau.Text = string.Empty;
            cboQuyen.SelectedIndex = 0;
            originalPassword = string.Empty;
        }
    }
}
