using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _05CRUDDemo.Models
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
