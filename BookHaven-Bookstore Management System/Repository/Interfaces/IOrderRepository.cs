using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookHaven_Bookstore_Management_System.Domain;

namespace BookHaven_Bookstore_Management_System.Repository.Interfaces
{
    public interface IOrderRepository
    {
        Order GetOrderById(int orderId);
        List<Order> GetAllOrders();
        void AddOrder(Order order);
        void UpdateOrder(Order order);
        void DeleteOrder(int orderId);
        List<Order> GetOrdersByCustomerId(int customerId);
    }
}
