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
    public partial class frmQuanLyXe : Form
    {
        private IMongoCollection<BsonDocument> _busCollection;
        public frmQuanLyXe()
        {
            InitializeComponent();
            _busCollection = MongodbConnect.GetCollection<BsonDocument>("buses");
            LoadBuses();
            InitializeComboBox();
        }

        private void LoadBuses()
        {
            var buses = _busCollection.Find(new BsonDocument()).ToList();
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("busID");
            dataTable.Columns.Add("licensePlate");
            dataTable.Columns.Add("type");
            dataTable.Columns.Add("seats");
            dataTable.Columns.Add("busCompany");

            foreach (var bus in buses)
            {
                DataRow row = dataTable.NewRow();
                row["busID"] = bus["busID"].AsString;
                row["licensePlate"] = bus["licensePlate"].AsString;
                row["type"] = bus["type"].AsString;
                row["seats"] = bus["seats"].ToInt32();
                row["busCompany"] = bus["busCompany"].AsString;
                dataTable.Rows.Add(row);
            }

            dgvXeKhach.DataSource = dataTable;
        }

        private void InitializeComboBox()
        {
            cboLoaiXe.Items.Add("Limousine");
            cboLoaiXe.Items.Add("Giường nằm");
            cboLoaiXe.Items.Add("Ghế ngồi");
            cboLoaiXe.SelectedIndex = 0;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaXeKhach.Text) || string.IsNullOrWhiteSpace(txtBienSoXe.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin xe khách.");
                return;
            }

            var newBus = new BsonDocument
            {
                { "busID", txtMaXeKhach.Text },
                { "licensePlate", txtBienSoXe.Text },
                { "type", cboLoaiXe.SelectedItem.ToString() },
                { "seats", int.Parse(txtSoGhe.Text) },
                { "busCompany", txtTenCongTy.Text }
            };

            try
            {
                _busCollection.InsertOne(newBus);
                MessageBox.Show("Xe khách đã được thêm thành công.");
                LoadBuses();
                ResetFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm xe khách: {ex.Message}");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvXeKhach.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn xe khách cần xóa.");
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa xe khách này?", "Xác nhận xóa", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var selectedBus = dgvXeKhach.SelectedRows[0];
                var busId = selectedBus.Cells["busID"].Value.ToString();

                var filter = Builders<BsonDocument>.Filter.Eq("busID", busId);
                var result = _busCollection.DeleteOne(filter);

                if (result.DeletedCount > 0)
                {
                    MessageBox.Show("Xe khách đã được xóa thành công.");
                    LoadBuses();
                    ResetFields();
                }
                else
                {
                    MessageBox.Show("Không thể xóa xe khách. Vui lòng thử lại.");
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvXeKhach.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn xe khách cần sửa.");
                return;
            }

            var busId = txtMaXeKhach.Text;

            var filter = Builders<BsonDocument>.Filter.Eq("busID", busId);
            var update = Builders<BsonDocument>.Update
                .Set("licensePlate", txtBienSoXe.Text)
                .Set("type", cboLoaiXe.SelectedItem.ToString())
                .Set("seats", int.Parse(txtSoGhe.Text))
                .Set("busCompany", txtTenCongTy.Text);

            try
            {
                var result = _busCollection.UpdateOne(filter, update);

                if (result.ModifiedCount > 0)
                {
                    MessageBox.Show("Thông tin xe khách đã được cập nhật thành công.");
                    LoadBuses();
                }
                else
                {
                    MessageBox.Show("Không thể cập nhật thông tin xe khách. Vui lòng thử lại.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi cập nhật thông tin xe khách: {ex.Message}");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetFields();
        }

        private void ResetFields()
        {
            txtMaXeKhach.Text = string.Empty;
            txtBienSoXe.Text = string.Empty;
            cboLoaiXe.SelectedIndex = 0;
            txtSoGhe.Text = string.Empty;
            txtTenCongTy.Text = string.Empty;
        }

        private void dgvXeKhach_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvXeKhach.SelectedRows.Count > 0)
            {
                var selectedBus = dgvXeKhach.SelectedRows[0];
                txtMaXeKhach.Text = selectedBus.Cells["busID"].Value.ToString();
                txtBienSoXe.Text = selectedBus.Cells["licensePlate"].Value.ToString();
                cboLoaiXe.SelectedItem = selectedBus.Cells["type"].Value.ToString();
                txtSoGhe.Text = selectedBus.Cells["seats"].Value.ToString();
                txtTenCongTy.Text = selectedBus.Cells["busCompany"].Value.ToString();
            }
        }

        private void lblLoaiXe_Click(object sender, EventArgs e)
        {

        }

        private void dgvXeKhach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
