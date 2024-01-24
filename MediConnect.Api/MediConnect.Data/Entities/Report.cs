using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediConnect.Data.Entities
{
    public class Report
    {
        [Key]
        public string ReportID { get; set; }
        public string AdminID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
    }
}
