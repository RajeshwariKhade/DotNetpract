using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace _10DemoAPI.Models
{
    public partial class StudentPhone
    {
        public int Id { get; set; }
        public int? StudentId { get; set; }
        public string? Number { get; set; }
        public bool? IsActive { get; set; }

        [JsonIgnore]
        public virtual Student? Student { get; set; }
    }
}
