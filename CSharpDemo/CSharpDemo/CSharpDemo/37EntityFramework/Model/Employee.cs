using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37EntityFramework.Model
{
    [Table("Employees")]
    public class Employee
    {
        [Key]
        public int EId { get; set; }
        public string EName { get; set; }
        public string EAddress { get; set; }
    }
}
