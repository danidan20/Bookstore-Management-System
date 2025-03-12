using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BookHaven_Bookstore_Management_System.Domain;
using BookHaven_Bookstore_Management_System.Services.interfaces;

namespace BookHaven_Bookstore_Management_System.View.Admin
{
    public partial class ReportingAnalyticsForm : Form
    {
        private readonly IOrderService _orderService;
        private readonly IBookService _bookService;

        public ReportingAnalyticsForm(IOrderService orderService, IBookService bookService)
        {
            InitializeComponent();
            _orderService = orderService;
            _bookService = bookService;
            InitializeReportControls();
        }

        private void InitializeReportControls()
        {
            dtpStartDate.Value = DateTime.Today.AddDays(-7);
            dtpEndDate.Value = DateTime.Today;
            cmbReportType.Items.AddRange(new string[] {
                "Daily Sales Details",
                "Weekly Sales Summary",
                "Monthly Sales Summary",
                "Best Selling Books with Details",
                "Inventory Status with Book Details"
            });
            cmbReportType.SelectedIndex = 0;
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            DateTime startDate = dtpStartDate.Value.Date;
            DateTime endDate = dtpEndDate.Value.Date.AddDays(1).AddSeconds(-1);
            string reportType = cmbReportType.SelectedItem.ToString();

            try
            {
                List<Order> orders = _orderService.GetAllOrders()
                                                    .Where(o => o.OrderDate >= startDate && o.OrderDate <= endDate)
                                                    .ToList();

                if (orders.Count == 0)
                {
                    MessageBox.Show("No sales data found for the selected period.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                switch (reportType)
                {
                    case "Daily Sales Details":
                        GenerateDailySalesDetails(orders);
                        break;
                    case "Weekly Sales Summary":
                        GenerateWeeklySalesSummary(orders);
                        break;
                    case "Monthly Sales Summary":
                        GenerateMonthlySalesSummary(orders);
                        break;
                    case "Best Selling Books with Details":
                        GenerateBestSellingBooksWithDetails();
                        break;
                    case "Inventory Status with Book Details":
                        GenerateInventoryStatusWithBookDetails();
                        break;
                    default:
                        MessageBox.Show("Invalid report type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating report: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GenerateDailySalesDetails(List<Order> orders)
        {
            var dailySalesDetails = orders.SelectMany(o => o.OrderItems.Select(oi => new
            {
                OrderDate = o.OrderDate.Date,
                OrderId = o.OrderID,
                BookTitle = _bookService.GetBookById(oi.BookID)?.Title,
                Quantity = oi.Quantity,
                UnitPrice = oi.Price,
                TotalOrderItemAmount = oi.Quantity * oi.Price
            })).OrderBy(d => d.OrderDate).ToList();

            dataGridViewReport.DataSource = dailySalesDetails;
        }

        private void GenerateWeeklySalesSummary(List<Order> orders)
        {
            var weeklySalesSummary = orders.GroupBy(o => System.Globalization.CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(o.OrderDate, System.Globalization.CalendarWeekRule.FirstDay, DayOfWeek.Monday))
                                         .Select(g => new
                                         {
                                             WeekNumber = g.Key,
                                             TotalOrders = g.Count(),
                                             TotalSalesAmount = g.Sum(o => o.TotalAmount),
                                             AverageOrderAmount = g.Average(o => o.TotalAmount)
                                         })
                                         .OrderBy(w => w.WeekNumber)
                                         .ToList();

            dataGridViewReport.DataSource = weeklySalesSummary;
        }

        private void GenerateMonthlySalesSummary(List<Order> orders)
        {
            var monthlySalesSummary = orders.GroupBy(o => new { o.OrderDate.Year, o.OrderDate.Month })
                                          .Select(g => new
                                          {
                                              Year = g.Key.Year,
                                              Month = g.Key.Month,
                                              TotalOrders = g.Count(),
                                              TotalSalesAmount = g.Sum(o => o.TotalAmount),
                                              AverageOrderAmount = g.Average(o => o.TotalAmount)
                                          })
                                          .OrderBy(m => m.Year).ThenBy(m => m.Month)
                                          .ToList();

            dataGridViewReport.DataSource = monthlySalesSummary;
        }

        private void GenerateBestSellingBooksWithDetails()
        {
            var bestSellingBooksWithDetails = _orderService.GetAllOrders()
                                                              .SelectMany(o => o.OrderItems.Select(oi => new
                                                              {
                                                                  BookId = oi.BookID,
                                                                  BookTitle = _bookService.GetBookById(oi.BookID)?.Title,
                                                                  Quantity = oi.Quantity,
                                                                  OrderDate = o.OrderDate,
                                                                  OrderId = o.OrderID
                                                              }))
                                                              .GroupBy(b => new { b.BookId, b.BookTitle })
                                                              .Select(g => new
                                                              {
                                                                  BookId = g.Key.BookId,
                                                                  BookTitle = g.Key.BookTitle,
                                                                  TotalQuantitySold = g.Sum(oi => oi.Quantity),
                                                                  FirstOrderDate = g.Min(oi => oi.OrderDate),
                                                                  LastOrderDate = g.Max(oi => oi.OrderDate),
                                                                  TotalOrders = g.Select(oi => oi.OrderId).Distinct().Count()
                                                              })
                                                              .OrderByDescending(b => b.TotalQuantitySold)
                                                              .ToList();

            dataGridViewReport.DataSource = bestSellingBooksWithDetails;
        }

        private void GenerateInventoryStatusWithBookDetails()
        {
            var inventoryStatusWithBookDetails = _bookService.GetAllBooks()
                                                              .Select(b => new
                                                              {
                                                                  BookId = b.BookID,
                                                                  BookTitle = b.Title,
                                                                  Author = b.Author,
                                                                  ISBN = b.ISBN,
                                                                  StockQuantity = b.StockQuantity,
                                                                  LowStock = b.StockQuantity < 10 ? "Yes" : "No"
                                                              })
                                                              .ToList();

            dataGridViewReport.DataSource = inventoryStatusWithBookDetails;
        }
    }
}