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
    public class OrderItemService: IOrderItemService
    {
        private readonly IOrderItemRepository _orderItemRepository;

        public OrderItemService(IOrderItemRepository orderItemRepository)
        {
            _orderItemRepository = orderItemRepository;
        }
        public List<OrderItem> GetOrderItemsWithBooksByOrderId(int orderId) { return _orderItemRepository.GetOrderItemsWithBooksByOrderId(orderId); }
        public OrderItem GetOrderItemById(int orderItemId)
        {
            return _orderItemRepository.GetOrderItemById(orderItemId);
        }

        public List<OrderItem> GetAllOrderItems()
        {
            return _orderItemRepository.GetAllOrderItems();
        }

        public void AddOrderItem(OrderItem orderItem)
        {
            _orderItemRepository.AddOrderItem(orderItem);
        }

        public void UpdateOrderItem(OrderItem orderItem)
        {
            _orderItemRepository.UpdateOrderItem(orderItem);
        }

        public void DeleteOrderItem(int orderItemId)
        {
            _orderItemRepository.DeleteOrderItem(orderItemId);
        }

        public List<OrderItem> GetOrderItemsByOrderId(int orderId)
        {
            return _orderItemRepository.GetOrderItemsByOrderId(orderId);
        }
    }
}
