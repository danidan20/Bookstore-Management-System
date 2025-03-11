using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using BookHaven_Bookstore_Management_System.Domain;
using BookHaven_Bookstore_Management_System.Repository.Implmentation;
using BookHaven_Bookstore_Management_System.Repository.Interfaces;
using BookHaven_Bookstore_Management_System.Services.interfaces;
using Microsoft.EntityFrameworkCore;

namespace BookHaven_Bookstore_Management_System.Services.impl
{
    public class SupplierOrderService : ISupplierOrderService
    {
        private readonly ISupplierOrderRepository _supplierOrderRepository;
        private readonly IBookRepository _bookRepository;
        private readonly ISupplierOrderItemRepository _supplierOrderItemRepository;

        public SupplierOrderService(ISupplierOrderRepository supplierOrderRepository, IBookRepository bookRepository, ISupplierOrderItemRepository supplierOrderItemRepository)
        {
            _supplierOrderRepository = supplierOrderRepository;
            _bookRepository = bookRepository;
            _supplierOrderItemRepository = supplierOrderItemRepository;
        }
        public SupplierOrder GetSupplierOrderById(int supplierOrderId)
        {
            return _supplierOrderRepository.GetSupplierOrderById(supplierOrderId);
        }

        public List<SupplierOrder> GetAllSupplierOrders()
        {
            return _supplierOrderRepository.GetAllSupplierOrders();
        }
        public void ReceiveOrder(int orderId)
        {
            var order = _supplierOrderRepository.GetSupplierOrderWithItemsAndBooks(orderId);

            if (order == null)
            {
                throw new ArgumentException($"Supplier order with ID {orderId} not found.");
            }

            if (order.OrderStatus != "Received")
            {
                throw new InvalidOperationException($"Supplier order with ID {orderId} is not in a 'Pending' state.");
            }

            order.OrderStatus = "Received";
            _supplierOrderRepository.UpdateSupplierOrder(order);

            foreach (var item in order.SupplierOrderItems)
            {
                var book = _bookRepository.GetBookById(item.BookID);

                if (book != null)
                {
                    book.StockQuantity += item.Quantity;
                    _bookRepository.UpdateBook(book);
                }
                else
                {
                    Console.WriteLine($"Warning: Book is null for SupplierOrderItemID: {item.SupplierOrderItemID}");
                }
            }
        }
        public void CreateSupplierOrder(SupplierOrder supplierOrder, List<SupplierOrderItem> orderItems)
        {
            _supplierOrderRepository.AddSupplierOrder(supplierOrder);
            foreach (var item in orderItems)
            {
                item.SupplierOrderID = supplierOrder.SupplierOrderID; 
                _supplierOrderItemRepository.Add(item);
            }
        }

        public void UpdateSupplierOrder(SupplierOrder supplierOrder)
        {
            _supplierOrderRepository.UpdateSupplierOrder(supplierOrder);
        }

        public void DeleteSupplierOrder(int supplierOrderId)
        {
            _supplierOrderRepository.DeleteSupplierOrder(supplierOrderId);
        }
    }
}
