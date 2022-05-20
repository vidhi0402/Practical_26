using System;
using System.Collections.Generic;

namespace Practical_26.Models
{
    public partial class City
    {
        public int CityId { get; set; }
        public string CityName { get; set; } = null!;
        public string Country { get; set; } = null!;
        public string? State { get; set; }
    }
}
