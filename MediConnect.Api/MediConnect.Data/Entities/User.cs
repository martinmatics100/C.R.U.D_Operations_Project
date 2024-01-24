using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediConnect.Data.Entities
{
    public class User
    {
        [Key]
        public string UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public decimal Fund { get; set; }
        public decimal Amount { get; set; }
        public string Type { get; set; }
        public int Status { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
