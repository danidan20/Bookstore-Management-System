using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookHaven_Bookstore_Management_System.Domain;

namespace BookHaven_Bookstore_Management_System.Repository.Interfaces
{
    public interface ISupplierOrderRepository
    {
        SupplierOrder GetById(int id);
        List<SupplierOrderItem> GetOrderItemsByOrderId(int orderId);
        SupplierOrder GetSupplierOrderById(int supplierOrderId);
        List<SupplierOrder> GetAllSupplierOrders();
        void AddSupplierOrder(SupplierOrder supplierOrder);
        void UpdateSupplierOrder(SupplierOrder supplierOrder);
        void DeleteSupplierOrder(int supplierOrderId);
        SupplierOrder GetSupplierOrderWithItemsAndBooks(int orderId);
    }
}
