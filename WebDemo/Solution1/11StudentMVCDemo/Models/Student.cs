using System;
using System.Collections.Generic;

namespace _11StudentMVCDemo.Models
{
    public partial class Student
    {
        public Student()
        {
            StudentPhones = new HashSet<StudentPhone>();
        }

        public int Id { get; set; }
        public string? Namefirst { get; set; }
        public string? Namelast { get; set; }
        public DateTime? Dob { get; set; }
        public string? EmailId { get; set; }

        public virtual StudentAddress? StudentAddress { get; set; }
        public virtual ICollection<StudentPhone> StudentPhones { get; set; }
    }
}
