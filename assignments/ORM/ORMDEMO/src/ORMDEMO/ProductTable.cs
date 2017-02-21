using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ORMDEMO
{
    public class ProductTable
    {
        [Key]
        public int PID { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription {get; set;}
        public string HomePageUrl { get; set; }
        public List<UpdateTable> UpdateTable { get; set; }
    }
}
