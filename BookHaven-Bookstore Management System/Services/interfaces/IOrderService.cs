using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookHaven_Bookstore_Management_System.Domain;
using BookHaven_Bookstore_Management_System.Domain.Enums;

namespace BookHaven_Bookstore_Management_System.Services.interfaces
{
    public interface IOrderService
    {
        Order GetOrderById(int orderId);
        List<Order> GetAllOrders();
        void AddOrder(Order order);
        void UpdateOrder(Order order);
        void DeleteOrder(int orderId);
        List<Order> GetOrdersByCustomerId(int customerId);
        Order CreateOrder(int customerId, List<OrderItem> orderItems, string deliveryAddress, decimal discount, PaymentStatus paymentStatus);
    }
}
