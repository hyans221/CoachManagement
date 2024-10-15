using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QLXeKhach
{
    public partial class frmQuanLyVe : Form
    {
        private IMongoCollection<BsonDocument> ticketsCollection;
        private IMongoCollection<BsonDocument> busesCollection;
        private IMongoDatabase database;
        public frmQuanLyVe()
        {
            InitializeComponent();
            InitializeMongoDB();
            LoadDataToGridView();
            LoadBusCompanies();
        }

        private void InitializeMongoDB()
        {
            var client = new MongoClient("mongodb://localhost:27017");
            database = client.GetDatabase("QLyXeKhach");
            ticketsCollection = database.GetCollection<BsonDocument>("tickets");
            busesCollection = database.GetCollection<BsonDocument>("buses");

        }

        private void LoadBusCompanies()
        {
            var busCompanies = busesCollection.Distinct<string>("busCompany", new BsonDocument()).ToList();

            cboNhaXe.Items.Clear();
            foreach (var company in busCompanies)
            {
                cboNhaXe.Items.Add(company);
            }
        }

        private void LoadDataToGridView()
        {
            try
            {
                var pipeline = new BsonDocument[]
                {
                    new BsonDocument("$lookup", new BsonDocument
                    {
                        { "from", "trips" },
                        { "localField", "tripID" },
                        { "foreignField", "_id" },
                        { "as", "tripDetails" }
                    }),
                    new BsonDocument("$unwind", "$tripDetails"),
                    new BsonDocument("$lookup", new BsonDocument
                    {
                        { "from", "buses" },
                        { "localField", "tripDetails.busID" },
                        { "foreignField", "_id" },
                        { "as", "busDetails" }
                    }),
                    new BsonDocument("$unwind", "$busDetails"),
                    new BsonDocument("$lookup", new BsonDocument
                    {
                        { "from", "customers" },
                        { "localField", "customerID" },
                        { "foreignField", "_id" },
                        { "as", "customerDetails" }
                    }),
                    new BsonDocument("$unwind", "$customerDetails"),
                    new BsonDocument("$project", new BsonDocument
                    {
                        { "ticketID", 1 },
                        { "busCompany", "$busDetails.busCompany" },
                        { "customerName", "$customerDetails.name" },
                        { "seatNumber", 1 },
                        { "price", 1 },
                        { "departureTime", "$tripDetails.departureTime" },
                        { "departure", "$tripDetails.departure" },
                        { "destination", "$tripDetails.destination" }
                    })
                };

                var results = ticketsCollection.Aggregate<BsonDocument>(pipeline).ToList();

                var dataTable = new DataTable();
                dataTable.Columns.Add("TicketID");
                dataTable.Columns.Add("BusCompany");
                dataTable.Columns.Add("CustomerName");
                dataTable.Columns.Add("SeatNumber");
                dataTable.Columns.Add("Price");
                dataTable.Columns.Add("DepartureTime");
                dataTable.Columns.Add("Departure");
                dataTable.Columns.Add("Destination");

                foreach (var doc in results)
                {
                    var row = dataTable.NewRow();
                    row["TicketID"] = doc["ticketID"].AsString;
                    row["BusCompany"] = doc["busCompany"].AsString;
                    row["CustomerName"] = doc["customerName"].AsString;
                    row["SeatNumber"] = doc["seatNumber"].AsString;
                    row["Price"] = doc["price"].AsInt32;
                    row["DepartureTime"] = doc["departureTime"].ToUniversalTime().ToString("dd/MM/yyyy HH:mm");
                    row["Departure"] = doc["departure"].AsString;
                    row["Destination"] = doc["destination"].AsString;
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
            var newTicket = new BsonDocument
            {
                { "ticketID", txtTicketID.Text },
                { "busCompany", cboNhaXe.Text },
                { "customerName", txtTenHanhKhach.Text },
                { "seatNumber", txtSeatNumber.Text },
                { "price", int.Parse(txtGia.Text) },
                { "departureTime", dtpNgayKhoiHanh.Value },
                { "departure", txtDiemDi.Text },
                { "destination", txtDiemDen.Text }
            };

            try
            {
                ticketsCollection.InsertOne(newTicket);
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
            string ticketIDToUpdate = selectedRow.Cells["TicketID"].Value.ToString();

            var updatedTicket = new BsonDocument
            {
                { "ticketID", ticketIDToUpdate },
                { "busCompany", cboNhaXe.Text },
                { "customerName", txtTenHanhKhach.Text },
                { "seatNumber", txtSeatNumber.Text },
                { "price", int.Parse(txtGia.Text) },
                { "departureTime", dtpNgayKhoiHanh.Value },
                { "departure", txtDiemDi.Text },
                { "destination", txtDiemDen.Text }
            };

            var filter = Builders<BsonDocument>.Filter.Eq("ticketID", ticketIDToUpdate);
            try
            {
                var result = ticketsCollection.ReplaceOne(filter, updatedTicket);

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
            string ticketIDToDelete = selectedRow.Cells["TicketID"].Value.ToString();

            var filter = Builders<BsonDocument>.Filter.Eq("ticketID", ticketIDToDelete);
            try
            {
                var result = ticketsCollection.DeleteOne(filter);

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
            if (dgvVe.CurrentRow != null)
            {
                var selectedRow = dgvVe.CurrentRow;

                txtTicketID.Text = selectedRow.Cells["TicketID"].Value.ToString();
                cboNhaXe.Text = selectedRow.Cells["BusCompany"].Value.ToString();
                txtTenHanhKhach.Text = selectedRow.Cells["CustomerName"].Value.ToString();
                txtSeatNumber.Text = selectedRow.Cells["SeatNumber"].Value.ToString();
                txtGia.Text = selectedRow.Cells["Price"].Value.ToString();

                DateTime departureTime;
                if (DateTime.TryParseExact(selectedRow.Cells["DepartureTime"].Value.ToString(), "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None, out departureTime))
                {
                    dtpNgayKhoiHanh.Value = departureTime;
                }
                else
                {
                    MessageBox.Show("Invalid date format in DepartureTime.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                txtDiemDi.Text = selectedRow.Cells["Departure"].Value.ToString();
                txtDiemDen.Text = selectedRow.Cells["Destination"].Value.ToString();
            }
        }

        private void btnInVe_Click(object sender, EventArgs e)
        {
            if (dgvVe.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một vé để xuất.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var selectedRow = dgvVe.SelectedRows[0];
            string ticketIDToExport = selectedRow.Cells["TicketID"].Value.ToString();

            // Lấy dữ liệu từ các control
            string busCompany = cboNhaXe.Text;
            string customerName = txtTenHanhKhach.Text;
            string departure = txtDiemDi.Text;
            string destination = txtDiemDen.Text;
            DateTime departureDateTime = dtpNgayKhoiHanh.Value;
            string departureTime = departureDateTime.ToString("dd/MM/yyyy");
            string time = departureDateTime.ToString("HH:mm");
            string price = txtGia.Text;
            string seatNumber = txtSeatNumber.Text;

            // Truyền dữ liệu vào hàm xuất
            ExportTicketToWord(ticketIDToExport, busCompany, customerName, departure, destination, departureTime, time, price, seatNumber);
        }


        private void ExportTicketToWord(string ticketID, string busCompany, string customerName, string departure, string destination, string departureTime, string time, string price, string seatNumber)
        {
            try
            {
                // Tạo đối tượng WordExport để xuất dữ liệu ra file Word
                string templatePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\Templates", "veXeKhach.docx");
                if (!File.Exists(templatePath))
                {
                    MessageBox.Show($"Template file not found: {templatePath}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                WordExport wordExport = new WordExport(templatePath, true);

                // Chuẩn bị dữ liệu để điền vào template
                Dictionary<string, string> fieldValues = new Dictionary<string, string> {
            { "busCompany", busCompany },
            { "name", customerName },
            { "departure", departure },
            { "destination", destination },
            { "departureTime", departureTime },
            { "time", time },
            { "price", price + " đ" },
            { "seatNumber", seatNumber }
            };

                // Điền dữ liệu vào template
                wordExport.WriteFields(fieldValues);

                // Lưu file Word ra Desktop
                string outputPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), $"Ve_{ticketID}.docx");
                wordExport.SaveAs(outputPath);
                wordExport.Close();

                MessageBox.Show($"Đã xuất vé thành công. File được lưu tại: {outputPath}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra khi xuất vé: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
