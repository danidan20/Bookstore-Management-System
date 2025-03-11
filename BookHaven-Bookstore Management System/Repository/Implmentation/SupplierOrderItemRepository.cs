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
    public class SupplierOrderItemRepository : ISupplierOrderItemRepository
    {
        private readonly BookHavenDbContext _dbContext;

        public SupplierOrderItemRepository(BookHavenDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public SupplierOrderItem GetById(int id)
        {
            return _dbContext.SupplierOrderItems.Find(id);
        }

        public List<SupplierOrderItem> GetAll()
        {
            return _dbContext.SupplierOrderItems.ToList();
        }
        public List<SupplierOrderItem> GetAllSupplierOrderItemsBySupplierId(int supplierId)
        {
            return _dbContext.SupplierOrderItems
                .Where(item => item.SupplierOrder.SupplierID == supplierId)
                .Include(item => item.Book)
                .Include(item => item.SupplierOrder)
                .ToList();
        }
        public List<SupplierOrderItem> GetSupplierOrderItemsByOrderId(int orderId)
        {
            return _dbContext.SupplierOrderItems
                .Where(item => item.SupplierOrderID == orderId)
                //.Include(item => item.Book)
                .ToList();
        }

        public List<SupplierOrderItem> GetByOrderId(int orderId)
        {
            return _dbContext.SupplierOrderItems.Where(item => item.SupplierOrderID == orderId).ToList();
        }

        public void Add(SupplierOrderItem item)
        {
            _dbContext.SupplierOrderItems.Add(item);
            _dbContext.SaveChanges();
        }

        public void Update(SupplierOrderItem item)
        {
            _dbContext.SupplierOrderItems.Update(item);
            _dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var item = _dbContext.SupplierOrderItems.Find(id);
            if (item != null)
            {
                _dbContext.SupplierOrderItems.Remove(item);
                _dbContext.SaveChanges();
            }
        }
    }
}
