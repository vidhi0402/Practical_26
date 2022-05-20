using System;
using System.Collections.Generic;

namespace Practical_26.Models
{
    public partial class Student
    {
        public int UserId { get; set; }
        public string UserName { get; set; } = null!;
        public string? EmailAddress { get; set; }
    }
}
