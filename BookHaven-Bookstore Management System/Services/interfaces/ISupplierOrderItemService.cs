using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookHaven_Bookstore_Management_System.Domain;

namespace BookHaven_Bookstore_Management_System.Services.interfaces
{
    public interface ISupplierOrderItemService
    {
        SupplierOrderItem GetSupplierOrderItemById(int id);
        List<SupplierOrderItem> GetAllSupplierOrderItems();
        List<SupplierOrderItem> GetSupplierOrderItemsByOrderId(int orderId);
        void AddSupplierOrderItem(SupplierOrderItem item);
        void UpdateSupplierOrderItem(SupplierOrderItem item);
        void DeleteSupplierOrderItem(int id);
    }
}
