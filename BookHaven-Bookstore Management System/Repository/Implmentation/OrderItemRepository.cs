using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookHaven_Bookstore_Management_System.Domain;
using BookHaven_Bookstore_Management_System.Repository.Interfaces;
using BookHaven_Bookstore_Management_System.Utils;
using Microsoft.EntityFrameworkCore;

namespace BookHaven_Bookstore_Management_System.Repository.Implmentation
{
    public class OrderItemRepository: IOrderItemRepository
    {
        private readonly BookHavenDbContext _context;

        public OrderItemRepository(BookHavenDbContext context)
        {
            _context = context;
        }
        public List<OrderItem> GetOrderItemsByOrderId(int orderId) { return _context.OrderItems.Where(oi => oi.OrderID == orderId).ToList(); }

        public OrderItem GetOrderItemById(int orderItemId) => _context.OrderItems.Find(orderItemId);
        public List<OrderItem> GetAllOrderItems() => _context.OrderItems.ToList();
        public void AddOrderItem(OrderItem orderItem)
        {
            _context.OrderItems.Add(orderItem);
            _context.SaveChanges(); 
        }
        public List<OrderItem> GetOrderItemsWithBooksByOrderId(int orderId) { return _context.OrderItems.Where(oi => oi.OrderID == orderId).Include(oi => oi.Book).ToList(); }
        public void RemoveOrderItem(OrderItem orderItem) { _context.OrderItems.Remove(orderItem); _context.SaveChanges(); }
        public void UpdateOrderItem(OrderItem orderItem) { _context.OrderItems.Update(orderItem); _context.SaveChanges(); }
        public void DeleteOrderItem(int orderItemId) { var orderItem = _context.OrderItems.Find(orderItemId); if (orderItem != null) { _context.OrderItems.Remove(orderItem); _context.SaveChanges(); } }
    }
}
