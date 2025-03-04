using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHaven_Bookstore_Management_System.Domain
{
    public class Order
    {
        [Key]
        public int OrderID { get; set; }

        [ForeignKey("Customer")]
        public int CustomerID { get; set; }

        public Customer Customer { get; set; } // Navigation property

        [Required]
        public DateTime OrderDate { get; set; }

        [Required]
        [Column(TypeName = "decimal(10, 2)")]
        public decimal TotalAmount { get; set; }

        [MaxLength(20)]
        public string OrderStatus { get; set; } // Placed, Shipped, Delivered, PickedUp

        [MaxLength(255)]
        public string DeliveryAddress { get; set; }

        public List<OrderItem> OrderItems { get; set; } // Navigation property
    }
}
