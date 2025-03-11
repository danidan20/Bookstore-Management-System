using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookHaven_Bookstore_Management_System.Domain;

namespace BookHaven_Bookstore_Management_System.Repository.Interfaces
{
    public interface ISupplierOrderItemRepository
    {
        SupplierOrderItem GetById(int id);
        List<SupplierOrderItem> GetAll();
        List<SupplierOrderItem> GetByOrderId(int orderId);
        void Add(SupplierOrderItem item);
        void Update(SupplierOrderItem item);
        void Delete(int id);
        List<SupplierOrderItem> GetAllSupplierOrderItemsBySupplierId(int supplierId);
        List<SupplierOrderItem> GetSupplierOrderItemsByOrderId(int orderId);
    }
}
