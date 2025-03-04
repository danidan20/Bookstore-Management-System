using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHaven_Bookstore_Management_System.Domain
{
    public class Supplier
    {
        [Key]
        public int SupplierID { get; set; }

        [Required]
        [MaxLength(100)]
        public string SupplierName { get; set; }

        [MaxLength(255)]
        public string ContactInfo { get; set; }

        public List<SupplierOrder> SupplierOrders { get; set; }
    }
}
