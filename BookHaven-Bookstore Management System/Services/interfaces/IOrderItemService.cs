using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookHaven_Bookstore_Management_System.Domain;

namespace BookHaven_Bookstore_Management_System.Services.interfaces
{
    public interface IOrderItemService
    {
        OrderItem GetOrderItemById(int orderItemId);
        List<OrderItem> GetAllOrderItems();
        void AddOrderItem(OrderItem orderItem);
        void UpdateOrderItem(OrderItem orderItem);
        void DeleteOrderItem(int orderItemId);
        List<OrderItem> GetOrderItemsByOrderId(int orderId);
        List<OrderItem> GetOrderItemsWithBooksByOrderId(int orderId);
    }
}
