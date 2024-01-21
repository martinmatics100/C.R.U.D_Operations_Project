using MediConnect.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediConnect.Data.Entities
{
    public class Orders
    {
        public string OrderID { get; set; }
        public string UserID { get; set; }
        public string OrderNo { get; set; }
        public decimal OrderTotal { get; set; }
        public Status OrderStatus { get; set; }
    }
}
