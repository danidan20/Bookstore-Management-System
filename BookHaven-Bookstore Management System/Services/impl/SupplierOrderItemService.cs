using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookHaven_Bookstore_Management_System.Domain;
using BookHaven_Bookstore_Management_System.Repository.Interfaces;
using BookHaven_Bookstore_Management_System.Services.interfaces;

namespace BookHaven_Bookstore_Management_System.Services.impl
{
    public class SupplierOrderItemService : ISupplierOrderItemService
    {
        private readonly ISupplierOrderItemRepository _supplierOrderItemRepository;

        public SupplierOrderItemService(ISupplierOrderItemRepository supplierOrderItemRepository)
        {
            _supplierOrderItemRepository = supplierOrderItemRepository;
        }

        public SupplierOrderItem GetSupplierOrderItemById(int id)
        {
            return _supplierOrderItemRepository.GetById(id);
        }

        public List<SupplierOrderItem> GetAllSupplierOrderItemsBySupplierId(int supplierId)
        {
            return _supplierOrderItemRepository.GetAllSupplierOrderItemsBySupplierId(supplierId);
        }

        public List<SupplierOrderItem> GetSupplierOrderItemsByOrderId(int orderId)
        {
            return _supplierOrderItemRepository.GetSupplierOrderItemsByOrderId(orderId);
        }

        public List<SupplierOrderItem> GetAllSupplierOrderItems()
        {
            return _supplierOrderItemRepository.GetAll();
        }


        public void AddSupplierOrderItem(SupplierOrderItem item)
        {
            _supplierOrderItemRepository.Add(item);
        }

        public void UpdateSupplierOrderItem(SupplierOrderItem item)
        {
            _supplierOrderItemRepository.Update(item);
        }

        public void DeleteSupplierOrderItem(int id)
        {
            _supplierOrderItemRepository.Delete(id);
        }
    }
}
