using System;
using System.Collections.Generic;

namespace _11StudentMVCDemo.Models
{
    public partial class Course
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int? Duration { get; set; }
        public string? Summery { get; set; }
    }
}
