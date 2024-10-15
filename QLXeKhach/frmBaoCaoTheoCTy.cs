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
    public partial class frmBaoCaoTheoCTy : Form
    {
        private IMongoCollection<BsonDocument> collection;
        public frmBaoCaoTheoCTy()
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
                // Thực hiện truy vấn aggregate với lookup tới bảng trips và buses
                var pipeline = new[]
                {
                    new BsonDocument("$lookup", new BsonDocument
                    {
                        { "from", "trips" },
                        { "localField", "tripID" },
                        { "foreignField", "_id" },
                        { "as", "tripDetails" }
                    }),
                    new BsonDocument("$unwind", "$tripDetails"), // Giải nén mảng tripDetails
                    new BsonDocument("$lookup", new BsonDocument
                    {
                        { "from", "buses" },
                        { "localField", "tripDetails.busID" },
                        { "foreignField", "_id" },
                        { "as", "busDetails" }
                    }),
                    new BsonDocument("$unwind", "$busDetails"), // Giải nén mảng busDetails
                    new BsonDocument("$group", new BsonDocument
                    {
                        { "_id", "$busDetails.busCompany" }, // Nhóm theo busCompany
                        { "totalTickets", new BsonDocument("$sum", 1) } // Đếm tổng số vé
                    }),
                    new BsonDocument("$sort", new BsonDocument("totalTickets", -1)) // Sắp xếp giảm dần theo tổng vé
                };

                var result = collection.Aggregate<BsonDocument>(pipeline).ToList();

                // Chuyển đổi kết quả sang DataTable
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("Bus Company");
                dataTable.Columns.Add("Total Tickets");

                foreach (var doc in result)
                {
                    var row = dataTable.NewRow();
                    row["Bus Company"] = doc["_id"].AsString;
                    row["Total Tickets"] = doc["totalTickets"].AsInt32;
                    dataTable.Rows.Add(row);
                }

                dgvTicketsSold.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy số vé từ textbox
                int ticketsToSearch = int.Parse(txtTicket.Text);

                // Thực hiện truy vấn aggregate với lookup và lọc theo số vé tìm kiếm
                var aggregate = collection.Aggregate()
                    .Lookup("trips", "tripID", "_id", "tripDetails")
                    .Unwind("tripDetails")
                    .Lookup("buses", "tripDetails.busID", "_id", "busDetails")
                    .Unwind("busDetails")
                    .Group(new BsonDocument
                    {
                        { "_id", "$busDetails.busCompany" },
                        { "totalTickets", new BsonDocument("$sum", 1) }
                    })
                    .Match(new BsonDocument("totalTickets", ticketsToSearch)) // Lọc theo số vé
                    .Sort(new BsonDocument("totalTickets", -1)) // Sắp xếp giảm dần
                    .ToList();

                // Hiển thị kết quả lên DataGridView
                if (aggregate.Any())
                {
                    dgvTicketsSold.DataSource = aggregate.Select(d => new
                    {
                        BusCompany = d["_id"].AsString,
                        TotalTickets = d["totalTickets"].AsInt32
                    }).ToList();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy công ty xe buýt với số vé bán ra như vậy.");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập vào một số hợp lệ.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                // Reset lại dữ liệu trong textbox
                txtTicket.Text = string.Empty;

                // Thực hiện lại truy vấn aggregate ban đầu
                var aggregate = collection.Aggregate()
                    .Lookup("trips", "tripID", "_id", "tripDetails")
                    .Unwind("tripDetails")
                    .Lookup("buses", "tripDetails.busID", "_id", "busDetails")
                    .Unwind("busDetails")
                    .Group(new BsonDocument
                    {
                        { "_id", "$busDetails.busCompany" },
                        { "totalTickets", new BsonDocument("$sum", 1) }
                    })
                    .Sort(new BsonDocument("totalTickets", -1)) // Sắp xếp giảm dần
                    .ToList();

                // Hiển thị lại kết quả ban đầu
                dgvTicketsSold.DataSource = aggregate.Select(d => new
                {
                    BusCompany = d["_id"].AsString,
                    TotalTickets = d["totalTickets"].AsInt32
                }).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }
    }
}
