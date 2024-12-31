using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _09_CurdMvc.Model
{

    [Table("Employeess")]
    public class Employee
    {
        [Key] 

        public int EID { get; set; }
        public string Ename { get; set; }
        public  string EAddress { get; set; }

    }
}
