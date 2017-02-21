using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ORMDEMO
{
    public class UpdateTable
    {
        [Key]
        [Required]
        public int UpdateID { get; set; }
        public string UpdateName { get; set; }
        public string UpdateDescription {get; set;}
        public int PID { get; set; }
        [ForeignKey("PID")]
        public ProductTable ProductTable { get; set; }

    }
}
