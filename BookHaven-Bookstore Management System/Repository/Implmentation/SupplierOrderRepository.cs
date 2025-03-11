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
    public class SupplierOrderRepository : ISupplierOrderRepository
    {
        private readonly BookHavenDbContext _context;

        public SupplierOrderRepository(BookHavenDbContext context)
        {
            _context = context;
        }

        public SupplierOrder GetSupplierOrderWithItemsAndBooks(int orderId)
        {
            return _context.SupplierOrders
                .Include(so => so.SupplierOrderItems)
                .ThenInclude(soi => soi.Book)
                .FirstOrDefault(so => so.SupplierOrderID == orderId);
        }

        public SupplierOrder GetSupplierOrderById(int supplierOrderId)
        {
            return _context.SupplierOrders.Find(supplierOrderId);
        }

        public List<SupplierOrder> GetAllSupplierOrders()
        {
            return _context.SupplierOrders.ToList();
        }

        public void AddSupplierOrder(SupplierOrder supplierOrder)
        {
            _context.SupplierOrders.Add(supplierOrder);
            _context.SaveChanges();
        }

        public void UpdateSupplierOrder(SupplierOrder supplierOrder)
        {
            _context.SupplierOrders.Update(supplierOrder);
            _context.SaveChanges();
        }

        public void DeleteSupplierOrder(int supplierOrderId)
        {
            var supplierOrder = _context.SupplierOrders.Find(supplierOrderId);
            if (supplierOrder != null)
            {
                _context.SupplierOrders.Remove(supplierOrder);
                _context.SaveChanges();
            }
        }

        public SupplierOrder GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<SupplierOrderItem> GetOrderItemsByOrderId(int orderId)
        {
            throw new NotImplementedException();
        }
    }
}
