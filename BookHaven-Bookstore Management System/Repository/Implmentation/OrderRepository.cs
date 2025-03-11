using System;
using System.Collections.Generic;
using System.Linq;
using BookHaven_Bookstore_Management_System.Domain;
using BookHaven_Bookstore_Management_System.Repository.Interfaces;
using BookHaven_Bookstore_Management_System.Utils;
using Microsoft.EntityFrameworkCore;

namespace BookHaven_Bookstore_Management_System.Repository.Implmentation
{
    public class OrderRepository : IOrderRepository
    {
        private readonly BookHavenDbContext _context;

        public OrderRepository(BookHavenDbContext context)
        {
            _context = context;
        }

        public Order GetOrderById(int orderId)
        {
            return _context.Orders
                .Include(o => o.OrderItems)
                .ThenInclude(oi => oi.Book)
                .Include(o => o.Customer)
                .FirstOrDefault(o => o.OrderID == orderId);
        }

        public List<Order> GetAllOrders() => _context.Orders.Include(o => o.Customer).ToList();

        public void AddOrder(Order order)
        {
            _context.Orders.Add(order);
            _context.SaveChanges();
        }

        public void UpdateOrder(Order order)
        {
            _context.Orders.Update(order);
            _context.SaveChanges();
        }

        public void DeleteOrder(int orderId)
        {
            var order = _context.Orders.Find(orderId);
            if (order != null)
            {
                _context.Orders.Remove(order);
                _context.SaveChanges();
            }
        }

        public List<Order> GetOrdersByCustomerId(int customerId) => _context.Orders.Where(o => o.CustomerID == customerId).ToList();
    }
}