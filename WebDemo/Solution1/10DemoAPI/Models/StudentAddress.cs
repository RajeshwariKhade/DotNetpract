using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace _10DemoAPI.Models
{
    public partial class StudentAddress
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public string Address { get; set; } = null!;

        [JsonIgnore]
        public virtual Student Student { get; set; } = null!;
    }
}
