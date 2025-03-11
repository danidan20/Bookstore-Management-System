using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookHaven_Bookstore_Management_System.Domain;

namespace BookHaven_Bookstore_Management_System.Repository.Interfaces
{
    public interface IOrderItemRepository
    {
        OrderItem GetOrderItemById(int orderItemId);
        List<OrderItem> GetAllOrderItems();
        void AddOrderItem(OrderItem orderItem);
        void UpdateOrderItem(OrderItem orderItem);
        List<OrderItem> GetOrderItemsByOrderId(int orderId);
        void DeleteOrderItem(int orderItemId);
        void RemoveOrderItem(OrderItem orderItem);
        List<OrderItem> GetOrderItemsWithBooksByOrderId(int orderId);
    }
}
