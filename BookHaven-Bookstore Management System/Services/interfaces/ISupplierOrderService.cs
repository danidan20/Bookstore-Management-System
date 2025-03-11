using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookHaven_Bookstore_Management_System.Domain;

namespace BookHaven_Bookstore_Management_System.Services.interfaces
{
    public interface ISupplierOrderService
    {
        SupplierOrder GetSupplierOrderById(int supplierOrderId);
        List<SupplierOrder> GetAllSupplierOrders();
        void CreateSupplierOrder(SupplierOrder supplierOrder, List<SupplierOrderItem> orderItems);
        void UpdateSupplierOrder(SupplierOrder supplierOrder);
        void DeleteSupplierOrder(int supplierOrderId);
        void ReceiveOrder(int orderId);
    }
}
