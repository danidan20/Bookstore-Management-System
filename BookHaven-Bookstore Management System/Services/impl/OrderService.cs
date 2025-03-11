using System;
using System.Collections.Generic;
using System.Linq;
using BookHaven_Bookstore_Management_System.Domain;
using BookHaven_Bookstore_Management_System.Domain.Enums;
using BookHaven_Bookstore_Management_System.Repository.Implmentation;
using BookHaven_Bookstore_Management_System.Repository.Interfaces;
using BookHaven_Bookstore_Management_System.Services.interfaces;

namespace BookHaven_Bookstore_Management_System.Services.impl
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IOrderItemRepository _orderItemRepository;
        private readonly IBookRepository _bookRepository;

        public OrderService(IOrderRepository orderRepository, IOrderItemRepository orderItemRepository, IBookRepository bookRepository)
        {
            _orderRepository = orderRepository;
            _orderItemRepository = orderItemRepository;
            _bookRepository = bookRepository;
        }

        public Order GetOrderById(int orderId) => _orderRepository.GetOrderById(orderId);
        public List<Order> GetAllOrders() => _orderRepository.GetAllOrders();
        public void AddOrder(Order order) => _orderRepository.AddOrder(order);
        public void UpdateOrder(Order order)
        {
            _orderRepository.UpdateOrder(order);

            foreach (var orderItem in order.OrderItems)
            {
                if (orderItem.OrderItemID == 0)
                {
                    _orderItemRepository.AddOrderItem(orderItem); 
                }
                else
                {
                    _orderItemRepository.UpdateOrderItem(orderItem);
                }
            }

            var existingOrderItems = _orderItemRepository.GetOrderItemsByOrderId(order.OrderID);

            var itemsToRemove = existingOrderItems
                .Where(existingItem => !order.OrderItems.Any(updatedItem => updatedItem.OrderItemID == existingItem.OrderItemID))
                .ToList();
            foreach (var itemToRemove in itemsToRemove)
            {
                _orderItemRepository.RemoveOrderItem(itemToRemove);
            }
        }
        public void DeleteOrder(int orderId) => _orderRepository.DeleteOrder(orderId);
        public List<Order> GetOrdersByCustomerId(int customerId) => _orderRepository.GetOrdersByCustomerId(customerId);

        public Order CreateOrder(int customerId, List<OrderItem> orderItems, string deliveryAddress, decimal discount = 0, PaymentStatus paymentStatus = PaymentStatus.Pending)
        {
            decimal subtotal = orderItems.Sum(oi => oi.Price * oi.Quantity);
            decimal totalAmount = subtotal - discount;

            var order = new Order
            {
                CustomerID = customerId,
                OrderDate = DateTime.Now,
                TotalAmount = totalAmount,
                PaymentStatus = paymentStatus, // Set PaymentStatus
                DeliveryAddress = deliveryAddress,
                Discount = discount,
                DeliveryStatus = DeliveryStatus.DELIVERY // Default Delivery Status
            };

            _orderRepository.AddOrder(order);

            foreach (var item in orderItems)
            {
                item.OrderID = order.OrderID;
                _orderItemRepository.AddOrderItem(item);

                var book = _bookRepository.GetBookById(item.BookID);
                book.StockQuantity -= item.Quantity;
                _bookRepository.UpdateBook(book);
            }
            return order;
        }

        public void UpdateOrder(Order order, decimal discount)
        {
            order.Discount = discount;
            _orderRepository.UpdateOrder(order);
        }

        public void UpdateOrder(Order order, DeliveryStatus deliveryStatus)
        {
            order.DeliveryStatus = deliveryStatus;
            _orderRepository.UpdateOrder(order);
        }

        public void UpdateOrder(Order order, PaymentStatus paymentStatus) // New overload
        {
            order.PaymentStatus = paymentStatus;
            _orderRepository.UpdateOrder(order);
        }

        public void UpdateOrder(Order order, decimal discount, DeliveryStatus deliveryStatus)
        {
            order.Discount = discount;
            order.DeliveryStatus = deliveryStatus;
            _orderRepository.UpdateOrder(order);
        }

        public void UpdateOrder(Order order, decimal discount, PaymentStatus paymentStatus) // New overload
        {
            order.Discount = discount;
            order.PaymentStatus = paymentStatus;
            _orderRepository.UpdateOrder(order);
        }

        public void UpdateOrder(Order order, DeliveryStatus deliveryStatus, PaymentStatus paymentStatus) // New overload
        {
            order.DeliveryStatus = deliveryStatus;
            order.PaymentStatus = paymentStatus;
            _orderRepository.UpdateOrder(order);
        }

        public void UpdateOrder(Order order, decimal discount, DeliveryStatus deliveryStatus, PaymentStatus paymentStatus) // New overload
        {
            order.Discount = discount;
            order.DeliveryStatus = deliveryStatus;
            order.PaymentStatus = paymentStatus;
            _orderRepository.UpdateOrder(order);
        }
    }
}