using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediConnect.Data.Entities
{
    public class Cart
    {
        public string CartId { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Discount { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }

        public string UserID { get; set; }
        public Users User { get; set; }
        public string OrderID { get; set; }
        public Orders Order { get; set; }
        public string MdecineID { get; set; }
        public Medicines Medicine { get; set; }
    }
}
