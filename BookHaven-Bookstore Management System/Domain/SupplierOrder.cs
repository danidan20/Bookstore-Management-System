using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHaven_Bookstore_Management_System.Domain
{
    public class SupplierOrder
    {
        [Key]
        public int SupplierOrderID { get; set; }

        [ForeignKey("Supplier")]
        public int SupplierID { get; set; }

        public Supplier Supplier { get; set; }

        [Required]
        public DateTime OrderDate { get; set; }

        [MaxLength(20)]
        public string OrderStatus { get; set; }

        public List<SupplierOrderItem> SupplierOrderItems { get; set; }
    }
}
