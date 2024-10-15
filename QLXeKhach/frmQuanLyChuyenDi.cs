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
    public partial class frmQuanLyChuyenDi : Form
    {
        private IMongoCollection<BsonDocument> collection;
        private IMongoCollection<BsonDocument> busCollection;
        public frmQuanLyChuyenDi()
        {
            InitializeComponent();
            InitializeMongoDB();
            LoadDataToGridView();
            LoadBusDataToComboBox();
        }

        private void InitializeMongoDB()
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("QLXeKhach1");
            collection = database.GetCollection<BsonDocument>("trips");
            busCollection = database.GetCollection<BsonDocument>("buses");
        }

        private void LoadDataToGridView()
        {
            try
            {
                var documents = collection.Find(new BsonDocument()).ToList();
                var dataTable = new DataTable();

                dataTable.Columns.Add("tripID");
                dataTable.Columns.Add("departure");
                dataTable.Columns.Add("destination");
                dataTable.Columns.Add("departureTime");
                dataTable.Columns.Add("busID");

                // Lấy danh sách buses để ánh xạ busID
                var buses = busCollection.Find(new BsonDocument()).ToList().ToDictionary(b => b["_id"].ToString(), b => b["busID"].AsString);

                // Duyệt qua các document và thêm vào DataTable
                foreach (var doc in documents)
                {
                    var row = dataTable.NewRow();
                    row["tripID"] = doc["tripID"].AsString;
                    row["departure"] = doc["departure"].AsString;
                    row["destination"] = doc["destination"].AsString;
                    row["departureTime"] = doc["departureTime"].ToLocalTime().ToString("dd/MM/yyyy HH:mm");

                    // Lấy busID từ dictionary
                    var busId = doc["busID"].ToString();
                    row["busID"] = buses.ContainsKey(busId) ? buses[busId] : "Unknown"; // Kiểm tra nếu busID tồn tại trong dictionary

                    dataTable.Rows.Add(row);
                }

                dgvChuyenDi.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void LoadBusDataToComboBox()
        {
            try
            {
                var busDocuments = busCollection.Find(new BsonDocument()).ToList();
                cboBusID.DataSource = busDocuments.Select(b => new { ID = b["_id"].ToString(), Name = b["busID"].AsString }).ToList();
                cboBusID.DisplayMember = "Name";
                cboBusID.ValueMember = "ID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading buses: " + ex.Message);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {

                var tripID = txtTripsID.Text.Trim();
                var departure = txtDeparture.Text.Trim();
                var destination = txtDestination.Text.Trim();
                var departureTime = dtDepartureTime.Value.ToUniversalTime();
                var busID = cboBusID.SelectedValue.ToString();

                if (string.IsNullOrWhiteSpace(tripID) ||
                    string.IsNullOrWhiteSpace(departure) ||
                    string.IsNullOrWhiteSpace(destination) ||
                    string.IsNullOrWhiteSpace(busID))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                    return;
                }

                var newTrip = new BsonDocument
                {
                    { "tripID", tripID },
                    { "departureTime", departureTime },
                    { "departure", departure },
                    { "destination", destination },
                    { "busID", new ObjectId(busID) }
                };


                collection.InsertOne(newTrip);


                LoadDataToGridView();


                MessageBox.Show("Thêm chuyến đi thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                var tripID = txtTripsID.Text.Trim();
                var departure = txtDeparture.Text.Trim();
                var destination = txtDestination.Text.Trim();
                var departureTime = dtDepartureTime.Value.ToUniversalTime();
                var busID = cboBusID.SelectedValue.ToString();

                if (string.IsNullOrWhiteSpace(tripID) ||
                    string.IsNullOrWhiteSpace(departure) ||
                    string.IsNullOrWhiteSpace(destination) ||
                    string.IsNullOrWhiteSpace(busID))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                    return;
                }

                var filter = Builders<BsonDocument>.Filter.Eq("tripID", tripID);

                var updatedTrip = new BsonDocument
                {
                    { "departureTime", departureTime },
                    { "departure", departure },
                    { "destination", destination },
                    { "busID", new ObjectId(busID) }
                };

                collection.UpdateOne(filter, new BsonDocument("$set", updatedTrip));

                LoadDataToGridView();

                MessageBox.Show("Sửa chuyến đi thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvChuyenDi.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một chuyến đi để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedRow = dgvChuyenDi.SelectedRows[0];
            string tripIDToDelete = selectedRow.Cells["tripID"].Value.ToString();

            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("QLXeKhach1");
            var collection = database.GetCollection<BsonDocument>("trips");

            var filter = Builders<BsonDocument>.Filter.Eq("tripID", tripIDToDelete);

            var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa chuyến đi này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    var result = collection.DeleteOne(filter);

                    if (result.DeletedCount > 0)
                    {
                        MessageBox.Show("Xóa chuyến đi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDataToGridView();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy chuyến đi để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvMonHoc_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvChuyenDi.CurrentRow != null) // Chỉ thực hiện nếu hàng được chọn hợp lệ
            {
                var selectedRow = dgvChuyenDi.CurrentRow;

                txtTripsID.Text = selectedRow.Cells["tripID"].Value.ToString();
                txtDeparture.Text = selectedRow.Cells["departure"].Value.ToString();
                txtDestination.Text = selectedRow.Cells["destination"].Value.ToString();

                var departureTimeValue = selectedRow.Cells["departureTime"].Value;
                if (departureTimeValue != null && departureTimeValue != DBNull.Value)
                {
                    dtDepartureTime.Value = DateTime.ParseExact(departureTimeValue.ToString(), "dd/MM/yyyy HH:mm", null);
                }
                else
                {
                    dtDepartureTime.Value = DateTime.Now;
                }

                // Set the ComboBox value
                var busIDValue = selectedRow.Cells["busID"].Value.ToString();
                var busItem = cboBusID.Items.Cast<dynamic>().FirstOrDefault(item => item.Name == busIDValue);
                if (busItem != null)
                {
                    cboBusID.SelectedValue = busItem.ID;
                }
                else
                {
                    cboBusID.SelectedIndex = -1; // Clear selection if not found
                }
            }
        }
    }
}
