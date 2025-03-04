using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHaven_Bookstore_Management_System.Domain
{
    public class User
    {
        [Key] 
        public int UserID { get; set; }

        [Required]
        [MaxLength(50)]
        public string Username { get; set; }

        [Required]
        [MaxLength(255)]
        public string PasswordHash { get; set; }

        [Required]
        public Role Role { get; set; }

        [MaxLength(100)]
        public string RealName { get; set; }
        
        [MaxLength(255)]
        public string Email { get; set; }
    }
}
