using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookHaven_Bookstore_Management_System.Domain;

namespace BookHaven_Bookstore_Management_System.Utils
{
    public class ReceiptGenerator
    {
        private Order _order;
        private Customer _customer;
        private Font _headerFont = new Font("Arial", 14, FontStyle.Bold);
        private Font _regularFont = new Font("Arial", 10);
        private Font _smallFont = new Font("Arial", 8);

        public ReceiptGenerator(Order order, Customer customer)
        {
            _order = order;
            _customer = customer;
        }

        public void PrintReceipt()
        {
            PrintDocument printDoc = new PrintDocument();
            printDoc.PrintPage += new PrintPageEventHandler(PrintPageHandler);

            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDoc;

            if (printDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                printDoc.Print();
            }
        }

        private void PrintPageHandler(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            float yPos = 20;
            float leftMargin = e.MarginBounds.Left;

            // Header
            g.DrawString("BookHaven Bookstore Receipt", _headerFont, Brushes.Black, leftMargin, yPos);
            yPos += _headerFont.GetHeight() + 10;

            // Customer Details
            g.DrawString($"Customer: {_customer.FullName}", _regularFont, Brushes.Black, leftMargin, yPos);
            yPos += _regularFont.GetHeight() + 5;
           // g.DrawString($"Address: {_order.Address}", _regularFont, Brushes.Black, leftMargin, yPos);
            yPos += _regularFont.GetHeight() + 10;

            // Order Details
            g.DrawString($"Order ID: {_order.OrderID}", _regularFont, Brushes.Black, leftMargin, yPos);
            yPos += _regularFont.GetHeight() + 5;
            g.DrawString($"Order Date: {_order.OrderDate.ToString("yyyy-MM-dd HH:mm")}", _regularFont, Brushes.Black, leftMargin, yPos);
            yPos += _regularFont.GetHeight() + 10;

            // Order Items
            g.DrawString("Items:", _regularFont, Brushes.Black, leftMargin, yPos);
            yPos += _regularFont.GetHeight() + 5;

            foreach (OrderItem item in _order.OrderItems)
            {
                g.DrawString($"{item.Book.Title} ({item.Quantity} x LKR {item.Price:F2})", _smallFont, Brushes.Black, leftMargin, yPos);
                yPos += _smallFont.GetHeight() + 3;
                g.DrawString($"Subtotal: LKR {item.Quantity * item.Price:F2}", _smallFont, Brushes.Black, leftMargin + 20, yPos);
                yPos += _smallFont.GetHeight() + 5;
            }

            // Payment Details
            g.DrawString($"Discount: LKR {_order.Discount:F2}", _regularFont, Brushes.Black, leftMargin, yPos);
            yPos += _regularFont.GetHeight() + 5;
            g.DrawString($"Total: LKR {(_order.OrderItems.Sum(oi => oi.Quantity * oi.Price) - _order.Discount):F2}", _regularFont, Brushes.Black, leftMargin, yPos);
            yPos += _regularFont.GetHeight() + 5;
            g.DrawString($"Payment Status: {_order.PaymentStatus}", _regularFont, Brushes.Black, leftMargin, yPos);
            yPos += _regularFont.GetHeight() + 5;
            g.DrawString($"Delivery Status: {_order.DeliveryStatus}", _regularFont, Brushes.Black, leftMargin, yPos);
            yPos += _regularFont.GetHeight() + 10;

            // Footer
            g.DrawString("Thank you for your purchase!", _regularFont, Brushes.Black, leftMargin, yPos);
        }
    }
}
