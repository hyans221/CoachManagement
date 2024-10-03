using MongoDB.Bson;
using MongoDB.Driver;
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
    public partial class frmDangNhap : Form
    {
        private readonly UserAuthentication _userAuth;
        public frmDangNhap()
        {
            InitializeComponent();
            _userAuth = new UserAuthentication();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string password = txtPassword.Text;

            if (_userAuth.AuthenticateUser(username, password))
            {
                string userRole = _userAuth.GetUserRole(username);
                MessageBox.Show($"Đăng nhập thành công! Xin chào: {userRole}");

                if (userRole == "admin")
                {
                    new frmTrangChu().Show();
                }
                // else if (userRole == "customer")
                // {
                //     new frmCustomer().Show();
                // }

                this.Hide();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng. Đăng nhập thất bại.");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }

    public class UserAuthentication
    {
        private readonly IMongoCollection<BsonDocument> _userCollection;

        public UserAuthentication()
        {
            _userCollection = MongodbConnect.GetCollection<BsonDocument>("user");
        }

        public bool AuthenticateUser(string username, string password)
        {
            var filter = Builders<BsonDocument>.Filter.And(
                Builders<BsonDocument>.Filter.Eq("username", username),
                Builders<BsonDocument>.Filter.Eq("password", password)
            );

            var user = _userCollection.Find(filter).FirstOrDefault();

            return user != null;
        }

        public string GetUserRole(string username)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("username", username);
            var user = _userCollection.Find(filter).FirstOrDefault();

            return user?["role"].AsString;
        }
    }

}
