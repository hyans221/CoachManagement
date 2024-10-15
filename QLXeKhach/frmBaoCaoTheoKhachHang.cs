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
    public partial class frmBaoCaoTheoKhachHang : Form
    {
        private IMongoCollection<BsonDocument> collection;
        public frmBaoCaoTheoKhachHang()
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
                var pipeline = new[]
                {
            new BsonDocument("$group", new BsonDocument
            {
                { "_id", "$customerID" },
                { "totalTicketsSold", new BsonDocument("$sum", 1) }
            }),
            new BsonDocument("$lookup", new BsonDocument
            {
                { "from", "customers" },
                { "localField", "_id" },
                { "foreignField", "_id" }, // Lấy thông tin khách hàng theo customerID
                { "as", "customerDetails" }
            }),
            new BsonDocument("$unwind", "$customerDetails"),
            new BsonDocument("$project", new BsonDocument
            {
                { "_id", 0 },
                { "CustomerName", "$customerDetails.name" },
                { "TotalTicketsSold", "$totalTicketsSold" }
            })
        };

                var result = collection.Aggregate<BsonDocument>(pipeline).ToList();

                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("Customer Name");
                dataTable.Columns.Add("Total Tickets Sold");

                foreach (var doc in result)
                {
                    var row = dataTable.NewRow();
                    row["Customer Name"] = doc["CustomerName"].AsString;
                    row["Total Tickets Sold"] = doc["TotalTicketsSold"].AsInt32;
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
                // Lấy số lượng vé từ textbox
                int ticketsToSearch = int.Parse(txtTicket.Text);

                // Kết nối tới MongoDB
                var client = new MongoClient("mongodb://localhost:27017");
                var database = client.GetDatabase("QLyXeKhach");
                var ticketsCollection = database.GetCollection<BsonDocument>("tickets");

                // Thực hiện truy vấn aggregate
                var aggregate = ticketsCollection.Aggregate()
                    .Group(new BsonDocument
                    {
                        { "_id", "$customerID" },
                        { "totalTicketsSold", new BsonDocument("$sum", 1) }
                    })
                    .Match(new BsonDocument("totalTicketsSold", ticketsToSearch)) // Lọc theo số vé cần tìm
                    .Lookup("customers", "_id", "_id", "customerDetails")  // Nối với collection customers
                    .Unwind("customerDetails")
                    .Project(new BsonDocument
                    {
                        { "_id", 0 },
                        { "CustomerName", "$customerDetails.name" },
                        { "TotalTicketsSold", "$totalTicketsSold" }
                    })
                    .ToList();

                // Kiểm tra nếu tìm thấy kết quả
                if (aggregate.Any())
                {
                    // Cập nhật DataGridView với kết quả tìm kiếm
                    dgvTicketsSold.DataSource = aggregate.Select(d => new
                    {
                        CustomerName = d["CustomerName"].AsString,
                        TotalTicketsSold = d["TotalTicketsSold"].AsInt32
                    }).ToList();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy khách hàng với số vé bán ra như vậy.");
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
                // Xóa nội dung trong textbox txtTicket
                txtTicket.Text = string.Empty;

                // Kết nối tới MongoDB
                var client = new MongoClient("mongodb://localhost:27017");
                var database = client.GetDatabase("QLyXeKhach");
                var ticketsCollection = database.GetCollection<BsonDocument>("tickets");

                // Thực hiện truy vấn aggregate để lấy tất cả các khách hàng và tổng số vé bán
                var aggregate = ticketsCollection.Aggregate()
                    .Group(new BsonDocument
                    {
                        { "_id", "$customerID" },
                        { "totalTicketsSold", new BsonDocument("$sum", 1) }
                    })
                    .Lookup("customers", "_id", "_id", "customerDetails")  // Nối với collection customers
                    .Unwind("customerDetails")
                    .Project(new BsonDocument
                    {
                        { "_id", 0 },
                        { "CustomerName", "$customerDetails.name" },
                        { "TotalTicketsSold", "$totalTicketsSold" }
                    })
                    .ToList();

                // Hiển thị lại kết quả ban đầu lên DataGridView
                dgvTicketsSold.DataSource = aggregate.Select(d => new
                {
                    CustomerName = d["CustomerName"].AsString,
                    TotalTicketsSold = d["TotalTicketsSold"].AsInt32
                }).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }
    }
}
