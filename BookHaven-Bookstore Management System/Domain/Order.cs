using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookHaven_Bookstore_Management_System.Domain.Enums;

namespace BookHaven_Bookstore_Management_System.Domain
{
    public class Order
    {
        [Key]
        public int OrderID { get; set; }

        [ForeignKey("Customer")]
        public int CustomerID { get; set; }

        public Customer Customer { get; set; }

        [Required]
        public DateTime OrderDate { get; set; }

        [Required]
        [Column(TypeName = "decimal(10, 2)")]
        public decimal TotalAmount { get; set; }

        [MaxLength(20)]
        public PaymentStatus PaymentStatus { get; set; }

        [MaxLength(255)]
        public string DeliveryAddress { get; set; }

        public List<OrderItem> OrderItems { get; set; }

        // Add the Discount property
        [Column(TypeName = "decimal(10, 2)")]
        public decimal Discount { get; set; }

        // Add Delivery Status Property
        public DeliveryStatus DeliveryStatus { get; set; }
    }
}