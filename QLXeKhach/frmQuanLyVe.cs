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
    public partial class frmQuanLyVe : Form
    {
        private IMongoCollection<BsonDocument> collection;
        public frmQuanLyVe()
        {
            InitializeComponent();
            InitializeMongoDB();
            LoadDataToGridView();
        }

        private void InitializeMongoDB()
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("QLyXeKhach");
            collection = database.GetCollection<BsonDocument>("tickets");
        }

        private void LoadDataToGridView()
        {
            try
            {
                var documents = collection.Find(new BsonDocument()).ToList();
                var dataTable = new System.Data.DataTable();

                dataTable.Columns.Add("ticketID");
                dataTable.Columns.Add("seatNumber");
                dataTable.Columns.Add("startdate");

                foreach (var doc in documents)
                {
                    var row = dataTable.NewRow();
                    row["ticketID"] = doc["ticketID"].AsString;
                    row["seatNumber"] = doc["seatNumber"].AsString;
                    row["startDate"] = doc["startDate"].ToLocalTime().ToString("dd/MM/yyyy");
                    dataTable.Rows.Add(row);
                }

                dgvVe.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("QLyXeKhach");
            var collection = database.GetCollection<BsonDocument>("tickets");

            var newTicket = new BsonDocument
            {
                { "ticketID", txtTicketID.Text },
                { "seatNumber", txtSeatNumber.Text },
                { "startDate", dtNgayBatDau.Value.ToUniversalTime() }
            };

            try
            {
                collection.InsertOne(newTicket);
                MessageBox.Show("Thêm vé thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadDataToGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvVe.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một vé để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedRow = dgvVe.SelectedRows[0];
            string ticketIDToUpdate = selectedRow.Cells["ticketID"].Value.ToString();

            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("QLyXeKhach");
            var collection = database.GetCollection<BsonDocument>("tickets");

            var updatedTicket = new BsonDocument
            {
                { "ticketID", ticketIDToUpdate },
                { "seatNumber", txtSeatNumber.Text },
                { "startDate", dtNgayBatDau.Value.ToUniversalTime() }
            };

            var filter = Builders<BsonDocument>.Filter.Eq("ticketID", ticketIDToUpdate);
            try
            {
                var result = collection.ReplaceOne(filter, updatedTicket);

                if (result.ModifiedCount > 0)
                {
                    MessageBox.Show("Cập nhật vé thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataToGridView();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy vé để cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvVe.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một vé để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedRow = dgvVe.SelectedRows[0];
            string ticketIDToDelete = selectedRow.Cells["ticketID"].Value.ToString();

            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("QLyXeKhach");
            var collection = database.GetCollection<BsonDocument>("tickets");

            var filter = Builders<BsonDocument>.Filter.Eq("ticketID", ticketIDToDelete);
            try
            {
                var result = collection.DeleteOne(filter);

                if (result.DeletedCount > 0)
                {
                    MessageBox.Show("Xóa vé thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataToGridView();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy vé để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void dgvMonHoc_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvVe.CurrentRow != null) // Chỉ thực hiện nếu hàng được chọn hợp lệ
            {
                var selectedRow = dgvVe.CurrentRow;

                txtTicketID.Text = selectedRow.Cells["ticketID"].Value.ToString();
                txtSeatNumber.Text = selectedRow.Cells["seatNumber"].Value.ToString();

                var startDateValue = selectedRow.Cells["startDate"].Value;
                if (startDateValue != null && startDateValue != DBNull.Value)
                {
                    dtNgayBatDau.Value = DateTime.ParseExact(startDateValue.ToString(), "dd/MM/yyyy", null);
                }
                else
                {
                    dtNgayBatDau.Value = DateTime.Now;
                }
            }
        }
    }
}
