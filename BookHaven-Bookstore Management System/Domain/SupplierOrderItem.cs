using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHaven_Bookstore_Management_System.Domain
{
    public class SupplierOrderItem
    {
        [Key]
        public int SupplierOrderItemID { get; set; }

        [ForeignKey("SupplierOrder")]
        public int SupplierOrderID { get; set; }

        public SupplierOrder SupplierOrder { get; set; }

        [ForeignKey("Book")]
        public int BookID { get; set; }

        public Book Book { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        [Column(TypeName = "decimal(10, 2)")]
        public decimal Price { get; set; }
    }
}
